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
    public partial class frm_orders_list : Form
    {
        BL.cls_cstmrs cstmr = new BL.cls_cstmrs();
        BL.cls_orders order = new BL.cls_orders();
        public string id_order;
        public frm_orders_list()
        {
            InitializeComponent();
            this.dgvorders.DataSource = order.search_order("");

        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_orders_list_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgvorders.DataSource = order.search_order(textBox1.Text);

            }
            catch
            {

                return;
            }
        }

        private void btntba3a_Click(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.WaitCursor;
            //int order_id = Convert.ToInt32(dgvorders.CurrentRow.Cells[0].Value);
            //RPT.rpt_orders report = new RPT.rpt_orders();
            //RPT.frm_rpt_product frm = new RPT.frm_rpt_product();
            //report.SetDataSource(order.getorderdetails(order_id));
            //frm.crystalReportViewer1.ReportSource = report;
            //frm.ShowDialog();
            //this.Cursor = Cursors.Default;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الفاتورة؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                order.avoid_order(this.dgvorders.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم حذف الفاتورة بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvorders.DataSource = order.search_order("");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            id_order = this.dgvorders.CurrentRow.Cells[0].Value.ToString();
            Frm_orders frm = new Frm_orders();
            frm.type = "edit";
            frm.txtorderid.Text = this.dgvorders.CurrentRow.Cells[0].Value.ToString();
            // frm.dateTimePicker1.Value = this.dgvorders.CurrentRow.Cells[2].Value مافيش تعديل في التاريخ مش عارف اعمله
            frm.txtsaleman.Text = this.dgvorders.CurrentRow.Cells[3].Value.ToString();
            frm.txtcstnme.Text = this.dgvorders.CurrentRow.Cells[1].Value.ToString();
          //  order.bianat_ameel_mnelesm(this.dgvorders.CurrentRow.Cells[1].Value.ToString()); مافيض اعديل في العميل
            frm.dgvproducts.DataSource = order.get_order_details_for_edit(this.dgvorders.CurrentRow.Cells[0].Value.ToString());
            frm.btnnew.Enabled = false;
            frm.btnprnt.Enabled = false;
            frm.btnsve.Enabled = true;
            frm.btnsve.Text = "تعديل ";
           frm.txtmg.Text = (from DataGridViewRow row in frm.dgvproducts.Rows
                          where row.Cells[6].FormattedValue.ToString() != string.Empty
                          select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

            frm.ShowDialog();

        }*/
        }

        private void dgvorders_DoubleClick(object sender, EventArgs e)
        {
            //this.dgvorders.DataSource = order.search_order("");

            frm_view_order frm = new frm_view_order();
            string id_order = this.dgvorders.CurrentRow.Cells[0].Value.ToString();
            frm.dataGridView8_cstmr_id.DataSource = order.get_cstmr_id(this.dgvorders.CurrentRow.Cells[1].Value.ToString());
            frm.txtordr_id.Text = id_order;
            frm.txtdate.Text = this.dgvorders.CurrentRow.Cells[2].Value.ToString();
            frm.txtcstmr_name.Text = this.dgvorders.CurrentRow.Cells[1].Value.ToString();
            frm.txtbaya.Text = this.dgvorders.CurrentRow.Cells[3].Value.ToString();
            frm.dataGridView2.DataSource = order.get_price_msdd(id_order);
            frm.dataGridView3.DataSource = order.get_price_mtbkii(id_order);
            frm.dataGridView7.DataSource = order.get_7sab_sabk(this.dgvorders.CurrentRow.Cells[1].Value.ToString());

            frm.dataGridView4.DataSource = cstmr.get_cstmr_adress(this.dgvorders.CurrentRow.Cells[1].Value.ToString());
            frm.dataGridView1.DataSource = order.get_order_details_for_edit(this.dgvorders.CurrentRow.Cells[0].Value.ToString());
            frm.dataGridView5.DataSource = order.get_price_shraa_for_mksb(this.dgvorders.CurrentRow.Cells[0].Value.ToString());

            frm.txt_notes.Text=order.get_single_new_orders(Convert.ToInt32(id_order)).Rows[0][9].ToString();
            if (order.get_single_new_order_mndb(Convert.ToInt32(id_order)).Rows.Count!=0)
            {
                try
                {
                    frm.txt_mndbName.Text = order.get_single_new_order_mndb(Convert.ToInt32(id_order)).Rows[0][1].ToString();
            frm.txt_mndb_rseed.Text = order.get_single_new_order_mndb(Convert.ToInt32(id_order)).Rows[0][2].ToString();
            frm.txt_mndb_id.Text = order.get_single_new_order_mndb(Convert.ToInt32(id_order)).Rows[0][0].ToString();

                }
                catch (Exception)
                {
                    
                }
            }

            
            //مجموع الاجمالي
            double sum = 0;
            for (int i = 0; i < frm.dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(frm.dataGridView1.Rows[i].Cells[6].Value);
            }
            frm.txttotal.Text = sum.ToString();
            frm.txt_transport.Text = order.get_single_new_orders(Convert.ToInt32(id_order)).Rows[0][8].ToString();
            frm.txt_total_after_transport.Text = order.get_single_new_orders(Convert.ToInt32(id_order)).Rows[0][5].ToString();
            if (string.IsNullOrEmpty(order.get_single_new_orders(Convert.ToInt32(id_order)).Rows[0][8].ToString()))
            {
                frm.txt_transport.Text = "0";
            }
            frm.ShowDialog();
            this.dgvorders.DataSource = order.search_order("");

        }

        private void dgvorders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                order.re_calc_total_price_for_order(Convert.ToInt32(dgvorders.CurrentRow.Cells[0].Value));
                MessageBox.Show("fixed successfully :D", "Congrat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Cant be fixed :(","sorry",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private  void button4_Click_1(object sender, EventArgs e)
        {
            frm_view_order frm = new frm_view_order();
            var id_order = order.get_last_order_forprint().Rows[0][0].ToString();
            dgvorders.ReadOnly = false;

            dgvorders.CurrentRow.Selected = false;
            dgvorders.CurrentRow.Selected = false;
           dgvorders.Rows[dgvorders.Rows.Count-2].Selected = true;
           DataGridViewRow ro = dgvorders.Rows[dgvorders.Rows.Count - 2] ;
            
            dgvorders.ReadOnly = true;

            //string id_order = this.dgvorders.CurrentRow.Cells[0].Value.ToString();
            frm.dataGridView8_cstmr_id.DataSource = order.get_cstmr_id(ro.Cells[1].Value.ToString());
            frm.txtordr_id.Text = id_order;
            frm.txtdate.Text = ro.Cells[2].Value.ToString();
            frm.txtcstmr_name.Text = ro.Cells[1].Value.ToString();
            frm.txtbaya.Text =ro.Cells[3].Value.ToString();
            frm.dataGridView2.DataSource = order.get_price_msdd(id_order);
            frm.dataGridView3.DataSource = order.get_price_mtbkii(id_order);
            frm.dataGridView7.DataSource = order.get_7sab_sabk(ro.Cells[1].Value.ToString());

            frm.dataGridView4.DataSource = cstmr.get_cstmr_adress(ro.Cells[1].Value.ToString());
            frm.dataGridView1.DataSource = order.get_order_details_for_edit(id_order);
            frm.dataGridView5.DataSource = order.get_price_shraa_for_mksb(id_order);

            if (order.get_single_new_order_mndb(Convert.ToInt32(id_order)).Rows.Count != 0)
            {
                try
                {
                    frm.txt_mndbName.Text = order.get_single_new_order_mndb(Convert.ToInt32(id_order)).Rows[0][1].ToString();
                    frm.txt_mndb_rseed.Text = order.get_single_new_order_mndb(Convert.ToInt32(id_order)).Rows[0][2].ToString();
                    frm.txt_mndb_id.Text = order.get_single_new_order_mndb(Convert.ToInt32(id_order)).Rows[0][0].ToString();

                }
                catch (Exception)
                {

                }
            }


            //مجموع الاجمالي
            double sum = 0;
            for (int i = 0; i < frm.dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(frm.dataGridView1.Rows[i].Cells[6].Value);
            }
            frm.txttotal.Text = sum.ToString();
            frm.txt_transport.Text = order.get_single_new_orders(Convert.ToInt32(id_order)).Rows[0][8].ToString();
            frm.txt_total_after_transport.Text = order.get_single_new_orders(Convert.ToInt32(id_order)).Rows[0][5].ToString();
            if (string.IsNullOrEmpty(order.get_single_new_orders(Convert.ToInt32(id_order)).Rows[0][8].ToString()))
            {
                frm.txt_transport.Text = "0";
            }
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


