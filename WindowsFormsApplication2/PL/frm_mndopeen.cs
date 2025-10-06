using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.PL
{
    public partial class frm_mndopeen : Form
    {
        BL.cls_mndobeen mndb = new BL.cls_mndobeen();
        BL.cls_orders order = new BL.cls_orders();
        BL.cls_expenses expn = new BL.cls_expenses();
        DataTable dt_msarif = new DataTable();
        DataTable dt_orders = new DataTable();
        DataTable dt_t7see = new DataTable();
        public frm_mndopeen()
        {
            InitializeComponent();
            dataGridView1.DataSource = mndb.get_all_mndopeen();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

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
        private void txt_serch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mndb.search_mndobeen(txt_serch.Text);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nme.Text))
            {
                if (string.IsNullOrEmpty(txt_rseed.Text))
                {
                    txt_rseed.Text = "0";
                }
                mndb.add_mndoob(txt_nme.Text, txt_phone.Text, Convert.ToDouble(txt_rseed.Text));
                MessageBox.Show("تم اضافة المندوب بنجاح", "عملية الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = mndb.search_mndobeen("");
                txt_nme.Text = string.Empty;
                txt_phone.Text = string.Empty;
                txt_rseed.Text = string.Empty;
                
            }
            else
            {
                MessageBox.Show("برجاء ادخال اسم المندوب", "عملية الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
             txt_nme.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
             txt_phone.Text =dataGridView1.CurrentRow.Cells[2].Value.ToString();
             txt_rseed.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
             try
             {
                 dataGridView2.DataSource = mndb.get_all_orders_for_mandob(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                 //
                 //dataGridView_t7selat.DataSource = mndb.get_all_cstmr_pays_for_mndb(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                 dataGridView_new_t7sel.DataSource = mndb.get_all_cstmr_pays_for_mndb(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                 dataGridView_msarif.DataSource = expn.get_all_expenses_for_kind(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                 dataGridView_prds.DataSource = "";
             }
             catch (Exception)
             {

             }

             refresh_frm();
            
            mndb.edit_mndoob(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), Convert.ToDouble(textBox2.Text));
             //this.dataGridView1.DataSource = mndb.search_mndobeen("");
             dataGridView1.CurrentRow.Cells[3].Value = textBox2.Text;
             
            //
        }
        void refresh_frm()
        {
            textBox2.Text = (from DataGridViewRow row in dataGridView2.Rows
                             where row.Cells[5].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
            txt_msarif.Text = (from DataGridViewRow row in dataGridView_msarif.Rows
                               where row.Cells[2].FormattedValue.ToString() != string.Empty
                               select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
            txt_t7seel.Text = (from DataGridViewRow row in dataGridView_new_t7sel.Rows
                               where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[6].FormattedValue.ToString() != "خصم مسموح به" && row.Cells[6].FormattedValue.ToString() != "رد للعميل"
                               select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            txt_5sm.Text = (from DataGridViewRow row in dataGridView_new_t7sel.Rows
                            where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[6].FormattedValue.ToString() == "خصم مسموح به"
                            select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            txt_rd.Text = (from DataGridViewRow row in dataGridView_new_t7sel.Rows
                           where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[6].FormattedValue.ToString() == "رد للعميل"
                           select Math.Abs(Convert.ToDouble(row.Cells[3].FormattedValue))).Sum().ToString();

            txt_msdd.Text = (from DataGridViewRow row in dataGridView2.Rows
                             where row.Cells[3].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nme.Text))
            {
                mndb.edit_mndoob(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),txt_nme.Text, txt_phone.Text, Convert.ToDouble(txt_rseed.Text));
                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = mndb.search_mndobeen("");
                txt_nme.Text = string.Empty;
                txt_phone.Text = string.Empty;
                txt_rseed.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("برجاء ادخال اسم المندوب", "عملية الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل تريد حذف هذا المندوب ؟", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mndb.delete_mndoop(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                this.dataGridView1.DataSource = mndb.search_mndobeen("");
                txt_nme.Text = string.Empty;
                txt_phone.Text = string.Empty;
                txt_rseed.Text = string.Empty;

            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_prds.DataSource = order.get_order_details_for_edit(dataGridView2.CurrentRow.Cells[0].Value.ToString());

            }
            catch (Exception)
            {

            }
            //try
            //{
            //dgv_asnaf.DataSource = order.getorderdetails(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
            //dgv_asnaf.Columns.RemoveAt(15);
            //dgv_asnaf.Columns.RemoveAt(14);
            //dgv_asnaf.Columns.RemoveAt(12);
            //dgv_asnaf.Columns.RemoveAt(11);
            //dgv_asnaf.Columns.RemoveAt(10);
            //dgv_asnaf.Columns.RemoveAt(9);
            //dgv_asnaf.Columns.RemoveAt(8);
            //dgv_asnaf.Columns.RemoveAt(6);
            //dgv_asnaf.Columns.RemoveAt(0);
            //dgv_asnaf.Columns.RemoveAt(6);
            //}
            //catch (Exception)
            //{
                
                
            //}
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            //groupBox_msarif.Visible = false;
            //groupBox_t7selat.Visible = false;
            //groupBox_orders.Visible = true;
            //groupBox6.Visible = true;
            group_prds.BringToFront();
            groupBox_orders.BringToFront();
           // groupBox_new_t7seel.BringToFront();

            //groupBox_prds.BringToFront();
            
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
           // groupBox_msarif.Visible = true;
            //groupBox_t7selat.Visible = true;
            //groupBox_t7selat.BringToFront();
            groupBox_msarif.BringToFront();
            groupBox_new_t7seel.BringToFront();
           // groupBox_orders.Visible = true;
            //dataGridView2.Visible = false;
           // groupBox_prds.Visible = false;
        }

        private void frm_mndopeen_Load(object sender, EventArgs e)
        {

        }

        private void groupBox_msarif_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = mndb.get_all_orders_for_mandob(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                //
                //dataGridView_t7selat.DataSource = mndb.get_all_cstmr_pays_for_mndb(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                dataGridView_new_t7sel.DataSource = mndb.get_all_cstmr_pays_for_mndb(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                dataGridView_msarif.DataSource = expn.get_all_expenses_for_kind(dataGridView1.CurrentRow.Cells[1].Value.ToString());

            }
            catch (Exception)
            {

            }
            refresh_frm();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            dt_msarif.Clear();
            dt_orders.Clear();
            dt_t7see.Clear();

            foreach (var item in get_dates_between(dateTimePicker1.Value, dateTimePicker2.Value))
            {
                dt_msarif.Merge(mndb.get_all_expenses_for_kind_by_date(dataGridView1.CurrentRow.Cells[1].Value.ToString(), item.Date));
                dt_orders.Merge(mndb.get_all_orders_for_mandob_by_date(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),item.Date.ToString("dd/MM/yyyy")));
                dt_t7see.Merge(mndb.get_all_cstmr_pays_for_mndb_by_date(dataGridView1.CurrentRow.Cells[1].Value.ToString(),item.Date.ToString("dd/MM/yyyy")));
            }
            dataGridView_msarif.DataSource = dt_msarif;
            dataGridView_new_t7sel.DataSource = dt_t7see;
            dataGridView2.DataSource = dt_orders;
            refresh_frm();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            i++;
            ii++;
            page_num++;
            Font f = new Font("Arial", 12, FontStyle.Bold);
            Font v = new Font("Arial", 36, FontStyle.Bold);
            Font n = new Font("Arial", 10, FontStyle.Regular);
            Font col_header = new Font("Arial", 16, FontStyle.Underline);
            int txt_hight = 35;

            float marg = 25;
            string cstmrid = "كود المندوب : " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string cstname = "اسم المندوب: " + dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string datee = "التاريخ : " + DateTime.Now.ToShortDateString();
            //////


            SizeF FpntSizeid = e.Graphics.MeasureString(cstmrid, f);
            SizeF FpntSizenme = e.Graphics.MeasureString(cstname, f);

            SizeF fontsizegate = e.Graphics.MeasureString(datee, f);
            ////////

            //الحاجات اللي في اخر الفاتورة
            //e.Graphics.DrawLine(Pens.DarkBlue, marg, e.PageBounds.Height - 130, e.PageBounds.Width - (marg), e.PageBounds.Height - 130);


            e.Graphics.FillRectangle(Brushes.WhiteSmoke, new Rectangle(0, e.PageBounds.Height - 30, (int)(e.PageBounds.Width), e.PageBounds.Bottom));
            e.Graphics.DrawString("صفحة : " + page_num, f, Brushes.DarkBlue, marg, e.PageBounds.Height - 30);
            e.Graphics.DrawString(Program.FooterAllReportsText, n, Brushes.Black, (e.PageBounds.Width / 6) + 20, e.PageBounds.Height - 30);


            if (page_num == 1)
            {
                e.Graphics.DrawRectangle(Pens.Black, marg, 3, (e.PageBounds.Width / 2) - 140, marg + txt_hight * 3 - 7);
                e.Graphics.DrawString(Program.company_name, v, Brushes.Blue, 20, 5);
                e.Graphics.DrawString(Program.details_1, f, Brushes.BlueViolet, marg, marg + txt_hight);
                e.Graphics.DrawString(Program.details_2, f, Brushes.BlueViolet, marg, marg + (txt_hight * 2) - 15);
                e.Graphics.DrawString(Program.telephon_1, f, Brushes.Black, marg, marg + (txt_hight * 3) - 30);
                //e.Graphics.DrawString(" للأدوات الصحية ", f, Brushes.BlueViolet, marg, marg + txt_hight);
                //e.Graphics.DrawString("والمواسير الألمانية وأنظمة المياة", f, Brushes.BlueViolet, marg, marg + (txt_hight * 2) - 15);
                //e.Graphics.DrawString("الحاج/مصطفي/01022070794", f, Brushes.Black, marg, marg + (txt_hight * 3) - 30);

                e.Graphics.DrawRectangle(Pens.DarkRed, (e.PageBounds.Width / 2) - 70, marg / 2, 180, 30);
                e.Graphics.DrawString("كشف فواتير مندوب", col_header, Brushes.DarkRed, (e.PageBounds.Width / 2) + 10 - 70, marg / 2);
                e.Graphics.DrawString(datee, f, Brushes.Black, (e.PageBounds.Width - fontsizegate.Width) - marg, marg + txt_hight - 10);
                e.Graphics.DrawString(cstmrid, f, Brushes.Blue, (e.PageBounds.Width - FpntSizeid.Width) - marg, marg);
                e.Graphics.DrawString(cstname, f, Brushes.Black, (e.PageBounds.Width - FpntSizenme.Width) - marg, marg + (txt_hight * 2) - 20);

            
            }


            //e.Graphics.DrawString("العرض : "+e.PageBounds.Width, col_header, Brushes.DarkGreen, (e.PageBounds.Width / 2) + 50 , marg+ 80);
            //e.Graphics.DrawString("الطول : " + e.PageBounds.Height, col_header, Brushes.DarkGreen, (e.PageBounds.Width / 2) + 50, marg +50);




            float prehights = marg + txt_hight * 3;

            ////المستطيل
            //e.Graphics.DrawRectangle(Pens.Black, marg, prehights, e.PageBounds.Width - marg * 2, e.PageBounds.Height - marg * 2 - 30 - prehights);
            float colhight = 45;
            float diff_betwn_line_and_word = 2;


            float colwidth1 = 30;
            float colwidth2 = 80 + colwidth1;
            float colwidth3 = 200 + colwidth2;
            float colwidth4 = 80 + colwidth3;
            float colwidth5 = 80 + colwidth4;
            float colwidth6 = 80 + colwidth5;
            float colwidth7 = 110 + colwidth6;
            float colwidth8 = 90 + colwidth7;
            //float colwidth9 = 60 + colwidth8;
            //float colwidth10 = 60 + colwidth9;
            //float colwidth11 = 85 + colwidth10;
            if (page_num != 1)
            {
                prehights = 20;
            }

            e.Graphics.DrawLine(Pens.Black, marg, prehights + colhight - 5, e.PageBounds.Width - marg, prehights + colhight - 5);


            //  e.Graphics.DrawString("عمليات الشراء", col_header, Brushes.DarkRed, (e.PageBounds.Width / 2) - 70, marg + (txt_hight * 3) - 30);

            ////////////////////////////////////////////
            float rowshight = 50;

            for (; i < dataGridView2.Rows.Count - 1; i++)
            {

                e.Graphics.DrawString((i + 1).ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth1 + diff_betwn_line_and_word, prehights + 30 + rowshight - 36);


                e.Graphics.DrawString(dataGridView2.Rows[i].Cells[0].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth2 + diff_betwn_line_and_word, prehights + 30 + rowshight - 4 - 35);
                e.Graphics.DrawString(dataGridView2.Rows[i].Cells[2].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth3 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView2.Rows[i].Cells[1].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth4 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView2.Rows[i].Cells[3].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth5 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView2.Rows[i].Cells[4].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth6 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView2.Rows[i].Cells[5].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth7 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView2.Rows[i].Cells[6].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth8 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                //e.Graphics.DrawString(dataGridView2.Rows[i].Cells[7].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth9 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                //e.Graphics.DrawString(dataGridView2.Rows[i].Cells[8].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth10 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                //e.Graphics.DrawString(dataGridView2.Rows[i].Cells[9].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth11 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);

                e.Graphics.DrawLine(Pens.Black, marg, prehights + colhight + rowshight - 30, e.PageBounds.Width - marg, prehights + colhight + rowshight - 30);
                rowshight += 30;

                if ((i % 31) == 0 && i != 0)
                {
                    e.HasMorePages = true;
                    break;
                }
            }

            ////////////////////////////////////////////////////////////////////
            //المستطيل
            e.Graphics.DrawRectangle(Pens.Black, marg, prehights, e.PageBounds.Width - marg * 2, rowshight - 12);


            e.Graphics.DrawString("م", f, Brushes.Black, e.PageBounds.Width - marg - colwidth1 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth1, prehights, e.PageBounds.Width - marg - colwidth1, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("كود الفاتورة", f, Brushes.Black, e.PageBounds.Width - marg - colwidth2 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth2, prehights, e.PageBounds.Width - marg - colwidth2, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("اسم العميل", f, Brushes.Black, e.PageBounds.Width - marg - colwidth3 + diff_betwn_line_and_word + 50, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth3, prehights, e.PageBounds.Width - marg - colwidth3, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("التاريخ", f, Brushes.Black, e.PageBounds.Width - marg - colwidth4 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth4, prehights, e.PageBounds.Width - marg - colwidth4, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("مسدد", f, Brushes.Black, e.PageBounds.Width - marg - colwidth5 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth5, prehights, e.PageBounds.Width - marg - colwidth5, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("متبقي", f, Brushes.Black, e.PageBounds.Width - marg - colwidth6 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth6, prehights, e.PageBounds.Width - marg - colwidth6, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("اجمالي الفاتورة", f, Brushes.Black, e.PageBounds.Width - marg - colwidth7 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth7, prehights, e.PageBounds.Width - marg - colwidth7, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("صافي ربح", f, Brushes.Black, e.PageBounds.Width - marg - colwidth8 + diff_betwn_line_and_word, prehights + 15);
            //e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth8, prehights, e.PageBounds.Width - marg - colwidth8, prehights + 30 + rowshight - 5 - 35);

            //e.Graphics.DrawString("مرتجع", f, Brushes.Black, e.PageBounds.Width - marg - colwidth9 + diff_betwn_line_and_word, prehights + 15);
            //e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth9, prehights, e.PageBounds.Width - marg - colwidth9, prehights + 30 + rowshight - 5 - 35);


            //e.Graphics.DrawString("الرصيد", f, Brushes.Black, e.PageBounds.Width - marg - colwidth10 + diff_betwn_line_and_word, prehights + 15);
            //e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth10, prehights, e.PageBounds.Width - marg - colwidth10, prehights + 30 + rowshight - 5 - 35);


            //e.Graphics.DrawString("نوع الرصيد", f, Brushes.Black, e.PageBounds.Width - marg - colwidth11 + diff_betwn_line_and_word, prehights + 15);
            //// e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth11, prehights, e.PageBounds.Width - marg - colwidth11, prehights + 30 + rowshight - 5 - 35);
            ColorMatrix matrix = new ColorMatrix();
            matrix.Matrix33 = (float)0.2;
            ImageAttributes attr = new ImageAttributes();
            attr.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            var src_water_mark = new Bitmap(Program.PrintUpperImageSource);
            e.Graphics.DrawImage(src_water_mark, new Rectangle((e.PageBounds.Width / 2) - 200, (e.PageBounds.Height / 2) - 250, 400, 400), 0, 0, src_water_mark.Width, src_water_mark.Height, GraphicsUnit.Pixel, attr);

        }
        public int i = -1;
        public int ii = -1;
        public int mslsl = 0;
        public int page_num = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();


            printDlg.AllowSelection = true;

            printDlg.AllowSomePages = true;

            //Call ShowDialog

            if (printDlg.ShowDialog() == DialogResult.OK)
                printDocument1.Print();

            //((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            //if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    printDocument1.Print();
            //}
            i = -1;
            ii = -1;
            mslsl = 0;
            page_num = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();


            printDlg.AllowSelection = true;

            printDlg.AllowSomePages = true;

            //Call ShowDialog

            if (printDlg.ShowDialog() == DialogResult.OK)
                printDocument2.Print();

            //((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            //if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    printDocument1.Print();
            //}
            i = -1;
            ii = -1;
            mslsl = 0;
            page_num = 0;
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            i++;
            ii++;
            page_num++;
            Font f = new Font("Arial", 12, FontStyle.Bold);
            Font v = new Font("Arial", 36, FontStyle.Bold);
            Font n = new Font("Arial", 10, FontStyle.Regular);
            Font col_header = new Font("Arial", 16, FontStyle.Underline);
            int txt_hight = 35;

            float marg = 25;
            string cstmrid = "كود المندوب : " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string cstname = "اسم المندوب: " + dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string datee = "التاريخ : " + DateTime.Now.ToShortDateString();
            //////


            SizeF FpntSizeid = e.Graphics.MeasureString(cstmrid, f);
            SizeF FpntSizenme = e.Graphics.MeasureString(cstname, f);

            SizeF fontsizegate = e.Graphics.MeasureString(datee, f);
            ////////

            //الحاجات اللي في اخر الفاتورة
            //e.Graphics.DrawLine(Pens.DarkBlue, marg, e.PageBounds.Height - 130, e.PageBounds.Width - (marg), e.PageBounds.Height - 130);

            e.Graphics.FillRectangle(Brushes.WhiteSmoke, new Rectangle(0, e.PageBounds.Height - 30, (int)(e.PageBounds.Width), e.PageBounds.Bottom));
            e.Graphics.DrawString("صفحة : " + page_num, f, Brushes.DarkBlue, marg, e.PageBounds.Height - 30);
            e.Graphics.DrawString(Program.FooterAllReportsText, n, Brushes.Black, (e.PageBounds.Width / 6) + 20, e.PageBounds.Height - 30);


            if (page_num == 1)
            {
                e.Graphics.DrawRectangle(Pens.Black, marg, 3, (e.PageBounds.Width / 2) - 140, marg + txt_hight * 3 - 7);
                e.Graphics.DrawString(Program.company_name, v, Brushes.Blue, 20, 5);
                e.Graphics.DrawString(Program.details_1, f, Brushes.BlueViolet, marg, marg + txt_hight);
                e.Graphics.DrawString(Program.details_2, f, Brushes.BlueViolet, marg, marg + (txt_hight * 2) - 15);
                e.Graphics.DrawString(Program.telephon_1, f, Brushes.Black, marg, marg + (txt_hight * 3) - 30);
                //e.Graphics.DrawString(" للأدوات الصحية ", f, Brushes.BlueViolet, marg, marg + txt_hight);
                //e.Graphics.DrawString("والمواسير الألمانية وأنظمة المياة", f, Brushes.BlueViolet, marg, marg + (txt_hight * 2) - 15);
                //e.Graphics.DrawString("الحاج/مصطفي/01022070794", f, Brushes.Black, marg, marg + (txt_hight * 3) - 30);

                e.Graphics.DrawRectangle(Pens.DarkRed, (e.PageBounds.Width / 2) - 70, marg / 2, 180, 30);
                e.Graphics.DrawString("كشف تحصيل مندوب", col_header, Brushes.DarkRed, (e.PageBounds.Width / 2) + 10 - 70, marg / 2);
                e.Graphics.DrawString(datee, f, Brushes.Black, (e.PageBounds.Width - fontsizegate.Width) - marg, marg + txt_hight - 10);
                e.Graphics.DrawString(cstmrid, f, Brushes.Blue, (e.PageBounds.Width - FpntSizeid.Width) - marg, marg);
                e.Graphics.DrawString(cstname, f, Brushes.Black, (e.PageBounds.Width - FpntSizenme.Width) - marg, marg + (txt_hight * 2) - 20);


            }


            //e.Graphics.DrawString("العرض : "+e.PageBounds.Width, col_header, Brushes.DarkGreen, (e.PageBounds.Width / 2) + 50 , marg+ 80);
            //e.Graphics.DrawString("الطول : " + e.PageBounds.Height, col_header, Brushes.DarkGreen, (e.PageBounds.Width / 2) + 50, marg +50);




            float prehights = marg + txt_hight * 3;

            ////المستطيل
            //e.Graphics.DrawRectangle(Pens.Black, marg, prehights, e.PageBounds.Width - marg * 2, e.PageBounds.Height - marg * 2 - 30 - prehights);
            float colhight = 45;
            float diff_betwn_line_and_word = 2;


            float colwidth1 = 30;
            float colwidth2 = 80 + colwidth1;
            float colwidth3 = 200 + colwidth2;
            float colwidth4 = 80 + colwidth3;
            float colwidth5 = 80 + colwidth4;
            float colwidth6 = 80 + colwidth5;
            float colwidth7 = 110 + colwidth6;
            float colwidth8 = 90 + colwidth7;
            //float colwidth9 = 60 + colwidth8;
            //float colwidth10 = 60 + colwidth9;
            //float colwidth11 = 85 + colwidth10;
            if (page_num != 1)
            {
                prehights = 20;
            }

            e.Graphics.DrawLine(Pens.Black, marg, prehights + colhight - 5, e.PageBounds.Width - marg, prehights + colhight - 5);


            //  e.Graphics.DrawString("عمليات الشراء", col_header, Brushes.DarkRed, (e.PageBounds.Width / 2) - 70, marg + (txt_hight * 3) - 30);

            ////////////////////////////////////////////
            float rowshight = 50;

            for (; i < dataGridView_new_t7sel.Rows.Count - 1; i++)
            {

                e.Graphics.DrawString((i + 1).ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth1 + diff_betwn_line_and_word, prehights + 30 + rowshight - 36);


                e.Graphics.DrawString(dataGridView_new_t7sel.Rows[i].Cells[0].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth2 + diff_betwn_line_and_word, prehights + 30 + rowshight - 4 - 35);
                e.Graphics.DrawString(dataGridView_new_t7sel.Rows[i].Cells[1].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth3 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView_new_t7sel.Rows[i].Cells[2].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth4 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView_new_t7sel.Rows[i].Cells[3].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth5 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView_new_t7sel.Rows[i].Cells[4].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth6 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView_new_t7sel.Rows[i].Cells[5].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth7 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView_new_t7sel.Rows[i].Cells[6].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth8 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                //e.Graphics.DrawString(dataGridView2.Rows[i].Cells[7].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth9 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                //e.Graphics.DrawString(dataGridView2.Rows[i].Cells[8].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth10 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                //e.Graphics.DrawString(dataGridView2.Rows[i].Cells[9].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth11 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);

                e.Graphics.DrawLine(Pens.Black, marg, prehights + colhight + rowshight - 30, e.PageBounds.Width - marg, prehights + colhight + rowshight - 30);
                rowshight += 30;

                if ((i % 31) == 0 && i != 0)
                {
                    e.HasMorePages = true;
                    break;
                }
            }

            ////////////////////////////////////////////////////////////////////
            //المستطيل
            e.Graphics.DrawRectangle(Pens.Black, marg, prehights, e.PageBounds.Width - marg * 2, rowshight - 12);


            e.Graphics.DrawString("م", f, Brushes.Black, e.PageBounds.Width - marg - colwidth1 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth1, prehights, e.PageBounds.Width - marg - colwidth1, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("كود العملية", f, Brushes.Black, e.PageBounds.Width - marg - colwidth2 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth2, prehights, e.PageBounds.Width - marg - colwidth2, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("اسم العميل", f, Brushes.Black, e.PageBounds.Width - marg - colwidth3 + diff_betwn_line_and_word + 50, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth3, prehights, e.PageBounds.Width - marg - colwidth3, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("رصيد اول", f, Brushes.Black, e.PageBounds.Width - marg - colwidth4 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth4, prehights, e.PageBounds.Width - marg - colwidth4, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("المدفوع", f, Brushes.Black, e.PageBounds.Width - marg - colwidth5 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth5, prehights, e.PageBounds.Width - marg - colwidth5, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("رصيد اخر", f, Brushes.Black, e.PageBounds.Width - marg - colwidth6 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth6, prehights, e.PageBounds.Width - marg - colwidth6, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("التاريخ", f, Brushes.Black, e.PageBounds.Width - marg - colwidth7 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth7, prehights, e.PageBounds.Width - marg - colwidth7, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("نوع العملية", f, Brushes.Black, e.PageBounds.Width - marg - colwidth8 + diff_betwn_line_and_word, prehights + 15);
            //e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth8, prehights, e.PageBounds.Width - marg - colwidth8, prehights + 30 + rowshight - 5 - 35);

            //e.Graphics.DrawString("مرتجع", f, Brushes.Black, e.PageBounds.Width - marg - colwidth9 + diff_betwn_line_and_word, prehights + 15);
            //e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth9, prehights, e.PageBounds.Width - marg - colwidth9, prehights + 30 + rowshight - 5 - 35);


            //e.Graphics.DrawString("الرصيد", f, Brushes.Black, e.PageBounds.Width - marg - colwidth10 + diff_betwn_line_and_word, prehights + 15);
            //e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth10, prehights, e.PageBounds.Width - marg - colwidth10, prehights + 30 + rowshight - 5 - 35);


            //e.Graphics.DrawString("نوع الرصيد", f, Brushes.Black, e.PageBounds.Width - marg - colwidth11 + diff_betwn_line_and_word, prehights + 15);
            //// e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth11, prehights, e.PageBounds.Width - marg - colwidth11, prehights + 30 + rowshight - 5 - 35);

            ColorMatrix matrix = new ColorMatrix();
            matrix.Matrix33 = (float)0.2;
            ImageAttributes attr = new ImageAttributes();
            attr.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            var src_water_mark = new Bitmap(Program.PrintUpperImageSource);
            e.Graphics.DrawImage(src_water_mark, new Rectangle((e.PageBounds.Width / 2) - 200, (e.PageBounds.Height / 2) - 250, 400, 400), 0, 0, src_water_mark.Width, src_water_mark.Height, GraphicsUnit.Pixel, attr);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        DataTable dt_prds = new DataTable();
        private void button3_Click(object sender, EventArgs e)
        {
            dt_prds.Clear();
            frm_all_mndb_prds frm = new frm_all_mndb_prds();
            for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
            {
                dt_prds.Merge(mndb.get_all_order_details_for_mndb(dataGridView2.Rows[i].Cells[0].Value.ToString()));
                
            }
            frm.dataGridView1.DataSource = dt_prds;
            frm.Show();
        }

    }
}
