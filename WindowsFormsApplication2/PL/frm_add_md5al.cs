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
    public partial class frm_add_md5al : Form
    {
        public string state = "add";

        BL.cls_orders order = new BL.cls_orders();
        public frm_add_md5al()
        {
            InitializeComponent();
            dateTimePicker1.Value = System.DateTime.Today;
            
            ApplyModernTheme();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (state=="add")
            {
                order.add_md5al(txtvalue.Text, dateTimePicker1.Text, txtdskrbshn.Text);
                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdskrbshn.Text = string.Empty;
                txtvalue.Text = string.Empty;
            }
            else
            {
                order.edit_md5al(Convert.ToInt32(label4.Text),txtvalue.Text,dateTimePicker1.Text,txtdskrbshn.Text);
                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }
        
        private void ApplyModernTheme()
        {
            // Apply modern form styling
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = ModernTheme.NormalFont;
            
            // Style TextBoxes
            ModernTheme.StyleTextBox(txtvalue);
            ModernTheme.StyleTextBox(txtdskrbshn);
            
            // Style Labels
            StyleLabels();
            
            // Style Buttons
            StyleButtons();
            
            // Style DateTimePicker
            StyleDateTimePicker();
        }
        
        private void StyleLabels()
        {
            Label[] labels = { label1, label2, label3 };
            
            foreach (Label label in labels)
            {
                if (label != null)
                {
                    ModernTheme.StyleLabel(label, LabelStyle.Normal);
                }
            }
        }
        
        private void StyleButtons()
        {
            // Main action button
            ModernTheme.StyleButton(button1, ButtonStyle.Success);
            
            // Exit button
            ModernTheme.StyleButton(button2, ButtonStyle.Danger);
        }
        
        private void StyleDateTimePicker()
        {
            if (dateTimePicker1 != null)
            {
                dateTimePicker1.Font = new Font("Segoe UI", 10F);
                dateTimePicker1.CalendarFont = new Font("Segoe UI", 10F);
                dateTimePicker1.CalendarTitleBackColor = ModernTheme.PrimaryColor;
                dateTimePicker1.CalendarTitleForeColor = ModernTheme.TextLight;
            }
        }
    }
}
