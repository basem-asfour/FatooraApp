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
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace WindowsFormsApplication2.PL
{
    public partial class frm_products : Form 
    {
        
        private static frm_products frm;
        static void frm_formclesed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
       public static frm_products getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new frm_products();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclesed);
                }
                return frm;
            }
        }

     
        BL.cls_products prd = new BL.cls_products();
        BL.cls_purchases purch = new BL.cls_purchases();
        BL.cls_orders order = new BL.cls_orders();
        BL.cls_mwrdeen mwrd = new BL.cls_mwrdeen();
        public string id;
        DAL.DATAaccesslayer dal = new DAL.DATAaccesslayer();
        DataTable dt_price_shraa_for_corrupted=new System.Data.DataTable();
        DataTable dt_gard = new System.Data.DataTable();
        DataTable dt_cat = new DataTable();
        public frm_products()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            dt_cat = prd.get_all_catogries();
            combo_cat.DataSource = dt_cat;
            combo_cat.DisplayMember = "النوع";
            combo_cat.ValueMember = "id";
            /*
            //***********************************************(عشان اقرا الاصناف بطريقه جديده)*****************************************************
            
            string selectdata = "SELECT * FROM products";
            //  انشاء وتعريف كائن من كلاس الجدول DataTable 
            DataTable DT = new DataTable();
            // استقبال البيانات من دالة تنفيذ استعلام استرجاع البيانات الى كائن الجدول.   
            DT = dal.ExecSelect(selectdata);
            //  اضافة الجدول لل DataGridView لعرضها على الفورم.
            dataGridView1.DataSource = DT; 
           // this.dataGridView1.DataSource = prd.get_all_products(); ********
            //****************************************************************************************************
            */

            this.dataGridView1.DataSource = prd.get_all_products();
            createdatatable();
            createdatatable_gard();
            //مجموع الاجمالي
         /*   double sum = 0;
            for (int i = 0; i < this.dataGridView1.Rows.Count-1; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
            }
            textBox2.Text = sum.ToString();*/
            

        }
        void createdatatable()
        {
            dt_price_shraa_for_corrupted.Columns.Add("الكمية");            
            dt_price_shraa_for_corrupted.Columns.Add("السعر");

        }
        private void OnBottonHover(Button button)
        {
            button.BackColor = Color.DarkBlue;
            button.ForeColor = Color.AliceBlue;
        }
        private void OnBottonLeave(Button button)
        {
            button.ForeColor = Color.Black;
            button.BackColor = Color.MintCream;
        }
        void createdatatable_gard()
        {
            dt_gard.Columns.Add("كود الصنف");
            dt_gard.Columns.Add("اسم الصنف");
            dt_gard.Columns.Add("كمية كارت الصنف");
            dt_gard.Columns.Add("كمية ادارة الاصناف");


        }

        private void frm_products_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[1].Width = 210;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.searchproduct(textBox1.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_add_product frm = new frm_add_product("");
            frm.state = "add";
            frm.ShowDialog();
            this.dataGridView1.DataSource = prd.get_all_products();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                ///---------------------------------------------------------------////////////////////////////////////////////
                if (MessageBox.Show("هل تريد حذف الصنف", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                        Int32 selectedRowCount =
                       dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    prd.deleteproduct(Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0].Value));
                }
                        //prd.deleteproduct(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                    }
                    MessageBox.Show("تمت عمليه الحذف بنجاح", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.dataGridView1.DataSource = prd.get_all_products();

                }
                else
                {
                    MessageBox.Show("تم الغاء عمليه الحذف ", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        

        private void button5_Click(object sender, EventArgs e)
        {
            id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm_add_product frm = new frm_add_product(id);
            frm.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();

            frm.txtnme.Text =this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
           // frm.txtnme.Enabled = false;
            frm.txtqte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtpshr.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.txtpg.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.txtpb.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.txtmsthlk.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.txttmd.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.Text = "تحديث بيانات الصنف:" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnok.Text = "تحديث";
            frm.combo_stores.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            frm.txt_serial.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            try
            {
                byte[] image = (byte[])prd.get_image_product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
                MemoryStream ms = new MemoryStream(image);
                frm.pbox.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {
            }

         
            frm.state = "update";
            frm.ShowDialog();
            this.dataGridView1.DataSource = prd.get_all_products();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_review frm = new frm_review();
            byte[] image = (byte[])prd.get_image_product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ii = -1;
            string cont_products = (dataGridView1.Rows.Count - 1).ToString();
            double cont =Convert.ToDouble(dataGridView1.Rows.Count - 1 );
            double ss=cont/30;




            double pages=Math.Ceiling(ss);
            


            if (MessageBox.Show("عد الاصناف =" + cont_products + "\nعدد صفح الطباعه =" +pages.ToString()+"\n هل تريد الطباعة ؟؟", "عملية الطباعة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PrintDialog printDlg = new PrintDialog();


                printDlg.AllowSelection = true;

                printDlg.AllowSomePages = true;

                //Call ShowDialog

                if (printDlg.ShowDialog() == DialogResult.OK)

                    printDocument1.Print();

 
            }
            
            /*
            this.Cursor = Cursors.WaitCursor;
            RPT.rpt_all_product report = new RPT.rpt_all_product();
            RPT.frm_rpt_product frm = new RPT.frm_rpt_product();
            report.SetDataSource(prd.get_all_products());
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

            textBox2.Text = (from DataGridViewRow row in dataGridView1.Rows
                             where row.Cells[7].FormattedValue.ToString() != string.Empty && Convert.ToDouble( row.Cells[2].FormattedValue)!=0
                          select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            txtQunts.Text = (from DataGridViewRow row in dataGridView1.Rows
                             where row.Cells[2].FormattedValue.ToString() != string.Empty && Convert.ToDouble(row.Cells[2].FormattedValue) != 0
                             select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
        }
        int ii = -1;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ii++;
           double cont_product = Convert.ToDouble(dataGridView1.Rows.Count - 1);

            e.HasMorePages = false;
            Font f = new Font("Arial", 18, FontStyle.Bold);
            Font ff = new Font("Arial", 26, FontStyle.Underline);
            Font v = new Font("Arial", 40, FontStyle.Bold,GraphicsUnit.Point);
            Font n = new Font("Arial", 14, FontStyle.Regular);
            Font col_header = new Font("Arial", 16, FontStyle.Underline);

            float marg = 20;
      

            SizeF fontsizeNO = e.Graphics.MeasureString("شركه الفؤاد",v);
            SizeF fontsizename = e.Graphics.MeasureString("للمستلزمات الطبية", f);
            SizeF fontsizedate = e.Graphics.MeasureString("ومستحضرات التجميل", f);
            SizeF fontsizebayea = e.Graphics.MeasureString("احمد/01017705232", f);
            SizeF fontsizetotalP = e.Graphics.MeasureString("ادهم/01281658077", f);


            e.Graphics.DrawString(Program.company_name, v, Brushes.Blue, 480, 5);
            e.Graphics.DrawString(Program.details_1, f, Brushes.BlueViolet, 510, marg + fontsizename.Height + 10);
            e.Graphics.DrawString(Program.details_2, f, Brushes.BlueViolet, 505, marg + fontsizeNO.Height);
            e.Graphics.DrawString(Program.telephon_1, f, Brushes.Black, 50, marg + fontsizename.Height - 10);
            //e.Graphics.DrawString("والمواسير الألمانية وأنظمة المياة", f, Brushes.BlueViolet, 505, marg + fontsizeNO.Height);
            //e.Graphics.DrawString(" للأدوات الصحية ", f, Brushes.BlueViolet, 510, marg + fontsizename.Height + 10);
            //e.Graphics.DrawString("الحاج/مصطفي/01022070794", f, Brushes.Black, 50, marg + fontsizename.Height - 10);
           // e.Graphics.DrawString("ادهم فؤاد/01281658077", f, Brushes.Black, 50, marg + fontsizeNO.Height-10 );

            e.Graphics.DrawString("قـائمة اصناف الشركـة", ff, Brushes.DarkGreen, e.PageBounds.Width -550, marg + fontsizebayea.Height * 3+10 );



            float prehights = marg+ marg + fontsizename.Height +100;

            //المستطيل
            e.Graphics.DrawRectangle(Pens.Black, marg, prehights, e.PageBounds.Width - marg * 2, e.PageBounds.Height - marg * 2 - prehights+30);
            float colhight = 50;

            float colwidth1 = 50;
            float colwidth2 = 380 + colwidth1;
            float colwidth3 = 70 + colwidth2;
            float colwidth4 = 50 + colwidth3;
            float colwidth5 = 50 + colwidth4;
            float colwidth6 = 50 + colwidth5;

            e.Graphics.DrawLine(Pens.Black, marg, prehights + colhight, e.PageBounds.Width - marg, prehights + colhight);

            e.Graphics.DrawString("م", col_header, Brushes.Black, e.PageBounds.Width - marg * 2 - 20, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 30, prehights, e.PageBounds.Width - marg * 2 - 30, e.PageBounds.Height - marg * 2 + 30);


            e.Graphics.DrawString("الكود", col_header, Brushes.Black, e.PageBounds.Width - marg * 2 - 75, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 85, prehights, e.PageBounds.Width - marg * 2 - 85, e.PageBounds.Height - marg * 2 + 30);

            e.Graphics.DrawString("اسم الصنف", col_header, Brushes.Black, e.PageBounds.Width - marg * 2 - 300, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 56 - 30, prehights, e.PageBounds.Width - marg * 2 - 30 - 300 - 56 - 30, e.PageBounds.Height - marg * 2 + 30);

         //   e.Graphics.DrawString("الكميه", f, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 56 - 20, prehights + 20);
         //   e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3, prehights, e.PageBounds.Width - marg * 2 - colwidth3, e.PageBounds.Height - marg * 2 - 30);

            e.Graphics.DrawString("السعر", col_header, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 111 - 56, prehights + 20);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - colwidth3 - 80, prehights, e.PageBounds.Width - marg * 2 - colwidth3 - 80, e.PageBounds.Height - marg * 2+30 );

            e.Graphics.DrawString("سعر المستهلك", col_header, Brushes.Black, e.PageBounds.Width - marg * 2 - 750, prehights + 20);


            ////////////////////////////////////////////
            float rowshight = 55;

            for (; ii < dataGridView1.Rows.Count - 1; ii++)
            {
                //
                e.Graphics.DrawString((ii + 1).ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 28, prehights + 30 + rowshight - 35);

                //
                e.Graphics.DrawString(dataGridView1.Rows[ii].Cells[0].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 80, prehights + 30 + rowshight - 35);
                e.Graphics.DrawString(dataGridView1.Rows[ii].Cells[1].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 - 300 - 56 - 20, prehights + 30 + rowshight - 35);
                e.Graphics.DrawString(dataGridView1.Rows[ii].Cells[4].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 30 -530, prehights + 30 + rowshight - 35);
                e.Graphics.DrawString(dataGridView1.Rows[ii].Cells[6].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 730, prehights + 30 + rowshight - 35);
                e.Graphics.DrawLine(Pens.Black, marg, prehights + colhight + rowshight - 30, e.PageBounds.Width - marg, prehights + colhight + rowshight - 30);

                if (ii == 30 || ii == 30 * 2 || ii == 30 * 3 || ii == 30 * 4 || ii == 30 * 5 || ii == 30 * 6 || ii == 30 * 7 || ii == 30 * 8 || ii == 30 * 9 || ii == 30 * 10 || ii == 30 * 11 ||
                    ii == 30 * 12 || ii == 30 * 13 || ii == 30 * 14 || ii == 30 * 15 || ii == 30 * 16 || ii == 30 * 17 || ii == 30 * 18 || ii == 30 * 19 || ii == 30 * 20 || ii == 30 * 21 || ii == 30 * 22 ||
                    ii == 30 * 23 || ii == 30 * 24 || ii == 30 * 25 || ii == 30 * 26 || ii == 30 * 27 || ii == 30 * 28 || ii == 30 * 29 || ii == 30 * 30 || ii == 30 * 31 || ii == 30 * 32 || ii == 30 * 33 || ii == 30 * 34 || ii == 30 * 35
                    || ii == 30 * 36 || ii == 30 * 37 || ii == 30 * 38 || ii == 30 * 39 || ii == 30 * 40 || ii == 30 * 41 || ii == 30 * 42 || ii == 30 * 43 || ii == 30 * 44 || ii == 30 * 45 || ii == 30 * 46 || ii == 30 * 47 || ii == 30 * 48 || ii == 30 * 49 || ii == 30 * 50)
                {
                    e.HasMorePages = true;
                    break;
                }

                rowshight += 30;
            /*    if (ii==cont_product)
                {
                    ii = -1;
                }*/
            }
            ColorMatrix matrix = new ColorMatrix();
            matrix.Matrix33 = (float)0.2;
            ImageAttributes attr = new ImageAttributes();
            attr.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            var src_water_mark = new Bitmap(Program.PrintUpperImageSource);
            e.Graphics.DrawImage(src_water_mark, new Rectangle((e.PageBounds.Width / 2) - 200, (e.PageBounds.Height / 2) - 250, 400, 400), 0, 0, src_water_mark.Width, src_water_mark.Height, GraphicsUnit.Pixel, attr);


        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ii++;
            double cont_product = Convert.ToDouble(dataGridView1.Rows.Count - 1);

            e.HasMorePages = false;
            Font f = new Font("Arial", 18, FontStyle.Bold);
            Font ff = new Font("Arial", 26, FontStyle.Underline);
            Font v = new Font("Arial", 40, FontStyle.Bold, GraphicsUnit.Point);
            Font n = new Font("Arial", 10, FontStyle.Regular);
            Font col_header = new Font("Arial", 16, FontStyle.Underline);
            float marg = 20;


            SizeF fontsizeNO = e.Graphics.MeasureString("شركه الفؤاد", v);
            SizeF fontsizename = e.Graphics.MeasureString("للمستلزمات الطبية", f);
            SizeF fontsizedate = e.Graphics.MeasureString("ومستحضرات التجميل", f);
            SizeF fontsizebayea = e.Graphics.MeasureString("احمد/01017705232", f);
            SizeF fontsizetotalP = e.Graphics.MeasureString("ادهم/01281658077", f);


            e.Graphics.DrawString(Program.company_name, v, Brushes.Blue, 480, 5);
            e.Graphics.DrawString(Program.details_1, f, Brushes.BlueViolet, 510, marg + fontsizename.Height + 10);
            e.Graphics.DrawString(Program.details_2, f, Brushes.BlueViolet, 505, marg + fontsizeNO.Height);
            e.Graphics.DrawString(Program.telephon_1, f, Brushes.Black, 50, marg + fontsizename.Height - 10);
            //e.Graphics.DrawString("والمواسير الألمانية وأنظمة المياة", f, Brushes.BlueViolet, 505, marg + fontsizeNO.Height);
            //e.Graphics.DrawString(" للأدوات الصحية ", f, Brushes.BlueViolet, 510, marg + fontsizename.Height + 10);
            //e.Graphics.DrawString("الحاج/مصطفي/01022070794", f, Brushes.Black, 50, marg + fontsizename.Height - 10);
            e.Graphics.DrawString("قـائمة اصناف الشركـة", ff, Brushes.DarkGreen, e.PageBounds.Width - 550, marg + fontsizebayea.Height * 3 + 10);



            float prehights = marg + marg + fontsizename.Height + 100;

            //المستطيل
            e.Graphics.DrawRectangle(Pens.Black, marg, prehights, e.PageBounds.Width - marg * 2, e.PageBounds.Height - marg * 2 - prehights + 30);
            float colhight = 50;

            float colwidth1 = 50;
            float colwidth2 = 380 + colwidth1;
            float colwidth3 = 70 + colwidth2;
            float colwidth4 = 50 + colwidth3;
            float colwidth5 = 50 + colwidth4;
            float colwidth6 = 50 + colwidth5;

            e.Graphics.DrawLine(Pens.Black, marg, prehights + colhight, e.PageBounds.Width - marg, prehights + colhight);

            e.Graphics.DrawString("م", col_header, Brushes.Black, e.PageBounds.Width - marg * 2 - 20, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 24, prehights, e.PageBounds.Width - marg * 2 - 24, e.PageBounds.Height - marg * 2 + 30);


            e.Graphics.DrawString("الكود", col_header, Brushes.Black, e.PageBounds.Width - marg * 2 - 65, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 64, prehights, e.PageBounds.Width - marg * 2 - 64, e.PageBounds.Height - marg * 2 + 30);

            e.Graphics.DrawString("اسم الصنف", col_header, Brushes.Black, e.PageBounds.Width - marg * 2 - 180, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2  -280, prehights, e.PageBounds.Width - marg * 2 - 280, e.PageBounds.Height - marg * 2 + 30);

            e.Graphics.DrawString("الكميه", col_header, Brushes.Black, e.PageBounds.Width - marg * 2 -345, prehights + 15);
               e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 350, prehights, e.PageBounds.Width - marg * 2 - 350, e.PageBounds.Height - marg * 2 + 30);

            e.Graphics.DrawString("سعر شراء", col_header, Brushes.Black, e.PageBounds.Width - marg * 2 - 432, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 434 , prehights, e.PageBounds.Width - marg * 2 - 434, e.PageBounds.Height - marg * 2 + 30);


            e.Graphics.DrawString("سعر جمله", col_header, Brushes.Black, e.PageBounds.Width - marg * 2 - 514, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 - 515, prehights, e.PageBounds.Width - marg * 2 - 515, e.PageBounds.Height - marg * 2 + 30);


            e.Graphics.DrawString("سعر بيع", col_header, Brushes.Black, e.PageBounds.Width - marg * 2 -580, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2-585, prehights, e.PageBounds.Width - marg * 2 -585, e.PageBounds.Height - marg * 2 + 30);

            e.Graphics.DrawString("سعر مستهلك", col_header, Brushes.Black, e.PageBounds.Width - marg * 2 -691, prehights + 15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marg * 2 -695, prehights, e.PageBounds.Width - marg * 2 -695, e.PageBounds.Height - marg * 2 + 30);


            e.Graphics.DrawString("اجمالي", col_header, Brushes.Black, e.PageBounds.Width - marg * 2 -760, prehights + 15);



            ////////////////////////////////////////////
            float rowshight = 55;

            for (; ii < dataGridView1.Rows.Count - 1; ii++)
            {

                e.Graphics.DrawString((ii+1).ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 20, prehights + 30 + rowshight - 35);

                //
                e.Graphics.DrawString(dataGridView1.Rows[ii].Cells[0].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 60, prehights + 30 + rowshight - 35);
                e.Graphics.DrawString(dataGridView1.Rows[ii].Cells[1].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 275, prehights + 30 + rowshight - 35);
                e.Graphics.DrawString(dataGridView1.Rows[ii].Cells[2].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 345, prehights + 30 + rowshight - 35);
                e.Graphics.DrawString(dataGridView1.Rows[ii].Cells[3].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 405, prehights + 30 + rowshight - 35);
                e.Graphics.DrawString(dataGridView1.Rows[ii].Cells[4].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 510, prehights + 30 + rowshight - 35);
                e.Graphics.DrawString(dataGridView1.Rows[ii].Cells[5].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 580, prehights + 30 + rowshight - 35);
                e.Graphics.DrawString(dataGridView1.Rows[ii].Cells[6].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 690, prehights + 30 + rowshight - 35);
                e.Graphics.DrawString(dataGridView1.Rows[ii].Cells[7].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 760, prehights + 30 + rowshight - 35);


                e.Graphics.DrawLine(Pens.Black, marg, prehights + colhight + rowshight - 30, e.PageBounds.Width - marg, prehights + colhight + rowshight - 30);

                if (ii == 30 || ii == 30 * 2 || ii == 30 * 3 || ii == 30 * 4 || ii == 30 * 5 || ii == 30 * 6 || ii == 30 * 7 || ii == 30 * 8 || ii == 30 * 9 || ii == 30 * 10 || ii == 30 * 11 ||
                    ii == 30 * 12 || ii == 30 * 13 || ii == 30 * 14 || ii == 30 * 15 || ii == 30 * 16 || ii == 30 * 17 || ii == 30 * 18 || ii == 30 * 19 || ii == 30 * 20 || ii == 30 * 21 || ii == 30 * 22 ||
                    ii == 30 * 23 || ii == 30 * 24 || ii == 30 * 25 || ii == 30 * 26 || ii == 30 * 27 || ii == 30 * 28 || ii == 30 * 29 || ii == 30 * 30 || ii == 30 * 31 || ii == 30 * 32 || ii == 30 * 33 || ii == 30 * 34 || ii == 30 * 35
                    || ii == 30 * 36 || ii == 30 * 37 || ii == 30 * 38 || ii == 30 * 39 || ii == 30 * 40 || ii == 30 * 41 || ii == 30 * 42 || ii == 30 * 43 || ii == 30 * 44 || ii == 30 * 45 || ii == 30 * 46 || ii == 30 * 47 || ii == 30 * 48 || ii == 30 * 49 || ii == 30 * 50)
                {
                    e.HasMorePages = true;
                    break;
                }

                rowshight += 30;
                /*    if (ii==cont_product)
                    {
                        ii = -1;
                    }*/
            }
            ColorMatrix matrix = new ColorMatrix();
            matrix.Matrix33 = (float)0.2;
            ImageAttributes attr = new ImageAttributes();
            attr.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            var src_water_mark = new Bitmap(Program.PrintUpperImageSource);
            e.Graphics.DrawImage(src_water_mark, new Rectangle((e.PageBounds.Width / 2) - 200, (e.PageBounds.Height / 2) - 250, 400, 400), 0, 0, src_water_mark.Width, src_water_mark.Height, GraphicsUnit.Pixel, attr);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ii = -1;
            string cont_products = (dataGridView1.Rows.Count - 1).ToString();
            double cont = Convert.ToDouble(dataGridView1.Rows.Count - 1);
            double ss = cont / 30;




            double pages = Math.Ceiling(ss);
            if (MessageBox.Show("عد الاصناف =" + cont_products + "\nعدد صفح الطباعه =" + pages.ToString() + "\n هل تريد الطباعة ؟؟", "عملية الطباعة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PrintDialog printDlg = new PrintDialog();


                printDlg.AllowSelection = true;

                printDlg.AllowSomePages = true;

                //Call ShowDialog

                if (printDlg.ShowDialog() == DialogResult.OK)

                    printDocument2.Print();
                


            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            frm_product_card frm = new frm_product_card();
            frm.dgv_mwrdeen.DataSource = purch.get_prd_purchases_for_card(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            frm.dgv_orders.DataSource = prd.get_all_order_details_for_card(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            frm.txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.dgv_mrtg3_mbe3at.DataSource = prd.mrtg3_mbe3at_for_card(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            frm.dgv_mrtg3_mshtriat.DataSource = prd.get_all_mrtg3_mshtriat_for_card(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            frm.dgv_corrupted.DataSource = prd.search_corrupted_prd(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            frm.dgv__first_rseed.DataSource = prd.search_prd_first_rseed(dataGridView1.CurrentRow.Cells[1].Value.ToString());

            //frm.txt_total_corrupted.Text = (from DataGridViewRow row in frm.dgv_corrupted.Rows
            //                                where row.Cells[1].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() != string.Empty
            //                                select Convert.ToDouble(row.Cells[1].FormattedValue) * Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();

            frm.txt_total_first_rseed.Text = (from DataGridViewRow row in frm.dgv__first_rseed.Rows
                                              where row.Cells[5].FormattedValue.ToString() != string.Empty
                                              select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();

            frm.txt_mrtg3_mbe3at.Text = (from DataGridViewRow row in frm.dgv_mrtg3_mbe3at.Rows
                                         where row.Cells[1].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() != string.Empty
                                         select Convert.ToDouble(row.Cells[1].FormattedValue) * Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
           
            frm.txt_mrtg3_mshtriat.Text=(from DataGridViewRow row in frm.dgv_mrtg3_mshtriat.Rows
                                             where row.Cells[2].FormattedValue.ToString() != string.Empty && row.Cells[3].FormattedValue.ToString() != string.Empty
                                             select Convert.ToDouble(row.Cells[2].FormattedValue) * Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();


            frm.txt_total_buy.Text = (from DataGridViewRow row in frm.dgv_mwrdeen.Rows
                                      where row.Cells[6].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            frm.txt_total_sales.Text = (from DataGridViewRow row in frm.dgv_orders.Rows
                                        where row.Cells[4].FormattedValue.ToString() != string.Empty 
                                        select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();

            //quantities//////////////////
            frm.txt_qte_first_rseed.Text = (from DataGridViewRow row in frm.dgv__first_rseed.Rows
                                            where row.Cells[3].FormattedValue.ToString() != string.Empty
                                            select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            frm.txt_qte_mbe3at.Text = (from DataGridViewRow row in frm.dgv_orders.Rows
                                       where row.Cells[1].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum().ToString();
            frm.txt_qte_mshtriat.Text = (from DataGridViewRow row in frm.dgv_mwrdeen.Rows
                                         where row.Cells[2].FormattedValue.ToString() != string.Empty
                                         select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
            frm.txt_qte_mrtg3_mbe3at.Text = (from DataGridViewRow row in frm.dgv_mrtg3_mbe3at.Rows
                                             where row.Cells[2].FormattedValue.ToString() != string.Empty
                                             select  Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
            frm.txt_qte_mrtg3_mshtriat.Text = (from DataGridViewRow row in frm.dgv_mrtg3_mshtriat.Rows
                                               where row.Cells[2].FormattedValue.ToString() != string.Empty
                                               select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
            frm.txt_qte_corrupted.Text=(from DataGridViewRow row in frm.dgv_corrupted.Rows
                                            where row.Cells[3].FormattedValue.ToString() != string.Empty 
                                            select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();

            ////dgv price shraa load
            DataRow r;
            for (int i = 0; i < frm.dgv_corrupted.Rows.Count-1; i++)
            {
                r = dt_price_shraa_for_corrupted.NewRow();
                r[0] = frm.dgv_corrupted.Rows[i].Cells[3].Value.ToString();
                r[1] = order.get_price_shraa_formksab_in_order(Convert.ToInt32(frm.dgv_corrupted.Rows[i].Cells[1].Value)).Rows[0][0].ToString();
                dt_price_shraa_for_corrupted.Rows.Add(r);
            }
            frm.dgv_corrupted_price_shraa.DataSource = dt_price_shraa_for_corrupted;
            double corrupted_totalPrice = 0;
            for (int i = 0; i < frm.dgv_corrupted_price_shraa.Rows.Count - 1; i++)
            {
                corrupted_totalPrice += (Convert.ToInt32(frm.dgv_corrupted_price_shraa.Rows[i].Cells[0].Value)
                    * Convert.ToDouble(frm.dgv_corrupted_price_shraa.Rows[i].Cells[1].Value));
            }
            frm.txt_total_corrupted.Text = corrupted_totalPrice.ToString();

            //جمعت رصيد اول عليهم عشان هو دخل كمياتهم بصفر الاول فأول حاجة في المشتريات بصفر وكدة رصيد اول مش هيتكرر///
            //if (string.IsNullOrEmpty(frm.dgv_mwrdeen.Rows[0].Cells[2].Value.ToString()))
            //{
            //    frm.dgv_mwrdeen.Rows[0].Cells[2].Value = 0;
            //}
            int real_qte = 0;
            double real_rseed = 0;
            try
            {
                if (frm.dgv_mwrdeen.Rows.Count > 1)
                {
                    if (frm.dgv_mwrdeen.Rows[0].Cells[2].Value.ToString() == "0" || frm.dgv_mwrdeen.Rows[0].Cells[2].Value.ToString() != frm.dgv__first_rseed.Rows[0].Cells[3].Value.ToString())
                    {
                        real_qte = Convert.ToInt32(frm.txt_qte_first_rseed.Text) + Convert.ToInt32(frm.txt_qte_mshtriat.Text) + Convert.ToInt32(frm.txt_qte_mrtg3_mbe3at.Text) -
                      Convert.ToInt32(frm.txt_qte_mbe3at.Text) - Convert.ToInt32(frm.txt_qte_mrtg3_mshtriat.Text) - Convert.ToInt32(frm.txt_qte_corrupted.Text);
                        frm.txt_qte_real.Text = real_qte.ToString();

                        real_rseed = Convert.ToDouble(frm.txt_total_first_rseed.Text) + Convert.ToDouble(frm.txt_total_buy.Text) + Convert.ToDouble(frm.txt_mrtg3_mbe3at.Text) -
                           Convert.ToDouble(frm.txt_mrtg3_mshtriat.Text) - Convert.ToDouble(frm.txt_total_sales.Text) - Convert.ToDouble(frm.txt_total_corrupted.Text);
                        frm.txt_rseed_real.Text = Math.Round(real_rseed, 3).ToString();
                    }
                    else
                    {
                        real_qte = Convert.ToInt32(frm.txt_qte_mshtriat.Text) + Convert.ToInt32(frm.txt_qte_mrtg3_mbe3at.Text) -
                      Convert.ToInt32(frm.txt_qte_mbe3at.Text) - Convert.ToInt32(frm.txt_qte_mrtg3_mshtriat.Text) - Convert.ToInt32(frm.txt_qte_corrupted.Text);
                        frm.txt_qte_real.Text = real_qte.ToString();

                        real_rseed = Convert.ToDouble(frm.txt_total_buy.Text) + Convert.ToDouble(frm.txt_mrtg3_mbe3at.Text) -
                           Convert.ToDouble(frm.txt_mrtg3_mshtriat.Text) - Convert.ToDouble(frm.txt_total_sales.Text) - Convert.ToDouble(frm.txt_total_corrupted.Text);
                        frm.txt_rseed_real.Text = Math.Round(real_rseed, 3).ToString();
                    }

                }
                else
                {
                    real_qte = Convert.ToInt32(frm.txt_qte_first_rseed.Text) + Convert.ToInt32(frm.txt_qte_mshtriat.Text) + Convert.ToInt32(frm.txt_qte_mrtg3_mbe3at.Text) -
                      Convert.ToInt32(frm.txt_qte_mbe3at.Text) - Convert.ToInt32(frm.txt_qte_mrtg3_mshtriat.Text) - Convert.ToInt32(frm.txt_qte_corrupted.Text);
                    frm.txt_qte_real.Text = real_qte.ToString();

                    real_rseed = Convert.ToDouble(frm.txt_total_first_rseed.Text) + Convert.ToDouble(frm.txt_total_buy.Text) + Convert.ToDouble(frm.txt_mrtg3_mbe3at.Text) -
                       Convert.ToDouble(frm.txt_mrtg3_mshtriat.Text) - Convert.ToDouble(frm.txt_total_sales.Text) - Convert.ToDouble(frm.txt_total_corrupted.Text);
                    frm.txt_rseed_real.Text = Math.Round(real_rseed, 3).ToString();
                }

            }
            catch (Exception x)
            {

               MessageBox.Show(x.Message.ToString());
            }
            

            frm.Show();


            dt_price_shraa_for_corrupted.Clear();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = prd.get_all_products();
        }



        private void button20_Click(object sender, EventArgs e)
        {
            //int result=0;
            //for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            //{
                
            //    int.TryParse( dataGridView1.Rows[i].Cells[2].Value.ToString(),out result);
            //    if (dataGridView1.Rows[i].Cells[2].Value.ToString().Contains("e") ==true)
	           //     {
		 
	           //     }
            //}
        }

        private void button21_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) == 0 )
                {
                    prd.update_total_mdfo3_to_zero(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value));
                }

                prd.update_total_mdfo3();
                //if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value)==0&&Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value)!=0)
                //{
                //    prd.update_total_mdfo3_to_zero(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value));
                //}

            }
            this.dataGridView1.DataSource = prd.get_all_products();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frm_deleted_products frm = new frm_deleted_products();
            frm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox2.Text = (from DataGridViewRow row in dataGridView1.Rows
                             where row.Cells[7].FormattedValue.ToString() != string.Empty && Convert.ToDouble(row.Cells[2].FormattedValue) != 0
                             select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            txtQunts.Text = (from DataGridViewRow row in dataGridView1.Rows
                             where row.Cells[2].FormattedValue.ToString() != string.Empty && Convert.ToDouble(row.Cells[2].FormattedValue) != 0
                             select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQunts_TextChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = prd.get_all_products();
            dt_gard.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                int final_qte=0;
                           
                ///////////////////////////////////////////////////////////////
                            object sum_purchase = purch.get_prd_purchases_for_card(dataGridView1.Rows[i].Cells[1].Value.ToString()).Compute("Sum(الكميه)", string.Empty);
                            object sum_orders = prd.get_all_order_details_for_card(dataGridView1.Rows[i].Cells[1].Value.ToString()).Compute("Sum(الكميه)", string.Empty);
                            object sum_mrtg3_mbe3at = prd.mrtg3_mbe3at_for_card(dataGridView1.Rows[i].Cells[1].Value.ToString()).Compute("Sum(الكمية)", string.Empty);
                            object sum_mrtg3_mshtriat = prd.get_all_mrtg3_mshtriat_for_card(dataGridView1.Rows[i].Cells[1].Value.ToString()).Compute("Sum(الكمية)", string.Empty);
                            object sum_corrupted = prd.search_corrupted_prd(dataGridView1.Rows[i].Cells[1].Value.ToString()).Compute("Sum([كمية الهالك])", string.Empty);
                            object sum_first_rseed = prd.search_prd_first_rseed(dataGridView1.Rows[i].Cells[1].Value.ToString()).Compute("Sum(الكمية)", string.Empty);
                            
            //quantities//////////////////


                            if (purch.get_prd_purchases_for_card(dataGridView1.Rows[i].Cells[1].Value.ToString()).Rows.Count>0)
            {
                if (purch.get_prd_purchases_for_card(dataGridView1.Rows[i].Cells[1].Value.ToString()).Rows[0][2].ToString() == "0" || 
                    purch.get_prd_purchases_for_card(dataGridView1.Rows[i].Cells[1].Value.ToString()).Rows[0][2].ToString() != prd.search_prd_first_rseed(dataGridView1.Rows[i].Cells[1].Value.ToString()).Rows[0][3].ToString())
                {
                    int real_qte = toNullableInt(sum_first_rseed) + toNullableInt(sum_purchase) + toNullableInt(sum_mrtg3_mbe3at) -
                   toNullableInt(sum_orders) - toNullableInt(sum_mrtg3_mshtriat) - toNullableInt(sum_corrupted);
                    final_qte = real_qte;


                }
                else
                {
                    int real_qte = toNullableInt(sum_purchase) + toNullableInt(sum_mrtg3_mbe3at) -
                   toNullableInt(sum_orders) - toNullableInt(sum_mrtg3_mshtriat) - toNullableInt(sum_corrupted);
                    final_qte = real_qte;


                }
              
            }
            else
            {
                int real_qte = toNullableInt(sum_first_rseed) + toNullableInt(sum_purchase) + toNullableInt(sum_mrtg3_mbe3at) -
                   toNullableInt(sum_orders) - toNullableInt(sum_mrtg3_mshtriat) - toNullableInt(sum_corrupted);
                final_qte = real_qte;

               
            }
                DataRow r_new = dt_gard.NewRow();
                r_new[0] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                r_new[1] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                r_new[2] = final_qte;
                r_new[3] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                dt_gard.Rows.Add(r_new);
            }
                frm_gard foorm = new frm_gard();
                foorm.dataGridView1.DataSource = dt_gard;
                foorm.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //this.dataGridView1.DataSource = prd.get_all_products();
            
            //dt_gard.Clear();
            //frm_product_card frm = new frm_product_card();
            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //{
            //    int final_qte = 0;
            //    if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[0].Value.ToString()) || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].Value.ToString())||string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[2].Value.ToString()))
            //    {
            //        MessageBox.Show("missing Data");
            //        return;
            //    }
            //    try
            //    {
            //        frm.dgv_mwrdeen.DataSource = purch.get_prd_purchases_for_card(dataGridView1.Rows[i].Cells[1].Value.ToString());
            //        frm.dgv_orders.DataSource = prd.get_all_order_details_for_card(dataGridView1.Rows[i].Cells[1].Value.ToString());
            //        frm.txtname.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            //        frm.dgv_mrtg3_mbe3at.DataSource = prd.mrtg3_mbe3at_for_card(dataGridView1.Rows[i].Cells[1].Value.ToString());
            //        frm.dgv_mrtg3_mshtriat.DataSource = prd.get_all_mrtg3_mshtriat_for_card(dataGridView1.Rows[i].Cells[1].Value.ToString());
            //        frm.dgv_corrupted.DataSource = prd.search_corrupted_prd(dataGridView1.Rows[i].Cells[1].Value.ToString());
            //        frm.dgv__first_rseed.DataSource = prd.search_prd_first_rseed(dataGridView1.Rows[i].Cells[1].Value.ToString());

            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("error in set datagridview dataSourses");
            //        break;
            //    }

            //    try
            //    {
            //        //quantities//////////////////
            //        frm.txt_qte_first_rseed.Text = (from DataGridViewRow row in frm.dgv__first_rseed.Rows
            //                                        where row.Cells[3].FormattedValue.ToString() != string.Empty
            //                                        select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            //        frm.txt_qte_mbe3at.Text = (from DataGridViewRow row in frm.dgv_orders.Rows
            //                                   where row.Cells[1].FormattedValue.ToString() != string.Empty
            //                                   select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum().ToString();
            //        frm.txt_qte_mshtriat.Text = (from DataGridViewRow row in frm.dgv_mwrdeen.Rows
            //                                     where row.Cells[2].FormattedValue.ToString() != string.Empty
            //                                     select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
            //        frm.txt_qte_mrtg3_mbe3at.Text = (from DataGridViewRow row in frm.dgv_mrtg3_mbe3at.Rows
            //                                         where row.Cells[2].FormattedValue.ToString() != string.Empty
            //                                         select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
            //        frm.txt_qte_mrtg3_mshtriat.Text = (from DataGridViewRow row in frm.dgv_mrtg3_mshtriat.Rows
            //                                           where row.Cells[2].FormattedValue.ToString() != string.Empty
            //                                           select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
            //        frm.txt_qte_corrupted.Text = (from DataGridViewRow row in frm.dgv_corrupted.Rows
            //                                      where row.Cells[3].FormattedValue.ToString() != string.Empty
            //                                      select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            //    }
            //    catch (Exception)
            //    {
                    
            //        MessageBox.Show("error in set txtts");
            //        break;
            //    }


            //    try
            //    {
            //   if (frm.dgv_mwrdeen.Rows.Count > 1)
            //    {
            //        if (frm.dgv_mwrdeen.Rows[0].Cells[2].Value.ToString() == "0" || frm.dgv_mwrdeen.Rows[0].Cells[2].Value.ToString() != frm.dgv__first_rseed.Rows[0].Cells[3].Value.ToString())
            //        {
            //            int real_qte = Convert.ToInt32(frm.txt_qte_first_rseed.Text) + Convert.ToInt32(frm.txt_qte_mshtriat.Text) + Convert.ToInt32(frm.txt_qte_mrtg3_mbe3at.Text) -
            //           Convert.ToInt32(frm.txt_qte_mbe3at.Text) - Convert.ToInt32(frm.txt_qte_mrtg3_mshtriat.Text) - Convert.ToInt32(frm.txt_qte_corrupted.Text);
            //            final_qte = real_qte;
            //        }
            //        else
            //        {
            //            int real_qte = Convert.ToInt32(frm.txt_qte_mshtriat.Text) + Convert.ToInt32(frm.txt_qte_mrtg3_mbe3at.Text) -
            //           Convert.ToInt32(frm.txt_qte_mbe3at.Text) - Convert.ToInt32(frm.txt_qte_mrtg3_mshtriat.Text) - Convert.ToInt32(frm.txt_qte_corrupted.Text);
            //            final_qte = real_qte;
            //        }

            //    }
            //    else
            //    {
            //        int real_qte = Convert.ToInt32(frm.txt_qte_first_rseed.Text) + Convert.ToInt32(frm.txt_qte_mshtriat.Text) + Convert.ToInt32(frm.txt_qte_mrtg3_mbe3at.Text) -
            //           Convert.ToInt32(frm.txt_qte_mbe3at.Text) - Convert.ToInt32(frm.txt_qte_mrtg3_mshtriat.Text) - Convert.ToInt32(frm.txt_qte_corrupted.Text);
            //        final_qte = real_qte;
            //    }
            //    }
            //    catch (Exception)
            //    {
                    
            //        MessageBox.Show("error in set final qte");
            //        break;
            //    }
            //    try
            //    {
            //        DataRow r_new = dt_gard.NewRow();
            //        r_new[0] = dataGridView1.Rows[i].Cells[0].Value.ToString();
            //        r_new[1] = dataGridView1.Rows[i].Cells[1].Value.ToString();
            //        r_new[2] = final_qte;
            //        r_new[3] = dataGridView1.Rows[i].Cells[2].Value.ToString();
            //        dt_gard.Rows.Add(r_new);
            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("error in add dataRow");
            //        break;
            //    }
                
            //}
            //frm_gard foorm = new frm_gard();
            //foorm.dataGridView1.DataSource = dt_gard;
            //foorm.Show();
            //MessageBox.Show("success");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //    this.dataGridView1.DataSource = prd.get_all_products();
            //    dt_gard.Clear();
            //    frm_product_card frm = new frm_product_card();
            //    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //    {
            //        frm.dgv_mwrdeen.DataSource = purch.get_prd_purchases_for_card(dataGridView1.Rows[i].Cells[1].Value.ToString());
            //        frm.dgv_orders.DataSource = prd.get_all_order_details_for_card(dataGridView1.Rows[i].Cells[1].Value.ToString());
            //        frm.txtname.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            //        frm.dgv_mrtg3_mbe3at.DataSource = prd.mrtg3_mbe3at_for_card(dataGridView1.Rows[i].Cells[1].Value.ToString());
            //        frm.dgv_mrtg3_mshtriat.DataSource = prd.get_all_mrtg3_mshtriat_for_card(dataGridView1.Rows[i].Cells[1].Value.ToString());
            //        frm.dgv_corrupted.DataSource = prd.search_corrupted_prd(dataGridView1.Rows[i].Cells[1].Value.ToString());
            //        frm.dgv__first_rseed.DataSource = prd.search_prd_first_rseed(dataGridView1.Rows[i].Cells[1].Value.ToString());


            //        //quantities//////////////////
            //        frm.txt_qte_first_rseed.Text = (from DataGridViewRow row in frm.dgv__first_rseed.Rows
            //                                        where row.Cells[3].FormattedValue.ToString() != string.Empty
            //                                        select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            //        frm.txt_qte_mbe3at.Text = (from DataGridViewRow row in frm.dgv_orders.Rows
            //                                   where row.Cells[1].FormattedValue.ToString() != string.Empty
            //                                   select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum().ToString();
            //        frm.txt_qte_mshtriat.Text = (from DataGridViewRow row in frm.dgv_mwrdeen.Rows
            //                                     where row.Cells[2].FormattedValue.ToString() != string.Empty
            //                                     select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
            //        frm.txt_qte_mrtg3_mbe3at.Text = (from DataGridViewRow row in frm.dgv_mrtg3_mbe3at.Rows
            //                                         where row.Cells[2].FormattedValue.ToString() != string.Empty
            //                                         select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
            //        frm.txt_qte_mrtg3_mshtriat.Text = (from DataGridViewRow row in frm.dgv_mrtg3_mshtriat.Rows
            //                                           where row.Cells[2].FormattedValue.ToString() != string.Empty
            //                                           select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
            //        frm.txt_qte_corrupted.Text = (from DataGridViewRow row in frm.dgv_corrupted.Rows
            //                                      where row.Cells[3].FormattedValue.ToString() != string.Empty
            //                                      select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();

            //        if (frm.dgv_mwrdeen.Rows.Count > 1)
            //        {
            //            if (frm.dgv_mwrdeen.Rows[0].Cells[2].Value.ToString() == "0" || frm.dgv_mwrdeen.Rows[0].Cells[2].Value.ToString() != frm.dgv__first_rseed.Rows[0].Cells[3].Value.ToString())
            //            {
            //                int real_qte = Convert.ToInt32(frm.txt_qte_first_rseed.Text) + Convert.ToInt32(frm.txt_qte_mshtriat.Text) + Convert.ToInt32(frm.txt_qte_mrtg3_mbe3at.Text) -
            //               Convert.ToInt32(frm.txt_qte_mbe3at.Text) - Convert.ToInt32(frm.txt_qte_mrtg3_mshtriat.Text) - Convert.ToInt32(frm.txt_qte_corrupted.Text);
            //                frm.txt_qte_real.Text = real_qte.ToString();


            //            }
            //            else
            //            {
            //                int real_qte = Convert.ToInt32(frm.txt_qte_mshtriat.Text) + Convert.ToInt32(frm.txt_qte_mrtg3_mbe3at.Text) -
            //               Convert.ToInt32(frm.txt_qte_mbe3at.Text) - Convert.ToInt32(frm.txt_qte_mrtg3_mshtriat.Text) - Convert.ToInt32(frm.txt_qte_corrupted.Text);
            //                frm.txt_qte_real.Text = real_qte.ToString();


            //            }

            //        }
            //        else
            //        {
            //            int real_qte = Convert.ToInt32(frm.txt_qte_first_rseed.Text) + Convert.ToInt32(frm.txt_qte_mshtriat.Text) + Convert.ToInt32(frm.txt_qte_mrtg3_mbe3at.Text) -
            //               Convert.ToInt32(frm.txt_qte_mbe3at.Text) - Convert.ToInt32(frm.txt_qte_mrtg3_mshtriat.Text) - Convert.ToInt32(frm.txt_qte_corrupted.Text);
            //            frm.txt_qte_real.Text = real_qte.ToString();


            //        }
            //        dt_price_shraa_for_corrupted.Clear();
            //        DataRow r_new=dt_gard.NewRow();
            //        r_new[0] = dataGridView1.Rows[i].Cells[0].Value.ToString();
            //        r_new[1] = dataGridView1.Rows[i].Cells[1].Value.ToString();
            //        r_new[2] = frm.txt_qte_real.Text;
            //        r_new[3] = dataGridView1.Rows[i].Cells[2].Value.ToString();
            //        dt_gard.Rows.Add(r_new);
            //    }
            //    frm_gardTwo ferm = new frm_gardTwo();
            //    ferm.dataGridView1.DataSource = dt_gard;
            //    ferm.ShowDialog();

        }

    public int toNullableInt(object o)
        {
            int x;
            if (int.TryParse(o.ToString(), out x)) return x;
            return 0;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //dt_gard.Clear();
            Cursor.Current = Cursors.WaitCursor;
            DataTable new_dt = new System.Data.DataTable();
            
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                new_dt.Merge(prd.get_all_products_for_gard(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)));

            }
            frm_gard frm = new frm_gard();
            frm.dataGridView1.DataSource = new_dt;
            frm.Show();
            Cursor.Current = Cursors.Default;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            frm_prd_first_rseed frm = new frm_prd_first_rseed();
            frm.Show();
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
           


            
        }

        private void txt_qte_TextChanged(object sender, EventArgs e)
        {
            int my_qte = 0;
            if (!string.IsNullOrEmpty(txt_qte.Text) && int.TryParse(txt_qte.Text, out my_qte))
            {
                my_qte = Convert.ToInt32(txt_qte.Text);
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) > my_qte)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) == my_qte)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.BlanchedAlmond;
                    }
                    else
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
                    else
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            
                                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            
                        }
                    }
            }

        private void button27_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
            if (!string.IsNullOrEmpty(combo_cat.Text))
            {
                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{
                //    if (row.Cells[1].Value.ToString().Contains(textBox1.Text))
                //    {
                //        row.Selected = true;
                //        break;
                //    }
                //}
                string rowFilter = string.Format("[{0}] Like '%{1}%'", "النوع", combo_cat.Text);
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            //button6.BackColor = Color.DarkViolet;
            //button6.ForeColor = Color.White;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            OnBottonHover((Button)sender);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            OnBottonLeave((Button)sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_deleted_products frm = new frm_deleted_products();
            frm.ShowDialog();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            OnBottonHover((Button)sender);

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            OnBottonLeave((Button)sender);

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            OnBottonHover((Button)sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ii = -1;

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;

                string rowFilter = string.Format("[{0}] <>'' ", "سيريال");
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

            string cont_products = (dataGridView1.Rows.Count - 1).ToString();
            double cont = Convert.ToDouble(dataGridView1.Rows.Count - 1);
            double ss = cont / 10;




            double pages = Math.Ceiling(ss);



            if (MessageBox.Show("عد الاصناف =" + cont_products + "\nعدد صفح الطباعه =" + pages.ToString() + "\n هل تريد الطباعة ؟؟", "عملية الطباعة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PrintDialog printDlg = new PrintDialog();


                printDlg.AllowSelection = true;

                printDlg.AllowSomePages = true;

                //Call ShowDialog

                if (printDlg.ShowDialog() == DialogResult.OK)

                    printDocumentBarCode.Print();


            }


        }

        private void printDocumentBarCode_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ii++;

            Font BarCodeFont = new Font("3 of 9 Barcode", 50);
            Font n = new Font("Arial", 20, FontStyle.Regular);

            float marg = 0;
            float prehights = 0;
            float rowshight = 0;
            for (; ii < dataGridView1.Rows.Count - 1; ii++)
            {
                var BarCodeText = dataGridView1.Rows[ii].Cells[13].Value.ToString();
                if (string.IsNullOrEmpty(BarCodeText))
                {
                    continue;
                }
                //e.Graphics.DrawString((ii + 1).ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 20, prehights + rowshight );

                //
                e.Graphics.DrawString(dataGridView1.Rows[ii].Cells[0].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 60, prehights  + rowshight +20);
                e.Graphics.DrawString(dataGridView1.Rows[ii].Cells[1].Value.ToString(), n, Brushes.Black, e.PageBounds.Width - marg * 2 - 350, prehights  + rowshight +20);
                e.Graphics.DrawString("*"+BarCodeText+"*", BarCodeFont, Brushes.Black,  marg , prehights  + rowshight +20 );

                e.Graphics.DrawLine(Pens.Black, marg, prehights  + rowshight, e.PageBounds.Width - marg, prehights  + rowshight );

                if (ii % 10 == 0 && ii >= 10)
                {
                    e.HasMorePages = true;
                    break;
                }

                rowshight += 100;
                /*    if (ii==cont_product)
                    {
                        ii = -1;
                    }*/
            }

        }
    }
    }

