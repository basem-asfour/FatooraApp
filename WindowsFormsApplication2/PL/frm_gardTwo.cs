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
    public partial class frm_gardTwo : Form
    {
        BL.cls_products prd = new BL.cls_products();

        public frm_gardTwo()
        {
            InitializeComponent();
        }

        public void frm_refresh()
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                dataGridView1.Rows[i].Cells[3].Value = prd.get_single_product(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)).Rows[0][1].ToString();

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) < Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.NavajoWhite;
                }
            }   
        }



        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) < Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.NavajoWhite;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("عند القيام بتمكين المطابقة يدوياَ قم بكتابة القيمة المراد تطبيقها في عمود كمية كارت الصنف ثم قم بتحديد الاصناف المراد مطابقتها واضغط علي زر مطابقة الاصناف المحددة", "عمليه المطابقة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                checkBox1.BackColor = Color.LightGreen;
                dataGridView1.ReadOnly = false;
            }
            else
            {
                checkBox1.BackColor = Color.PapayaWhip;
                dataGridView1.ReadOnly = true;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من تحديث كميات اصناف القائمة ادناه القيم الموجودة في عمود *كمية كارت الصنف *؟؟", "عمليه المطابقة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    prd.edit_prd_qte_for_gard(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value));
                }
                MessageBox.Show("تمت المطابقة بنجاح", "عمليه المطابقة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            frm_refresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من تحديث كميات الأصناف المحددة ادناه بالقيم الموجودة في عمود *كمية كارت الصنف *؟؟", "عمليه المطابقة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Int32 selectedRowCount =
                      dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    prd.edit_prd_qte_for_gard(Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0].Value),
                        Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[2].Value));
                }
                MessageBox.Show("تمت المطابقة بنجاح", "عمليه المطابقة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            frm_refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{
                //    if (row.Cells[1].Value.ToString().Contains(textBox1.Text))
                //    {
                //        row.Selected = true;
                //        break;
                //    }
                //}
                string rowFilter = string.Format("[{0}] Like '%{1}%'", "اسم الصنف", textBox1.Text);
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) < Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.NavajoWhite;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) < Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.NavajoWhite;
                }
            }
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من تحديث كميات اصناف القائمة ادناه القيم الموجودة في عمود *كمية كارت الصنف *؟؟", "عمليه المطابقة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    prd.edit_prd_qte_for_gard(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value));
                }
                MessageBox.Show("تمت المطابقة بنجاح", "عمليه المطابقة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            frm_refresh();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من تحديث كميات الأصناف المحددة ادناه بالقيم الموجودة في عمود *كمية كارت الصنف *؟؟", "عمليه المطابقة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Int32 selectedRowCount =
                      dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    prd.edit_prd_qte_for_gard(Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0].Value),
                        Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[2].Value));
                }
                MessageBox.Show("تمت المطابقة بنجاح", "عمليه المطابقة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            frm_refresh();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{
                //    if (row.Cells[1].Value.ToString().Contains(textBox1.Text))
                //    {
                //        row.Selected = true;
                //        break;
                //    }
                //}
                string rowFilter = string.Format("[{0}] Like '%{1}%'", "اسم الصنف", textBox1.Text);
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) < Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.NavajoWhite;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) < Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.NavajoWhite;
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) < Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.NavajoWhite;
                }
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("عند القيام بتمكين المطابقة يدوياَ قم بكتابة القيمة المراد تطبيقها في عمود كمية كارت الصنف ثم قم بتحديد الاصناف المراد مطابقتها واضغط علي زر مطابقة الاصناف المحددة", "عمليه المطابقة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                checkBox1.BackColor = Color.LightGreen;
                dataGridView1.ReadOnly = false;
            }
            else
            {
                checkBox1.BackColor = Color.PapayaWhip;
                dataGridView1.ReadOnly = true;
            }
        }
    }
}
