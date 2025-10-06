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
    public partial class frm_mwrdeen_list : Form
    {
        BL.cls_mwrdeen mwrd = new BL.cls_mwrdeen();
        public frm_mwrdeen_list()
        {
            InitializeComponent();
            dgvcstmrs.DataSource=mwrd.get_all_mwrdeen();
        }

        private void dgvcstmrs_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
