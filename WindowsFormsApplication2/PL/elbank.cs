using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
