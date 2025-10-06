namespace WindowsFormsApplication2.PL
{
    partial class frm_products_list
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
            this.dgvprdcts = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprdcts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvprdcts
            // 
            this.dgvprdcts.AllowUserToAddRows = false;
            this.dgvprdcts.AllowUserToDeleteRows = false;
            this.dgvprdcts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvprdcts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprdcts.Location = new System.Drawing.Point(2, 59);
            this.dgvprdcts.MultiSelect = false;
            this.dgvprdcts.Name = "dgvprdcts";
            this.dgvprdcts.ReadOnly = true;
            this.dgvprdcts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprdcts.Size = new System.Drawing.Size(1227, 436);
            this.dgvprdcts.TabIndex = 0;
            this.dgvprdcts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprdcts_CellContentClick);
            this.dgvprdcts.DoubleClick += new System.EventHandler(this.dgvprdcts_DoubleClick);
            this.dgvprdcts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvprdcts_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(451, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "البحث:";
            // 
            // frm_products_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvprdcts);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_products_list";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة جميع الاصناف";
            this.Load += new System.EventHandler(this.frm_products_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprdcts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvprdcts;
    }
}