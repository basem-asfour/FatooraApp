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

    public partial class frm_mordeen : Form
    {
        BL.cls_mwrdeen mwrd = new BL.cls_mwrdeen();
        BL.cls_products prd = new BL.cls_products();
        public frm_mordeen()
        {
            InitializeComponent();
            dataGridView1.DataSource = mwrd.get_all_mwrdeen();

        }

        private void frm_mordeen_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المرد المحدد؟؟","عملية الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                mwrd.delete_mwrd(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = mwrd.get_all_mwrdeen();
                txtnme.Clear();
                txtphone.Clear();
                txtadress.Clear();

            }
        }
        public void demo()
        {
            if (mwrd.get_all_mwrdeen().Rows.Count >= 2)
            {
                MessageBox.Show("برجاء شراء البرنامج للتمتع بكافة الصلاحيات \n لا يمكنك اضافة موردين آخرين", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            mwrd.add_mwrd(txtnme.Text, txtphone.Text, txtadress.Text);
            MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = mwrd.get_all_mwrdeen();
            txtnme.Clear();
            txtphone.Clear();
            txtadress.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تعديل المورد؟؟", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mwrd.edit_mwrd(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), txtnme.Text, txtphone.Text, txtadress.Text);

                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtnme.Clear();
            txtphone.Clear();
            txtadress.Clear();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtnme.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtphone. Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtadress. Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            frm_from_mwrdeen frm = new frm_from_mwrdeen();
            frm.dataGridView_fwater.DataSource = mwrd.get_all_fwateer_mwrd(this.txtnme.Text);
            frm.txtmwrd_nme.Text = this.txtnme.Text;
            frm.txtmwrd_phone.Text = this.txtphone.Text;
            frm.txtmwrd_adress.Text = this.txtadress.Text;
            frm.label_id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txttotal.Text = (from DataGridViewRow row in frm.dataGridView_fwater.Rows
                                 where row.Cells[3].FormattedValue.ToString() != string.Empty
                                 select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            double msdd_when_create = (from DataGridViewRow row in frm.dataGridView_fwater.Rows
                                 where row.Cells[4].FormattedValue.ToString() != string.Empty
                                 select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum();
            //frm.txtmtpakii.Text = (from DataGridViewRow row in frm.dataGridView_fwater.Rows
            //                     where row.Cells[5].FormattedValue.ToString() != string.Empty
            //                     select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
            frm_mwrd_pays frm_false = new frm_mwrd_pays();
            frm_false.dgv_mdfo3at.DataSource = mwrd.get_all_mwrd_pays(Convert.ToInt32(frm.label_id.Text));
            object some = mwrd.get_all_mwrd_pays(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value)).Compute("Sum(المدفوع)", string.Empty);
            double previous_pays = 0;
            if (!string.IsNullOrEmpty(some.ToString()))
            {
                previous_pays = Convert.ToDouble(some);
            }

            frm.txtmsdd.Text = (msdd_when_create + previous_pays).ToString();

            double hand_written_rseed = (from DataGridViewRow row in frm_false.dgv_mdfo3at.Rows
                                         where row.Cells[3].FormattedValue.ToString() == "0"
                                         select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum();
            frm.dgv_all_mrtg3.DataSource = prd.get_all_mrtg3_mshtriat_for_mwrd(this.txtnme.Text);
            frm.txt_mrtg3.Text = (from DataGridViewRow row in frm.dgv_all_mrtg3.Rows
                                  where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() != string.Empty
                                  select Convert.ToDouble(row.Cells[3].FormattedValue) * Convert.ToInt32(row.Cells[2].FormattedValue)).Sum().ToString();
            frm.txtmtpakii.Text = (Convert.ToDouble(frm.txttotal.Text) + hand_written_rseed -
                Convert.ToDouble(frm.txt_mrtg3.Text) - Convert.ToDouble(frm.txtmsdd.Text)).ToString();
            frm.txt_rseed_first.Text = hand_written_rseed.ToString();
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = mwrd.search_mwrdeen(textBox1.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label_first_rseed.Text))
            {
                MessageBox.Show("من فضلك قم بتحديد المبلغ", "عمليه الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            
            mwrd.add_mwrd_pays(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToDouble(label_first_rseed.Text),
                0,Convert.ToDouble(label_first_rseed.Text),DateTime.Now.ToShortDateString(),"اضافة رصيد",txtnotes.Text);

            label_first_rseed.Text = "";
            txtnotes.Clear();
            MessageBox.Show("تمت الاضافة بنجاح", "عمليه الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dt.Merge(mwrd.get_all_mwrdeen_report(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            frm_all_mwrdeen_report frm = new frm_all_mwrdeen_report();
            frm.dataGridView1.DataSource = dt;
            for (int i = 0; i < frm.dataGridView1.Rows.Count - 1; i++)
            {
                if (!string.IsNullOrEmpty(frm.dataGridView1.Rows[i].Cells[8].Value.ToString()))
                {


                    if (Convert.ToDouble(frm.dataGridView1.Rows[i].Cells[8].Value) > 0)
                    {
                        frm.dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.Thistle;
                        frm.dataGridView1.Rows[i].Cells[9].Value = "دائن";
                    }
                    else if (Convert.ToDouble(frm.dataGridView1.Rows[i].Cells[8].Value) == 0)
                    {
                        frm.dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.LightGreen;
                        frm.dataGridView1.Rows[i].Cells[9].Value = "خالص";
                    }
                    else if (Convert.ToDouble(frm.dataGridView1.Rows[i].Cells[8].Value) < 0)
                    {
                        frm.dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.LightSalmon;
                        frm.dataGridView1.Rows[i].Cells[9].Value = "مدين";
                        frm.dataGridView1.Rows[i].Cells[8].Value = Math.Abs(Convert.ToDouble(frm.dataGridView1.Rows[i].Cells[8].Value));
                    }
                }

            }
            frm.Show();
        }
    }
}
