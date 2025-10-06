namespace WindowsFormsApplication2.PL
{
    partial class frm_mrtg3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mrtg3));
            this.label_cstmr_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1_orders = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_open = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_fatora = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView2_products = new System.Windows.Forms.DataGridView();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pprice = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_quentity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelprd_name = new System.Windows.Forms.GroupBox();
            this.label_id = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pri = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_qnt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label_cstmr_id = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_orders)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_products)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.labelprd_name.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_cstmr_name
            // 
            this.label_cstmr_name.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label_cstmr_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cstmr_name.Location = new System.Drawing.Point(148, 3);
            this.label_cstmr_name.Name = "label_cstmr_name";
            this.label_cstmr_name.Size = new System.Drawing.Size(293, 27);
            this.label_cstmr_name.TabIndex = 1;
            this.label_cstmr_name.Text = "اسم العميل";
            this.label_cstmr_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1_orders);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 542);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فواتير العميل";
            // 
            // dataGridView1_orders
            // 
            this.dataGridView1_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_orders.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1_orders.Name = "dataGridView1_orders";
            this.dataGridView1_orders.ReadOnly = true;
            this.dataGridView1_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_orders.Size = new System.Drawing.Size(539, 517);
            this.dataGridView1_orders.TabIndex = 3;
            this.dataGridView1_orders.Click += new System.EventHandler(this.dataGridView1_orders_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_open);
            this.groupBox2.Controls.Add(this.btn_add_fatora);
            this.groupBox2.Controls.Add(this.dataGridView2_products);
            this.groupBox2.Location = new System.Drawing.Point(652, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 514);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "محتوي الفاتورة";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_open
            // 
            this.btn_open.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_open.BorderRadius = 0;
            this.btn_open.ButtonText = "فتح فاتورة باسم العميل المحدد";
            this.btn_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open.DisabledColor = System.Drawing.Color.Gray;
            this.btn_open.Enabled = false;
            this.btn_open.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_open.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_open.Iconimage")));
            this.btn_open.Iconimage_right = null;
            this.btn_open.Iconimage_right_Selected = null;
            this.btn_open.Iconimage_Selected = null;
            this.btn_open.IconMarginLeft = 0;
            this.btn_open.IconMarginRight = 0;
            this.btn_open.IconRightVisible = true;
            this.btn_open.IconRightZoom = 0D;
            this.btn_open.IconVisible = true;
            this.btn_open.IconZoom = 90D;
            this.btn_open.IsTab = false;
            this.btn_open.Location = new System.Drawing.Point(377, 455);
            this.btn_open.Name = "btn_open";
            this.btn_open.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_open.OnHovercolor = System.Drawing.Color.LightGreen;
            this.btn_open.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_open.selected = false;
            this.btn_open.Size = new System.Drawing.Size(159, 51);
            this.btn_open.TabIndex = 10;
            this.btn_open.Text = "فتح فاتورة باسم العميل المحدد";
            this.btn_open.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_open.Textcolor = System.Drawing.Color.White;
            this.btn_open.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.Visible = false;
            this.btn_open.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // btn_add_fatora
            // 
            this.btn_add_fatora.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_add_fatora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_add_fatora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_fatora.BorderRadius = 0;
            this.btn_add_fatora.ButtonText = "تأكيد اضافة فاتورة الاسترجاع";
            this.btn_add_fatora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_fatora.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_fatora.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add_fatora.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_add_fatora.Iconimage")));
            this.btn_add_fatora.Iconimage_right = null;
            this.btn_add_fatora.Iconimage_right_Selected = null;
            this.btn_add_fatora.Iconimage_Selected = null;
            this.btn_add_fatora.IconMarginLeft = 0;
            this.btn_add_fatora.IconMarginRight = 0;
            this.btn_add_fatora.IconRightVisible = true;
            this.btn_add_fatora.IconRightZoom = 0D;
            this.btn_add_fatora.IconVisible = true;
            this.btn_add_fatora.IconZoom = 90D;
            this.btn_add_fatora.IsTab = false;
            this.btn_add_fatora.Location = new System.Drawing.Point(6, 455);
            this.btn_add_fatora.Name = "btn_add_fatora";
            this.btn_add_fatora.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_add_fatora.OnHovercolor = System.Drawing.Color.LightGreen;
            this.btn_add_fatora.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_fatora.selected = false;
            this.btn_add_fatora.Size = new System.Drawing.Size(295, 51);
            this.btn_add_fatora.TabIndex = 9;
            this.btn_add_fatora.Text = "تأكيد اضافة فاتورة الاسترجاع";
            this.btn_add_fatora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_fatora.Textcolor = System.Drawing.Color.White;
            this.btn_add_fatora.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_fatora.Click += new System.EventHandler(this.btn_add_fatora_Click);
            // 
            // dataGridView2_products
            // 
            this.dataGridView2_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_products.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2_products.Name = "dataGridView2_products";
            this.dataGridView2_products.ReadOnly = true;
            this.dataGridView2_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2_products.Size = new System.Drawing.Size(539, 430);
            this.dataGridView2_products.TabIndex = 3;
            this.dataGridView2_products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_products_CellContentClick);
            this.dataGridView2_products.Click += new System.EventHandler(this.dataGridView2_products_Click);
            this.dataGridView2_products.DoubleClick += new System.EventHandler(this.dataGridView2_products_DoubleClick);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "اختيار العميل";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::WindowsFormsApplication2.Properties.Resources.Personnel_icon1;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(12, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(133, 48);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "اختيار العميل";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_pprice);
            this.groupBox3.Controls.Add(this.bunifuFlatButton2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_quentity);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.bunifuiOSSwitch1);
            this.groupBox3.Location = new System.Drawing.Point(652, 533);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 111);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الكمية المسترجعة";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "السعر";
            // 
            // txt_pprice
            // 
            this.txt_pprice.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_pprice.Location = new System.Drawing.Point(314, 82);
            this.txt_pprice.Name = "txt_pprice";
            this.txt_pprice.Size = new System.Drawing.Size(159, 20);
            this.txt_pprice.TabIndex = 9;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "استرجاع الكمية المحددة";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(20, 24);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.LightGreen;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(253, 77);
            this.bunifuFlatButton2.TabIndex = 8;
            this.bunifuFlatButton2.Text = "استرجاع الكمية المحددة";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "الكمية";
            // 
            // txt_quentity
            // 
            this.txt_quentity.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_quentity.Location = new System.Drawing.Point(315, 53);
            this.txt_quentity.Name = "txt_quentity";
            this.txt_quentity.Size = new System.Drawing.Size(159, 20);
            this.txt_quentity.TabIndex = 6;
            this.txt_quentity.TextChanged += new System.EventHandler(this.txt_quentity_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "اجمالي الكمية؟؟";
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(345, 24);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch1.TabIndex = 2;
            this.bunifuiOSSwitch1.Value = true;
            this.bunifuiOSSwitch1.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch1_OnValueChange);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Teal;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "اختيار الصنف";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Enabled = false;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(17, 16);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(182, 35);
            this.bunifuFlatButton3.TabIndex = 9;
            this.bunifuFlatButton3.Text = "اختيار الصنف";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "شراء صنف غير موجود";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Enabled = false;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(500, 398);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.Violet;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(249, 44);
            this.bunifuFlatButton4.TabIndex = 10;
            this.bunifuFlatButton4.Text = "شراء صنف غير موجود";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // labelprd_name
            // 
            this.labelprd_name.Controls.Add(this.bunifuFlatButton3);
            this.labelprd_name.Controls.Add(this.label_id);
            this.labelprd_name.Controls.Add(this.label_name);
            this.labelprd_name.Controls.Add(this.label5);
            this.labelprd_name.Controls.Add(this.txt_pri);
            this.labelprd_name.Controls.Add(this.bunifuFlatButton5);
            this.labelprd_name.Controls.Add(this.label1);
            this.labelprd_name.Controls.Add(this.txt_qnt);
            this.labelprd_name.Location = new System.Drawing.Point(80, 172);
            this.labelprd_name.Name = "labelprd_name";
            this.labelprd_name.Size = new System.Drawing.Size(539, 175);
            this.labelprd_name.TabIndex = 9;
            this.labelprd_name.TabStop = false;
            this.labelprd_name.Text = "شراء كمية من صنف موجود مسبقاَ";
            this.labelprd_name.Visible = false;
            // 
            // label_id
            // 
            this.label_id.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(474, 13);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(59, 41);
            this.label_id.TabIndex = 12;
            this.label_id.Text = "كود الصنف";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_name
            // 
            this.label_name.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(205, 16);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(263, 38);
            this.label_name.TabIndex = 11;
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "السعر";
            // 
            // txt_pri
            // 
            this.txt_pri.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_pri.Location = new System.Drawing.Point(315, 114);
            this.txt_pri.Name = "txt_pri";
            this.txt_pri.Size = new System.Drawing.Size(159, 20);
            this.txt_pri.TabIndex = 9;
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "اضافة الي الفاتورة";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(17, 57);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.LightGreen;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(253, 77);
            this.bunifuFlatButton5.TabIndex = 8;
            this.bunifuFlatButton5.Text = "اضافة الي الفاتورة";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "الكمية";
            // 
            // txt_qnt
            // 
            this.txt_qnt.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_qnt.Location = new System.Drawing.Point(315, 70);
            this.txt_qnt.Name = "txt_qnt";
            this.txt_qnt.Size = new System.Drawing.Size(159, 20);
            this.txt_qnt.TabIndex = 6;
            // 
            // label_cstmr_id
            // 
            this.label_cstmr_id.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label_cstmr_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_cstmr_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cstmr_id.Location = new System.Drawing.Point(145, 3);
            this.label_cstmr_id.Name = "label_cstmr_id";
            this.label_cstmr_id.Size = new System.Drawing.Size(48, 26);
            this.label_cstmr_id.TabIndex = 13;
            this.label_cstmr_id.Text = "كود العميل";
            this.label_cstmr_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_cstmr_id.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Azure;
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Location = new System.Drawing.Point(442, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(761, 48);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "نوع عملية الاسترجاع";
            // 
            // radioButton3
            // 
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton3.FlatAppearance.BorderSize = 10;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButton3.Location = new System.Drawing.Point(3, 16);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(218, 29);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "مرتجع اصناف غير موجودة";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton2.FlatAppearance.BorderSize = 10;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButton2.Location = new System.Drawing.Point(3, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(498, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "استرجاع اصناف غير مسبقة الشراء";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton1.FlatAppearance.BorderSize = 10;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButton1.Location = new System.Drawing.Point(501, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(257, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "استرجاع اصناف مسبقة الشراء";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "التاريخ : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // frm_mrtg3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 655);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label_cstmr_id);
            this.Controls.Add(this.labelprd_name);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_cstmr_name);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Name = "frm_mrtg3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مرتجع عميل";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_orders)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_products)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.labelprd_name.ResumeLayout(false);
            this.labelprd_name.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel label_cstmr_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2_products;
        private System.Windows.Forms.DataGridView dataGridView1_orders;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_quentity;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private System.Windows.Forms.GroupBox labelprd_name;
        private System.Windows.Forms.Label label5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_pri;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_qnt;
        private Bunifu.Framework.UI.BunifuCustomLabel label_name;
        private Bunifu.Framework.UI.BunifuCustomLabel label_id;
        private Bunifu.Framework.UI.BunifuFlatButton btn_open;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_fatora;
        private Bunifu.Framework.UI.BunifuCustomLabel label_cstmr_id;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_pprice;
    }
}