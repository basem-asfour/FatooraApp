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
    public partial class frm_single_cstmr_pay : Form
    {
        BL.cls_cstmrs cstmr = new BL.cls_cstmrs();
        public frm_single_cstmr_pay()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
             int id = 0;
            if (!string.IsNullOrEmpty(textBox1.Text) && int.TryParse(textBox1.Text, out id))
            {
                dataGridView1.DataSource = cstmr.Get_single_cstmr_pay_by_id(id);
            }
        }
    }
}
