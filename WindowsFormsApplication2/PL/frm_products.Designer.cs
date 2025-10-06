namespace WindowsFormsApplication2.PL
{
    partial class frm_products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_products));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQunts = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.txt_qte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_cat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.printDocumentBarCode = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1327, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ادخل كلمه البحث";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(926, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1518, 579);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمه الاصناف";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1518, 556);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Controls.Add(this.txtQunts);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button25);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button26);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(10, 679);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1518, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            // 
            // txtQunts
            // 
            this.txtQunts.Location = new System.Drawing.Point(13, 34);
            this.txtQunts.Name = "txtQunts";
            this.txtQunts.Size = new System.Drawing.Size(144, 22);
            this.txtQunts.TabIndex = 28;
            this.txtQunts.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MintCream;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_page_setup_48;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(844, 90);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 73);
            this.button3.TabIndex = 8;
            this.button3.Text = "طباعه نسخه مكتب";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Firebrick;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_close_48;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.Location = new System.Drawing.Point(13, 99);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 55);
            this.button8.TabIndex = 7;
            this.button8.Text = "خروج";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.DarkBlue;
            this.button25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ForeColor = System.Drawing.Color.AliceBlue;
            this.button25.Image = global::WindowsFormsApplication2.Properties.Resources.checklist1;
            this.button25.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button25.Location = new System.Drawing.Point(296, 105);
            this.button25.Margin = new System.Windows.Forms.Padding(4);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(250, 57);
            this.button25.TabIndex = 26;
            this.button25.Text = "مطابقة الجرد";
            this.button25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MintCream;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arabic Typesetting", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_plus_48;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(1296, 23);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(205, 69);
            this.button6.TabIndex = 5;
            this.button6.Text = "اضافه صنف جديد";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseEnter += new System.EventHandler(this.button6_MouseEnter);
            this.button6.MouseLeave += new System.EventHandler(this.button6_MouseLeave);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.MintCream;
            this.button26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Image = global::WindowsFormsApplication2.Properties.Resources.open;
            this.button26.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button26.Location = new System.Drawing.Point(587, 90);
            this.button26.Margin = new System.Windows.Forms.Padding(4);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(235, 72);
            this.button26.TabIndex = 27;
            this.button26.Text = "ادارة رصيد أول الأصناف";
            this.button26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            this.button26.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button26.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MintCream;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_edit_48;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(1072, 23);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(216, 69);
            this.button5.TabIndex = 4;
            this.button5.Text = "تعديل بيانات الصنف";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MintCream;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_delete_48;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(1072, 90);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 73);
            this.button4.TabIndex = 3;
            this.button4.Text = "حذف الصنف المحدد";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_print_48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(844, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "طباعه كل الاصناف ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MintCream;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_delete_48;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(587, 23);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(235, 73);
            this.button7.TabIndex = 0;
            this.button7.Text = "عرض الأصناف المحذوفة";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button7.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_e_magazine_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1296, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "صوره الصنف";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_money_circulation_48;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(296, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "اجمالي الرصيد";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(296, 73);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(250, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument2;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printDialog2
            // 
            this.printDialog2.Document = this.printDocument2;
            this.printDialog2.UseEXDialog = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1212, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "اسم الصنف او السيريال او النوع او المخزن";
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(261, 21);
            this.button20.Margin = new System.Windows.Forms.Padding(4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(189, 47);
            this.button20.TabIndex = 18;
            this.button20.Text = "فلترة الكميات";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Visible = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // txt_qte
            // 
            this.txt_qte.Location = new System.Drawing.Point(669, 54);
            this.txt_qte.Margin = new System.Windows.Forms.Padding(4);
            this.txt_qte.Name = "txt_qte";
            this.txt_qte.Size = new System.Drawing.Size(156, 22);
            this.txt_qte.TabIndex = 0;
            this.txt_qte.TextChanged += new System.EventHandler(this.txt_qte_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(833, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "الكمية:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "--  حد الطلب   --";
            // 
            // combo_cat
            // 
            this.combo_cat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_cat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_cat.FormattingEnabled = true;
            this.combo_cat.Location = new System.Drawing.Point(458, 54);
            this.combo_cat.Margin = new System.Windows.Forms.Padding(4);
            this.combo_cat.Name = "combo_cat";
            this.combo_cat.Size = new System.Drawing.Size(189, 24);
            this.combo_cat.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(586, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "اختيار النوع";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button21);
            this.groupBox3.Controls.Add(this.button27);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button20);
            this.groupBox3.Controls.Add(this.combo_cat);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_qte);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.ForeColor = System.Drawing.Color.GhostWhite;
            this.groupBox3.Location = new System.Drawing.Point(10, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1518, 87);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_search_48;
            this.pictureBox1.Location = new System.Drawing.Point(1461, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkBlue;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_menu_48;
            this.button9.Location = new System.Drawing.Point(97, 21);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 59);
            this.button9.TabIndex = 7;
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DarkBlue;
            this.button21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button21.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_refresh_48;
            this.button21.Location = new System.Drawing.Point(8, 21);
            this.button21.Margin = new System.Windows.Forms.Padding(4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(76, 59);
            this.button21.TabIndex = 19;
            this.button21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Navy;
            this.button27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button27.ForeColor = System.Drawing.Color.AliceBlue;
            this.button27.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_search_48;
            this.button27.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button27.Location = new System.Drawing.Point(458, 21);
            this.button27.Margin = new System.Windows.Forms.Padding(4);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(130, 32);
            this.button27.TabIndex = 75;
            this.button27.Text = "بحث بالنوع";
            this.button27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.MintCream;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Navy;
            this.button10.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_barcode_reader_48;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.Location = new System.Drawing.Point(196, 21);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(235, 59);
            this.button10.TabIndex = 27;
            this.button10.Text = "طباعة باركود الأصناف";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            this.button10.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button10.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // printDocumentBarCode
            // 
            this.printDocumentBarCode.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentBarCode_PrintPage);
            // 
            // frm_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1538, 866);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_products";
            this.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة اداره الاصناف";
            this.Load += new System.EventHandler(this.frm_products_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.TextBox txt_qte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.ComboBox combo_cat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtQunts;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button10;
        private System.Drawing.Printing.PrintDocument printDocumentBarCode;
    }
}