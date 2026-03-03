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
using WindowsFormsApplication2.BL;
using WindowsFormsApplication2.UI;

namespace WindowsFormsApplication2.PL
{
    public partial class frm_cstmr_report : Form
    {
        DataTable dt_cstmr = new DataTable();
        DataTable dt_all = new DataTable();
        BL.cls_cstmrs cstmr = new BL.cls_cstmrs();

        public frm_cstmr_report()
        {
            InitializeComponent();
            
            ApplyModernTheme();
            
            dt_cstmr = cstmr.get_all_cstmrs();
            combo_cstmr.DataSource = dt_cstmr;
            combo_cstmr.DisplayMember = "اسم العميل";
            combo_cstmr.ValueMember = "id_cstmr";
            combo_cstmr.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }
        
        private void ApplyModernTheme()
        {
            // Apply modern form styling
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            
            // Style ComboBoxes
            StyleComboBoxes();
            
            // Style DateTimePickers
            StyleDateTimePickers();
            
            // Style Labels
            StyleLabels();
            
            // Style Buttons
            StyleButtons();
            
            // Style TextBoxes
            StyleTextBoxes();
            
            // Style DataGridViews
            StyleDataGridViews();
        }
        
        private void StyleComboBoxes()
        {
            if (combo_cstmr != null)
            {
                ModernTheme.StyleComboBox(combo_cstmr);
                combo_cstmr.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            }
        }
        
        private void StyleDateTimePickers()
        {
            if (dateTimePicker1 != null)
            {
                dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                dateTimePicker1.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular);
                dateTimePicker1.CalendarTitleBackColor = ModernTheme.PrimaryColor;
                dateTimePicker1.CalendarTitleForeColor = ModernTheme.TextLight;
            }
            
            if (dateTimePicker2 != null)
            {
                dateTimePicker2.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                dateTimePicker2.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular);
                dateTimePicker2.CalendarTitleBackColor = ModernTheme.PrimaryColor;
                dateTimePicker2.CalendarTitleForeColor = ModernTheme.TextLight;
            }
        }
        
        private void StyleLabels()
        {
            // Only labels that exist on this form (from Designer)
            Label[] labels = { label1, label3, label7, label_days };
            
            foreach (Label label in labels)
            {
                if (label != null)
                {
                    ModernTheme.StyleLabel(label, LabelStyle.Normal);
                    label.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                    label.ForeColor = ModernTheme.TextPrimary;
                    label.UseCompatibleTextRendering = false;
                    label.AutoSize = false;
                }
            }
        }
        
        private void StyleButtons()
        {
            // Get all buttons using reflection or manual list
            Button[] buttons = { button4, button5, button11 };
            
            foreach (Button button in buttons)
            {
                if (button != null)
                {
                    if (button == button4) // Print button
                    {
                        ModernTheme.StyleButton(button, ButtonStyle.Primary);
                        button.Text = "🖨️ طباعة التقرير";
                        button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    }
                    else if (button == button5) // Filter by date button
                    {
                        ModernTheme.StyleButton(button, ButtonStyle.Success);
                        button.Text = "🔍 فلترة بالتاريخ";
                        button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    }
                    else if (button == button11) // Generate report button
                    {
                        ModernTheme.StyleButton(button, ButtonStyle.Primary);
                        button.Text = "📊 إنشاء التقرير";
                        button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    }
                    
                    button.UseCompatibleTextRendering = false;
                }
            }
        }
        
        private void StyleTextBoxes()
        {
            // Financial summary textboxes with special styling
            TextBox[] summaryBoxes = { txt_total_bee3, txt_total_first_rseed, txt_total_ta7seel, txt_total_5sm, txt_total_metg3, txt_total_rd, txt_safi };
            
            foreach (TextBox textBox in summaryBoxes)
            {
                if (textBox != null)
                {
                    textBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    textBox.TextAlign = HorizontalAlignment.Center;
                    textBox.ReadOnly = true;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    
                    // Apply semantic colors based on content
                    if (textBox == txt_total_bee3 || textBox == txt_total_first_rseed || textBox == txt_total_rd)
                    {
                        textBox.BackColor = Color.FromArgb(220, 248, 198); // Light green for positive amounts
                        textBox.ForeColor = Color.FromArgb(39, 174, 96); // Dark green text
                    }
                    else if (textBox == txt_total_ta7seel || textBox == txt_total_metg3 || textBox == txt_total_5sm)
                    {
                        textBox.BackColor = Color.FromArgb(255, 243, 205); // Light orange for payments/deductions
                        textBox.ForeColor = Color.FromArgb(230, 126, 34); // Dark orange text
                    }
                    else if (textBox == txt_safi)
                    {
                        textBox.BackColor = Color.FromArgb(248, 215, 218); // Light red for remaining balance
                        textBox.ForeColor = Color.FromArgb(220, 53, 69); // Dark red text
                    }
                }
            }
        }
        
        private void StyleDataGridViews()
        {
            if (dataGridView1 != null)
            {
                ModernTheme.StyleDataGridView(dataGridView1);
            }
            
            if (dgv_cstmrs != null)
            {
                ModernTheme.StyleDataGridView(dgv_cstmrs);
            }
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
        //public DataTable sort_dgv(DataTable dt, DateTime d1, DateTime d2)
        //{
        //    DateTime min= Convert.ToDateTime(dt.Rows[0][2]);
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dt.Rows.Count; j++)
        //        {
        //            min = Convert.ToDateTime(dt.Rows[j][2]);
        //            if (Convert.ToDateTime(dt.Rows[i][2]) < Convert.ToDateTime(dt.Rows[j][2]))
        //                Swap(x: ref data[i], y: ref data[min]);
        //        }
        //    }
        //}
        //private static void Swap(ref DataRow x, ref DataRow y)
        //{
        //    x = x + y;
        //    y = x - y;
        //    x = x - y;
        //}

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cstmr.get_cstmr_mrtg3_for_cstmr_report(Convert.ToInt32(combo_cstmr.SelectedValue), "");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[5].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells[4].Value = dataGridView1.Rows[i].Cells[5].Value;
                }
            }
            dataGridView1.Columns.RemoveAt(5);
            dt_all.Clear();
            dt_all.Merge(cstmr.get_cstmr_pays_first_rseed_for_cstmr_report(Convert.ToInt32(combo_cstmr.SelectedValue), ""));
            dt_all.Merge(cstmr.get_cstmr_orders_for_cstmr_report(Convert.ToInt32(combo_cstmr.SelectedValue), ""));
            dt_all.Merge(cstmr.get_cstmr_orders_msdd_for_cstmr_report(Convert.ToInt32(combo_cstmr.SelectedValue), ""));
            dt_all.Merge(cstmr.get_cstmr_pays_for_cstmr_report(Convert.ToInt32(combo_cstmr.SelectedValue), ""));
            dt_all.Merge(dataGridView1.DataSource as DataTable);
            dt_all.Columns.RemoveAt(7);
            dt_all.Columns[2].DataType = typeof(DateTime);
            dgv_cstmrs.DataSource = dt_all;
            dgv_cstmrs.Columns[2].ValueType = typeof(DateTime);
            dgv_cstmrs.Columns[2].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";

            dgv_cstmrs.Sort(dgv_cstmrs.Columns[2] , ListSortDirection.Ascending);
            //dgv_cstmrs.Sort(new RowComparer(SortOrder.Ascending));
            for (int i = 0; i < dgv_cstmrs.Rows.Count-1; i++)
            {
                
                
                if (i>0)
                {
                    dgv_cstmrs.Rows[i].Cells[3].Value = dgv_cstmrs.Rows[i - 1].Cells[5].Value;
                }

                if (string.IsNullOrEmpty(dgv_cstmrs.Rows[i].Cells[1].Value.ToString()))
                {
                    if (dgv_cstmrs.Rows[i].Cells[4].Value.ToString()=="0")
                    {
                        dgv_cstmrs.Rows[i].Cells[1].Value = "اضافة رصيد";
                    }
                    if (Convert.ToDouble(dgv_cstmrs.Rows[i].Cells[4].Value)>0)
                    {
                        dgv_cstmrs.Rows[i].Cells[1].Value = "تحصيل";
                    }
                    if (Convert.ToDouble(dgv_cstmrs.Rows[i].Cells[4].Value) < 0)
                    {
                        dgv_cstmrs.Rows[i].Cells[1].Value = "رد للعميل";
                    }
                }
                try
                {
                    if (i == 0)
                    {
                        Convert.ToDouble(dgv_cstmrs.Rows[i].Cells[3].Value);
                        if (dgv_cstmrs.Rows[i].Cells[1].Value.ToString() == "اضافة رصيد")
                        {
                            dgv_cstmrs.Rows[i].Cells[3].Value = 0;
                            dgv_cstmrs.Rows[i].Cells[4].Value = dgv_cstmrs.Rows[i].Cells[5].Value;
                        }
                    }
                }
                catch (Exception)
                {

                    dgv_cstmrs.Rows[i].Cells[3].Value = 0;
                }
                if (dgv_cstmrs.Rows[i].Cells[1].Value.ToString()=="تحصيل"||dgv_cstmrs.Rows[i].Cells[1].Value.ToString()=="خصم مسموح به"||
                    dgv_cstmrs.Rows[i].Cells[1].Value.ToString().Contains("مسدد من فاتورة بيع رقم") || dgv_cstmrs.Rows[i].Cells[1].Value.ToString() == "مرتجع")
                {
                    dgv_cstmrs.Rows[i].Cells[1].Style.ForeColor = Color.DarkGreen;
                    dgv_cstmrs.Rows[i].Cells[5].Value = Convert.ToDouble(dgv_cstmrs.Rows[i].Cells[3].Value) - Convert.ToDouble(dgv_cstmrs.Rows[i].Cells[4].Value);
                }
                if (dgv_cstmrs.Rows[i].Cells[1].Value.ToString() == "رد للعميل" || dgv_cstmrs.Rows[i].Cells[1].Value.ToString() == "فاتورة بيع" )
                {
                    if (Convert.ToDouble(dgv_cstmrs.Rows[i].Cells[4].Value)>0)
                    {
                        dgv_cstmrs.Rows[i].Cells[5].Value = Convert.ToDouble(dgv_cstmrs.Rows[i].Cells[3].Value) + Convert.ToDouble(dgv_cstmrs.Rows[i].Cells[4].Value);

                    }
                    else
                    {
                        dgv_cstmrs.Rows[i].Cells[5].Value = Convert.ToDouble(dgv_cstmrs.Rows[i].Cells[3].Value) +Math.Abs(Convert.ToDouble(dgv_cstmrs.Rows[i].Cells[4].Value));
                        dgv_cstmrs.Rows[i].Cells[4].Value = Math.Abs(Convert.ToDouble(dgv_cstmrs.Rows[i].Cells[4].Value));
                    }
                    dgv_cstmrs.Rows[i].Cells[1].Style.ForeColor = Color.Red;
                
                }
                if (dgv_cstmrs.Rows[i].Cells[1].Value.ToString() == "اضافة رصيد"&&i>0)
                {
                    dgv_cstmrs.Rows[i].Cells[1].Style.ForeColor = Color.Red;
                    dgv_cstmrs.Rows[i].Cells[4].Value = Convert.ToDouble(dgv_cstmrs.Rows[i].Cells[5].Value);
                    dgv_cstmrs.Rows[i].Cells[5].Value = Convert.ToDouble(dgv_cstmrs.Rows[i].Cells[5].Value) + Convert.ToDouble(dgv_cstmrs.Rows[i-1].Cells[5].Value);
                }
                if (Convert.ToDouble(dgv_cstmrs.Rows[i].Cells[5].Value)>0)
                {
                    dgv_cstmrs.Rows[i].Cells[6].Value = "مدين";
                    dgv_cstmrs.Rows[i].Cells[6].Style.ForeColor = Color.Blue;
                }
                else if (Convert.ToDouble(dgv_cstmrs.Rows[i].Cells[5].Value) < 0)
                {
                    dgv_cstmrs.Rows[i].Cells[6].Value = "دائن";
                    dgv_cstmrs.Rows[i].Cells[6].Style.ForeColor = Color.DarkOrange;

                }
                else if (Convert.ToDouble(dgv_cstmrs.Rows[i].Cells[5].Value) == 0)
                {
                    dgv_cstmrs.Rows[i].Cells[6].Value = "خالص";
                    dgv_cstmrs.Rows[i].Cells[6].Style.ForeColor = Color.SpringGreen;

                }
            }
            dgv_cstmrs.Columns[4].DefaultCellStyle.BackColor = Color.LightCyan;
            /////
            txt_total_bee3.Text = (from DataGridViewRow row in dgv_cstmrs.Rows
                                   where row.Cells[4].FormattedValue.ToString() != string.Empty && row.Cells[1].FormattedValue.ToString() =="فاتورة بيع"
                                     select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_total_first_rseed.Text = (from DataGridViewRow row in dgv_cstmrs.Rows
                                   where row.Cells[4].FormattedValue.ToString() != string.Empty && row.Cells[1].FormattedValue.ToString() == "اضافة رصيد"
                                   select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_total_ta7seel.Text = (from DataGridViewRow row in dgv_cstmrs.Rows
                                      where row.Cells[4].FormattedValue.ToString() != string.Empty && row.Cells[1].FormattedValue.ToString() == "تحصيل" || row.Cells[4].FormattedValue.ToString() != string.Empty && row.Cells[1].FormattedValue.ToString().Contains("مسدد من فاتورة بيع")
                                   select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_total_5sm.Text = (from DataGridViewRow row in dgv_cstmrs.Rows
                                   where row.Cells[4].FormattedValue.ToString() != string.Empty && row.Cells[1].FormattedValue.ToString() == "خصم مسموح به"
                                   select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_total_metg3.Text = (from DataGridViewRow row in dgv_cstmrs.Rows
                                   where row.Cells[4].FormattedValue.ToString() != string.Empty && row.Cells[1].FormattedValue.ToString() == "مرتجع"
                                   select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_total_rd.Text = (from DataGridViewRow row in dgv_cstmrs.Rows
                                   where row.Cells[4].FormattedValue.ToString() != string.Empty && row.Cells[1].FormattedValue.ToString() == "رد للعميل"
                                   select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();

            try
            {
                txt_safi.Text = Math.Round((Convert.ToDouble(txt_total_bee3.Text)+Convert.ToDouble(txt_total_first_rseed.Text)+Convert.ToDouble(txt_total_rd.Text)
                    - Convert.ToDouble(txt_total_ta7seel.Text) - Convert.ToDouble(txt_total_metg3.Text) - Convert.ToDouble(txt_total_5sm.Text)),2).ToString();
            }
            catch (Exception)
            {

                txt_safi.Text = "رجاء مراجعة القيم";
            }
        }

        private void frm_cstmr_report_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button11_Click(sender, e);
            dgv_cstmrs.ReadOnly = false;
            dgv_cstmrs.CurrentRow.Selected = false;

            foreach (var item in get_dates_between(dateTimePicker1.Value, dateTimePicker2.Value))
            {
                foreach (DataGridViewRow row in dgv_cstmrs.Rows)
                {
                    if (row.Index<dgv_cstmrs.Rows.Count-1)
                    {
                        if (row.Cells[2].Value.ToString().Contains(item.ToString("dd/MM/yyyy")))
                        {
                            row.Selected = true;
                        }
                    }
                    
                }
            }
            dgv_cstmrs.ReadOnly = true;
            //List<int> xx = new List<int>();
            //for (int i = 0; i < dgv_cstmrs.Rows.Count-1; i++)
            //{
            //    if (dgv_cstmrs.Rows[i].Selected == false)
            //    {
            //        xx.Add(i);
            //    }
            //}
            //for (int i =xx.Count-1; i>= 0 ; i--)
            //{
            //    dgv_cstmrs.Rows.RemoveAt(i);
            //}

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
            string cstmrid = "كود العميل : " + combo_cstmr.SelectedValue;
            string cstname = "اسم العميل: " + combo_cstmr.Text;
            string datee = "التاريخ : " + DateTime.Now.ToShortDateString();
            //////
            string first_rseed = "رصيد أول : " + txt_total_first_rseed.Text;
            string total_mshtriat = "اجمالي مبيعات : " + txt_total_bee3.Text;
            string mrtg3 = "اجمالي مرتجع : " + txt_total_metg3.Text;
            string msdd = "مسدد : " + txt_total_ta7seel.Text;
            string rd = "رد للعميل : " + txt_total_rd.Text;
            string khsm = "خصم مسموح به : " + txt_total_5sm.Text;
            string mtbaki = "مدان ب : " + txt_safi.Text;


            SizeF FpntSizeid = e.Graphics.MeasureString(cstmrid, f);
            SizeF FpntSizenme = e.Graphics.MeasureString(cstname, f);
            SizeF fontsizegate = e.Graphics.MeasureString(datee, f);
            ////////
            SizeF FontSizefirst_rseed = e.Graphics.MeasureString(first_rseed, f);
            SizeF FontSizetotal_mshtriat = e.Graphics.MeasureString(total_mshtriat, f);
            SizeF fontsizemrtg3 = e.Graphics.MeasureString(mrtg3, f);
            SizeF FontSizemsdd = e.Graphics.MeasureString(msdd, f);
            SizeF FontSizmtbaki = e.Graphics.MeasureString(mtbaki, f);

            SizeF FontSizekhsm= e.Graphics.MeasureString(khsm, f);
            SizeF FontSizerd = e.Graphics.MeasureString(rd, f);
            //الحاجات اللي في اخر الفاتورة
            e.Graphics.DrawLine(Pens.DarkBlue, marg , e.PageBounds.Height - 130, e.PageBounds.Width - (marg ), e.PageBounds.Height - 130);
            e.Graphics.DrawString(first_rseed, f, Brushes.Black, e.PageBounds.Width - FontSizefirst_rseed.Width - (marg * 2), e.PageBounds.Height - 120);
            e.Graphics.DrawString(total_mshtriat, f, Brushes.Black, e.PageBounds.Width - FontSizetotal_mshtriat.Width - (marg * 2), e.PageBounds.Height - 90);
            e.Graphics.DrawString(mrtg3, f, Brushes.Black, e.PageBounds.Width - fontsizemrtg3.Width - (marg * 2), e.PageBounds.Height - 65);
            e.Graphics.DrawString(msdd, f, Brushes.Black, (e.PageBounds.Width / 2) - FontSizemsdd.Width - (marg * 2)+150, e.PageBounds.Height - 120);
            e.Graphics.DrawString(rd, f, Brushes.Black, (e.PageBounds.Width / 2) - FontSizerd.Width - (marg * 2) + 150, e.PageBounds.Height - 90);
            e.Graphics.DrawString(khsm, f, Brushes.Black, (e.PageBounds.Width / 2) - FontSizekhsm.Width - (marg * 2) + 150, e.PageBounds.Height - 65);
           
            e.Graphics.DrawString(mtbaki, f, Brushes.Blue, (e.PageBounds.Width / 3) - FontSizmtbaki.Width - (marg * 2), e.PageBounds.Height - 90);


            e.Graphics.FillRectangle(Brushes.WhiteSmoke, new Rectangle(0, e.PageBounds.Height - 30, (int)(e.PageBounds.Width), e.PageBounds.Bottom));
            e.Graphics.DrawString("صفحة : " + page_num, f, Brushes.DarkBlue, marg, e.PageBounds.Height - 30);
            e.Graphics.DrawString(Program.FooterAllReportsText, n, Brushes.Black, (e.PageBounds.Width / 6) + 20, e.PageBounds.Height - 30);



            e.Graphics.DrawRectangle(Pens.Black, marg, 3, (e.PageBounds.Width / 2) - 140, marg + txt_hight * 3 - 7);
            //e.Graphics.DrawRectangle(Pens.DarkRed, (e.PageBounds.Width / 2) + 75, 3, (e.PageBounds.Width / 2) - 100, marg + txt_hight * 3 - 7);
            e.Graphics.DrawString(Program.company_name, v, Brushes.Blue, 20, 5);
            e.Graphics.DrawString(Program.details_1, f, Brushes.BlueViolet, marg, marg + txt_hight);
            e.Graphics.DrawString(Program.details_2, f, Brushes.BlueViolet, marg, marg + (txt_hight * 2) - 15);
            e.Graphics.DrawString(Program.telephon_1, f, Brushes.Black, marg, marg + (txt_hight * 3) - 30);
            //e.Graphics.DrawString(" للأدوات الصحية ", f, Brushes.BlueViolet, marg, marg + txt_hight);
            //e.Graphics.DrawString("والمواسير الألمانية وأنظمة المياة", f, Brushes.BlueViolet, marg, marg + (txt_hight * 2) - 15);
            //e.Graphics.DrawString("الحاج/مصطفي/01022070794", f, Brushes.Black, marg, marg + (txt_hight * 3) - 30);


            e.Graphics.DrawRectangle(Pens.DarkRed, (e.PageBounds.Width / 2) - 70, marg / 2, 110, 30);
            e.Graphics.DrawString("تقرير عميل", col_header, Brushes.DarkRed, (e.PageBounds.Width / 2) + 10 - 70, marg / 2);



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

            for (; i < dgv_cstmrs.Rows.Count - 1; i++)
            {

                e.Graphics.DrawString((i + 1).ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 20, prehights + 30 + rowshight - 36);


                e.Graphics.DrawString(dgv_cstmrs.Rows[i].Cells[0].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 75, prehights + 30 + rowshight - 4 - 35);
                e.Graphics.DrawString(dgv_cstmrs.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, e.PageBounds.Width - marg * 2 - 270, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(Convert.ToDateTime(dgv_cstmrs.Rows[i].Cells[2].Value.ToString()).ToShortDateString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 376, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dgv_cstmrs.Rows[i].Cells[3].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 111, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dgv_cstmrs.Rows[i].Cells[4].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 522, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dgv_cstmrs.Rows[i].Cells[5].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 620, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dgv_cstmrs.Rows[i].Cells[6].Value.ToString(), n, Brushes.Black, marg * 2 + 20, prehights + 30 + rowshight - 5 - 35);
                
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
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 90, prehights, e.PageBounds.Width - marg * 2 - 90, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("نوع العملية", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 230, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - colwidth2-20, prehights, e.PageBounds.Width - colwidth2-20, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("التاريخ", f, Brushes.Black, e.PageBounds.Width - marg * 2 -  350 , prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3-5, prehights, e.PageBounds.Width - marg * 2 - colwidth3-5, prehights + 30 + rowshight - 5 - 35);

            e.Graphics.DrawString("رصيد أول", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 40 - 300 - 114 , prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 455, prehights, e.PageBounds.Width - marg * 2 - 455, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("المبلغ", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 522, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth4 - 120, prehights, e.PageBounds.Width - marg * 2 - colwidth4 - 120, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("رصيد آخر", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 625 , prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 625, prehights, e.PageBounds.Width - marg * 2 - 625, prehights + 30 + rowshight - 5 - 35);


            e.Graphics.DrawString("نوع الرصيد", f, Brushes.Black,  marg * 2  , prehights + 15);
            //e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3 - 170, prehights, e.PageBounds.Width - marg * 2 - colwidth3 - 170, prehights + 30 + rowshight - 5 - 35);
            ColorMatrix matrix = new ColorMatrix();
            matrix.Matrix33 = (float)0.2;
            ImageAttributes attr = new ImageAttributes();
            attr.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            var src_water_mark = new Bitmap(Program.PrintUpperImageSource);
            e.Graphics.DrawImage(src_water_mark, new Rectangle((e.PageBounds.Width / 2) - 200, (e.PageBounds.Height / 2) - 250, 400, 400), 0, 0, src_water_mark.Width, src_water_mark.Height, GraphicsUnit.Pixel, attr);

        }
    }
}
