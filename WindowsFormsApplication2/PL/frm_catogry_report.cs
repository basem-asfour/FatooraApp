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
    public partial class frm_catogry_report : Form
    {
        BL.cls_products prd = new BL.cls_products();
        DataTable dt_cat = new DataTable();
        DataTable dt_bee3 = new DataTable();
        DataTable dt_shraa = new DataTable();
        DataTable dt_mrtg3_bee3 = new DataTable();
        DataTable dt_mrtg3_shraa = new DataTable();


        public frm_catogry_report()
        {
            InitializeComponent();
            
            ApplyModernTheme();
            
            dt_cat = prd.get_all_catogries();
            combo_cat.DataSource = dt_cat;
            combo_cat.DisplayMember = "النوع";
            combo_cat.ValueMember = "id";
            dateTimePicker1.Value = DateTime.Now.Date;
            dateTimePicker2.Value = DateTime.Now.Date;
        }
        
        private void ApplyModernTheme()
        {
            // Apply modern form styling
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = ModernTheme.NormalFont;
            
            // Style ComboBox
            if (combo_cat != null)
            {
                ModernTheme.StyleComboBox(combo_cat);
            }
            
            // Style DateTimePickers
            StyleDateTimePickers();
            
            // Style Labels
            StyleLabels();
            
            // Style Buttons
            StyleButtons();
            
            // Style TextBoxes
            StyleTextBoxes();
            
            // Style GroupBoxes
            StyleGroupBoxes();
            
            // Style DataGridViews
            StyleDataGridViews();
        }
        
        private void StyleDateTimePickers()
        {
            if (dateTimePicker1 != null)
            {
                dateTimePicker1.Font = ModernTheme.NormalFont;
                dateTimePicker1.CalendarFont = ModernTheme.NormalFont;
                dateTimePicker1.CalendarTitleBackColor = ModernTheme.PrimaryColor;
                dateTimePicker1.CalendarTitleForeColor = ModernTheme.TextLight;
            }
            
            if (dateTimePicker2 != null)
            {
                dateTimePicker2.Font = ModernTheme.NormalFont;
                dateTimePicker2.CalendarFont = ModernTheme.NormalFont;
                dateTimePicker2.CalendarTitleBackColor = ModernTheme.PrimaryColor;
                dateTimePicker2.CalendarTitleForeColor = ModernTheme.TextLight;
            }
        }
        
        private void StyleLabels()
        {
            Label[] labels = { label1, label3, label7 };
            
            foreach (Label label in labels)
            {
                if (label != null)
                {
                    ModernTheme.StyleLabel(label, LabelStyle.Normal);
                    label.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    label.ForeColor = ModernTheme.TextPrimary;
                }
            }
        }
        
        private void StyleButtons()
        {
            // Search by Category Button
            if (button11 != null)
            {
                ModernTheme.StyleButton(button11, ButtonStyle.Primary);
                button11.Text = "🔍 بحث بالنوع";
                button11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            
            // Search by Category and Date Button
            if (button5 != null)
            {
                ModernTheme.StyleButton(button5, ButtonStyle.Success);
                button5.Text = "📅 بحث بالنوع والتاريخ";
                button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            
            // Exit Button
            if (button7 != null)
            {
                ModernTheme.StyleButton(button7, ButtonStyle.Danger);
                button7.Text = "❌ خروج";
                button7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            
            // Summary Buttons
            if (button6 != null)
            {
                ModernTheme.StyleButton(button6, ButtonStyle.Secondary);
                button6.Text = "💰 إجمالي مبيعات";
                button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
            
            if (button10 != null)
            {
                ModernTheme.StyleButton(button10, ButtonStyle.Secondary);
                button10.Text = "🔄 إجمالي مرتجع مبيعات";
                button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
            
            if (button1 != null)
            {
                ModernTheme.StyleButton(button1, ButtonStyle.Secondary);
                button1.Text = "🛒 إجمالي مشتريات";
                button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
            
            if (button9 != null)
            {
                ModernTheme.StyleButton(button9, ButtonStyle.Secondary);
                button9.Text = "↩️ إجمالي مرتجع مشتريات";
                button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
            
            if (button2 != null)
            {
                ModernTheme.StyleButton(button2, ButtonStyle.Primary);
                button2.Text = "📊 صافي";
                button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
        }
        
        private void StyleTextBoxes()
        {
            // Summary TextBoxes with special styling
            TextBox[] summaryBoxes = { txt_bee3, txt_mrtg3_bee3, txt_shraa, txt_mrtg3_shraa, txt_safi };
            TextBox[] quantityBoxes = { txt_qte_bee3, txt_qte_mrtg3_bee3, txt_qte_shraa, txt_qte_mrtg3_shraa, txt_qte_safi };
            
            foreach (TextBox textBox in summaryBoxes)
            {
                if (textBox != null)
                {
                    textBox.BackColor = ModernTheme.BackgroundCard;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    textBox.ForeColor = ModernTheme.TextPrimary;
                    textBox.TextAlign = HorizontalAlignment.Center;
                }
            }
            
            foreach (TextBox textBox in quantityBoxes)
            {
                if (textBox != null)
                {
                    textBox.BackColor = Color.FromArgb(248, 249, 250);
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                    textBox.ForeColor = ModernTheme.TextSecondary;
                    textBox.TextAlign = HorizontalAlignment.Center;
                }
            }
        }
        
        private void StyleGroupBoxes()
        {
            GroupBox[] groupBoxes = { groupBox1, groupBox2, groupBox3, groupBox4 };
            string[] titles = { "📈 المبيعات", "🛒 المشتريات", "↩️ مرتجع المشتريات", "🔄 مرتجع المبيعات" };
            
            for (int i = 0; i < groupBoxes.Length; i++)
            {
                if (groupBoxes[i] != null)
                {
                    ModernTheme.StyleGroupBox(groupBoxes[i]);
                    groupBoxes[i].BackColor = ModernTheme.BackgroundCard;
                    groupBoxes[i].ForeColor = ModernTheme.TextPrimary;
                    groupBoxes[i].Text = titles[i];
                    groupBoxes[i].Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                }
            }
        }
        
        private void StyleDataGridViews()
        {
            DataGridView[] dataGridViews = { dgv_mbe3at, dgv_mshtriat, dgv_mrtg3_mshtriat, dgv_mrtg3_mbe3at };
            
            foreach (DataGridView dgv in dataGridViews)
            {
                if (dgv != null)
                {
                    ModernTheme.StyleDataGridView(dgv);
                }
            }
        }

        public void refresh_txt()
        {
            txt_bee3.Text = (from DataGridViewRow row in dgv_mbe3at.Rows
                                     where row.Cells[6].FormattedValue.ToString() !=string.Empty
                                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            txt_mrtg3_bee3.Text = (from DataGridViewRow row in dgv_mrtg3_mbe3at.Rows
                                   where row.Cells[2].FormattedValue.ToString() != string.Empty && row.Cells[3].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[3].FormattedValue) * Convert.ToInt32(row.Cells[2].FormattedValue)).Sum().ToString();
            txt_shraa.Text = (from DataGridViewRow row in dgv_mshtriat.Rows
                              where row.Cells[4].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_mrtg3_shraa.Text = (from DataGridViewRow row in dgv_mrtg3_mshtriat.Rows
                                        where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[4].FormattedValue.ToString() != string.Empty
                                        select Convert.ToDouble(row.Cells[4].FormattedValue) * Convert.ToInt32(row.Cells[3].FormattedValue)).Sum().ToString();
            ///////////////////////////////////////////////quantities
            txt_qte_bee3.Text = (from DataGridViewRow row in dgv_mbe3at.Rows
                             where row.Cells[3].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            txt_qte_mrtg3_bee3.Text = (from DataGridViewRow row in dgv_mrtg3_mbe3at.Rows
                                   where row.Cells[2].FormattedValue.ToString() != string.Empty 
                                   select  Convert.ToInt32(row.Cells[2].FormattedValue)).Sum().ToString();
            txt_qte_shraa.Text = (from DataGridViewRow row in dgv_mshtriat.Rows
                              where row.Cells[2].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
            txt_qte_mrtg3_shraa.Text = (from DataGridViewRow row in dgv_mrtg3_mshtriat.Rows
                                        where row.Cells[3].FormattedValue.ToString() != string.Empty 
                                        select Convert.ToInt32(row.Cells[3].FormattedValue)).Sum().ToString();
            ///////////////////////////////////////////////////final
            txt_safi.Text = (Convert.ToDouble(txt_shraa.Text) + Convert.ToDouble(txt_mrtg3_bee3.Text) -
                Convert.ToDouble(txt_bee3.Text) - Convert.ToDouble(txt_mrtg3_shraa.Text)).ToString();
            txt_qte_safi.Text = (Convert.ToDouble(txt_qte_shraa.Text) + Convert.ToDouble(txt_qte_mrtg3_bee3.Text) -
                Convert.ToDouble(txt_qte_bee3.Text) - Convert.ToDouble(txt_qte_mrtg3_shraa.Text)).ToString();
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
            if (!string.IsNullOrEmpty(combo_cat.Text))
            {
                dgv_mbe3at.DataSource = prd.get_order_details_for_catogry_report(combo_cat.Text);
                dgv_mrtg3_mbe3at.DataSource = prd.get_mrtg3_mbe3at_for_catogry_report(combo_cat.Text);
                dgv_mrtg3_mshtriat.DataSource = prd.get_mrtg3_mshtriat_for_catogry_report(combo_cat.Text);
                dgv_mshtriat.DataSource = prd.get_purchases_for_catogry_report(combo_cat.Text);
                refresh_txt();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dt_mrtg3_shraa.Clear();
            dt_shraa.Clear();
            dt_bee3.Clear();
            dt_mrtg3_bee3.Clear();
            foreach (var item in get_dates_between(dateTimePicker1.Value, dateTimePicker2.Value))
            {
                //(dgv_mbe3at.DataSource as DataTable).DefaultView.RowFilter = null;
                //(dgv_mshtriat.DataSource as DataTable).DefaultView.RowFilter = null;
                //(dgv_mrtg3_mshtriat.DataSource as DataTable).DefaultView.RowFilter = null;
                //(dgv_mbe3at.DataSource as DataTable).DefaultView.RowFilter = null;

                //string rowFilter = string.Format("[{0}] Like '%''{1}''%'", "تاريخ الفاتورة", item.Date.ToString("dd/MM/yyyy"));
                //(dgv_mbe3at.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                //string rowFilter2 = string.Format("[{0}] Like '%''{1}''%'", "التاريخ", item.Date.ToString("dd/MM/yyyy"));
                //(dgv_mshtriat.DataSource as DataTable).DefaultView.RowFilter = rowFilter2;
                //(dgv_mrtg3_mshtriat.DataSource as DataTable).DefaultView.RowFilter = rowFilter2;
                //string rowFilter3 = string.Format("[{0}] Like '%''{1}''%'", "تاريخ الإسترجاع", item.Date.ToString("dd/MM/yyyy"));
                //(dgv_mrtg3_mbe3at.DataSource as DataTable).DefaultView.RowFilter = rowFilter3;

                dt_bee3.Merge(prd.get_order_details_for_catogry_report_date_filter(combo_cat.Text,item.Date));
                dt_mrtg3_bee3.Merge(prd.get_mrtg3_mbe3at_for_catogry_report_date_filter(combo_cat.Text, item.Date));
                dt_shraa.Merge(prd.get_purchases_for_catogry_report_date_filter(combo_cat.Text, item.Date.ToString("dd/MM/yyyy")));
                dt_mrtg3_shraa.Merge(prd.get_mrtg3_mshtriat_for_catogry_report_date_filter(combo_cat.Text, item.Date));
            }
            dgv_mbe3at.DataSource = dt_bee3;
            dgv_mshtriat.DataSource = dt_shraa;
            dgv_mrtg3_mbe3at.DataSource = dt_mrtg3_bee3;
            dgv_mrtg3_mshtriat.DataSource = dt_mrtg3_shraa;
            refresh_txt();

        }

        private void frm_catogry_report_Load(object sender, EventArgs e)
        {

        }
    }
}
