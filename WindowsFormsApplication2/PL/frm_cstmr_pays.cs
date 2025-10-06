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
    public partial class frm_cstmr_pays : Form
    {
        BL.cls_cstmrs cstmr = new BL.cls_cstmrs();
        BL.cls_orders order = new BL.cls_orders();
        DataTable dt_cstmr = new DataTable();
        double new_mdfo3;
        DataTable dt_mndob;
        BL.cls_mndobeen mndb = new BL.cls_mndobeen();
        public frm_cstmr_pays()
        {
            InitializeComponent();
            //
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now; 
            dateTimePicker3.Value = DateTime.Now;
            dt_mndob = mndb.get_all_mndopeen();
            combo_mndoob.DataSource = dt_mndob;
            combo_mndoob.DisplayMember = "اسم المندوب";
            combo_mndoob.ValueMember = "id";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mdfo3.Text))
            {
                MessageBox.Show("من فضلك قم بتحديد المبلغ", "عمليه الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (radio_rd.Checked==false&&radioButton_5sm.Checked==false&&radioButton_تحصيل.Checked==false)
            {
           MessageBox.Show("برجاء اختيار نوع العملية", "عمليه الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
           return;
            }
            new_mdfo3 = Convert.ToDouble(txt_mdfo3.Text);
            if (radioButton_تحصيل.Checked==true)
            {
                if (new_mdfo3 == 0)
                {
                    cstmr.add_cstmr_pay(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                    Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, "","اضافة رصيد",txt_notes.Text);
                }
                else
                {
                    cstmr.add_cstmr_pay(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                    Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, combo_mndoob.Text,"تحصيل",txt_notes.Text);
                }
            }
            else if (radio_rd.Checked==true)
            {
                if (new_mdfo3 == 0)
                {
                    cstmr.add_cstmr_pay(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                    Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, "","اضافة رصيد",txt_notes.Text);
                }
                else if ((new_mdfo3 < 0))
                {
                    cstmr.add_cstmr_pay(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                    Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, combo_mndoob.Text,"رد للعميل",txt_notes.Text);
                }
                else
                {
                    new_mdfo3 = -1*new_mdfo3;
                    cstmr.add_cstmr_pay(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(new_mdfo3),
                   Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(new_mdfo3), dateTimePicker1.Text, combo_mndoob.Text, "رد للعميل",txt_notes.Text);
                }
            }
            else if (radioButton_5sm.Checked==true)
            {
                if (new_mdfo3 == 0)
                {
                    cstmr.add_cstmr_pay(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                    Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, "","اضافة رصيد",txt_notes.Text);
                }
                else
                {
                    cstmr.add_cstmr_pay(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                    Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, combo_mndoob.Text,"خصم مسموح به",txt_notes.Text);
                }
            }
            

           label_first_rseed.Text=(Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(new_mdfo3)).ToString();
           dataGridView1.DataSource = cstmr.get_all_cstmr_pays(Convert.ToInt32(label_id.Text));
           label_total_mdfo3.Text = (from DataGridViewRow row in dataGridView1.Rows
                                     where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[6].FormattedValue.ToString() != "خصم مسموح به"
                                     select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
           txt_mdfo3.Text = "";
           txt_notes.Text = "";
           //for (int i = 0; i < dataGridView2.Rows.Count-1 && new_mdfo3>0; i++)
           //{
           //    if (new_mdfo3 >= Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value) && Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value)>0)
           //    {
           //        order.update_msdd_mtpakii(dataGridView2.Rows[i].Cells[0].Value.ToString()
           //            , dataGridView2.Rows[i].Cells[4].Value.ToString(), "0");

           //        order.update_msdd_mtpakii_in_new_orders(dataGridView2.Rows[i].Cells[0].Value.ToString()
           //            , dataGridView2.Rows[i].Cells[4].Value.ToString(), "0");
           //        new_mdfo3 -= Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value);
           //    }
           //    else if (new_mdfo3 < Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value) && Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value) > 0)
           //    {
           //         order.update_msdd_mtpakii(dataGridView2.Rows[i].Cells[0].Value.ToString()
           //            ,(Convert.ToDouble( dataGridView2.Rows[i].Cells[2].Value)+new_mdfo3).ToString(),
           //            (Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value)- new_mdfo3).ToString());

           //        order.update_msdd_mtpakii_in_new_orders(dataGridView2.Rows[i].Cells[0].Value.ToString()
           //            , (Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value) + new_mdfo3).ToString(),
           //            (Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value) - new_mdfo3).ToString());
           //        new_mdfo3 = 0;
           //    }
            
           //}
           MessageBox.Show("تمت الاضافة بنجاح", "عمليه الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
           dataGridView2.DataSource = order.get_cstmr_orders(label_id.Text);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("هل تريد حذف هذا الدفع؟؟", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
            {
                label_first_rseed.Text = (Convert.ToDouble(label_first_rseed.Text) + Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value)).ToString();

                cstmr.delete_cstmr_pay(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                dataGridView1.DataSource = cstmr.get_all_cstmr_pays(Convert.ToInt32(label_id.Text));
                label_total_mdfo3.Text = (from DataGridViewRow row in dataGridView1.Rows
                                          where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[6].FormattedValue.ToString() != "خصم مسموح به"
                                          select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
                MessageBox.Show("تم الحذف بنجاح", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rowFilter = string.Format("[{0}] like '{1}'", "نوع العملية", "تحصيل");
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;

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
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;

            foreach (var item in get_dates_between(dateTimePicker3.Value, dateTimePicker2.Value))
            {

                dt_cstmr.Merge(cstmr.get_all_cstmrs_pays_bydate(item.Date.ToString("dd/MM/yyyy")));



            }
            dataGridView1.DataSource = dt_cstmr;

        }
    }
}
