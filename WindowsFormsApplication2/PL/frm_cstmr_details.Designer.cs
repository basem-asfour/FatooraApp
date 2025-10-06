namespace WindowsFormsApplication2.PL
{
    partial class frm_cstmr_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cstmr_details));
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcstid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcstnme = new System.Windows.Forms.TextBox();
            this.txtmsdd = new System.Windows.Forms.TextBox();
            this.txtmtpakii = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_asnaaf = new System.Windows.Forms.DataGridView();
            this.dgv_fwateer = new System.Windows.Forms.DataGridView();
            this.txt_total_mrtg3 = new System.Windows.Forms.TextBox();
            this.txt_rseed_first = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asnaaf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fwateer)).BeginInit();
            this.SuspendLayout();
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.PaleGreen;
            this.txttotal.Location = new System.Drawing.Point(162, 269);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(211, 26);
            this.txttotal.TabIndex = 0;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "كود العميل ";
            // 
            // txtcstid
            // 
            this.txtcstid.Location = new System.Drawing.Point(95, 12);
            this.txtcstid.Name = "txtcstid";
            this.txtcstid.ReadOnly = true;
            this.txtcstid.Size = new System.Drawing.Size(113, 26);
            this.txtcstid.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "اسم العميل";
            // 
            // txtcstnme
            // 
            this.txtcstnme.Location = new System.Drawing.Point(319, 12);
            this.txtcstnme.Name = "txtcstnme";
            this.txtcstnme.ReadOnly = true;
            this.txtcstnme.Size = new System.Drawing.Size(212, 26);
            this.txtcstnme.TabIndex = 5;
            // 
            // txtmsdd
            // 
            this.txtmsdd.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtmsdd.Location = new System.Drawing.Point(556, 269);
            this.txtmsdd.Name = "txtmsdd";
            this.txtmsdd.Size = new System.Drawing.Size(169, 26);
            this.txtmsdd.TabIndex = 7;
            this.txtmsdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmtpakii
            // 
            this.txtmtpakii.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtmtpakii.Location = new System.Drawing.Point(730, 269);
            this.txtmtpakii.Name = "txtmtpakii";
            this.txtmtpakii.Size = new System.Drawing.Size(159, 26);
            this.txtmtpakii.TabIndex = 9;
            this.txtmtpakii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(21, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 191);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الفواتير الخاصة بالعميل";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(955, 164);
            this.dataGridView1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_asnaaf);
            this.groupBox2.Controls.Add(this.dgv_fwateer);
            this.groupBox2.Location = new System.Drawing.Point(21, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(973, 191);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فواتير المرتجع";
            // 
            // dgv_asnaaf
            // 
            this.dgv_asnaaf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_asnaaf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asnaaf.Location = new System.Drawing.Point(6, 21);
            this.dgv_asnaaf.Name = "dgv_asnaaf";
            this.dgv_asnaaf.RowHeadersWidth = 51;
            this.dgv_asnaaf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_asnaaf.Size = new System.Drawing.Size(520, 164);
            this.dgv_asnaaf.TabIndex = 13;
            // 
            // dgv_fwateer
            // 
            this.dgv_fwateer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_fwateer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fwateer.Location = new System.Drawing.Point(530, 21);
            this.dgv_fwateer.Name = "dgv_fwateer";
            this.dgv_fwateer.RowHeadersWidth = 51;
            this.dgv_fwateer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fwateer.Size = new System.Drawing.Size(437, 164);
            this.dgv_fwateer.TabIndex = 12;
            this.dgv_fwateer.Click += new System.EventHandler(this.dgv_fwateer_Click);
            // 
            // txt_total_mrtg3
            // 
            this.txt_total_mrtg3.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_total_mrtg3.Location = new System.Drawing.Point(385, 269);
            this.txt_total_mrtg3.Name = "txt_total_mrtg3";
            this.txt_total_mrtg3.Size = new System.Drawing.Size(159, 26);
            this.txt_total_mrtg3.TabIndex = 14;
            this.txt_total_mrtg3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_rseed_first
            // 
            this.txt_rseed_first.BackColor = System.Drawing.Color.PaleGreen;
            this.txt_rseed_first.Location = new System.Drawing.Point(21, 269);
            this.txt_rseed_first.Name = "txt_rseed_first";
            this.txt_rseed_first.Size = new System.Drawing.Size(131, 26);
            this.txt_rseed_first.TabIndex = 17;
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
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_page_setup_48;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(301, 497);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(341, 48);
            this.button3.TabIndex = 19;
            this.button3.Text = "طباعة تقرير العميل (مشتريات و تحصيل)";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_money_bag_40;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(21, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "رصيد اول";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::WindowsFormsApplication2.Properties.Resources.payment_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(648, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 49);
            this.button2.TabIndex = 16;
            this.button2.Text = "مدفوعات العميل";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Image = global::WindowsFormsApplication2.Properties.Resources.remove_item1;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(385, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "اجمالي المرتجع";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Image = global::WindowsFormsApplication2.Properties.Resources.decrease;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(730, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "مدان ب";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Image = global::WindowsFormsApplication2.Properties.Resources.increase1;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(556, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "مسدد منها";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Image = global::WindowsFormsApplication2.Properties.Resources.money_icon__2_;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(162, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "اجمالي البضاعة المسحوبة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_close_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(771, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "خروج";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_cstmr_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 551);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_rseed_first);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_total_mrtg3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmtpakii);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmsdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcstnme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcstid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttotal);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cstmr_details";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل العميل";
            this.Load += new System.EventHandler(this.frm_cstmr_details_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asnaaf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fwateer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtcstid;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtcstnme;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtmsdd;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtmtpakii;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgv_asnaaf;
        public System.Windows.Forms.DataGridView dgv_fwateer;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_total_mrtg3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_rseed_first;
        private System.Windows.Forms.Button button3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}