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
    public partial class frm_deleted_products : Form
    {
        BL.cls_products prd = new BL.cls_products();
        BL.cls_mwrdeen mwrd = new BL.cls_mwrdeen();
        public frm_deleted_products()
        {
            InitializeComponent();
            dataGridView1.DataSource = prd.get_all_deleted_products();
        }

        private void frm_deleted_products_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الغاء حذف حذف الصنف","الغاء الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {

                Int32 selectedRowCount =
               dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {

                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        prd.undelete_product(Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0].Value));
                        if (!string.IsNullOrEmpty(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[11].Value.ToString()))
                        {
                            mwrd.update_total_w_msdd_fwateer_mwrd_case_add(Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0].Value)
                                ,Convert.ToDouble(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[7].Value));
                        }
                    }
                }
                //prd.undelete_product(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                dataGridView1.DataSource = prd.get_all_deleted_products();
            }
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("سوف يتم حذف كل متعلقات الصنف من مشتريات ومبيعات وهالك ومرتجع مشتريات ومرتجع مبيعات \n هل تريد تأكيد الحذف ؟؟","حذف نهائي",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                prd.prd_permenant_delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), dataGridView1.CurrentRow.Cells[1].Value.ToString());
                dataGridView1.DataSource = prd.get_all_deleted_products();

                MessageBox.Show("تم الحذف بنجاح", "حذف نهائي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
