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
    public partial class frm_prd_first_rseed : Form
    {
        BL.cls_products prd = new BL.cls_products();

        public frm_prd_first_rseed()
        {
            InitializeComponent();
            dataGridView1.DataSource = prd.get_all_products_first_rseed();
        }
        public void frm_refresh()
        {
            Cursor.Current = Cursors.WaitCursor;
            
            dataGridView1.DataSource = prd.get_all_products_first_rseed();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Int64 first_rseed = 0;
                if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[2].Value.ToString()))
                {
                     first_rseed = Convert.ToInt64(dataGridView1.Rows[i].Cells[2].Value);
                }

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > first_rseed)
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == first_rseed)
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) < first_rseed)
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.NavajoWhite;
                }
                Cursor.Current = Cursors.Default;

            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                string rowFilter = string.Format("[{0}] Like '%{1}%'", "اسم الصنف", textBox1.Text);
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_refresh();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("عند القيام بتمكين المطابقة يدوياَ قم بكتابة القيمة المراد تطبيقها في عمود كمية ادارة الأصناف ثم قم بتحديد الاصناف المراد مطابقتها واضغط علي زر مطابقة الاصناف المحددة", "عمليه المطابقة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                checkBox1.BackColor = Color.LightGreen;
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns[3].ReadOnly = false;
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
            }
            else
            {
                checkBox1.BackColor = Color.PapayaWhip;
                dataGridView1.ReadOnly = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من تحديث رصيد أول الأصناف المحددة ادناه بالقيم الموجودة في عمود *كمية ادارة الأصناف *؟؟", "عمليه المطابقة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Int32 selectedRowCount =
                      dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    prd.update_products_first_rseed(Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0].Value),
                        Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[3].Value));
                }
                MessageBox.Show("تمت المطابقة بنجاح", "عمليه المطابقة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            frm_refresh();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من تحديث رصيد أول اصناف القائمة ادناه القيم الموجودة في عمود *كمية ادارة الأصناف *؟؟", "عمليه المطابقة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    prd.update_products_first_rseed(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));
                }
                MessageBox.Show("تمت المطابقة بنجاح", "عمليه المطابقة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            frm_refresh();

        }
    }
}
