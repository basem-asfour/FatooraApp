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
    public partial class frm_gard : Form
    {
        BL.cls_products prd = new BL.cls_products();
        DataTable new_dt = new System.Data.DataTable();
        DataTable dt_cat = new DataTable();
        public frm_gard()
        {
            InitializeComponent();

            dt_cat = prd.get_all_catogries();
            combo_cat.DataSource = dt_cat;
            combo_cat.DisplayMember = "النوع";
            combo_cat.ValueMember = "id";
        }

        public void frm_refresh()
        {
            Cursor.Current = Cursors.WaitCursor;

           

            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                new_dt.Merge(prd.get_all_products_for_gard(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)));

               // dataGridView1.Rows[i].Cells[3].Value = prd.get_single_product(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)).Rows[0][1].ToString();

                //if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > Convert.ToInt64(dataGridView1.Rows[i].Cells[2].Value))
                //{
                //    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                //}
                //if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == Convert.ToInt64(dataGridView1.Rows[i].Cells[2].Value))
                //{
                //    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                //}
                //if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) < Convert.ToInt64(dataGridView1.Rows[i].Cells[2].Value))
                //{
                //    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.NavajoWhite;
                //}
            }
            dataGridView1.DataSource = new_dt;
            Cursor.Current = Cursors.Default;
           
        }


        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > Convert.ToInt64(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == Convert.ToInt64(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) < Convert.ToInt64(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.NavajoWhite;
                }
                //Int64 first_rseed = 0;
                //if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[8].Value.ToString()))
                //{
                //    first_rseed = Convert.ToInt64(dataGridView1.Rows[i].Cells[8].Value);
                //}

                //if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > first_rseed)
                //{
                //    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                //}
                //if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == first_rseed)
                //{
                //    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                //}
                //if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) < first_rseed)
                //{
                //    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.NavajoWhite;
                //}
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("عند القيام بتمكين المطابقة يدوياَ قم بكتابة القيمة المراد تطبيقها في عمود القيمة الجديدة ثم قم بتحديد الاصناف المراد مطابقتها واضغط علي زر مطابقة الاصناف المحددة", "عمليه المطابقة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                checkBox1.BackColor = Color.LightGreen;
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[8].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[5].ReadOnly = true;
                dataGridView1.Columns[6].ReadOnly = true;
                dataGridView1.Columns[7].ReadOnly = true;
                dataGridView1.Columns[9].ReadOnly = true;
                dataGridView1.Columns.Add("اكتب هنا", "القيمة الجديدة");
                button4.Visible = true;
                button6.Visible = true;
            }
            else
            {
                checkBox1.BackColor = Color.PapayaWhip;
                dataGridView1.ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns.RemoveAt(10);
                button4.Visible = false;
                button6.Visible = false;

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من تحديث كميات ادارة اصناف القائمة ادناه بالقيم الموجودة في عمود *كمية كارت الصنف *؟؟", "عمليه المطابقة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            if (MessageBox.Show("هل انت متأكد من تحديث كميات ادارةالأصناف المحددة ادناه بالقيم الموجودة في عمود *القيمة الجديدة *؟؟", "عمليه المطابقة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Int32 selectedRowCount =
                      dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    
                    if (dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[10].Value != null)
                    {
                        prd.edit_prd_qte_for_gard(Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0].Value),
                        Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[10].Value));

                        dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[3].Value = dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[10].Value;
                        dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[10].Value = "";
                    }
                }
                MessageBox.Show("تمت المطابقة بنجاح", "عمليه المطابقة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           // frm_refresh();
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
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > Convert.ToInt64(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == Convert.ToInt64(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) < Convert.ToInt64(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.NavajoWhite;
                }
                //Int64 first_rseed = 0;
                //if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[8].Value.ToString()))
                //{
                //    first_rseed = Convert.ToInt64(dataGridView1.Rows[i].Cells[8].Value);
                //}

                //if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > first_rseed)
                //{
                //    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                //}
                //if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == first_rseed)
                //{
                //    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                //}
                //if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) < first_rseed)
                //{
                //    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.NavajoWhite;
                //}
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > Convert.ToInt64(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == Convert.ToInt64(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) < Convert.ToInt64(dataGridView1.Rows[i].Cells[2].Value))
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.NavajoWhite;
                }
                //Int64 first_rseed = 0;
                //if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[8].Value.ToString()))
                //{
                //    first_rseed = Convert.ToInt64(dataGridView1.Rows[i].Cells[8].Value);
                //}

                //if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > first_rseed)
                //{
                //    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                //}
                //if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == first_rseed)
                //{
                //    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                //}
                //if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) < first_rseed)
                //{
                //    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.NavajoWhite;
                //}
            }
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من تحديث رصيد أول الأصناف المحددة ادناه بالقيم الموجودة في عمود *القيمة الجديدة *؟؟", "عمليه المطابقة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Int32 selectedRowCount =
                      dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    if (!string.IsNullOrEmpty(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[10].Value.ToString()))
                    {

                        prd.update_products_first_rseed(Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0].Value),
                            Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[10].Value));
                        dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[8].Value = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[10].Value);
                        dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[10].Value = string.Empty;
                    }
                }
                MessageBox.Show("تمت المطابقة بنجاح", "عمليه المطابقة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
            //frm_refresh();
        }
    }
}
