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
    public partial class frm_edit_mndob : Form
    {
        DataTable dt_mndob;
        BL.cls_mndobeen mndb = new BL.cls_mndobeen();
            BL.cls_orders order =new BL.cls_orders();
            public int id_order = 0;
            public bool changed = false;
        public frm_edit_mndob()
        {
            InitializeComponent();

            dt_mndob = mndb.get_all_mndopeen();
            combo_mndoob.DataSource = dt_mndob;
            combo_mndoob.DisplayMember = "اسم المندوب";
            combo_mndoob.ValueMember = "id";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changed = false;
            Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            order.edit_order_mndob(id_order, Convert.ToInt32(combo_mndoob.SelectedValue));
            changed = true;
            this.Close();
        }
    }
}
