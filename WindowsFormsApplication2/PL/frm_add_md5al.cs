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
    public partial class frm_add_md5al : Form
    {
        public string state = "add";

        BL.cls_orders order = new BL.cls_orders();
        public frm_add_md5al()
        {
            InitializeComponent();
            dateTimePicker1.Value = System.DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (state=="add")
            {
                order.add_md5al(txtvalue.Text, dateTimePicker1.Text, txtdskrbshn.Text);
                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdskrbshn.Text = string.Empty;
                txtvalue.Text = string.Empty;
            }
            else
            {
                order.edit_md5al(Convert.ToInt32(label4.Text),txtvalue.Text,dateTimePicker1.Text,txtdskrbshn.Text);
                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }
    }
}
