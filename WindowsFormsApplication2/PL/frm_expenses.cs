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
    public partial class frm_expenses : Form
    {
        BL.cls_expenses expn = new BL.cls_expenses();
        DataTable dt_kind;
        BL.cls_mndobeen mndb = new BL.cls_mndobeen();
        BL.cls_stores store = new BL.cls_stores();
        DataTable dt_msarif = new DataTable();
        void createdatatable_msarif()
        {
            dt_msarif.Columns.Add("كود المصروف");
            dt_msarif.Columns.Add("النوع");
            dt_msarif.Columns.Add("المبلغ");
            dt_msarif.Columns.Add("التفاصيل");
            dt_msarif.Columns.Add("التاريخ");

        }
        public frm_expenses()
        {
            InitializeComponent();
            dataGridView1.DataSource = expn.get_all_expenses();
            textBox2.Text = (from DataGridViewRow row in dataGridView1.Rows
                             where row.Cells[2].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();

            //createdatatable_msarif();
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cach.Text))
            {
                MessageBox.Show("من فضلك حدد قيمة المبلغ المصروف", "نقص معلومات", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            expn.add_expenses(combo_kind.Text, Convert.ToDouble(txt_cach.Text), txtdetails.Text, dateTimePicker1.Value.Date);
            MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_cach.Text = "";
            txtdetails.Text = "";
            dataGridView1.DataSource = expn.get_all_expenses();
            textBox2.Text = (from DataGridViewRow row in dataGridView1.Rows
                             where row.Cells[2].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();

        }

        private void txt_serch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_serch.Text))
            {
                //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
                dataGridView1.DataSource = expn.get_all_expenses_for_kind(txt_serch.Text);
                //string rowFilter = string.Format("[{0}] Like '{1}'", "النوع", txt_serch.Text);
                //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                textBox2.Text = (from DataGridViewRow row in dataGridView1.Rows
                                 where row.Cells[2].FormattedValue.ToString() != string.Empty
                                 select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
                
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cach.Text))
            {
                MessageBox.Show("من فضلك حدد قيمة المبلغ المصروف", "نقص معلومات", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            expn.edit_expenses(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),combo_kind.Text, Convert.ToDouble(txt_cach.Text), txtdetails.Text, dateTimePicker1.Value.Date);
            MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_cach.Text = "";
            txtdetails.Text = "";
            dataGridView1.DataSource = expn.get_all_expenses();
            textBox2.Text = (from DataGridViewRow row in dataGridView1.Rows
                             where row.Cells[2].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المصروف المحدد ادناه؟؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                expn.delete_expenses(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_cach.Text = "";
                txtdetails.Text = "";
                dataGridView1.DataSource = expn.get_all_expenses();
                textBox2.Text = (from DataGridViewRow row in dataGridView1.Rows
                                 where row.Cells[2].FormattedValue.ToString() != string.Empty
                                 select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            dt_kind = store.get_all_m5azen();
            combo_kind.DataSource = dt_kind;
            combo_kind.DisplayMember = "اسم المخزن";
            combo_kind.ValueMember = "id";
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            dt_kind = mndb.get_all_mndopeen();
            combo_kind.DataSource = dt_kind;
            combo_kind.DisplayMember = "اسم المندوب";
            combo_kind.ValueMember = "id";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            dt_kind.Clear();
            combo_kind.DataSource = dt_kind;
            combo_kind.Text = "مصاريف متنوعة";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_cach.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtdetails.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                combo_kind.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
            }
            catch (Exception)
            {
                
            }
            
        }
        public List<DateTime> get_dates_between(DateTime startDate, DateTime endDate)
        {
            List<DateTime> allDates = new List<DateTime>();
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                allDates.Add(date);
            }
            return allDates;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            dt_msarif.Clear();
            foreach (var item in get_dates_between(dateTimePicker3.Value, dateTimePicker2.Value))
            {
                dt_msarif.Merge(expn.get_all_expenses_for_specific_date(item.Date));

            }
            dataGridView1.DataSource = dt_msarif;
            textBox2.Text = (from DataGridViewRow row in dataGridView1.Rows
                             where row.Cells[2].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = expn.get_all_expenses();
            textBox2.Text = (from DataGridViewRow row in dataGridView1.Rows
                             where row.Cells[2].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
        }
        DataTable dt_from_to = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_from.Text)&&!string.IsNullOrEmpty(txt_to.Text))
            {
                //List<int> nums = new List<int>();
                for (int i = Convert.ToInt32(txt_from.Text); i <= Convert.ToInt32(txt_to.Text); i++)
                {
                    dt_from_to.Merge(expn.get_single_expenses(i));
                }
                dataGridView1.DataSource = dt_from_to;
                //for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                //{
                //    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)<Convert.ToInt32(txt_from.Text)||Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)>Convert.ToInt32(txt_to.Text))
                //    {
                //        dataGridView1.Rows[i].Clone();
                //    }
                //}
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt_msarif.Clear();
            foreach (var item in get_dates_between(dateTimePicker3.Value, dateTimePicker2.Value))
            {
                dt_msarif.Merge(expn.get_all_expenses_for_kind_by_date(txt_serch.Text,item.Date));

            }
            dataGridView1.DataSource = dt_msarif;
            textBox2.Text = (from DataGridViewRow row in dataGridView1.Rows
                             where row.Cells[2].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
        }
    }
}
