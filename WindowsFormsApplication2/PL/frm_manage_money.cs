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
    public partial class frm_manage_money : Form
    {
        BL.cls_orders order = new BL.cls_orders();
        BL.cls_mwrdeen mwrd = new BL.cls_mwrdeen();
        BL.cls_cstmrs cstmr = new BL.cls_cstmrs();
        BL.cls_products prd = new BL.cls_products();
        DataTable dt_md5lat =new DataTable();
        DataTable dt_mwrd = new DataTable();
        DataTable dt_cstmr = new DataTable();
        DataTable dt_new_orders=new DataTable();
        DataTable dt_fwateer = new DataTable();
        DataTable dt_mrt_cstmr = new DataTable();
        DataTable dt_mrt_mwrd = new DataTable();

        void createdatatable_md5lat()
        {
            dt_md5lat.Columns.Add("id");
            dt_md5lat.Columns.Add("القيمة");
            dt_md5lat.Columns.Add("التاريخ");
            dt_md5lat.Columns.Add("الوصف");

            dataGridView1.DataSource = dt_md5lat;

        }
        //void createdatatable_new_orders()
        //{
        //    dt_new_orders.Columns.Add("رقم الفاتورة");
        //    dt_new_orders.Columns.Add("تاريخ الفاتورة");
        //    dt_new_orders.Columns.Add("اسم العميل");
        //    dt_new_orders.Columns.Add("المبلغ المسدد");
        //    dt_new_orders.Columns.Add("المبلغ المتبقي");
        //    dt_new_orders.Columns.Add("اجمالي الفاتورة");
        //    dt_new_orders.Columns.Add("صافي الربح");
        //    dt_new_orders.Columns.Add("اسم المندوب");


        //    dgv_orders.DataSource = dt_new_orders; ;

        //}
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
            for (DateTime date = startDate; date <= endDate ; date=date.AddDays(1))
            {
                allDates.Add(date);   
            }
            return allDates;
        }
        public frm_manage_money()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now.Date;
            dateTimePicker2.Value = DateTime.Now.Date;

            dataGridView1.DataSource = order.get_all_md5lat();
            dgv_orders.DataSource = order.get_all_new_orders();
            dgv_fwateer.DataSource = mwrd.search_fwateer_mwrd_bydate("");
            dgv_mwrd.DataSource = mwrd.get_all_mwrdeen_pays_bydate("");
            dgv_cstmrs.DataSource = cstmr.get_all_cstmrs_pays_bydate("");
            dgv_mrtg3_mbe3at.DataSource = cstmr.get_all_fwareer_mrtg3();
            dgv_mrtg3_mshtriat.DataSource = prd.get_all_mrtg3_mshtriat_for_card("");
            //textBox1.Text = (from DataGridViewRow row in dataGridView1.Rows
            //                 where row.Cells[1].FormattedValue.ToString() != string.Empty
            //                 select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum().ToString();
            //txt_orders.Text = (from DataGridViewRow row in dgv_orders.Rows
            //                 where row.Cells[5].FormattedValue.ToString() != string.Empty
            //                 select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
            //txt_nkdi.Text = (from DataGridViewRow row in dgv_orders.Rows
            //                 where row.Cells[6].FormattedValue.ToString() != string.Empty
            //                 select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            calc_sum();

        }
        public void calc_sum()
        {
            txt_cstmr_firstr.Text = (from DataGridViewRow row in dgv_cstmrs.Rows
                                     where row.Cells[3].FormattedValue.ToString() == "0"
                                     select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_nkdi.Text = (from DataGridViewRow row in dgv_orders.Rows
                                   where row.Cells[5].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() == "بيع نقدي"
                                   select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
            txt_orders_msdd.Text = (from DataGridViewRow row in dgv_orders.Rows
                                           where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() != "بيع نقدي"
                                           select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            txt_cstmr_t7seel.Text = (from DataGridViewRow row in dgv_cstmrs.Rows
                                      where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[7].FormattedValue.ToString() != "خصم مسموح به"
                                      select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
           /*/*/ double khsm_msmo7 = (from DataGridViewRow row in dgv_cstmrs.Rows
                                 where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[7].FormattedValue.ToString() == "خصم مسموح به"
                                 select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum();
            txt_orders.Text = (from DataGridViewRow row in dgv_orders.Rows
                               where row.Cells[5].FormattedValue.ToString() !=string.Empty
                               select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
            double old_mrtg3_total = (from DataGridViewRow row in dgv_mrtg3_mbe3at.Rows
                                      where row.Cells[1].FormattedValue.ToString() != string.Empty && row.Cells[5].FormattedValue.ToString() == string.Empty
                                      select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum();
            double new_mrtg3_total = (from DataGridViewRow row in dgv_mrtg3_mbe3at.Rows
                                      where row.Cells[5].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum();
            txt_cstmrs_mrtg3.Text = (new_mrtg3_total + old_mrtg3_total).ToString();

            txt_cstmr_final.Text = ((Convert.ToDouble(txt_cstmr_firstr.Text) - Convert.ToDouble(txt_orders_msdd.Text)) +
                (Convert.ToDouble(txt_orders.Text) - Convert.ToDouble(txt_cstmr_t7seel.Text)) - Convert.ToDouble(txt_cstmrs_mrtg3.Text)-khsm_msmo7).ToString();

            txt_allowd_disck.Text = khsm_msmo7.ToString();
            ///////////////////////////////////////////////////////////////////////////////////////////
            txt_fateer_mwrd.Text = (from DataGridViewRow row in dgv_fwateer.Rows
                                    where row.Cells[3].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            txt_mwrd_firstr.Text = (from DataGridViewRow row in dgv_mwrd.Rows
                                    where row.Cells[3].FormattedValue.ToString() == "0"
                                    select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_fwateer_msdd.Text = (from DataGridViewRow row in dgv_fwateer.Rows
                                     where row.Cells[4].FormattedValue.ToString() !=string.Empty
                                     select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_mwrd_t7seel.Text = (from DataGridViewRow row in dgv_mwrd.Rows
                                    where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[6].FormattedValue.ToString() != "خصم مكتسب"
                                    select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            txt_mwrd_mrtg3.Text =  (from DataGridViewRow row in dgv_mrtg3_mshtriat.Rows
                                   where row.Cells[2].FormattedValue.ToString() != string.Empty && row.Cells[3].FormattedValue.ToString() != string.Empty
                                   select Convert.ToInt32(row.Cells[2].FormattedValue) * Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            /***/
            double khsm_mktsb = (from DataGridViewRow row in dgv_mwrd.Rows
                                 where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[6].FormattedValue.ToString() == "خصم مكتسب"
                                 select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum();

            txt_mwrd_final.Text = ((Convert.ToDouble(txt_mwrd_firstr.Text) - Convert.ToDouble(txt_fwateer_msdd.Text)) +
                (Convert.ToDouble(txt_fateer_mwrd.Text) - Convert.ToDouble(txt_mwrd_t7seel.Text)) - Convert.ToDouble(txt_mwrd_mrtg3.Text) - khsm_mktsb).ToString();

            txt_gaind_dicsk.Text = khsm_mktsb.ToString();
        
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_add_md5al frm = new frm_add_md5al();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string x,y,z;
            //createdatatable_md5lat();
            //createdatatable_new_orders();
             dt_md5lat.Clear();
             dt_new_orders.Clear();
             dt_cstmr.Clear();
             dt_fwateer.Clear();
             dt_mrt_cstmr.Clear();
             dt_mrt_mwrd.Clear();
             dt_mwrd.Clear();
            
            label_days.Text = ((dateTimePicker2.Value - dateTimePicker1.Value).TotalDays+1).ToString() + " ايام ";
            foreach (var item in get_dates_between(dateTimePicker1.Value, dateTimePicker2.Value))
            {
                dt_md5lat.Merge(order.search_md5lat_bydate(item.Date.ToString("dd/MM/yyyy")));
                dt_new_orders.Merge(order.search_new_orders_bydate(item.Date.ToString("dd/MM/yyyy")));
                //
                dt_cstmr.Merge(cstmr.get_all_cstmrs_pays_bydate(item.Date.ToString("dd/MM/yyyy")));
                dt_mwrd.Merge(mwrd.get_all_mwrdeen_pays_bydate(item.Date.ToString("dd/MM/yyyy")));
                //
                dt_fwateer.Merge(mwrd.search_fwateer_mwrd_bydate(item.Date.ToString("dd/MM/yyyy")));
                dt_mrt_mwrd.Merge(mwrd.search_mrtg3_mshtriat_bydate(item.Date));
                dt_mrt_cstmr.Merge(cstmr.search_cstmrs_mrtg3_bydate(item.Date));

            } 
            //dataGridView1.DataSource = order.search_md5lat_bydate(dateTimePicker1.Text);
            //dataGridView2.DataSource = order.search_new_orders_bydate(dateTimePicker1.Text);
            //dataGridView1.DataSource = dt_md5lat;
            dgv_orders.DataSource = dt_new_orders;
            dgv_cstmrs.DataSource = dt_cstmr;
            dgv_fwateer.DataSource = dt_fwateer;
            dgv_mrtg3_mbe3at.DataSource = dt_mrt_cstmr;
            dgv_mrtg3_mshtriat.DataSource = dt_mrt_mwrd;
            dgv_mwrd.DataSource = dt_mwrd;
            calc_sum();

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد انك تريد حذف المدخل المحدد؟؟","عملية الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                order.delete_md5al(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم الحذف بنجاح","عملية الحذف",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataGridView1.DataSource = order.get_all_md5lat();
            }
            else
            {
                return;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_add_md5al frm = new frm_add_md5al();
            frm.label4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.state = "edit";
            frm.txtdskrbshn.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.txtvalue.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.button1.Text = "تعديل";
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = order.get_all_md5lat();
            dgv_orders.DataSource = order.get_all_new_orders();
            dgv_fwateer.DataSource = mwrd.search_fwateer_mwrd_bydate("");
            dgv_mwrd.DataSource = mwrd.get_all_mwrdeen_pays_bydate("");
            dgv_cstmrs.DataSource = cstmr.get_all_cstmrs_pays_bydate("");
            dgv_mrtg3_mbe3at.DataSource = cstmr.get_all_fwareer_mrtg3();
            dgv_mrtg3_mshtriat.DataSource = prd.get_all_mrtg3_mshtriat_for_card("");
            calc_sum();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المحدد؟؟","عملية الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                order.delete_m5rgat(dgv_orders.CurrentRow.Cells[0].Value.ToString());
                dgv_orders.DataSource = order.get_all_new_orders();
                calc_sum();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
