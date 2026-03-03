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
using WindowsFormsApplication2.UI;

namespace WindowsFormsApplication2.PL
{
    public partial class frm_cstmr_details : Form
    {
        BL.cls_orders order = new BL.cls_orders();
        BL.cls_cstmrs cstmr = new BL.cls_cstmrs();
        public frm_cstmr_details()
        {
            InitializeComponent();
            
            ApplyModernTheme();
        }
        
        private void ApplyModernTheme()
        {
            // Apply modern form styling
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = ModernTheme.NormalFont;
            
            // Style TextBoxes
            StyleTextBoxes();
            
            // Style Labels
            StyleLabels();
            
            // Style Buttons
            StyleButtons();
            
            // Style GroupBoxes
            StyleGroupBoxes();
            
            // Style DataGridViews
            StyleDataGridViews();
        }
        
        private void StyleTextBoxes()
        {
            // Financial summary textboxes with special styling
            if (txttotal != null)
            {
                txttotal.BackColor = Color.FromArgb(220, 248, 198); // Light green for total
                txttotal.BorderStyle = BorderStyle.FixedSingle;
                txttotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                txttotal.ForeColor = Color.FromArgb(39, 174, 96); // Dark green text
                txttotal.TextAlign = HorizontalAlignment.Center;
            }
            
            if (txtmsdd != null)
            {
                txtmsdd.BackColor = Color.FromArgb(255, 243, 205); // Light orange for paid
                txtmsdd.BorderStyle = BorderStyle.FixedSingle;
                txtmsdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                txtmsdd.ForeColor = Color.FromArgb(230, 126, 34); // Dark orange text
                txtmsdd.TextAlign = HorizontalAlignment.Center;
            }
            
            if (txtmtpakii != null)
            {
                txtmtpakii.BackColor = Color.FromArgb(248, 215, 218); // Light red for remaining
                txtmtpakii.BorderStyle = BorderStyle.FixedSingle;
                txtmtpakii.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                txtmtpakii.ForeColor = Color.FromArgb(220, 53, 69); // Dark red text
                txtmtpakii.TextAlign = HorizontalAlignment.Center;
            }
            
            if (txt_total_mrtg3 != null)
            {
                txt_total_mrtg3.BackColor = Color.FromArgb(255, 243, 205); // Light orange for returns
                txt_total_mrtg3.BorderStyle = BorderStyle.FixedSingle;
                txt_total_mrtg3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                txt_total_mrtg3.ForeColor = Color.FromArgb(230, 126, 34); // Dark orange text
                txt_total_mrtg3.TextAlign = HorizontalAlignment.Center;
            }
            
            if (txt_rseed_first != null)
            {
                txt_rseed_first.BackColor = Color.FromArgb(220, 248, 198); // Light green for initial balance
                txt_rseed_first.BorderStyle = BorderStyle.FixedSingle;
                txt_rseed_first.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                txt_rseed_first.ForeColor = Color.FromArgb(39, 174, 96); // Dark green text
                txt_rseed_first.TextAlign = HorizontalAlignment.Center;
            }
            
            // Readonly customer info textboxes
            if (txtcstid != null)
            {
                txtcstid.BackColor = Color.FromArgb(248, 249, 250); // Very light gray for readonly
                txtcstid.ForeColor = ModernTheme.TextSecondary;
                txtcstid.BorderStyle = BorderStyle.FixedSingle;
                txtcstid.Font = ModernTheme.NormalFont;
            }
            
            if (txtcstnme != null)
            {
                txtcstnme.BackColor = Color.FromArgb(248, 249, 250); // Very light gray for readonly
                txtcstnme.ForeColor = ModernTheme.TextSecondary;
                txtcstnme.BorderStyle = BorderStyle.FixedSingle;
                txtcstnme.Font = ModernTheme.NormalFont;
            }
        }
        
        private void StyleLabels()
        {
            Label[] labels = { label1, label2, label3, label4, label5, label6, label7 };
            
            foreach (Label label in labels)
            {
                if (label != null)
                {
                    ModernTheme.StyleLabel(label, LabelStyle.Normal);
                    label.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    label.ForeColor = ModernTheme.TextPrimary;
                    
                    // Special styling for financial summary labels
                    if (label == label1) // Total purchases
                    {
                        label.BackColor = Color.FromArgb(220, 248, 198);
                        label.Text = "💰 إجمالي البضاعة المسحوبة";
                    }
                    else if (label == label4) // Paid amount
                    {
                        label.BackColor = Color.FromArgb(255, 243, 205);
                        label.Text = "💳 مسدد منها";
                    }
                    else if (label == label5) // Remaining amount
                    {
                        label.BackColor = Color.FromArgb(248, 215, 218);
                        label.Text = "⚠️ مدان ب";
                    }
                    else if (label == label6) // Total returns
                    {
                        label.BackColor = Color.FromArgb(255, 243, 205);
                        label.Text = "↩️ إجمالي المرتجع";
                    }
                    else if (label == label7) // Initial balance
                    {
                        label.BackColor = Color.FromArgb(220, 248, 198);
                        label.Text = "🏦 رصيد أول";
                    }
                    else if (label == label2) // Customer ID
                    {
                        label.Text = "🆔 كود العميل:";
                    }
                    else if (label == label3) // Customer name
                    {
                        label.Text = "👤 اسم العميل:";
                    }
                }
            }
        }
        
        private void StyleButtons()
        {
            // Customer Payments Button
            if (button2 != null)
            {
                ModernTheme.StyleButton(button2, ButtonStyle.Success);
                button2.Text = "💳 مدفوعات العميل";
                button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            
            // Print Report Button
            if (button3 != null)
            {
                ModernTheme.StyleButton(button3, ButtonStyle.Primary);
                button3.Text = "🖨️ طباعة تقرير العميل (مشتريات و تحصيل)";
                button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            
            // Close Button
            if (button1 != null)
            {
                ModernTheme.StyleButton(button1, ButtonStyle.Danger);
                button1.Text = "❌ خروج";
                button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }
        
        private void StyleGroupBoxes()
        {
            if (groupBox1 != null)
            {
                ModernTheme.StyleGroupBox(groupBox1);
                groupBox1.BackColor = ModernTheme.BackgroundCard;
                groupBox1.ForeColor = ModernTheme.TextPrimary;
                groupBox1.Text = "📋 الفواتير الخاصة بالعميل";
                groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            }
            
            if (groupBox2 != null)
            {
                ModernTheme.StyleGroupBox(groupBox2);
                groupBox2.BackColor = ModernTheme.BackgroundCard;
                groupBox2.ForeColor = ModernTheme.TextPrimary;
                groupBox2.Text = "↩️ فواتير المرتجع";
                groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            }
        }
        
        private void StyleDataGridViews()
        {
            if (dataGridView1 != null)
            {
                ModernTheme.StyleDataGridView(dataGridView1);
            }
            
            if (dgv_asnaaf != null)
            {
                ModernTheme.StyleDataGridView(dgv_asnaaf);
            }
            
            if (dgv_fwateer != null)
            {
                ModernTheme.StyleDataGridView(dgv_fwateer);
            }
        }
        public void refresh_frm()
        {
            //txtmsdd.Text = (from DataGridViewRow row in dataGridView1.Rows
            //                where row.Cells[2].FormattedValue.ToString() != string.Empty
            //                select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
            //txtmtpakii.Text = (from DataGridViewRow row in dataGridView1.Rows
            //                   where row.Cells[3].FormattedValue.ToString() != string.Empty
            //                   select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            txttotal.Text = (from DataGridViewRow row in dataGridView1.Rows
                             where row.Cells[4].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            

            double msdd_when_create = (from DataGridViewRow row in dataGridView1.Rows
                                       where row.Cells[2].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum();
            frm_mwrd_pays frm_false = new frm_mwrd_pays();
            frm_false.dgv_mdfo3at.DataSource = cstmr.get_all_cstmr_pays(Convert.ToInt32(txtcstid.Text));
            object some = cstmr.get_all_cstmr_pays(Convert.ToInt32(txtcstid.Text)).Compute("Sum(المدفوع)", string.Empty);
            double previous_pays = 0;
            if (!string.IsNullOrEmpty(some.ToString()))
            {
                previous_pays = Convert.ToDouble(some);
            }

            txtmsdd.Text = (msdd_when_create + previous_pays).ToString();

            double hand_written_rseed = (from DataGridViewRow row in frm_false.dgv_mdfo3at.Rows
                                         where row.Cells[3].FormattedValue.ToString() == "0"
                                         select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum();
            //txt_total_mrtg3.Text = (from DataGridViewRow row in dgv_fwateer.Rows
            //                        where row.Cells[1].FormattedValue.ToString() != string.Empty
            //                        select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum().ToString();
            double old_mrtg3_total = (from DataGridViewRow row in dgv_fwateer.Rows
                                      where row.Cells[1].FormattedValue.ToString() != string.Empty && row.Cells[5].FormattedValue.ToString() == string.Empty
                                      select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum();
            double new_mrtg3_total = (from DataGridViewRow row in dgv_fwateer.Rows
                                      where row.Cells[5].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum();
            txt_total_mrtg3.Text = (new_mrtg3_total + old_mrtg3_total).ToString();
            //
            txtmtpakii.Text = (Convert.ToDouble(txttotal.Text) + hand_written_rseed -
            Convert.ToDouble(txt_total_mrtg3.Text) - Convert.ToDouble(txtmsdd.Text)).ToString();
            txt_rseed_first.Text = hand_written_rseed.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            refresh_frm();
        }

        private void frm_cstmr_details_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

            refresh_frm();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            refresh_frm();
        }

        private void dgv_fwateer_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_asnaaf.DataSource = cstmr.get_all_fatora_mrtg3_products(Convert.ToInt32(dgv_fwateer.CurrentRow.Cells[0].Value));

            }
            catch (Exception)
            {
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            refresh_frm(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_cstmr_pays frm = new frm_cstmr_pays();
            frm.label_id.Text = this.txtcstid.Text;
            frm.label_nme.Text = this.txtcstnme.Text;
            frm.dataGridView1.DataSource = cstmr.get_all_cstmr_pays(Convert.ToInt32(this.txtcstid.Text));
            frm.dataGridView2.DataSource = order.get_cstmr_orders(this.txtcstid.Text);

            frm.label_total_mdfo3.Text = (from DataGridViewRow row in frm.dataGridView1.Rows
                                     where row.Cells[3].FormattedValue.ToString() != string.Empty &&row.Cells[6].FormattedValue.ToString() !="خصم مسموح به"
                                     select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            //if (frm.dataGridView1.Rows.Count<=1)
            //{
            //    frm.label_first_rseed.Text=(from DataGridViewRow row in dataGridView1.Rows
            //                   where row.Cells[3].FormattedValue.ToString() != string.Empty
            //                   select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            //}
            //else
            //{
            //    frm.label_first_rseed.Text = frm.dataGridView1.Rows[frm.dataGridView1.Rows.Count - 2].Cells[4].Value.ToString();
            //}
            double hand_written_rseed = (from DataGridViewRow row in frm.dataGridView1.Rows
                                         where row.Cells[3].FormattedValue.ToString() =="0"
                                         select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum();

            double previous_mtbaki = (from DataGridViewRow row in dataGridView1.Rows
                                      where row.Cells[3].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum();
            frm.label_first_rseed.Text = txtmtpakii.Text; //(hand_written_rseed+previous_mtbaki).ToString();
            for (int i = 0; i < frm.dataGridView2.Rows.Count - 1; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (string.IsNullOrEmpty(frm.dataGridView2.Rows[i].Cells[j].Value.ToString()))
                    {
                        frm.dataGridView2.Rows[i].Cells[j].Value = "0";
                    }
                }
            }
            frm.ShowDialog();
            refresh_frm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //frm_mwrd_pays frm_false = new frm_mwrd_pays();
            //frm_false.dgv_mdfo3at.DataSource = cstmr.get_all_cstmr_pays(Convert.ToInt32(txtcstid.Text));
            //if ((dataGridView1.Rows.Count + frm_false.dgv_mdfo3at.Rows.Count  - 2)>27)
            //{
            //    PrintDialog printDlg = new PrintDialog();


            //    printDlg.AllowSelection = true;

            //    printDlg.AllowSomePages = true;

            //    //Call ShowDialog

            //    if (printDlg.ShowDialog() == DialogResult.OK)

            //        printDocument1.Print();

            //}
            //else
            //{
            //    ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            //    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        printDocument1.Print();
            //    }
            //}
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
            string cstmrid = "كود العميل : " + txtcstid.Text;
            string cstname = "اسم العميل: " + txtcstnme.Text;
            string datee = "التاريخ : " + DateTime.Now.ToShortDateString();
            //////
            string first_rseed = "رصيد أول : " + txt_rseed_first.Text;
            string total_mshtriat = "اجمالي مشتريات : " + txttotal.Text;
            string mrtg3 = "اجمالي مرتجع : " + txt_total_mrtg3.Text;
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
            //e.Graphics.DrawLine(Pens.DarkBlue, marg, e.PageBounds.Height - 35, e.PageBounds.Width - (marg), e.PageBounds.Height - 35);
            e.Graphics.FillRectangle(Brushes.WhiteSmoke, new Rectangle(0, e.PageBounds.Height - 30, (int)(e.PageBounds.Width), e.PageBounds.Bottom));
            e.Graphics.DrawString("صفحة : " + page_num, f, Brushes.DarkBlue, marg, e.PageBounds.Height - 30);
            e.Graphics.DrawString(Program.FooterAllReportsText, n, Brushes.Black, (e.PageBounds.Width / 6) + 20, e.PageBounds.Height - 30);


            e.Graphics.DrawString(Program.company_name, v, Brushes.Blue, 5, 5);
            e.Graphics.DrawString(Program.details_1, f, Brushes.BlueViolet, marg, marg + txt_hight);
            e.Graphics.DrawString(Program.details_2, f, Brushes.BlueViolet, marg, marg + (txt_hight * 2) - 15);
            e.Graphics.DrawString(Program.telephon_1, f, Brushes.Black, marg, marg + (txt_hight * 3) - 30);
                //e.Graphics.DrawString(" للأدوات الصحية ", f, Brushes.BlueViolet, marg, marg + txt_hight);
                //e.Graphics.DrawString("والمواسير الألمانية وأنظمة المياة", f, Brushes.BlueViolet, marg, marg + (txt_hight * 2) - 15);
                //e.Graphics.DrawString("الحاج/مصطفي/01022070794", f, Brushes.Black, marg, marg + (txt_hight * 3) - 30);
            
           
            e.Graphics.DrawString("تقرير عميل", col_header, Brushes.DarkRed, (e.PageBounds.Width / 2)+10 - 70, marg/2);



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

            for (; i < dataGridView1.Rows.Count - 1; i++)
            {

                e.Graphics.DrawString((i + 1).ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 20, prehights + 30 + rowshight - 36);


                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 75, prehights + 30 + rowshight - 4 - 35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 200, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 56 - 20, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 111 - 56, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 90, prehights + 30 + rowshight - 5 - 35);
                e.Graphics.DrawString(this.dataGridView1.Rows[i].Cells[6].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 111 - 56 - 40, prehights + 30 + rowshight-5-35);
                e.Graphics.DrawLine(Pens.Black, marg, prehights + colhight + rowshight - 30, e.PageBounds.Width - marg, prehights + colhight + rowshight - 30);
                rowshight += 30;

                if ((i%28)==0&&i!=0)
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


            e.Graphics.DrawString("مصاريف نقل", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 111 - 56 - 50, prehights + 20);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3 - 200, prehights, e.PageBounds.Width - marg * 2 - colwidth3 - 200, prehights + 30 + rowshight - 5 - 35);




            //////////////////////////////////////////////////////////////////////////////////////////الجدول الثاني
            frm_mwrd_pays frm_false = new frm_mwrd_pays();
            frm_false.dgv_mdfo3at.DataSource = cstmr.get_all_cstmr_pays(Convert.ToInt32(txtcstid.Text));
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
                        e.Graphics.DrawString(frm_false.dgv_mdfo3at.Rows[ii].Cells[6].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 111 - 56 - 40, new_rowshight + new_start);

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
                        e.Graphics.DrawString("رد للعميل", n, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 111 - 56 - 40, new_rowshight + new_start);

                        e.Graphics.DrawLine(Pens.Black, marg, new_rowshight + new_start+25, e.PageBounds.Width - marg, new_rowshight + new_start+25);
                        new_rowshight += 30;
                    }
                }

                if ((ii + dataGridView1.Rows.Count - 1) %28==0)
                {
                    e.HasMorePages = true;
                    break;
                }
                
            }


            /////////////////////////////////////////////////////////////////////////////////////////////
            e.Graphics.DrawString("عمليات التحصيل", col_header, Brushes.DarkRed, (e.PageBounds.Width/2) - 70, rowshight + 135);
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
