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
    public partial class frm_add_user : Form
    {

        public frm_add_user()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtid.Text==string.Empty||txtpsrd.Text==string.Empty||txtpsrdconfirm.Text==string.Empty||txttotalname.Text==string.Empty)
            {
                MessageBox.Show(" من فضلك ادخل كامل بيانات المستخدم", "missing data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtpsrd.Text != txtpsrdconfirm.Text)
            {
                MessageBox.Show("كلمتي الباسورد غير متطابقه", "تاكيد الباسورد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
                if (btnadd.Text=="اضافة")
                {
                    
                
                PL.cls_login user = new PL.cls_login();
                user.add_users(txtid.Text, txtpsrd.Text, txttotalname.Text);
                MessageBox.Show("تم اضافه المستخدم بنجاح ", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                            
                    else if (btnadd.Text=="تعديل")
            	{
                    PL.cls_login user = new PL.cls_login();
                    user.update_users(txtid.Text, txtpsrd.Text, txttotalname.Text);
                    MessageBox.Show("تم تعديل بيانات المستخدم بنجاح ", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            	}
                txtid.Clear();
                txtpsrd.Clear();
                txtpsrdconfirm.Clear();
                txttotalname.Clear();
                txtid.Focus();
            
        }

        private void txtpsrdconfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpsrdconfirm_Validated(object sender, EventArgs e)
        {
            if (txtpsrd.Text!=txtpsrdconfirm.Text)
            {
                MessageBox.Show("كلمتي الباسورد غير متطابقه", "تاكيد الباسورد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
