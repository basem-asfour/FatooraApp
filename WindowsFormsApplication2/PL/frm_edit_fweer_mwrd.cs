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
    public partial class frm_edit_fweer_mwrd : Form
    {
        BL.cls_mwrdeen mwrd = new BL.cls_mwrdeen();

        public frm_edit_fweer_mwrd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mwrd.edit_fwateer_mwrd(Convert.ToInt32( txtid.Text),txtnme.Text,txtdate.Text,txtvalye.Text,txtmsdd.Text,txtmtbaki.Text);
            MessageBox.Show("تم التعديل بنجاح ", "عملية التعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm_from_mwrdeen.getmainform.dataGridView_fwater.DataSource = mwrd.get_all_fwateer_mwrd(this.txtnme.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmsdd_TextChanged(object sender, EventArgs e)
        {
            if (txtvalye.Text != string.Empty && txtmsdd.Text != string.Empty)
            {
                txtmtbaki.Text = (Convert.ToDouble(txtvalye. Text) - Convert.ToDouble(txtmsdd.Text)).ToString();
            }
        }
    }
}
