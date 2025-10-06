namespace WindowsFormsApplication2.PL
{
    partial class frm_edit_fweer_mwrd
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvalye = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmsdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmtbaki = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(75, 17);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(243, 22);
            this.txtid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_done_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(280, 311);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "تأكيد";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnme
            // 
            this.txtnme.Location = new System.Drawing.Point(75, 49);
            this.txtnme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnme.Name = "txtnme";
            this.txtnme.ReadOnly = true;
            this.txtnme.Size = new System.Drawing.Size(243, 22);
            this.txtnme.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسم المورد";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(75, 81);
            this.txtdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(243, 22);
            this.txtdate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "التاريخ";
            // 
            // txtvalye
            // 
            this.txtvalye.Location = new System.Drawing.Point(75, 116);
            this.txtvalye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvalye.Name = "txtvalye";
            this.txtvalye.Size = new System.Drawing.Size(243, 22);
            this.txtvalye.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "قيمة الفاتورة ";
            // 
            // txtmsdd
            // 
            this.txtmsdd.Location = new System.Drawing.Point(75, 159);
            this.txtmsdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmsdd.Name = "txtmsdd";
            this.txtmsdd.Size = new System.Drawing.Size(243, 22);
            this.txtmsdd.TabIndex = 10;
            this.txtmsdd.TextChanged += new System.EventHandler(this.txtmsdd_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "المسد منها ";
            // 
            // txtmtbaki
            // 
            this.txtmtbaki.Location = new System.Drawing.Point(75, 207);
            this.txtmtbaki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmtbaki.Name = "txtmtbaki";
            this.txtmtbaki.Size = new System.Drawing.Size(243, 22);
            this.txtmtbaki.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "المتبقي";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_close_48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(49, 311);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 54);
            this.button2.TabIndex = 13;
            this.button2.Text = "خروج";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_edit_fweer_mwrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 410);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtmtbaki);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmsdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtvalye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_edit_fweer_mwrd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات الفاتورة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox txtnme;
        public System.Windows.Forms.TextBox txtdate;
        public System.Windows.Forms.TextBox txtvalye;
        public System.Windows.Forms.TextBox txtmsdd;
        public System.Windows.Forms.TextBox txtmtbaki;
    }
}