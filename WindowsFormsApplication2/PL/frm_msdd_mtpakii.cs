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
    public partial class frm_msdd_mtpakii : Form
    {
        BL.cls_orders order = new BL.cls_orders();
        public string okatabio = "doesn't exist in new order";
        public frm_msdd_mtpakii()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmsdd_TextChanged(object sender, EventArgs e)
        {
            if (txtmsdd.Text!=string.Empty)
            {
                try
                {
                    txtmtpakii.Text = (Convert.ToDouble(txttotal.Text) - Convert.ToDouble(txtmsdd.Text)).ToString();

                }
                catch (Exception)
                {
                    
                   // throw;
                }

            }
        }

        private void txtmtpakii_TextChanged(object sender, EventArgs e)
        {
            if (txtmtpakii.Text!=string.Empty)
            {
                txtmsdd.Text = (Convert.ToDouble(txttotal.Text) - Convert.ToDouble(txtmtpakii.Text)).ToString();

            }

        }

        private void radioButton_5ales_CheckedChanged(object sender, EventArgs e)
        {
            txtmsdd.Text = txttotal.Text;
            txtmtpakii.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  if (Convert.ToDouble(txtmtpakii.Text)<0||Convert.ToDouble(txtmsdd.Text)<0)
            {
                MessageBox.Show("عذرا لا يمكن ادخال رقم سالب","تحقق من المبالغ ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/
            
            if (MessageBox.Show("هل تريد حفظ التغيرات؟؟","عمليه التعديل",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                order.update_msdd_mtpakii(textBox1.Text, txtmsdd.Text, txtmtpakii.Text);
                if (okatabio=="exist")
                {
                    order.update_msdd_mtpakii_in_new_orders(textBox1.Text, txtmsdd.Text, txtmtpakii.Text);
                    MessageBox.Show("تم التعديل بنجاح","عمليه التعديل",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                

            }
            else
            {
                return;
            }

            frm_view_order.getmainform.dataGridView2.DataSource = order.get_price_msdd(textBox1.Text);
            frm_view_order.getmainform.dataGridView3.DataSource = order.get_price_mtbkii(textBox1.Text);
            

        }

        private void frm_msdd_mtpakii_Load(object sender, EventArgs e)
        {

        }

        private void frm_msdd_mtpakii_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
