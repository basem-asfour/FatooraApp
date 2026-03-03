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
    public partial class frm_cstmr_pays : Form
    {
        BL.cls_cstmrs cstmr = new BL.cls_cstmrs();
        BL.cls_orders order = new BL.cls_orders();
        DataTable dt_cstmr = new DataTable();
        double new_mdfo3;
        DataTable dt_mndob;
        BL.cls_mndobeen mndb = new BL.cls_mndobeen();
        public frm_cstmr_pays()
        {
            InitializeComponent();
            
            ApplyModernTheme();
            
            //
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now; 
            dateTimePicker3.Value = DateTime.Now;
            dt_mndob = mndb.get_all_mndopeen();
            combo_mndoob.DataSource = dt_mndob;
            combo_mndoob.DisplayMember = "اسم المندوب";
            combo_mndoob.ValueMember = "id";
        }
        
        private void ApplyModernTheme()
        {
            // Apply modern form styling
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            
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
            
            // Style ComboBoxes
            StyleComboBoxes();
            
            // Style DateTimePickers
            StyleDateTimePickers();
            
            // Style RadioButtons
            StyleRadioButtons();
        }
        
        private void StyleTextBoxes()
        {
            if (txt_mdfo3 != null)
            {
                ModernTheme.StyleTextBox(txt_mdfo3);
                txt_mdfo3.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            }
            
            if (txt_notes != null)
            {
                ModernTheme.StyleTextBox(txt_notes);
                txt_notes.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            }
            
            if (label_first_rseed != null)
            {
                label_first_rseed.BackColor = Color.FromArgb(248, 249, 250); // Very light gray for readonly
                label_first_rseed.ForeColor = ModernTheme.TextSecondary;
                label_first_rseed.BorderStyle = BorderStyle.FixedSingle;
                label_first_rseed.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            }
        }
        
        private void StyleLabels()
        {
            Label[] labels = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, labl4 };
            
            foreach (Label label in labels)
            {
                if (label != null)
                {
                    ModernTheme.StyleLabel(label, LabelStyle.Normal);
                    // Use standard font without any spacing modifications
                    label.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                    label.ForeColor = ModernTheme.TextPrimary;
                    // Ensure no letter spacing
                    label.UseCompatibleTextRendering = false;
                    // Disable auto sizing
                    label.AutoSize = false;
                }
            }
            
            // Special styling for dynamic labels
            if (label_id != null)
            {
                label_id.BackColor = Color.FromArgb(220, 248, 198); // Light green for customer ID
                label_id.ForeColor = Color.FromArgb(39, 174, 96); // Dark green text
                label_id.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                label_id.UseCompatibleTextRendering = false;
                label_id.AutoSize = false;
            }
            
            if (label_nme != null)
            {
                label_nme.BackColor = Color.FromArgb(220, 248, 198); // Light green for customer name
                label_nme.ForeColor = Color.FromArgb(39, 174, 96); // Dark green text
                label_nme.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                label_nme.UseCompatibleTextRendering = false;
                label_nme.AutoSize = false;
            }
            
            if (label_total_mdfo3 != null)
            {
                label_total_mdfo3.BackColor = Color.FromArgb(255, 243, 205); // Light orange for total
                label_total_mdfo3.ForeColor = Color.FromArgb(230, 126, 34); // Dark orange text
                label_total_mdfo3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                label_total_mdfo3.UseCompatibleTextRendering = false;
                label_total_mdfo3.AutoSize = false;
            }
        }
        
        private void StyleButtons()
        {
            // Add Payment Button
            if (btn_add != null)
            {
                ModernTheme.StyleButton(btn_add, ButtonStyle.Success);
                btn_add.Text = "💳 تحصيل المبلغ";
                btn_add.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btn_add.UseCompatibleTextRendering = false;
            }
            
            // Edit Button
            if (btn_edit != null)
            {
                ModernTheme.StyleButton(btn_edit, ButtonStyle.Warning);
                btn_edit.Text = "✏️ تعديل المحدد";
                btn_edit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btn_edit.UseCompatibleTextRendering = false;
            }
            
            // Delete Button
            if (btn_delete != null)
            {
                ModernTheme.StyleButton(btn_delete, ButtonStyle.Danger);
                btn_delete.Text = "🗑️ حذف المحدد";
                btn_delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btn_delete.UseCompatibleTextRendering = false;
            }
            
            // Filter Buttons
            if (button1 != null)
            {
                ModernTheme.StyleButton(button1, ButtonStyle.Primary);
                button1.Text = "🔍 عرض التحصيلات فقط";
                button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                button1.UseCompatibleTextRendering = false;
            }
            
            if (button3 != null)
            {
                ModernTheme.StyleButton(button3, ButtonStyle.Secondary);
                button3.Text = "📋 عرض الكل";
                button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                button3.UseCompatibleTextRendering = false;
            }
            
            if (button5 != null)
            {
                ModernTheme.StyleButton(button5, ButtonStyle.Primary);
                button5.Text = "🔍 بحث";
                button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                button5.UseCompatibleTextRendering = false;
            }
        }
        
        private void StyleGroupBoxes()
        {
            if (groupBox1 != null)
            {
                ModernTheme.StyleGroupBox(groupBox1);
                groupBox1.BackColor = ModernTheme.BackgroundCard;
                groupBox1.ForeColor = ModernTheme.TextPrimary;
                groupBox1.Text = "💳 قائمة مدفوعات العميل";
                groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                groupBox1.UseCompatibleTextRendering = false;
            }
            
            if (groupBox2 != null)
            {
                ModernTheme.StyleGroupBox(groupBox2);
                groupBox2.BackColor = ModernTheme.BackgroundCard;
                groupBox2.ForeColor = ModernTheme.TextPrimary;
                groupBox2.Text = "🔧 العمليات المتاحة";
                groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                groupBox2.UseCompatibleTextRendering = false;
            }
            
            if (groupBox3 != null)
            {
                ModernTheme.StyleGroupBox(groupBox3);
                groupBox3.BackColor = ModernTheme.BackgroundCard;
                groupBox3.ForeColor = ModernTheme.TextPrimary;
                groupBox3.Text = "📝 بيانات التحصيل";
                groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                groupBox3.UseCompatibleTextRendering = false;
            }
            
            if (groupBox4 != null)
            {
                ModernTheme.StyleGroupBox(groupBox4);
                groupBox4.BackColor = ModernTheme.BackgroundCard;
                groupBox4.ForeColor = ModernTheme.TextPrimary;
                groupBox4.Text = "📋 الفواتير الخاصة بالعميل";
                groupBox4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                groupBox4.UseCompatibleTextRendering = false;
            }
            
            if (groupBox5 != null)
            {
                ModernTheme.StyleGroupBox(groupBox5);
                groupBox5.BackColor = Color.FromArgb(248, 249, 250); // Very light background
                groupBox5.ForeColor = ModernTheme.TextPrimary;
                groupBox5.Text = "⚙️ نوع العملية";
                groupBox5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                groupBox5.UseCompatibleTextRendering = false;
            }
        }
        
        private void StyleDataGridViews()
        {
            if (dataGridView1 != null)
            {
                ModernTheme.StyleDataGridView(dataGridView1);
            }
            
            if (dataGridView2 != null)
            {
                ModernTheme.StyleDataGridView(dataGridView2);
            }
        }
        
        private void StyleComboBoxes()
        {
            if (combo_mndoob != null)
            {
                ModernTheme.StyleComboBox(combo_mndoob);
                combo_mndoob.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
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
            
            if (dateTimePicker3 != null)
            {
                dateTimePicker3.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                dateTimePicker3.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular);
                dateTimePicker3.CalendarTitleBackColor = ModernTheme.PrimaryColor;
                dateTimePicker3.CalendarTitleForeColor = ModernTheme.TextLight;
            }
        }
        
        private void StyleRadioButtons()
        {
            if (radioButton_تحصيل != null)
            {
                radioButton_تحصيل.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                radioButton_تحصيل.ForeColor = ModernTheme.TextPrimary;
                radioButton_تحصيل.Text = "💳 تحصيل";
                radioButton_تحصيل.UseCompatibleTextRendering = false;
            }
            
            if (radioButton_5sm != null)
            {
                radioButton_5sm.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                radioButton_5sm.ForeColor = ModernTheme.TextPrimary;
                radioButton_5sm.Text = "💰 خصم مسموح به";
                radioButton_5sm.UseCompatibleTextRendering = false;
            }
            
            if (radio_rd != null)
            {
                radio_rd.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                radio_rd.ForeColor = ModernTheme.TextPrimary;
                radio_rd.Text = "↩️ رد للعميل";
                radio_rd.UseCompatibleTextRendering = false;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mdfo3.Text))
            {
                MessageBox.Show("من فضلك قم بتحديد المبلغ", "عمليه الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (radio_rd.Checked==false&&radioButton_5sm.Checked==false&&radioButton_تحصيل.Checked==false)
            {
           MessageBox.Show("برجاء اختيار نوع العملية", "عمليه الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
           return;
            }
            new_mdfo3 = Convert.ToDouble(txt_mdfo3.Text);
            if (radioButton_تحصيل.Checked==true)
            {
                if (new_mdfo3 == 0)
                {
                    cstmr.add_cstmr_pay(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                    Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, "","اضافة رصيد",txt_notes.Text);
                }
                else
                {
                    cstmr.add_cstmr_pay(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                    Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, combo_mndoob.Text,"تحصيل",txt_notes.Text);
                }
            }
            else if (radio_rd.Checked==true)
            {
                if (new_mdfo3 == 0)
                {
                    cstmr.add_cstmr_pay(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                    Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, "","اضافة رصيد",txt_notes.Text);
                }
                else if ((new_mdfo3 < 0))
                {
                    cstmr.add_cstmr_pay(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                    Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, combo_mndoob.Text,"رد للعميل",txt_notes.Text);
                }
                else
                {
                    new_mdfo3 = -1*new_mdfo3;
                    cstmr.add_cstmr_pay(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(new_mdfo3),
                   Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(new_mdfo3), dateTimePicker1.Text, combo_mndoob.Text, "رد للعميل",txt_notes.Text);
                }
            }
            else if (radioButton_5sm.Checked==true)
            {
                if (new_mdfo3 == 0)
                {
                    cstmr.add_cstmr_pay(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                    Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, "","اضافة رصيد",txt_notes.Text);
                }
                else
                {
                    cstmr.add_cstmr_pay(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                    Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, combo_mndoob.Text,"خصم مسموح به",txt_notes.Text);
                }
            }
            

           label_first_rseed.Text=(Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(new_mdfo3)).ToString();
           dataGridView1.DataSource = cstmr.get_all_cstmr_pays(Convert.ToInt32(label_id.Text));
           label_total_mdfo3.Text = (from DataGridViewRow row in dataGridView1.Rows
                                     where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[6].FormattedValue.ToString() != "خصم مسموح به"
                                     select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
           txt_mdfo3.Text = "";
           txt_notes.Text = "";
           //for (int i = 0; i < dataGridView2.Rows.Count-1 && new_mdfo3>0; i++)
           //{
           //    if (new_mdfo3 >= Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value) && Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value)>0)
           //    {
           //        order.update_msdd_mtpakii(dataGridView2.Rows[i].Cells[0].Value.ToString()
           //            , dataGridView2.Rows[i].Cells[4].Value.ToString(), "0");

           //        order.update_msdd_mtpakii_in_new_orders(dataGridView2.Rows[i].Cells[0].Value.ToString()
           //            , dataGridView2.Rows[i].Cells[4].Value.ToString(), "0");
           //        new_mdfo3 -= Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value);
           //    }
           //    else if (new_mdfo3 < Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value) && Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value) > 0)
           //    {
           //         order.update_msdd_mtpakii(dataGridView2.Rows[i].Cells[0].Value.ToString()
           //            ,(Convert.ToDouble( dataGridView2.Rows[i].Cells[2].Value)+new_mdfo3).ToString(),
           //            (Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value)- new_mdfo3).ToString());

           //        order.update_msdd_mtpakii_in_new_orders(dataGridView2.Rows[i].Cells[0].Value.ToString()
           //            , (Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value) + new_mdfo3).ToString(),
           //            (Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value) - new_mdfo3).ToString());
           //        new_mdfo3 = 0;
           //    }
            
           //}
           MessageBox.Show("تمت الاضافة بنجاح", "عمليه الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
           dataGridView2.DataSource = order.get_cstmr_orders(label_id.Text);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("هل تريد حذف هذا الدفع؟؟", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
            {
                label_first_rseed.Text = (Convert.ToDouble(label_first_rseed.Text) + Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value)).ToString();

                cstmr.delete_cstmr_pay(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                dataGridView1.DataSource = cstmr.get_all_cstmr_pays(Convert.ToInt32(label_id.Text));
                label_total_mdfo3.Text = (from DataGridViewRow row in dataGridView1.Rows
                                          where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[6].FormattedValue.ToString() != "خصم مسموح به"
                                          select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
                MessageBox.Show("تم الحذف بنجاح", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rowFilter = string.Format("[{0}] like '{1}'", "نوع العملية", "تحصيل");
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;

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
        private void button5_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;

            foreach (var item in get_dates_between(dateTimePicker3.Value, dateTimePicker2.Value))
            {

                dt_cstmr.Merge(cstmr.get_all_cstmrs_pays_bydate(item.Date.ToString("dd/MM/yyyy")));



            }
            dataGridView1.DataSource = dt_cstmr;

        }
    }
}
