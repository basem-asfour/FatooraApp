namespace WindowsFormsApplication2.PL
{
    partial class frm_select_serial_for_order
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgv_serials = new System.Windows.Forms.DataGridView();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_serials)).BeginInit();
            this.SuspendLayout();
            //
            // dgv_serials
            //
            this.dgv_serials.AllowUserToAddRows = false;
            this.dgv_serials.AllowUserToDeleteRows = false;
            this.dgv_serials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_serials.BackgroundColor = System.Drawing.Color.White;
            this.dgv_serials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_serials.Location = new System.Drawing.Point(12, 45);
            this.dgv_serials.MultiSelect = true;
            this.dgv_serials.Name = "dgv_serials";
            this.dgv_serials.ReadOnly = true;
            this.dgv_serials.RowHeadersWidth = 51;
            this.dgv_serials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_serials.Size = new System.Drawing.Size(460, 280);
            this.dgv_serials.TabIndex = 0;
            //
            // lbl_info
            //
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(12, 15);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_info.Size = new System.Drawing.Size(280, 16);
            this.lbl_info.TabIndex = 1;
            this.lbl_info.Text = "اختر السيريالات المطلوبة (الكمية المطلوبة: 0)";
            //
            // btn_ok
            //
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(187)))), ((int)(((byte)(120)))));
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.FlatAppearance.BorderSize = 0;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(297, 335);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(85, 35);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "موافق";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            //
            // btn_cancel
            //
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(388, 335);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(84, 35);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "إلغاء";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            //
            // frm_select_serial_for_order
            //
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.dgv_serials);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_select_serial_for_order";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اختيار السيريالات";
            this.Load += new System.EventHandler(this.frm_select_serial_for_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_serials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_serials;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}
