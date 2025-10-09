namespace WindowsFormsApplication2.PL
{
    partial class frm_add_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_user));
            this.btnadd = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpsrd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpsrdconfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotalname = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd.Location = new System.Drawing.Point(110, 250);
            this.btnadd.Margin = new System.Windows.Forms.Padding(5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Padding = new System.Windows.Forms.Padding(10);
            this.btnadd.Size = new System.Drawing.Size(130, 50);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "إضافة";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtid.Location = new System.Drawing.Point(170, 40);
            this.txtid.Margin = new System.Windows.Forms.Padding(5);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(220, 25);
            this.txtid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المستخدم:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "كلمة المرور:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtpsrd
            // 
            this.txtpsrd.BackColor = System.Drawing.Color.White;
            this.txtpsrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpsrd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtpsrd.Location = new System.Drawing.Point(170, 85);
            this.txtpsrd.Margin = new System.Windows.Forms.Padding(5);
            this.txtpsrd.Name = "txtpsrd";
            this.txtpsrd.PasswordChar = '●';
            this.txtpsrd.Size = new System.Drawing.Size(220, 25);
            this.txtpsrd.TabIndex = 1;
            this.txtpsrd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(30, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "تأكيد كلمة المرور:";
            // 
            // txtpsrdconfirm
            // 
            this.txtpsrdconfirm.BackColor = System.Drawing.Color.White;
            this.txtpsrdconfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpsrdconfirm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtpsrdconfirm.Location = new System.Drawing.Point(170, 130);
            this.txtpsrdconfirm.Margin = new System.Windows.Forms.Padding(5);
            this.txtpsrdconfirm.Name = "txtpsrdconfirm";
            this.txtpsrdconfirm.PasswordChar = '●';
            this.txtpsrdconfirm.Size = new System.Drawing.Size(220, 25);
            this.txtpsrdconfirm.TabIndex = 2;
            this.txtpsrdconfirm.TextChanged += new System.EventHandler(this.txtpsrdconfirm_TextChanged);
            this.txtpsrdconfirm.Validated += new System.EventHandler(this.txtpsrdconfirm_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(30, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "الاسم الكامل:";
            // 
            // txttotalname
            // 
            this.txttotalname.BackColor = System.Drawing.Color.White;
            this.txttotalname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txttotalname.Location = new System.Drawing.Point(170, 175);
            this.txttotalname.Margin = new System.Windows.Forms.Padding(5);
            this.txttotalname.Name = "txttotalname";
            this.txttotalname.Size = new System.Drawing.Size(220, 25);
            this.txttotalname.TabIndex = 3;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Image = global::WindowsFormsApplication2.Properties.Resources.male_user_remove;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclose.Location = new System.Drawing.Point(260, 250);
            this.btnclose.Margin = new System.Windows.Forms.Padding(5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Padding = new System.Windows.Forms.Padding(10);
            this.btnclose.Size = new System.Drawing.Size(130, 50);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "إلغاء";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(420, 330);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttotalname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpsrdconfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpsrd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnadd);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_user";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "👤 إضافة مستخدم جديد - نظام إدارة المبيعات";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnclose;
        public System.Windows.Forms.Button btnadd;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox txtpsrd;
        public System.Windows.Forms.TextBox txtpsrdconfirm;
        public System.Windows.Forms.TextBox txttotalname;
    }
}