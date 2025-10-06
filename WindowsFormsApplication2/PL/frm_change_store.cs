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
    public partial class frm_change_store : Form
    {
        BL.cls_products prd = new BL.cls_products();
        BL.cls_mwrdeen mwrd = new BL.cls_mwrdeen();
        DataTable dt_combobox;
        DataTable dt_stores;
        BL.cls_stores store = new BL.cls_stores();
        public frm_change_store()
        {
            InitializeComponent();
            dt_stores = store.get_all_m5azen();
            ////////////////////////
            dt_combobox = prd.get_all_products();
            txtnme.DataSource = dt_combobox;
            txtnme.DisplayMember = "اسم الصنف";
            txtnme.ValueMember = "id";
            ////////////////////////
            combo_stores.DataSource = dt_stores;
            combo_stores.DisplayMember = "اسم المخزن";
            combo_stores.ValueMember = "id";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtqte.Text))
            {
                store.change_store(Convert.ToInt32(txt_prd_id.Text), Convert.ToInt32(combo_stores.SelectedValue), Convert.ToInt32(txtqte.Text));
                MessageBox.Show("تم تغيير المخزن بنجاح ", "تغيير المخزن", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtqte.Text = "";
                this.dgv_products.DataSource = prd.get_single_product(Convert.ToInt32(txt_prd_id.Text));

                
            }
        }

        private void txtnme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnme.SelectedValue.ToString()))
            {
                try
                {
                    dgv_products.DataSource = prd.get_single_product(Convert.ToInt32(txtnme.SelectedValue));

                }
                catch (Exception)
                {
                    
                    
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_products_list frm = new frm_products_list();
            frm.ShowDialog();
            this.txt_prd_nme.Text = frm.dgvprdcts.CurrentRow.Cells[1].Value.ToString();
            this.dgv_products.DataSource = prd.get_single_product(Convert.ToInt32(frm.dgvprdcts.CurrentRow.Cells[0].Value));
            txt_prd_id.Text = frm.dgvprdcts.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
