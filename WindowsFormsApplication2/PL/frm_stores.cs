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
    public partial class frm_stores : Form
    {
        BL.cls_stores store = new BL.cls_stores();
        BL.cls_products prd = new BL.cls_products();
        public frm_stores()
        {
            InitializeComponent();
            dgv_stores.DataSource = store.get_all_m5azen();
        }

        private void frm_stores_Load(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_store.Text))
            {
                store.add_m5zn(txt_store.Text);
                MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_store.Text = "";
                dgv_stores.DataSource = store.get_all_m5azen();
                txt_store.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_store.Text))
            {
                store.edit_m5zn(Convert.ToInt32(dgv_stores.CurrentRow.Cells[0].Value), txt_store.Text);
                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_store.Text = "";
                dgv_stores.DataSource = store.get_all_m5azen();
                txt_store.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد حذف هذا المخزن؟؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                store.delete_m5zn(Convert.ToInt32(dgv_stores.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_store.Text = "";
                dgv_stores.DataSource = store.get_all_m5azen();
                txt_store.Focus();
            }
        }

        private void dgv_stores_Click(object sender, EventArgs e)
        {
            txt_store.Text = dgv_stores.CurrentRow.Cells[1].Value.ToString();
                try 
	            {
                    dgv_products.DataSource = prd.filter_by_store(dgv_stores.CurrentRow.Cells[1].Value.ToString());
		            
	            }
	            catch (Exception)
	            {
		
	            }
                dgv_products.Columns[1].Width = 150;
                txttotalPrice.Text = (from DataGridViewRow row in dgv_products.Rows
                                 where row.Cells[6].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() != "0"
                                 select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
                txtTotalQunt.Text = (from DataGridViewRow row in dgv_products.Rows
                                     where row.Cells[2].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() != "0"
                                 select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frm_change_store frm = new frm_change_store();
            frm.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
