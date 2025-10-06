namespace WindowsFormsApplication2.PL
{
    partial class frm_mwrdeen_list
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvcstmrs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcstmrs
            // 
            this.dgvcstmrs.AllowUserToAddRows = false;
            this.dgvcstmrs.AllowUserToDeleteRows = false;
            this.dgvcstmrs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcstmrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcstmrs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcstmrs.Location = new System.Drawing.Point(0, 0);
            this.dgvcstmrs.Name = "dgvcstmrs";
            this.dgvcstmrs.ReadOnly = true;
            this.dgvcstmrs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcstmrs.Size = new System.Drawing.Size(499, 352);
            this.dgvcstmrs.TabIndex = 1;
            this.dgvcstmrs.DoubleClick += new System.EventHandler(this.dgvcstmrs_DoubleClick);
            // 
            // frm_mwrdeen_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 352);
            this.Controls.Add(this.dgvcstmrs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_mwrdeen_list";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة الموردين";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcstmrs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvcstmrs;
    }
}