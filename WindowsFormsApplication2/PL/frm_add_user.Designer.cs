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
            this.btnadd.BackColor = System.Drawing.Color.LightGreen;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd.Location = new System.Drawing.Point(88, 214);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(89, 41);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "اضافة";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(146, 34);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(187, 20);
            this.txtid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "الباسورد";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtpsrd
            // 
            this.txtpsrd.Location = new System.Drawing.Point(146, 72);
            this.txtpsrd.Name = "txtpsrd";
            this.txtpsrd.PasswordChar = '*';
            this.txtpsrd.Size = new System.Drawing.Size(187, 20);
            this.txtpsrd.TabIndex = 1;
            this.txtpsrd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "تأكيد الباسورد";
            // 
            // txtpsrdconfirm
            // 
            this.txtpsrdconfirm.Location = new System.Drawing.Point(146, 108);
            this.txtpsrdconfirm.Name = "txtpsrdconfirm";
            this.txtpsrdconfirm.PasswordChar = '*';
            this.txtpsrdconfirm.Size = new System.Drawing.Size(187, 20);
            this.txtpsrdconfirm.TabIndex = 2;
            this.txtpsrdconfirm.TextChanged += new System.EventHandler(this.txtpsrdconfirm_TextChanged);
            this.txtpsrdconfirm.Validated += new System.EventHandler(this.txtpsrdconfirm_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "الاسم كامل";
            // 
            // txttotalname
            // 
            this.txttotalname.Location = new System.Drawing.Point(146, 145);
            this.txttotalname.Name = "txttotalname";
            this.txttotalname.Size = new System.Drawing.Size(187, 20);
            this.txttotalname.TabIndex = 3;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Coral;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = global::WindowsFormsApplication2.Properties.Resources.male_user_remove;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclose.Location = new System.Drawing.Point(207, 214);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(89, 41);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "الغاء";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 304);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_user";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مستخدم جديد";
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