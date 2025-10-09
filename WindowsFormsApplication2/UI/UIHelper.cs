using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApplication2.UI
{
    /// <summary>
    /// Helper class for common UI operations and enhancements
    /// </summary>
    public static class UIHelper
    {
        /// <summary>
        /// Create a rounded rectangle path for custom borders
        /// </summary>
        public static GraphicsPath CreateRoundedRectangle(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // Top left arc
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);

            // Top right arc
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);

            // Bottom right arc
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);

            // Bottom left arc
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// Add a shadow effect to a panel
        /// </summary>
        public static void AddShadowEffect(Panel panel, int shadowSize = 5, Color? shadowColor = null)
        {
            Color color = shadowColor ?? Color.FromArgb(50, 0, 0, 0);
            panel.Paint += (sender, e) =>
            {
                using (SolidBrush brush = new SolidBrush(color))
                {
                    e.Graphics.FillRectangle(brush,
                        new Rectangle(shadowSize, shadowSize,
                                     panel.Width - shadowSize,
                                     panel.Height - shadowSize));
                }
            };
        }

        /// <summary>
        /// Animate a control fade in
        /// </summary>
        public static void FadeIn(Control control, int duration = 500)
        {
            Timer timer = new Timer();
            int step = 0;
            int steps = 20;
            int interval = duration / steps;

            timer.Interval = interval;
            timer.Tick += (sender, e) =>
            {
                step++;
                //control.Opacity = (double)step / steps;

                if (step >= steps)
                {
                    timer.Stop();
                    timer.Dispose();
                }
            };

            //control.Opacity = 0;
            timer.Start();
        }

        /// <summary>
        /// Show a modern message box
        /// </summary>
        public static DialogResult ShowMessage(string message, string title, MessageType type = MessageType.Information)
        {
            MessageBoxIcon icon;
            switch (type)
            {
                case MessageType.Success:
                    icon = MessageBoxIcon.Information;
                    break;
                case MessageType.Error:
                    icon = MessageBoxIcon.Error;
                    break;
                case MessageType.Warning:
                    icon = MessageBoxIcon.Warning;
                    break;
                case MessageType.Question:
                    icon = MessageBoxIcon.Question;
                    return MessageBox.Show(message, title, MessageBoxButtons.YesNo, icon);
                default:
                    icon = MessageBoxIcon.Information;
                    break;
            }

            return MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        /// <summary>
        /// Create a separator line
        /// </summary>
        public static Panel CreateSeparator(int height = 1)
        {
            return new Panel
            {
                Height = height,
                Dock = DockStyle.Top,
                BackColor = ModernTheme.BorderLight
            };
        }

        /// <summary>
        /// Create a spacer panel
        /// </summary>
        public static Panel CreateSpacer(int height)
        {
            return new Panel
            {
                Height = height,
                Dock = DockStyle.Top,
                BackColor = Color.Transparent
            };
        }

        /// <summary>
        /// Apply hover effect to a button
        /// </summary>
        public static void AddButtonHoverEffect(Button button, Color hoverColor, Color normalColor)
        {
            button.MouseEnter += (sender, e) =>
            {
                button.BackColor = hoverColor;
            };

            button.MouseLeave += (sender, e) =>
            {
                button.BackColor = normalColor;
            };
        }

        /// <summary>
        /// Format currency for display
        /// </summary>
        public static string FormatCurrency(decimal amount)
        {
            return amount.ToString("N2") + " ج.م";
        }

        /// <summary>
        /// Format date for display in Arabic
        /// </summary>
        public static string FormatDate(DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Create a card-style panel
        /// </summary>
        public static Panel CreateCard(string title = null)
        {
            Panel card = new Panel
            {
                BackColor = ModernTheme.BackgroundCard,
                Padding = new Padding(ModernTheme.PaddingMedium),
                BorderStyle = BorderStyle.FixedSingle
            };

            if (!string.IsNullOrEmpty(title))
            {
                Label titleLabel = new Label
                {
                    Text = title,
                    Dock = DockStyle.Top,
                    Height = 30,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                ModernTheme.StyleLabel(titleLabel, LabelStyle.Title);
                card.Controls.Add(titleLabel);
                card.Controls.Add(CreateSeparator());
                card.Controls.Add(CreateSpacer(10));
            }

            return card;
        }

        /// <summary>
        /// Set placeholder text for textbox
        /// </summary>
        public static void SetPlaceholder(TextBox textBox, string placeholder, Color placeholderColor)
        {
            bool isPlaceholder = true;

            textBox.Text = placeholder;
            textBox.ForeColor = placeholderColor;

            textBox.GotFocus += (sender, e) =>
            {
                if (isPlaceholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = ModernTheme.TextPrimary;
                    isPlaceholder = false;
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = placeholderColor;
                    isPlaceholder = true;
                }
            };
        }

        /// <summary>
        /// Validate numeric input for textbox
        /// </summary>
        public static void SetNumericOnly(TextBox textBox, bool allowDecimal = false)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    if (!allowDecimal || e.KeyChar != '.')
                    {
                        e.Handled = true;
                    }
                }

                // Only allow one decimal point
                if (allowDecimal && e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
                {
                    e.Handled = true;
                }
            };
        }

        /// <summary>
        /// Highlight DataGridView row on hover
        /// </summary>
        public static void EnableRowHighlight(DataGridView dgv)
        {
            dgv.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = ModernTheme.GridSelectedRow;
                }
            };

            dgv.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    if (e.RowIndex % 2 == 0)
                        dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = ModernTheme.BackgroundCard;
                    else
                        dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = ModernTheme.GridAlternateRow;
                }
            };
        }

        /// <summary>
        /// Create a modern loading indicator
        /// </summary>
        public static Form ShowLoading(string message = "جاري التحميل...")
        {
            Form loadingForm = new Form
            {
                Size = new Size(300, 100),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.None,
                BackColor = ModernTheme.BackgroundCard,
                ShowInTaskbar = false
            };

            Label label = new Label
            {
                Text = message,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = ModernTheme.TitleFont,
                ForeColor = ModernTheme.TextPrimary
            };

            loadingForm.Controls.Add(label);
            loadingForm.Show();

            return loadingForm;
        }
    }

    public enum MessageType
    {
        Information,
        Success,
        Error,
        Warning,
        Question
    }
}
