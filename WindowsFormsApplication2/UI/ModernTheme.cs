using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2.UI
{
    /// <summary>
    /// Modern UI Theme for POS Application
    /// Provides centralized color scheme, fonts, and styling utilities
    /// </summary>
    public static class ModernTheme
    {
        #region Color Palette

        // Primary Colors - Professional Blue Gradient
        public static readonly Color PrimaryColor = Color.FromArgb(41, 128, 185);        // Modern Blue
        public static readonly Color PrimaryDark = Color.FromArgb(31, 97, 141);          // Darker Blue
        public static readonly Color PrimaryLight = Color.FromArgb(52, 152, 219);        // Lighter Blue
        public static readonly Color PrimaryHover = Color.FromArgb(46, 134, 193);        // Hover State

        // Secondary Colors - Elegant Gray Tones
        public static readonly Color SecondaryColor = Color.FromArgb(52, 73, 94);        // Dark Gray Blue
        public static readonly Color SecondaryLight = Color.FromArgb(127, 140, 141);     // Medium Gray
        public static readonly Color SecondaryHover = Color.FromArgb(69, 90, 100);       // Hover Gray

        // Background Colors
        public static readonly Color BackgroundMain = Color.FromArgb(236, 240, 241);     // Light Gray Background
        public static readonly Color BackgroundCard = Color.White;                        // Card/Panel Background
        public static readonly Color BackgroundDark = Color.FromArgb(44, 62, 80);        // Dark Background
        public static readonly Color BackgroundAlt = Color.FromArgb(250, 250, 250);      // Alternative Background

        // Text Colors
        public static readonly Color TextPrimary = Color.FromArgb(44, 62, 80);           // Primary Text
        public static readonly Color TextSecondary = Color.FromArgb(127, 140, 141);      // Secondary Text
        public static readonly Color TextLight = Color.White;                             // Light Text
        public static readonly Color TextDisabled = Color.FromArgb(189, 195, 199);       // Disabled Text

        // Accent Colors
        public static readonly Color AccentGreen = Color.FromArgb(39, 174, 96);          // Success/Positive
        public static readonly Color AccentRed = Color.FromArgb(231, 76, 60);            // Error/Delete
        public static readonly Color AccentOrange = Color.FromArgb(230, 126, 34);        // Warning
        public static readonly Color AccentYellow = Color.FromArgb(241, 196, 15);        // Info/Alert
        public static readonly Color AccentPurple = Color.FromArgb(155, 89, 182);        // Special Actions

        // Border Colors
        public static readonly Color BorderLight = Color.FromArgb(220, 220, 220);        // Light Border
        public static readonly Color BorderMedium = Color.FromArgb(189, 195, 199);       // Medium Border
        public static readonly Color BorderDark = Color.FromArgb(149, 165, 166);         // Dark Border

        // Grid Colors
        public static readonly Color GridHeaderBackground = Color.FromArgb(52, 73, 94);
        public static readonly Color GridHeaderText = Color.White;
        public static readonly Color GridAlternateRow = Color.FromArgb(245, 247, 248);
        public static readonly Color GridSelectedRow = Color.FromArgb(174, 214, 241);
        public static readonly Color GridBorder = Color.FromArgb(220, 220, 220);

        #endregion

        #region Fonts

        public static readonly Font HeaderFont = new Font("Segoe UI", 18F, FontStyle.Bold);
        public static readonly Font SubHeaderFont = new Font("Segoe UI", 14F, FontStyle.Bold);
        public static readonly Font TitleFont = new Font("Segoe UI", 12F, FontStyle.Bold);
        public static readonly Font NormalFont = new Font("Segoe UI", 10F, FontStyle.Regular);
        public static readonly Font SmallFont = new Font("Segoe UI", 9F, FontStyle.Regular);
        public static readonly Font ButtonFont = new Font("Segoe UI", 10F, FontStyle.Bold);
        public static readonly Font LabelFont = new Font("Segoe UI", 9.5F, FontStyle.Regular);

        #endregion

        #region Spacing & Sizing

        public const int PaddingSmall = 2;
        public const int PaddingMedium = 5;
        public const int PaddingLarge = 10;
        public const int PaddingXLarge = 15;

        public const int BorderRadiusSmall = 3;
        public const int BorderRadiusMedium = 5;
        public const int BorderRadiusLarge = 8;

        public const int ButtonHeight = 35;
        public const int ButtonHeightLarge = 45;
        public const int TextBoxHeight = 30;

        #endregion

        #region Styling Methods

        /// <summary>
        /// Apply modern button style
        /// </summary>
        public static void StyleButton(Button button, ButtonStyle style = ButtonStyle.Primary)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.Font = ButtonFont;
            button.Cursor = Cursors.Hand;
            button.Height = ButtonHeight;
            button.Padding = new Padding(PaddingMedium);

            switch (style)
            {
                case ButtonStyle.Primary:
                    button.BackColor = PrimaryColor;
                    button.ForeColor = TextLight;
                    button.FlatAppearance.BorderColor = PrimaryDark;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatAppearance.MouseOverBackColor = PrimaryHover;
                    button.FlatAppearance.MouseDownBackColor = PrimaryDark;
                    break;

                case ButtonStyle.Success:
                    button.BackColor = AccentGreen;
                    button.ForeColor = TextLight;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 130, 76);
                    break;

                case ButtonStyle.Danger:
                    button.BackColor = AccentRed;
                    button.ForeColor = TextLight;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 50, 38);
                    break;

                case ButtonStyle.Warning:
                    button.BackColor = AccentOrange;
                    button.ForeColor = TextLight;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 84, 0);
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(175, 96, 26);
                    break;

                case ButtonStyle.Secondary:
                    button.BackColor = SecondaryLight;
                    button.ForeColor = TextLight;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatAppearance.MouseOverBackColor = SecondaryHover;
                    button.FlatAppearance.MouseDownBackColor = SecondaryColor;
                    break;

                case ButtonStyle.Outline:
                    button.BackColor = Color.Transparent;
                    button.ForeColor = PrimaryColor;
                    button.FlatAppearance.BorderColor = PrimaryColor;
                    button.FlatAppearance.BorderSize = 2;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 41, 128, 185);
                    break;
            }
        }

        /// <summary>
        /// Apply modern textbox style
        /// </summary>
        public static void StyleTextBox(TextBox textBox)
        {
            textBox.Font = NormalFont;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Height = TextBoxHeight;
            textBox.BackColor = BackgroundCard;
            textBox.ForeColor = TextPrimary;
        }

        /// <summary>
        /// Apply modern label style
        /// </summary>
        public static void StyleLabel(Label label, LabelStyle style = LabelStyle.Normal)
        {
            switch (style)
            {
                case LabelStyle.Header:
                    label.Font = HeaderFont;
                    label.ForeColor = TextPrimary;
                    break;

                case LabelStyle.SubHeader:
                    label.Font = SubHeaderFont;
                    label.ForeColor = TextPrimary;
                    break;

                case LabelStyle.Title:
                    label.Font = TitleFont;
                    label.ForeColor = TextPrimary;
                    break;

                case LabelStyle.Normal:
                    label.Font = LabelFont;
                    label.ForeColor = TextPrimary;
                    break;

                case LabelStyle.Secondary:
                    label.Font = SmallFont;
                    label.ForeColor = TextSecondary;
                    break;
            }
        }

        /// <summary>
        /// Apply modern panel/groupbox style
        /// </summary>
        public static void StylePanel(Panel panel, bool addShadow = false)
        {
            panel.BackColor = BackgroundCard;
            panel.Padding = new Padding(PaddingMedium);

            if (addShadow)
            {
                panel.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        /// <summary>
        /// Apply modern groupbox style
        /// </summary>
        public static void StyleGroupBox(GroupBox groupBox)
        {
            groupBox.Font = TitleFont;
            groupBox.ForeColor = TextPrimary;
            groupBox.BackColor = BackgroundCard;
            groupBox.Padding = new Padding(PaddingMedium);
        }

        /// <summary>
        /// Apply modern DataGridView style
        /// </summary>
        public static void StyleDataGridView(DataGridView dgv)
        {
            // Basic settings
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = BackgroundCard;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Header styling
            dgv.ColumnHeadersDefaultCellStyle.BackColor = GridHeaderBackground;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = GridHeaderText;
            dgv.ColumnHeadersDefaultCellStyle.Font = TitleFont;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(PaddingMedium);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 40;

            // Cell styling
            dgv.DefaultCellStyle.BackColor = BackgroundCard;
            dgv.DefaultCellStyle.ForeColor = TextPrimary;
            dgv.DefaultCellStyle.Font = NormalFont;
            dgv.DefaultCellStyle.SelectionBackColor = GridSelectedRow;
            dgv.DefaultCellStyle.SelectionForeColor = TextPrimary;
            dgv.DefaultCellStyle.Padding = new Padding(PaddingSmall);
            dgv.RowTemplate.Height = 35;

            // Alternating row color
            dgv.AlternatingRowsDefaultCellStyle.BackColor = GridAlternateRow;

            // Grid lines
            dgv.GridColor = GridBorder;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        /// <summary>
        /// Apply modern form style
        /// </summary>
        public static void StyleForm(Form form)
        {
            form.BackColor = BackgroundMain;
            form.Font = NormalFont;
            form.ForeColor = TextPrimary;
        }

        /// <summary>
        /// Apply modern ComboBox style
        /// </summary>
        public static void StyleComboBox(ComboBox comboBox)
        {
            comboBox.Font = NormalFont;
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.BackColor = BackgroundCard;
            comboBox.ForeColor = TextPrimary;
        }

        /// <summary>
        /// Create a modern styled button with icon support
        /// </summary>
        public static Button CreateButton(string text, ButtonStyle style = ButtonStyle.Primary, int width = 120)
        {
            Button btn = new Button
            {
                Text = text,
                Width = width,
                Height = ButtonHeight,
                TextAlign = ContentAlignment.MiddleCenter
            };
            StyleButton(btn, style);
            return btn;
        }

        #endregion
    }

    #region Enums

    public enum ButtonStyle
    {
        Primary,
        Success,
        Danger,
        Warning,
        Secondary,
        Outline
    }

    public enum LabelStyle
    {
        Header,
        SubHeader,
        Title,
        Normal,
        Secondary
    }

    #endregion
}
