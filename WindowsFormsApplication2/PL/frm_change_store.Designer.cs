namespace WindowsFormsApplication2.PL
{
    partial class frm_change_store
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
            this.label10 = new System.Windows.Forms.Label();
            this.combo_stores = new System.Windows.Forms.ComboBox();
            this.txtnme = new System.Windows.Forms.ComboBox();
            this.txtqte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_prd_nme = new System.Windows.Forms.TextBox();
            this.txt_prd_id = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 12);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "المخزن";
            // 
            // combo_stores
            // 
            this.combo_stores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_stores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_stores.FormattingEnabled = true;
            this.combo_stores.Location = new System.Drawing.Point(73, 12);
            this.combo_stores.Name = "combo_stores";
            this.combo_stores.Size = new System.Drawing.Size(348, 21);
            this.combo_stores.TabIndex = 28;
            // 
            // txtnme
            // 
            this.txtnme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtnme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtnme.FormattingEnabled = true;
            this.txtnme.Location = new System.Drawing.Point(73, 51);
            this.txtnme.Name = "txtnme";
            this.txtnme.Size = new System.Drawing.Size(305, 21);
            this.txtnme.TabIndex = 25;
            this.txtnme.Visible = false;
            this.txtnme.SelectedIndexChanged += new System.EventHandler(this.txtnme_SelectedIndexChanged);
            // 
            // txtqte
            // 
            this.txtqte.Location = new System.Drawing.Point(73, 87);
            this.txtqte.Name = "txtqte";
            this.txtqte.Size = new System.Drawing.Size(348, 20);
            this.txtqte.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "الكميه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 53);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "اسم الصنف";
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_change.Location = new System.Drawing.Point(487, 79);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(123, 34);
            this.btn_change.TabIndex = 30;
            this.btn_change.Text = "تأكيد";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Location = new System.Drawing.Point(630, 79);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(125, 34);
            this.btn_cancel.TabIndex = 31;
            this.btn_cancel.Text = "الغاء";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.dgv_products);
            this.groupBox3.Location = new System.Drawing.Point(17, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(839, 84);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات الصنف المختار";
            // 
            // dgv_products
            // 
            this.dgv_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Location = new System.Drawing.Point(6, 18);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.ReadOnly = true;
            this.dgv_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_products.Size = new System.Drawing.Size(826, 62);
            this.dgv_products.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(329, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "اختيار صنف";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_prd_nme
            // 
            this.txt_prd_nme.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_prd_nme.Location = new System.Drawing.Point(73, 51);
            this.txt_prd_nme.Name = "txt_prd_nme";
            this.txt_prd_nme.ReadOnly = true;
            this.txt_prd_nme.Size = new System.Drawing.Size(255, 20);
            this.txt_prd_nme.TabIndex = 34;
            // 
            // txt_prd_id
            // 
            this.txt_prd_id.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_prd_id.Location = new System.Drawing.Point(121, 113);
            this.txt_prd_id.Name = "txt_prd_id";
            this.txt_prd_id.ReadOnly = true;
            this.txt_prd_id.Size = new System.Drawing.Size(71, 20);
            this.txt_prd_id.TabIndex = 35;
            this.txt_prd_id.Visible = false;
            // 
            // frm_change_store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 229);
            this.Controls.Add(this.txt_prd_id);
            this.Controls.Add(this.txt_prd_nme);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combo_stores);
            this.Controls.Add(this.txtnme);
            this.Controls.Add(this.txtqte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_change_store";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغيير مخزن الصنف";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox combo_stores;
        public System.Windows.Forms.ComboBox txtnme;
        public System.Windows.Forms.TextBox txtqte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_products;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txt_prd_nme;
        public System.Windows.Forms.TextBox txt_prd_id;

    }
}