using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.PL
{
    public partial class frm_users : Form
    {
        PL.cls_login user = new PL.cls_login();

        public frm_users()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = user.search_users("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.frm_add_user frm = new frm_add_user();
            frm.ShowDialog();
            this.dataGridView1.DataSource = user.search_users("");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            PL.frm_add_user frm = new frm_add_user();
            frm.txtid.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //frm.txtpsrd.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //frm.txtpsrdconfirm.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txttotalname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

            frm.btnadd.Text = "تعديل";
            frm.ShowDialog();
            this.dataGridView1.DataSource = user.search_users("");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = user.search_users(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذا المستخدم ؟","عمليه الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                cls_login user = new cls_login();
                user.delete_users(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = user.search_users("");

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
