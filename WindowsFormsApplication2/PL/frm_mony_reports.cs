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
    public partial class frm_mony_reports : Form
    {
        BL.cls_cstmrs cstmr = new BL.cls_cstmrs();
        BL.cls_mwrdeen mwrd = new BL.cls_mwrdeen();
        BL.cls_expenses expn = new BL.cls_expenses();
        BL.cls_orders order = new BL.cls_orders();
        DataTable dt_msarif = new DataTable();
        DataTable dt_cstmr = new DataTable();
        DataTable dt_mwrd = new DataTable();
        DataTable dt_new_orders = new DataTable();
        DataTable dt_mndob;
        BL.cls_mndobeen mndb = new BL.cls_mndobeen();
        public frm_mony_reports()
        {

            InitializeComponent();
            dgv_cstmrs.DataSource = cstmr.get_all_cstmrs_pays_bydate("");
            dgv_mwrden.DataSource = mwrd.get_all_mwrdeen_pays_bydate("");
            dgv_msarif.DataSource = expn.get_all_expenses();
            dgv_orders.DataSource= order.get_all_new_orders();
            calc_sum();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            //
            dt_mndob = mndb.get_all_mndopeen();
            combo_mndoob.DataSource = dt_mndob;
            combo_mndoob.DisplayMember = "اسم المندوب";
            combo_mndoob.ValueMember = "id";
            combo_mndoob.Text = "";
            
        }
        void createdatatable_msarif()
        {
            dt_msarif.Columns.Add("كود المصروف");
            dt_msarif.Columns.Add("النوع");
            dt_msarif.Columns.Add("المبغ");
            dt_msarif.Columns.Add("التفاصيل");
            dt_msarif.Columns.Add("التاريخ");

        }
        void createdatatable_cstmr()
        {
            dt_cstmr.Columns.Add("كود التحصيل");
            dt_cstmr.Columns.Add("اسم العميل");
            dt_cstmr.Columns.Add("رصيد اول");
            dt_cstmr.Columns.Add("المدفوع");
            dt_cstmr.Columns.Add("رصيد اخر");
            dt_cstmr.Columns.Add("التاريخ");
            dt_cstmr.Columns.Add("اسم المندوب");

        }
        void createdatatable_mwrd()
        {
            dt_mwrd.Columns.Add("كود التحصيل");
            dt_mwrd.Columns.Add("اسم المورد");
            dt_mwrd.Columns.Add("رصيد اول");
            dt_mwrd.Columns.Add("المدفوع");
            dt_mwrd.Columns.Add("رصيد اخر");
            dt_mwrd.Columns.Add("التاريخ");
       }
        void createdatatable_new_orders()
        {
            dt_new_orders.Columns.Add("رقم الفاتورة");
            dt_new_orders.Columns.Add("تاريخ الفاتورة");
            dt_new_orders.Columns.Add("اسم العميل");
            dt_new_orders.Columns.Add("المبلغ المسدد");
            dt_new_orders.Columns.Add("المبلغ المتبقي");
            dt_new_orders.Columns.Add("اجمالي الفاتورة");
            dt_new_orders.Columns.Add("صافي الربح");
            dt_new_orders.Columns.Add("اسم المندوب");
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
        public void refresh_frm()
        { 
            
        }
        public void calc_sum()
        {
            txt_total_msarif.Text = (from DataGridViewRow row in dgv_msarif.Rows
                                     where row.Cells[2].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
            txt_total_mwrd.Text = (from DataGridViewRow row in dgv_mwrden.Rows 
                                   where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[6].FormattedValue.ToString() !="خصم مكتسب"
                                   select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            txt_total_ta7seel.Text = (from DataGridViewRow row in dgv_cstmrs.Rows
                                      where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[7].FormattedValue.ToString() != "خصم مسموح به"
                                      select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            txt_total_nkdi.Text = (from DataGridViewRow row in dgv_orders.Rows
                                   where row.Cells[5].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString()=="بيع نقدي"
                                      select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
            txt_total_msdd.Text = (from DataGridViewRow row in dgv_orders.Rows
                                   where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() != "بيع نقدي"
                                   select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            txt_totalBee3.Text = (from DataGridViewRow row in dgv_orders.Rows
                                   where row.Cells[5].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() != "بيع نقدي"
                                   select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
            try
            {
                txt_safi.Text = ((Convert.ToDouble(txt_total_ta7seel.Text) - Convert.ToDouble(txt_total_msarif.Text)) - Convert.ToDouble(txt_total_mwrd.Text)
                    +Convert.ToDouble(txt_total_msdd.Text)+Convert.ToDouble(txt_total_nkdi.Text)).ToString();

            }
            catch (Exception)
            {
                

            }
            //string rowFilter = string.Format("[{0}] not like '{1}'", "نوع العملية", "خصم مسموح به");
            //(dgv_cstmrs.DataSource as DataTable).DefaultView.RowFilter = rowFilter;


            //مش فاكر انا كنت عاملها ليه
            //for (int i = 0; i < dgv_cstmrs.Rows.Count-1; i++)
            //{
            //    if (dgv_cstmrs.Rows[i].Cells[7].Value.ToString()=="خصم مسموح به")
            //    {
            //        dgv_cstmrs.Rows.RemoveAt(i);
            //    }
            //}
            //for (int i = 0; i < dgv_mwrden.Rows.Count - 1; i++)
            //{
            //    if (dgv_mwrden.Rows[i].Cells[6].Value.ToString() == "خصم مكتسب")
            //    {
            //        dgv_mwrden.Rows.RemoveAt(i);
            //    }
            //}

            dgv_cstmrs.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            combo_mndoob.Text = "";
            (dgv_cstmrs.DataSource as DataTable).DefaultView.RowFilter = null;
            (dgv_orders.DataSource as DataTable).DefaultView.RowFilter = null;
            (dgv_msarif.DataSource as DataTable).DefaultView.RowFilter = null;
            checkBox1.Checked = false;
            dgv_cstmrs.DataSource = cstmr.get_all_cstmrs_pays_bydate("");
            dgv_mwrden.DataSource = mwrd.get_all_mwrdeen_pays_bydate("");
            dgv_msarif.DataSource = expn.get_all_expenses();
            dgv_orders.DataSource = order.get_all_new_orders();
            calc_sum();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            combo_mndoob.Text = "";
            (dgv_cstmrs.DataSource as DataTable).DefaultView.RowFilter = null;
            (dgv_orders.DataSource as DataTable).DefaultView.RowFilter = null;
            (dgv_msarif.DataSource as DataTable).DefaultView.RowFilter = null;
            checkBox1.Checked = false;
            dgv_cstmrs.DataSource = cstmr.get_all_cstmrs_pays_bydate(DateTime.Now.Date.ToShortDateString());
            dgv_mwrden.DataSource = mwrd.get_all_mwrdeen_pays_bydate(DateTime.Now.Date.ToShortDateString());
            dgv_msarif.DataSource = expn.get_all_expenses_for_specific_date(DateTime.Now.Date);
            dgv_orders.DataSource = order.search_new_orders_bydate(DateTime.Now.Date.ToString("dd/MM/yyyy"));

            calc_sum();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            combo_mndoob.Text = "";
            (dgv_cstmrs.DataSource as DataTable).DefaultView.RowFilter = null;
            (dgv_orders.DataSource as DataTable).DefaultView.RowFilter = null;
            (dgv_msarif.DataSource as DataTable).DefaultView.RowFilter = null;
            checkBox1.Checked = false;
            dt_cstmr.Clear();
            dt_msarif.Clear();
            dt_mwrd.Clear();
            dt_new_orders.Clear();
            label_days.Text = ((dateTimePicker2.Value - dateTimePicker1.Value).TotalDays + 1).ToString() + " ايام ";
            foreach (var item in get_dates_between(dateTimePicker1.Value, dateTimePicker2.Value))
            {
                dt_msarif.Merge(expn.get_all_expenses_for_specific_date(item.Date));
                dt_cstmr.Merge(cstmr.get_all_cstmrs_pays_bydate(item.Date.ToString("dd/MM/yyyy")));
                dt_mwrd.Merge(mwrd.get_all_mwrdeen_pays_bydate(item.Date.ToString("dd/MM/yyyy")));
                dt_new_orders.Merge(order.search_new_orders_bydate(item.Date.ToString("dd/MM/yyyy")));


            }
            dgv_cstmrs.DataSource = dt_cstmr;
            dgv_msarif.DataSource = dt_msarif;
            dgv_mwrden.DataSource = dt_mwrd;
            dgv_orders.DataSource = dt_new_orders;
            calc_sum();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                txt_safi.Text = ((Convert.ToDouble(txt_safi.Text) + Convert.ToDouble(txt_total_mwrd.Text))).ToString();
                checkBox1.BackColor = Color.LightGreen;
            }
            else
            {
                txt_safi.Text = ((Convert.ToDouble(txt_total_ta7seel.Text) - Convert.ToDouble(txt_total_msarif.Text)) - Convert.ToDouble(txt_total_mwrd.Text)
                   + Convert.ToDouble(txt_total_msdd.Text) + Convert.ToDouble(txt_total_nkdi.Text)).ToString();
                checkBox1.BackColor = Color.PapayaWhip;
            }
        }

        private void combo_mndoob_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void combo_mndoob_SelectionChangeCommitted(object sender, EventArgs e)
        {

            
            
                
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(combo_mndoob.Text))
            {
                
                string rowFilter = string.Format("[{0}] like '{1}'", "اسم المندوب", combo_mndoob.Text);
                (dgv_cstmrs.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                (dgv_orders.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                string rowFilter2 = string.Format("[{0}] like '{1}'", "النوع", combo_mndoob.Text);
                (dgv_msarif.DataSource as DataTable).DefaultView.RowFilter = rowFilter2;
                dgv_mwrden.DataSource = "";
                calc_sum();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
