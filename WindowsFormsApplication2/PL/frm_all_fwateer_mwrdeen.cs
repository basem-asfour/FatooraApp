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
    public partial class frm_all_fwateer_mwrdeen : Form
    {
        public frm_all_fwateer_mwrdeen()
        {
            InitializeComponent();
            
            ApplyModernTheme();
        }
        
        private void ApplyModernTheme()
        {
            // Apply modern form styling
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = ModernTheme.NormalFont;
            
            // Style GroupBoxes
            if (groupBox1 != null)
            {
                ModernTheme.StyleGroupBox(groupBox1);
                groupBox1.BackColor = ModernTheme.BackgroundCard;
                groupBox1.ForeColor = ModernTheme.TextPrimary;
                groupBox1.Text = "📋 قائمة فواتير الموردين";
            }
            
            if (groupBox2 != null)
            {
                ModernTheme.StyleGroupBox(groupBox2);
                groupBox2.BackColor = ModernTheme.BackgroundCard;
                groupBox2.ForeColor = ModernTheme.TextPrimary;
                groupBox2.Text = "🔧 أدوات التقرير";
            }
            
            // Style DataGridView
            if (dataGridView1 != null)
            {
                ModernTheme.StyleDataGridView(dataGridView1);
            }
            
            // Style Buttons
            StyleButtons();
        }
        
        private void StyleButtons()
        {
            // Style all buttons with modern theme
            foreach (Control control in GetAllControls(this))
            {
                if (control is Button button)
                {
                    ModernTheme.StyleButton(button, ButtonStyle.Primary);
                }
            }
        }
        
        private IEnumerable<Control> GetAllControls(Control container)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control control in container.Controls)
            {
                controlList.Add(control);
                controlList.AddRange(GetAllControls(control));
            }
            return controlList;
        }
    }
}
