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
    public partial class frm_change_order_date : Form
    {
        BL.cls_orders order = new BL.cls_orders();
        public int id_order = 0;
        public bool changed = false;
        public frm_change_order_date()
        {
            InitializeComponent();
            dateTimePicker1.Value = dateTimePicker2.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changed = false;
            this.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            order.Edit_order_Date(id_order, dateTimePicker2.Text,dateTimePicker1.Value);
            changed = true ;
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker2.Value;
        }
    }
}
