namespace WindowsFormsApplication2.PL
{
    partial class frm_mwrd_pays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mwrd_pays));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_fwateer = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtnotes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radio_rd = new System.Windows.Forms.RadioButton();
            this.radioButton_5sm = new System.Windows.Forms.RadioButton();
            this.radioButton_تحصيل = new System.Windows.Forms.RadioButton();
            this.label_first_rseed = new System.Windows.Forms.TextBox();
            this.label_total_mdfo3 = new System.Windows.Forms.Label();
            this.labl4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_nme = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mdfo3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_mdfo3at = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fwateer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mdfo3at)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_fwateer);
            this.groupBox4.Location = new System.Drawing.Point(6, 370);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1170, 231);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "الفواتير الخاصة بالمورد";
            // 
            // dgv_fwateer
            // 
            this.dgv_fwateer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_fwateer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fwateer.Location = new System.Drawing.Point(6, 21);
            this.dgv_fwateer.Name = "dgv_fwateer";
            this.dgv_fwateer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fwateer.Size = new System.Drawing.Size(1158, 204);
            this.dgv_fwateer.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Location = new System.Drawing.Point(4, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LightGreen;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.Location = new System.Drawing.Point(201, 24);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 44);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "سداد المبلغ";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Location = new System.Drawing.Point(142, 23);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(107, 44);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "تعديل المحدد";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Visible = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightCoral;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Image = global::WindowsFormsApplication2.Properties.Resources.decrease;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(38, 23);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(108, 44);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "حذف المحدد";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtnotes);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.label_first_rseed);
            this.groupBox3.Controls.Add(this.label_total_mdfo3);
            this.groupBox3.Controls.Add(this.labl4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label_id);
            this.groupBox3.Controls.Add(this.label_nme);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_mdfo3);
            this.groupBox3.Location = new System.Drawing.Point(4, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 279);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات التحصيل";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtnotes
            // 
            this.txtnotes.Location = new System.Drawing.Point(38, 218);
            this.txtnotes.Multiline = true;
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.Size = new System.Drawing.Size(256, 55);
            this.txtnotes.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "ملاحظات:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Azure;
            this.groupBox5.Controls.Add(this.radio_rd);
            this.groupBox5.Controls.Add(this.radioButton_5sm);
            this.groupBox5.Controls.Add(this.radioButton_تحصيل);
            this.groupBox5.Location = new System.Drawing.Point(35, 81);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(286, 39);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "نوع العملية";
            // 
            // radio_rd
            // 
            this.radio_rd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_rd.Dock = System.Windows.Forms.DockStyle.Right;
            this.radio_rd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radio_rd.FlatAppearance.BorderSize = 10;
            this.radio_rd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radio_rd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radio_rd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radio_rd.Location = new System.Drawing.Point(101, 16);
            this.radio_rd.Name = "radio_rd";
            this.radio_rd.Size = new System.Drawing.Size(116, 20);
            this.radio_rd.TabIndex = 2;
            this.radio_rd.TabStop = true;
            this.radio_rd.Text = "استرجاع من المورد";
            this.radio_rd.UseVisualStyleBackColor = true;
            // 
            // radioButton_5sm
            // 
            this.radioButton_5sm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_5sm.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton_5sm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton_5sm.FlatAppearance.BorderSize = 10;
            this.radioButton_5sm.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton_5sm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButton_5sm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButton_5sm.Location = new System.Drawing.Point(3, 16);
            this.radioButton_5sm.Name = "radioButton_5sm";
            this.radioButton_5sm.Size = new System.Drawing.Size(95, 20);
            this.radioButton_5sm.TabIndex = 1;
            this.radioButton_5sm.TabStop = true;
            this.radioButton_5sm.Text = "خصم مكتسب";
            this.radioButton_5sm.UseVisualStyleBackColor = true;
            // 
            // radioButton_تحصيل
            // 
            this.radioButton_تحصيل.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_تحصيل.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton_تحصيل.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton_تحصيل.FlatAppearance.BorderSize = 10;
            this.radioButton_تحصيل.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton_تحصيل.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButton_تحصيل.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButton_تحصيل.Location = new System.Drawing.Point(217, 16);
            this.radioButton_تحصيل.Name = "radioButton_تحصيل";
            this.radioButton_تحصيل.Size = new System.Drawing.Size(66, 20);
            this.radioButton_تحصيل.TabIndex = 0;
            this.radioButton_تحصيل.TabStop = true;
            this.radioButton_تحصيل.Text = "دفع";
            this.radioButton_تحصيل.UseVisualStyleBackColor = true;
            // 
            // label_first_rseed
            // 
            this.label_first_rseed.Location = new System.Drawing.Point(38, 126);
            this.label_first_rseed.Name = "label_first_rseed";
            this.label_first_rseed.Size = new System.Drawing.Size(224, 20);
            this.label_first_rseed.TabIndex = 1;
            // 
            // label_total_mdfo3
            // 
            this.label_total_mdfo3.AutoSize = true;
            this.label_total_mdfo3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label_total_mdfo3.Location = new System.Drawing.Point(185, 64);
            this.label_total_mdfo3.Name = "label_total_mdfo3";
            this.label_total_mdfo3.Size = new System.Drawing.Size(0, 13);
            this.label_total_mdfo3.TabIndex = 19;
            // 
            // labl4
            // 
            this.labl4.AutoSize = true;
            this.labl4.Location = new System.Drawing.Point(260, 64);
            this.labl4.Name = "labl4";
            this.labl4.Size = new System.Drawing.Size(92, 13);
            this.labl4.TabIndex = 18;
            this.labl4.Text = "اجمالي التحصيل : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "رصيد اول : ";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label_id.Location = new System.Drawing.Point(186, 19);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(0, 13);
            this.label_id.TabIndex = 15;
            // 
            // label_nme
            // 
            this.label_nme.AutoSize = true;
            this.label_nme.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label_nme.Location = new System.Drawing.Point(136, 43);
            this.label_nme.Name = "label_nme";
            this.label_nme.Size = new System.Drawing.Size(0, 13);
            this.label_nme.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "كود المورد : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "اسم المورد : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "التاريخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "المبلغ";
            // 
            // txt_mdfo3
            // 
            this.txt_mdfo3.Location = new System.Drawing.Point(38, 157);
            this.txt_mdfo3.Name = "txt_mdfo3";
            this.txt_mdfo3.Size = new System.Drawing.Size(256, 20);
            this.txt_mdfo3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_mdfo3at);
            this.groupBox1.Location = new System.Drawing.Point(376, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 362);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة مدفوعات المورد";
            // 
            // dgv_mdfo3at
            // 
            this.dgv_mdfo3at.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mdfo3at.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mdfo3at.Location = new System.Drawing.Point(10, 19);
            this.dgv_mdfo3at.Name = "dgv_mdfo3at";
            this.dgv_mdfo3at.ReadOnly = true;
            this.dgv_mdfo3at.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mdfo3at.Size = new System.Drawing.Size(794, 334);
            this.dgv_mdfo3at.TabIndex = 3;
            // 
            // frm_mwrd_pays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 631);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_mwrd_pays";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة مدفوعات المورد";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fwateer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mdfo3at)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.DataGridView dgv_fwateer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox label_first_rseed;
        public System.Windows.Forms.Label label_total_mdfo3;
        private System.Windows.Forms.Label labl4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label_id;
        public System.Windows.Forms.Label label_nme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mdfo3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgv_mdfo3at;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radio_rd;
        private System.Windows.Forms.RadioButton radioButton_5sm;
        private System.Windows.Forms.RadioButton radioButton_تحصيل;
        private System.Windows.Forms.TextBox txtnotes;
        private System.Windows.Forms.Label label10;
    }
}