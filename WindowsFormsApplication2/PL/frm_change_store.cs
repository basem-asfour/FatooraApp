using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.UI;

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
            
            ApplyModernTheme();
            
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
        
        private void ApplyModernTheme()
        {
            // Apply modern form styling
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = ModernTheme.NormalFont;
            
            // Style ComboBoxes
            StyleComboBoxes();
            
            // Style TextBoxes
            StyleTextBoxes();
            
            // Style Labels
            StyleLabels();
            
            // Style Buttons
            StyleButtons();
            
            // Style GroupBox
            StyleGroupBox();
            
            // Style DataGridView
            StyleDataGridView();
        }
        
        private void StyleComboBoxes()
        {
            if (combo_stores != null)
            {
                ModernTheme.StyleComboBox(combo_stores);
            }
            
            if (txtnme != null)
            {
                ModernTheme.StyleComboBox(txtnme);
            }
        }
        
        private void StyleTextBoxes()
        {
            if (txtqte != null)
            {
                ModernTheme.StyleTextBox(txtqte);
            }
            
            if (txt_prd_nme != null)
            {
                txt_prd_nme.BackColor = Color.FromArgb(248, 249, 250); // Very light gray for readonly
                txt_prd_nme.ForeColor = ModernTheme.TextSecondary;
                txt_prd_nme.BorderStyle = BorderStyle.FixedSingle;
                txt_prd_nme.Font = ModernTheme.NormalFont;
            }
            
            if (txt_prd_id != null)
            {
                txt_prd_id.BackColor = Color.FromArgb(248, 249, 250); // Very light gray for readonly
                txt_prd_id.ForeColor = ModernTheme.TextSecondary;
                txt_prd_id.BorderStyle = BorderStyle.FixedSingle;
                txt_prd_id.Font = ModernTheme.NormalFont;
            }
        }
        
        private void StyleLabels()
        {
            Label[] labels = { label1, label2, label10 };
            
            foreach (Label label in labels)
            {
                if (label != null)
                {
                    ModernTheme.StyleLabel(label, LabelStyle.Normal);
                    label.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    label.ForeColor = ModernTheme.TextPrimary;
                }
            }
        }
        
        private void StyleButtons()
        {
            // Change Store Button
            if (btn_change != null)
            {
                ModernTheme.StyleButton(btn_change, ButtonStyle.Success);
                btn_change.Text = "✅ تأكيد";
                btn_change.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            
            // Cancel Button
            if (btn_cancel != null)
            {
                ModernTheme.StyleButton(btn_cancel, ButtonStyle.Danger);
                btn_cancel.Text = "❌ إلغاء";
                btn_cancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            
            // Select Product Button
            if (button1 != null)
            {
                ModernTheme.StyleButton(button1, ButtonStyle.Primary);
                button1.Text = "🔍 اختيار صنف";
                button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
        }
        
        private void StyleGroupBox()
        {
            if (groupBox3 != null)
            {
                ModernTheme.StyleGroupBox(groupBox3);
                groupBox3.BackColor = ModernTheme.BackgroundCard;
                groupBox3.ForeColor = ModernTheme.TextPrimary;
                groupBox3.Text = "📦 بيانات الصنف المختار";
                groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            }
        }
        
        private void StyleDataGridView()
        {
            if (dgv_products != null)
            {
                ModernTheme.StyleDataGridView(dgv_products);
            }
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
