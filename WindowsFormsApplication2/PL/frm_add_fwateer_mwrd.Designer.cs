namespace WindowsFormsApplication2.PL
{
    partial class frm_add_fwateer_mwrd
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
            this.txtmwrd_nme = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.id_mwrd_order = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmsdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmtbki = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المورد";
            // 
            // txtmwrd_nme
            // 
            this.txtmwrd_nme.Location = new System.Drawing.Point(145, 69);
            this.txtmwrd_nme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmwrd_nme.Name = "txtmwrd_nme";
            this.txtmwrd_nme.ReadOnly = true;
            this.txtmwrd_nme.Size = new System.Drawing.Size(265, 22);
            this.txtmwrd_nme.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(419, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(911, 683);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة اصناف الفاتورة";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.NavajoWhite;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_edit_48;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(459, 578);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(444, 48);
            this.button5.TabIndex = 10;
            this.button5.Text = "تعديل بيانات الصنف";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Image = global::WindowsFormsApplication2.Properties.Resources.Package_delete1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(8, 578);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(449, 48);
            this.button4.TabIndex = 9;
            this.button4.Text = "حذف الصنف المحدد";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(895, 551);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = global::WindowsFormsApplication2.Properties.Resources.Package_add1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(11, 633);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(892, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "اضافة اصناف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 116);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "التاريخ";
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(145, 193);
            this.txt_value.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(265, 22);
            this.txt_value.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "قيمة الفاتورة";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_done_48;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(63, 588);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(272, 58);
            this.button3.TabIndex = 9;
            this.button3.Text = "تأكيد اضافة الفاتورة";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // id_mwrd_order
            // 
            this.id_mwrd_order.Location = new System.Drawing.Point(145, 20);
            this.id_mwrd_order.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id_mwrd_order.Name = "id_mwrd_order";
            this.id_mwrd_order.ReadOnly = true;
            this.id_mwrd_order.Size = new System.Drawing.Size(265, 22);
            this.id_mwrd_order.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "رقم الفاتورة";
            // 
            // txtmsdd
            // 
            this.txtmsdd.Location = new System.Drawing.Point(145, 241);
            this.txtmsdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmsdd.Name = "txtmsdd";
            this.txtmsdd.Size = new System.Drawing.Size(265, 22);
            this.txtmsdd.TabIndex = 13;
            this.txtmsdd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(45, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "المسدد منها";
            // 
            // txtmtbki
            // 
            this.txtmtbki.Location = new System.Drawing.Point(145, 294);
            this.txtmtbki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmtbki.Name = "txtmtbki";
            this.txtmtbki.ReadOnly = true;
            this.txtmtbki.Size = new System.Drawing.Size(265, 22);
            this.txtmtbki.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "متبقي";
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DodgerBlue;
            this.button21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_refresh_48;
            this.button21.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button21.Location = new System.Drawing.Point(1148, 1);
            this.button21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(175, 42);
            this.button21.TabIndex = 20;
            this.button21.Text = "refresh";
            this.button21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // frm_add_fwateer_mwrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 709);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.txtmtbki);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmsdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.id_mwrd_order);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtmwrd_nme);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_fwateer_mwrd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة اضافة فاتورة من مورد";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox txtmwrd_nme;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox id_mwrd_order;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_value;
        public System.Windows.Forms.TextBox txtmsdd;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtmtbki;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button21;
    }
}