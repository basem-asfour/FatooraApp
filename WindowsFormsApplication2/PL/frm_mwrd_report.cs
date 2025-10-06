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
    public partial class frm_mwrd_report : Form
    {
        DataTable dt_cstmr = new DataTable();
        DataTable dt_all = new DataTable();
        BL.cls_mwrdeen mwrd = new BL.cls_mwrdeen();
        public frm_mwrd_report()
        {
            InitializeComponent();
            dt_cstmr = mwrd.get_all_mwrdeen();
            combo_mwrd.DataSource = dt_cstmr;
            combo_mwrd.DisplayMember = "اسم المورد";
            combo_mwrd.ValueMember = "id";
            combo_mwrd.Text = "";
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
        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mwrd.get_mwrd_mrtg3_for_mwrd_report(combo_mwrd.Text, "");
            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //{
            //    if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[5].Value.ToString()))
            //    {
            //        dataGridView1.Rows[i].Cells[4].Value = dataGridView1.Rows[i].Cells[5].Value;
            //    }
            //}
            //dataGridView1.Columns.RemoveAt(5);
            dt_all.Clear();
            dt_all.Merge(mwrd.get_mwrd_pays_first_rseed_for_mwrd_report(Convert.ToInt32(combo_mwrd.SelectedValue), ""));

            dt_all.Merge(mwrd.get_mwrd_fwateer_for_mwrd_report(combo_mwrd.Text, ""));
            dt_all.Merge(mwrd.get_mwrd_fwateer_msdd_for_mwrd_report(combo_mwrd.Text, ""));
            dt_all.Merge(mwrd.get_mwrd_pays_for_mwrd_report(Convert.ToInt32(combo_mwrd.SelectedValue), ""));

            dt_all.Merge(mwrd.get_mwrd_mrtg3_for_mwrd_report(combo_mwrd.Text, ""));
            //dt_all.Columns.RemoveAt(7);
            dt_all.Columns[2].DataType = typeof(DateTime);
            dgv_mwrd.DataSource = dt_all;
            dgv_mwrd.Columns[2].ValueType = typeof(DateTime);
            dgv_mwrd.Columns[2].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";

            dgv_mwrd.Sort(dgv_mwrd.Columns[2], ListSortDirection.Ascending);
            //dgv_cstmrs.Sort(new RowComparer(SortOrder.Ascending));
            for (int i = 0; i < dgv_mwrd.Rows.Count - 1; i++)
            {


                if (i > 0)
                {
                    dgv_mwrd.Rows[i].Cells[3].Value = dgv_mwrd.Rows[i - 1].Cells[5].Value;
                }

                if (string.IsNullOrEmpty(dgv_mwrd.Rows[i].Cells[1].Value.ToString()))
                {
                    if (dgv_mwrd.Rows[i].Cells[4].Value.ToString() == "0")
                    {
                        dgv_mwrd.Rows[i].Cells[1].Value = "اضافة رصيد";
                    }
                    if (Convert.ToDouble(dgv_mwrd.Rows[i].Cells[4].Value) > 0)
                    {
                        dgv_mwrd.Rows[i].Cells[1].Value = "دفع";
                    }
                    if (Convert.ToDouble(dgv_mwrd.Rows[i].Cells[4].Value) < 0)
                    {
                        dgv_mwrd.Rows[i].Cells[1].Value = "استرجاع من المورد";
                    }
                }
                try
                {
                    if (i == 0)
                    {
                        Convert.ToDouble(dgv_mwrd.Rows[i].Cells[3].Value);
                        if (dgv_mwrd.Rows[i].Cells[1].Value.ToString() == "اضافة رصيد")
                        {
                            dgv_mwrd.Rows[i].Cells[3].Value = 0;
                            dgv_mwrd.Rows[i].Cells[4].Value = dgv_mwrd.Rows[i].Cells[5].Value;
                        }
                    }
                }
                catch (Exception)
                {

                    dgv_mwrd.Rows[i].Cells[3].Value = 0;
                }
                if (dgv_mwrd.Rows[i].Cells[1].Value.ToString() == "دفع" || dgv_mwrd.Rows[i].Cells[1].Value.ToString() == "خصم مكتسب" ||
                    dgv_mwrd.Rows[i].Cells[1].Value.ToString().Contains("مسدد من فاتورة شراء رقم") || dgv_mwrd.Rows[i].Cells[1].Value.ToString().Contains("مرتجع من فاتورة شراء رقم"))
                {
                    dgv_mwrd.Rows[i].Cells[1].Style.ForeColor = Color.DarkGreen;
                    dgv_mwrd.Rows[i].Cells[5].Value = Convert.ToDouble(dgv_mwrd.Rows[i].Cells[3].Value) - Convert.ToDouble(dgv_mwrd.Rows[i].Cells[4].Value);
                }
                if (dgv_mwrd.Rows[i].Cells[1].Value.ToString() == "استرجاع من المورد" || dgv_mwrd.Rows[i].Cells[1].Value.ToString() == "فاتورة شراء")
                {
                    if (Convert.ToDouble(dgv_mwrd.Rows[i].Cells[4].Value) > 0)
                    {
                        dgv_mwrd.Rows[i].Cells[5].Value = Convert.ToDouble(dgv_mwrd.Rows[i].Cells[3].Value) + Convert.ToDouble(dgv_mwrd.Rows[i].Cells[4].Value);

                    }
                    else
                    {
                        dgv_mwrd.Rows[i].Cells[5].Value = Convert.ToDouble(dgv_mwrd.Rows[i].Cells[3].Value) + Math.Abs(Convert.ToDouble(dgv_mwrd.Rows[i].Cells[4].Value));
                        dgv_mwrd.Rows[i].Cells[4].Value = Math.Abs(Convert.ToDouble(dgv_mwrd.Rows[i].Cells[4].Value));
                    }
                    dgv_mwrd.Rows[i].Cells[1].Style.ForeColor = Color.Red;

                }
                if (dgv_mwrd.Rows[i].Cells[1].Value.ToString() == "اضافة رصيد" && i > 0)
                {
                    dgv_mwrd.Rows[i].Cells[1].Style.ForeColor = Color.Red;
                    dgv_mwrd.Rows[i].Cells[4].Value = Convert.ToDouble(dgv_mwrd.Rows[i].Cells[5].Value);
                    dgv_mwrd.Rows[i].Cells[5].Value = Convert.ToDouble(dgv_mwrd.Rows[i].Cells[5].Value) + Convert.ToDouble(dgv_mwrd.Rows[i - 1].Cells[5].Value);
                }
                if (Convert.ToDouble(dgv_mwrd.Rows[i].Cells[5].Value) > 0)
                {
                    dgv_mwrd.Rows[i].Cells[6].Value = "دائن";
                    dgv_mwrd.Rows[i].Cells[6].Style.ForeColor = Color.Crimson;
                }
                else if (Convert.ToDouble(dgv_mwrd.Rows[i].Cells[5].Value) < 0)
                {
                    dgv_mwrd.Rows[i].Cells[6].Value = "مدين";
                    dgv_mwrd.Rows[i].Cells[6].Style.ForeColor = Color.Blue;

                }
                else if (Convert.ToDouble(dgv_mwrd.Rows[i].Cells[5].Value) == 0)
                {
                    dgv_mwrd.Rows[i].Cells[6].Value = "خالص";
                    dgv_mwrd.Rows[i].Cells[6].Style.ForeColor = Color.SpringGreen;

                }
            }
            dgv_mwrd.Columns[4].DefaultCellStyle.BackColor = Color.LightCyan;


            /////
            txt_total_shraa.Text = (from DataGridViewRow row in dgv_mwrd.Rows
                                   where row.Cells[4].FormattedValue.ToString() != string.Empty && row.Cells[1].FormattedValue.ToString() == "فاتورة شراء"
                                   select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_total_first_rseed.Text = (from DataGridViewRow row in dgv_mwrd.Rows
                                          where row.Cells[4].FormattedValue.ToString() != string.Empty && row.Cells[1].FormattedValue.ToString() == "اضافة رصيد"
                                          select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_total_ta7seel.Text = (from DataGridViewRow row in dgv_mwrd.Rows
                                      where row.Cells[4].FormattedValue.ToString() != string.Empty && row.Cells[1].FormattedValue.ToString() == "دفع" || row.Cells[4].FormattedValue.ToString() != string.Empty && row.Cells[1].FormattedValue.ToString().Contains("مسدد من فاتورة")
                                      select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_total_5sm.Text = (from DataGridViewRow row in dgv_mwrd.Rows
                                  where row.Cells[4].FormattedValue.ToString() != string.Empty && row.Cells[1].FormattedValue.ToString() == "خصم مكتسب"
                                  select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_total_metg3.Text = (from DataGridViewRow row in dgv_mwrd.Rows
                                    where row.Cells[4].FormattedValue.ToString() != string.Empty && row.Cells[1].FormattedValue.ToString().Contains("مرتجع")
                                    select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_total_rd.Text = (from DataGridViewRow row in dgv_mwrd.Rows
                                 where row.Cells[4].FormattedValue.ToString() != string.Empty && row.Cells[1].FormattedValue.ToString() == "استرجاع من المورد"
                                 select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();

            try
            {
                txt_safi.Text = Math.Round((Convert.ToDouble(txt_total_shraa.Text) + Convert.ToDouble(txt_total_first_rseed.Text) + Convert.ToDouble(txt_total_rd.Text)
                    - Convert.ToDouble(txt_total_ta7seel.Text) - Convert.ToDouble(txt_total_metg3.Text) - Convert.ToDouble(txt_total_5sm.Text)),2).ToString();
            }
            catch (Exception)
            {

                txt_safi.Text = "رجاء مراجعة القيم";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button11_Click(sender, e);
            dgv_mwrd.ReadOnly = false;
            dgv_mwrd.CurrentRow.Selected = false;

            foreach (var item in get_dates_between(dateTimePicker1.Value, dateTimePicker2.Value))
            {
                foreach (DataGridViewRow row in dgv_mwrd.Rows)
                {
                    if (row.Index < dgv_mwrd.Rows.Count - 1)
                    {
                        if (row.Cells[2].Value.ToString().Contains(item.ToString("dd/MM/yyyy")))
                        {
                            row.Selected = true;
                        }
                    }

                }
            }
            dgv_mwrd.ReadOnly = true;
        }

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

            float marg = 25;
            string cstmrid = "كود مورد : " + combo_mwrd.SelectedValue;
            string cstname = "اسم المورد: " + combo_mwrd.Text;
            string datee = "التاريخ : " + DateTime.Now.ToShortDateString();
            //////
            string first_rseed = "رصيد أول : " + txt_total_first_rseed.Text;
            string total_mshtriat = "اجمالي مشتريات : " + txt_total_shraa.Text;
            string mrtg3 = "اجمالي مرتجع : " + txt_total_metg3.Text;
            string msdd = "مسدد : " + txt_total_ta7seel.Text;
            string rd = "استرجاع من المورد : " + txt_total_rd.Text;
            string khsm = "خصم مكتسب : " + txt_total_5sm.Text;
            string mtbaki = "دائن ب : " + txt_safi.Text;


            SizeF FpntSizeid = e.Graphics.MeasureString(cstmrid, f);
            SizeF FpntSizenme = e.Graphics.MeasureString(cstname, f);
            SizeF fontsizegate = e.Graphics.MeasureString(datee, f);
            ////////
            SizeF FontSizefirst_rseed = e.Graphics.MeasureString(first_rseed, f);
            SizeF FontSizetotal_mshtriat = e.Graphics.MeasureString(total_mshtriat, f);
            SizeF fontsizemrtg3 = e.Graphics.MeasureString(mrtg3, f);
            SizeF FontSizemsdd = e.Graphics.MeasureString(msdd, f);
            SizeF FontSizmtbaki = e.Graphics.MeasureString(mtbaki, f);

            SizeF FontSizekhsm = e.Graphics.MeasureString(khsm, f);
            SizeF FontSizerd = e.Graphics.MeasureString(rd, f);
            //الحاجات اللي في اخر الفاتورة
            e.Graphics.DrawLine(Pens.DarkBlue, marg, e.PageBounds.Height - 130, e.PageBounds.Width - (marg), e.PageBounds.Height - 130);
            e.Graphics.DrawString(first_rseed, f, Brushes.Black, e.PageBounds.Width - FontSizefirst_rseed.Width - (marg * 2), e.PageBounds.Height - 120);
            e.Graphics.DrawString(total_mshtriat, f, Brushes.Black, e.PageBounds.Width - FontSizetotal_mshtriat.Width - (marg * 2), e.PageBounds.Height - 90);
            e.Graphics.DrawString(mrtg3, f, Brushes.Black, e.PageBounds.Width - fontsizemrtg3.Width - (marg * 2), e.PageBounds.Height - 65);
            e.Graphics.DrawString(msdd, f, Brushes.Black, (e.PageBounds.Width / 2) - FontSizemsdd.Width - (marg * 2) + 150, e.PageBounds.Height - 120);
            e.Graphics.DrawString(rd, f, Brushes.Black, (e.PageBounds.Width / 2) - FontSizerd.Width - (marg * 2) + 150, e.PageBounds.Height - 90);
            e.Graphics.DrawString(khsm, f, Brushes.Black, (e.PageBounds.Width / 2) - FontSizekhsm.Width - (marg * 2) + 150, e.PageBounds.Height - 65);

            e.Graphics.DrawString(mtbaki, f, Brushes.Blue, (e.PageBounds.Width / 3) - FontSizmtbaki.Width - (marg * 2), e.PageBounds.Height - 90);


            e.Graphics.FillRectangle(Brushes.WhiteSmoke, new Rectangle(0, e.PageBounds.Height - 30, (int)(e.PageBounds.Width), e.PageBounds.Bottom));
            e.Graphics.DrawString("صفحة : " + page_num, f, Brushes.DarkBlue, marg, e.PageBounds.Height - 30);
            e.Graphics.DrawString(Program.FooterAllReportsText, n, Brushes.Black, (e.PageBounds.Width / 6) + 20, e.PageBounds.Height - 30);


            e.Graphics.DrawRectangle(Pens.Black, marg, 3 , (e.PageBounds.Width/2)-140,marg+txt_hight*3-7 );
            //e.Graphics.DrawRectangle(Pens.DarkRed, (e.PageBounds.Width / 2)+75, 3, (e.PageBounds.Width / 2) - 100, marg + txt_hight * 3 - 7);
            e.Graphics.DrawString(Program.company_name, v, Brushes.Blue, 20, 5);
            e.Graphics.DrawString(Program.details_1, f, Brushes.BlueViolet, marg, marg + txt_hight);
            e.Graphics.DrawString(Program.details_2, f, Brushes.BlueViolet, marg, marg + (txt_hight * 2) - 15);
            e.Graphics.DrawString(Program.telephon_1, f, Brushes.Black, marg, marg + (txt_hight * 3) - 30);
            //e.Graphics.DrawString(" للأدوات الصحية ", f, Brushes.BlueViolet, marg, marg + txt_hight);
            //e.Graphics.DrawString("والمواسير الألمانية وأنظمة المياة", f, Brushes.BlueViolet, marg, marg + (txt_hight * 2) - 15);
            //e.Graphics.DrawString("الحاج/مصطفي/01022070794", f, Brushes.Black, marg, marg + (txt_hight * 3) - 30);

            e.Graphics.DrawRectangle(Pens.DarkRed, (e.PageBounds.Width / 2) - 70, marg / 2, 110, 30);
            e.Graphics.DrawString("تقرير مـورد", col_header, Brushes.DarkRed, (e.PageBounds.Width / 2) + 10 - 70, marg / 2);



            e.Graphics.DrawString(cstmrid, f, Brushes.Blue, (e.PageBounds.Width - FpntSizeid.Width) - marg, marg);
            e.Graphics.DrawString(datee, f, Brushes.Black, (e.PageBounds.Width - fontsizegate.Width) - marg, marg + txt_hight - 10);
            e.Graphics.DrawString(cstname, f, Brushes.Black, (e.PageBounds.Width - FpntSizenme.Width) - marg, marg + (txt_hight * 2) - 20);


            float prehights = marg + txt_hight * 3;

            ////المستطيل
            //e.Graphics.DrawRectangle(Pens.Black, marg, prehights, e.PageBounds.Width - marg * 2, e.PageBounds.Height - marg * 2 - 30 - prehights);
            float colhight = 45;

            float colwidth1 = 50;
            float colwidth2 = 250 + colwidth1;
            float colwidth3 = 70 + colwidth2;
            float colwidth4 = 50 + colwidth3;
            float colwidth5 = 50 + colwidth4;
            float colwidth6 = 50 + colwidth5;

            e.Graphics.DrawLine(Pens.Black, marg, prehights + colhight, e.PageBounds.Width - marg, prehights + colhight);

            //  e.Graphics.DrawString("عمليات الشراء", col_header, Brushes.DarkRed, (e.PageBounds.Width / 2) - 70, marg + (txt_hight * 3) - 30);

            ////////////////////////////////////////////
            float rowshight = 55;

            for (; i < dgv_mwrd.Rows.Count - 1; i++)
            {

                e.Graphics.DrawString((i + 1).ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 20, prehights + 30 + rowshight - 36);


                e.Graphics.DrawString(dgv_mwrd.Rows[i].Cells[0].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 75, prehights + 30 + rowshight - 4 - 35);
                e.Graphics.DrawString(dgv_mwrd.Rows[i].Cells[1].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 270, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(Convert.ToDateTime(dgv_mwrd.Rows[i].Cells[2].Value.ToString()).ToShortDateString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 376, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dgv_mwrd.Rows[i].Cells[3].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 111, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dgv_mwrd.Rows[i].Cells[4].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 522, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dgv_mwrd.Rows[i].Cells[5].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 620, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dgv_mwrd.Rows[i].Cells[6].Value.ToString(), n, Brushes.Black, marg * 2 + 20, prehights + 30 + rowshight - 5 - 35);

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
            e.Graphics.DrawRectangle(Pens.Black, marg, prehights, e.PageBounds.Width - marg * 2, rowshight - 12);


            e.Graphics.DrawString("م", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 20, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 24, prehights, e.PageBounds.Width - marg * 2 - 24, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("الكود", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 75, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 80, prehights, e.PageBounds.Width - marg * 2 - 80, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("نوع العملية", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 230, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - colwidth2 - 20, prehights, e.PageBounds.Width - colwidth2 - 20, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("التاريخ", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 350, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3 - 5, prehights, e.PageBounds.Width - marg * 2 - colwidth3 - 5, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("رصيد أول", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 40 - 300 - 114, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 455, prehights, e.PageBounds.Width - marg * 2 - 455, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("المبلغ", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 522, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth4 - 120, prehights, e.PageBounds.Width - marg * 2 - colwidth4 - 120, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("رصيد آخر", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 625, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 625, prehights, e.PageBounds.Width - marg * 2 - 625, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("نوع الرصيد", f, Brushes.Black, marg * 2, prehights + 15);
            //e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3 - 170, prehights, e.PageBounds.Width - marg * 2 - colwidth3 - 170, prehights + 30 + rowshight - 5 - 35);
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
        private void button4_Click(object sender, EventArgs e)
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
    }
}
