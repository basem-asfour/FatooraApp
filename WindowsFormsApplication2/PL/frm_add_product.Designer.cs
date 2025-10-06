namespace WindowsFormsApplication2.PL
{
    partial class frm_add_product
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_product));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_serial = new System.Windows.Forms.TextBox();
            this.dgv_pre_prd = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.combo_stores = new System.Windows.Forms.ComboBox();
            this.txtnme = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtmsthlk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpshr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttmd = new System.Windows.Forms.TextBox();
            this.txtpb = new System.Windows.Forms.TextBox();
            this.txtpg = new System.Windows.Forms.TextBox();
            this.txtqte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pre_prd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txt_serial);
            this.groupBox1.Controls.Add(this.dgv_pre_prd);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.combo_stores);
            this.groupBox1.Controls.Add(this.txtnme);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtmsthlk);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtpshr);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnok);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pbox);
            this.groupBox1.Controls.Add(this.txttmd);
            this.groupBox1.Controls.Add(this.txtpb);
            this.groupBox1.Controls.Add(this.txtpg);
            this.groupBox1.Controls.Add(this.txtqte);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 591);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الصنف";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_serial
            // 
            this.txt_serial.Location = new System.Drawing.Point(6, 27);
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.Size = new System.Drawing.Size(214, 27);
            this.txt_serial.TabIndex = 25;
            this.txt_serial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_serial_KeyDown);
            // 
            // dgv_pre_prd
            // 
            this.dgv_pre_prd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pre_prd.Location = new System.Drawing.Point(55, 302);
            this.dgv_pre_prd.Name = "dgv_pre_prd";
            this.dgv_pre_prd.RowHeadersWidth = 51;
            this.dgv_pre_prd.Size = new System.Drawing.Size(240, 32);
            this.dgv_pre_prd.TabIndex = 24;
            this.dgv_pre_prd.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 33);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(70, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "سيريال";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 75);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(67, 21);
            this.label10.TabIndex = 23;
            this.label10.Text = "المخزن";
            // 
            // combo_stores
            // 
            this.combo_stores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_stores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_stores.FormattingEnabled = true;
            this.combo_stores.Location = new System.Drawing.Point(6, 72);
            this.combo_stores.Name = "combo_stores";
            this.combo_stores.Size = new System.Drawing.Size(213, 27);
            this.combo_stores.TabIndex = 22;
            // 
            // txtnme
            // 
            this.txtnme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtnme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtnme.FormattingEnabled = true;
            this.txtnme.Location = new System.Drawing.Point(7, 144);
            this.txtnme.Name = "txtnme";
            this.txtnme.Size = new System.Drawing.Size(213, 27);
            this.txtnme.TabIndex = 1;
            this.txtnme.SelectedIndexChanged += new System.EventHandler(this.txtnme_SelectedIndexChanged);
            this.txtnme.TextChanged += new System.EventHandler(this.txtnme_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 32);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 109);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(50, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "النوع";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 27);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtmsthlk
            // 
            this.txtmsthlk.Location = new System.Drawing.Point(6, 318);
            this.txtmsthlk.Name = "txtmsthlk";
            this.txtmsthlk.Size = new System.Drawing.Size(213, 27);
            this.txtmsthlk.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 321);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(133, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "سعر المستهلك";
            // 
            // txtpshr
            // 
            this.txtpshr.Location = new System.Drawing.Point(7, 216);
            this.txtpshr.Name = "txtpshr";
            this.txtpshr.Size = new System.Drawing.Size(213, 27);
            this.txtpshr.TabIndex = 3;
            this.txtpshr.TextChanged += new System.EventHandler(this.txtshr_TextChanged);
            this.txtpshr.Validated += new System.EventHandler(this.txtpshr_Validated_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 219);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "سعر الشراء";
            // 
            // txttmd
            // 
            this.txttmd.Location = new System.Drawing.Point(7, 354);
            this.txttmd.Name = "txttmd";
            this.txttmd.Size = new System.Drawing.Size(213, 27);
            this.txttmd.TabIndex = 7;
            // 
            // txtpb
            // 
            this.txtpb.Location = new System.Drawing.Point(7, 285);
            this.txtpb.Name = "txtpb";
            this.txtpb.Size = new System.Drawing.Size(212, 27);
            this.txtpb.TabIndex = 5;
            this.txtpb.Validated += new System.EventHandler(this.txtpb_Validated);
            // 
            // txtpg
            // 
            this.txtpg.Location = new System.Drawing.Point(7, 251);
            this.txtpg.Name = "txtpg";
            this.txtpg.Size = new System.Drawing.Size(212, 27);
            this.txtpg.TabIndex = 4;
            this.txtpg.Validated += new System.EventHandler(this.txtpshr_Validated);
            // 
            // txtqte
            // 
            this.txtqte.Location = new System.Drawing.Point(7, 180);
            this.txtqte.Name = "txtqte";
            this.txtqte.Size = new System.Drawing.Size(213, 27);
            this.txtqte.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 390);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(111, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "صوره الصنف";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 357);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(138, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "اجمالي المدفوع";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 292);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "سعر البيع";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 258);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "سعر القطعه جمله";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 183);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "الكميه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 149);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الصنف";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_barcode_48;
            this.pictureBox1.Location = new System.Drawing.Point(326, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 40);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnok.Image = ((System.Drawing.Image)(resources.GetObject("btnok.Image")));
            this.btnok.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnok.Location = new System.Drawing.Point(148, 539);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(123, 42);
            this.btnok.TabIndex = 9;
            this.btnok.Text = "اضافة";
            this.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_close_48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(-7, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "الغاء";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_e_magazine_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(7, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "اختيار صوره";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbox
            // 
            this.pbox.Image = global::WindowsFormsApplication2.Properties.Resources._101;
            this.pbox.Location = new System.Drawing.Point(7, 383);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(229, 114);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox.TabIndex = 13;
            this.pbox.TabStop = false;
            // 
            // frm_add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 606);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_add_product";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه صنف جديد";
            this.Load += new System.EventHandler(this.frm_add_product_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pre_prd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnok;
        public System.Windows.Forms.PictureBox pbox;
        public System.Windows.Forms.TextBox txttmd;
        public System.Windows.Forms.TextBox txtpb;
        public System.Windows.Forms.TextBox txtpg;
        public System.Windows.Forms.TextBox txtqte;
        public System.Windows.Forms.TextBox txtpshr;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtmsthlk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox txtnme;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox combo_stores;
        private System.Windows.Forms.DataGridView dgv_pre_prd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox txt_serial;
    }
}