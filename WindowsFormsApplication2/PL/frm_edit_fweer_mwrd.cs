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
    public partial class frm_edit_fweer_mwrd : Form
    {
        BL.cls_mwrdeen mwrd = new BL.cls_mwrdeen();

        public frm_edit_fweer_mwrd()
        {
            InitializeComponent();
            
            ApplyModernTheme();
        }
        
        private void ApplyModernTheme()
        {
            // Apply modern form styling
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            
            // Style TextBoxes
            StyleTextBoxes();
            
            // Style Labels
            StyleLabels();
            
            // Style Buttons
            StyleButtons();
        }
        
        private void StyleTextBoxes()
        {
            TextBox[] textBoxes = { txtid, txtnme, txtdate, txtvalye, txtmsdd, txtmtbaki };
            
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox != null)
                {
                    ModernTheme.StyleTextBox(textBox);
                    textBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                    
                    // Special styling for readonly fields
                    if (textBox == txtid || textBox == txtmtbaki)
                    {
                        textBox.BackColor = Color.FromArgb(248, 249, 250); // Very light gray for readonly
                        textBox.ForeColor = ModernTheme.TextSecondary;
                        textBox.ReadOnly = true;
                    }
                }
            }
        }
        
        private void StyleLabels()
        {
            // Get all labels using reflection or manual list
            Label[] labels = { label1, label2, label3, label4, label5, label6 };
            
            foreach (Label label in labels)
            {
                if (label != null)
                {
                    ModernTheme.StyleLabel(label, LabelStyle.Normal);
                    label.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                    label.ForeColor = ModernTheme.TextPrimary;
                    label.UseCompatibleTextRendering = false;
                    label.AutoSize = false;
                }
            }
        }
        
        private void StyleButtons()
        {
            if (button1 != null) // Save/Edit button
            {
                ModernTheme.StyleButton(button1, ButtonStyle.Success);
                button1.Text = "💾 حفظ التعديل";
                button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                button1.UseCompatibleTextRendering = false;
            }
            
            if (button2 != null) // Cancel button
            {
                ModernTheme.StyleButton(button2, ButtonStyle.Danger);
                button2.Text = "❌ إلغاء";
                button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                button2.UseCompatibleTextRendering = false;
            }
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
