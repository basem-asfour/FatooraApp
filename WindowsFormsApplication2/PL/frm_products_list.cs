using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.PL
{
    public partial class frm_products_list : Form
    {
        BL.cls_products prd = new BL.cls_products();
        public frm_products_list()
        {
            InitializeComponent();
            this.dgvprdcts.DataSource = prd.get_all_products();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                DataTable dt = new DataTable();
                dt = prd.searchproduct(textBox1.Text);
                this.dgvprdcts.DataSource = dt;
           
            
        }

        private void dgvprdcts_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_products_list_Load(object sender, EventArgs e)
        {
            this.dgvprdcts.Columns[0].Width = 100;
            this.dgvprdcts.Columns[1].Width = 210;
            this.dgvprdcts.Columns[2].Width = 78;
            this.dgvprdcts.Columns[3].Width = 83;
            this.dgvprdcts.Columns[4].Width = 80;
            this.dgvprdcts.Columns[5].Width = 105;
            this.dgvprdcts.Columns[6].Width = 100;
        }

        private void dgvprdcts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvprdcts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                Close();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dgvprdcts.Focus();
            }
        }
    }
}
