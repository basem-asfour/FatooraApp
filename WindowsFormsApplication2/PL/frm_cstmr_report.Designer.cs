namespace WindowsFormsApplication2.PL
{
    partial class frm_cstmr_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cstmr_report));
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button11 = new System.Windows.Forms.Button();
            this.combo_cstmr = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_days = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgv_cstmrs = new System.Windows.Forms.DataGridView();
            this.txt_total_first_rseed = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.txt_total_bee3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txt_total_metg3 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.txt_total_ta7seel = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.txt_total_5sm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_total_rd = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_safi = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cstmrs)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(737, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "الي";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(775, 23);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeftLayout = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(272, 22);
            this.dateTimePicker2.TabIndex = 36;
            this.dateTimePicker2.Value = new System.DateTime(2018, 7, 9, 20, 8, 47, 0);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(1056, 21);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 31);
            this.button5.TabIndex = 34;
            this.button5.Text = "بحث";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "من";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(453, 23);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 22);
            this.dateTimePicker1.TabIndex = 33;
            this.dateTimePicker1.Value = new System.DateTime(2018, 7, 9, 20, 8, 47, 0);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightGreen;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Location = new System.Drawing.Point(100, 33);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(264, 31);
            this.button11.TabIndex = 48;
            this.button11.Text = "تقرير العميل المختار";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // combo_cstmr
            // 
            this.combo_cstmr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_cstmr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_cstmr.FormattingEnabled = true;
            this.combo_cstmr.Location = new System.Drawing.Point(100, 7);
            this.combo_cstmr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_cstmr.Name = "combo_cstmr";
            this.combo_cstmr.Size = new System.Drawing.Size(263, 24);
            this.combo_cstmr.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "اختيار العميل:";
            // 
            // label_days
            // 
            this.label_days.AutoSize = true;
            this.label_days.Location = new System.Drawing.Point(84, 11);
            this.label_days.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_days.Name = "label_days";
            this.label_days.Size = new System.Drawing.Size(0, 16);
            this.label_days.TabIndex = 45;
            this.label_days.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.dgv_cstmrs);
            this.groupBox2.Location = new System.Drawing.Point(11, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1428, 560);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تقرير العميل";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 540);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1420, 12);
            this.dataGridView1.TabIndex = 2;
            // 
            // dgv_cstmrs
            // 
            this.dgv_cstmrs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cstmrs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cstmrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cstmrs.Location = new System.Drawing.Point(5, 21);
            this.dgv_cstmrs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_cstmrs.Name = "dgv_cstmrs";
            this.dgv_cstmrs.ReadOnly = true;
            this.dgv_cstmrs.RowHeadersWidth = 51;
            this.dgv_cstmrs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cstmrs.Size = new System.Drawing.Size(1420, 512);
            this.dgv_cstmrs.TabIndex = 1;
            // 
            // txt_total_first_rseed
            // 
            this.txt_total_first_rseed.BackColor = System.Drawing.Color.LightGreen;
            this.txt_total_first_rseed.Location = new System.Drawing.Point(199, 702);
            this.txt_total_first_rseed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_total_first_rseed.Name = "txt_total_first_rseed";
            this.txt_total_first_rseed.Size = new System.Drawing.Size(195, 22);
            this.txt_total_first_rseed.TabIndex = 59;
            this.txt_total_first_rseed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.MidnightBlue;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_money_bag_40;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.Location = new System.Drawing.Point(197, 649);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(197, 53);
            this.button10.TabIndex = 58;
            this.button10.Text = "اجمالي رصيد أول ";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // txt_total_bee3
            // 
            this.txt_total_bee3.BackColor = System.Drawing.Color.LightGreen;
            this.txt_total_bee3.Location = new System.Drawing.Point(4, 702);
            this.txt_total_bee3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_total_bee3.Name = "txt_total_bee3";
            this.txt_total_bee3.Size = new System.Drawing.Size(187, 22);
            this.txt_total_bee3.TabIndex = 57;
            this.txt_total_bee3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MidnightBlue;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(3, 649);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(189, 53);
            this.button6.TabIndex = 56;
            this.button6.Text = "اجمالي بيع ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // txt_total_metg3
            // 
            this.txt_total_metg3.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_total_metg3.Location = new System.Drawing.Point(952, 703);
            this.txt_total_metg3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_total_metg3.Name = "txt_total_metg3";
            this.txt_total_metg3.Size = new System.Drawing.Size(172, 22);
            this.txt_total_metg3.TabIndex = 55;
            this.txt_total_metg3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.MidnightBlue;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = global::WindowsFormsApplication2.Properties.Resources.remove_item1;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(952, 649);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(175, 54);
            this.button9.TabIndex = 54;
            this.button9.Text = "اجمالي مرتجع";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // txt_total_ta7seel
            // 
            this.txt_total_ta7seel.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_total_ta7seel.Location = new System.Drawing.Point(603, 703);
            this.txt_total_ta7seel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_total_ta7seel.Name = "txt_total_ta7seel";
            this.txt_total_ta7seel.Size = new System.Drawing.Size(188, 22);
            this.txt_total_ta7seel.TabIndex = 53;
            this.txt_total_ta7seel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.MidnightBlue;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::WindowsFormsApplication2.Properties.Resources.increase1;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.Location = new System.Drawing.Point(603, 649);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(191, 54);
            this.button8.TabIndex = 52;
            this.button8.Text = "اجمالي تحصيل + مسدد فواتير";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // txt_total_5sm
            // 
            this.txt_total_5sm.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_total_5sm.Location = new System.Drawing.Point(796, 703);
            this.txt_total_5sm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_total_5sm.Name = "txt_total_5sm";
            this.txt_total_5sm.Size = new System.Drawing.Size(151, 22);
            this.txt_total_5sm.TabIndex = 51;
            this.txt_total_5sm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::WindowsFormsApplication2.Properties.Resources.decrease;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(796, 649);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 54);
            this.button1.TabIndex = 50;
            this.button1.Text = "اجمالي خصم مسموح به";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txt_total_rd
            // 
            this.txt_total_rd.BackColor = System.Drawing.Color.LightGreen;
            this.txt_total_rd.Location = new System.Drawing.Point(403, 703);
            this.txt_total_rd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_total_rd.Name = "txt_total_rd";
            this.txt_total_rd.Size = new System.Drawing.Size(172, 22);
            this.txt_total_rd.TabIndex = 61;
            this.txt_total_rd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::WindowsFormsApplication2.Properties.Resources.decrease;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(403, 649);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 54);
            this.button2.TabIndex = 60;
            this.button2.Text = "اجمالي رد للعميل";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txt_safi
            // 
            this.txt_safi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_safi.Location = new System.Drawing.Point(1223, 703);
            this.txt_safi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_safi.Name = "txt_safi";
            this.txt_safi.Size = new System.Drawing.Size(209, 22);
            this.txt_safi.TabIndex = 63;
            this.txt_safi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::WindowsFormsApplication2.Properties.Resources.money_icon__2_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(1221, 649);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 54);
            this.button3.TabIndex = 62;
            this.button3.Text = "عليه : ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_page_setup_48;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(1191, 15);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(248, 52);
            this.button4.TabIndex = 64;
            this.button4.Text = "طباعة تقرير العميل اليومي";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // frm_cstmr_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 745);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txt_safi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_total_rd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_total_first_rseed);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.txt_total_bee3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txt_total_metg3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.txt_total_ta7seel);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txt_total_5sm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.combo_cstmr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_days);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_cstmr_report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير عميل";
            this.Load += new System.EventHandler(this.frm_cstmr_report_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cstmrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox combo_cstmr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_days;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_cstmrs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_total_first_rseed;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox txt_total_bee3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txt_total_metg3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox txt_total_ta7seel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txt_total_5sm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_total_rd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_safi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}