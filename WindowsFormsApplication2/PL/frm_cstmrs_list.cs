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
    public partial class frm_cstmrs_list : Form
    {
        BL.cls_cstmrs cust = new BL.cls_cstmrs();
        public frm_cstmrs_list()
        {
            InitializeComponent();
            this.dgvcstmrs.DataSource = cust.get_all_cstmrs();
        }

        private void dgvcstmrs_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvcstmrs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dgvcstmrs.DataSource = cust.search_cstmrs(textBox1.Text);

        }
    }
}
