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
    public partial class frm_catogry_report : Form
    {
        BL.cls_products prd = new BL.cls_products();
        DataTable dt_cat = new DataTable();
        DataTable dt_bee3 = new DataTable();
        DataTable dt_shraa = new DataTable();
        DataTable dt_mrtg3_bee3 = new DataTable();
        DataTable dt_mrtg3_shraa = new DataTable();


        public frm_catogry_report()
        {
            InitializeComponent();
            dt_cat = prd.get_all_catogries();
            combo_cat.DataSource = dt_cat;
            combo_cat.DisplayMember = "النوع";
            combo_cat.ValueMember = "id";
            dateTimePicker1.Value = DateTime.Now.Date;
            dateTimePicker2.Value = DateTime.Now.Date;
        }

        public void refresh_txt()
        {
            txt_bee3.Text = (from DataGridViewRow row in dgv_mbe3at.Rows
                                     where row.Cells[6].FormattedValue.ToString() !=string.Empty
                                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            txt_mrtg3_bee3.Text = (from DataGridViewRow row in dgv_mrtg3_mbe3at.Rows
                                   where row.Cells[2].FormattedValue.ToString() != string.Empty && row.Cells[3].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[3].FormattedValue) * Convert.ToInt32(row.Cells[2].FormattedValue)).Sum().ToString();
            txt_shraa.Text = (from DataGridViewRow row in dgv_mshtriat.Rows
                              where row.Cells[4].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_mrtg3_shraa.Text = (from DataGridViewRow row in dgv_mrtg3_mshtriat.Rows
                                        where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[4].FormattedValue.ToString() != string.Empty
                                        select Convert.ToDouble(row.Cells[4].FormattedValue) * Convert.ToInt32(row.Cells[3].FormattedValue)).Sum().ToString();
            ///////////////////////////////////////////////quantities
            txt_qte_bee3.Text = (from DataGridViewRow row in dgv_mbe3at.Rows
                             where row.Cells[3].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            txt_qte_mrtg3_bee3.Text = (from DataGridViewRow row in dgv_mrtg3_mbe3at.Rows
                                   where row.Cells[2].FormattedValue.ToString() != string.Empty 
                                   select  Convert.ToInt32(row.Cells[2].FormattedValue)).Sum().ToString();
            txt_qte_shraa.Text = (from DataGridViewRow row in dgv_mshtriat.Rows
                              where row.Cells[2].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
            txt_qte_mrtg3_shraa.Text = (from DataGridViewRow row in dgv_mrtg3_mshtriat.Rows
                                        where row.Cells[3].FormattedValue.ToString() != string.Empty 
                                        select Convert.ToInt32(row.Cells[3].FormattedValue)).Sum().ToString();
            ///////////////////////////////////////////////////final
            txt_safi.Text = (Convert.ToDouble(txt_shraa.Text) + Convert.ToDouble(txt_mrtg3_bee3.Text) -
                Convert.ToDouble(txt_bee3.Text) - Convert.ToDouble(txt_mrtg3_shraa.Text)).ToString();
            txt_qte_safi.Text = (Convert.ToDouble(txt_qte_shraa.Text) + Convert.ToDouble(txt_qte_mrtg3_bee3.Text) -
                Convert.ToDouble(txt_qte_bee3.Text) - Convert.ToDouble(txt_qte_mrtg3_shraa.Text)).ToString();
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
        private void button11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(combo_cat.Text))
            {
                dgv_mbe3at.DataSource = prd.get_order_details_for_catogry_report(combo_cat.Text);
                dgv_mrtg3_mbe3at.DataSource = prd.get_mrtg3_mbe3at_for_catogry_report(combo_cat.Text);
                dgv_mrtg3_mshtriat.DataSource = prd.get_mrtg3_mshtriat_for_catogry_report(combo_cat.Text);
                dgv_mshtriat.DataSource = prd.get_purchases_for_catogry_report(combo_cat.Text);
                refresh_txt();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dt_mrtg3_shraa.Clear();
            dt_shraa.Clear();
            dt_bee3.Clear();
            dt_mrtg3_bee3.Clear();
            foreach (var item in get_dates_between(dateTimePicker1.Value, dateTimePicker2.Value))
            {
                //(dgv_mbe3at.DataSource as DataTable).DefaultView.RowFilter = null;
                //(dgv_mshtriat.DataSource as DataTable).DefaultView.RowFilter = null;
                //(dgv_mrtg3_mshtriat.DataSource as DataTable).DefaultView.RowFilter = null;
                //(dgv_mbe3at.DataSource as DataTable).DefaultView.RowFilter = null;

                //string rowFilter = string.Format("[{0}] Like '%''{1}''%'", "تاريخ الفاتورة", item.Date.ToString("dd/MM/yyyy"));
                //(dgv_mbe3at.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                //string rowFilter2 = string.Format("[{0}] Like '%''{1}''%'", "التاريخ", item.Date.ToString("dd/MM/yyyy"));
                //(dgv_mshtriat.DataSource as DataTable).DefaultView.RowFilter = rowFilter2;
                //(dgv_mrtg3_mshtriat.DataSource as DataTable).DefaultView.RowFilter = rowFilter2;
                //string rowFilter3 = string.Format("[{0}] Like '%''{1}''%'", "تاريخ الإسترجاع", item.Date.ToString("dd/MM/yyyy"));
                //(dgv_mrtg3_mbe3at.DataSource as DataTable).DefaultView.RowFilter = rowFilter3;

                dt_bee3.Merge(prd.get_order_details_for_catogry_report_date_filter(combo_cat.Text,item.Date));
                dt_mrtg3_bee3.Merge(prd.get_mrtg3_mbe3at_for_catogry_report_date_filter(combo_cat.Text, item.Date));
                dt_shraa.Merge(prd.get_purchases_for_catogry_report_date_filter(combo_cat.Text, item.Date.ToString("dd/MM/yyyy")));
                dt_mrtg3_shraa.Merge(prd.get_mrtg3_mshtriat_for_catogry_report_date_filter(combo_cat.Text, item.Date));
            }
            dgv_mbe3at.DataSource = dt_bee3;
            dgv_mshtriat.DataSource = dt_shraa;
            dgv_mrtg3_mbe3at.DataSource = dt_mrtg3_bee3;
            dgv_mrtg3_mshtriat.DataSource = dt_mrtg3_shraa;
            refresh_txt();

        }

        private void frm_catogry_report_Load(object sender, EventArgs e)
        {

        }
    }
}
