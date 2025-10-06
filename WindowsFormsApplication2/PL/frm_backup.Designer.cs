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
            this.btnt7dd.BackColor = System.Drawing.Color.PeachPuff;
            this.btnt7dd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnt7dd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnt7dd.Location = new System.Drawing.Point(385, 52);
            this.btnt7dd.Name = "btnt7dd";
            this.btnt7dd.Size = new System.Drawing.Size(87, 27);
            this.btnt7dd.TabIndex = 0;
            this.btnt7dd.Text = "تحديد ...";
            this.btnt7dd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnt7dd.UseVisualStyleBackColor = false;
            this.btnt7dd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "رجاء قم بتحديد مكان حفظ النسخة";
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(121, 55);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.ReadOnly = true;
            this.txtfilename.Size = new System.Drawing.Size(258, 26);
            this.txtfilename.TabIndex = 2;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightCoral;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_close_48;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexit.Location = new System.Drawing.Point(337, 123);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(112, 45);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "خروج";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "انشاء نسخه احتياطية من البيانات المخزنه   واستدعائها في حاله اذا احتجنا لذالك";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn2nsh2
            // 
            this.btn2nsh2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn2nsh2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2nsh2.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_done_48;
            this.btn2nsh2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2nsh2.Location = new System.Drawing.Point(141, 123);
            this.btn2nsh2.Name = "btn2nsh2";
            this.btn2nsh2.Size = new System.Drawing.Size(169, 45);
            this.btn2nsh2.TabIndex = 4;
            this.btn2nsh2.Text = "انشاء نسخه احتياطية";
            this.btn2nsh2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2nsh2.UseVisualStyleBackColor = false;
            this.btn2nsh2.Click += new System.EventHandler(this.btn2nsh2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.floppy_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frm_backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 242);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btn2nsh2);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnt7dd);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_backup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انشاء نسخة احتياطية";
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