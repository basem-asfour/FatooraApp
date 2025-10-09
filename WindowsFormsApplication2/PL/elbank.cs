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
    public partial class elbank : Form
    {
        double elrasid = 0;
        string type = "ايداع";
        BL.cls_elbank bank = new BL.cls_elbank();
        public elbank()
        {
            InitializeComponent();
            dataGridView1.DataSource = bank.get_all_elbank();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;

            try
            {
                txt_first.Text = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Value.ToString();

            }
            catch (Exception)
            {

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "ايداع")
                    {
                        elrasid += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    }
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "سحب")
                    {
                        elrasid -= Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);

                    }


                }
                textBox1.Text = elrasid.ToString();
                elrasid = 0;
                txt_first.Text = textBox1.Text;
            }
            
            ApplyModernTheme();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد مسح العملية المحددة؟؟","عملية الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                bank.delete_bank(Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف بنجاح","عملية الحذف",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataGridView1.DataSource = bank.get_all_elbank();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton_sa7b.Checked==true)
	{
		 type="سحب";
         bank.add_elbank(type, Convert.ToDouble(txt_first.Text), txtvalue.Text, Convert.ToDouble(txt_first.Text) - Convert.ToDouble(txtvalue.Text), txtdskrbshn.Text, dateTimePicker1.Text);

	}
            else if (radioButton_eyda3.Checked==true)
            {
                type = "ايداع";
                bank.add_elbank(type, Convert.ToDouble(txt_first.Text), txtvalue.Text, Convert.ToDouble(txt_first.Text) + Convert.ToDouble(txtvalue.Text), txtdskrbshn.Text, dateTimePicker1.Text);

            }
            dataGridView1.DataSource = bank.get_all_elbank();
            MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtdskrbshn.Clear();
            txtvalue.Clear();
            radioButton_sa7b.Checked = false;
            radioButton_eyda3.Checked = false;
            type = "ايداع";
            int last_row=dataGridView1.Rows.Count - 2;
            txt_first.Text = dataGridView1.Rows[last_row].Cells[4].Value.ToString();



        }

        private void label4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString()=="ايداع")
                {
                    elrasid += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                }
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "سحب")
                {
                    elrasid -= Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);

                }
                
               
            }
            textBox1.Text = elrasid.ToString();
            elrasid = 0;
        }

        private void elbank_Load(object sender, EventArgs e)
        {

        }
        DataTable dt = new DataTable();
        private void button5_Click(object sender, EventArgs e)
        {
            dt.Clear();
            foreach (var item in get_dates_between(dateTimePicker3.Value, dateTimePicker2.Value))
            {
                dt.Merge(bank.filter_elbank_by_date(item.ToString("dd/MM/yyyy")));
            }
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bank.get_all_elbank();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        
        private void ApplyModernTheme()
        {
            // Apply modern form styling
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = ModernTheme.NormalFont;
            
            // Style GroupBox
            ModernTheme.StyleGroupBox(groupBox1);
            groupBox1.BackColor = ModernTheme.BackgroundCard;
            groupBox1.ForeColor = ModernTheme.TextPrimary;
            
            // Style DataGridView
            ModernTheme.StyleDataGridView(dataGridView1);
            
            // Style TextBoxes
            ModernTheme.StyleTextBox(txtdskrbshn);
            ModernTheme.StyleTextBox(txtvalue);
            ModernTheme.StyleTextBox(txt_first);
            ModernTheme.StyleTextBox(textBox1);
            
            // Style Labels
            StyleLabels();
            
            // Style Buttons
            StyleButtons();
            
            // Style RadioButtons
            StyleRadioButtons();
            
            // Style DateTimePickers
            StyleDateTimePickers();
            
            // Apply special styling
            ApplySpecialStyling();
        }
        
        private void StyleLabels()
        {
            Label[] labels = { label1, label2, label3, label4, label5, label6, label7, label8 };
            
            foreach (Label label in labels)
            {
                if (label != null)
                {
                    ModernTheme.StyleLabel(label, LabelStyle.Normal);
                }
            }
            
            // Special styling for balance label
            if (label4 != null)
            {
                label4.BackColor = ModernTheme.PrimaryColor;
                label4.ForeColor = ModernTheme.TextLight;
                label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            }
        }
        
        private void StyleButtons()
        {
            // Main action buttons
            ModernTheme.StyleButton(button1, ButtonStyle.Success);
            ModernTheme.StyleButton(button2, ButtonStyle.Danger);
            ModernTheme.StyleButton(button3, ButtonStyle.Danger);
            ModernTheme.StyleButton(button4, ButtonStyle.Secondary);
            ModernTheme.StyleButton(button5, ButtonStyle.Primary);
            ModernTheme.StyleButton(button6, ButtonStyle.Primary);
        }
        
        private void StyleRadioButtons()
        {
            if (radioButton_eyda3 != null)
            {
                radioButton_eyda3.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                radioButton_eyda3.ForeColor = ModernTheme.TextPrimary;
                radioButton_eyda3.BackColor = ModernTheme.BackgroundCard;
            }
            
            if (radioButton_sa7b != null)
            {
                radioButton_sa7b.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                radioButton_sa7b.ForeColor = ModernTheme.TextPrimary;
                radioButton_sa7b.BackColor = ModernTheme.BackgroundCard;
            }
        }
        
        private void StyleDateTimePickers()
        {
            DateTimePicker[] datePickers = { dateTimePicker1, dateTimePicker2, dateTimePicker3 };
            
            foreach (DateTimePicker datePicker in datePickers)
            {
                if (datePicker != null)
                {
                    datePicker.Font = new Font("Segoe UI", 10F);
                    datePicker.CalendarFont = new Font("Segoe UI", 10F);
                    datePicker.CalendarTitleBackColor = ModernTheme.PrimaryColor;
                    datePicker.CalendarTitleForeColor = ModernTheme.TextLight;
                }
            }
        }
        
        private void ApplySpecialStyling()
        {
            // Style readonly textbox
            if (textBox1 != null)
            {
                textBox1.BackColor = Color.FromArgb(230, 244, 241); // Light green
                textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            }
        }
    }
}
