using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.PL
{
    public partial class frm_from_mwrdeen : Form
    {
        private static frm_from_mwrdeen frm;
        static void frm_formclesed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static frm_from_mwrdeen getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new frm_from_mwrdeen();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclesed);
                }
                return frm;
            }
        }


        BL.cls_mwrdeen mwrd = new BL.cls_mwrdeen();
        BL.cls_products prd = new BL.cls_products();
        BL.cls_purchases purch = new BL.cls_purchases();
        public frm_from_mwrdeen()
        {
            InitializeComponent();
            dataGridView_fwater.DataSource = mwrd.get_all_fwateer_mwrd(txtmwrd_nme.Text);
            if (frm == null)
            {
                frm = this;
            }
        }

        private void frm_from_mwrdeen_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mwrd_name = txtmwrd_nme.Text;
            frm_add_fwateer_mwrd frm = new frm_add_fwateer_mwrd();
            frm.txtmwrd_nme.Text = mwrd_name;

            frm.ShowDialog();
            refresh_frm();
        }

        private void dataGridView_fwater_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_asnaf.DataSource = purch.get_all_fatora_mwrd_purchases(dataGridView_fwater.CurrentRow.Cells[0].Value.ToString());
                dgv_mrtg3_mshtriat.DataSource = prd.get_mrtg3_mshtriat_for_single_fatora(Convert.ToInt32(dataGridView_fwater.CurrentRow.Cells[0].Value));

            }
            catch (Exception)
            {
                
                throw;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذه الفاتورة؟؟\nبالتالي سوف يحذف الاصناف المتصله بها ","عملية الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                mwrd.delete_fwateer_mwrd(Convert.ToInt32(this.dataGridView_fwater.CurrentRow.Cells[0].Value));
                dataGridView_fwater.DataSource = mwrd.get_all_fwateer_mwrd(txtmwrd_nme.Text);
                frm.txttotal.Text = (from DataGridViewRow row in frm.dataGridView_fwater.Rows
                                     where row.Cells[3].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
                frm.txtmsdd.Text = (from DataGridViewRow row in frm.dataGridView_fwater.Rows
                                    where row.Cells[4].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                frm.txtmtpakii.Text = (from DataGridViewRow row in frm.dataGridView_fwater.Rows
                                       where row.Cells[5].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
                dataGridView_asnaf.DataSource = null;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_edit_fweer_mwrd frm = new frm_edit_fweer_mwrd();
            frm.txtid.Text = this.dataGridView_fwater.CurrentRow.Cells[0].Value.ToString();
            frm.txtnme.Text = this.dataGridView_fwater.CurrentRow.Cells[1].Value.ToString();
            frm.txtdate.Text = this.dataGridView_fwater.CurrentRow.Cells[2].Value.ToString();
            frm.txtvalye.Text = this.dataGridView_fwater.CurrentRow.Cells[3].Value.ToString();
            frm.txtmsdd.Text = this.dataGridView_fwater.CurrentRow.Cells[4].Value.ToString();
            frm.txtmtbaki.Text = this.dataGridView_fwater.CurrentRow.Cells[5].Value.ToString();
            frm.ShowDialog();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            refresh_frm();
        }
        public void refresh_frm()
        {
            dataGridView_fwater.DataSource = mwrd.get_all_fwateer_mwrd(txtmwrd_nme.Text);
            txttotal.Text = (from DataGridViewRow row in dataGridView_fwater.Rows
                             where row.Cells[3].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            double msdd_when_create = (from DataGridViewRow row in dataGridView_fwater.Rows
                            where row.Cells[4].FormattedValue.ToString() != string.Empty
                            select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum();
            
            double mtbaki_sum = (from DataGridViewRow row in dataGridView_fwater.Rows
                                   where row.Cells[5].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum();
            dgv_all_mrtg3.DataSource = prd.get_all_mrtg3_mshtriat_for_mwrd(txtmwrd_nme.Text);
            txt_mrtg3.Text = (from DataGridViewRow row in dgv_all_mrtg3.Rows
                              where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[3].FormattedValue) * Convert.ToInt32(row.Cells[2].FormattedValue)).Sum().ToString();
            object some=mwrd.get_all_mwrd_pays(Convert.ToInt32(this.label_id.Text)).Compute("Sum(المدفوع)",string.Empty);
            double previous_pays = 0;
            if (!string.IsNullOrEmpty(some.ToString()))
            {
                previous_pays = Convert.ToDouble(some);
            }

            txtmsdd.Text = (msdd_when_create + previous_pays).ToString();

            frm_mwrd_pays frm = new frm_mwrd_pays();
            frm.dgv_mdfo3at.DataSource = mwrd.get_all_mwrd_pays(Convert.ToInt32(this.label_id.Text));
            
            double hand_written_rseed = (from DataGridViewRow row in frm.dgv_mdfo3at.Rows
                                         where row.Cells[3].FormattedValue.ToString() == "0"
                                         select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum();


            txtmtpakii.Text = ((Convert.ToDouble(txttotal.Text) + hand_written_rseed - Convert.ToDouble(txt_mrtg3.Text))
                - Convert.ToDouble(txtmsdd.Text)).ToString();
           // txtmtpakii.Text = (mtbaki_sum - Convert.ToDouble(frm.txt_mrtg3.Text)).ToString();
            txt_rseed_first.Text = hand_written_rseed.ToString();

 
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string mwrd_nme = this.txtmwrd_nme.Text;
            frm_add_product frm = new frm_add_product("");
            frm.state = "add_product_with_mwrd_frm_from_mwrdeen";
            frm.mwrdnme = this.txtmwrd_nme.Text;
            frm.order_id_mwrd = this.dataGridView_fwater.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView_asnaf.DataSource = mwrd.get_all_fatora_mwrd_product(dataGridView_fwater.CurrentRow.Cells[0].Value.ToString());

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الصنف", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Int32 selectedRowCount =
               dataGridView_asnaf.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {

                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        purch.delete_purchase(Convert.ToInt32(dataGridView_asnaf.Rows[dataGridView_asnaf.SelectedRows[i].Index].Cells[0].Value));
                          
                        mwrd.edit_fwateer_mwrd(Convert.ToInt32(dataGridView_fwater.CurrentRow.Cells[0].Value),txtmwrd_nme.Text,dataGridView_fwater.CurrentRow.Cells[2].Value.ToString(),
                   (Convert.ToDouble(dataGridView_fwater.CurrentRow.Cells[3].Value)-(Convert.ToDouble(dataGridView_asnaf.Rows[dataGridView_asnaf.SelectedRows[i].Index].Cells[7].Value))).ToString(),
                        dataGridView_fwater.CurrentRow.Cells[4].Value.ToString(),(Convert.ToDouble(dataGridView_fwater.CurrentRow.Cells[5].Value)-(Convert.ToDouble(dataGridView_asnaf.Rows[dataGridView_asnaf.SelectedRows[i].Index].Cells[7].Value))).ToString());

                    }
                    //prd.deleteproduct(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                }
                MessageBox.Show("تمت عمليه الحذف بنجاح", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView_asnaf.DataSource = purch.get_all_fatora_mwrd_purchases(dataGridView_fwater.CurrentRow.Cells[0].Value.ToString());
                dataGridView_fwater.DataSource = mwrd.get_all_fwateer_mwrd(txtmwrd_nme.Text);
                //mwrd.edit_fwateer_mwrd(Convert.ToInt32(dataGridView_fwater.CurrentRow.Cells[0].Value),txtmwrd_nme.Text,dataGridView_fwater.CurrentRow.Cells[2].Value.ToString(),
                //   Convert.ToDouble(dataGridView_fwater.CurrentRow.Cells[3].Value)+,dataGridView_fwater.CurrentRow.Cells[4].Value.ToString(),Convert.ToDouble(dataGridView_fwater.CurrentRow.Cells[5].Value));


            }
            else
            {
                MessageBox.Show("تم الغاء عمليه الحذف ", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public string id;
        private void button6_Click(object sender, EventArgs e)
        {
            id = this.dataGridView_asnaf.CurrentRow.Cells[0].Value.ToString();
            frm_add_product frm = new frm_add_product(id);
            frm.state = "edit_product_with_mwrd_frm_from_mwrdeen";
            frm.txtnme.Text = this.dataGridView_asnaf.CurrentRow.Cells[1].Value.ToString();
            frm.txtqte.Text = this.dataGridView_asnaf.CurrentRow.Cells[2].Value.ToString();
            frm.txtpshr.Text = this.dataGridView_asnaf.CurrentRow.Cells[3].Value.ToString();
            frm.txtpg.Text = this.dataGridView_asnaf.CurrentRow.Cells[4].Value.ToString();
            frm.txtpb.Text = this.dataGridView_asnaf.CurrentRow.Cells[5].Value.ToString();
            frm.txtmsthlk.Text = this.dataGridView_asnaf.CurrentRow.Cells[6].Value.ToString();
            frm.txttmd.Text = this.dataGridView_asnaf.CurrentRow.Cells[7].Value.ToString();
            frm.Text = "تحديث بيانات الصنف:" + this.dataGridView_asnaf.CurrentRow.Cells[1].Value.ToString();
            frm.btnok.Text = "تحديث";
            frm.comboBox1.Text = this.dataGridView_asnaf.CurrentRow.Cells[8].Value.ToString();

            byte[] image = (byte[])prd.get_image_product(this.dataGridView_asnaf.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pbox.Image = Image.FromStream(ms);

            frm.state = "update";
            frm.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_asnaf_DoubleClick(object sender, EventArgs e)
        {
            id = this.dataGridView_asnaf.CurrentRow.Cells[0].Value.ToString();
            frm_add_product frm = new frm_add_product(id);
            frm.txtnme.Text = this.dataGridView_asnaf.CurrentRow.Cells[1].Value.ToString();
            frm.txtqte.Text = this.dataGridView_asnaf.CurrentRow.Cells[2].Value.ToString();
            frm.txtpshr.Text = this.dataGridView_asnaf.CurrentRow.Cells[3].Value.ToString();
            frm.txtpg.Text = this.dataGridView_asnaf.CurrentRow.Cells[4].Value.ToString();
            frm.txtpb.Text = this.dataGridView_asnaf.CurrentRow.Cells[5].Value.ToString();
            frm.txtmsthlk.Text = this.dataGridView_asnaf.CurrentRow.Cells[6].Value.ToString();
            frm.txttmd.Text = this.dataGridView_asnaf.CurrentRow.Cells[7].Value.ToString();
            frm.Text = "تحديث بيانات الصنف:" + this.dataGridView_asnaf.CurrentRow.Cells[1].Value.ToString();
            frm.btnok.Text = "تحديث";
            frm.comboBox1.Text = this.dataGridView_asnaf.CurrentRow.Cells[8].Value.ToString();

            byte[] image = (byte[])prd.get_image_product(this.dataGridView_asnaf.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pbox.Image = Image.FromStream(ms);

            frm.state = "update";
            frm.ShowDialog();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frm_mwrd_pays frm = new frm_mwrd_pays();
            frm.dgv_fwateer.DataSource = mwrd.get_all_fwateer_mwrd(txtmwrd_nme.Text);
            frm.dgv_mdfo3at.DataSource = mwrd.get_all_mwrd_pays(Convert.ToInt32(this.label_id.Text));
            frm.label_id.Text = this.label_id.Text;
            frm.label_nme.Text = txtmwrd_nme.Text;
            frm.label_total_mdfo3.Text = (from DataGridViewRow row in frm.dgv_mdfo3at.Rows
                                          where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[6].FormattedValue.ToString() != "خصم مكتسب"
                                          select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            double hand_written_rseed = (from DataGridViewRow row in frm.dgv_mdfo3at.Rows
                                         where row.Cells[3].FormattedValue.ToString() == "0"
                                         select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum();

            //double previous_mtbaki = Convert.ToDouble(txtmtpakii.Text);
           // double final_first_rseed = (hand_written_rseed + previous_mtbaki) - (Convert.ToDouble(frm.label_total_mdfo3.Text));
            //double previous_mtbaki = (from DataGridViewRow row in dataGridView1.Rows
            //                          where row.Cells[3].FormattedValue.ToString() != string.Empty
            //                          select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum();
           // frm.label_first_rseed.Text = (final_first_rseed).ToString();
            frm.label_first_rseed.Text = txtmtpakii.Text;
            frm.ShowDialog();
            refresh_frm();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            i = -1;
            ii = -1;
            mslsl = 0;
            page_num = 0;
        }
        public int i = -1;
        public int ii = -1;
        public int mslsl = 0;
        public int page_num = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            i++;
            ii++;
            page_num++;

              Font f = new Font("Arial", 16, FontStyle.Bold);
            Font v = new Font("Arial", 36, FontStyle.Bold);
            Font n = new Font("Arial", 14, FontStyle.Regular);
            Font col_header = new Font("Arial", 16, FontStyle.Underline);
            int txt_hight = 35;
            int txt_width =350;

            float marg = 25;
            string cstmrid = "كود المورد : " + label_id.Text;
            string cstname = "اسم المورد: " + txtmwrd_nme.Text;
            string datee = "التاريخ : " + DateTime.Now.ToShortDateString();
            //////
            string first_rseed = "رصيد أول : " + txt_rseed_first.Text;
            string total_mshtriat = "اجمالي مشتريات : " + txttotal.Text;
            string mrtg3 = "اجمالي مرتجع : " + txt_mrtg3.Text;
            string msdd = "مسدد : " + txtmsdd.Text;
            string mtbaki = "متبقي : " + txtmtpakii.Text;

            SizeF FpntSizeid = e.Graphics.MeasureString(cstmrid, f);
            SizeF FpntSizenme = e.Graphics.MeasureString(cstname, f);
            SizeF fontsizegate = e.Graphics.MeasureString(datee, f);
            ////////
            SizeF FontSizefirst_rseed = e.Graphics.MeasureString(first_rseed, f);
            SizeF FontSizetotal_mshtriat = e.Graphics.MeasureString(total_mshtriat, f);
            SizeF fontsizemrtg3 = e.Graphics.MeasureString(mrtg3, f);
            SizeF FontSizemsdd = e.Graphics.MeasureString(msdd, f);
            SizeF FontSizmtbaki = e.Graphics.MeasureString(mtbaki, f);


            //الحاجات اللي في اخر الفاتورة
            e.Graphics.DrawLine(Pens.DarkSeaGreen, marg * 2, e.PageBounds.Height - 105, e.PageBounds.Width - (marg * 2), e.PageBounds.Height - 105);
            e.Graphics.DrawString(first_rseed, f, Brushes.Black, e.PageBounds.Width - FontSizefirst_rseed.Width-(marg*2), e.PageBounds.Height - 100);
            e.Graphics.DrawString(total_mshtriat, f, Brushes.Black, e.PageBounds.Width - FontSizetotal_mshtriat.Width - (marg * 2), e.PageBounds.Height - 75);
            e.Graphics.DrawString(mrtg3, f, Brushes.Black, e.PageBounds.Width - fontsizemrtg3.Width - (marg * 2), e.PageBounds.Height - 50);
            e.Graphics.DrawString(msdd, f, Brushes.Blue, (e.PageBounds.Width / 2) - FontSizemsdd.Width - (marg * 2), e.PageBounds.Height - 90);
            e.Graphics.DrawString(mtbaki, f, Brushes.Blue, (e.PageBounds.Width / 2) - FontSizmtbaki.Width - (marg * 2), e.PageBounds.Height - 60);
            e.Graphics.FillRectangle(Brushes.WhiteSmoke, new Rectangle(0, e.PageBounds.Height - 30, (int)(e.PageBounds.Width), e.PageBounds.Bottom));
            e.Graphics.DrawString("صفحة : " + page_num, f, Brushes.DarkBlue, marg, e.PageBounds.Height - 30);
            e.Graphics.DrawString(Program.FooterAllReportsText, n, Brushes.Black, (e.PageBounds.Width / 6) + 20, e.PageBounds.Height - 30);



            e.Graphics.DrawString(Program.company_name, v, Brushes.Blue, 5, 5);
            e.Graphics.DrawString(Program.details_1, f, Brushes.BlueViolet, marg, marg + txt_hight);
            e.Graphics.DrawString(Program.details_2, f, Brushes.BlueViolet, marg, marg + (txt_hight * 2) - 15);
            e.Graphics.DrawString(Program.telephon_1, f, Brushes.Black, marg, marg + (txt_hight * 3) - 30);
            //e.Graphics.DrawString(" للأدوات الصحية ", f, Brushes.BlueViolet, marg, marg + txt_hight);
            //e.Graphics.DrawString("والمواسير الألمانية وأنظمة المياة", f, Brushes.BlueViolet, marg, marg + (txt_hight * 2)-15);
            //e.Graphics.DrawString("الحاج/مصطفي/01022070794", f, Brushes.Black, marg, marg + (txt_hight * 3)-30);
            e.Graphics.DrawString("تقرير مورد", col_header, Brushes.DarkRed, (e.PageBounds.Width / 2)+10 - 70, marg/2);



            e.Graphics.DrawString(cstmrid, f, Brushes.Blue, (e.PageBounds.Width - FpntSizeid.Width) - marg, marg);
            e.Graphics.DrawString(datee, f, Brushes.Black, (e.PageBounds.Width - fontsizegate.Width) - marg, marg + txt_hight - 10);
            e.Graphics.DrawString(cstname, f, Brushes.Black, (e.PageBounds.Width -FpntSizenme.Width ) - marg, marg + (txt_hight*2)-20);


            float prehights = marg +txt_hight*3;

            ////المستطيل
            //e.Graphics.DrawRectangle(Pens.Black, marg, prehights, e.PageBounds.Width - marg * 2, e.PageBounds.Height - marg * 2 - 30 - prehights);
            float colhight = 45;

            float colwidth1 = 50;
            float colwidth2 = 300 + colwidth1;
            float colwidth3 = 70 + colwidth2;
            float colwidth4 = 50 + colwidth3;
            float colwidth5 = 50 + colwidth4;
            float colwidth6 = 50 + colwidth5;

            e.Graphics.DrawLine(Pens.Black, marg, prehights + colhight, e.PageBounds.Width - marg, prehights + colhight);

            e.Graphics.DrawString("عمليات الشراء", col_header, Brushes.DarkRed, (e.PageBounds.Width / 2) - 70, marg + (txt_hight * 3) - 30);

            ////////////////////////////////////////////
            float rowshight = 55;

            for (; i < dataGridView_fwater.Rows.Count - 1; i++)
            {

                e.Graphics.DrawString((i + 1).ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 20, prehights + 30 + rowshight - 36);


                e.Graphics.DrawString(dataGridView_fwater.Rows[i].Cells[0].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 75, prehights + 30 + rowshight - 4 - 35);
                e.Graphics.DrawString(dataGridView_fwater.Rows[i].Cells[2].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 200, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView_fwater.Rows[i].Cells[3].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 56 - 20, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView_fwater.Rows[i].Cells[4].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 111 - 56, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView_fwater.Rows[i].Cells[5].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 90, prehights + 30 + rowshight - 5 - 35);
               // e.Graphics.DrawString(dataGridView_fwater.Rows[i].Cells[6].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 111 - 56 - 40, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawLine(Pens.Black, marg, prehights + colhight + rowshight - 30, e.PageBounds.Width - marg, prehights + colhight + rowshight - 30);
                rowshight += 30;

                if ((i % 28) == 0 && i != 0)
                {
                    e.HasMorePages = true;
                    break;
                }
            }

            ////////////////////////////////////////////////////////////////////
            //المستطيل
            e.Graphics.DrawRectangle(Pens.Black, marg, prehights, e.PageBounds.Width - marg * 2, rowshight -12);


            e.Graphics.DrawString("م", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 20, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 24, prehights, e.PageBounds.Width - marg * 2 - 24, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("الكود", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 75, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 90, prehights, e.PageBounds.Width - marg * 2 - 90, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("التاريخ", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 200, prehights + 20);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - colwidth2, prehights, e.PageBounds.Width - colwidth2, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("اجمالي", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 56 - 20, prehights + 20);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3, prehights, e.PageBounds.Width - marg * 2 - colwidth3, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("مسدد", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 111 - 56, prehights + 20);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3 - 80, prehights, e.PageBounds.Width - marg * 2 - colwidth3 - 80, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("متبقي", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 90, prehights + 20);


            e.Graphics.DrawString("ملاحظات", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 111 - 56 - 50, prehights + 20);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3 - 200, prehights, e.PageBounds.Width - marg * 2 - colwidth3 - 200, prehights + 30 + rowshight - 5 - 35);




            //////////////////////////////////////////////////////////////////////////////////////////الجدول الثاني
            frm_mwrd_pays frm_false = new frm_mwrd_pays();
            frm_false.dgv_mdfo3at.DataSource = mwrd.get_all_mwrd_pays(Convert.ToInt32(label_id.Text));
            ////////////////////////////////////////////
            float new_rowshight = 55;
            float new_start = rowshight + 155;
            for (; ii < frm_false.dgv_mdfo3at.Rows.Count - 1; ii++)
            {
                
                if (!string.IsNullOrEmpty(frm_false.dgv_mdfo3at.Rows[ii].Cells[3].Value.ToString()))
                {
                    if (Convert.ToDouble(frm_false.dgv_mdfo3at.Rows[ii].Cells[3].Value) > 0)
                    {
                        mslsl++;

                        e.Graphics.DrawString((mslsl).ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 20, new_rowshight + new_start);


                        e.Graphics.DrawString(frm_false.dgv_mdfo3at.Rows[ii].Cells[0].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 75, new_rowshight + new_start);
                        e.Graphics.DrawString(frm_false.dgv_mdfo3at.Rows[ii].Cells[5].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 200, new_rowshight + new_start);
                        e.Graphics.DrawString(frm_false.dgv_mdfo3at.Rows[ii].Cells[2].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 56 - 20, new_rowshight + new_start);
                        e.Graphics.DrawString(frm_false.dgv_mdfo3at.Rows[ii].Cells[4].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 90, new_rowshight + new_start);
                
                        e.Graphics.DrawString(frm_false.dgv_mdfo3at.Rows[ii].Cells[3].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 111 - 56, new_rowshight + new_start);
                        e.Graphics.DrawString(frm_false.dgv_mdfo3at.Rows[ii].Cells[6].Value.ToString(), n, Brushes.Black, marg +5, new_rowshight + new_start);

                        e.Graphics.DrawLine(Pens.Black, marg, new_rowshight + new_start+25, e.PageBounds.Width - marg, new_rowshight + new_start+25);
                        new_rowshight += 30;
                    }
                    else if (Convert.ToDouble(frm_false.dgv_mdfo3at.Rows[ii].Cells[3].Value) < 0)
                    {
                        mslsl++;
                        e.Graphics.DrawString((mslsl).ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 20, new_rowshight + new_start);


                        e.Graphics.DrawString(frm_false.dgv_mdfo3at.Rows[ii].Cells[0].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 75, new_rowshight + new_start);
                        e.Graphics.DrawString(frm_false.dgv_mdfo3at.Rows[ii].Cells[5].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 200, new_rowshight + new_start);
                        e.Graphics.DrawString(frm_false.dgv_mdfo3at.Rows[ii].Cells[2].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 56 - 20, new_rowshight + new_start);
                        e.Graphics.DrawString(frm_false.dgv_mdfo3at.Rows[ii].Cells[4].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 90, new_rowshight + new_start);
                
                        e.Graphics.DrawString((Convert.ToDouble(frm_false.dgv_mdfo3at.Rows[ii].Cells[3].Value) * -1).ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 111 - 56, new_rowshight + new_start);
                        e.Graphics.DrawString("استرجاع من المورد", n, Brushes.Black,  marg +5, new_rowshight + new_start);

                        e.Graphics.DrawLine(Pens.Black, marg, new_rowshight + new_start+25, e.PageBounds.Width - marg, new_rowshight + new_start+25);
                        new_rowshight += 30;
                    }
                }


                if ((ii + dataGridView_fwater.Rows.Count - 1) % 28 == 0)
                {
                    e.HasMorePages = true;
                    break;
                }
            }


            /////////////////////////////////////////////////////////////////////////////////////////////
            e.Graphics.DrawString("عمليات الدفع", col_header, Brushes.DarkRed, (e.PageBounds.Width/2) - 70, rowshight + 135);
            //المستطيل التاني
            e.Graphics.DrawRectangle(Pens.Black, marg, rowshight + 170, e.PageBounds.Width - marg * 2,  new_rowshight-20);

            float line_y2 = rowshight + new_rowshight+150;
            e.Graphics.DrawLine(Pens.Black, marg, rowshight + 210, e.PageBounds.Width - marg, rowshight + 210);


            e.Graphics.DrawString("م", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 20, rowshight + 180);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 24, rowshight + 170, e.PageBounds.Width - marg * 2 - 24, line_y2);


            e.Graphics.DrawString("الكود", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 75, rowshight + 180);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 90, rowshight + 170, e.PageBounds.Width - marg * 2 - 90, line_y2);

            e.Graphics.DrawString("التاريخ", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 200, rowshight + 180);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - colwidth2, rowshight + 170, e.PageBounds.Width - colwidth2, line_y2);

            e.Graphics.DrawString("رصيد أول", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 56 - 20, rowshight + 180);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3, rowshight + 170, e.PageBounds.Width - marg * 2 - colwidth3, line_y2);

            e.Graphics.DrawString("المبلغ", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 111 - 56, rowshight + 180);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3 - 80, rowshight + 170, e.PageBounds.Width - marg * 2 - colwidth3 - 80, line_y2);


            e.Graphics.DrawString("رصيد آخر", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 90, rowshight + 180);


            e.Graphics.DrawString("نوع العملية", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 111 - 56 - 50, rowshight + 180);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3 - 200, rowshight + 170, e.PageBounds.Width - marg * 2 - colwidth3 - 200, line_y2);


            ColorMatrix matrix = new ColorMatrix();
            matrix.Matrix33 = (float)0.2;
            ImageAttributes attr = new ImageAttributes();
            attr.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            var src_water_mark = new Bitmap(Program.PrintUpperImageSource);
            e.Graphics.DrawImage(src_water_mark, new Rectangle((e.PageBounds.Width / 2) - 200, (e.PageBounds.Height / 2) - 250, 400, 400), 0, 0, src_water_mark.Width, src_water_mark.Height, GraphicsUnit.Pixel, attr);


        }
    }
}
