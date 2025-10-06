namespace WindowsFormsApplication2.PL
{
    partial class restore
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btn2nsh2 = new System.Windows.Forms.Button();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnt7dd = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightCoral;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Location = new System.Drawing.Point(289, 150);
            this.btnexit.Name = "btnexit";
            this.btnexit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnexit.Size = new System.Drawing.Size(90, 34);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "خروج";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btn2nsh2
            // 
            this.btn2nsh2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn2nsh2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2nsh2.Location = new System.Drawing.Point(93, 150);
            this.btn2nsh2.Name = "btn2nsh2";
            this.btn2nsh2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn2nsh2.Size = new System.Drawing.Size(169, 34);
            this.btn2nsh2.TabIndex = 9;
            this.btn2nsh2.Text = "استعادة النسخه";
            this.btn2nsh2.UseVisualStyleBackColor = false;
            this.btn2nsh2.Click += new System.EventHandler(this.btn2nsh2_Click);
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(67, 100);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.ReadOnly = true;
            this.txtfilename.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtfilename.Size = new System.Drawing.Size(323, 20);
            this.txtfilename.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 60);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(177, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "قم بتحديد ملف النسخه الاحتياطية";
            // 
            // btnt7dd
            // 
            this.btnt7dd.BackColor = System.Drawing.Color.PeachPuff;
            this.btnt7dd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnt7dd.Location = new System.Drawing.Point(396, 97);
            this.btnt7dd.Name = "btnt7dd";
            this.btnt7dd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnt7dd.Size = new System.Drawing.Size(87, 27);
            this.btnt7dd.TabIndex = 6;
            this.btnt7dd.Text = "تحديد";
            this.btnt7dd.UseVisualStyleBackColor = false;
            this.btnt7dd.Click += new System.EventHandler(this.btnt7dd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "اذا حدث خطأ ما في استعادة النسخه ولم تظهر رساله تؤكد الاستعادة برجاء الرجوع الي ا" +
    "لمبرمج";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 248);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btn2nsh2);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnt7dd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "restore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "استعادة نسخه محفوظة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btn2nsh2;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnt7dd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
    }
}