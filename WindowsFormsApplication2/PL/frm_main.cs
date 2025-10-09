using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.UI;

namespace WindowsFormsApplication2.PL
{
    public partial class frm_main : Form
    {
        //single instance
        // 1
        private static frm_main frm;
        BL.cls_orders order = new BL.cls_orders();
        cls_login log = new cls_login();

        // 2
        static void frm_formclesed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        //3
        public static frm_main getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new frm_main();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclesed);
                }
                return frm;
            }
        }
        public frm_main()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            ApplyModernTheme();
            this.الاصنافToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            //this.استعادهنسخهمحفوظهToolStripMenuItem.Enabled = false;
            this.انشاءنسخهاحتياطيهToolStripMenuItem.Enabled = false;
            this.الموردينToolStripMenuItem.Enabled = false;
            //this.الربحالشهريToolStripMenuItem.Enabled = false;
            this.اخريToolStripMenuItem.Enabled = false;
            this.النقديةToolStripMenuItem.Enabled = false;
            this.label1.Cursor = Cursors.Default;
            this.label2.Cursor = Cursors.Default;
            this.button1.Cursor = Cursors.Hand;
            //this.roundButton1.Cursor = Cursors.Hand;
            //this.roundButton2.Cursor = Cursors.Hand;
            //this.roundButton3.Cursor = Cursors.Hand;
            //this.roundButton4.Cursor = Cursors.Hand;
            //this.roundButton5.Cursor = Cursors.Hand;
            groupBox1.Dock = DockStyle.None;
            dataGridView1.Dock = DockStyle.None;
            //groupBox2.Dock = DockStyle.None;
            //groupBox2.Visible = false;

            groupBox1.Visible=false;
            //label2.Text =label2.Text +"        ......     "+ DateTime.UtcNow.ToShortDateString();
            label3.Text = DateTime.UtcNow.ToLongDateString();
            dataGridView1.DataSource = order.search_new_orders_bydate(DateTime.Today.ToShortDateString());
            dataGridView1.Visible = false;
            if (Program.isDemo)
            {

              //  this.label1.Text = " نسخة تجريبية \n لايمكن اضافة سوي 5 اصناف \n و 2 من العملاء والموردين \n و 5 من عمليات البيع \n   ";
                this.label1.Text = " نسخة تجريبية \n   ";
                this.Text = "EASY MANAGE (DEMO VERSION)";
                if (log.get_system_type().Rows.Count>0)
                {
                    this.label1.Text +="Expiration date :  \n"+ (Convert.ToDateTime(log.get_system_type().Rows[0][1].ToString()).AddMonths(Convert.ToInt32(log.get_system_type().Rows[0][2].ToString()))).ToLongDateString() + "\n";
                
                }
            }
        }

        private void ApplyModernTheme()
        {
            // Apply modern theme to form
            this.BackColor = ModernTheme.BackgroundMain;
            
            // Style MenuStrip
            StyleMenuStrip();
            
            // Style DataGridView
            ModernTheme.StyleDataGridView(dataGridView1);
            
            // Style GroupBox
            ModernTheme.StyleGroupBox(groupBox1);
            groupBox1.BackColor = ModernTheme.BackgroundCard;
            
            // Style all buttons in groupBox1
            StyleSidebarButtons();
            
            // Style labels
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.ForeColor = ModernTheme.TextPrimary;
            
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            label2.BackColor = ModernTheme.PrimaryColor;
            label2.ForeColor = ModernTheme.TextLight;
            
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            label3.BackColor = ModernTheme.SecondaryColor;
            label3.ForeColor = ModernTheme.TextLight;
            
            // Style the unlock button
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = ModernTheme.BackgroundMain;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button1.ForeColor = ModernTheme.PrimaryColor;
        }

        private void StyleMenuStrip()
        {
            // Modern menu strip styling
            menuStrip1.BackColor = ModernTheme.BackgroundCard;
            menuStrip1.ForeColor = ModernTheme.TextPrimary;
            menuStrip1.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            menuStrip1.Padding = new Padding(5, 5, 0, 5);
            
            // Style each top-level menu item
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = ModernTheme.BackgroundCard;
                item.ForeColor = ModernTheme.TextPrimary;
                item.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                
                // Style dropdown items
                foreach (ToolStripItem subItem in item.DropDownItems)
                {
                    if (subItem is ToolStripMenuItem)
                    {
                        subItem.BackColor = ModernTheme.BackgroundCard;
                        subItem.ForeColor = ModernTheme.TextPrimary;
                        subItem.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                    }
                }
            }
        }

        private void StyleSidebarButtons()
        {
            // Style all buttons in the sidebar
            Button[] buttons = { button2, button3, button4, button6, button12, button5, button7, button8, button9 };
            
            foreach (Button btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = ModernTheme.BackgroundCard;
                btn.ForeColor = ModernTheme.PrimaryColor;
                btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                btn.FlatAppearance.BorderColor = ModernTheme.BorderLight;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.MouseOverBackColor = ModernTheme.PrimaryLight;
                btn.FlatAppearance.MouseDownBackColor = ModernTheme.PrimaryColor;
                btn.Cursor = Cursors.Hand;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.ImageAlign = ContentAlignment.TopCenter;
                
                // Add hover effect handlers
                btn.MouseEnter += (s, e) => {
                    ((Button)s).ForeColor = ModernTheme.TextLight;
                };
                btn.MouseLeave += (s, e) => {
                    ((Button)s).ForeColor = ModernTheme.PrimaryColor;
                };
            }
        }
        
        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login frm = new frm_login();
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void اضافةصنفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_add_product frm = new frm_add_product("");
            frm.state = "add";
            frm.Show();
        }

        private void ادارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_products frm = new frm_products();
            frm.Show();
        }

        private void ادارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.frm_cstmrs frm = new frm_cstmrs();
            frm.Show();
        }

        private void ادرهالمستخدمونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.frm_users frm = new frm_users();
            frm.Show();
        }

        private void ادارهالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.frm_orders_list frm = new frm_orders_list();
            frm.Show();
        }

        private void اضافهبيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Frm_orders frm = new Frm_orders();
            frm.Show();
        }

        private void اضافهمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.frm_add_user frm = new frm_add_user();
            frm.Show();
        }

        private void انشاءنسخهاحتياطيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_backup frm = new frm_backup();
            frm.Show();
        }

        private void استعادهنسخهمحفوظهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restore frm = new restore();
            frm.Show();

        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تسجيل الخروج؟؟","تسجيل الخروج",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.الاصنافToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            //this.استعادهنسخهمحفوظهToolStripMenuItem.Enabled = false;
            this.انشاءنسخهاحتياطيهToolStripMenuItem.Enabled = false;
            this.الموردينToolStripMenuItem.Enabled = false;
            this.اخريToolStripMenuItem.Enabled = false;
            //this.الربحالشهريToolStripMenuItem.Enabled = false;
            this.النقديةToolStripMenuItem.Enabled = false;
            this.button1.Visible = true;

            MessageBox.Show("تم تسجيل الخروج بنجاح","تسجيل الخروج",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

       

        private void ادارةاصنافاخريToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_products_again frm = new frm_products_again();
            frm.Show();
        }

        private void ادارةالماليةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_manage_money frm = new frm_manage_money();
            frm.Show();
        }

        private void اToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_manage_money frm = new frm_manage_money();
            frm.Show();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_products frm = new frm_products();
            frm.Show();
        }

        private void الرصيدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.elbank frm = new elbank();
            frm.Show();
        }

        private void الموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_login frm = new frm_login();
            frm.Show();
        }

        private void الربحالشهريToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_profit_month frm = new frm_profit_month();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void اToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_mrtg3 frm = new frm_mrtg3();
            frm.Show();
        }

        private void ادارةالأنواعالأساسيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_catogries frm = new frm_catogries();
            frm.Show();
        }

        private void ادارةالمخازنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_stores frm = new frm_stores();
            frm.Show();
        }

        private void المندوبينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_mndopeen frm = new frm_mndopeen();
            frm.Show();
        }

        private void ادارةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.frm_mordeen frm = new frm_mordeen();
            frm.Show();
        }

        private void مرتجعالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_mrtg3_mshtriat frm = new frm_mrtg3_mshtriat();
            frm.Show();
        }

        private void هالكالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_corrupted_prd frm = new frm_corrupted_prd();
            frm.Show();
        }

        private void المصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_expenses frm = new frm_expenses();
            frm.Show();
        }

        private void تقريرالتحصيلوالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_mony_reports frm = new frm_mony_reports();
            frm.Show();

        }

        private void النقديةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارةمرتجعالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_manage_mrtg3_mbe3at frm = new frm_manage_mrtg3_mbe3at();
            frm.Show();

        }

        private void تقريرالأنواعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_catogry_report frm = new frm_catogry_report();
            frm.Show();
        }

        private void تقريرالعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cstmr_report frm = new frm_cstmr_report();
            frm.Show();
        }

        private void تقريرمورديوميToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_mwrd_report frm = new frm_mwrd_report();
            frm.Show();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_orders frm = new Frm_orders();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm_products frm = new frm_products();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_catogries frm = new frm_catogries();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_single_cstmr_pay frm = new frm_single_cstmr_pay();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_cstmrs frm = new frm_cstmrs();
            frm.Show();
        }

        private void ايجادعمليةتحصيلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_single_cstmr_pay frm = new frm_single_cstmr_pay();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frm_mrtg3 frm = new frm_mrtg3();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frm_backup frm = new frm_backup();
            frm.Show();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frm_mndopeen frm = new frm_mndopeen(); 
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_change_company_name frm = new frm_change_company_name();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_mordeen FRM = new frm_mordeen();
            FRM.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            PL.elbank frm = new elbank();
            frm.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            PL.elbank frm = new elbank();
            frm.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frm_mrtg3 frm = new frm_mrtg3();
            frm.Show();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            frm_mordeen frm = new frm_mordeen();
            frm.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            frm_products frm = new frm_products();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 50;

            if (label2.Text.Length > 208)
            {
                label2.Text += " ";

                label2.Text = "م.باسم عصفور / 01153306987" + "        ......     " + DateTime.UtcNow.ToShortDateString();
                //label2.Text.Remove(label2.Text.Length-2, 2);
               // label2.TextAlign = ContentAlignment.MiddleRight;
            }
            if (label2.Text.Length != 130)
            {
                label2.Text += " ";
                label2.ForeColor = Color.DarkBlue;
                label2.BackColor = Color.PaleGoldenrod;
            }
            else
            {
                label2.Text += " ";
                timer1.Interval = 5000;
                label2.ForeColor = Color.White;
                label2.BackColor = Color.MidnightBlue;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           // timer1.Enabled = !timer1.Enabled;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frm_mndopeen frm = new frm_mndopeen();
            frm.Show();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            frm_mony_reports frm = new frm_mony_reports();
            frm.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            frm_catogries frm = new frm_catogries();
            frm.Show();
        }

        private void العملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            PL.frm_orders_list frm = new frm_orders_list();
            frm.Show();
        }
    }
}
