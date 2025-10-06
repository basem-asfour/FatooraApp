namespace WindowsFormsApplication2.PL
{
    partial class frm_edit_mndob
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
            this.btnnew = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.combo_mndoob = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.SpringGreen;
            this.btnnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnew.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_done_48;
            this.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnew.Location = new System.Drawing.Point(121, 110);
            this.btnnew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(147, 54);
            this.btnnew.TabIndex = 26;
            this.btnnew.Text = "تأكيد";
            this.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_close_48;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(355, 110);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 54);
            this.button4.TabIndex = 27;
            this.button4.Text = "الغاء";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(49, 52);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 16);
            this.label23.TabIndex = 49;
            this.label23.Text = "اسم المندوب";
            // 
            // combo_mndoob
            // 
            this.combo_mndoob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_mndoob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_mndoob.FormattingEnabled = true;
            this.combo_mndoob.Location = new System.Drawing.Point(149, 48);
            this.combo_mndoob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_mndoob.Name = "combo_mndoob";
            this.combo_mndoob.Size = new System.Drawing.Size(367, 24);
            this.combo_mndoob.TabIndex = 50;
            // 
            // frm_edit_mndob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 204);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.combo_mndoob);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.button4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_edit_mndob";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغيير المندوب الخاص بالفاتورة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.ComboBox combo_mndoob;
    }
}