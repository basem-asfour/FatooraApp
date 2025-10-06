using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.PL
{
    public partial class frm_add_fwateer_mwrd : Form
    {
        private static frm_add_fwateer_mwrd frm;
        static void frm_formclesed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static frm_add_fwateer_mwrd getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new frm_add_fwateer_mwrd();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclesed);
                }
                return frm;
            }
        }


        BL.cls_orders order = new BL.cls_orders();
        BL.cls_mwrdeen mwrd = new BL.cls_mwrdeen();
        BL.cls_products prd = new BL.cls_products();
        BL.cls_purchases purch = new BL.cls_purchases();
        public frm_add_fwateer_mwrd()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            id_mwrd_order.Text = mwrd.get_last_order_id_mwrd().Rows[0][0].ToString();
            dataGridView1.DataSource = purch.get_all_fatora_mwrd_purchases(mwrd.get_last_order_id_mwrd().Rows[0][0].ToString());

            //dataGridView1.DataSource = mwrd.get_all_fatora_mwrd_product(mwrd.get_last_order_id_mwrd().Rows[0][0].ToString());
        }

        //private void dgvproducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        //{

        //   txt_value.Text = (from DataGridViewRow row in dataGridView1.Rows
        //                     where row.Cells[2].FormattedValue.ToString() != string.Empty && row.Cells[3].FormattedValue.ToString() != string.Empty
        //                     select Convert.ToDouble(row.Cells[2].FormattedValue) * Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
        //}

        //private void dgvproducts_Rowsadd(object sender, DataGridViewRowsAddedEventArgs e)
        //{

        //    txt_value.Text = (from DataGridViewRow row in dataGridView1.Rows
        //                      where row.Cells[2].FormattedValue.ToString() != string.Empty && row.Cells[3].FormattedValue.ToString() != string.Empty
        //                      select Convert.ToDouble(row.Cells[2].FormattedValue) *Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
        //}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mwrd_nme = this.txtmwrd_nme.Text;
            frm_add_product frm = new frm_add_product("");
            frm.state = "add_product_with_mwrd";
            frm.mwrdnme = this.txtmwrd_nme.Text;
            frm.order_id_mwrd = this.id_mwrd_order.Text;
            frm.ShowDialog();
            refresh_frm();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_value.Text == string.Empty || txtmsdd.Text == string.Empty)
            {
                MessageBox.Show("من فضلك حدد القيمة المسددة والمتبقية","missing data!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {

            order.add_md5al(txt_value.Text,dateTimePicker1.Text,"فاتورة من المورد : "+txtmwrd_nme.Text);
            mwrd.add_fwateer_mwrd(Convert.ToInt32( id_mwrd_order.Text),txtmwrd_nme.Text,dateTimePicker1.Text,txt_value.Text,txtmsdd.Text,txtmtbki.Text);
            MessageBox.Show("تمت الاضافة بنجاح","عملية الاضافة",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_value.Text!=string.Empty&&txtmsdd.Text!=string.Empty)
            {
                txtmtbki.Text = (Convert.ToDouble(txt_value.Text )-Convert.ToDouble( txtmsdd.Text)).ToString();
            }
        }
        public string id;
        private void button5_Click(object sender, EventArgs e)
        {
            id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm_add_product frm = new frm_add_product(id);
            frm.state = "edit_product_with_mwrd";
            frm.txtnme.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtqte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtpshr.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.txtpg.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.txtpb.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.txtmsthlk.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.txttmd.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.Text = "تحديث بيانات الصنف:" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnok.Text = "تحديث";
            frm.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();

            byte[] image = (byte[])prd.get_image_product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pbox.Image = Image.FromStream(ms);

            frm.state = "update";
            frm.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
                            if (MessageBox.Show("هل تريد حذف الصنف", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                        Int32 selectedRowCount =
                       dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    purch.delete_purchase(Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0].Value));
                }
                        //prd.deleteproduct(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                    }
                    MessageBox.Show("تمت عمليه الحذف بنجاح", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   // dataGridView1.DataSource = mwrd.get_all_fatora_mwrd_product(mwrd.get_last_order_id_mwrd().Rows[0][0].ToString());
                    dataGridView1.DataSource = purch.get_all_fatora_mwrd_purchases(mwrd.get_last_order_id_mwrd().Rows[0][0].ToString());
    

                }
                else
                {
                    MessageBox.Show("تم الغاء عمليه الحذف ", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void button21_Click(object sender, EventArgs e)
        {
            refresh_frm();
        }
        public void refresh_frm()
        {
            dataGridView1.DataSource = purch.get_all_fatora_mwrd_purchases(mwrd.get_last_order_id_mwrd().Rows[0][0].ToString());

            // dataGridView1.DataSource = mwrd.get_all_fatora_mwrd_product(mwrd.get_last_order_id_mwrd().Rows[0][0].ToString());
            //txt_value.Text = (from DataGridViewRow row in dataGridView1.Rows
            //                                                   where row.Cells[2].FormattedValue.ToString() != string.Empty && row.Cells[3].FormattedValue.ToString() != string.Empty
            //                                                   select Convert.ToDouble(row.Cells[2].FormattedValue) * Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            txt_value.Text = (from DataGridViewRow row in dataGridView1.Rows
                              where row.Cells[7].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
        
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm_add_product frm = new frm_add_product(id);
            frm.txtnme.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtqte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtpshr.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.txtpg.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.txtpb.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.txtmsthlk.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.txttmd.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.Text = "تحديث بيانات الصنف:" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnok.Text = "تحديث";
            frm.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();

            byte[] image = (byte[])prd.get_image_product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pbox.Image = Image.FromStream(ms);

            frm.state = "update";
            frm.ShowDialog();
        }
        
        }

        
    }

