namespace WindowsFormsApplication2.PL
{
    partial class frm_manage_mrtg3_mbe3at
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_manage_mrtg3_mbe3at));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_fwateer = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_asnaaf = new System.Windows.Forms.DataGridView();
            this.txt_total_mrtg3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radioButton_number = new System.Windows.Forms.RadioButton();
            this.radioButton_nesba = new System.Windows.Forms.RadioButton();
            this.txt_total_after_5sm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_total_5sm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_cstmrs = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fwateer)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asnaaf)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_fwateer);
            this.groupBox2.Location = new System.Drawing.Point(3, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 316);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فواتير المرتجع";
            // 
            // dgv_fwateer
            // 
            this.dgv_fwateer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_fwateer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fwateer.Location = new System.Drawing.Point(6, 19);
            this.dgv_fwateer.Name = "dgv_fwateer";
            this.dgv_fwateer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fwateer.Size = new System.Drawing.Size(431, 277);
            this.dgv_fwateer.TabIndex = 12;
            this.dgv_fwateer.Click += new System.EventHandler(this.dgv_fwateer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_asnaaf);
            this.groupBox1.Location = new System.Drawing.Point(455, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 316);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "محتوي الفاتورة المحددة";
            // 
            // dgv_asnaaf
            // 
            this.dgv_asnaaf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_asnaaf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asnaaf.Location = new System.Drawing.Point(6, 19);
            this.dgv_asnaaf.Name = "dgv_asnaaf";
            this.dgv_asnaaf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_asnaaf.Size = new System.Drawing.Size(508, 277);
            this.dgv_asnaaf.TabIndex = 12;
            // 
            // txt_total_mrtg3
            // 
            this.txt_total_mrtg3.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_total_mrtg3.Location = new System.Drawing.Point(12, 415);
            this.txt_total_mrtg3.Name = "txt_total_mrtg3";
            this.txt_total_mrtg3.Size = new System.Drawing.Size(159, 20);
            this.txt_total_mrtg3.TabIndex = 16;
            this.txt_total_mrtg3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "بحث بإسم العميل";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(177, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 95);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات المتاحة علي الفاتورة المحددة";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.txt_total_after_5sm);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txt_total_5sm);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtmg);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Location = new System.Drawing.Point(455, 349);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 90);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "اجراء خصم علي الفاتورة المحددة";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox8.Controls.Add(this.radioButton_number);
            this.groupBox8.Controls.Add(this.radioButton_nesba);
            this.groupBox8.Location = new System.Drawing.Point(111, 10);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(219, 35);
            this.groupBox8.TabIndex = 57;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "نوع الخصم (افتراضي %)";
            // 
            // radioButton_number
            // 
            this.radioButton_number.BackColor = System.Drawing.Color.Navy;
            this.radioButton_number.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_number.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_number.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton_number.Location = new System.Drawing.Point(8, 14);
            this.radioButton_number.Name = "radioButton_number";
            this.radioButton_number.Size = new System.Drawing.Size(84, 22);
            this.radioButton_number.TabIndex = 15;
            this.radioButton_number.TabStop = true;
            this.radioButton_number.Text = "رقمي";
            this.radioButton_number.UseVisualStyleBackColor = false;
            this.radioButton_number.CheckedChanged += new System.EventHandler(this.radioButton_number_CheckedChanged);
            // 
            // radioButton_nesba
            // 
            this.radioButton_nesba.BackColor = System.Drawing.Color.Navy;
            this.radioButton_nesba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_nesba.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_nesba.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton_nesba.Location = new System.Drawing.Point(123, 14);
            this.radioButton_nesba.Name = "radioButton_nesba";
            this.radioButton_nesba.Size = new System.Drawing.Size(75, 22);
            this.radioButton_nesba.TabIndex = 14;
            this.radioButton_nesba.TabStop = true;
            this.radioButton_nesba.Text = "%";
            this.radioButton_nesba.UseVisualStyleBackColor = false;
            this.radioButton_nesba.CheckedChanged += new System.EventHandler(this.radioButton_nesba_CheckedChanged);
            // 
            // txt_total_after_5sm
            // 
            this.txt_total_after_5sm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_total_after_5sm.Location = new System.Drawing.Point(125, 55);
            this.txt_total_after_5sm.Name = "txt_total_after_5sm";
            this.txt_total_after_5sm.Size = new System.Drawing.Size(105, 20);
            this.txt_total_after_5sm.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "القيمة بعد الخصم:";
            // 
            // txt_total_5sm
            // 
            this.txt_total_5sm.Location = new System.Drawing.Point(340, 55);
            this.txt_total_5sm.Name = "txt_total_5sm";
            this.txt_total_5sm.Size = new System.Drawing.Size(105, 20);
            this.txt_total_5sm.TabIndex = 24;
            this.txt_total_5sm.TextChanged += new System.EventHandler(this.txt_total_5sm_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "الخصم:";
            // 
            // txtmg
            // 
            this.txtmg.Location = new System.Drawing.Point(340, 19);
            this.txtmg.Name = "txtmg";
            this.txtmg.Size = new System.Drawing.Size(105, 20);
            this.txtmg.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "قيمة الفاتورة:";
            // 
            // combo_cstmrs
            // 
            this.combo_cstmrs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_cstmrs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_cstmrs.FormattingEnabled = true;
            this.combo_cstmrs.Location = new System.Drawing.Point(114, 12);
            this.combo_cstmrs.Name = "combo_cstmrs";
            this.combo_cstmrs.Size = new System.Drawing.Size(335, 21);
            this.combo_cstmrs.TabIndex = 58;
            this.combo_cstmrs.SelectedIndexChanged += new System.EventHandler(this.combo_cstmrs_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(6, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 73);
            this.button5.TabIndex = 0;
            this.button5.Text = "اجراء الخصم";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::WindowsFormsApplication2.Properties.Resources.shopping_cart_remove2;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(6, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "حذف الفاتورة بأصنافها";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = global::WindowsFormsApplication2.Properties.Resources.Package_delete1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(150, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "حذف الفاتورة";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Image = global::WindowsFormsApplication2.Properties.Resources.remove_item;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(12, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 60);
            this.label6.TabIndex = 17;
            this.label6.Text = "اجمالي المرتجع";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_manage_mrtg3_mbe3at
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 465);
            this.Controls.Add(this.combo_cstmrs);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_total_mrtg3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "frm_manage_mrtg3_mbe3at";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة مرتجع المبيعات";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fwateer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asnaaf)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgv_fwateer;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgv_asnaaf;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_total_mrtg3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox txt_total_after_5sm;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_total_5sm;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtmg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.RadioButton radioButton_number;
        public System.Windows.Forms.RadioButton radioButton_nesba;
        public System.Windows.Forms.ComboBox combo_cstmrs;
    }
}