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
    public partial class frm_add_cstmr : Form
    {
        public string status;
        DataTable dt_mndob;
        BL.cls_mndobeen mndb = new BL.cls_mndobeen();
        public frm_add_cstmr()
        {
            InitializeComponent(); 
            dt_mndob = mndb.get_all_mndopeen();
            combo_mndb.DataSource = dt_mndob;
            combo_mndb.DisplayMember = "اسم المندوب";
            combo_mndb.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcstadrs.Text == string.Empty || txtcstnme.Text == string.Empty || txtcstpho.Text == string.Empty)
            {
                MessageBox.Show("برجاء ادخال البيانات كامله وفي حالة عدم معرفه بيان معين اكتب (غير معروف) ", "missing data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            BL.cls_cstmrs cstmr = new BL.cls_cstmrs();
            cstmr.ad_cstmr(txtcstnme.Text, txtcstpho.Text, txtcstadrs.Text, Convert.ToDouble(txtmax.Text),combo_mndb.Text);
            MessageBox.Show("تم اضافة العميل بنجاح", "عملية الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.dataGridView1.DataSource = cstmr.search_cstmrs("");
            //txtcstadrs.Text = string.Empty;
            //txtcstnme.Text = string.Empty;
            //txtcstpho.Text = string.Empty;
            status = "added";
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            status = "closed";
            this.Close();
        }
    }
}
