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
    public partial class frm_mrtg3 : Form
    {
        BL.cls_orders order = new BL.cls_orders();
        BL.cls_cstmrs cstmr = new BL.cls_cstmrs();
        BL.cls_products product = new BL.cls_products();
        DataTable dt = new DataTable();
        bool preExist;
        double total_price;
        public frm_mrtg3()
        {
            InitializeComponent();
            createdatatable();
            preExist = false;
            total_price = 0.0;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            labelprd_name.Visible = false;
            btn_add_fatora.Visible = false;
            btn_open.Visible = false;
            bunifuFlatButton3.Visible = false;
            bunifuFlatButton4.Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frm_cstmrs_list frm = new frm_cstmrs_list();
            frm.ShowDialog();

            this.label_cstmr_name.Text = frm.dgvcstmrs.CurrentRow.Cells[1].Value.ToString();
            dataGridView1_orders.DataSource= order.get_cstmr_orders(frm.dgvcstmrs.CurrentRow.Cells[0].Value.ToString());
            this.dataGridView1_orders.Sort(dataGridView1_orders.Columns["id_order"], ListSortDirection.Descending);
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            dataGridView1_orders.Visible = true;
            dataGridView2_products.Visible = true;
            groupBox3.Visible = true;
            labelprd_name.Visible = false;
            label_cstmr_id.Text = frm.dgvcstmrs.CurrentRow.Cells[0].Value.ToString();
            bunifuFlatButton3.Enabled = true;
            bunifuFlatButton4.Enabled = true;
            radioButton1.Checked = true;
        }

        //private void dataGridView1_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    dataGridView2_products.DataSource = order.get_order_details_for_edit(this.dataGridView1_orders.CurrentRow.Cells[0].ToString());
        //}

        private void dataGridView2_products_DoubleClick(object sender, EventArgs e)
        {
            frm_product_mrtg3 frm = new frm_product_mrtg3();

        }

        private void dataGridView1_orders_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2_products.DataSource = order.get_order_details_for_edit(this.dataGridView1_orders.CurrentRow.Cells[0].Value.ToString());

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value==true)
            {
                txt_quentity.Text = dataGridView2_products.CurrentRow.Cells[2].Value.ToString();
                txt_quentity.Enabled = false;
            }
            else
            {
                txt_quentity.Text = "";
                txt_quentity.Enabled = true;
            }
        }

        private void dataGridView2_products_Click(object sender, EventArgs e)
        {
            txt_quentity.Text = dataGridView2_products.CurrentRow.Cells[2].Value.ToString();
            groupBox3.Text = "استرجاع صنف : " + dataGridView2_products.CurrentRow.Cells[1].Value.ToString();
            txt_quentity.Enabled = false;
            bunifuiOSSwitch1.Value = true;
            txt_pprice.Text = dataGridView2_products.CurrentRow.Cells[3].Value.ToString();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            frm_products_list frm = new frm_products_list();
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            labelprd_name.Visible = true;
            //btn_open.Enabled = true;

            frm.ShowDialog();
            this.label_id.Text = frm.dgvprdcts.CurrentRow.Cells[0].Value.ToString();
            this.label_name.Text = frm.dgvprdcts.CurrentRow.Cells[1].Value.ToString();
            preExist = false;
            dataGridView2_products.DataSource = dt;


        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            //labelprd_name.Visible = true;
            //btn_open.Enabled = true;

            frm_add_product frm = new frm_add_product("");
            frm.state = "cstmr_mrtg3";
            frm.ShowDialog();
            this.txt_pri.Text = frm.txtpshr.Text;
            this.txt_qnt.Text = frm.txtqte.Text;
            this.label_name.Text = frm.txtnme.Text;
            preExist = true;
            labelprd_name.Visible = false;
            dataGridView2_products.DataSource = dt;
            cstmr.after_add_notExist_prd_to_cstmr_fatora(Convert.ToDouble(frm.txtpshr.Text), Convert.ToInt32(frm.txtqte.Text),
                Convert.ToInt32(label_cstmr_id.Text), dateTimePicker1.Value.Date);

        }
        void createdatatable()
        {
            dt.Columns.Add("كود الصنف");
            dt.Columns.Add("اسم الصنف");
            dt.Columns.Add("السعر");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("السعر الكلي");

            dataGridView2_products.DataSource = dt;

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_pri.Text)||string.IsNullOrEmpty(txt_qnt.Text))
            {
                MessageBox.Show("تأكد من ادخال السعر والكمية", "معلومات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DataRow r = dt.NewRow();
            if (preExist)
            {
                r[0] = product.get_last_prd_id().Rows[0][0];
            }
            else
            {
                r[0] = label_id.Text;
            }
            
            r[1] = label_name.Text;
            r[2] = txt_qnt.Text;
            r[3] = txt_pri.Text;
            r[4] = Convert.ToInt32(txt_qnt.Text) * Convert.ToDouble(txt_pri.Text);
            dt.Rows.Add(r);

            dataGridView2_products.DataSource = dt;
            txt_qnt.Text = "";
            txt_pri.Text = "";
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            cstmr.add_cstmr_fatora(Convert.ToInt32(label_cstmr_id.Text),dateTimePicker1.Value.Date);
            btn_add_fatora.Enabled = true;
            btn_open.Enabled = false;
        }

        private void btn_add_fatora_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2_products.Rows.Count -1; i++)
            {
                cstmr.add_preExist_prd_to_cstmr_fatora(Convert.ToInt32(dataGridView2_products.Rows[i].Cells[0].Value),
                    Convert.ToDouble(dataGridView2_products.Rows[i].Cells[3].Value),
                    Convert.ToInt32(dataGridView2_products.Rows[i].Cells[2].Value),Convert.ToInt32(label_cstmr_id.Text),
                    dateTimePicker1.Value.Date);
               // total_price+=Convert.ToDouble(dataGridView2_products.Rows[i].Cells[2].Value)*Convert.ToDouble(dataGridView2_products.Rows[i].Cells[3].Value)
            }
            MessageBox.Show("تم اضافة الفاتورة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            groupBox1.Visible = true;
            labelprd_name.Visible = false;
            btn_add_fatora.Enabled = true;
            //btn_open.Enabled = true;
            dataGridView1_orders.DataSource = order.get_cstmr_orders(label_cstmr_id.Text);
            
            this.dataGridView1_orders.Sort(dataGridView1_orders.Columns["id_order"], ListSortDirection.Descending);
            dt.Clear();
            dataGridView2_products.Update();


        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_pprice.Text)||string.IsNullOrEmpty(txt_quentity.Text))
            {
             MessageBox.Show("تأكد من ادخال السعر والكمية", "معلومات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;   
            }
            //if (bunifuiOSSwitch1.Value==true)
            //{
               
                // cstmr.avoid_prduct_from_specific_order(Convert.ToInt32(label_cstmr_id.Text), Convert.ToInt32(dataGridView1_orders.CurrentRow.Cells[0].Value), Convert.ToInt32(dataGridView2_products.CurrentRow.Cells[0].Value), Convert.ToInt32(txt_quentity.Text));
                cstmr.add_preExist_prd_to_cstmr_fatora(Convert.ToInt32(dataGridView2_products.CurrentRow.Cells[0].Value),
                   Convert.ToDouble(txt_pprice.Text),Convert.ToInt32(txt_quentity.Text), Convert.ToInt32(label_cstmr_id.Text),
                   dateTimePicker1.Value.Date);
            //}
            //else
            //{
            //    cstmr.avoid_prduct_from_specific_order_notall_qnt(Convert.ToInt32(label_cstmr_id.Text), Convert.ToInt32(dataGridView1_orders.CurrentRow.Cells[0].Value), Convert.ToInt32(dataGridView2_products.CurrentRow.Cells[0].Value), Convert.ToInt32(txt_quentity.Text));
            //}
            dataGridView2_products.DataSource = order.get_order_details_for_edit(this.dataGridView1_orders.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("تم استرجاع الكمية بنجاح", "عملية الاسترجاع", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txt_quentity_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                labelprd_name.Visible = false;
                btn_add_fatora.Visible = false;
                btn_open.Visible = false;
                bunifuFlatButton3.Visible = false;
                bunifuFlatButton4.Visible = false;

            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            labelprd_name.Visible = true;
            btn_add_fatora.Visible = true;
            //btn_open.Visible = true;
            bunifuFlatButton3.Visible = true;
            bunifuFlatButton4.Visible = false;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            labelprd_name.Visible = false;
            btn_add_fatora.Visible = false;
            btn_open.Visible = false;
            bunifuFlatButton3.Visible = false;
            bunifuFlatButton4.Visible = true;
        }

        private void dataGridView2_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
