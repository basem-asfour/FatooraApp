using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace WindowsFormsApplication2.PL
{

    public partial class Frm_orders : Form
    {
        public string type = "save new";
        double mksab = 0;
        BL.cls_orders order = new BL.cls_orders();
        BL.cls_cstmrs cstmr = new BL.cls_cstmrs();

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        BL.cls_products product = new BL.cls_products();
        BL.cls_product_serials prdSerials = new BL.cls_product_serials();
        void calctotalprice()
        {
            if (string.IsNullOrEmpty(txtds.Text))
            {
                txtds.Text = "0";
            }
            if (txtprice.Text != string.Empty && txtqte.Text != string.Empty)//&& txtds.Text != string.Empty
            {

                double xx = Convert.ToDouble(txtprice.Text) * Convert.ToInt32(txtqte.Text);

                txttp.Text = (xx - (xx / 100 * Convert.ToDouble(txtds.Text))).ToString();
            }
        }
        void calctotalprice_afterTotal_5sm()
        {
            if (string.IsNullOrEmpty(txt_total_5sm.Text))
            {
                txt_total_5sm.Text = "0";
            }
            if (txtmg.Text != string.Empty)
            {
                double xx;
                for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
                {
                    xx = Convert.ToDouble(dgvproducts.Rows[i].Cells[2].Value) * Convert.ToInt32(dgvproducts.Rows[i].Cells[3].Value);                     
                    dgvproducts.Rows[i].Cells[6].Value = (xx - (xx / 100 * Convert.ToDouble(txt_total_5sm.Text))).ToString();
                    dgvproducts.Rows[i].Cells[4].Value = txt_total_5sm.Text;
                }
                txt_total_after_5sm.Text = (from DataGridViewRow row in dgvproducts.Rows
                                            where row.Cells[6].FormattedValue.ToString() != string.Empty
                                            select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
                if (txt_total_5sm.Text == "0")
                {
                    // double xx ;
                    for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
                    {
                        xx = Convert.ToDouble(dgvproducts.Rows[i].Cells[2].Value) * Convert.ToInt32(dgvproducts.Rows[i].Cells[3].Value); ;
                        dgvproducts.Rows[i].Cells[6].Value = xx;// (xx - (xx / 100 * Convert.ToDouble(dgvproducts.Rows[i].Cells[4].Value))).ToString();
                        dgvproducts.Rows[i].Cells[4].Value = txt_total_5sm.Text;
                    }
                    txt_total_after_5sm.Text = txtmg.Text;
                }
            }
        }
        void calcTotalPriceAfter_number_5sm()
        {
            if (string.IsNullOrEmpty(txt_total_5sm.Text))
            {
                txt_total_5sm.Text = "0";
            }
            if (txtmg.Text != string.Empty)
            {

                txt_total_after_5sm.Text = (Convert.ToDouble(txtmg.Text) - Convert.ToDouble(txt_total_5sm.Text)).ToString();
                if (txt_total_5sm.Text == "0")
                {                
                    txt_total_after_5sm.Text = txtmg.Text;
                }
                if (txt_total_5sm.Text == "0")
                {
                     double xx ;
                    for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
                    {
                        xx = Convert.ToDouble(dgvproducts.Rows[i].Cells[2].Value) * Convert.ToInt32(dgvproducts.Rows[i].Cells[3].Value); ;
                        dgvproducts.Rows[i].Cells[6].Value = xx;// (xx - (xx / 100 * Convert.ToDouble(dgvproducts.Rows[i].Cells[4].Value))).ToString();
                        dgvproducts.Rows[i].Cells[4].Value = txt_total_5sm.Text;
                    }
                    txt_total_after_5sm.Text = txtmg.Text;
                }

                if (!string.IsNullOrEmpty(txtmsdd.Text))
                {
                     txtmsdd.Text = (Convert.ToDouble(txtmg.Text) - Convert.ToDouble(txt_total_5sm.Text)).ToString();
                }

            }
        }
        void clearboxes()
        {
            txtid.Clear();
            txtnme.Clear();
            txtprice.Clear();
            txtqte.Clear();
            txtds.Clear();
            txttp.Clear();
            button2.Focus();
            txtpmsthlk.Clear();
            txt_price_shraa.Clear();
        }
        void cleardata()
        {
            txtpmsthlk.Clear();
            txtorderid.Clear();
            dateTimePicker1.ResetText();
            txtcstid.Clear();
            txtcstnme.Clear();
            txtcstpho.Clear();
            txtcstadrs.Clear();
            clearboxes();
            dgvproducts.DataSource = null;
            dt = new DataTable();
            createdatatable();
            txttp.Clear();
            txtmsdd.Clear();
            txtmtbki.Clear();
            txtmg.Clear();
            txt_total_after_5sm.Clear();
            txt_total_5sm.Clear();
            radioButton2not3mel.Checked = false;
            radioButtonamel.Checked = false;
            btnnew.Enabled = true;
            btnsve.Enabled = false;
            btnprnt.Enabled = true;
            dt2.Clear();
            txt_price_shraa.Clear();
            txt_transport.Text = "0";
            txt_notes.Clear();
            txt_serial.Clear();
        }
        List<string> GetExcludeSerialsFromGrid()
        {
            var list = new List<string>();
            for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
            {
                var cell = dgvproducts.Rows[i].Cells.Count > 7 ? dgvproducts.Rows[i].Cells[7].Value : null;
                if (cell != null && cell != DBNull.Value && !string.IsNullOrEmpty(cell.ToString()))
                {
                    foreach (var s in cell.ToString().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        var t = s.Trim();
                        if (!string.IsNullOrEmpty(t) && !list.Contains(t))
                            list.Add(t);
                    }
                }
            }
            return list;
        }
        void createdatatable()
        {
            dt.Columns.Add("كود الصنف");
            dt.Columns.Add("اسم الصنف");
            dt.Columns.Add("السعر");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("(%)الخصم");
            dt.Columns.Add("سعر المستهلك");
            dt.Columns.Add("السعر الكلي");
            dt.Columns.Add("السيريال");

            dgvproducts.DataSource = dt;
        }
        //عندك خطا هنا صلحه بتاع تظبيط عواميد الداتا جريد فيو
        void resizedgv()
        {
            this.dgvproducts.RowHeadersWidth = 91;
            this.dgvproducts.Columns[0].Width = 100;
            this.dgvproducts.Columns[1].Width = 197;
            this.dgvproducts.Columns[2].Width = 78;
            this.dgvproducts.Columns[3].Width = 83;
            this.dgvproducts.Columns[4].Width = 80;
            this.dgvproducts.Columns[5].Width = 105;
            this.dgvproducts.Columns[6].Width = 125;
            if (this.dgvproducts.Columns.Count > 7)
                this.dgvproducts.Columns[7].Width = 130;
        }
        DataTable dt_combobox;
        DataTable dt_mndob;
        BL.cls_mndobeen mndb = new BL.cls_mndobeen();
        public Frm_orders()
        {
            InitializeComponent();
            createdatatable();
            txtsaleman.Text = Program.saleman;
            dt2.Columns.Add("سعر الشراء");
            dataGridView1.DataSource = dt2;
            dt_combobox = product.get_all_products();
            comboBox2.DataSource =dt_combobox;
            comboBox2.DisplayMember="اسم الصنف";
            comboBox2.ValueMember = "id";

            //comboBox1.DataSource = product.get_nme_product("");
            dt_mndob = mndb.get_all_mndopeen();
            combo_mndoob.DataSource = dt_mndob;
            combo_mndoob.DisplayMember = "اسم المندوب";
            combo_mndoob.ValueMember = "id";
            txt_mndb_phon.Text = "";

            radioButton2not3mel.Checked = true;
            txt_rseed.Clear();
            radioButton_number.Checked = true;
            //dateTimePicker1.Focus();
            txt_serial.Focus();

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_orders_Load(object sender, EventArgs e)
        {
            dataGridView1.SendToBack();
            txt_serial.Focus();
        }
        public void demo()
        {
            if (order.get_all_new_orders().Rows.Count >= 5)
            {
                MessageBox.Show("برجاء شراء البرنامج للتمتع بكافة الصلاحيات \n لايمكنك اضافة مبيعات اخري", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.isDemo)
            {
                demo();
                return;
            }
           //DataTable dt_date = order.one_order_for_each_day(dateTimePicker2.Text);
           // if (radioButton2not3mel.Checked==true&&dt_date.Rows.Count>0)
           // {
           //     txtorderid.Text = order.one_order_for_each_day(dateTimePicker2.Text).Rows[0][0].ToString();
           // }
           // else
           // {
           //     this.txtorderid.Text = order.get_last_order_id().Rows[0][0].ToString();

           // }
            if (string.IsNullOrEmpty(txtmsdd.Text))
            {
                txtmsdd.Text = "0";
                //txtmtbki.Text = "0";
            }
               this.txtorderid.Text = order.get_last_order_id().Rows[0][0].ToString();

            btnnew.Enabled = false;
            btnsve.Enabled = true;
            //////////////////////////new
            if (radioButton_nesba.Checked == true || radioButton_nesba.Checked == false && radioButton_number.Checked == false)
            {
                mksab = 0;
                for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
                {
                    double cell6 = 0, cell0 = 0, cell3 = 0;
                    double.TryParse(dgvproducts.Rows[i].Cells[6].Value?.ToString(), out cell6);
                    double.TryParse(dataGridView1.Rows[i].Cells[0].Value?.ToString(), out cell0);
                    double.TryParse(dgvproducts.Rows[i].Cells[3].Value?.ToString(), out cell3);
                    mksab += (cell6 - cell0 * cell3);
                }
                txtmksb.Text = mksab.ToString();

            }
            else
            {
                mksab = 0;
                for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
                {
                    double cell6 = 0, cell0 = 0, cell3 = 0;
                    double.TryParse(dgvproducts.Rows[i].Cells[6].Value?.ToString(), out cell6);
                    double.TryParse(dataGridView1.Rows[i].Cells[0].Value?.ToString(), out cell0);
                    double.TryParse(dgvproducts.Rows[i].Cells[3].Value?.ToString(), out cell3);
                    mksab += (cell6 - cell0 * cell3);
                }
                double total5sm = 0;
                double.TryParse(txt_total_5sm.Text, out total5sm);
                txtmksb.Text = (mksab - total5sm).ToString();

            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_cstmrs_list frm = new frm_cstmrs_list();
            frm.ShowDialog();
            if (!string.IsNullOrEmpty(cstmr.get_all_7sab_sabk(Convert.ToInt32(frm.dgvcstmrs.CurrentRow.Cells[0].Value)).Rows[0][0].ToString()))
            {
                if (Convert.ToInt32(cstmr.get_all_7sab_sabk(Convert.ToInt32(frm.dgvcstmrs.CurrentRow.Cells[0].Value)).Rows[0][0]) >= 5000)
                {
                    MessageBox.Show("لا يمكن اختيار هذا العميل نظراً لأن حسابه السابق تجاوز 5000 ", "برجاء سداد الحساب السابق", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            this.txtcstid.Text = frm.dgvcstmrs.CurrentRow.Cells[0].Value.ToString();
            this.txtcstnme.Text = frm.dgvcstmrs.CurrentRow.Cells[1].Value.ToString();
            this.txtcstpho.Text = frm.dgvcstmrs.CurrentRow.Cells[2].Value.ToString();
            this.txtcstadrs.Text = frm.dgvcstmrs.CurrentRow.Cells[3].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearboxes();
            frm_products_list frm = new frm_products_list();
            frm.ShowDialog();
            txtid.Text = frm.dgvprdcts.CurrentRow.Cells[0].Value.ToString();
            txtnme.Text = frm.dgvprdcts.CurrentRow.Cells[1].Value.ToString();
            txtpmsthlk.Text = frm.dgvprdcts.CurrentRow.Cells[6].Value.ToString();
            txt_price_shraa.Text = frm.dgvprdcts.CurrentRow.Cells[3].Value.ToString();
            if (radioButtonamel.Checked == true)
            {
                txtprice.Text = frm.dgvprdcts.CurrentRow.Cells[4].Value.ToString();

            }
            else if (radioButton2not3mel.Checked == true)
            {
                txtprice.Text = frm.dgvprdcts.CurrentRow.Cells[5].Value.ToString();

            }
            txtprice.Focus();
            txt_rseed.Text = frm.dgvprdcts.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtqte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txtprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtprice.Text != string.Empty)
            {
                txtqte.Focus();
            }
        }

        private void txtqte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtqte.Text != string.Empty)
            {
                txtds.Focus();
            }
        }

        private void txtds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtds.Text != string.Empty)
            {
                button2.Focus();

                for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
                {
                    if (dgvproducts.Rows[i].Cells[0].Value != null && dgvproducts.Rows[i].Cells[0].Value.ToString() == txtid.Text)
                    {
                        MessageBox.Show("تم ادخال هذا المنتج مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (radio_raseed.Checked == true || radio_not_raseed.Checked == false && radio_raseed.Checked == false)
                {
                    if (order.verifyqte(Convert.ToInt32(txtid.Text), Convert.ToInt32(txtqte.Text)).Rows.Count < 1)
                    {
                        MessageBox.Show("الكميه المدخله لهذا الصنف غير متوفره ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                int qte = 0;
                int.TryParse(txtqte.Text, out qte);
                if (qte < 1)
                {
                    MessageBox.Show("الكمية يجب أن تكون أكبر من صفر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                object serialsForCell7 = DBNull.Value;
                int mode = product.GetProductSerialNumberMode(txtid.Text);
                if (mode == 1)
                {
                    var excludeSerials = GetExcludeSerialsFromGrid();
                    var frm = new frm_select_serial_for_order(Convert.ToInt32(txtid.Text), qte, excludeSerials);
                    frm.ShowDialog();
                    if (frm.DialogResult != DialogResult.OK || string.IsNullOrEmpty(frm.SelectedSerialsCommaSeparated))
                    {
                        return;
                    }
                    serialsForCell7 = frm.SelectedSerialsCommaSeparated;
                }

                DataRow r = dt.NewRow();
                r[0] = txtid.Text;
                r[1] = txtnme.Text;
                r[2] = txtprice.Text;
                r[3] = txtqte.Text;
                r[4] = txtds.Text;
                r[5] = txtpmsthlk.Text;
                r[6] = txttp.Text;
                r[7] = serialsForCell7;
                dt.Rows.Add(r);
                dgvproducts.DataSource = dt;
                ///////////////////
                DataRow r2 = dt2.NewRow();
                r2[0] = txt_price_shraa.Text;
                dt2.Rows.Add(r2);
                dataGridView1.DataSource = dt2;
                ////////////////////////////

                resizedgv();
                clearboxes();

                txtmg.Text = (from DataGridViewRow row in dgvproducts.Rows
                              where row.Cells[6].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
                if (radioButton2not3mel.Checked == true)
                {
                    txtmsdd.Text = txtmg.Text;
                    txtmtbki.Text = "0";
                }
                else if (radioButtonamel.Checked == true)
                {
                    txtmsdd.Focus();

                }
            }
            comboBox2.Focus();
            txt_rseed.Clear();

        }

        private void txtprice_KeyUp(object sender, KeyEventArgs e)
        {
            calctotalprice();
        }

        private void txtds_KeyUp(object sender, KeyEventArgs e)
        {
            calctotalprice();

        }

        private void txtqte_KeyUp(object sender, KeyEventArgs e)
        {
            calctotalprice();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
            {
                if (dgvproducts.Rows[i].Cells[0].Value != null && dgvproducts.Rows[i].Cells[0].Value.ToString() == txtid.Text)
                {
                    MessageBox.Show("تم ادخال هذا المنتج مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (radio_raseed.Checked == true || radio_not_raseed.Checked == false && radio_raseed.Checked == false)
            {
                if (order.verifyqte(Convert.ToInt32(txtid.Text), Convert.ToInt32(txtqte.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("الكميه المدخله لهذا الصنف غير متوفره ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int qte = 0;
            int.TryParse(txtqte.Text, out qte);
            if (qte < 1)
            {
                MessageBox.Show("الكمية يجب أن تكون أكبر من صفر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object serialsForCell7 = DBNull.Value;
            int mode = product.GetProductSerialNumberMode(txtid.Text);
            if (mode == 1)
            {
                var excludeSerials = GetExcludeSerialsFromGrid();
                var frm = new frm_select_serial_for_order(Convert.ToInt32(txtid.Text), qte, excludeSerials);
                frm.ShowDialog();
                if (frm.DialogResult != DialogResult.OK || string.IsNullOrEmpty(frm.SelectedSerialsCommaSeparated))
                {
                    return;
                }
                serialsForCell7 = frm.SelectedSerialsCommaSeparated;
            }

            DataRow r = dt.NewRow();
            r[0] = txtid.Text;
            r[1] = txtnme.Text;
            r[2] = txtprice.Text;
            r[3] = txtqte.Text;
            r[4] = txtds.Text;
            r[5] = txtpmsthlk.Text;
            r[6] = txttp.Text;
            r[7] = serialsForCell7;
                dt.Rows.Add(r);

                DataRow r2 = dt2.NewRow();
                r2[0] = txt_price_shraa.Text;
                dt2.Rows.Add(r2);
                dataGridView1.DataSource = dt2;
                if (type == "save new")
                    dgvproducts.DataSource = dt;
                else
                    dgvproducts.Rows.Add(dt);
                resizedgv();
            clearboxes();

            txtmg.Text = (from DataGridViewRow row in dgvproducts.Rows
                          where row.Cells[6].FormattedValue.ToString() != string.Empty
                          select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            if (radioButton2not3mel.Checked == true)
            {
                txtmsdd.Text = txt_total_after_5sm.Text;
                txtmtbki.Text = "0";
            }
            else if (radioButtonamel.Checked == true)
            {
                txtmsdd.Focus();

            }
            comboBox2.Focus();
            txt_rseed.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvproducts_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtid.Text = this.dgvproducts.CurrentRow.Cells[0].Value.ToString();
                txtnme.Text = this.dgvproducts.CurrentRow.Cells[1].Value.ToString();
                txtprice.Text = this.dgvproducts.CurrentRow.Cells[2].Value.ToString();
                txtqte.Text = this.dgvproducts.CurrentRow.Cells[3].Value.ToString();
                txtds.Text = this.dgvproducts.CurrentRow.Cells[4].Value.ToString();
                txtpmsthlk.Text = this.dgvproducts.CurrentRow.Cells[5].Value.ToString();
                txttp.Text = this.dgvproducts.CurrentRow.Cells[6].Value.ToString();
                dgvproducts.Rows.RemoveAt(dgvproducts.CurrentRow.Index);
                txtqte.Focus();
            }
            catch
            {
                return;
            }
        }

        private void dgvproducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

            txtmg.Text = (from DataGridViewRow row in dgvproducts.Rows
                          where row.Cells[6].FormattedValue.ToString() != string.Empty
                          select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvproducts_DoubleClick(sender, e);
        }

        private void حذفالصنفالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvproducts.Rows.RemoveAt(dgvproducts.CurrentRow.Index);
                dataGridView1.Rows.RemoveAt(dgvproducts.CurrentRow.Index);


            }
            catch (Exception)
            {

            }

        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dgvproducts.Refresh();
        }

        private void btnsve_Click(object sender, EventArgs e)
        {
            //check values (ماتنساش تفصصها)
            if (txtorderid.Text == string.Empty  )
            {
                MessageBox.Show("تاكد من اختيار فاتورة جديدة","يوجد نقص في المعلومات ومن فضلك تاكد من اختياراتك", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ( radioButton2not3mel.Checked == false && radioButtonamel.Checked == false )
            {
                MessageBox.Show("اختر نوع العميل", "يوجد نقص في المعلومات ومن فضلك تاكد من اختياراتك", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ( radioButtonamel.Checked == true && txtcstid.Text == string.Empty)
            {
                MessageBox.Show("اختر عميل", "يوجد نقص في المعلومات ومن فضلك تاكد من اختياراتك", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            //////عملت ال if دي جديده لما قال عاوز كل يوم يبقي فيه فاتوره واحده
            //DataTable dt_date = order.one_order_for_each_day(dateTimePicker2.Text);
            //if (radioButton2not3mel.Checked == true && dt_date.Rows.Count > 0)
            //{
            //    string mg = (Convert.ToDouble(txtmg.Text) + Convert.ToDouble(order.one_order_for_each_day(dateTimePicker2.Text).Rows[0][2])).ToString();

            //    string mtbaki = "0";
            //    string mksb = (Convert.ToInt32(txtmksb.Text) + Convert.ToDouble(order.one_order_for_each_day(dateTimePicker2.Text).Rows[0][1])).ToString();

            //    //التعديل في new order
            //    order.edit_new_order(Convert.ToInt32(txtorderid.Text), mg, mtbaki, mg, mksb);

            //    //اضافه اصناف البيع النقدي الجديده 
            //    for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
            //    {
            //        order.add_order_details(Convert.ToInt16(txtorderid.Text), Convert.ToInt32(dgvproducts.Rows[i].Cells[0].Value),
            //            Convert.ToInt32(dgvproducts.Rows[i].Cells[2].Value), dgvproducts.Rows[i].Cells[3].Value.ToString(),
            //            Convert.ToDouble(dgvproducts.Rows[i].Cells[4].Value), dgvproducts.Rows[i].Cells[5].Value.ToString(),
            //            dgvproducts.Rows[i].Cells[6].Value.ToString(), mg,mtbaki);


            //    }
            //    order.update_msdd_mtpakii(txtorderid.Text, mg, mtbaki);
            //}
            //else
            //{
            //    //اضافه معلومات الفتوره
            //    order.ad_order(Convert.ToInt32(txtorderid.Text), dateTimePicker1.Value, Convert.ToInt32(txtcstid.Text), txtsaleman.Text);
            //    //عملت جدول جديد عشان اضافة معلومات الفاتورة بالاضافة للمسدد والمتبقي
            //    order.add_to_new_orders(Convert.ToInt32(txtorderid.Text), dateTimePicker2.Text, Convert.ToInt32(txtcstid.Text), txtmsdd.Text, txtmtbki.Text, txtmg.Text, txtmksb.Text);
            //    //اضافه منتجات الفاتوره وتفاصيلها
            //    for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
            //    {
            //        order.add_order_details(Convert.ToInt32(txtorderid.Text), Convert.ToInt32(dgvproducts.Rows[i].Cells[0].Value),
            //            Convert.ToInt32(dgvproducts.Rows[i].Cells[3].Value), dgvproducts.Rows[i].Cells[2].Value.ToString(),
            //           Convert.ToDouble(dgvproducts.Rows[i].Cells[4].Value), dgvproducts.Rows[i].Cells[5].Value.ToString(), dgvproducts.Rows[i].Cells[6].Value.ToString(),
            //            txtmsdd.Text, txtmtbki.Text);
            //    }

            //}
            //اضافه معلومات الفتوره
            order.ad_order(Convert.ToInt32(txtorderid.Text), dateTimePicker1.Value, Convert.ToInt32(txtcstid.Text), txtsaleman.Text);
            //عملت جدول جديد عشان اضافة معلومات الفاتورة بالاضافة للمسدد والمتبقي
            if (bunifuiOSSwitch1.Value==true && !string.IsNullOrEmpty(combo_mndoob.Text))
            {
                order.add_to_new_orders(Convert.ToInt32(txtorderid.Text), dateTimePicker2.Text,
                 Convert.ToInt32(txtcstid.Text), txtmsdd.Text, txtmtbki.Text, txt_total_after_5sm.Text,
                 txtmksb.Text, Convert.ToInt32(combo_mndoob.SelectedValue),Convert.ToDouble(txt_transport.Text),txt_notes.Text); 
            }
            else
            {
                order.add_to_new_orders(Convert.ToInt32(txtorderid.Text), dateTimePicker2.Text,
                Convert.ToInt32(txtcstid.Text), txtmsdd.Text, txtmtbki.Text, txt_total_after_5sm.Text,
                txtmksb.Text, 0, Convert.ToDouble(txt_transport.Text), txt_notes.Text);
            }
            //اضافه منتجات الفاتوره وتفاصيلها
            for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
            {
                string lineSerials = null;
                if (dgvproducts.Rows[i].Cells.Count > 7 && dgvproducts.Rows[i].Cells[7].Value != null && dgvproducts.Rows[i].Cells[7].Value != DBNull.Value)
                    lineSerials = dgvproducts.Rows[i].Cells[7].Value.ToString();
                order.add_order_details(Convert.ToInt32(txtorderid.Text), Convert.ToInt32(dgvproducts.Rows[i].Cells[0].Value),
                    Convert.ToInt32(dgvproducts.Rows[i].Cells[3].Value), dgvproducts.Rows[i].Cells[2].Value.ToString(),
                    Convert.ToDouble(dgvproducts.Rows[i].Cells[4].Value), dgvproducts.Rows[i].Cells[5].Value.ToString(), dgvproducts.Rows[i].Cells[6].Value.ToString(),
                    txtmsdd.Text, txtmtbki.Text, lineSerials);
            }
            MessageBox.Show("تم حفظ البيع بنجاح", "عمليه الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cleardata();
            txtmksb.Clear();
            frm_main.getmainform.dataGridView1.DataSource = order.search_new_orders_bydate(DateTime.Today.ToShortDateString());
            txt_serial.Clear();

        }

        private void txtmsdd_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonamel.Checked == true)
            {
                if (txtmsdd.Text == "")
                {
                    txtmsdd.Text = "0";
                }
                if (txtmg.Text == "")
                {
                    txtmg.Text = "0";
                }
                if (txt_total_after_5sm.Text == "")
                {
                    txt_total_after_5sm.Text = txtmg.Text;
                }
                txtmtbki.Text = (Convert.ToDouble(txt_total_after_5sm.Text) - Convert.ToDouble(txtmsdd.Text)).ToString();
            }
        }

        private void txtqte_Validated(object sender, EventArgs e)
        {

        }

        private void txtnme_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnprnt_Click(object sender, EventArgs e)
        {
             ////get the last order
             // this.Cursor = Cursors.WaitCursor;
             // int order_id = Convert.ToInt32(order.get_last_order_forprint().Rows[0][0]);
             // RPT.rpt_orders report = new RPT.rpt_orders();
             // RPT.frm_rpt_product frm = new RPT.frm_rpt_product();
             // report.SetDataSource(order.getorderdetails(order_id));
             // frm.crystalReportViewer1.ReportSource = report;
             // frm.ShowDialog();
             // this.Cursor = Cursors.Default;
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                dgvproducts.Rows.RemoveAt(dgvproducts.CurrentRow.Index);
                dataGridView1.Rows.RemoveAt(dgvproducts.CurrentRow.Index);

            }
            catch (Exception)
            {

            }
        }

        private void radioButton2not3mel_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2not3mel.Checked==true)
            {
                
               txtcstadrs.Text = "بيع نقدي";
                txtcstnme.Text = "بيع نقدي";
                txtcstpho.Text = "0";
                txtcstid.Text = "1";
                
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }

        private void txtds_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonamel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonamel_Click(object sender, EventArgs e)
        {



            ///////////////////////////////////////////
                
            double max;
            frm_cstmrs_list frm = new frm_cstmrs_list();
            try
            {
                frm.ShowDialog();

            }
            catch (Exception)
            {
                
                
            }
            ///////////////////////////////////////////////calc 7sab sabek
            //
            object some = cstmr.get_all_cstmr_pays(Convert.ToInt32(frm.dgvcstmrs.CurrentRow.Cells[0].Value.ToString())).Compute("Sum(المدفوع)", string.Empty);
            double previous_pays = 0;
            if (!string.IsNullOrEmpty(some.ToString()))
            {
                previous_pays = Convert.ToDouble(some);
            }
            //
            frm_mwrd_pays frm_false = new frm_mwrd_pays();
            frm_false.dgv_mdfo3at.DataSource = cstmr.get_all_cstmr_pays(Convert.ToInt32(frm.dgvcstmrs.CurrentRow.Cells[0].Value));
            //
            object some_msdd_when_create = order.get_cstmr_orders(frm.dgvcstmrs.CurrentRow.Cells[0].Value.ToString()).Compute("Sum([المبلغ المسدد])", string.Empty);
            double msdd_when_create = 0;
            if (!string.IsNullOrEmpty(some_msdd_when_create.ToString()))
            {
                msdd_when_create = Convert.ToDouble(some_msdd_when_create);
            }
            //
            double all_msdd = msdd_when_create + previous_pays;

            double hand_written_rseed = (from DataGridViewRow row in frm_false.dgv_mdfo3at.Rows
                                         where row.Cells[3].FormattedValue.ToString() == "0"
                                         select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum();
            //
            object some_total_mrtg3 = cstmr.get_all_fwareer_mrtg3_for_cstmr(Convert.ToInt32(frm.dgvcstmrs.CurrentRow.Cells[0].Value)).Compute("Sum([اجمالي الفاتورة])", string.Empty);
            double total_mrtg3 = 0;
            if (!string.IsNullOrEmpty(some_total_mrtg3.ToString()))
            {
                total_mrtg3 = Convert.ToDouble(some_total_mrtg3);
            }
            //
            object some_total_mbe3at = order.get_cstmr_orders(frm.dgvcstmrs.CurrentRow.Cells[0].Value.ToString()).Compute("Sum([اجمالي الفاتورة])", string.Empty);
            double total_mbe3at = 0;
            if (!string.IsNullOrEmpty(some_total_mbe3at.ToString()))
            {
                total_mbe3at = Convert.ToDouble(some_total_mbe3at);
            }
            double hsab_sabk = total_mbe3at + hand_written_rseed - total_mrtg3 - all_msdd ;
            //
            ///////////////////////////////////////////////////////////////////////////

            if (!string.IsNullOrEmpty(cstmr.get_max_for_cstmr(Convert.ToInt32(frm.dgvcstmrs.CurrentRow.Cells[0].Value)).Rows[0][0].ToString()))
	        {
		        max=Convert.ToDouble(cstmr.get_max_for_cstmr(Convert.ToInt32(frm.dgvcstmrs.CurrentRow.Cells[0].Value)).Rows[0][0]);
	        }
            else
	        {
		        max=1000000000;
	        }
            

                if (hsab_sabk >=max)
                {
                    MessageBox.Show(" لا يمكن اختيار هذا العميل نظراً لأن حسابه السابق تجاوز "+max.ToString(), "برجاء سداد الحساب السابق", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            



            this.txtcstid.Text = frm.dgvcstmrs.CurrentRow.Cells[0].Value.ToString();
            this.txtcstnme.Text = frm.dgvcstmrs.CurrentRow.Cells[1].Value.ToString();
            this.txtcstpho.Text = frm.dgvcstmrs.CurrentRow.Cells[2].Value.ToString();
            this.txtcstadrs.Text = frm.dgvcstmrs.CurrentRow.Cells[3].Value.ToString();
           

            //
            this.txt_rseed_sabek.Text = (total_mbe3at + hand_written_rseed - total_mrtg3 - all_msdd).ToString();

            //this.txt_rseed_sabek.Text = cstmr.get_all_7sab_sabk(Convert.ToInt32(frm.dgvcstmrs.CurrentRow.Cells[0].Value)).Rows[0][0].ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product_id = Convert.ToInt32(comboBox2.SelectedValue);
            txtid.Text=product_id.ToString();
            txtnme.Text=product.get_single_product(product_id).Rows[0][0].ToString();
            txtpmsthlk.Text = product.get_single_product(product_id).Rows[0][5].ToString();
            txt_price_shraa.Text = product.get_single_product(product_id).Rows[0][2].ToString();
            if (radioButtonamel.Checked == true)
            {
                txtprice.Text = product.get_single_product(product_id).Rows[0][3].ToString();

            }
            else if (radioButton2not3mel.Checked == true)
            {
                txtprice.Text = product.get_single_product(product_id).Rows[0][4].ToString();

            }
            txtprice.Focus();
            txt_rseed.Text = product.get_single_product(product_id).Rows[0][1].ToString();

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != string.Empty)
            {
               // comboBox2.DataSource = product.searchproduct(comboBox2.Text);
                comboBox2.DisplayMember = "اسم الصنف";
                comboBox2.ValueMember = "id";

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value;
        }

        private void txt_total_5sm_KeyUp(object sender, KeyEventArgs e)
        {

            calctotalprice_afterTotal_5sm();
        }

        private void txt_total_5sm_TextChanged(object sender, EventArgs e)
        {
            calctotalprice_afterTotal_5sm();
        }

        private void txt_total_5sm_KeyUp_1(object sender, KeyEventArgs e)
        {
            calctotalprice_afterTotal_5sm();
        }

        private void txt_total_5sm_Leave(object sender, EventArgs e)
        {
            calctotalprice_afterTotal_5sm();
        }

        private void txt_total_5sm_TextChanged_1(object sender, EventArgs e)
        {
            if (radioButton_nesba.Checked==true||radioButton_nesba.Checked==false&&radioButton_number.Checked==false)
            {
                calctotalprice_afterTotal_5sm();
            }
            else
            {
                calcTotalPriceAfter_number_5sm();
            }
            txt_transport.Text = "0";
            
        }

        private void getallproductsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtmg_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_transport.Text))
            {
                txt_transport.Text = "0";
            }
            if (txt_total_5sm.Text=="0"|| string.IsNullOrEmpty(txt_total_5sm.Text))
            {
                txt_total_after_5sm.Text = txtmg.Text;
            }

        }

        private void txt_total_5sm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txtmsdd.Focus();
            }
        }

        private void txtmsdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnnew.Focus();
            }
        }

        private void btnnew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsve.Focus();
            }
        }

        private void combo_mndoob_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_mndb_phon.Text = combo_mndoob.SelectedValue.ToString();
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value==true)
            {
                label25.Text = "يوجد مندوب";
                label25.BackColor = Color.LightGreen;
                txt_mndb_phon.Enabled = true;
                combo_mndoob.Enabled = true;
            }
            else
            {
                label25.Text = "لا يوجد مندوب";
                label25.BackColor = Color.Coral;
                txt_mndb_phon.Enabled = false;
                combo_mndoob.Enabled = false;
                txt_mndb_phon.Text = "";
                combo_mndoob.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_add_cstmr frm = new frm_add_cstmr();
            frm.ShowDialog();
            if (frm.status == "added")
            {
            this.txtcstnme.Text = frm.txtcstnme.Text;
            try
            {
                this.txtcstid.Text = order.get_cstmr_id(frm.txtcstnme.Text).Rows[0][0].ToString();

            }
            catch (Exception)
            {
                
                
            }
            this.txtcstpho.Text = frm.txtcstpho.Text;
            this.txtcstadrs.Text = frm.txtcstadrs.Text;
            this.txt_rseed_sabek.Text = "0";
            this.radioButtonamel.Checked = true;
            }


        }

        private void txt_transport_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_transport.Text))
            {
                txt_transport.Text = "0";
            }
            double xx=0;
            for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
            {
                xx += Convert.ToDouble(dgvproducts.Rows[i].Cells[2].Value) * Convert.ToInt32(dgvproducts.Rows[i].Cells[3].Value);                
            }

            txtmg.Text = (Convert.ToDouble(txt_transport.Text) + xx).ToString();

            

            if (radioButton_nesba.Checked == true || radioButton_nesba.Checked == false && radioButton_number.Checked == false)
            {
                calctotalprice_afterTotal_5sm();
                txt_total_after_5sm.Text = (Convert.ToDouble(txt_transport.Text) + Convert.ToDouble(txt_total_after_5sm.Text)).ToString();
            }
            else
            {
                calcTotalPriceAfter_number_5sm();
                //txt_total_after_5sm.Text = (Convert.ToDouble(txt_transport.Text) + Convert.ToDouble(txt_total_after_5sm.Text)).ToString();

            }
            if (txt_total_5sm.Text == "0" || string.IsNullOrEmpty(txt_total_5sm.Text))
            {
                txt_total_after_5sm.Text = txtmg.Text;
            }
        }

        private void txt_total_after_5sm_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_nesba_CheckedChanged(object sender, EventArgs e)
        {
            txt_total_5sm.Text = "0";
        }

        private void radioButton_number_CheckedChanged(object sender, EventArgs e)
        {
            txt_total_5sm.Text = "0";

        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (radioButton_nesba.Checked == true || radioButton_nesba.Checked == false && radioButton_number.Checked == false)
            {
                mksab = 0;
                for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
                {
                    mksab += (Convert.ToDouble(dgvproducts.Rows[i].Cells[6].Value) - (Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value)) * Convert.ToDouble(dgvproducts.Rows[i].Cells[3].Value));
                }
                txtmksb.Text = mksab.ToString();

            }
            else
            {
                mksab = 0;
                for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
                {
                    mksab += (Convert.ToDouble(dgvproducts.Rows[i].Cells[6].Value) - (Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value)) * Convert.ToDouble(dgvproducts.Rows[i].Cells[3].Value));
                }
                txtmksb.Text = (mksab - Convert.ToDouble(txt_total_5sm.Text)).ToString();

            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frm_orders_list frmmm = new frm_orders_list();
            frm_view_order frm = new frm_view_order();
            var id_order = order.get_last_order_forprint().Rows[0][0].ToString();

            DataGridViewRow ro = frmmm.dgvorders.Rows[frmmm.dgvorders.Rows.Count - 2];

            frmmm.dgvorders.ReadOnly = true;

            //string id_order = this.dgvorders.CurrentRow.Cells[0].Value.ToString();
            frm.dataGridView8_cstmr_id.DataSource = order.get_cstmr_id(ro.Cells[1].Value.ToString());
            frm.txtordr_id.Text = id_order;
            frm.txtdate.Text = ro.Cells[2].Value.ToString();
            frm.txtcstmr_name.Text = ro.Cells[1].Value.ToString();
            frm.txtbaya.Text = ro.Cells[3].Value.ToString();
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

        private void button7_Click(object sender, EventArgs e)
        {
            frm_orders_list frm = new frm_orders_list();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm_cstmrs frm = new frm_cstmrs();
            frm.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            frm_expenses frm = new frm_expenses();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frm_mony_reports frm = new frm_mony_reports();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frm_cstmr_report frm = new frm_cstmr_report();
            frm.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void txt_serial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || string.IsNullOrEmpty(txt_serial.Text)) return;

            var prd = product.get_prd_by_serial(txt_serial.Text);
            if (prd.Rows.Count == 0)
            {
                MessageBox.Show("لم يتم ادراج هذا الصنف من قبل ", "صنف غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_serial.Clear();
                txt_serial.Focus();
                return;
            }

            int serialNumberMode = 0;
            if (prd.Columns.Count > 7 && prd.Rows[0][7] != null && prd.Rows[0][7] != DBNull.Value)
                int.TryParse(prd.Rows[0][15].ToString(), out serialNumberMode);

            txt_price_shraa.Text = prd.Rows[0][3].ToString();
            if (radioButtonamel.Checked == true)
                txtprice.Text = prd.Rows[0][4].ToString();
            else if (radioButton2not3mel.Checked == true)
                txtprice.Text = prd.Rows[0][5].ToString();

            txtnme.Text = prd.Rows[0][1].ToString();
            txtpmsthlk.Text = prd.Rows[0][6].ToString();
            txtid.Text = prd.Rows[0][0].ToString();
            txtqte.Text = "1";
            txtds.Text = "0";
            calctotalprice();
            txt_total_5sm.Text = "0";
            calctotalprice_afterTotal_5sm();

            string scannedSerial = txt_serial.Text.Trim();

            if (serialNumberMode == 1) // OnePerPiece: validate serial
            {
                if (prdSerials.IsSerialSold(scannedSerial))
                {
                    MessageBox.Show("هذا السيريال تم بيعه مسبقاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_serial.Clear();
                    txt_serial.Focus();
                    return;
                }
                var availableDt = prdSerials.GetAvailableSerialsForProduct(Convert.ToInt32(txtid.Text));
                bool serialFound = false;
                if (availableDt != null)
                    foreach (DataRow row in availableDt.Rows)
                        if (row["serial"] != null && row["serial"].ToString().Trim().Equals(scannedSerial, StringComparison.OrdinalIgnoreCase))
                        { serialFound = true; break; }
                if (!serialFound)
                {
                    MessageBox.Show("هذا السيريال غير متاح لهذا الصنف (تم بيعه أو غير مسجل)", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_serial.Clear();
                    txt_serial.Focus();
                    return;
                }
                for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
                {
                    var serialsCell = dgvproducts.Rows[i].Cells.Count > 7 ? dgvproducts.Rows[i].Cells[7].Value : null;
                    if (serialsCell != null && !string.IsNullOrEmpty(serialsCell.ToString()))
                    {
                        var serials = serialsCell.ToString().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        if (serials.Any(s => s.Trim() == scannedSerial))
                        {
                            MessageBox.Show("تم مسح هذا السيريال مسبقاً في هذه الفاتورة", "سيريال مكرر", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_serial.Clear();
                            txt_serial.Focus();
                            return;
                        }
                    }
                }
            }

            for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
            {
                if (dgvproducts.Rows[i].Cells[0].Value != null && dgvproducts.Rows[i].Cells[0].Value.ToString() == txtid.Text)
                {
                    if (serialNumberMode == 1) // OnePerPiece: one scan = one piece, append serial
                    {
                        var serialsCell = dgvproducts.Rows[i].Cells.Count > 7 ? dgvproducts.Rows[i].Cells[7].Value : null;
                        string existingSerials = (serialsCell != null && serialsCell != DBNull.Value) ? serialsCell.ToString() : "";
                        dgvproducts.Rows[i].Cells[7].Value = string.IsNullOrEmpty(existingSerials) ? scannedSerial : existingSerials + "," + scannedSerial;
                    }
                    dgvproducts.Rows[i].Cells[3].Value = Convert.ToInt32(dgvproducts.Rows[i].Cells[3].Value) + 1;
                    dgvproducts.Rows[i].Cells[6].Value = Convert.ToDouble(dgvproducts.Rows[i].Cells[6].Value) + Convert.ToDouble(txtprice.Text);
                    txtmg.Text = (from DataGridViewRow row in dgvproducts.Rows
                                  where row.Cells[6].FormattedValue.ToString() != string.Empty
                                  select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
                    if (radioButton2not3mel.Checked == true)
                    {
                        txtmsdd.Text = txt_total_after_5sm.Text;
                        txtmtbki.Text = "0";
                    }
                    else if (radioButtonamel.Checked == true)
                        txtmsdd.Focus();
                    txt_serial.Clear();
                    clearboxes();
                    txt_serial.Focus();
                    return;
                }
            }
            if (radio_raseed.Checked == true || radio_not_raseed.Checked == false && radio_raseed.Checked == false)
            {
                if (order.verifyqte(Convert.ToInt32(txtid.Text), Convert.ToInt32(txtqte.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("الكميه المدخله لهذا الصنف غير متوفره ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_serial.Clear();
                    txt_serial.Focus();
                    return;
                }
            }

            DataRow r = dt.NewRow();
            r[0] = txtid.Text;
            r[1] = txtnme.Text;
            r[2] = txtprice.Text;
            r[3] = txtqte.Text;
            r[4] = txtds.Text;
            r[5] = txtpmsthlk.Text;
            r[6] = txttp.Text;
            r[7] = scannedSerial;
            dt.Rows.Add(r);

            DataRow r2 = dt2.NewRow();
            r2[0] = txt_price_shraa.Text;
            dt2.Rows.Add(r2);
            dataGridView1.DataSource = dt2;
            if (type == "save new")
                dgvproducts.DataSource = dt;
            else
                dgvproducts.Rows.Add(dt);
            resizedgv();
            clearboxes();

            txtmg.Text = (from DataGridViewRow row in dgvproducts.Rows
                          where row.Cells[6].FormattedValue.ToString() != string.Empty
                          select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            if (radioButton2not3mel.Checked == true)
            {
                txtmsdd.Text = txt_total_after_5sm.Text;
                txtmtbki.Text = "0";
            }
            else if (radioButtonamel.Checked == true)
                txtmsdd.Focus();
            comboBox2.Focus();

            txt_serial.Clear();
            txt_serial.Focus();
        }
    }
    }

