namespace WindowsFormsApplication2.PL
{
    partial class frm_from_mwrdeen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_from_mwrdeen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView_asnaf = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmwrd_nme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmwrd_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmwrd_adress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView_fwater = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmtpakii = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmsdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_mrtg3_mshtriat = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mrtg3 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_all_mrtg3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label_id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_rseed_first = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_asnaf)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fwater)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mrtg3_mshtriat)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_mrtg3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.dataGridView_asnaf);
            this.groupBox1.Location = new System.Drawing.Point(683, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(824, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة اصناف الفاتورة المحددة";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(0, 375);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(143, 36);
            this.button8.TabIndex = 13;
            this.button8.Text = "refresh";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SpringGreen;
            this.button5.Image = global::WindowsFormsApplication2.Properties.Resources.add_item;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(572, 362);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 50);
            this.button5.TabIndex = 10;
            this.button5.Text = "اضافة صنف";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.PeachPuff;
            this.button6.Location = new System.Drawing.Point(405, 377);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 36);
            this.button6.TabIndex = 11;
            this.button6.Text = "تعديل";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightCoral;
            this.button7.Image = global::WindowsFormsApplication2.Properties.Resources.remove_item1;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(233, 362);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(181, 50);
            this.button7.TabIndex = 12;
            this.button7.Text = "حذف المحدد";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView_asnaf
            // 
            this.dataGridView_asnaf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_asnaf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_asnaf.Location = new System.Drawing.Point(4, 20);
            this.dataGridView_asnaf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_asnaf.Name = "dataGridView_asnaf";
            this.dataGridView_asnaf.RowHeadersWidth = 51;
            this.dataGridView_asnaf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_asnaf.Size = new System.Drawing.Size(812, 335);
            this.dataGridView_asnaf.TabIndex = 0;
            this.dataGridView_asnaf.DoubleClick += new System.EventHandler(this.dataGridView_asnaf_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المورد:";
            // 
            // txtmwrd_nme
            // 
            this.txtmwrd_nme.Location = new System.Drawing.Point(108, 15);
            this.txtmwrd_nme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmwrd_nme.Name = "txtmwrd_nme";
            this.txtmwrd_nme.Size = new System.Drawing.Size(231, 22);
            this.txtmwrd_nme.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "التليفون:";
            // 
            // txtmwrd_phone
            // 
            this.txtmwrd_phone.Location = new System.Drawing.Point(411, 15);
            this.txtmwrd_phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmwrd_phone.Name = "txtmwrd_phone";
            this.txtmwrd_phone.Size = new System.Drawing.Size(231, 22);
            this.txtmwrd_phone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "العنوان:";
            // 
            // txtmwrd_adress
            // 
            this.txtmwrd_adress.Location = new System.Drawing.Point(719, 15);
            this.txtmwrd_adress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmwrd_adress.Multiline = true;
            this.txtmwrd_adress.Name = "txtmwrd_adress";
            this.txtmwrd_adress.Size = new System.Drawing.Size(285, 24);
            this.txtmwrd_adress.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.dataGridView_fwater);
            this.groupBox2.Location = new System.Drawing.Point(16, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(659, 417);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "قائمة فواتير المورد";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.Image = global::WindowsFormsApplication2.Properties.Resources.shopping_cart_add2;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(445, 362);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "اضافة فاتورة";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PeachPuff;
            this.button3.Image = global::WindowsFormsApplication2.Properties.Resources.shopping_cart_info;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(264, 362);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 49);
            this.button3.TabIndex = 8;
            this.button3.Text = "تعديل";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Image = global::WindowsFormsApplication2.Properties.Resources.shopping_cart_remove2;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(73, 362);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 49);
            this.button4.TabIndex = 9;
            this.button4.Text = "حذف المحدد";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView_fwater
            // 
            this.dataGridView_fwater.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_fwater.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_fwater.Location = new System.Drawing.Point(4, 20);
            this.dataGridView_fwater.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_fwater.Name = "dataGridView_fwater";
            this.dataGridView_fwater.RowHeadersWidth = 51;
            this.dataGridView_fwater.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_fwater.Size = new System.Drawing.Size(647, 335);
            this.dataGridView_fwater.TabIndex = 0;
            this.dataGridView_fwater.Click += new System.EventHandler(this.dataGridView_fwater_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Image = global::WindowsFormsApplication2.Properties.Resources.decrease;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(1095, 714);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 39);
            this.label5.TabIndex = 16;
            this.label5.Text = "مدان ب";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtmtpakii
            // 
            this.txtmtpakii.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtmtpakii.Location = new System.Drawing.Point(1095, 754);
            this.txtmtpakii.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmtpakii.Name = "txtmtpakii";
            this.txtmtpakii.ReadOnly = true;
            this.txtmtpakii.Size = new System.Drawing.Size(211, 22);
            this.txtmtpakii.TabIndex = 15;
            this.txtmtpakii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Image = global::WindowsFormsApplication2.Properties.Resources.increase;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(861, 714);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 39);
            this.label4.TabIndex = 14;
            this.label4.Text = "مسدد منها";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtmsdd
            // 
            this.txtmsdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtmsdd.Location = new System.Drawing.Point(861, 754);
            this.txtmsdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmsdd.Name = "txtmsdd";
            this.txtmsdd.ReadOnly = true;
            this.txtmsdd.Size = new System.Drawing.Size(224, 22);
            this.txtmsdd.TabIndex = 13;
            this.txtmsdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Image = global::WindowsFormsApplication2.Properties.Resources.shopping_cart_accept1;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(408, 714);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "اجمالي المشتريات";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txttotal.Location = new System.Drawing.Point(408, 753);
            this.txttotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(276, 22);
            this.txttotal.TabIndex = 11;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_mrtg3_mshtriat);
            this.groupBox3.Location = new System.Drawing.Point(737, 471);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(765, 238);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "قائمة مرتجع مشتريات الفاتورة المحددة";
            // 
            // dgv_mrtg3_mshtriat
            // 
            this.dgv_mrtg3_mshtriat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mrtg3_mshtriat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mrtg3_mshtriat.Location = new System.Drawing.Point(4, 23);
            this.dgv_mrtg3_mshtriat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_mrtg3_mshtriat.Name = "dgv_mrtg3_mshtriat";
            this.dgv_mrtg3_mshtriat.RowHeadersWidth = 51;
            this.dgv_mrtg3_mshtriat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mrtg3_mshtriat.Size = new System.Drawing.Size(745, 204);
            this.dgv_mrtg3_mshtriat.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Image = global::WindowsFormsApplication2.Properties.Resources.shopping_cart_remove2;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(693, 714);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 39);
            this.label7.TabIndex = 18;
            this.label7.Text = "اجمالي مرتجع المشتريات";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_mrtg3
            // 
            this.txt_mrtg3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_mrtg3.Location = new System.Drawing.Point(693, 754);
            this.txt_mrtg3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mrtg3.Name = "txt_mrtg3";
            this.txt_mrtg3.ReadOnly = true;
            this.txt_mrtg3.Size = new System.Drawing.Size(159, 22);
            this.txt_mrtg3.TabIndex = 17;
            this.txt_mrtg3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_all_mrtg3);
            this.groupBox4.Location = new System.Drawing.Point(12, 473);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(717, 238);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "قائمة مرتجع مشتريات المورد";
            // 
            // dgv_all_mrtg3
            // 
            this.dgv_all_mrtg3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_all_mrtg3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_all_mrtg3.Location = new System.Drawing.Point(4, 23);
            this.dgv_all_mrtg3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_all_mrtg3.Name = "dgv_all_mrtg3";
            this.dgv_all_mrtg3.RowHeadersWidth = 51;
            this.dgv_all_mrtg3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_all_mrtg3.Size = new System.Drawing.Size(701, 204);
            this.dgv_all_mrtg3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_close_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1357, 716);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 62);
            this.button1.TabIndex = 14;
            this.button1.Text = "خروج";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SpringGreen;
            this.button9.Image = global::WindowsFormsApplication2.Properties.Resources.payment_icon;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(16, 714);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(181, 65);
            this.button9.TabIndex = 14;
            this.button9.Text = "مدفوعات المورد";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "refresh";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1260, 1);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(247, 49);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.Text = "refresh";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(1168, 43);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(58, 16);
            this.label_id.TabIndex = 19;
            this.label_id.Text = "كود المورد";
            this.label_id.Visible = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Image = global::WindowsFormsApplication2.Properties.Resources.budget;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(240, 714);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 39);
            this.label8.TabIndex = 21;
            this.label8.Text = "رصيد أول";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_rseed_first
            // 
            this.txt_rseed_first.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_rseed_first.Location = new System.Drawing.Point(240, 754);
            this.txt_rseed_first.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_rseed_first.Name = "txt_rseed_first";
            this.txt_rseed_first.ReadOnly = true;
            this.txt_rseed_first.Size = new System.Drawing.Size(159, 22);
            this.txt_rseed_first.TabIndex = 20;
            this.txt_rseed_first.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.MidnightBlue;
            this.button10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_print_48;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.Location = new System.Drawing.Point(1013, 1);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(239, 44);
            this.button10.TabIndex = 22;
            this.button10.Text = "طباعة تقرير المورد";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // frm_from_mwrdeen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 790);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_rseed_first);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_mrtg3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmtpakii);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmsdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmwrd_adress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmwrd_phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtmwrd_nme);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_from_mwrdeen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فواتير المورد";
            this.Load += new System.EventHandler(this.frm_from_mwrdeen_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_asnaf)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fwater)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mrtg3_mshtriat)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_mrtg3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox txtmwrd_nme;
        public System.Windows.Forms.TextBox txtmwrd_phone;
        public System.Windows.Forms.TextBox txtmwrd_adress;
        public System.Windows.Forms.DataGridView dataGridView_fwater;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        public System.Windows.Forms.DataGridView dataGridView_asnaf;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtmtpakii;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtmsdd;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView dgv_mrtg3_mshtriat;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_mrtg3;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.DataGridView dgv_all_mrtg3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        public System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_rseed_first;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button10;
    }
}