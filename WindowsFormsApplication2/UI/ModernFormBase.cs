using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2.UI
{
    /// <summary>
    /// Base form class that applies modern theme to all controls automatically
    /// </summary>
    public class ModernFormBase : Form
    {
        public ModernFormBase()
        {
            // Apply form-level styling
            ModernTheme.StyleForm(this);
            this.Load += ModernFormBase_Load;
        }

        private void ModernFormBase_Load(object sender, EventArgs e)
        {
            // Auto-apply theme to all controls when form loads
            ApplyThemeToAllControls(this);
        }

        /// <summary>
        /// Recursively apply modern theme to all controls on the form
        /// </summary>
        protected virtual void ApplyThemeToAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // Apply appropriate styling based on control type
                if (control is Button)
                {
                    // Determine button style based on name/text
                    ButtonStyle style = DetermineButtonStyle(control as Button);
                    ModernTheme.StyleButton(control as Button, style);
                }
                else if (control is TextBox)
                {
                    ModernTheme.StyleTextBox(control as TextBox);
                }
                else if (control is Label)
                {
                    // Keep existing label style but ensure font consistency
                    LabelStyle style = DetermineLabelStyle(control as Label);
                    ModernTheme.StyleLabel(control as Label, style);
                }
                else if (control is GroupBox)
                {
                    ModernTheme.StyleGroupBox(control as GroupBox);
                }
                else if (control is Panel)
                {
                    ModernTheme.StylePanel(control as Panel);
                }
                else if (control is DataGridView)
                {
                    ModernTheme.StyleDataGridView(control as DataGridView);
                }
                else if (control is ComboBox)
                {
                    ModernTheme.StyleComboBox(control as ComboBox);
                }

                // Recursively apply to child controls
                if (control.HasChildren)
                {
                    ApplyThemeToAllControls(control);
                }
            }
        }

        /// <summary>
        /// Determine button style based on button properties
        /// </summary>
        private ButtonStyle DetermineButtonStyle(Button button)
        {
            string name = button.Name.ToLower();
            string text = button.Text.ToLower();

            // Determine style based on button name or text
            if (name.Contains("save") || name.Contains("sve") || text.Contains("حفظ") || text.Contains("save"))
                return ButtonStyle.Success;
            else if (name.Contains("delete") || name.Contains("del") || name.Contains("remove") ||
                     text.Contains("حذف") || text.Contains("delete") || text.Contains("مسح"))
                return ButtonStyle.Danger;
            else if (name.Contains("cancel") || text.Contains("الغاء") || text.Contains("cancel") ||
                     text.Contains("خروج") || text.Contains("close"))
                return ButtonStyle.Secondary;
            else if (name.Contains("print") || name.Contains("prnt") || text.Contains("طباعة") || text.Contains("print"))
                return ButtonStyle.Warning;
            else if (name.Contains("new") || text.Contains("جديد") || text.Contains("new") || text.Contains("اضافة"))
                return ButtonStyle.Primary;
            else
                return ButtonStyle.Primary;
        }

        /// <summary>
        /// Determine label style based on label properties
        /// </summary>
        private LabelStyle DetermineLabelStyle(Label label)
        {
            // Check font size to determine style
            if (label.Font.Size >= 16)
                return LabelStyle.Header;
            else if (label.Font.Size >= 14)
                return LabelStyle.SubHeader;
            else if (label.Font.Size >= 12 || label.Font.Bold)
                return LabelStyle.Title;
            else if (label.ForeColor == Color.Gray || label.ForeColor.GetBrightness() > 0.5)
                return LabelStyle.Secondary;
            else
                return LabelStyle.Normal;
        }

        /// <summary>
        /// Manual theme application - can be called explicitly if needed
        /// </summary>
        protected void ApplyModernTheme()
        {
            ApplyThemeToAllControls(this);
        }
    }
}
