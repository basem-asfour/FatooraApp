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
    public partial class frm_change_company_name : Form
    {
        public frm_change_company_name()
        {
            InitializeComponent();
            
            ApplyModernTheme();
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
        }
        
        private void StyleLabels()
        {
            if (label2 != null)
            {
                ModernTheme.StyleLabel(label2, LabelStyle.Normal);
                label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                label2.ForeColor = ModernTheme.TextPrimary;
            }
        }
        
        private void StyleButtons()
        {
            // Save Button
            if (btnnew != null)
            {
                ModernTheme.StyleButton(btnnew, ButtonStyle.Success);
                btnnew.Text = "💾 حفظ الاسم";
                btnnew.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            
            // Exit Button
            if (button4 != null)
            {
                ModernTheme.StyleButton(button4, ButtonStyle.Danger);
                button4.Text = "❌ خروج";
                button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Program.company_name = textBox1.Text;
                MessageBox.Show("عملية التعديل", "تم التحديث بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
