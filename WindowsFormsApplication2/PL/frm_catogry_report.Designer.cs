namespace WindowsFormsApplication2.PL
{
    partial class frm_catogry_report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_catogry_report));
            this.button11 = new System.Windows.Forms.Button();
            this.combo_cat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mrtg3_bee3 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.txt_bee3 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_mrtg3_mbe3at = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.txt_safi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_mrtg3_mshtriat = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txt_qte_mrtg3_shraa = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_qte_shraa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_mshtriat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_mbe3at = new System.Windows.Forms.DataGridView();
            this.txt_qte_mrtg3_bee3 = new System.Windows.Forms.TextBox();
            this.txt_qte_bee3 = new System.Windows.Forms.TextBox();
            this.txt_mrtg3_shraa = new System.Windows.Forms.TextBox();
            this.txt_shraa = new System.Windows.Forms.TextBox();
            this.txt_qte_safi = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mrtg3_mbe3at)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mrtg3_mshtriat)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mshtriat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mbe3at)).BeginInit();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(1000, 20);
            this.button11.Margin = new System.Windows.Forms.Padding(5);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(5);
            this.button11.Size = new System.Drawing.Size(200, 35);
            this.button11.TabIndex = 69;
            this.button11.Text = "🔍 بحث بالنوع";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // combo_cat
            // 
            this.combo_cat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_cat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_cat.BackColor = System.Drawing.Color.White;
            this.combo_cat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_cat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_cat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.combo_cat.FormattingEnabled = true;
            this.combo_cat.Location = new System.Drawing.Point(800, 25);
            this.combo_cat.Margin = new System.Windows.Forms.Padding(5);
            this.combo_cat.Name = "combo_cat";
            this.combo_cat.Size = new System.Drawing.Size(190, 25);
            this.combo_cat.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(720, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 67;
            this.label7.Text = "📂 اختيار النوع";
            // 
            // txt_mrtg3_bee3
            // 
            this.txt_mrtg3_bee3.BackColor = System.Drawing.Color.LightGreen;
            this.txt_mrtg3_bee3.Location = new System.Drawing.Point(277, 635);
            this.txt_mrtg3_bee3.Name = "txt_mrtg3_bee3";
            this.txt_mrtg3_bee3.Size = new System.Drawing.Size(121, 20);
            this.txt_mrtg3_bee3.TabIndex = 66;
            this.txt_mrtg3_bee3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.MidnightBlue;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = global::WindowsFormsApplication2.Properties.Resources.remove_item1;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.Location = new System.Drawing.Point(211, 592);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(187, 43);
            this.button10.TabIndex = 65;
            this.button10.Text = "اجمالي مرتجع مبيعات";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // txt_bee3
            // 
            this.txt_bee3.BackColor = System.Drawing.Color.LightGreen;
            this.txt_bee3.Location = new System.Drawing.Point(70, 635);
            this.txt_bee3.Name = "txt_bee3";
            this.txt_bee3.Size = new System.Drawing.Size(121, 20);
            this.txt_bee3.TabIndex = 64;
            this.txt_bee3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.dgv_mrtg3_mbe3at);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBox4.Location = new System.Drawing.Point(10, 360);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(540, 260);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "🔄 مرتجع المبيعات";
            // 
            // dgv_mrtg3_mbe3at
            // 
            this.dgv_mrtg3_mbe3at.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mrtg3_mbe3at.BackgroundColor = System.Drawing.Color.White;
            this.dgv_mrtg3_mbe3at.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_mrtg3_mbe3at.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mrtg3_mbe3at.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dgv_mrtg3_mbe3at.Location = new System.Drawing.Point(10, 30);
            this.dgv_mrtg3_mbe3at.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_mrtg3_mbe3at.Name = "dgv_mrtg3_mbe3at";
            this.dgv_mrtg3_mbe3at.ReadOnly = true;
            this.dgv_mrtg3_mbe3at.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mrtg3_mbe3at.Size = new System.Drawing.Size(520, 220);
            this.dgv_mrtg3_mbe3at.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MidnightBlue;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(2, 592);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 43);
            this.button6.TabIndex = 63;
            this.button6.Text = "اجمالي مبيعات";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // txt_safi
            // 
            this.txt_safi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_safi.Location = new System.Drawing.Point(957, 638);
            this.txt_safi.Name = "txt_safi";
            this.txt_safi.Size = new System.Drawing.Size(158, 20);
            this.txt_safi.TabIndex = 60;
            this.txt_safi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::WindowsFormsApplication2.Properties.Resources.increase;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(878, 594);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 44);
            this.button2.TabIndex = 59;
            this.button2.Text = "صافي ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.dgv_mrtg3_mshtriat);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBox3.Location = new System.Drawing.Point(560, 360);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(690, 260);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "↩️ مرتجع المشتريات";
            // 
            // dgv_mrtg3_mshtriat
            // 
            this.dgv_mrtg3_mshtriat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mrtg3_mshtriat.BackgroundColor = System.Drawing.Color.White;
            this.dgv_mrtg3_mshtriat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_mrtg3_mshtriat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mrtg3_mshtriat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dgv_mrtg3_mshtriat.Location = new System.Drawing.Point(10, 30);
            this.dgv_mrtg3_mshtriat.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_mrtg3_mshtriat.Name = "dgv_mrtg3_mshtriat";
            this.dgv_mrtg3_mshtriat.ReadOnly = true;
            this.dgv_mrtg3_mshtriat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mrtg3_mshtriat.Size = new System.Drawing.Size(670, 220);
            this.dgv_mrtg3_mshtriat.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(280, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 19);
            this.label3.TabIndex = 57;
            this.label3.Text = "📅 إلى";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(302, 17);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeftLayout = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker2.TabIndex = 58;
            this.dateTimePicker2.Value = new System.DateTime(2018, 7, 9, 20, 8, 47, 0);
            // 
            // txt_qte_mrtg3_shraa
            // 
            this.txt_qte_mrtg3_shraa.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_qte_mrtg3_shraa.Location = new System.Drawing.Point(654, 636);
            this.txt_qte_mrtg3_shraa.Name = "txt_qte_mrtg3_shraa";
            this.txt_qte_mrtg3_shraa.Size = new System.Drawing.Size(62, 20);
            this.txt_qte_mrtg3_shraa.TabIndex = 56;
            this.txt_qte_mrtg3_shraa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.MidnightBlue;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = global::WindowsFormsApplication2.Properties.Resources.shopping_cart_remove2;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(654, 592);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(180, 44);
            this.button9.TabIndex = 55;
            this.button9.Text = "اجمالي مرتجع مشتريات";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightCoral;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::WindowsFormsApplication2.Properties.Resources.Close_icon2;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(1136, 597);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 59);
            this.button7.TabIndex = 54;
            this.button7.Text = "خروج";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(550, 20);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(5);
            this.button5.Size = new System.Drawing.Size(150, 35);
            this.button5.TabIndex = 53;
            this.button5.Text = "📅 بحث بالنوع والتاريخ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_qte_shraa
            // 
            this.txt_qte_shraa.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_qte_shraa.Location = new System.Drawing.Point(430, 636);
            this.txt_qte_shraa.Name = "txt_qte_shraa";
            this.txt_qte_shraa.Size = new System.Drawing.Size(67, 20);
            this.txt_qte_shraa.TabIndex = 51;
            this.txt_qte_shraa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dgv_mshtriat);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBox2.Location = new System.Drawing.Point(560, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(690, 290);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "🛒 المشتريات";
            // 
            // dgv_mshtriat
            // 
            this.dgv_mshtriat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mshtriat.BackgroundColor = System.Drawing.Color.White;
            this.dgv_mshtriat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_mshtriat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mshtriat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dgv_mshtriat.Location = new System.Drawing.Point(10, 30);
            this.dgv_mshtriat.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_mshtriat.Name = "dgv_mshtriat";
            this.dgv_mshtriat.ReadOnly = true;
            this.dgv_mshtriat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mshtriat.Size = new System.Drawing.Size(670, 250);
            this.dgv_mshtriat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "📅 من";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::WindowsFormsApplication2.Properties.Resources.shopping_cart_full;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(430, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 44);
            this.button1.TabIndex = 45;
            this.button1.Text = "اجمالي مشتريات";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker1.TabIndex = 52;
            this.dateTimePicker1.Value = new System.DateTime(2018, 7, 9, 20, 8, 47, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgv_mbe3at);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBox1.Location = new System.Drawing.Point(10, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(540, 290);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "📈 المبيعات";
            // 
            // dgv_mbe3at
            // 
            this.dgv_mbe3at.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mbe3at.BackgroundColor = System.Drawing.Color.White;
            this.dgv_mbe3at.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_mbe3at.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mbe3at.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dgv_mbe3at.Location = new System.Drawing.Point(10, 30);
            this.dgv_mbe3at.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_mbe3at.Name = "dgv_mbe3at";
            this.dgv_mbe3at.ReadOnly = true;
            this.dgv_mbe3at.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mbe3at.Size = new System.Drawing.Size(520, 250);
            this.dgv_mbe3at.TabIndex = 1;
            // 
            // txt_qte_mrtg3_bee3
            // 
            this.txt_qte_mrtg3_bee3.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_qte_mrtg3_bee3.Location = new System.Drawing.Point(211, 635);
            this.txt_qte_mrtg3_bee3.Name = "txt_qte_mrtg3_bee3";
            this.txt_qte_mrtg3_bee3.Size = new System.Drawing.Size(67, 20);
            this.txt_qte_mrtg3_bee3.TabIndex = 70;
            this.txt_qte_mrtg3_bee3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_qte_bee3
            // 
            this.txt_qte_bee3.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_qte_bee3.Location = new System.Drawing.Point(3, 635);
            this.txt_qte_bee3.Name = "txt_qte_bee3";
            this.txt_qte_bee3.Size = new System.Drawing.Size(67, 20);
            this.txt_qte_bee3.TabIndex = 70;
            this.txt_qte_bee3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_mrtg3_shraa
            // 
            this.txt_mrtg3_shraa.BackColor = System.Drawing.Color.LightGreen;
            this.txt_mrtg3_shraa.Location = new System.Drawing.Point(716, 636);
            this.txt_mrtg3_shraa.Name = "txt_mrtg3_shraa";
            this.txt_mrtg3_shraa.Size = new System.Drawing.Size(118, 20);
            this.txt_mrtg3_shraa.TabIndex = 66;
            this.txt_mrtg3_shraa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_shraa
            // 
            this.txt_shraa.BackColor = System.Drawing.Color.LightGreen;
            this.txt_shraa.Location = new System.Drawing.Point(497, 636);
            this.txt_shraa.Name = "txt_shraa";
            this.txt_shraa.Size = new System.Drawing.Size(118, 20);
            this.txt_shraa.TabIndex = 66;
            this.txt_shraa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_qte_safi
            // 
            this.txt_qte_safi.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_qte_safi.Location = new System.Drawing.Point(878, 638);
            this.txt_qte_safi.Name = "txt_qte_safi";
            this.txt_qte_safi.Size = new System.Drawing.Size(79, 20);
            this.txt_qte_safi.TabIndex = 56;
            this.txt_qte_safi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_catogry_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.txt_qte_bee3);
            this.Controls.Add(this.txt_qte_mrtg3_bee3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.combo_cat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_shraa);
            this.Controls.Add(this.txt_mrtg3_shraa);
            this.Controls.Add(this.txt_mrtg3_bee3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.txt_bee3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txt_safi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txt_qte_safi);
            this.Controls.Add(this.txt_qte_mrtg3_shraa);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txt_qte_shraa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frm_catogry_report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "📊 تقرير الأنواع الأساسية - نظام إدارة المبيعات";
            this.Load += new System.EventHandler(this.frm_catogry_report_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mrtg3_mbe3at)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mrtg3_mshtriat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mshtriat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mbe3at)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox combo_cat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mrtg3_bee3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox txt_bee3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_mrtg3_mbe3at;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txt_safi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_mrtg3_mshtriat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txt_qte_mrtg3_shraa;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_qte_shraa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_mshtriat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_mbe3at;
        private System.Windows.Forms.TextBox txt_qte_mrtg3_bee3;
        private System.Windows.Forms.TextBox txt_qte_bee3;
        private System.Windows.Forms.TextBox txt_mrtg3_shraa;
        private System.Windows.Forms.TextBox txt_shraa;
        private System.Windows.Forms.TextBox txt_qte_safi;
    }
}