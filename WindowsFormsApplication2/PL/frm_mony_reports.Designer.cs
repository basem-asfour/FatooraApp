namespace WindowsFormsApplication2.PL
{
    partial class frm_mony_reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mony_reports));
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txt_total_mwrd = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.txt_total_ta7seel = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_total_msarif = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_cstmrs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_msarif = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_mwrden = new System.Windows.Forms.DataGridView();
            this.txt_safi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label_days = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_orders = new System.Windows.Forms.DataGridView();
            this.txt_total_nkdi = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txt_total_msdd = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.combo_mndoob = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.txt_totalBee3 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cstmrs)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_msarif)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mwrden)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "الي";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(303, 18);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeftLayout = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.Value = new System.DateTime(2018, 7, 9, 20, 8, 47, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txt_total_mwrd
            // 
            this.txt_total_mwrd.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_total_mwrd.Location = new System.Drawing.Point(722, 637);
            this.txt_total_mwrd.Name = "txt_total_mwrd";
            this.txt_total_mwrd.Size = new System.Drawing.Size(158, 20);
            this.txt_total_mwrd.TabIndex = 29;
            this.txt_total_mwrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.MidnightBlue;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(722, 593);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(159, 44);
            this.button9.TabIndex = 28;
            this.button9.Text = "اجمالي تحصيل الي المورد";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // txt_total_ta7seel
            // 
            this.txt_total_ta7seel.BackColor = System.Drawing.Color.LightGreen;
            this.txt_total_ta7seel.Location = new System.Drawing.Point(394, 639);
            this.txt_total_ta7seel.Name = "txt_total_ta7seel";
            this.txt_total_ta7seel.Size = new System.Drawing.Size(133, 20);
            this.txt_total_ta7seel.TabIndex = 27;
            this.txt_total_ta7seel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.MidnightBlue;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.Location = new System.Drawing.Point(394, 595);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 44);
            this.button8.TabIndex = 26;
            this.button8.Text = "اجمالي تحصيل العملاء";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightCoral;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1164, 593);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(79, 64);
            this.button7.TabIndex = 25;
            this.button7.Text = "خروج";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(537, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 25);
            this.button5.TabIndex = 2;
            this.button5.Text = "بحث";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_total_msarif
            // 
            this.txt_total_msarif.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_total_msarif.Location = new System.Drawing.Point(557, 637);
            this.txt_total_msarif.Name = "txt_total_msarif";
            this.txt_total_msarif.Size = new System.Drawing.Size(158, 20);
            this.txt_total_msarif.TabIndex = 22;
            this.txt_total_msarif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_cstmrs);
            this.groupBox2.Location = new System.Drawing.Point(550, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 284);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تحصيل من العملاء";
            // 
            // dgv_cstmrs
            // 
            this.dgv_cstmrs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cstmrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cstmrs.Location = new System.Drawing.Point(0, 17);
            this.dgv_cstmrs.Name = "dgv_cstmrs";
            this.dgv_cstmrs.ReadOnly = true;
            this.dgv_cstmrs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cstmrs.Size = new System.Drawing.Size(680, 253);
            this.dgv_cstmrs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "من";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(557, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "اجمالي المصاريف";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2018, 7, 9, 20, 8, 47, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_msarif);
            this.groupBox1.Location = new System.Drawing.Point(4, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 284);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مصاريف";
            // 
            // dgv_msarif
            // 
            this.dgv_msarif.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_msarif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_msarif.Location = new System.Drawing.Point(7, 15);
            this.dgv_msarif.Name = "dgv_msarif";
            this.dgv_msarif.ReadOnly = true;
            this.dgv_msarif.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_msarif.Size = new System.Drawing.Size(521, 261);
            this.dgv_msarif.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_mwrden);
            this.groupBox3.Location = new System.Drawing.Point(550, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(686, 259);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "دفع للموردين";
            // 
            // dgv_mwrden
            // 
            this.dgv_mwrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mwrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mwrden.Location = new System.Drawing.Point(0, 17);
            this.dgv_mwrden.Name = "dgv_mwrden";
            this.dgv_mwrden.ReadOnly = true;
            this.dgv_mwrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mwrden.Size = new System.Drawing.Size(680, 236);
            this.dgv_mwrden.TabIndex = 1;
            // 
            // txt_safi
            // 
            this.txt_safi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_safi.Location = new System.Drawing.Point(924, 637);
            this.txt_safi.Name = "txt_safi";
            this.txt_safi.Size = new System.Drawing.Size(158, 20);
            this.txt_safi.TabIndex = 33;
            this.txt_safi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::WindowsFormsApplication2.Properties.Resources.money_icon__2_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(923, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 44);
            this.button2.TabIndex = 32;
            this.button2.Text = "صافي النقدية";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(936, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 25);
            this.button3.TabIndex = 5;
            this.button3.Text = "عرض معلومات اليوم";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGreen;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(1087, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 25);
            this.button4.TabIndex = 6;
            this.button4.Text = "عرض الكل";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label_days
            // 
            this.label_days.AutoSize = true;
            this.label_days.Location = new System.Drawing.Point(711, 8);
            this.label_days.Name = "label_days";
            this.label_days.Size = new System.Drawing.Size(0, 13);
            this.label_days.TabIndex = 36;
            this.label_days.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_orders);
            this.groupBox4.Location = new System.Drawing.Point(4, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(534, 259);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "فواتير البيع";
            // 
            // dgv_orders
            // 
            this.dgv_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orders.Location = new System.Drawing.Point(7, 15);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.ReadOnly = true;
            this.dgv_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_orders.Size = new System.Drawing.Size(521, 238);
            this.dgv_orders.TabIndex = 1;
            // 
            // txt_total_nkdi
            // 
            this.txt_total_nkdi.BackColor = System.Drawing.Color.LightGreen;
            this.txt_total_nkdi.Location = new System.Drawing.Point(4, 637);
            this.txt_total_nkdi.Name = "txt_total_nkdi";
            this.txt_total_nkdi.Size = new System.Drawing.Size(110, 20);
            this.txt_total_nkdi.TabIndex = 38;
            this.txt_total_nkdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MidnightBlue;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(3, 594);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 43);
            this.button6.TabIndex = 37;
            this.button6.Text = "اجمالي بيع نقدي";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // txt_total_msdd
            // 
            this.txt_total_msdd.BackColor = System.Drawing.Color.LightGreen;
            this.txt_total_msdd.Location = new System.Drawing.Point(257, 638);
            this.txt_total_msdd.Name = "txt_total_msdd";
            this.txt_total_msdd.Size = new System.Drawing.Size(131, 20);
            this.txt_total_msdd.TabIndex = 40;
            this.txt_total_msdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.MidnightBlue;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.Location = new System.Drawing.Point(256, 595);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(132, 43);
            this.button10.TabIndex = 39;
            this.button10.Text = "اجمالي مسدد فواتير العملاء";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Location = new System.Drawing.Point(1088, 599);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 55);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "تجاهل تحصيل الموردين";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // combo_mndoob
            // 
            this.combo_mndoob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_mndoob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_mndoob.FormattingEnabled = true;
            this.combo_mndoob.Location = new System.Drawing.Point(723, 5);
            this.combo_mndoob.Name = "combo_mndoob";
            this.combo_mndoob.Size = new System.Drawing.Size(198, 21);
            this.combo_mndoob.TabIndex = 3;
            this.combo_mndoob.SelectedIndexChanged += new System.EventHandler(this.combo_mndoob_SelectedIndexChanged);
            this.combo_mndoob.SelectionChangeCommitted += new System.EventHandler(this.combo_mndoob_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(648, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "اختيار المندوب:";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightGreen;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Location = new System.Drawing.Point(723, 26);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(198, 25);
            this.button11.TabIndex = 4;
            this.button11.Text = "بحث بالمندوب";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // txt_totalBee3
            // 
            this.txt_totalBee3.BackColor = System.Drawing.Color.LightGreen;
            this.txt_totalBee3.Location = new System.Drawing.Point(125, 638);
            this.txt_totalBee3.Name = "txt_totalBee3";
            this.txt_totalBee3.Size = new System.Drawing.Size(121, 20);
            this.txt_totalBee3.TabIndex = 46;
            this.txt_totalBee3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.MidnightBlue;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.Location = new System.Drawing.Point(124, 595);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(122, 43);
            this.button12.TabIndex = 45;
            this.button12.Text = "اجمالي فواتير العملاء";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // frm_mony_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 660);
            this.Controls.Add(this.txt_totalBee3);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.combo_mndoob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txt_total_msdd);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.txt_total_nkdi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label_days);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_safi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txt_total_mwrd);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.txt_total_ta7seel);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txt_total_msarif);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_mony_reports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير التحصيل والمصروفات";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cstmrs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_msarif)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mwrden)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txt_total_mwrd;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox txt_total_ta7seel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_total_msarif;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_cstmrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_msarif;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_mwrden;
        private System.Windows.Forms.TextBox txt_safi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label_days;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_orders;
        private System.Windows.Forms.TextBox txt_total_nkdi;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txt_total_msdd;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox combo_mndoob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox txt_totalBee3;
        private System.Windows.Forms.Button button12;
    }
}