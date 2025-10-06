using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication2.PL
{
    public partial class frm_products_again : Form
    {
        BL.cls_products prd = new BL.cls_products();
        public string id;
        DAL.DATAaccesslayer dal = new DAL.DATAaccesslayer();
        public frm_products_again()
        {
            InitializeComponent();

            this.dgvprdcts.DataSource = prd.get_all_products();
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.searchproduct(textBox1.Text);
            this.dgvprdcts.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_add_product frm = new frm_add_product("");
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل تريد حذف الصنف", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                prd.deleteproduct(Convert.ToInt32(this.dgvprdcts.CurrentRow.Cells[0].Value));
                MessageBox.Show("تمت عمليه الحذف بنجاح", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.dgvprdcts.DataSource = prd.get_all_products();

            }
            else
            {
                MessageBox.Show("تم الغاء عمليه الحذف ", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            id = this.dgvprdcts.CurrentRow.Cells[0].Value.ToString();
            frm_add_product frm = new frm_add_product(id);
            frm.txtnme.Text = this.dgvprdcts.CurrentRow.Cells[1].Value.ToString();
            frm.txtqte.Text = this.dgvprdcts.CurrentRow.Cells[2].Value.ToString();
            frm.txtpshr.Text = this.dgvprdcts.CurrentRow.Cells[3].Value.ToString();
            frm.txtpg.Text = this.dgvprdcts.CurrentRow.Cells[4].Value.ToString();
            frm.txtpb.Text = this.dgvprdcts.CurrentRow.Cells[5].Value.ToString();
            frm.txtmsthlk.Text = this.dgvprdcts.CurrentRow.Cells[6].Value.ToString();
            frm.txttmd.Text = this.dgvprdcts.CurrentRow.Cells[7].Value.ToString();
            frm.Text = "تحديث بيانات الصنف:" + this.dgvprdcts.CurrentRow.Cells[1].Value.ToString();
            frm.btnok.Text = "تحديث";

            byte[] image = (byte[])prd.get_image_product(this.dgvprdcts.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pbox.Image = Image.FromStream(ms);

            frm.state = "update";
            frm.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frm_review frm = new frm_review();
            byte[] image = (byte[])prd.get_image_product(this.dgvprdcts.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void frm_products_again_Load(object sender, EventArgs e)
        {

        }
    }
}
