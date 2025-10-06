namespace WindowsFormsApplication2.PL
{
    partial class frm_add_cstmr
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcstnme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcstadrs = new System.Windows.Forms.TextBox();
            this.txtcstpho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.combo_mndb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "أقصي حساب سابق";
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(25, 281);
            this.txtmax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(295, 22);
            this.txtmax.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم العميل:";
            // 
            // txtcstnme
            // 
            this.txtcstnme.Location = new System.Drawing.Point(25, 38);
            this.txtcstnme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcstnme.Name = "txtcstnme";
            this.txtcstnme.Size = new System.Drawing.Size(340, 22);
            this.txtcstnme.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "التليفون: ";
            // 
            // txtcstadrs
            // 
            this.txtcstadrs.Location = new System.Drawing.Point(25, 119);
            this.txtcstadrs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcstadrs.Multiline = true;
            this.txtcstadrs.Name = "txtcstadrs";
            this.txtcstadrs.Size = new System.Drawing.Size(340, 73);
            this.txtcstadrs.TabIndex = 3;
            // 
            // txtcstpho
            // 
            this.txtcstpho.Location = new System.Drawing.Point(25, 79);
            this.txtcstpho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcstpho.Name = "txtcstpho";
            this.txtcstpho.Size = new System.Drawing.Size(340, 22);
            this.txtcstpho.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "العنوان:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.combo_mndb);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtmax);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtcstnme);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtcstadrs);
            this.groupBox3.Controls.Add(this.txtcstpho);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(16, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(475, 313);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات العميل";
            // 
            // combo_mndb
            // 
            this.combo_mndb.FormattingEnabled = true;
            this.combo_mndb.Location = new System.Drawing.Point(25, 223);
            this.combo_mndb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_mndb.Name = "combo_mndb";
            this.combo_mndb.Size = new System.Drawing.Size(295, 24);
            this.combo_mndb.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 226);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "المندوب الخاص بالعميل";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_close_48;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(284, 332);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 73);
            this.button4.TabIndex = 4;
            this.button4.Text = "خروج";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::WindowsFormsApplication2.Properties.Resources.male_user_add1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.Location = new System.Drawing.Point(75, 332);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "اضافه العميل ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_add_cstmr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 411);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_cstmr";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة عميل جديد";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtmax;
        public System.Windows.Forms.TextBox txtcstnme;
        public System.Windows.Forms.TextBox txtcstadrs;
        public System.Windows.Forms.TextBox txtcstpho;
        private System.Windows.Forms.ComboBox combo_mndb;
        private System.Windows.Forms.Label label9;
    }
}