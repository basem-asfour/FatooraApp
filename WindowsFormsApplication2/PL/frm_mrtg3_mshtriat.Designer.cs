namespace WindowsFormsApplication2.PL
{
    partial class frm_mrtg3_mshtriat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mrtg3_mshtriat));
            this.dataGridView2_products = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_quentity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_open = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_fatora = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1_orders = new System.Windows.Forms.DataGridView();
            this.label_mwrd_id = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label_mwrd_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_products)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2_products
            // 
            this.dataGridView2_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_products.Location = new System.Drawing.Point(6, 17);
            this.dataGridView2_products.Name = "dataGridView2_products";
            this.dataGridView2_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2_products.Size = new System.Drawing.Size(620, 388);
            this.dataGridView2_products.TabIndex = 3;
            this.dataGridView2_products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_products_CellContentClick);
            this.dataGridView2_products.Click += new System.EventHandler(this.dataGridView2_products_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bunifuFlatButton2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_quentity);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.bunifuiOSSwitch1);
            this.groupBox3.Location = new System.Drawing.Point(519, 525);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(626, 111);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الكمية المسترجعة";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "ارجاع الكمية المحددة";
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
            this.bunifuFlatButton2.Text = "ارجاع الكمية المحددة";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "الكمية";
            // 
            // txt_quentity
            // 
            this.txt_quentity.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_quentity.Location = new System.Drawing.Point(358, 70);
            this.txt_quentity.Name = "txt_quentity";
            this.txt_quentity.Size = new System.Drawing.Size(159, 20);
            this.txt_quentity.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 34);
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
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(385, 27);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch1.TabIndex = 2;
            this.bunifuiOSSwitch1.Value = true;
            this.bunifuiOSSwitch1.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch1_OnValueChange);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_open);
            this.groupBox2.Controls.Add(this.btn_add_fatora);
            this.groupBox2.Controls.Add(this.dataGridView2_products);
            this.groupBox2.Location = new System.Drawing.Point(519, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 468);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "محتوي الفاتورة";
            // 
            // btn_open
            // 
            this.btn_open.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_open.BorderRadius = 0;
            this.btn_open.ButtonText = "فتح فاتورة باسم المورد المحدد";
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
            this.btn_open.Location = new System.Drawing.Point(467, 411);
            this.btn_open.Name = "btn_open";
            this.btn_open.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_open.OnHovercolor = System.Drawing.Color.LightGreen;
            this.btn_open.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_open.selected = false;
            this.btn_open.Size = new System.Drawing.Size(159, 51);
            this.btn_open.TabIndex = 10;
            this.btn_open.Text = "فتح فاتورة باسم المورد المحدد";
            this.btn_open.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_open.Textcolor = System.Drawing.Color.White;
            this.btn_open.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.Visible = false;
            // 
            // btn_add_fatora
            // 
            this.btn_add_fatora.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_add_fatora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_add_fatora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_fatora.BorderRadius = 0;
            this.btn_add_fatora.ButtonText = "ارجاع كامل اصناف الفاتورة";
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
            this.btn_add_fatora.Location = new System.Drawing.Point(6, 411);
            this.btn_add_fatora.Name = "btn_add_fatora";
            this.btn_add_fatora.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_add_fatora.OnHovercolor = System.Drawing.Color.LightGreen;
            this.btn_add_fatora.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_fatora.selected = false;
            this.btn_add_fatora.Size = new System.Drawing.Size(295, 51);
            this.btn_add_fatora.TabIndex = 9;
            this.btn_add_fatora.Text = "ارجاع كامل اصناف الفاتورة";
            this.btn_add_fatora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_fatora.Textcolor = System.Drawing.Color.White;
            this.btn_add_fatora.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_fatora.Click += new System.EventHandler(this.btn_add_fatora_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1_orders);
            this.groupBox1.Location = new System.Drawing.Point(3, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 585);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فواتير المورد";
            // 
            // dataGridView1_orders
            // 
            this.dataGridView1_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_orders.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1_orders.Name = "dataGridView1_orders";
            this.dataGridView1_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_orders.Size = new System.Drawing.Size(498, 560);
            this.dataGridView1_orders.TabIndex = 3;
            this.dataGridView1_orders.Click += new System.EventHandler(this.dataGridView1_orders_Click);
            // 
            // label_mwrd_id
            // 
            this.label_mwrd_id.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label_mwrd_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_mwrd_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mwrd_id.Location = new System.Drawing.Point(149, 3);
            this.label_mwrd_id.Name = "label_mwrd_id";
            this.label_mwrd_id.Size = new System.Drawing.Size(62, 46);
            this.label_mwrd_id.TabIndex = 19;
            this.label_mwrd_id.Text = "كود المورد";
            this.label_mwrd_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_mwrd_name
            // 
            this.label_mwrd_name.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label_mwrd_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mwrd_name.Location = new System.Drawing.Point(164, 2);
            this.label_mwrd_name.Name = "label_mwrd_name";
            this.label_mwrd_name.Size = new System.Drawing.Size(263, 47);
            this.label_mwrd_name.TabIndex = 15;
            this.label_mwrd_name.Text = "اسم المورد";
            this.label_mwrd_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "اختيار المورد";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::WindowsFormsApplication2.Properties.Resources.تنزيل__1_;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(3, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(140, 48);
            this.bunifuFlatButton1.TabIndex = 14;
            this.bunifuFlatButton1.Text = "اختيار المورد";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // frm_mrtg3_mshtriat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 643);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_mwrd_id);
            this.Controls.Add(this.label_mwrd_name);
            this.Controls.Add(this.bunifuFlatButton1);
            this.MaximizeBox = false;
            this.Name = "frm_mrtg3_mshtriat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة مرتجع المشتريات";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_products)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_orders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_open;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_fatora;
        private System.Windows.Forms.DataGridView dataGridView2_products;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_quentity;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1_orders;
        private Bunifu.Framework.UI.BunifuCustomLabel label_mwrd_id;
        private Bunifu.Framework.UI.BunifuCustomLabel label_mwrd_name;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}