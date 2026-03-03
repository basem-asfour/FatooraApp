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
    public partial class frm_cstmrs : Form
    {
        BL.cls_cstmrs cstmr = new BL.cls_cstmrs();
        BL.cls_orders order = new BL.cls_orders();
        DataTable dt_mndob;
        BL.cls_mndobeen mndb = new BL.cls_mndobeen();
         public frm_cstmrs()
        {
            InitializeComponent();
            
            ApplyModernTheme();
            
            this.dataGridView1.DataSource = cstmr.search_cstmrs("");
            dt_mndob = mndb.get_all_mndopeen();
            combo_mndb.DataSource = dt_mndob;
            combo_mndb.DisplayMember = "اسم المندوب";
            combo_mndb.ValueMember = "id";
            combo_mndb2.DataSource = dt_mndob;
            combo_mndb2.DisplayMember = "اسم المندوب";
            combo_mndb2.ValueMember = "id";
        }
        
        private void ApplyModernTheme()
        {
            // Apply modern form styling
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            
            // Style DataGridView
            StyleDataGridView();
            
            // Style TextBoxes
            StyleTextBoxes();
            
            // Style ComboBoxes
            StyleComboBoxes();
            
            // Style Labels
            StyleLabels();
            
            // Style Buttons
            StyleButtons();
            
            // Style GroupBoxes
            StyleGroupBoxes();
        }
        
        private void StyleDataGridView()
        {
            if (dataGridView1 != null)
            {
                ModernTheme.StyleDataGridView(dataGridView1);
            }
        }
        
        private void StyleTextBoxes()
        {
            TextBox[] textBoxes = { txtcstnme, txtcstpho, txtcstadrs, txtmax, textBox1, label_first_rseed, txtnotes, txt_qte };
            
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox != null)
                {
                    ModernTheme.StyleTextBox(textBox);
                    textBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                    
                    // Special styling for readonly fields
                    if (textBox == label_first_rseed)
                    {
                        textBox.BackColor = Color.FromArgb(248, 249, 250); // Very light gray for readonly
                        textBox.ForeColor = ModernTheme.TextSecondary;
                    }
                }
            }
        }
        
        private void StyleComboBoxes()
        {
            ComboBox[] comboBoxes = { combo_mndb, combo_mndb2 };
            
            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox != null)
                {
                    ModernTheme.StyleComboBox(comboBox);
                    comboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                }
            }
        }
        
        private void StyleLabels()
        {
            // Get all labels using reflection or manual list
            Label[] labels = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12 };
            
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
            Button[] buttons = { button1, button2, button3, button4, button5, button11 };
            
            foreach (Button button in buttons)
            {
                if (button != null)
                {
                    if (button == button1) // Add Customer
                    {
                        ModernTheme.StyleButton(button, ButtonStyle.Success);
                        button.Text = "➕ إضافة عميل";
                        button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    }
                    else if (button == button2) // Edit Customer
                    {
                        ModernTheme.StyleButton(button, ButtonStyle.Warning);
                        button.Text = "✏️ تعديل العميل";
                        button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    }
                    else if (button == button3) // Delete Customer
                    {
                        ModernTheme.StyleButton(button, ButtonStyle.Danger);
                        button.Text = "🗑️ حذف العميل";
                        button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    }
                    else if (button == button4) // Close
                    {
                        ModernTheme.StyleButton(button, ButtonStyle.Danger);
                        button.Text = "❌ إغلاق";
                        button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    }
                    else if (button == button5) // Add Balance
                    {
                        ModernTheme.StyleButton(button, ButtonStyle.Primary);
                        button.Text = "💰 إضافة رصيد";
                        button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    }
                    else if (button == button11) // Filter by Sales Rep
                    {
                        ModernTheme.StyleButton(button, ButtonStyle.Secondary);
                        button.Text = "🔍 فلترة بالمندوب";
                        button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    }
                    
                    button.UseCompatibleTextRendering = false;
                }
            }
            
            // Style BunifuFlatButtons
            StyleBunifuButtons();
        }
        
        private void StyleBunifuButtons()
        {
            if (bunifuFlatButton1 != null)
            {
                bunifuFlatButton1.BackColor = ModernTheme.AccentGreen;
                bunifuFlatButton1.Activecolor = ModernTheme.AccentGreen;
                bunifuFlatButton1.Normalcolor = ModernTheme.AccentGreen;
                bunifuFlatButton1.OnHovercolor = Color.FromArgb(36, 129, 77);
                bunifuFlatButton1.Textcolor = ModernTheme.TextLight;
                bunifuFlatButton1.ButtonText = "📊 تقرير جميع عملاء القائمة";
                bunifuFlatButton1.TextFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            
            if (bunifuFlatButton2 != null)
            {
                bunifuFlatButton2.BackColor = ModernTheme.PrimaryColor;
                bunifuFlatButton2.Activecolor = ModernTheme.PrimaryColor;
                bunifuFlatButton2.Normalcolor = ModernTheme.PrimaryColor;
                bunifuFlatButton2.OnHovercolor = ModernTheme.PrimaryHover;
                bunifuFlatButton2.Textcolor = ModernTheme.TextLight;
                bunifuFlatButton2.ButtonText = "👥 عرض جميع العملاء";
                bunifuFlatButton2.TextFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
            
            if (bunifuFlatButton3 != null)
            {
                bunifuFlatButton3.BackColor = ModernTheme.AccentOrange;
                bunifuFlatButton3.Activecolor = ModernTheme.AccentOrange;
                bunifuFlatButton3.Normalcolor = ModernTheme.AccentOrange;
                bunifuFlatButton3.OnHovercolor = Color.FromArgb(211, 84, 0);
                bunifuFlatButton3.Textcolor = ModernTheme.TextLight;
                bunifuFlatButton3.ButtonText = "📈 تقرير آخر الحركات";
                bunifuFlatButton3.TextFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
        }
        
        private void StyleGroupBoxes()
        {
            // Get all groupboxes using reflection or manual list
            GroupBox[] groupBoxes = { groupBox1, groupBox2, groupBox3, groupBox4 };
            
            foreach (GroupBox groupBox in groupBoxes)
            {
                if (groupBox != null)
                {
                    ModernTheme.StyleGroupBox(groupBox);
                    groupBox.BackColor = ModernTheme.BackgroundCard;
                    groupBox.ForeColor = ModernTheme.TextPrimary;
                    groupBox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                    groupBox.UseCompatibleTextRendering = false;
                }
            }
        }

        private void frm_cstmrs_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[1].Width = 200;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void demo()
        {
            if (cstmr.get_all_cstmrs().Rows.Count >= 3)
            {
                MessageBox.Show("برجاء شراء البرنامج للتمتع بكافة الصلاحيات \n لايمكنك اضافة عملاء آخرين", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.isDemo)
            {
                demo();
                return;
            }
            if (txtcstadrs.Text==string.Empty||txtcstnme.Text==string.Empty||txtcstpho.Text==string.Empty)
            {
                MessageBox.Show("برجاء ادخال البيانات كامله ","missing data",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtmax.Text))
            {
                txtmax.Text = "1000000";
            }

            BL.cls_cstmrs cstmr = new BL.cls_cstmrs();
            cstmr.ad_cstmr(txtcstnme.Text,txtcstpho.Text,txtcstadrs.Text,Convert.ToDouble(txtmax.Text),combo_mndb.Text);
            MessageBox.Show("تم اضافة العميل بنجاح","عملية الاضافه",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.dataGridView1.DataSource = cstmr.search_cstmrs("");
            txtcstadrs.Text = string.Empty;
            txtcstnme.Text = string.Empty;
            txtcstpho.Text = string.Empty;
            txtmax.Text = string.Empty;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtcstadrs.Text == string.Empty || txtcstnme.Text == string.Empty || txtcstpho.Text == string.Empty)
            {
                MessageBox.Show("برجاء ادخال البيانات كامله وفي حالة عدم معرفه بيان معين اكتب (غير معروف) ", "missing data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cstmr.edit_cstmrs(id, txtcstnme.Text, txtcstpho.Text, txtcstadrs.Text, Convert.ToDouble(txtmax.Text),combo_mndb.Text);
            MessageBox.Show("تم تعديل بيانات العميل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dataGridView1.DataSource = cstmr.search_cstmrs("");
            txtcstadrs.Text = string.Empty;
            txtcstnme.Text = string.Empty;
            txtcstpho.Text = string.Empty;

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtcstadrs.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtcstnme.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtcstpho.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtmax.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            combo_mndb.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = cstmr.search_cstmrs(textBox1.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[1].Value.ToString()=="بيع نقدي")
            {
                MessageBox.Show("عفواً لا يمكنك مسح البيع النقدي","عملية الحذف",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("هل تريد حذف هذا العميل ؟","عمليه الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                cstmr.delete_cstmr(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                this.dataGridView1.DataSource = cstmr.search_cstmrs("");
                txtcstadrs.Text = string.Empty;
                txtcstnme.Text = string.Empty;
                txtcstpho.Text = string.Empty;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)

        {
            frm_cstmr_details frm = new frm_cstmr_details();
            frm.txtcstid.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtcstnme.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.dataGridView1.DataSource = order.get_cstmr_orders( this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frm.dgv_fwateer.DataSource = cstmr.get_all_fwareer_mrtg3_for_cstmr(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));


            ////////////////////////////////////////////////////////////////////////// 
            frm.txttotal.Text = (from DataGridViewRow row in frm.dataGridView1.Rows
                                 where row.Cells[4].FormattedValue.ToString() != string.Empty
                                 select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            double msdd_when_create = (from DataGridViewRow row in frm.dataGridView1.Rows
                                       where row.Cells[2].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum();
            frm_mwrd_pays frm_false = new frm_mwrd_pays();
            frm_false.dgv_mdfo3at.DataSource = cstmr.get_all_cstmr_pays(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
            object some = cstmr.get_all_cstmr_pays(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value)).Compute("Sum(المدفوع)", string.Empty);
            double previous_pays = 0;
            if (!string.IsNullOrEmpty(some.ToString()))
            {
                previous_pays = Convert.ToDouble(some);                
            }

            frm.txtmsdd.Text = (msdd_when_create + previous_pays).ToString();

            double hand_written_rseed = (from DataGridViewRow row in frm_false.dgv_mdfo3at.Rows
                                         where row.Cells[3].FormattedValue.ToString() == "0"
                                         select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum();
            //frm.txt_total_mrtg3.Text = (from DataGridViewRow row in frm.dgv_fwateer.Rows
            //                        where row.Cells[1].FormattedValue.ToString() != string.Empty
            //                        select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum().ToString();   
            double old_mrtg3_total = (from DataGridViewRow row in frm.dgv_fwateer.Rows
                                      where row.Cells[1].FormattedValue.ToString() != string.Empty && row.Cells[5].FormattedValue.ToString() == string.Empty
                                      select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum();
            double new_mrtg3_total = (from DataGridViewRow row in frm.dgv_fwateer.Rows
                                      where row.Cells[5].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum();
            frm.txt_total_mrtg3.Text = (new_mrtg3_total + old_mrtg3_total).ToString();
            //
            frm.txtmtpakii.Text = (Convert.ToDouble(frm.txttotal.Text) + hand_written_rseed -
                Convert.ToDouble(frm.txt_total_mrtg3.Text) - Convert.ToDouble(frm.txtmsdd.Text)).ToString();
            frm.txt_rseed_first.Text = hand_written_rseed.ToString();

        /*      double sum = 0;
            for (int i = 0; i < this.dataGridView1.Rows.Count-1; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            }
             frm.txtmsdd.Text = sum.ToString();*/

         /*    double sum1 = 0;
             for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)
             {
                 sum1 += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
             }
             frm.txtmtpakii.Text = sum1.ToString();*/


        /*   frm.txtmsdd.Text = (from DataGridViewRow row in dataGridView1.Rows
                             where row.Cells[3].FormattedValue.ToString() != string.Empty 
                             select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            frm.txtmtpakii.Text = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[4].FormattedValue.ToString() != string.Empty
                                select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();*/
            // frm.txttotal.Text = (Convert.ToDouble(frm.txtmsdd.Text) + Convert.ToDouble(frm.txtmtpakii.Text)).ToString();

            frm.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(label_first_rseed.Text))
            {
                return;
            }
            try
            {
                
                cstmr.add_cstmr_pay(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToDouble(label_first_rseed.Text), 0,
               Convert.ToDouble(label_first_rseed.Text), DateTime.Now.ToShortDateString(),"","اضافة رصيد",txtnotes.Text);
                MessageBox.Show("تم اضافة الرصيد بنجاح", "اضافة الرصيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label_first_rseed.Text = "";
                txtnotes.Text = "";
            }
            catch (Exception)
            {
                
            }
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                dt.Merge(cstmr.get_all_cstnrs_report(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)));
            }
            frm_all_cstmrs_report frm = new frm_all_cstmrs_report();
            frm.dataGridView1.DataSource = dt;
            for (int i = 0; i < frm.dataGridView1.Rows.Count-1; i++)
            {
                if (!string.IsNullOrEmpty(frm.dataGridView1.Rows[i].Cells[8].Value.ToString()))
                {
                    
                
                    if (Convert.ToDouble(frm.dataGridView1.Rows[i].Cells[8].Value)>0)
                    {
                        frm.dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.Thistle;
                        frm.dataGridView1.Rows[i].Cells[9].Value = "مدين";
                    }
                   else if (Convert.ToDouble(frm.dataGridView1.Rows[i].Cells[8].Value) == 0)
                    {
                        frm.dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.LightGreen;
                        frm.dataGridView1.Rows[i].Cells[9].Value = "خالص";
                    }
                    else if (Convert.ToDouble(frm.dataGridView1.Rows[i].Cells[8].Value) < 0)
                    {
                        frm.dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.LightSalmon;
                        frm.dataGridView1.Rows[i].Cells[9].Value = "دائن";
                        frm.dataGridView1.Rows[i].Cells[8].Value = Math.Abs(Convert.ToDouble(frm.dataGridView1.Rows[i].Cells[8].Value));
                    }
                }

            }
            frm.Show();
        }

        private void txt_qte_TextChanged(object sender, EventArgs e)
        {
             int my_qte = 0;
             if (!string.IsNullOrEmpty(txt_qte.Text) && int.TryParse(txt_qte.Text, out my_qte))
             {
                 string dte = DateTime.Now.AddDays(-my_qte).ToString("dd/MM/yyyy");
                 dataGridView1.DataSource = cstmr.get_all_late_cstmr_pays(dte);
             }
        }

        private void combo_mndb2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
            this.dataGridView1.DataSource = cstmr.search_cstmrs("");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
            string rowFilter = string.Format("[{0}] like '{1}'", "المندوب", combo_mndb2.Text);
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
        DataTable dt2nd = new DataTable();
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            dt2nd.Clear();
            frm_all_mndb_prds frm = new frm_all_mndb_prds();
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                dt2nd.Merge(cstmr.get_last_date_for_cstmr(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)));
            }
            //dt2nd.Columns.Add("عدد ايام اخر فاتورة");
            //dt2nd.Columns.Add("عدد ايام اخر عملية تحصيل");
            //for (int i = 0; i < dt2nd.Rows.Count-1; i++)
            //{
            //    int day1 = ((DateTime.Now.Date -Convert.ToDateTime( dt2nd.Rows[i][3].ToString())).TotalDays + 1).ToString();
            //    int day2 = ((DateTime.Now.Date - dt2nd.Rows[i][3].ToString()).TotalDays + 1).TotalDays + 1).ToString();
            //}

            frm.dataGridView1.DataSource = dt2nd;

            frm.Text = "اخر حركات العميل";
            frm.Show();
        }
    }
}
