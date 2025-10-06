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
    public partial class frm_manage_mrtg3_mbe3at : Form
    {
        BL.cls_cstmrs cstmr = new BL.cls_cstmrs();
        DataTable dt_combobox = new DataTable();

        public frm_manage_mrtg3_mbe3at()
        {
            InitializeComponent();
            dgv_fwateer.DataSource = cstmr.get_all_fwareer_mrtg3();
            //
            dt_combobox = cstmr.get_all_cstmrs();
            combo_cstmrs.DataSource = dt_combobox;
            combo_cstmrs.DisplayMember = "اسم العميل";
            combo_cstmrs.ValueMember = "id_cstmr";
            //
            radioButton_nesba.Checked = true;
            refresh_frm();

        }
        public void refresh_frm()
        {
            dgv_fwateer.DataSource = cstmr.get_all_fwareer_mrtg3();

            double old_mrtg3_total = (from DataGridViewRow row in dgv_fwateer.Rows
                                      where row.Cells[1].FormattedValue.ToString() != string.Empty && row.Cells[5].FormattedValue.ToString() == string.Empty
                                      select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum();
            double new_mrtg3_total = (from DataGridViewRow row in dgv_fwateer.Rows
                                      where row.Cells[5].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum();
            txt_total_mrtg3.Text = (new_mrtg3_total + old_mrtg3_total).ToString();

        }

        void calctotalprice_afterTotal_5sm()
        {
            if (string.IsNullOrEmpty(txt_total_5sm.Text))
            {
                txt_total_5sm.Text = "0";
            }
            if (txtmg.Text != string.Empty)
            {
                double xx;
                xx = Convert.ToDouble(txtmg.Text);
                   txt_total_after_5sm.Text = (xx - (xx / 100 * Convert.ToDouble(txt_total_5sm.Text))).ToString();

                
                if (txt_total_5sm.Text == "0")
                {
                    txt_total_after_5sm.Text = txtmg.Text;
                }
            }
        }
        void calcTotalPriceAfter_number_5sm()
        {
            if (string.IsNullOrEmpty(txt_total_5sm.Text))
            {
                txt_total_5sm.Text = "0";
            }
            if (txtmg.Text != string.Empty)
            {

                txt_total_after_5sm.Text = (Convert.ToDouble(txtmg.Text) - Convert.ToDouble(txt_total_5sm.Text)).ToString();
                if (txt_total_5sm.Text == "0")
                {
                    txt_total_after_5sm.Text = txtmg.Text;
                }
                if (string.IsNullOrEmpty(txt_total_5sm.Text))
                {
                    txt_total_5sm.Text = "0";
                }

            }
        }


        private void radioButton_nesba_CheckedChanged(object sender, EventArgs e)
        {
            txt_total_5sm.Text = "0";

        }

        private void radioButton_number_CheckedChanged(object sender, EventArgs e)
        {
            txt_total_5sm.Text = "0";

        }

        private void txt_total_5sm_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_nesba.Checked == true || radioButton_nesba.Checked == false && radioButton_number.Checked == false)
            {
                calctotalprice_afterTotal_5sm();
            }
            else
            {
                calcTotalPriceAfter_number_5sm();
            }
        }

        private void dgv_fwateer_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_asnaaf.DataSource = cstmr.get_all_fatora_mrtg3_products(Convert.ToInt32(dgv_fwateer.CurrentRow.Cells[0].Value));
                txtmg.Text = dgv_fwateer.CurrentRow.Cells[1].Value.ToString();

            }
            catch (Exception)
            {

            }
        }

        private void combo_cstmrs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_asnaaf.DataSource = "";
                refresh_frm();
                txtmg.Text = "";
                dgv_fwateer.DataSource = cstmr.get_all_fwareer_mrtg3_for_cstmr(Convert.ToInt32(combo_cstmrs.SelectedValue));

            }
            catch (Exception)
            {
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton_nesba.Checked==true)
	            {
                    cstmr.update_cstmr_fatora(Convert.ToInt32(dgv_fwateer.CurrentRow.Cells[0].Value), Convert.ToDouble(txtmg.Text),
                Convert.ToDouble(txt_total_5sm.Text), "نسبة(%)", Convert.ToDouble(txt_total_after_5sm.Text));
	            }
           else if (radioButton_number.Checked==true)
            {
                cstmr.update_cstmr_fatora(Convert.ToInt32(dgv_fwateer.CurrentRow.Cells[0].Value), Convert.ToDouble(txtmg.Text),
                 Convert.ToDouble(txt_total_5sm.Text), "رقمي", Convert.ToDouble(txt_total_after_5sm.Text));   
            }
            MessageBox.Show("تم تسجيل الخصم بنجاح", "عملية تسجيل الخصم", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refresh_frm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الفاتورة المحددة ؟", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cstmr.delete_cstmr_fatora(Convert.ToInt32(dgv_fwateer.CurrentRow.Cells[0].Value));
                dgv_asnaaf.DataSource = "";
                refresh_frm();     
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_asnaaf.Rows.Count==0)
            {
                MessageBox.Show("من فضلك قم باختيار الفاتورة أولا", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (MessageBox.Show("هل تريد حذف الفاتورة المحددة وحذف اصنافها من المرتجعات ؟", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < dgv_asnaaf.Rows.Count-1; i++)
			{
                cstmr.after_delete_mrtg3_mbe3at(Convert.ToInt32(dgv_asnaaf.Rows[i].Cells[1].Value), Convert.ToInt32(dgv_asnaaf.Rows[i].Cells[0].Value));
			 
			}
                cstmr.delete_cstmr_fatora_with_products(Convert.ToInt32(dgv_fwateer.CurrentRow.Cells[0].Value));
                dgv_fwateer.Update();
                dgv_asnaaf.DataSource = "";
                refresh_frm();
            }
        }
    }
}
