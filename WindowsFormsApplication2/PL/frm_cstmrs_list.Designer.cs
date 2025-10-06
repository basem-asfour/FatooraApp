namespace WindowsFormsApplication2.PL
{
    partial class frm_cstmrs_list
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
            this.dgvcstmrs = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcstmrs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcstmrs
            // 
            this.dgvcstmrs.AllowUserToAddRows = false;
            this.dgvcstmrs.AllowUserToDeleteRows = false;
            this.dgvcstmrs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcstmrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcstmrs.Location = new System.Drawing.Point(0, 31);
            this.dgvcstmrs.Name = "dgvcstmrs";
            this.dgvcstmrs.ReadOnly = true;
            this.dgvcstmrs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcstmrs.Size = new System.Drawing.Size(965, 389);
            this.dgvcstmrs.TabIndex = 0;
            this.dgvcstmrs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcstmrs_CellContentClick);
            this.dgvcstmrs.DoubleClick += new System.EventHandler(this.dgvcstmrs_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(507, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "البحث:";
            // 
            // frm_cstmrs_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 419);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvcstmrs);
            this.Name = "frm_cstmrs_list";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لائحة العملاء";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcstmrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvcstmrs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;

    }
}