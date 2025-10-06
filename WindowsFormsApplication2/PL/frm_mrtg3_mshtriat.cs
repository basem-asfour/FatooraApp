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
    public partial class frm_mrtg3_mshtriat : Form
    {
        BL.cls_mwrdeen mwrd = new BL.cls_mwrdeen();
        BL.cls_products prd = new BL.cls_products();
        BL.cls_purchases purch = new BL.cls_purchases();
        public frm_mrtg3_mshtriat()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frm_mwrdeen_list frm = new frm_mwrdeen_list();
            frm.ShowDialog();
            this.label_mwrd_id.Text = frm.dgvcstmrs.CurrentRow.Cells[0].Value.ToString();
            this.label_mwrd_name.Text = frm.dgvcstmrs.CurrentRow.Cells[1].Value.ToString();
            this.dataGridView1_orders.DataSource = mwrd.get_all_fwateer_mwrd(frm.dgvcstmrs.CurrentRow.Cells[1].Value.ToString());

        }

        private void dataGridView1_orders_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2_products.DataSource = purch.get_all_fatora_mwrd_purchases(dataGridView1_orders.CurrentRow.Cells[0].Value.ToString());

            }
            catch (Exception)
            {
                
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value == true)
            {
                prd.deleteproduct(Convert.ToInt32(dataGridView2_products.CurrentRow.Cells[0].Value));
                mwrd.add_mrtg3_mshtriat(Convert.ToInt32(dataGridView2_products.CurrentRow.Cells[0].Value),
                    dataGridView2_products.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(dataGridView2_products.CurrentRow.Cells[2].Value)
                    , Convert.ToDouble(dataGridView2_products.CurrentRow.Cells[3].Value), Convert.ToInt32(dataGridView1_orders.CurrentRow.Cells[0].Value),
                    DateTime.Now.Date);
            }
            else
            {
                if (!string.IsNullOrEmpty(txt_quentity.Text))
                {
                    mwrd.add_mrtg3_mshtriat(Convert.ToInt32(dataGridView2_products.CurrentRow.Cells[0].Value),
                    dataGridView2_products.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(txt_quentity.Text)
                    , Convert.ToDouble(dataGridView2_products.CurrentRow.Cells[3].Value), Convert.ToInt32(dataGridView1_orders.CurrentRow.Cells[0].Value),
                    DateTime.Now.Date);
                    /////////////
                    prd.update_product_after_mrtg3_mshtriat(Convert.ToInt32(dataGridView2_products.CurrentRow.Cells[0].Value),
                        Convert.ToInt32(txt_quentity.Text));
                }
                
            }
            //dataGridView2_products.DataSource = order.get_order_details_for_edit(this.dataGridView1_orders.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("تم استرجاع الكمية بنجاح", "عملية الاسترجاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView2_products.DataSource = purch.get_all_fatora_mwrd_purchases(dataGridView1_orders.CurrentRow.Cells[0].Value.ToString());
            txt_quentity.Text = "";
            bunifuiOSSwitch1.Enabled = true;
        }

        private void btn_add_fatora_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد ارجاع كامل الفاتورة؟؟","عملية ارجاع",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                return;
            }
            for (int i = 0; i < dataGridView2_products.Rows.Count-1; i++)
            {
                prd.deleteproduct(Convert.ToInt32(dataGridView2_products.Rows[i].Cells[0].Value));
                mwrd.add_mrtg3_mshtriat(Convert.ToInt32(dataGridView2_products.Rows[i].Cells[0].Value),
                    dataGridView2_products.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(dataGridView2_products.Rows[i].Cells[2].Value)
                    , Convert.ToDouble(dataGridView2_products.Rows[i].Cells[3].Value), Convert.ToInt32(dataGridView1_orders.CurrentRow.Cells[0].Value),
                    DateTime.Now.Date);
            }
            mwrd.edit_fwateer_mwrd(Convert.ToInt32(dataGridView1_orders.CurrentRow.Cells[0].Value),label_mwrd_name.Text
                ,dataGridView1_orders.CurrentRow.Cells[3].Value.ToString()
                ,"0","0","0");
        }

        private void dataGridView2_products_Click(object sender, EventArgs e)
        {
            txt_quentity.Text = dataGridView2_products.CurrentRow.Cells[2].Value.ToString();
            txt_quentity.ReadOnly = true;
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value==true)
            {
                try
                {

                    txt_quentity.Text=dataGridView2_products.CurrentRow.Cells[2].Value.ToString();
                    txt_quentity.ReadOnly = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("من فضلك قم باختيار الصنف اولا", "التحكم في الكمية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }

            }
            else
            {
                txt_quentity.ReadOnly = false;
            }
        }

        private void dataGridView2_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
