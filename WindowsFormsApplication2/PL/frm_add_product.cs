using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApplication2.UI;

namespace WindowsFormsApplication2.PL
{
    public partial class frm_add_product : Form
    {
        string ID = "";
        public string state;// = "add";        
        public string mwrdnme = "";
        public string order_id_mwrd = "";
        BL.cls_products prd = new BL.cls_products();
        BL.cls_mwrdeen mwrd = new BL.cls_mwrdeen();
        BL.cls_purchases purch = new BL.cls_purchases();
        DataTable dt_combobox;
        DataTable dt_stores;
        BL.cls_stores store = new BL.cls_stores();
        public frm_add_product( string id )
        {
            this.ID = id;
            InitializeComponent();
            //comboBox1.Items.Add("مستلزمات طبية");
            //comboBox1.Items.Add("مستحضرات تجميل");
            //comboBox1.Items.Add("اسنان");
            //comboBox1.Items.Add("شامبو وشاور");
            //comboBox1.Items.Add("رجال وأطفال");
            //comboBox1.Items.Add("كريم شعر");
            //comboBox1.Items.Add("جيل شعر");
            //comboBox1.Items.Add("زيت شعر");
            //comboBox1.Items.Add("ورقيات");
            //comboBox1.Items.Add("عناية منزلية");
            //comboBox1.Items.Add("روايح وعطور");
            DataTable dt_cat = new DataTable();
            dt_cat = prd.get_all_catogries();
            dt_stores = store.get_all_m5azen();

            dataGridView1.DataSource = prd.get_all_catogries();
            for (int i = 0; i < dt_cat.Rows.Count; i++)
            {
                comboBox1.Items.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
            }
           ////////////////////////
            dt_combobox = prd.get_all_products();
            txtnme.DataSource = dt_combobox;
            txtnme.DisplayMember = "اسم الصنف";
            txtnme.ValueMember = "id";
            ////////////////////////
            combo_stores.DataSource = dt_stores;
            combo_stores.DisplayMember = "اسم المخزن";
            combo_stores.ValueMember = "id";

            dgv_pre_prd.DataSource = prd.searchproduct("");

            txt_serial.Focus();
            txt_serial.Cursor = Cursor.Current;
            
            ApplyModernTheme();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور |*.JPG;*.PNG;*.GIF;*.BM;";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void demo()
        {
            if (prd.get_all_products().Rows.Count >= 5 &&Program.isDemo)
            {
                MessageBox.Show("برجاء شراء البرنامج للتمتع بكافة الصلاحيات \n لايمكنك اضافة اصناف اخري", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //return;
            }
        }
      private void button3_Click(object sender, EventArgs e)
        {
          /////////////////
            if ( Program.isDemo)
            {
                demo();
                return;
            }
            
           // this.Close();
          /////////////////
            if (string.IsNullOrEmpty(txtpb.Text))
            {
                txtpb.Text = "0";
            }
            if (string.IsNullOrEmpty(txtpg.Text))
            {
                txtpg.Text = "0";
            }
            if (string.IsNullOrEmpty(txtqte.Text))
            {
                txtqte.Text = "0";
            }

            if (string.IsNullOrEmpty(txtpshr.Text))
            {
                txtpshr.Text = "0";
            }
          bool exists=false ;
          
            if (prd.searchproduct(txtnme.Text).Rows.Count>=1)
            {
                exists = true;
                
            }
            if (state == "cstmr_mrtg3")
            {

                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteimage = ms.ToArray();


                prd.ad_product(txtnme.Text, Convert.ToInt32(txtqte.Text), txtpshr.Text, txtpg.Text, txtpb.Text, txtmsthlk.Text, txttmd.Text, byteimage, comboBox1.Text,combo_stores.Text, txt_serial.Text);

                MessageBox.Show("تمت الاضافه بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_products frm = new frm_products();

                frm.dataGridView1.DataSource = prd.get_all_products();
                this.Close();
            }
            else if (state=="add")
            {
                
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteimage = ms.ToArray();
                if (exists)
                {
                    //double new_price_shr=Math.Round(((Convert.ToInt32(txtqte.Text)*Convert.ToDouble(txtpshr.Text))+(Convert.ToInt32(dgv_pre_prd.Rows[0].Cells[2].Value)*Convert.ToDouble(dgv_pre_prd.Rows[0].Cells[3].Value)))/
                    //    ((Convert.ToInt32(txtqte.Text)+(Convert.ToInt32(dgv_pre_prd.Rows[0].Cells[2].Value)))),2);
                    double new_price_shr = Math.Round(((Convert.ToDouble(txtpshr.Text)) + (Convert.ToDouble(dgv_pre_prd.Rows[0].Cells[3].Value)))/2,2);
                    double new_total_mdfo3=Math.Round( new_price_shr*((Convert.ToInt32(txtqte.Text)+
                        (Convert.ToInt32(dgv_pre_prd.Rows[0].Cells[2].Value)))),2);
                    prd.update_product(txtnme.Text, Convert.ToInt32(txtqte.Text)+Convert.ToInt32(dgv_pre_prd.Rows[0].Cells[2].Value), new_price_shr.ToString(), txtpg.Text,
                        txtpb.Text, txtmsthlk.Text, new_total_mdfo3.ToString(), byteimage, dgv_pre_prd.Rows[0].Cells[0].Value.ToString(), comboBox1.Text, combo_stores.Text, txt_serial.Text);
                    /////////////////////////قالي الغي الاضافة في المشتريات من ادارة الاصناف
                    //purch.add_purshase(txtnme.Text, Convert.ToInt32(txtqte.Text), txtpshr.Text, txtpg.Text, txtpb.Text, txtmsthlk.Text,
                    //    txttmd.Text, byteimage, comboBox1.Text, "0", "0", combo_stores.Text);
                }
                else
                {
                    ///////////////////////////
                    prd.ad_product(txtnme.Text, Convert.ToInt32(txtqte.Text), txtpshr.Text, txtpg.Text, txtpb.Text, txtmsthlk.Text,
                        txttmd.Text, byteimage, comboBox1.Text, combo_stores.Text, txt_serial.Text);
                    ////////////////////قالي الغي الاضافة في المشتريات من ادارة الاصناف
                    //purch.add_purshase(txtnme.Text, Convert.ToInt32(txtqte.Text), txtpshr.Text, txtpg.Text, txtpb.Text, txtmsthlk.Text,
                    //    txttmd.Text, byteimage, comboBox1.Text, "0", "0", combo_stores.Text);
                    ///////////////////
                    prd.add_prd_first_rseed(Convert.ToInt32(prd.get_last_prd_id().Rows[0][0]), txtnme.Text, Convert.ToInt32(txtqte.Text), Convert.ToDouble(txtpshr.Text), Convert.ToDouble(txttmd.Text),DateTime.Now.ToShortDateString());
                }


                MessageBox.Show("تمت الاضافه بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_products frm = new frm_products();
                
                frm.dataGridView1.DataSource = prd.get_all_products();
                txtnme.Text = string.Empty;
                txtpb.Text = string.Empty;
                txtpg.Text = string.Empty;
                txtpshr.Text = string.Empty;
                txtqte.Text = string.Empty;
                txttmd.Text = string.Empty;
                txtmsthlk.Text = string.Empty;

                frm_products.getmainform.dataGridView1.DataSource = prd.get_all_products();

            }
            else if (state=="add_product_with_mwrd")
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteimage = ms.ToArray();


               
                if (exists)
                {
                    double new_price_shr =Math.Round( ((Convert.ToInt32(txtqte.Text) * Convert.ToDouble(txtpshr.Text)) + (Math.Abs(Convert.ToInt32(dgv_pre_prd.Rows[0].Cells[2].Value)) * Convert.ToDouble(dgv_pre_prd.Rows[0].Cells[3].Value))) /
                        ((Convert.ToInt32(txtqte.Text) + (Math.Abs(Convert.ToInt32(dgv_pre_prd.Rows[0].Cells[2].Value))))), 2);
                    double new_total_mdfo3 =Math.Round( new_price_shr * ((Convert.ToInt32(txtqte.Text) +
                        (Convert.ToInt32(dgv_pre_prd.Rows[0].Cells[2].Value)))),2);
                    int old_qte = 0;
                    try 
	                {
                         old_qte = Convert.ToInt32(dgv_pre_prd.Rows[0].Cells[2].Value);
		                
	                }
	                catch (Exception)
	                {
		
		                 old_qte=0;
	                }
                    prd.update_product(txtnme.Text, Convert.ToInt32(txtqte.Text) + old_qte, new_price_shr.ToString(), txtpg.Text,
                        txtpb.Text, txtmsthlk.Text, new_total_mdfo3.ToString(), byteimage, dgv_pre_prd.Rows[0].Cells[0].Value.ToString(), comboBox1.Text, combo_stores.Text, txt_serial.Text);
                    /////////////////////////
                    purch.add_purshase(txtnme.Text, Convert.ToInt32(txtqte.Text), txtpshr.Text, txtpg.Text, txtpb.Text, txtmsthlk.Text,
                        txttmd.Text, byteimage, comboBox1.Text, mwrdnme, order_id_mwrd, combo_stores.Text);
                }
                else
                {
                    ///////////////////////////
                    prd.add_product_with_mwrd(txtnme.Text, Convert.ToInt32(txtqte.Text), txtpshr.Text, txtpg.Text, txtpb.Text, txtmsthlk.Text
                   , txttmd.Text, byteimage, comboBox1.Text, mwrdnme, order_id_mwrd, combo_stores.Text);
                    ////////////////////
                    purch.add_purshase(txtnme.Text, Convert.ToInt32(txtqte.Text), txtpshr.Text, txtpg.Text, txtpb.Text, txtmsthlk.Text,
                        txttmd.Text, byteimage, comboBox1.Text, mwrdnme, order_id_mwrd, combo_stores.Text);
                    ///////////////////
                    prd.add_prd_first_rseed(Convert.ToInt32(prd.get_last_prd_id().Rows[0][0]), txtnme.Text, Convert.ToInt32(txtqte.Text), Convert.ToDouble(txtpshr.Text), Convert.ToDouble(txttmd.Text), DateTime.Now.ToShortDateString());
                }

                MessageBox.Show("تمت الاضافه بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_add_fwateer_mwrd frm1 = new frm_add_fwateer_mwrd();
                //frm1.dataGridView1.DataSource = mwrd.get_all_fatora_mwrd_product(order_id_mwrd);
                frm1.dataGridView1.DataSource = purch.get_all_fatora_mwrd_purchases(order_id_mwrd);

                frm_add_fwateer_mwrd.getmainform.dataGridView1.DataSource = purch.get_all_fatora_mwrd_purchases(order_id_mwrd);
                frm_add_fwateer_mwrd.getmainform.txt_value.Text = (from DataGridViewRow row in frm_add_fwateer_mwrd.getmainform.dataGridView1.Rows
                                                                   where row.Cells[2].FormattedValue.ToString() != string.Empty && row.Cells[3].FormattedValue.ToString() != string.Empty
                                                                   select Convert.ToDouble(row.Cells[2].FormattedValue) * Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
                
                txtnme.Text = string.Empty;
                txtpb.Text = string.Empty;
                txtpg.Text = string.Empty;
                txtpshr.Text = string.Empty;
                txtqte.Text = string.Empty;
                txttmd.Text = string.Empty;
                txtmsthlk.Text = string.Empty;
            }
            else if (state == "add_product_with_mwrd_frm_from_mwrdeen")
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteimage = ms.ToArray();


               // prd.add_product_with_mwrd(txtnme.Text, Convert.ToInt32(txtqte.Text), txtpshr.Text, txtpg.Text, txtpb.Text, txtmsthlk.Text, txttmd.Text, byteimage, comboBox1.Text, mwrdnme, order_id_mwrd, combo_stores.Text);
                if (exists)
                {
                    double new_price_shr = Math.Round(((Convert.ToInt32(txtqte.Text) * Convert.ToDouble(txtpshr.Text)) + (Math.Abs(Convert.ToInt32(dgv_pre_prd.Rows[0].Cells[2].Value)) * Convert.ToDouble(dgv_pre_prd.Rows[0].Cells[3].Value))) /
                        ((Convert.ToInt32(txtqte.Text) + Math.Abs(Convert.ToInt32(dgv_pre_prd.Rows[0].Cells[2].Value)))), 2);
                    double new_total_mdfo3 =Math.Round(new_price_shr * ((Convert.ToInt32(txtqte.Text) +
                        (Convert.ToInt32(dgv_pre_prd.Rows[0].Cells[2].Value)))),2);
                    prd.update_product(txtnme.Text, Convert.ToInt32(txtqte.Text) + Convert.ToInt32(dgv_pre_prd.Rows[0].Cells[2].Value), new_price_shr.ToString(), txtpg.Text,
                        txtpb.Text, txtmsthlk.Text, new_total_mdfo3.ToString(), byteimage, dgv_pre_prd.Rows[0].Cells[0].Value.ToString(), comboBox1.Text, combo_stores.Text, txt_serial.Text);
                    /////////////////////////
                    purch.add_purshase(txtnme.Text, Convert.ToInt32(txtqte.Text), txtpshr.Text, txtpg.Text, txtpb.Text, txtmsthlk.Text,
                        txttmd.Text, byteimage, comboBox1.Text, mwrdnme, order_id_mwrd, combo_stores.Text);
                }
                else
                {
                    ///////////////////////////
                    prd.add_product_with_mwrd(txtnme.Text, Convert.ToInt32(txtqte.Text), txtpshr.Text, txtpg.Text, txtpb.Text, txtmsthlk.Text
                   , txttmd.Text, byteimage, comboBox1.Text, mwrdnme, order_id_mwrd, combo_stores.Text);
                    ////////////////////
                    purch.add_purshase(txtnme.Text, Convert.ToInt32(txtqte.Text), txtpshr.Text, txtpg.Text, txtpb.Text, txtmsthlk.Text,
                        txttmd.Text, byteimage, comboBox1.Text, mwrdnme, order_id_mwrd, combo_stores.Text);
                    ///////////////////
                    prd.add_prd_first_rseed(Convert.ToInt32(prd.get_last_prd_id().Rows[0][0]), txtnme.Text, Convert.ToInt32(txtqte.Text), Convert.ToDouble(txtpshr.Text), Convert.ToDouble(txttmd.Text), DateTime.Now.ToShortDateString());
                }

                MessageBox.Show("تمت الاضافه بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //frm_add_fwateer_mwrd frm1 = new frm_add_fwateer_mwrd();
                //frm1.dataGridView1.DataSource = mwrd.get_all_fatora_mwrd_product(order_id_mwrd);
                //frm_add_fwateer_mwrd.getmainform.dataGridView1.DataSource = mwrd.get_all_fatora_mwrd_product(order_id_mwrd);
                //frm_add_fwateer_mwrd.getmainform.txt_value.Text = (from DataGridViewRow row in frm_add_fwateer_mwrd.getmainform.dataGridView1.Rows
                //                                                   where row.Cells[2].FormattedValue.ToString() != string.Empty && row.Cells[3].FormattedValue.ToString() != string.Empty
                //                                                   select Convert.ToDouble(row.Cells[2].FormattedValue) * Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
                ////frm_from_mwrdeen 
                //////////////////////////////////////////////////
                frm_from_mwrdeen.getmainform.dataGridView_asnaf.DataSource = purch.get_all_fatora_mwrd_purchases(frm_from_mwrdeen.getmainform.dataGridView_fwater.CurrentRow.Cells[0].Value.ToString());
                string newTotal = (from DataGridViewRow row in frm_from_mwrdeen.getmainform.dataGridView_asnaf.Rows
                                   where row.Cells[7].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
                string oldTotal = frm_from_mwrdeen.getmainform.dataGridView_fwater.CurrentRow.Cells[3].Value.ToString();
                double new_mtbakii = Convert.ToDouble(newTotal) - Convert.ToDouble(oldTotal);
                mwrd.edit_fwateer_mwrd(Convert.ToInt32(frm_from_mwrdeen.getmainform.dataGridView_fwater.CurrentRow.Cells[0].Value),
                    frm_from_mwrdeen.getmainform.dataGridView_fwater.CurrentRow.Cells[1].Value.ToString(),
                    frm_from_mwrdeen.getmainform.dataGridView_fwater.CurrentRow.Cells[2].Value.ToString(),
                    newTotal.ToString(), frm_from_mwrdeen.getmainform.dataGridView_fwater.CurrentRow.Cells[4].Value.ToString(),
                    (Convert.ToDouble(frm_from_mwrdeen.getmainform.dataGridView_fwater.CurrentRow.Cells[5].Value)+new_mtbakii).ToString());
                frm_from_mwrdeen.getmainform.dataGridView_fwater.DataSource = mwrd.get_all_fwateer_mwrd(frm_from_mwrdeen.getmainform.txtmwrd_nme.Text);

                txtnme.Text = string.Empty;
                txtpb.Text = string.Empty;
                txtpg.Text = string.Empty;
                txtpshr.Text = string.Empty;
                txtqte.Text = string.Empty;
                txttmd.Text = string.Empty;
                txtmsthlk.Text = string.Empty;
            }
            else if (state == "edit_product_with_mwrd")
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteimage = ms.ToArray();
                PL.frm_products frm = new frm_products();
                //  MessageBox.Show(ID);

                prd.update_prd_name(txtnme.Text, Convert.ToInt32(ID));
                
                prd.update_product(txtnme.Text, Convert.ToInt32(txtqte.Text), txtpshr.Text, txtpg.Text, txtpb.Text, txtmsthlk.Text, txttmd.Text, byteimage, ID, comboBox1.Text, combo_stores.Text, txt_serial.Text);
                //string single= purch.get_single_purchase_id(txtnme.Text).Rows[0][0].ToString();

                MessageBox.Show("تم التعديل بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // frm_products.getmainform.dataGridView1.DataSource = prd.get_all_products();
                frm_add_fwateer_mwrd.getmainform.dataGridView1.DataSource = purch.get_all_fatora_mwrd_purchases(order_id_mwrd);
                frm_add_fwateer_mwrd.getmainform.txt_value.Text = (from DataGridViewRow row in frm_add_fwateer_mwrd.getmainform.dataGridView1.Rows
                                                                   where row.Cells[2].FormattedValue.ToString() != string.Empty && row.Cells[3].FormattedValue.ToString() != string.Empty
                                                                   select Convert.ToDouble(row.Cells[2].FormattedValue) * Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
                this.Close();
            }
            else if (state == "edit_product_with_mwrd_frm_from_mwrdeen")
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteimage = ms.ToArray();
                PL.frm_products frm = new frm_products();
                //  MessageBox.Show(ID);
                prd.update_prd_name(txtnme.Text, Convert.ToInt32(ID));

                prd.update_product(txtnme.Text, Convert.ToInt32(txtqte.Text), txtpshr.Text, txtpg.Text, txtpb.Text, txtmsthlk.Text, txttmd.Text, byteimage, ID, comboBox1.Text, combo_stores.Text, txt_serial.Text);
               // string single = purch.get_single_purchase_id(txtnme.Text).Rows[0][0].ToString();

                MessageBox.Show("تم التعديل بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // frm_products.getmainform.dataGridView1.DataSource = prd.get_all_products();
                frm_from_mwrdeen.getmainform.dataGridView_asnaf.DataSource = purch.get_all_fatora_mwrd_purchases(frm_from_mwrdeen.getmainform.dataGridView_fwater.CurrentRow.Cells[0].Value.ToString());
                string newTotal = (from DataGridViewRow row in frm_from_mwrdeen.getmainform.dataGridView_asnaf.Rows
                                   where row.Cells[7].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
                string oldTotal = frm_from_mwrdeen.getmainform.dataGridView_fwater.CurrentRow.Cells[3].Value.ToString();
                double new_mtbakii = Convert.ToDouble(newTotal) - Convert.ToDouble(oldTotal);
                mwrd.edit_fwateer_mwrd(Convert.ToInt32(frm_from_mwrdeen.getmainform.dataGridView_fwater.CurrentRow.Cells[0].Value),
                    frm_from_mwrdeen.getmainform.dataGridView_fwater.CurrentRow.Cells[1].Value.ToString(),
                    frm_from_mwrdeen.getmainform.dataGridView_fwater.CurrentRow.Cells[2].Value.ToString(),
                    newTotal.ToString(), frm_from_mwrdeen.getmainform.dataGridView_fwater.CurrentRow.Cells[4].Value.ToString(),
                    (Convert.ToDouble(frm_from_mwrdeen.getmainform.dataGridView_fwater.CurrentRow.Cells[5].Value) + new_mtbakii).ToString());
                frm_from_mwrdeen.getmainform.dataGridView_fwater.DataSource = mwrd.get_all_fwateer_mwrd(frm_from_mwrdeen.getmainform.txtmwrd_nme.Text);
                this.Close();
            }
            else
            {


                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteimage = ms.ToArray();
                PL.frm_products frm = new frm_products();
                //  MessageBox.Show(ID);
                prd.update_prd_name(txtnme.Text, Convert.ToInt32(ID));

                prd.update_product(txtnme.Text, Convert.ToInt32(txtqte.Text), txtpshr.Text, txtpg.Text, txtpb.Text, txtmsthlk.Text, txttmd.Text, byteimage, ID, comboBox1.Text, combo_stores.Text, txt_serial.Text);
                //string single = purch.get_single_purchase_id(txtnme.Text).Rows[0][0].ToString();
                MessageBox.Show("تم التعديل بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_products.getmainform.dataGridView1.DataSource = prd.get_all_products();

                this.Close();
                frm_products.getmainform.dataGridView1.DataSource = prd.get_all_products();

            }
            //txtnme.Focus();

            txt_serial.Focus();
            txt_serial.Clear();
            dt_combobox = prd.get_all_products();
            txtnme.DataSource = dt_combobox;
            txtnme.DisplayMember = "اسم الصنف";
            txtnme.ValueMember = "id";
          //  MessageBox.Show("state : " + state);
        }

      private void txtpshr_Validated(object sender, EventArgs e)
      {
      }

      private void txtpb_Validated(object sender, EventArgs e)
      {
      }

      private void frm_add_product_Load(object sender, EventArgs e)
      {
            txt_serial.Focus();
        }

        private void txtshr_TextChanged(object sender, EventArgs e)
      {
          if (txtpshr.Text != string.Empty && txtqte.Text != string.Empty)
          {
              txttmd.Text = Convert.ToString(Convert.ToDouble(txtpshr.Text) * Convert.ToDouble(txtqte.Text));

          }
      }

      private void txtpshr_Validated_1(object sender, EventArgs e)
      {
          if (txtpshr.Text!=string.Empty&&txtqte.Text!=string.Empty)
          {
              txttmd.Text = Convert.ToString(Convert.ToDouble(txtpshr.Text) * Convert.ToDouble(txtqte.Text));
 
          }

      }

      private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
      {
         // this.dataGridView1.DataSource = prd.searchproduct(comboBox1.Text);
          dt_combobox = prd.searchproduct(comboBox1.Text);
          txtnme.DataSource = dt_combobox;
          txtnme.DisplayMember = "اسم الصنف";
          txtnme.ValueMember = "id";
            

      }

      private void txtnme_TextChanged(object sender, EventArgs e)
      {
          if (txtnme.Text != string.Empty)
          {
              //txtnme.DataSource = prd.searchproduct(txtnme.Text);
              txtnme.DisplayMember = "اسم الصنف";
              txtnme.ValueMember = "id";

          }
      }

      private void txtnme_SelectedIndexChanged(object sender, EventArgs e)
      {
          dgv_pre_prd.DataSource = prd.searchproduct(txtnme.Text);
      }

        private void txt_serial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txt_serial.Text))
            {
                var product = prd.get_prd_by_serial(txt_serial.Text);
                if (product.Rows.Count > 0)
                {
                    txtnme.Text = product.Rows[0][1].ToString();
                    txtmsthlk.Text = product.Rows[0][6].ToString();
                    combo_stores.Text = product.Rows[0][12].ToString();
                    comboBox1.Text = product.Rows[0][9].ToString();
                    txtpshr.Text = product.Rows[0][3].ToString();
                    txtpg.Text = product.Rows[0][4].ToString();
                    txtpb.Text = product.Rows[0][5].ToString();
                    txtqte.Focus();
                    dgv_pre_prd.DataSource = prd.searchproduct(txtnme.Text);

                }
                else
                {
                    txtnme.Focus();
                }
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "انشاء بار كود خاص"); // you can change the first parameter (textbox3) on any control you wanna focus
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txt_serial.Text = RandomString(8);
        }
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        
        private void ApplyModernTheme()
        {
            // Apply modern form styling
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = ModernTheme.NormalFont;
            
            // Style GroupBox
            ModernTheme.StyleGroupBox(groupBox1);
            groupBox1.BackColor = ModernTheme.BackgroundCard;
            groupBox1.ForeColor = ModernTheme.TextPrimary;
            
            // Style TextBoxes
            StyleTextBoxes();
            
            // Style ComboBoxes
            StyleComboBoxes();
            
            // Style Labels
            StyleLabels();
            
            // Style Buttons
            StyleButtons();
            
            // Style DataGridViews
            StyleDataGridViews();
        }
        
        private void StyleTextBoxes()
        {
            TextBox[] textBoxes = { txt_serial, txtqte, txtpshr, txtpg, txtpb, txtmsthlk, txttmd };
            
            foreach (TextBox txt in textBoxes)
            {
                if (txt != null)
                {
                    ModernTheme.StyleTextBox(txt);
                }
            }
            
            // Special styling for total
            if (txttmd != null)
            {
                txttmd.BackColor = Color.FromArgb(230, 244, 241); // Light green
                txttmd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            }
        }
        
        private void StyleComboBoxes()
        {
            ModernTheme.StyleComboBox(txtnme);
            ModernTheme.StyleComboBox(comboBox1);
            ModernTheme.StyleComboBox(combo_stores);
        }
        
        private void StyleLabels()
        {
            Label[] labels = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11 };
            
            foreach (Label label in labels)
            {
                if (label != null)
                {
                    ModernTheme.StyleLabel(label, LabelStyle.Normal);
                }
            }
        }
        
        private void StyleButtons()
        {
            // Main action button
            ModernTheme.StyleButton(btnok, ButtonStyle.Success);
            
            // Image button
            ModernTheme.StyleButton(button1, ButtonStyle.Primary);
            
            // Exit button
            ModernTheme.StyleButton(button2, ButtonStyle.Danger);
        }
        
        private void StyleDataGridViews()
        {
            if (dgv_pre_prd != null)
            {
                ModernTheme.StyleDataGridView(dgv_pre_prd);
            }
            
            if (dataGridView1 != null)
            {
                ModernTheme.StyleDataGridView(dataGridView1);
            }
        }
    }
}
