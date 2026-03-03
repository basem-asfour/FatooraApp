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
    public partial class frm_cstmrs_list : Form
    {
        BL.cls_cstmrs cust = new BL.cls_cstmrs();
        public frm_cstmrs_list()
        {
            InitializeComponent();
            
            ApplyModernTheme();
            
            this.dgvcstmrs.DataSource = cust.get_all_cstmrs();
        }
        
        private void ApplyModernTheme()
        {
            // Apply modern form styling
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            
            // Style DataGridView
            StyleDataGridView();
            
            // Style TextBox
            StyleTextBox();
        }
        
        private void StyleDataGridView()
        {
            if (dgvcstmrs != null)
            {
                ModernTheme.StyleDataGridView(dgvcstmrs);
            }
        }
        
        private const string SearchPlaceholder = "🔍 ابحث عن العميل...";

        private void StyleTextBox()
        {
            if (textBox1 != null)
            {
                ModernTheme.StyleTextBox(textBox1);
                textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                textBox1.GotFocus += (s, e) =>
                {
                    if (textBox1.Text == SearchPlaceholder)
                    {
                        textBox1.Text = "";
                        textBox1.ForeColor = SystemColors.WindowText;
                    }
                };
                textBox1.LostFocus += (s, e) =>
                {
                    if (string.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        textBox1.Text = SearchPlaceholder;
                        textBox1.ForeColor = SystemColors.GrayText;
                    }
                };
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    textBox1.Text = SearchPlaceholder;
                    textBox1.ForeColor = SystemColors.GrayText;
                }
            }
        }

        private void dgvcstmrs_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvcstmrs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search = (textBox1.Text == SearchPlaceholder) ? "" : textBox1.Text;
            this.dgvcstmrs.DataSource = cust.search_cstmrs(search);
        }
    }
}
