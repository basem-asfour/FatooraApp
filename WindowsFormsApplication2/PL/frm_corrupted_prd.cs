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
    public partial class frm_corrupted_prd : Form
    {
        BL.cls_products prd = new BL.cls_products();
        DataTable dt_combobox=new DataTable();
        public frm_corrupted_prd()
        {
            InitializeComponent();
            
            ApplyModernTheme();
            
            dt_combobox = prd.get_all_products();
            txtnme.DataSource = dt_combobox;
            txtnme.DisplayMember = "اسم الصنف";
            txtnme.ValueMember = "id";
            dataGridView1.DataSource = prd.search_corrupted_prd("");
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
            
            // Style GroupBoxes
            StyleGroupBoxes();
            
            // Style DataGridView
            StyleDataGridView();
            
            // Style DateTimePicker
            StyleDateTimePicker();
        }
        
        private void StyleComboBoxes()
        {
            if (txtnme != null)
            {
                ModernTheme.StyleComboBox(txtnme);
            }
        }
        
        private void StyleTextBoxes()
        {
            if (txt_qte != null)
            {
                ModernTheme.StyleTextBox(txt_qte);
            }
            
            if (txt_reason != null)
            {
                ModernTheme.StyleTextBox(txt_reason);
            }
            
            if (textBox1 != null)
            {
                ModernTheme.StyleTextBox(textBox1);
            }
        }
        
        private void StyleLabels()
        {
            Label[] labels = { label1, label2, label3, label4, label5, label6 };
            
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
            // Add Corrupted Product Button
            if (btn_add != null)
            {
                ModernTheme.StyleButton(btn_add, ButtonStyle.Success);
                btn_add.Text = "➕ إضافة الهالك";
                btn_add.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            
            // Edit Button
            if (btn_edit != null)
            {
                ModernTheme.StyleButton(btn_edit, ButtonStyle.Warning);
                btn_edit.Text = "✏️ تعديل المحدد";
                btn_edit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            
            // Delete Button
            if (btn_delete != null)
            {
                ModernTheme.StyleButton(btn_delete, ButtonStyle.Danger);
                btn_delete.Text = "🗑️ حذف المحدد";
                btn_delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            
            // Choose Product Button
            if (btn_choose != null)
            {
                ModernTheme.StyleButton(btn_choose, ButtonStyle.Primary);
                btn_choose.Text = "🔍 اختيار صنف";
                btn_choose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
        }
        
        private void StyleGroupBoxes()
        {
            if (groupBox1 != null)
            {
                ModernTheme.StyleGroupBox(groupBox1);
                groupBox1.BackColor = ModernTheme.BackgroundCard;
                groupBox1.ForeColor = ModernTheme.TextPrimary;
                groupBox1.Text = "📋 قائمة هالك الأصناف";
                groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            }
            
            if (groupBox2 != null)
            {
                ModernTheme.StyleGroupBox(groupBox2);
                groupBox2.BackColor = ModernTheme.BackgroundCard;
                groupBox2.ForeColor = ModernTheme.TextPrimary;
                groupBox2.Text = "🔧 العمليات المتاحة";
                groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            }
            
            if (groupBox3 != null)
            {
                ModernTheme.StyleGroupBox(groupBox3);
                groupBox3.BackColor = ModernTheme.BackgroundCard;
                groupBox3.ForeColor = ModernTheme.TextPrimary;
                groupBox3.Text = "📦 بيانات الصنف";
                groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            }
        }
        
        private void StyleDataGridView()
        {
            if (dataGridView1 != null)
            {
                ModernTheme.StyleDataGridView(dataGridView1);
            }
        }
        
        private void StyleDateTimePicker()
        {
            if (dateTimePicker1 != null)
            {
                dateTimePicker1.Font = ModernTheme.NormalFont;
                dateTimePicker1.CalendarFont = ModernTheme.NormalFont;
                dateTimePicker1.CalendarTitleBackColor = ModernTheme.PrimaryColor;
                dateTimePicker1.CalendarTitleForeColor = ModernTheme.TextLight;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            frm_products_list frm = new frm_products_list();
            frm.ShowDialog();
            txtnme.SelectedValue = Convert.ToInt32(frm.dgvprdcts.CurrentRow.Cells[0].Value);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            prd.add_corrupted_product(Convert.ToInt32(txtnme.SelectedValue), Convert.ToInt32(txt_qte.Text), txt_reason.Text, dateTimePicker1.Text);
            prd.update_product_after_mrtg3_mshtriat(Convert.ToInt32(txtnme.SelectedValue), Convert.ToInt32(txt_qte.Text));
            dataGridView1.DataSource = prd.search_corrupted_prd("");
            txt_reason.Text = "";
            txt_qte.Text = "";
            txtnme.Text = "";
            MessageBox.Show("تمت الإضافة بنجاح ", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtnme.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            txt_qte.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_reason.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           // dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = prd.search_corrupted_prd(textBox1.Text);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            prd.edit_corrupted_prd(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),Convert.ToInt32(txtnme.SelectedValue), Convert.ToInt32(txt_qte.Text), txt_reason.Text, dateTimePicker1.Text);
            dataGridView1.DataSource = prd.search_corrupted_prd("");
            txt_reason.Text = "";
            txt_qte.Text = "";
            txtnme.Text = "";
            MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("عند الحذف سيتم استرجاع الكمية التالفة ","عملية الحذف",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
            {
                prd.delete_corrupted_prd(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                dataGridView1.DataSource = prd.search_corrupted_prd("");
                txt_reason.Text = "";
                txt_qte.Text = "";
                txtnme.Text = "";
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
