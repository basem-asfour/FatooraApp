namespace WindowsFormsApplication2.PL
{
    partial class frm_cstmr_pays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cstmr_pays));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radio_rd = new System.Windows.Forms.RadioButton();
            this.radioButton_5sm = new System.Windows.Forms.RadioButton();
            this.radioButton_تحصيل = new System.Windows.Forms.RadioButton();
            this.combo_mndoob = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label_first_rseed = new System.Windows.Forms.TextBox();
            this.label_total_mdfo3 = new System.Windows.Forms.Label();
            this.labl4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_nme = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mdfo3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Location = new System.Drawing.Point(10, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LightGreen;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.Location = new System.Drawing.Point(191, 23);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(109, 44);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "تحصيل المبلغ";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Location = new System.Drawing.Point(142, 23);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(107, 44);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "تعديل المحدد";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Visible = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightCoral;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Image = global::WindowsFormsApplication2.Properties.Resources.decrease;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(28, 23);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(134, 44);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "حذف المحدد";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.combo_mndoob);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_notes);
            this.groupBox3.Controls.Add(this.label_first_rseed);
            this.groupBox3.Controls.Add(this.label_total_mdfo3);
            this.groupBox3.Controls.Add(this.labl4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label_id);
            this.groupBox3.Controls.Add(this.label_nme);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_mdfo3);
            this.groupBox3.Location = new System.Drawing.Point(4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 376);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات التحصيل";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Azure;
            this.groupBox5.Controls.Add(this.radio_rd);
            this.groupBox5.Controls.Add(this.radioButton_5sm);
            this.groupBox5.Controls.Add(this.radioButton_تحصيل);
            this.groupBox5.Location = new System.Drawing.Point(38, 99);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(286, 39);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "نوع العملية";
            // 
            // radio_rd
            // 
            this.radio_rd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_rd.Dock = System.Windows.Forms.DockStyle.Right;
            this.radio_rd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radio_rd.FlatAppearance.BorderSize = 10;
            this.radio_rd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radio_rd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radio_rd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radio_rd.Location = new System.Drawing.Point(125, 16);
            this.radio_rd.Name = "radio_rd";
            this.radio_rd.Size = new System.Drawing.Size(92, 20);
            this.radio_rd.TabIndex = 2;
            this.radio_rd.TabStop = true;
            this.radio_rd.Text = "رد للعميل";
            this.radio_rd.UseVisualStyleBackColor = true;
            this.radio_rd.Visible = false;
            // 
            // radioButton_5sm
            // 
            this.radioButton_5sm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_5sm.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton_5sm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton_5sm.FlatAppearance.BorderSize = 10;
            this.radioButton_5sm.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton_5sm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButton_5sm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButton_5sm.Location = new System.Drawing.Point(3, 16);
            this.radioButton_5sm.Name = "radioButton_5sm";
            this.radioButton_5sm.Size = new System.Drawing.Size(104, 20);
            this.radioButton_5sm.TabIndex = 1;
            this.radioButton_5sm.TabStop = true;
            this.radioButton_5sm.Text = "خصم مسموح به";
            this.radioButton_5sm.UseVisualStyleBackColor = true;
            // 
            // radioButton_تحصيل
            // 
            this.radioButton_تحصيل.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_تحصيل.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton_تحصيل.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton_تحصيل.FlatAppearance.BorderSize = 10;
            this.radioButton_تحصيل.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton_تحصيل.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButton_تحصيل.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButton_تحصيل.Location = new System.Drawing.Point(217, 16);
            this.radioButton_تحصيل.Name = "radioButton_تحصيل";
            this.radioButton_تحصيل.Size = new System.Drawing.Size(66, 20);
            this.radioButton_تحصيل.TabIndex = 0;
            this.radioButton_تحصيل.TabStop = true;
            this.radioButton_تحصيل.Text = "تحصيل";
            this.radioButton_تحصيل.UseVisualStyleBackColor = true;
            // 
            // combo_mndoob
            // 
            this.combo_mndoob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_mndoob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_mndoob.FormattingEnabled = true;
            this.combo_mndoob.Location = new System.Drawing.Point(38, 236);
            this.combo_mndoob.Name = "combo_mndoob";
            this.combo_mndoob.Size = new System.Drawing.Size(256, 21);
            this.combo_mndoob.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "المندوب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "اي تحصيل بمبلغ  (0) سوف يتم حساب رصيد اول المبلغ كرصيد اول للعميل ";
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(38, 290);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(256, 80);
            this.txt_notes.TabIndex = 5;
            // 
            // label_first_rseed
            // 
            this.label_first_rseed.Location = new System.Drawing.Point(38, 151);
            this.label_first_rseed.Name = "label_first_rseed";
            this.label_first_rseed.Size = new System.Drawing.Size(227, 20);
            this.label_first_rseed.TabIndex = 1;
            // 
            // label_total_mdfo3
            // 
            this.label_total_mdfo3.AutoSize = true;
            this.label_total_mdfo3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label_total_mdfo3.Location = new System.Drawing.Point(185, 70);
            this.label_total_mdfo3.Name = "label_total_mdfo3";
            this.label_total_mdfo3.Size = new System.Drawing.Size(0, 13);
            this.label_total_mdfo3.TabIndex = 19;
            // 
            // labl4
            // 
            this.labl4.AutoSize = true;
            this.labl4.Location = new System.Drawing.Point(260, 70);
            this.labl4.Name = "labl4";
            this.labl4.Size = new System.Drawing.Size(92, 13);
            this.labl4.TabIndex = 18;
            this.labl4.Text = "اجمالي التحصيل : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ملاحظات : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "رصيد اول : ";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label_id.Location = new System.Drawing.Point(186, 24);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(0, 13);
            this.label_id.TabIndex = 15;
            // 
            // label_nme
            // 
            this.label_nme.AutoSize = true;
            this.label_nme.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label_nme.Location = new System.Drawing.Point(116, 48);
            this.label_nme.Name = "label_nme";
            this.label_nme.Size = new System.Drawing.Size(0, 13);
            this.label_nme.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "كود العميل : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "اسم العميل : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 207);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "التاريخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "المبلغ";
            // 
            // txt_mdfo3
            // 
            this.txt_mdfo3.Location = new System.Drawing.Point(38, 180);
            this.txt_mdfo3.Name = "txt_mdfo3";
            this.txt_mdfo3.Size = new System.Drawing.Size(256, 20);
            this.txt_mdfo3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(366, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 467);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة مدفوعات العميل";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(10, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 25);
            this.button3.TabIndex = 38;
            this.button3.Text = "عرض الكل";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(167, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 25);
            this.button1.TabIndex = 37;
            this.button1.Text = "عرض التحصيلات فقط";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "الي";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(466, 24);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeftLayout = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker2.TabIndex = 36;
            this.dateTimePicker2.Value = new System.DateTime(2018, 7, 9, 20, 8, 47, 0);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(362, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 25);
            this.button5.TabIndex = 34;
            this.button5.Text = "بحث";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(814, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "من";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(655, 24);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.RightToLeftLayout = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker3.TabIndex = 33;
            this.dateTimePicker3.Value = new System.DateTime(2018, 7, 9, 20, 8, 47, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(827, 401);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(6, 478);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1203, 241);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "الفواتير الخاصة بالعميل";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1184, 214);
            this.dataGridView2.TabIndex = 12;
            // 
            // frm_cstmr_pays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 722);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_cstmr_pays";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة مدفوعات العميل";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mdfo3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label_id;
        public System.Windows.Forms.Label label_nme;
        public System.Windows.Forms.Label label_total_mdfo3;
        private System.Windows.Forms.Label labl4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.TextBox label_first_rseed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_mndoob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radio_rd;
        private System.Windows.Forms.RadioButton radioButton_5sm;
        private System.Windows.Forms.RadioButton radioButton_تحصيل;
        public System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button button3;
    }
}