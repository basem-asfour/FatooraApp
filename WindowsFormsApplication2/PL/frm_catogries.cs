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
    
    public partial class frm_catogries : Form
    {
        BL.cls_products product = new BL.cls_products();
        public frm_catogries()
        {
            InitializeComponent();
            
            ApplyModernTheme();
            
            dataGridView1.DataSource = product.get_all_catogries();
        }
        
        private void ApplyModernTheme()
        {
            // Apply modern form styling
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = ModernTheme.NormalFont;
            
            // Style TextBox
            if (textBox1 != null)
            {
                ModernTheme.StyleTextBox(textBox1);
            }
            
            // Style Labels
            StyleLabels();
            
            // Style Buttons
            StyleButtons();
            
            // Style DataGridView
            if (dataGridView1 != null)
            {
                ModernTheme.StyleDataGridView(dataGridView1);
            }
        }
        
        private void StyleLabels()
        {
            if (label1 != null)
            {
                ModernTheme.StyleLabel(label1, LabelStyle.Normal);
                label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                label1.ForeColor = ModernTheme.TextPrimary;
            }
        }
        
        private void StyleButtons()
        {
            // Add Button
            if (btnok != null)
            {
                ModernTheme.StyleButton(btnok, ButtonStyle.Success);
                btnok.Text = "➕ إضافة";
                btnok.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            
            // Edit Button
            if (button2 != null)
            {
                ModernTheme.StyleButton(button2, ButtonStyle.Primary);
                button2.Text = "✏️ تعديل";
                button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            
            // Delete Button
            if (button1 != null)
            {
                ModernTheme.StyleButton(button1, ButtonStyle.Danger);
                button1.Text = "🗑️ حذف النوع";
                button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        private void frm_catogries_Load(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                product.add_catogry(textBox1.Text);
                MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                dataGridView1.DataSource = product.get_all_catogries();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                product.edit_catogry(Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value),textBox1.Text);
                MessageBox.Show("تمت التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                dataGridView1.DataSource = product.get_all_catogries();
                textBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد حذف هذا النوع؟؟","عملية الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                product.delete_catogry(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                dataGridView1.DataSource = product.get_all_catogries();
                textBox1.Focus();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox1.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox1.Focus();
        }
    }
}
