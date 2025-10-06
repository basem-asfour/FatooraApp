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
    public partial class frm_mwrd_pays : Form
    {
        double new_mdfo3;
        BL.cls_mwrdeen mwrd = new BL.cls_mwrdeen();
        public frm_mwrd_pays()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mdfo3.Text))
            {
            MessageBox.Show("من فضلك قم بتحديد المبلغ", "عمليه الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
            }
            //
            if (radio_rd.Checked == false && radioButton_5sm.Checked == false && radioButton_تحصيل.Checked == false)
            {
                MessageBox.Show("برجاء اختيار نوع العملية", "عمليه الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            new_mdfo3 = Convert.ToDouble(txt_mdfo3.Text);
            if (radioButton_تحصيل.Checked == true)
            {
                if (new_mdfo3 == 0)
                {
                    mwrd.add_mwrd_pays(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, "اضافة رصيد",txtnotes.Text);
                }
                else
                {
                    mwrd.add_mwrd_pays(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, "دفع",txtnotes.Text);
                }
            }
            else if (radio_rd.Checked == true)
            {
                if (new_mdfo3 == 0)
                {
                    mwrd.add_mwrd_pays(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, "اضافة رصيد", txtnotes.Text);
                }
                else if ((new_mdfo3 < 0))
                {
                    mwrd.add_mwrd_pays(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                 Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, "استرجاع من المورد", txtnotes.Text);
                }
                else
                {
                    new_mdfo3 = -1 * new_mdfo3;
                    mwrd.add_mwrd_pays(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(new_mdfo3),
                Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(new_mdfo3), dateTimePicker1.Text, "استرجاع من المورد", txtnotes.Text);
                }
            }
            else if (radioButton_5sm.Checked == true)
            {
                if (new_mdfo3 == 0)
                {
                    mwrd.add_mwrd_pays(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, "اضافة رصيد", txtnotes.Text);
                }
                else
                {
                    mwrd.add_mwrd_pays(Convert.ToInt32(label_id.Text), Convert.ToDouble(label_first_rseed.Text), Convert.ToDouble(txt_mdfo3.Text),
                Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(txt_mdfo3.Text), dateTimePicker1.Text, "خصم مكتسب", txtnotes.Text);
                }
            }
            //
            //new_mdfo3 = Convert.ToDouble(txt_mdfo3.Text);
            

            label_first_rseed.Text = (Convert.ToDouble(label_first_rseed.Text) - Convert.ToDouble(new_mdfo3)).ToString();
            dgv_mdfo3at.DataSource = mwrd.get_all_mwrd_pays(Convert.ToInt32(label_id.Text));
            label_total_mdfo3.Text = (from DataGridViewRow row in dgv_mdfo3at.Rows
                                      where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[6].FormattedValue.ToString() != "خصم مكتسب"
                                      select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            txt_mdfo3.Text = "";
            //for (int i = 0; i < dgv_fwateer.Rows.Count - 1 && new_mdfo3 > 0; i++)
            //{
            //    if (new_mdfo3 >= Convert.ToDouble(dgv_fwateer.Rows[i].Cells[5].Value) && Convert.ToDouble(dgv_fwateer.Rows[i].Cells[5].Value) > 0)
            //    {
            //        mwrd.edit_fwateer_mwrd(Convert.ToInt32(dgv_fwateer.Rows[i].Cells[0].Value),
            //            dgv_fwateer.Rows[i].Cells[1].Value.ToString(), dgv_fwateer.Rows[i].Cells[2].Value.ToString()
            //           , dgv_fwateer.Rows[i].Cells[3].Value.ToString(), dgv_fwateer.Rows[i].Cells[3].Value.ToString(), "0");

            //        new_mdfo3 -= Convert.ToDouble(dgv_fwateer.Rows[i].Cells[5].Value);
            //        dgv_fwateer.DataSource = mwrd.get_all_fwateer_mwrd(label_nme.Text);

            //    }
            //    if (new_mdfo3 < Convert.ToDouble(dgv_fwateer.Rows[i].Cells[5].Value) && Convert.ToDouble(dgv_fwateer.Rows[i].Cells[5].Value) > 0)
            //    {
            //        mwrd.edit_fwateer_mwrd(Convert.ToInt32(dgv_fwateer.Rows[i].Cells[0].Value),
            //            dgv_fwateer.Rows[i].Cells[1].Value.ToString(), dgv_fwateer.Rows[i].Cells[2].Value.ToString()
            //           , dgv_fwateer.Rows[i].Cells[3].Value.ToString(),
            //           (Convert.ToDouble(dgv_fwateer.Rows[i].Cells[4].Value) + new_mdfo3).ToString(),
            //           (Convert.ToDouble(dgv_fwateer.Rows[i].Cells[5].Value) - new_mdfo3).ToString());

            //        new_mdfo3 = 0;
            //        dgv_fwateer.DataSource = mwrd.get_all_fwateer_mwrd(label_nme.Text);

            //    }

            //}
            MessageBox.Show("تمت الاضافة بنجاح", "عمليه الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذا الدفع؟؟", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                label_first_rseed.Text = (Convert.ToDouble(label_first_rseed.Text) + Convert.ToDouble(dgv_mdfo3at.CurrentRow.Cells[4].Value)).ToString();

                mwrd.delete_mwrd_pays(Convert.ToInt32(dgv_mdfo3at.CurrentRow.Cells[0].Value));

                dgv_mdfo3at.DataSource = mwrd.get_all_mwrd_pays(Convert.ToInt32(label_id.Text));
                label_total_mdfo3.Text = (from DataGridViewRow row in dgv_mdfo3at.Rows
                                          where row.Cells[3].FormattedValue.ToString() != string.Empty && row.Cells[6].FormattedValue.ToString() != "خصم مكتسب"
                                          select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
                MessageBox.Show("تم الحذف بنجاح", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
