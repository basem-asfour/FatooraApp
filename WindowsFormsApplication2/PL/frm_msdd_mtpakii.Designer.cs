namespace WindowsFormsApplication2.PL
{
    partial class frm_msdd_mtpakii
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
            this.button1 = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmsdd = new System.Windows.Forms.TextBox();
            this.txtmtpakii = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton_5ales = new System.Windows.Forms.RadioButton();
            this.radioButton_not5ales = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(102, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "حفظ التغيرات";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(168, 55);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(205, 26);
            this.txttotal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "اجمالي الفاتورة";
            // 
            // txtmsdd
            // 
            this.txtmsdd.Location = new System.Drawing.Point(168, 94);
            this.txtmsdd.Name = "txtmsdd";
            this.txtmsdd.Size = new System.Drawing.Size(205, 26);
            this.txtmsdd.TabIndex = 3;
            this.txtmsdd.TextChanged += new System.EventHandler(this.txtmsdd_TextChanged);
            // 
            // txtmtpakii
            // 
            this.txtmtpakii.Location = new System.Drawing.Point(168, 145);
            this.txtmtpakii.Name = "txtmtpakii";
            this.txtmtpakii.Size = new System.Drawing.Size(205, 26);
            this.txtmtpakii.TabIndex = 4;
            this.txtmtpakii.TextChanged += new System.EventHandler(this.txtmtpakii_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "المبلغ المسدد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "المبلغ المتبقي";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "حالة الفاتورة";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(305, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton_5ales
            // 
            this.radioButton_5ales.AutoSize = true;
            this.radioButton_5ales.BackColor = System.Drawing.Color.LightGreen;
            this.radioButton_5ales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_5ales.Location = new System.Drawing.Point(168, 200);
            this.radioButton_5ales.Name = "radioButton_5ales";
            this.radioButton_5ales.Size = new System.Drawing.Size(72, 22);
            this.radioButton_5ales.TabIndex = 10;
            this.radioButton_5ales.TabStop = true;
            this.radioButton_5ales.Text = "خالصه";
            this.radioButton_5ales.UseVisualStyleBackColor = false;
            this.radioButton_5ales.CheckedChanged += new System.EventHandler(this.radioButton_5ales_CheckedChanged);
            // 
            // radioButton_not5ales
            // 
            this.radioButton_not5ales.AutoSize = true;
            this.radioButton_not5ales.BackColor = System.Drawing.Color.IndianRed;
            this.radioButton_not5ales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_not5ales.Location = new System.Drawing.Point(281, 200);
            this.radioButton_not5ales.Name = "radioButton_not5ales";
            this.radioButton_not5ales.Size = new System.Drawing.Size(100, 22);
            this.radioButton_not5ales.TabIndex = 11;
            this.radioButton_not5ales.TabStop = true;
            this.radioButton_not5ales.Text = "غير خالصه";
            this.radioButton_not5ales.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "رقم الفاتورة";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(159, 26);
            this.textBox1.TabIndex = 12;
            // 
            // frm_msdd_mtpakii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(474, 326);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton_not5ales);
            this.Controls.Add(this.radioButton_5ales);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmtpakii);
            this.Controls.Add(this.txtmsdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_msdd_mtpakii";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة حالة الفاتورة";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_msdd_mtpakii_FormClosed);
            this.Load += new System.EventHandler(this.frm_msdd_mtpakii_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txttotal;
        public System.Windows.Forms.TextBox txtmsdd;
        public System.Windows.Forms.TextBox txtmtpakii;
        public System.Windows.Forms.RadioButton radioButton_5ales;
        public System.Windows.Forms.RadioButton radioButton_not5ales;
    }
}