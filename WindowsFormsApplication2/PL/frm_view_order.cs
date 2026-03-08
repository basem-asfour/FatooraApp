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
    public partial class frm_view_order : Form
    {
        double printpages = 0;
        BL.cls_products product = new BL.cls_products();
        DataTable dt_combobox;
        private static frm_view_order frm;
        static void frm_formclesed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static frm_view_order getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new frm_view_order();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclesed);
                }
                return frm;
            }
        }
        DataTable dt = new DataTable();
        BL.cls_orders order = new BL.cls_orders();
        void calctotalprice()
        {
            if (txtprice.Text != string.Empty && txtqte.Text != string.Empty && txtds.Text != string.Empty)
            {

                double xx = Convert.ToDouble(txtprice.Text) * Convert.ToInt32(txtqte.Text);

                txttp.Text = (xx - (xx / 100 * Convert.ToDouble(txtds.Text))).ToString();
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
        }
        void createdatatable()
        {
            dt.Columns.Add("كود الصنف");
            dt.Columns.Add("اسم الصنف");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("السعر");
            dt.Columns.Add("(%)الخصم");
            dt.Columns.Add("سعر المستهلك");
            dt.Columns.Add("السعر الكلي");
            dataGridView6.DataSource = dt;


        }
        //حساب صافي الربح
        double mksab = 0;
       public void calcprofit()
        {
            for (int i = 0; i < dataGridView5.Rows.Count-1; i++)
			{
                mksab += Convert.ToDouble(this.dataGridView5.Rows[i].Cells[7].Value)-Convert.ToDouble(this.dataGridView5.Rows[i].Cells[2].Value) * Convert.ToDouble(this.dataGridView5.Rows[i].Cells[3].Value);

			}
           


        }

        public frm_view_order()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            createdatatable();
            dataGridView7_new_orders.DataSource = order.get_all_new_orders();
            dt_combobox = product.get_all_products();
            comboBox2.DataSource = dt_combobox;
            comboBox2.DisplayMember = "اسم الصنف";
            comboBox2.ValueMember = "id";
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string double_snf = "";
            //موضوع لو الصنف متكرر يخليه صنف واحد ويجمع الكميتين والاجمالي
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                double_snf = dataGridView1.Rows[i].Cells[1].Value.ToString();

                for (int j = 0; j < dataGridView1.Rows.Count-1; j++)
                {
                    if (dataGridView1.Rows[j].Cells[1].Value.ToString()==double_snf &&i!=j)
                    {
                      MessageBox.Show("سيتم دمج الصنف :  " + double_snf, "صنف مكرر", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        dataGridView1.Rows[i].Cells[2].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value)+Convert.ToInt32(dataGridView1.Rows[j].Cells[2].Value);
                        dataGridView1.Rows[i].Cells[6].Value = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value) + Convert.ToDouble(dataGridView1.Rows[j].Cells[6].Value);
                        dataGridView1.Rows[i].Cells[3].Value =Math.Round(( Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value) / Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value)),2);                        

                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows[j].Index);
                    }
                }
            }
            ///نهاية الموضوع اللي فوق 
            //if (dataGridView1.Rows.Count > 29)
            //{
            PrintDialog printDlg = new PrintDialog();


            printDlg.AllowSelection = true;

            printDlg.AllowSomePages = true;

            //Call ShowDialog

            if (printDlg.ShowDialog() == DialogResult.OK)

                printDocument1.Print();


            //}
            //else
            //{
            //    ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            //    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        printDocument1.Print();
            //    }
            //}


            ///////////
            //((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            //if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    printDocument1.Print();
            //}
           // i = -1;
            ii = -1;
            mslsl = 0;
            page_num = 0;
        }


        private void frm_view_order_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[1].Width = 200;
            dataGridView4.SendToBack();
            dataGridView5.SendToBack();
            dataGridView6.SendToBack();
            dataGridView7.SendToBack();
            dataGridView7_new_orders.SendToBack();
            dataGridView8_cstmr_id.SendToBack();
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

            const float marg = 30f;
            const float rowHeight = 26f;
            const int maxRowsPerPage = 26;
            float pageW = e.PageBounds.Width;
            float pageH = e.PageBounds.Height;
            float tableWidth = pageW - marg * 2;
            float tableLeft = marg;
            float tableRight = pageW - marg;

            // RTL column proportions (right to left): م | الكود | اسم الصنف | الكميه | السعر | السعر الكلي
            float[] colRatios = { 0.05f, 0.09f, 0.42f, 0.10f, 0.14f, 0.20f };
            float[] colX = new float[7]; // 7 edges for 6 columns
            colX[0] = tableRight;
            for (int c = 0; c < 6; c++)
                colX[c + 1] = colX[c] - tableWidth * colRatios[c];
            string[] colHeaders = { "م", "الكود", "اسم الصنف", "الكميه", "السعر", "السعر الكلي" };

            Font fontTitle = new Font(Program.PrintFontType, 20, FontStyle.Bold);
            Font fontSub = new Font(Program.PrintFontType, 9, FontStyle.Regular);
            Font fontHeader = new Font(Program.PrintFontType, 10, FontStyle.Bold);
            Font fontBody = new Font(Program.PrintFontType, 10, FontStyle.Regular);
            Font fontFooter = new Font(Program.PrintFontType, 8, FontStyle.Regular);
            Font fontTotals = new Font(Program.PrintFontType, 10, FontStyle.Bold);

            Color colorPrimary = Color.FromArgb(44, 62, 80);
            Color colorHeaderBg = Color.FromArgb(245, 246, 248);
            Color colorRowAlt = Color.FromArgb(252, 252, 254);
            Color colorLine = Color.FromArgb(210, 210, 210);
            Color colorAccent = Color.FromArgb(41, 128, 185);
            SolidBrush brushPrimary = new SolidBrush(colorPrimary);
            SolidBrush brushText = new SolidBrush(Color.FromArgb(60, 60, 60));
            SolidBrush brushLight = new SolidBrush(Color.FromArgb(120, 120, 120));
            Pen penLine = new Pen(colorLine, 0.6f);
            Pen penAccent = new Pen(colorAccent, 1.2f);

            StringFormat sfCenter = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            StringFormat sfRight = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };

            try
            {
                float y = marg;

                // ===== PAGE 1 HEADER =====
                if (page_num == 1)
                {
                    // Logo (centered, aspect-ratio preserved)
                    if (Program.PrintWaterMarkImageSource != null)
                    {
                        try
                        {
                            using (var src = new Bitmap(Program.PrintWaterMarkImageSource))
                            {
                                int maxLogoH = 60;
                                float aspect = (float)src.Width / src.Height;
                                int logoH = maxLogoH;
                                int logoW = (int)(logoH * aspect);
                                if (logoW > 120) { logoW = 120; logoH = (int)(logoW / aspect); }
                                int logoX = (int)(pageW / 2 - logoW / 2);
                                e.Graphics.DrawImage(src, logoX, (int)y, logoW, logoH);
                                y += logoH + 6f;
                            }
                        }
                        catch { y += 6f; }
                    }

                    // Company name (centered)
                    e.Graphics.DrawString(Program.company_name, fontTitle, brushPrimary, pageW / 2f, y, sfCenter);
                    y += fontTitle.Height + 6f;

                    // Two-column info: company details (left) | invoice details (right)
                    float infoTop = y;
                    float leftX = marg + 4f;
                    float rightX = pageW - marg - 4f;
                    StringFormat sfLeftAlign = new StringFormat { LineAlignment = StringAlignment.Near };

                    e.Graphics.DrawString(Program.details_1 ?? "", fontSub, brushLight, leftX, y, sfLeftAlign);
                    y += fontSub.Height + 1f;
                    e.Graphics.DrawString(Program.details_2 ?? "", fontSub, brushLight, leftX, y, sfLeftAlign);
                    y += fontSub.Height + 1f;
                    e.Graphics.DrawString(Program.telephon_1 ?? "", fontSub, brushLight, leftX, y, sfLeftAlign);
                    y += fontSub.Height + 1f;
                    e.Graphics.DrawString(Program.telephon_2 ?? "", fontSub, brushLight, leftX, y, sfLeftAlign);

                    float ry = infoTop;
                    e.Graphics.DrawString("فاتورة رقم : " + txtordr_id.Text, fontHeader, new SolidBrush(colorAccent), rightX, ry, new StringFormat { Alignment = StringAlignment.Far });
                    ry += fontHeader.Height + 3f;
                    e.Graphics.DrawString("التاريخ : " + txtdate.Text, fontSub, brushText, rightX, ry, new StringFormat { Alignment = StringAlignment.Far });
                    ry += fontSub.Height + 2f;
                    e.Graphics.DrawString("العميل : " + txtcstmr_name.Text, fontSub, brushText, rightX, ry, new StringFormat { Alignment = StringAlignment.Far });
                    ry += fontSub.Height + 2f;
                    if (dataGridView4.Rows.Count > 0 && dataGridView4.Rows[0].Cells[0].Value != null)
                    {
                        e.Graphics.DrawString("العنوان : " + dataGridView4.Rows[0].Cells[0].Value.ToString(), fontSub, brushText, rightX, ry, new StringFormat { Alignment = StringAlignment.Far });
                        ry += fontSub.Height + 2f;
                    }
                    e.Graphics.DrawString("البائع : " + txtbaya.Text, fontSub, brushText, rightX, ry, new StringFormat { Alignment = StringAlignment.Far });

                    y = Math.Max(y, ry) + fontSub.Height + 10f;

                    // Accent line separator
                    e.Graphics.DrawLine(penAccent, marg, y, pageW - marg, y);
                    y += 12f;
                }
                else
                {
                    y = marg + 8f;
                }

                // ===== TABLE HEADER =====
                float headerY = y;
                float headerH = 28f;
                e.Graphics.FillRectangle(new SolidBrush(colorHeaderBg), tableLeft, headerY, tableWidth, headerH);

                for (int c = 0; c < 6; c++)
                {
                    float cx = (colX[c] + colX[c + 1]) / 2f;
                    RectangleF cellRect = new RectangleF(colX[c + 1], headerY, colX[c] - colX[c + 1], headerH);
                    e.Graphics.DrawString(colHeaders[c], fontHeader, brushPrimary, cellRect, sfCenter);
                }
                e.Graphics.DrawLine(penAccent, tableLeft, headerY + headerH, tableRight, headerY + headerH);

                y = headerY + headerH;
                int rowsOnThisPage = 0;

                // ===== DATA ROWS =====
                for (; i < dataGridView1.Rows.Count - 1; i++)
                {
                    float rowY = y + rowsOnThisPage * rowHeight;

                    if (rowsOnThisPage % 2 == 1)
                        e.Graphics.FillRectangle(new SolidBrush(colorRowAlt), tableLeft, rowY, tableWidth, rowHeight);

                    string[] vals = {
                        (i + 1).ToString(),
                        dataGridView1.Rows[i].Cells[0].Value?.ToString() ?? "",
                        dataGridView1.Rows[i].Cells[1].Value?.ToString() ?? "",
                        dataGridView1.Rows[i].Cells[2].Value?.ToString() ?? "",
                        dataGridView1.Rows[i].Cells[3].Value?.ToString() ?? "",
                        dataGridView1.Rows[i].Cells[6].Value?.ToString() ?? ""
                    };

                    for (int c = 0; c < 6; c++)
                    {
                        RectangleF cellRect = new RectangleF(colX[c + 1] + 2f, rowY, colX[c] - colX[c + 1] - 4f, rowHeight);
                        e.Graphics.DrawString(vals[c], fontBody, brushText, cellRect, sfCenter);
                    }

                    e.Graphics.DrawLine(penLine, tableLeft, rowY + rowHeight, tableRight, rowY + rowHeight);

                    rowsOnThisPage++;
                    if (rowsOnThisPage >= maxRowsPerPage)
                    {
                        e.HasMorePages = true;
                        break;
                    }
                }

                float tableBottom = y + rowsOnThisPage * rowHeight;

                // Vertical column lines
                for (int c = 1; c < 6; c++)
                    e.Graphics.DrawLine(penLine, colX[c], headerY, colX[c], tableBottom);
                e.Graphics.DrawRectangle(new Pen(colorLine, 0.8f), tableLeft, headerY, tableWidth, tableBottom - headerY);

                // ===== FOOTER: Totals =====
                float footerY = pageH - marg - 56f;
                e.Graphics.DrawLine(penLine, marg, footerY - 6f, pageW - marg, footerY - 6f);

                string totalP = "اجمالي الفاتورة : " + txttotal.Text;
                string pmsdd = dataGridView2.Rows.Count > 0 && dataGridView2.Rows[0].Cells[0].Value != null
                    ? "مبلغ مسدد : " + dataGridView2.Rows[0].Cells[0].Value.ToString() : "مبلغ مسدد : —";
                string pmtpkii = dataGridView3.Rows.Count > 0 && dataGridView3.Rows[0].Cells[0].Value != null
                    ? "المبلغ المتبقي : " + dataGridView3.Rows[0].Cells[0].Value.ToString() : "المبلغ المتبقي : —";

                // Three columns at footer: right = total, middle = paid, left = remaining
                float third = tableWidth / 3f;
                e.Graphics.DrawString(totalP, fontTotals, brushPrimary,
                    new RectangleF(tableRight - third, footerY, third, 20f), sfCenter);
                e.Graphics.DrawString(pmsdd, fontBody, brushText,
                    new RectangleF(tableRight - third * 2, footerY, third, 20f), sfCenter);
                e.Graphics.DrawString(pmtpkii, fontBody, brushText,
                    new RectangleF(tableLeft, footerY, third, 20f), sfCenter);

                // Page number + footer text
                float bottomY = pageH - marg - 16f;
                e.Graphics.DrawString("صفحة " + page_num, fontFooter, brushLight, marg, bottomY);
                if (!string.IsNullOrEmpty(Program.FooterInvoiceText))
                    e.Graphics.DrawString(Program.FooterInvoiceText, fontFooter, brushLight, pageW / 2f, bottomY, sfCenter);

                // ===== WATERMARK (page 1 only, very subtle) =====
                if (page_num == 1 && Program.PrintWaterMarkImageSource != null)
                {
                    try
                    {
                        using (var src = new Bitmap(Program.PrintWaterMarkImageSource))
                        {
                            float wmAspect = (float)src.Width / src.Height;
                            int wmH = 280;
                            int wmW = (int)(wmH * wmAspect);
                            ColorMatrix matrix = new ColorMatrix();
                            matrix.Matrix33 = 0.08f;
                            ImageAttributes attr = new ImageAttributes();
                            attr.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                            e.Graphics.DrawImage(src,
                                new Rectangle((int)(pageW - wmW) / 2, (int)(pageH - wmH) / 2, wmW, wmH),
                                0, 0, src.Width, src.Height, GraphicsUnit.Pixel, attr);
                        }
                    }
                    catch { }
                }
            }
            finally
            {
                fontTitle?.Dispose();
                fontSub?.Dispose();
                fontHeader?.Dispose();
                fontBody?.Dispose();
                fontFooter?.Dispose();
                fontTotals?.Dispose();
                brushPrimary?.Dispose();
                brushText?.Dispose();
                brushLight?.Dispose();
                penLine?.Dispose();
                penAccent?.Dispose();
                sfCenter?.Dispose();
                sfRight?.Dispose();
            }
        }

        /// <summary>Gets the serial from order_details for thermal print. Uses only order_details.serials, not product_serials.</summary>
        private string GetSerialForOrderLine(DataGridViewRow row)
        {
            if (row == null) return "";
            var dt = dataGridView1.DataSource as DataTable;
            if (dt == null) return "";
            if (dt.Columns.Contains("serials"))
            {
                var v = row.Cells["serials"].Value;
                if (v != null && !string.IsNullOrWhiteSpace(v.ToString())) return v.ToString().Trim();
            }
            if (dt.Columns.Contains("serial"))
            {
                var v = row.Cells["serial"].Value;
                if (v != null && !string.IsNullOrWhiteSpace(v.ToString())) return v.ToString().Trim();
            }
            if (row.Cells.Count > 7)
            {
                var v = row.Cells[7].Value;
                if (v != null && !string.IsNullOrWhiteSpace(v.ToString())) return v.ToString().Trim();
            }
            return "";
        }

        private void button_thermal_Click(object sender, EventArgs e)
        {
            try
            {
                int w58 = (int)(58f / 25.4f * 100f);
                try
                {
                    printDocumentThermal.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("58mm Thermal", w58, 5000);
                }
                catch { }
                PrintDialog dlg = new PrintDialog { Document = printDocumentThermal };
                if (dlg.ShowDialog() == DialogResult.OK)
                    printDocumentThermal.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في الطباعة: " + ex.Message, "طباعة حراري", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocumentThermal_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float pageW = e.PageBounds.Width > 0 ? e.PageBounds.Width : 220f;
            float W = Math.Min(215f, pageW - 10f);
            float x = 5f, y = 4f;
            Font fontTitle = new Font("Arial", 10, FontStyle.Bold);
            Font fontBody = new Font("Arial", 8, FontStyle.Regular);
            Font fontSmall = new Font("Arial", 7, FontStyle.Regular);
            StringFormat sfCenter = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Near };
            StringFormat sfRight = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Near };

            try
            {
                if (Program.PrintWaterMarkImageSource!=null)
                {
                    try
                    {
                        using (var logo = new Bitmap(Program.PrintWaterMarkImageSource))
                        {
                            int maxLogoW = 50;
                            float aspect = (float)logo.Width / logo.Height;
                            int logoW = maxLogoW;
                            int logoH = (int)(logoW / aspect);
                            if (logoH > 50) { logoH = 50; logoW = (int)(logoH * aspect); }
                            float logoX = x + (W - 2 * x - logoW) / 2f;
                            e.Graphics.DrawImage(logo, (int)logoX, (int)y, logoW, logoH);
                            y += logoH + 4f;
                        }
                    }
                    catch { }
                }
                e.Graphics.DrawString(Program.company_name ?? "", fontTitle, Brushes.Black, W / 2f, y, sfCenter);
                y += fontTitle.Height + 2f;
                e.Graphics.DrawString(Program.details_1 ?? "", fontSmall, Brushes.Black, W / 2f, y, sfCenter);
                y += fontSmall.Height + 1f;
                if (!string.IsNullOrEmpty(Program.details_2))
                {
                    e.Graphics.DrawString(Program.details_2 ?? "", fontSmall, Brushes.Black, W / 2f, y, sfCenter);
                    y += fontSmall.Height + 1f;
                }
                string phones = string.Join("  ", new[] { Program.telephon_1 ?? "", Program.telephon_2 ?? "" }.Where(s => !string.IsNullOrEmpty(s)));
                if (!string.IsNullOrEmpty(phones))
                {
                    e.Graphics.DrawString(phones, fontSmall, Brushes.Black, W / 2f, y, sfCenter);
                    y += fontSmall.Height + 2f;
                }
                else
                    y += 2f;
                e.Graphics.DrawLine(Pens.Black, x, y, W - x, y);
                y += 6f;

                e.Graphics.DrawString("فاتورة #" + txtordr_id.Text, fontBody, Brushes.Black, W - x, y, sfRight);
                y += fontBody.Height + 1f;
                e.Graphics.DrawString(txtdate.Text, fontBody, Brushes.Black, W - x, y, sfRight);
                y += fontBody.Height + 1f;
                e.Graphics.DrawString("العميل: " + txtcstmr_name.Text, fontBody, Brushes.Black, W - x, y, sfRight);
                y += fontBody.Height + 4f;
                e.Graphics.DrawLine(Pens.Black, x, y, W - x, y);
                y += 6f;

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string name = dataGridView1.Rows[i].Cells[1].Value?.ToString() ?? "";
                    string qty = dataGridView1.Rows[i].Cells[2].Value?.ToString() ?? "";
                    string price = dataGridView1.Rows[i].Cells[3].Value?.ToString() ?? "";
                    string total = dataGridView1.Rows[i].Cells[6].Value?.ToString() ?? "";
                    string serial = GetSerialForOrderLine(dataGridView1.Rows[i]);

                    e.Graphics.DrawString(name, fontBody, Brushes.Black, new RectangleF(x, y, W - 2 * x, 20f), sfRight);
                    y += fontBody.Height + 2f;
                    if (!string.IsNullOrEmpty(serial))
                    {
                        e.Graphics.DrawString("سيريال: " + serial, fontSmall, Brushes.DarkGray, new RectangleF(x, y, W - 2 * x, 16f), sfRight);
                        y += fontSmall.Height + 2f;
                    }
                    e.Graphics.DrawString(qty + " x " + price + " = " + total, fontSmall, Brushes.Black, W - x, y, sfRight);
                    y += fontSmall.Height + 6f;
                }

                e.Graphics.DrawLine(Pens.Black, x, y, W - x, y);
                y += 6f;
                e.Graphics.DrawString("الإجمالي: " + txttotal.Text, fontTitle, Brushes.Black, W - x, y, sfRight);
                y += fontTitle.Height + 4f;
                if (dataGridView2.Rows.Count > 0 && dataGridView2.Rows[0].Cells[0].Value != null)
                    e.Graphics.DrawString("مسدد: " + dataGridView2.Rows[0].Cells[0].Value.ToString(), fontBody, Brushes.Black, W - x, y, sfRight);
                y += fontBody.Height + 2f;
                if (dataGridView3.Rows.Count > 0 && dataGridView3.Rows[0].Cells[0].Value != null)
                    e.Graphics.DrawString("متبقي: " + dataGridView3.Rows[0].Cells[0].Value.ToString(), fontBody, Brushes.Black, W - x, y, sfRight);
                y += fontBody.Height + 8f;
                e.Graphics.DrawString("شكراً لتعاملكم معنا", fontSmall, Brushes.Black, W / 2f, y, sfCenter);
            }
            finally
            {
                fontTitle?.Dispose();
                fontBody?.Dispose();
                fontSmall?.Dispose();
                sfCenter?.Dispose();
                sfRight?.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الفاتورة بالكامل؟؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    order.tzbeet_qte(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value));
                }
                order.avoid_order(txtordr_id.Text);
                this.Close();
                
            }
            return;
             

        }

        private void button6_Click(object sender, EventArgs e)
        {
            clearboxes();
            frm_products_list frm = new frm_products_list();
            frm.ShowDialog();
            txtid.Text = frm.dgvprdcts.CurrentRow.Cells[0].Value.ToString();
            txtnme.Text = frm.dgvprdcts.CurrentRow.Cells[1].Value.ToString();
            txtpmsthlk.Text = frm.dgvprdcts.CurrentRow.Cells[6].Value.ToString();
            if (txtcstmr_name.Text != "بيع نقدي") //عميل
            {
                txtprice.Text = frm.dgvprdcts.CurrentRow.Cells[4].Value.ToString();

            }
            else if (txtcstmr_name.Text == "بيع نقدي")//مش عميل 
            {
                txtprice.Text = frm.dgvprdcts.CurrentRow.Cells[5].Value.ToString();

            }
            txtprice.Focus();
   
        }

        private void txtqte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtqte.Text != string.Empty)
            {
                txtds.Focus();
            }
        }

        private void txtqte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtqte_KeyUp(object sender, KeyEventArgs e)
        {
            calctotalprice();

        }

        private void txtds_KeyUp(object sender, KeyEventArgs e)
        {
            calctotalprice();

        }

        private void button5_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtid.Text)
                {
                    MessageBox.Show("تم ادخال هذا المنتج مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // return;
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
            DataRow r = dt.NewRow();
        //    dt.Clear();

           
            r[0] = txtid.Text;
            r[1] = txtnme.Text;
            r[2] = txtqte.Text;
            r[3] = txtprice.Text;     
            r[4] = txtds.Text;
            r[5] = txtpmsthlk.Text;
            r[6] = txttp.Text;
            dt.Rows.Add(r);
            //لو حصل حاجه الغي الفور دي 
       /*    for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                  DataRow r1 = dt.NewRow();

           
            r1[0] = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
            r1[1] = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
            r1[2] = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
            r1[3] = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
            r1[4] = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
            r1[5] = this.dataGridView1.Rows[i].Cells[5].Value.ToString();
            r1[6] = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
            dt.Rows.Add(r1);

            }*/
           
           

            dataGridView6.DataSource = dt;
      /*      for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                order.tzbeet_qte(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value));
            }*/
        //    order.avoid_order(txtordr_id.Text);


            //مش لازم فور لوب هنا اصلا لانه كل مره بيبقي صنف واحد
            for (int i = 0; i < dataGridView6.Rows.Count-1; i++)
            {
                order.add_product_to_order(txtordr_id.Text, Convert.ToInt32(dataGridView6.Rows[i].Cells[0].Value),
                    Convert.ToInt32(dataGridView6.Rows[i].Cells[2].Value), dataGridView6.Rows[i].Cells[3].Value.ToString(),
                    Convert.ToDouble(dataGridView6.Rows[i].Cells[4].Value), dataGridView6.Rows[i].Cells[5].Value.ToString(),
                    dataGridView6.Rows[i].Cells[6].Value.ToString(),dataGridView2.Rows[0].Cells[0].Value.ToString(),dataGridView3.Rows[0].Cells[0].Value.ToString());


            }
           
            
            dataGridView1.DataSource = order.get_order_details_for_edit(txtordr_id.Text);
            dataGridView5.DataSource = order.get_price_shraa_for_mksb(txtordr_id.Text);

            mksab = 0;
            calcprofit();
            txtmksb.Text = mksab.ToString();

            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
            }
             txttotal.Text = sum.ToString();
             string new_mtbaki = (Convert.ToDouble(dataGridView3.Rows[0].Cells[0].Value) + Convert.ToDouble(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[6].Value)).ToString();
             double new_total = Convert.ToDouble(txt_transport.Text) + Convert.ToDouble(txttotal.Text);
             this.txt_total_after_transport.Text = new_total.ToString();
             order.update_total_w_reb7(Convert.ToInt32(txtordr_id.Text), new_total.ToString(), txtmksb.Text, new_mtbaki);
             //MessageBox.Show("new_mtbakii :  " + new_mtbaki);

            clearboxes();
            dt.Clear();

            dataGridView2.DataSource = order.get_price_msdd(txtordr_id.Text);
            dataGridView3.DataSource = order.get_price_mtbkii(txtordr_id.Text);
            comboBox2.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            mksab = 0;
            calcprofit();
            txtmksb.Text = mksab.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            mksab = 0;
            for (int i = 0; i < dataGridView5.Rows.Count - 1; i++)
            {
                mksab += Convert.ToDouble(this.dataGridView5.Rows[i].Cells[6].Value) - Convert.ToDouble(this.dataGridView5.Rows[i].Cells[2].Value) * Convert.ToDouble(this.dataGridView5.Rows[i].Cells[3].Value);
                textBox1.Text = mksab.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذا الصنف؟؟","عملية الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                order.delete_product_from_order(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),Convert.ToInt32(txtordr_id.Text));

                try
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                }
                catch (Exception)
                {

                }

                ///////////////////////

                dataGridView5.DataSource = order.get_price_shraa_for_mksb(txtordr_id.Text);


                mksab = 0;
                calcprofit();
                txtmksb.Text = mksab.ToString();

                double sum = 0;
                for (int i = 0; i < frm.dataGridView1.Rows.Count-1; i++)
                {
                    sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                txttotal.Text = sum.ToString();
                string new_mtbaki = (Convert.ToDouble(dataGridView3.Rows[0].Cells[0].Value) - Convert.ToDouble(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[6].Value)).ToString();
                order.update_total_w_reb7(Convert.ToInt32(txtordr_id.Text), txttotal.Text, txtmksb.Text, new_mtbaki);
                ///////////////////
                dataGridView2.DataSource = order.get_price_msdd(txtordr_id.Text);
                dataGridView3.DataSource = order.get_price_mtbkii(txtordr_id.Text);
                
            }
      
         /*   for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                order.tzbeet_qte(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value));
            }
            order.avoid_order(txtordr_id.Text);
            lbl_order_id.Text = order.get_last_order_id().Rows[0][0].ToString();*/


        }

        private void button7_Click_1(object sender, EventArgs e)
        {
          
        }

        private void label8_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = order.get_price_msdd(txtordr_id.Text);
            dataGridView3.DataSource = order.get_price_mtbkii(txtordr_id.Text);
            if (dataGridView2.Rows[0].Cells[0].Value.ToString()==string.Empty||dataGridView3.Rows[0].Cells[0].Value.ToString()==string.Empty)
            {
                txt_7aletha.Text = "لايوجد معلومات ";
                txt_7aletha.BackColor = Color.WhiteSmoke;
            }


            else if (Convert.ToDouble(dataGridView3.Rows[0].Cells[0].Value) == 0)
            {
                txt_7aletha.Text = "مسدده بالكامل";
                txt_7aletha.BackColor = Color.LightGreen;
            }
            else
            {
                txt_7aletha.Text = "غير خالصه";
                txt_7aletha.BackColor = Color.LightCoral;
            }
        }

        private void label8_DoubleClick(object sender, EventArgs e)
        {
            frm_msdd_mtpakii frm = new frm_msdd_mtpakii();
            frm.txttotal.Text = this.txttotal.Text;
            frm.textBox1.Text = this.txtordr_id.Text;
            frm.txtmsdd.Text = this.dataGridView2.Rows[0].Cells[0].Value.ToString();
            frm.txtmtpakii.Text = this.dataGridView3.Rows[0].Cells[0].Value.ToString();

            if (dataGridView2.Rows[0].Cells[0].Value.ToString() == string.Empty || dataGridView3.Rows[0].Cells[0].Value.ToString() == string.Empty)
            {
                frm.radioButton_not5ales.Checked = false;
                frm.radioButton_5ales.Checked = false;
            }

         else if (Convert.ToDouble(dataGridView3.Rows[0].Cells[0].Value) == 0)
            {
                frm.radioButton_5ales.Checked = true;
                frm.radioButton_not5ales.Checked = false;
            }
            else
            {
                frm.radioButton_not5ales.Checked = true;
                frm.radioButton_5ales.Checked = false;

            }
            for (int i = 0; i < dataGridView7_new_orders.Rows.Count-1; i++)
			{
			 if (dataGridView7_new_orders.Rows[i].Cells[0].Value.ToString()==txtordr_id.Text)
            {
                frm.okatabio = "exist";
            }
			}
            
            frm.ShowDialog();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView7_new_orders.Rows.Count - 1; i++)
            {
                //if (dataGridView7_new_orders.Rows[i].Cells[0].Value.ToString() == txtordr_id.Text)
                //{
                //    MessageBox.Show("تم حفظ ربح هذه الفاتورة مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

            }
            if (dataGridView2.Rows[0].Cells[0].Value.ToString()==string.Empty||dataGridView3.Rows[0].Cells[0].Value.ToString()==string.Empty)
            {
                MessageBox.Show("من فضلك حدد المبلغ المسدد والمتبقي","نقص في المعلومات ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            order.Edit_mksb(Convert.ToInt32(txtordr_id.Text),txtmksb.Text);
            MessageBox.Show("تم تعديل المكسب بنجاح ","عملية الحفظ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        //int i = -1;
        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            i++;
            ii++;
            page_num++;
            double cont = Convert.ToDouble(dataGridView1.Rows.Count - 1);
            e.HasMorePages = false;
            Font f = new Font(Program.PrintFontType, 16, FontStyle.Bold);
            Font v = new Font(Program.PrintFontType, 36, FontStyle.Bold);
            Font n = new Font(Program.PrintFontType, 14, FontStyle.Regular);

            float marg = 20;
            string idorder = "رقم الفاتورة : " + txtordr_id.Text;
            string cstname = "اسم العميل: " + txtcstmr_name.Text;
            string datee = "التاريخ : " + txtdate.Text;
            string bayea = "اسم البائع: " + txtbaya.Text;
            string totalP = "اجمالي الفاتورة : " + txttotal.Text;

            double rseed_sabek = 0;
            rseed_sabek = (from DataGridViewRow row in dataGridView7.Rows
                           where row.Cells[0].FormattedValue.ToString() != string.Empty
                           select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum();



            double egmali = Convert.ToDouble(txttotal.Text) + rseed_sabek;
            //string pmsdd = "حساب سابق : " + rseed_sabek.ToString();
            //string pmtpkii = "اجمالي : " + egmali.ToString();

            string pmsdd = "مبلغ مسدد :" + dataGridView2.Rows[0].Cells[0].Value.ToString();
            string pmtpkii = "المبلغ المتبقي :" + dataGridView3.Rows[0].Cells[0].Value.ToString();
            string cstmr_adress = "عنوان العميل :" + dataGridView4.Rows[0].Cells[0].Value.ToString();

            SizeF fontsizeNO = e.Graphics.MeasureString(idorder, f);
            SizeF fontsizename = e.Graphics.MeasureString(cstname, f);
            SizeF fontsizedate = e.Graphics.MeasureString(datee, f);
            SizeF fontsizebayea = e.Graphics.MeasureString(bayea, f);
            SizeF fontsizetotalP = e.Graphics.MeasureString(totalP, f);
            SizeF FpntSizePmsdd = e.Graphics.MeasureString(pmsdd, f);
            SizeF FpntSizePmtpkii = e.Graphics.MeasureString(pmtpkii, f);
            SizeF fontsizeadrss = e.Graphics.MeasureString(cstmr_adress, f);


            e.Graphics.DrawString(Program.company_name, v, Brushes.Blue, 5, 5);
            e.Graphics.DrawString(Program.details_1, f, Brushes.BlueViolet, marg, marg + fontsizebayea.Height+2);
            e.Graphics.DrawString(Program.details_2, f, Brushes.BlueViolet, marg, marg + (fontsizebayea.Height * 2));
            e.Graphics.DrawString(Program.telephon_1, f, Brushes.Black, marg, marg + (fontsizebayea.Height * 3));
      


            e.Graphics.DrawString("رقم الفاتورة : " + txtordr_id.Text, f, Brushes.Blue, (e.PageBounds.Width - fontsizeNO.Width) - marg, marg);
            e.Graphics.DrawString(datee, f, Brushes.Black, (e.PageBounds.Width - fontsizedate.Width) - marg, marg + fontsizeNO.Height);
            e.Graphics.DrawString(cstname, f, Brushes.Black, (e.PageBounds.Width - fontsizename.Width) - marg, marg + fontsizeNO.Height + fontsizedate.Height);
            e.Graphics.DrawString(cstmr_adress, f, Brushes.Black, (e.PageBounds.Width - fontsizeadrss.Width) - marg, marg + fontsizeNO.Height + fontsizedate.Height + fontsizename.Height);

            e.Graphics.DrawString(bayea, f, Brushes.Black, (e.PageBounds.Width - fontsizebayea.Width) - marg, marg + fontsizeNO.Height + fontsizedate.Height + fontsizename.Height + fontsizeadrss.Height);

            e.Graphics.DrawString("صفحة : " + page_num, f, Brushes.Blue, marg, e.PageBounds.Height - 30);

            e.Graphics.DrawLine(Pens.DarkBlue, marg, e.PageBounds.Height - 37, e.PageBounds.Width - (marg), e.PageBounds.Height - 37);
            e.Graphics.DrawString("اعداد برنامج ادارة المخازن والمبيعات : م/باسم عصفور         " + "ت/01153306987", n, Brushes.Black, (e.PageBounds.Width / 6) + 20, e.PageBounds.Height - 30);


            float prehights = marg + fontsizeNO.Height + fontsizename.Height + fontsizedate.Height + fontsizebayea.Height + 30;

            //المستطيل
            e.Graphics.DrawRectangle(Pens.Black, marg, prehights, e.PageBounds.Width - marg * 2, e.PageBounds.Height - marg * 2 - 30 - prehights);
            float colhight =45;

            float colwidth1 = 50;
            float colwidth2 = 300 + colwidth1;
            float colwidth3 = 70 + colwidth2;
            float colwidth4 = 50 + colwidth3;
            float colwidth5 = 50 + colwidth4;
            float colwidth6 = 50 + colwidth5;

            e.Graphics.DrawLine(Pens.Black, marg, prehights + colhight, e.PageBounds.Width - marg, prehights + colhight);

            e.Graphics.DrawString("م", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 20, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 24, prehights, e.PageBounds.Width - marg * 2 - 24, e.PageBounds.Height - marg * 2 - 30);


            e.Graphics.DrawString("الكود", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 65, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 70, prehights, e.PageBounds.Width - marg * 2 - 70, e.PageBounds.Height - marg * 2 - 30);

            e.Graphics.DrawString("اسم الصنف", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 220, prehights + 20);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth2, prehights, e.PageBounds.Width - marg * 2 - colwidth2, e.PageBounds.Height - marg * 2 - 30);

            e.Graphics.DrawString("الكميه", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 56 - 20, prehights + 20);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3, prehights, e.PageBounds.Width - marg * 2 - colwidth3, e.PageBounds.Height - marg * 2 - 30);

            e.Graphics.DrawString("السعر", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 111 - 56, prehights + 20);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3 - 80, prehights, e.PageBounds.Width - marg * 2 - colwidth3 - 80, e.PageBounds.Height - marg * 2 - 30);

            //e.Graphics.DrawString("سعر المستهلك", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 111, prehights + 20);
            //e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3 - 222, prehights, e.PageBounds.Width - marg * 2 - colwidth3 - 222, e.PageBounds.Height - marg * 2 - 30);

            //e.Graphics.DrawString("السعر الكلي", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 111 - 56 - 50, prehights + 20);

            e.Graphics.DrawString("السعر الكلي", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 111, prehights + 20);


            e.Graphics.DrawString(" ملاحظات", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 111 - 56 - 50, prehights + 20);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3 - 222, prehights, e.PageBounds.Width - marg * 2 - colwidth3 - 222, e.PageBounds.Height - marg * 2 - 30);

            ////////////////////////////////////////////
            float rowshight = 55;

            for (; i < dataGridView1.Rows.Count - 1; i++)
            {

                e.Graphics.DrawString((i + 1).ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 20, prehights + 30 + rowshight - 36);


                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 69, prehights + 30 + rowshight - 4 - 35);
               // e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 35, prehights + 30 + rowshight - 5-35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300, prehights + 30 + rowshight - 5-35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 56 - 20, prehights + 30 + rowshight - 5-35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 111 - 56, prehights + 30 + rowshight - 5-35);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[6].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 111, prehights + 30 + rowshight - 5-35);
                //e.Graphics.DrawString(this.dataGridView1.Rows[i].Cells[6].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 300 - 111 - 111 - 111 - 56 - 40, prehights + 30 + rowshight - 5-35);
                e.Graphics.DrawLine(Pens.Black, marg, prehights + colhight + rowshight - 30, e.PageBounds.Width - marg, prehights + colhight + rowshight - 30);

                if (i == 29 || i == 29 * 2 || i == 29 * 3 || i == 29 * 4 || i == 29 * 5 || i == 29 * 6 || i == 29 * 7 || i == 29 * 8 || i == 29 * 9 || i == 29 * 10 || i == 29 * 11 || i == 29 * 12 || i == 29 * 13 || i == 29 * 14 || i == 29 * 15 || i == 29 * 16 || i == 29 * 17 || i == 29 * 18 || i == 29 * 19 || i == 29 * 20 || i == 29 * 21
                    || i == 29 * 22 || i == 29 * 23 || i == 29 * 24 || i == 29 * 25 || i == 29 * 26 || i == 29 * 27 || i == 29 * 28 || i == 29 * 29 || i == 29 * 30 || i == 29 * 31 || i == 29 * 32 || i == 29 * 33 || i == 29 * 34 || i == 29 * 35 || i == 29 * 36 || i == 29 * 37)
               {
                   e.HasMorePages = true;
                   break;
               }
               
                rowshight += 30;
                if (i==cont-1)
                {
                    e.Graphics.DrawString(totalP, f, Brushes.Black, e.PageBounds.Width - marg * 2 - 200, e.PageBounds.Height - marg * 3);
                    e.Graphics.DrawString(pmsdd, f, Brushes.Black, e.PageBounds.Width - marg - 260 - 200, e.PageBounds.Height - marg * 3);
                    e.Graphics.DrawString(pmtpkii, f, Brushes.Black, e.PageBounds.Width - marg - 520 - 200, e.PageBounds.Height - marg * 3);
                }
            }
           
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog2_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            frm_cstmrs_list_forEdit frm = new frm_cstmrs_list_forEdit();
            frm.label1.Text = txtordr_id.Text;

            frm.ShowDialog();
            this.txtcstmr_name.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            if (dataGridView2.Rows[0].Cells[0].Value.ToString() == string.Empty || dataGridView3.Rows[0].Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("من فضلك حدد المبلغ المسدد والمتبقي", "نقص في المعلومات ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            order.add_to_new_orders(Convert.ToInt32(txtordr_id.Text), txtdate.Text, Convert.ToInt32(dataGridView8_cstmr_id.Rows[0].Cells[0].Value), dataGridView2.Rows[0].Cells[0].Value.ToString(), dataGridView3.Rows[0].Cells[0].Value.ToString(), txttotal.Text, txtmksb.Text,Convert.ToInt32(txt_mndb_id.Text),Convert.ToDouble(txt_transport.Text),"");
            MessageBox.Show("تم الحفظ بنجاح ", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtds.Text != string.Empty)
            {
                button6.Focus();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtid.Text)
                    {
                        MessageBox.Show("تم ادخال هذا المنتج مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // return;
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
                DataRow r = dt.NewRow();
                //    dt.Clear();


                r[0] = txtid.Text;
                r[1] = txtnme.Text;
                r[2] = txtqte.Text;
                r[3] = txtprice.Text;
                r[4] = txtds.Text;
                r[5] = txtpmsthlk.Text;
                r[6] = txttp.Text;
                dt.Rows.Add(r);
                //لو حصل حاجه الغي الفور دي 
                /*    for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                     {
                           DataRow r1 = dt.NewRow();

           
                     r1[0] = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                     r1[1] = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                     r1[2] = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                     r1[3] = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                     r1[4] = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
                     r1[5] = this.dataGridView1.Rows[i].Cells[5].Value.ToString();
                     r1[6] = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                     dt.Rows.Add(r1);

                     }*/



                dataGridView6.DataSource = dt;
                /*      for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                      {
                          order.tzbeet_qte(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value));
                      }*/
                //    order.avoid_order(txtordr_id.Text);


                //مش لازم فور لوب هنا اصلا لانه كل مره بيبقي صنف واحد
                for (int i = 0; i < dataGridView6.Rows.Count - 1; i++)
                {
                    order.add_product_to_order(txtordr_id.Text, Convert.ToInt32(dataGridView6.Rows[i].Cells[0].Value),
                        Convert.ToInt32(dataGridView6.Rows[i].Cells[2].Value), dataGridView6.Rows[i].Cells[3].Value.ToString(),
                        Convert.ToDouble(dataGridView6.Rows[i].Cells[4].Value), dataGridView6.Rows[i].Cells[5].Value.ToString(),
                        dataGridView6.Rows[i].Cells[6].Value.ToString(), dataGridView2.Rows[0].Cells[0].Value.ToString(), dataGridView3.Rows[0].Cells[0].Value.ToString());


                }


                dataGridView1.DataSource = order.get_order_details_for_edit(txtordr_id.Text);
                dataGridView5.DataSource = order.get_price_shraa_for_mksb(txtordr_id.Text);

                mksab = 0;
                calcprofit();
                txtmksb.Text = mksab.ToString();

                double sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                txttotal.Text = sum.ToString();
                string new_mtbaki = (Convert.ToDouble(dataGridView3.Rows[0].Cells[0].Value) + Convert.ToDouble(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[6].Value)).ToString();
                double new_total = Convert.ToDouble(txt_transport.Text) + Convert.ToDouble(txttotal.Text);
                this.txt_total_after_transport.Text = new_total.ToString();
                order.update_total_w_reb7(Convert.ToInt32(txtordr_id.Text), new_total.ToString(), txtmksb.Text, new_mtbaki);
                //MessageBox.Show("new_mtbakii :  " + new_mtbaki);

                clearboxes();
                dt.Clear();

                dataGridView2.DataSource = order.get_price_msdd(txtordr_id.Text);
                dataGridView3.DataSource = order.get_price_mtbkii(txtordr_id.Text);
                comboBox2.Focus();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product_id = Convert.ToInt32(comboBox2.SelectedValue);
            txtid.Text = product_id.ToString();
            txtnme.Text = product.get_single_product(product_id).Rows[0][0].ToString();
            txtpmsthlk.Text = product.get_single_product(product_id).Rows[0][5].ToString();
            if (txtcstmr_name.Text != "بيع نقدي") //عميل
            {
                txtprice.Text = product.get_single_product(product_id).Rows[0][3].ToString();

            }
            else if (txtcstmr_name.Text == "بيع نقدي")//مش عميل 
            {
                txtprice.Text = product.get_single_product(product_id).Rows[0][4].ToString();

            }

            txtprice.Focus();
        }

        private void txtprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtprice.Text != string.Empty)
            {
                txtqte.Focus();
            }
        }

        private void txtprice_KeyUp(object sender, KeyEventArgs e)
        {
            calctotalprice();

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

        private void label7_Click(object sender, EventArgs e)
        {
            frm_change_order_date frm = new frm_change_order_date();
            frm.id_order = Convert.ToInt32(this.txtordr_id.Text);
            frm.changed = false;
            
            frm.ShowDialog();
            if (frm.changed)
            {
                this.txtdate.Text = frm.dateTimePicker2.Text;                
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            frm_edit_mndob frm = new frm_edit_mndob();
            frm.id_order = Convert.ToInt32(this.txtordr_id.Text);
            frm.changed = false;

            frm.ShowDialog();
            if (frm.changed)
            {
                this.txt_mndb_id.Text = frm.combo_mndoob.SelectedValue.ToString();
                this.txt_mndbName.Text = frm.combo_mndoob.Text.ToString();
            }
        }
    }
}
