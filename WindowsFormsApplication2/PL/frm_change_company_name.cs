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
    public partial class frm_change_company_name : Form
    {
        public frm_change_company_name()
        {
            InitializeComponent();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Program.company_name = textBox1.Text;
                MessageBox.Show("عملية التعديل", "تم التحديث بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
