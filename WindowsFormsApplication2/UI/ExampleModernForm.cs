using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2.UI
{
    /// <summary>
    /// Example form demonstrating modern theme usage
    /// This serves as a template for creating new forms with modern UI
    /// </summary>
    public partial class ExampleModernForm : ModernFormBase
    {
        public ExampleModernForm()
        {
            InitializeComponent();
            SetupModernUI();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Form properties
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Name = "ExampleModernForm";
            this.Text = "Modern UI Example - POS Application";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.ResumeLayout(false);
        }

        private void SetupModernUI()
        {
            // Create header panel
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = ModernTheme.PrimaryColor
            };

            Label headerLabel = new Label
            {
                Text = "نموذج واجهة حديثة",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = ModernTheme.TextLight,
                Font = ModernTheme.HeaderFont
            };

            headerPanel.Controls.Add(headerLabel);
            this.Controls.Add(headerPanel);

            // Create main content panel
            Panel contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(ModernTheme.PaddingLarge),
                BackColor = ModernTheme.BackgroundMain
            };
            this.Controls.Add(contentPanel);

            // Create left panel for form inputs
            Panel leftPanel = UIHelper.CreateCard("بيانات العميل");
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Width = 400;
            contentPanel.Controls.Add(leftPanel);

            // Add form controls to left panel
            AddFormControls(leftPanel);

            // Create right panel for data grid
            Panel rightPanel = UIHelper.CreateCard("قائمة العملاء");
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Padding = new Padding(ModernTheme.PaddingMedium, 50, ModernTheme.PaddingMedium, ModernTheme.PaddingMedium);
            contentPanel.Controls.Add(rightPanel);

            // Add DataGridView
            AddDataGridExample(rightPanel);

            // Create button panel at bottom
            Panel buttonPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                BackColor = ModernTheme.BackgroundCard,
                Padding = new Padding(ModernTheme.PaddingLarge)
            };
            contentPanel.Controls.Add(buttonPanel);

            AddButtons(buttonPanel);
        }

        private void AddFormControls(Panel parent)
        {
            int yPosition = 80;
            int labelHeight = 25;
            int controlHeight = 30;
            int spacing = 15;

            // Customer Name
            Label lblName = new Label
            {
                Text = "اسم العميل:",
                Location = new Point(250, yPosition),
                Size = new Size(100, labelHeight),
                TextAlign = ContentAlignment.MiddleRight
            };
            ModernTheme.StyleLabel(lblName, LabelStyle.Normal);
            parent.Controls.Add(lblName);

            TextBox txtName = new TextBox
            {
                Location = new Point(50, yPosition),
                Size = new Size(190, controlHeight),
                Name = "txtCustomerName"
            };
            ModernTheme.StyleTextBox(txtName);
            UIHelper.SetPlaceholder(txtName, "ادخل اسم العميل", ModernTheme.TextSecondary);
            parent.Controls.Add(txtName);

            yPosition += controlHeight + spacing;

            // Phone Number
            Label lblPhone = new Label
            {
                Text = "رقم الهاتف:",
                Location = new Point(250, yPosition),
                Size = new Size(100, labelHeight),
                TextAlign = ContentAlignment.MiddleRight
            };
            ModernTheme.StyleLabel(lblPhone, LabelStyle.Normal);
            parent.Controls.Add(lblPhone);

            TextBox txtPhone = new TextBox
            {
                Location = new Point(50, yPosition),
                Size = new Size(190, controlHeight),
                Name = "txtPhone"
            };
            ModernTheme.StyleTextBox(txtPhone);
            UIHelper.SetNumericOnly(txtPhone, false);
            UIHelper.SetPlaceholder(txtPhone, "ادخل رقم الهاتف", ModernTheme.TextSecondary);
            parent.Controls.Add(txtPhone);

            yPosition += controlHeight + spacing;

            // Email
            Label lblEmail = new Label
            {
                Text = "البريد الإلكتروني:",
                Location = new Point(250, yPosition),
                Size = new Size(100, labelHeight),
                TextAlign = ContentAlignment.MiddleRight
            };
            ModernTheme.StyleLabel(lblEmail, LabelStyle.Normal);
            parent.Controls.Add(lblEmail);

            TextBox txtEmail = new TextBox
            {
                Location = new Point(50, yPosition),
                Size = new Size(190, controlHeight),
                Name = "txtEmail"
            };
            ModernTheme.StyleTextBox(txtEmail);
            UIHelper.SetPlaceholder(txtEmail, "example@email.com", ModernTheme.TextSecondary);
            parent.Controls.Add(txtEmail);

            yPosition += controlHeight + spacing;

            // Credit Limit
            Label lblCredit = new Label
            {
                Text = "الحد الائتماني:",
                Location = new Point(250, yPosition),
                Size = new Size(100, labelHeight),
                TextAlign = ContentAlignment.MiddleRight
            };
            ModernTheme.StyleLabel(lblCredit, LabelStyle.Normal);
            parent.Controls.Add(lblCredit);

            TextBox txtCredit = new TextBox
            {
                Location = new Point(50, yPosition),
                Size = new Size(190, controlHeight),
                Name = "txtCreditLimit"
            };
            ModernTheme.StyleTextBox(txtCredit);
            UIHelper.SetNumericOnly(txtCredit, true);
            UIHelper.SetPlaceholder(txtCredit, "0.00", ModernTheme.TextSecondary);
            parent.Controls.Add(txtCredit);

            yPosition += controlHeight + spacing + 10;

            // Status GroupBox
            GroupBox grpStatus = new GroupBox
            {
                Text = "حالة العميل",
                Location = new Point(50, yPosition),
                Size = new Size(300, 80)
            };
            ModernTheme.StyleGroupBox(grpStatus);

            RadioButton rbActive = new RadioButton
            {
                Text = "نشط",
                Location = new Point(200, 25),
                Checked = true
            };

            RadioButton rbInactive = new RadioButton
            {
                Text = "غير نشط",
                Location = new Point(100, 25)
            };

            grpStatus.Controls.Add(rbActive);
            grpStatus.Controls.Add(rbInactive);
            parent.Controls.Add(grpStatus);
        }

        private void AddDataGridExample(Panel parent)
        {
            DataGridView dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                Name = "dgvCustomers"
            };

            ModernTheme.StyleDataGridView(dgv);
            UIHelper.EnableRowHighlight(dgv);

            // Add sample columns
            dgv.Columns.Add("ID", "الكود");
            dgv.Columns.Add("Name", "الاسم");
            dgv.Columns.Add("Phone", "الهاتف");
            dgv.Columns.Add("Email", "البريد الإلكتروني");
            dgv.Columns.Add("Credit", "الحد الائتماني");
            dgv.Columns.Add("Status", "الحالة");

            // Add sample data
            dgv.Rows.Add("1", "أحمد محمد", "01012345678", "ahmed@example.com", "5000", "نشط");
            dgv.Rows.Add("2", "فاطمة علي", "01123456789", "fatma@example.com", "3000", "نشط");
            dgv.Rows.Add("3", "محمود حسن", "01234567890", "mahmoud@example.com", "10000", "غير نشط");

            parent.Controls.Add(dgv);
        }

        private void AddButtons(Panel parent)
        {
            FlowLayoutPanel flowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.RightToLeft,
                Padding = new Padding(0)
            };

            // Save button
            Button btnSave = ModernTheme.CreateButton("حفظ", ButtonStyle.Success, 100);
            btnSave.Click += (s, e) => UIHelper.ShowMessage("تم الحفظ بنجاح", "نجاح", MessageType.Success);
            flowPanel.Controls.Add(btnSave);

            // Add spacer
            flowPanel.Controls.Add(new Panel { Width = 10 });

            // Delete button
            Button btnDelete = ModernTheme.CreateButton("حذف", ButtonStyle.Danger, 100);
            btnDelete.Click += (s, e) =>
            {
                if (UIHelper.ShowMessage("هل أنت متأكد من الحذف؟", "تأكيد", MessageType.Question) == DialogResult.Yes)
                {
                    UIHelper.ShowMessage("تم الحذف بنجاح", "نجاح", MessageType.Success);
                }
            };
            flowPanel.Controls.Add(btnDelete);

            // Add spacer
            flowPanel.Controls.Add(new Panel { Width = 10 });

            // Print button
            Button btnPrint = ModernTheme.CreateButton("طباعة", ButtonStyle.Warning, 100);
            btnPrint.Click += (s, e) => UIHelper.ShowMessage("جاري الطباعة...", "معلومات", MessageType.Information);
            flowPanel.Controls.Add(btnPrint);

            // Add spacer
            flowPanel.Controls.Add(new Panel { Width = 10 });

            // New button
            Button btnNew = ModernTheme.CreateButton("جديد", ButtonStyle.Primary, 100);
            btnNew.Click += (s, e) => UIHelper.ShowMessage("فتح سجل جديد", "معلومات", MessageType.Information);
            flowPanel.Controls.Add(btnNew);

            // Add spacer
            flowPanel.Controls.Add(new Panel { Width = 10 });

            // Cancel button
            Button btnCancel = ModernTheme.CreateButton("إلغاء", ButtonStyle.Secondary, 100);
            btnCancel.Click += (s, e) => this.Close();
            flowPanel.Controls.Add(btnCancel);

            parent.Controls.Add(flowPanel);
        }
    }
}
