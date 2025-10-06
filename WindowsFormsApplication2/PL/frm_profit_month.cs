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
    
    public partial class frm_profit_month : Form
    {
        BL.cls_elbank bnk = new BL.cls_elbank();
        public frm_profit_month()
        {
            InitializeComponent();
        }

        private void frm_profit_month_Load(object sender, EventArgs e)
        {
            bunifuDatepicker1.Format = DateTimePickerFormat.Custom;
            bunifuDatepicker1.FormatCustom = "MM/yyyy";
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string date = bunifuDatepicker1.Value.Month.ToString() + "/" + bunifuDatepicker1.Value.Year.ToString();
           // MessageBox.Show(date);
             dataGridView1.DataSource = bnk.Get_month_details(date);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
