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
    public partial class frm_change_order_date : Form
    {
        BL.cls_orders order = new BL.cls_orders();
        public int id_order = 0;
        public bool changed = false;
        public frm_change_order_date()
        {
            InitializeComponent();
            
            ApplyModernTheme();
            
            dateTimePicker1.Value = dateTimePicker2.Value;
        }
        
        private void ApplyModernTheme()
        {
            // Apply modern form styling
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = ModernTheme.NormalFont;
            
            // Style DateTimePickers
            StyleDateTimePickers();
            
            // Style Labels
            StyleLabels();
            
            // Style Buttons
            StyleButtons();
        }
        
        private void StyleDateTimePickers()
        {
            if (dateTimePicker1 != null)
            {
                dateTimePicker1.Font = ModernTheme.NormalFont;
                dateTimePicker1.CalendarFont = ModernTheme.NormalFont;
                dateTimePicker1.CalendarTitleBackColor = ModernTheme.PrimaryColor;
                dateTimePicker1.CalendarTitleForeColor = ModernTheme.TextLight;
            }
            
            if (dateTimePicker2 != null)
            {
                dateTimePicker2.Font = ModernTheme.NormalFont;
                dateTimePicker2.CalendarFont = ModernTheme.NormalFont;
                dateTimePicker2.CalendarTitleBackColor = ModernTheme.PrimaryColor;
                dateTimePicker2.CalendarTitleForeColor = ModernTheme.TextLight;
            }
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
                btnnew.Text = "💾 حفظ التاريخ";
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

        private void button4_Click(object sender, EventArgs e)
        {
            changed = false;
            this.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            order.Edit_order_Date(id_order, dateTimePicker2.Text,dateTimePicker1.Value);
            changed = true ;
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker2.Value;
        }
    }
}
