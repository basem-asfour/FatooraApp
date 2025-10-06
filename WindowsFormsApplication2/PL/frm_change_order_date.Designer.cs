namespace WindowsFormsApplication2.PL
{
    partial class frm_change_order_date
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_change_order_date));
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(238, 24);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeftLayout = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 23;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "تاريخ الفاتوره";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.SpringGreen;
            this.btnnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnew.Location = new System.Drawing.Point(163, 99);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(110, 44);
            this.btnnew.TabIndex = 24;
            this.btnnew.Text = "حفظ التاريخ";
            this.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Image = global::WindowsFormsApplication2.Properties.Resources.Close_icon2;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(338, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 44);
            this.button4.TabIndex = 25;
            this.button4.Text = "خروج";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(238, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Visible = false;
            // 
            // frm_change_order_date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 155);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Name = "frm_change_order_date";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغيير تاريخ الفاتورة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}