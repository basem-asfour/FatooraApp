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
    public partial class frm_all_mwrdeen_report : Form
    {
        public frm_all_mwrdeen_report()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[8].Value.ToString()))
                {


                    if (Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value) > 0)
                    {
                        dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.Thistle;
                        //dataGridView1.Rows[i].Cells[9].Value = "مدين";
                    }
                    else if (Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value) == 0)
                    {
                        dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.LightGreen;
                        //dataGridView1.Rows[i].Cells[9].Value = "خالص";
                    }
                    else if (Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value) < 0)
                    {
                        dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.LightSalmon;
                        //dataGridView1.Rows[i].Cells[9].Value = "دائن";
                        dataGridView1.Rows[i].Cells[8].Value = Math.Abs(Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value));
                    }
                }

            }
        }
        public int i = -1;
        public int ii = -1;
        public int mslsl = 0;
        public int page_num = 0;
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
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
            //string cstmrid = "كود العميل : " + combo_cstmr.SelectedValue;
            //string cstname = "اسم العميل: " + combo_cstmr.Text;
            string datee = "التاريخ : " + DateTime.Now.ToShortDateString();
            //////




            SizeF fontsizegate = e.Graphics.MeasureString(datee, f);
            ////////

            //الحاجات اللي في اخر الفاتورة
            //e.Graphics.DrawLine(Pens.DarkBlue, marg, e.PageBounds.Height - 130, e.PageBounds.Width - (marg), e.PageBounds.Height - 130);


            //e.Graphics.DrawLine(Pens.DarkBlue, marg, e.PageBounds.Height - 35, e.PageBounds.Width - (marg), e.PageBounds.Height - 35);
            e.Graphics.FillRectangle(Brushes.WhiteSmoke, new Rectangle(0, e.PageBounds.Height - 30, (int)(e.PageBounds.Width), e.PageBounds.Bottom));
            e.Graphics.DrawString("صفحة : " + page_num, f, Brushes.DarkBlue, marg, e.PageBounds.Height - 30);
            e.Graphics.DrawString(Program.FooterAllReportsText, n, Brushes.Black, (e.PageBounds.Width / 6) + 20, e.PageBounds.Height - 30);


            if (page_num == 1)
            {
                e.Graphics.DrawRectangle(Pens.Black, marg, 3, (e.PageBounds.Width / 2) - 140, marg + txt_hight * 3 - 7);
                e.Graphics.DrawString(Program.company_name, v, Brushes.Blue, 20, 5);
                //e.Graphics.DrawString(" للأدوات الصحية ", f, Brushes.BlueViolet, marg, marg + txt_hight);
                //e.Graphics.DrawString("والمواسير الألمانية وأنظمة المياة", f, Brushes.BlueViolet, marg, marg + (txt_hight * 2) - 15);
                //e.Graphics.DrawString("الحاج/مصطفي/01022070794", f, Brushes.Black, marg, marg + (txt_hight * 3) - 30);

                e.Graphics.DrawString(Program.details_1, f, Brushes.BlueViolet, marg, marg + txt_hight);
                e.Graphics.DrawString(Program.details_2, f, Brushes.BlueViolet, marg, marg + (txt_hight * 2) - 15);
                e.Graphics.DrawString(Program.telephon_1, f, Brushes.Black, marg, marg + (txt_hight * 3) - 30);

                e.Graphics.DrawRectangle(Pens.DarkRed, (e.PageBounds.Width / 2) - 70, marg / 2, 150, 30);
                e.Graphics.DrawString("تقرير جميع الموردين", col_header, Brushes.DarkRed, (e.PageBounds.Width / 2) + 10 - 70, marg / 2);
                e.Graphics.DrawString(datee, f, Brushes.Black, (e.PageBounds.Width - fontsizegate.Width) - marg, marg + txt_hight - 10);
            }


            //e.Graphics.DrawString("العرض : "+e.PageBounds.Width, col_header, Brushes.DarkGreen, (e.PageBounds.Width / 2) + 50 , marg+ 80);
            //e.Graphics.DrawString("الطول : " + e.PageBounds.Height, col_header, Brushes.DarkGreen, (e.PageBounds.Width / 2) + 50, marg +50);




            float prehights = marg + txt_hight * 3;

            ////المستطيل
            //e.Graphics.DrawRectangle(Pens.Black, marg, prehights, e.PageBounds.Width - marg * 2, e.PageBounds.Height - marg * 2 - 30 - prehights);
            float colhight = 45;
            float diff_betwn_line_and_word = 2;


            float colwidth1 = 30;
            float colwidth2 = 40 + colwidth1;
            float colwidth3 = 180 + colwidth2;
            float colwidth4 = 60 + colwidth3;
            float colwidth5 = 60 + colwidth4;
            float colwidth6 = 60 + colwidth5;
            float colwidth7 = 60 + colwidth6;
            float colwidth8 = 80 + colwidth7;
            float colwidth9 = 60 + colwidth8;
            float colwidth10 = 60 + colwidth9;
            float colwidth11 = 85 + colwidth10;
            if (page_num != 1)
            {
                prehights = 20;
            }

            e.Graphics.DrawLine(Pens.Black, marg, prehights + colhight - 5, e.PageBounds.Width - marg, prehights + colhight - 5);


            //  e.Graphics.DrawString("عمليات الشراء", col_header, Brushes.DarkRed, (e.PageBounds.Width / 2) - 70, marg + (txt_hight * 3) - 30);

            ////////////////////////////////////////////
            float rowshight = 50;

            for (; i < dataGridView1.Rows.Count - 1; i++)
            {

                e.Graphics.DrawString((i + 1).ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth1 + diff_betwn_line_and_word, prehights + 30 + rowshight - 36);


                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth2 + diff_betwn_line_and_word, prehights + 30 + rowshight - 4 - 35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth3 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth4 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth5 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth6 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth7 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[6].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth8 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[7].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth9 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[8].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth10 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[9].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg - colwidth11 + diff_betwn_line_and_word, prehights + 30 + rowshight - 5 - 35);

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


            e.Graphics.DrawString("الكود", f, Brushes.Black, e.PageBounds.Width - marg - colwidth2 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth2, prehights, e.PageBounds.Width - marg - colwidth2, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("اسم المورد", f, Brushes.Black, e.PageBounds.Width - marg - colwidth3 + diff_betwn_line_and_word + 50, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth3, prehights, e.PageBounds.Width - marg - colwidth3, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("رصيد أول", f, Brushes.Black, e.PageBounds.Width - marg - colwidth4 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth4, prehights, e.PageBounds.Width - marg - colwidth4, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("مشتريات", f, Brushes.Black, e.PageBounds.Width - marg - colwidth5 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth5, prehights, e.PageBounds.Width - marg - colwidth5, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("استرجاع",f, Brushes.Black, e.PageBounds.Width - marg - colwidth6 + diff_betwn_line_and_word, prehights + 3);
            e.Graphics.DrawString("من المورد", f, Brushes.Black, e.PageBounds.Width - marg - colwidth6 + diff_betwn_line_and_word, prehights + 20);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth6, prehights, e.PageBounds.Width - marg - colwidth6, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("دفع", f, Brushes.Black, e.PageBounds.Width - marg - colwidth7 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth7, prehights, e.PageBounds.Width - marg - colwidth7, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("خصم مكتسب", f, Brushes.Black, e.PageBounds.Width - marg - colwidth8 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth8, prehights, e.PageBounds.Width - marg - colwidth8, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("مرتجع", f, Brushes.Black, e.PageBounds.Width - marg - colwidth9 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth9, prehights, e.PageBounds.Width - marg - colwidth9, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("الرصيد", f, Brushes.Black, e.PageBounds.Width - marg - colwidth10 + diff_betwn_line_and_word, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth10, prehights, e.PageBounds.Width - marg - colwidth10, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("نوع الرصيد", f, Brushes.Black, e.PageBounds.Width - marg - colwidth11 + diff_betwn_line_and_word, prehights + 15);
            // e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg - colwidth11, prehights, e.PageBounds.Width - marg - colwidth11, prehights + 30 + rowshight - 5 - 35);

            ColorMatrix matrix = new ColorMatrix();
            matrix.Matrix33 = (float)0.2;
            ImageAttributes attr = new ImageAttributes();
            attr.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            var src_water_mark = new Bitmap(Program.PrintUpperImageSource);
            e.Graphics.DrawImage(src_water_mark, new Rectangle((e.PageBounds.Width / 2) - 200, (e.PageBounds.Height / 2) - 250, 400, 400), 0, 0, src_water_mark.Width, src_water_mark.Height, GraphicsUnit.Pixel, attr);

        }
    }
}
