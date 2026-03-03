namespace WindowsFormsApplication2.PL
{
    partial class frm_backup
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
            this.btnt7dd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn2nsh2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnt7dd
            // 
            this.btnt7dd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnt7dd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnt7dd.FlatAppearance.BorderSize = 0;
            this.btnt7dd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnt7dd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnt7dd.ForeColor = System.Drawing.Color.White;
            this.btnt7dd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnt7dd.Location = new System.Drawing.Point(420, 80);
            this.btnt7dd.Margin = new System.Windows.Forms.Padding(5);
            this.btnt7dd.Name = "btnt7dd";
            this.btnt7dd.Padding = new System.Windows.Forms.Padding(5);
            this.btnt7dd.Size = new System.Drawing.Size(120, 35);
            this.btnt7dd.TabIndex = 0;
            this.btnt7dd.Text = "📁 تحديد مجلد";
            this.btnt7dd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnt7dd.UseVisualStyleBackColor = false;
            this.btnt7dd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(120, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "📂 رجاء قم بتحديد مكان حفظ النسخة الاحتياطية";
            // 
            // txtfilename
            // 
            this.txtfilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtfilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfilename.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtfilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.txtfilename.Location = new System.Drawing.Point(120, 85);
            this.txtfilename.Margin = new System.Windows.Forms.Padding(5);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.ReadOnly = true;
            this.txtfilename.Size = new System.Drawing.Size(290, 25);
            this.txtfilename.TabIndex = 2;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_close_48;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexit.Location = new System.Drawing.Point(350, 180);
            this.btnexit.Margin = new System.Windows.Forms.Padding(5);
            this.btnexit.Name = "btnexit";
            this.btnexit.Padding = new System.Windows.Forms.Padding(5);
            this.btnexit.Size = new System.Drawing.Size(120, 45);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "❌ خروج";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label2.Location = new System.Drawing.Point(10, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 60);
            this.label2.TabIndex = 6;
            this.label2.Text = "💡 إنشاء نسخة احتياطية من البيانات المخزنة واستدعائها في حالة الحاجة لذلك\r\n🔒 حماية بياناتك من الفقدان أو التلف";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn2nsh2
            // 
            this.btn2nsh2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn2nsh2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2nsh2.FlatAppearance.BorderSize = 0;
            this.btn2nsh2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2nsh2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn2nsh2.ForeColor = System.Drawing.Color.White;
            this.btn2nsh2.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_done_48;
            this.btn2nsh2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2nsh2.Location = new System.Drawing.Point(120, 180);
            this.btn2nsh2.Margin = new System.Windows.Forms.Padding(5);
            this.btn2nsh2.Name = "btn2nsh2";
            this.btn2nsh2.Padding = new System.Windows.Forms.Padding(5);
            this.btn2nsh2.Size = new System.Drawing.Size(220, 45);
            this.btn2nsh2.TabIndex = 4;
            this.btn2nsh2.Text = "💾 إنشاء نسخة احتياطية";
            this.btn2nsh2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn2nsh2.UseVisualStyleBackColor = false;
            this.btn2nsh2.Click += new System.EventHandler(this.btn2nsh2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.floppy_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frm_backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(550, 320);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btn2nsh2);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnt7dd);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_backup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "💾 إنشاء نسخة احتياطية - نظام إدارة المبيعات";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnt7dd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Button btn2nsh2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}