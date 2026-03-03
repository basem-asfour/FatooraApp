using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.UI;

namespace WindowsFormsApplication2.PL
{
    public partial class frm_cstmrs_list_forEdit : Form
    {

        BL.cls_cstmrs cust = new BL.cls_cstmrs();
        BL.cls_orders order = new BL.cls_orders();

        public frm_cstmrs_list_forEdit()
        {
            InitializeComponent();
            
            ApplyModernTheme();
            
            this.dataGridView1.DataSource = cust.get_all_cstmrs();
        }
        
        private void ApplyModernTheme()
        {
            // Apply modern form styling
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            
            // Style DataGridView
            StyleDataGridView();
            
            // Style Labels
            StyleLabels();
        }
        
        private void StyleDataGridView()
        {
            if (dataGridView1 != null)
            {
                ModernTheme.StyleDataGridView(dataGridView1);
            }
        }
        
        private void StyleLabels()
        {
            if (label1 != null)
            {
                ModernTheme.StyleLabel(label1, LabelStyle.Normal);
                label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                label1.ForeColor = ModernTheme.TextPrimary;
                label1.UseCompatibleTextRendering = false;
                label1.AutoSize = false;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (MessageBox.Show("متأكد انك تريد تغير العميل ؟؟", "تغيير العميل", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    order.change_cstmr(Convert.ToInt32(label1.Text), Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    Close();
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("متأكد انك تريد تغير العميل ؟؟", "تغيير العميل", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                order.change_cstmr(Convert.ToInt32(label1.Text),Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                Close();
            }
            
        }
    }
}
