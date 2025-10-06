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
    public partial class frm_product_card : Form
    {
        BL.cls_products prd = new BL.cls_products();
        public frm_product_card()
        {
            InitializeComponent();
        }

        private void frm_product_card_Load(object sender, EventArgs e)
        {

        }
        void refresh()
        {
            int real_qte = 0;
            double real_rseed = 0;
            try
            {
                if (dgv_mwrdeen.Rows.Count > 1)
                {
                    if (dgv_mwrdeen.Rows[0].Cells[2].Value.ToString() == "0" || dgv_mwrdeen.Rows[0].Cells[2].Value.ToString() != dgv__first_rseed.Rows[0].Cells[3].Value.ToString())
                    {
                        real_qte = Convert.ToInt32(txt_qte_first_rseed.Text) + Convert.ToInt32(txt_qte_mshtriat.Text) + Convert.ToInt32(txt_qte_mrtg3_mbe3at.Text) -
                      Convert.ToInt32(txt_qte_mbe3at.Text) - Convert.ToInt32(txt_qte_mrtg3_mshtriat.Text) - Convert.ToInt32(txt_qte_corrupted.Text);
                        txt_qte_real.Text = real_qte.ToString();

                        real_rseed = Convert.ToDouble(txt_total_first_rseed.Text) + Convert.ToDouble(txt_total_buy.Text) + Convert.ToDouble(txt_mrtg3_mbe3at.Text) -
                           Convert.ToDouble(txt_mrtg3_mshtriat.Text) - Convert.ToDouble(txt_total_sales.Text) - Convert.ToDouble(txt_total_corrupted.Text);
                        txt_rseed_real.Text = Math.Round(real_rseed, 3).ToString();
                    }
                    else
                    {
                        real_qte = Convert.ToInt32(txt_qte_mshtriat.Text) + Convert.ToInt32(txt_qte_mrtg3_mbe3at.Text) -
                      Convert.ToInt32(txt_qte_mbe3at.Text) - Convert.ToInt32(txt_qte_mrtg3_mshtriat.Text) - Convert.ToInt32(txt_qte_corrupted.Text);
                        txt_qte_real.Text = real_qte.ToString();

                        real_rseed = Convert.ToDouble(txt_total_buy.Text) + Convert.ToDouble(txt_mrtg3_mbe3at.Text) -
                           Convert.ToDouble(txt_mrtg3_mshtriat.Text) - Convert.ToDouble(txt_total_sales.Text) - Convert.ToDouble(txt_total_corrupted.Text);
                        txt_rseed_real.Text = Math.Round(real_rseed, 3).ToString();
                    }

                }
                else
                {
                    real_qte = Convert.ToInt32(txt_qte_first_rseed.Text) + Convert.ToInt32(txt_qte_mshtriat.Text) + Convert.ToInt32(txt_qte_mrtg3_mbe3at.Text) -
                      Convert.ToInt32(txt_qte_mbe3at.Text) - Convert.ToInt32(txt_qte_mrtg3_mshtriat.Text) - Convert.ToInt32(txt_qte_corrupted.Text);
                    txt_qte_real.Text = real_qte.ToString();

                    real_rseed = Convert.ToDouble(txt_total_first_rseed.Text) + Convert.ToDouble(txt_total_buy.Text) + Convert.ToDouble(txt_mrtg3_mbe3at.Text) -
                       Convert.ToDouble(txt_mrtg3_mshtriat.Text) - Convert.ToDouble(txt_total_sales.Text) - Convert.ToDouble(txt_total_corrupted.Text);
                    txt_rseed_real.Text = Math.Round(real_rseed, 3).ToString();
                }

            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message.ToString());
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            prd.update_prd_first_rseed(Convert.ToInt32(dgv__first_rseed.Rows[0].Cells[1].Value),DateTime.Now.ToString("dd/MM/yyyy"));
            dgv__first_rseed.DataSource = prd.search_prd_first_rseed(txtname.Text);
            txt_total_first_rseed.Text = (from DataGridViewRow row in dgv__first_rseed.Rows
                                          where row.Cells[5].FormattedValue.ToString() != string.Empty
                                          select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
            txt_qte_first_rseed.Text = (from DataGridViewRow row in dgv__first_rseed.Rows
                                        where row.Cells[3].FormattedValue.ToString() != string.Empty
                                        select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            MessageBox.Show("تم تحديث رصيد اول ببيانات الصنف الموجودة في ادارة الاصناف بنجاح ","تحديث رصيد اول",MessageBoxButtons.OK,MessageBoxIcon.Information);
            refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            prd.edit_prd_qte_for_gard(Convert.ToInt32(dgv__first_rseed.Rows[0].Cells[1].Value), Convert.ToInt32(txt_qte_real.Text));
            MessageBox.Show("تم تحديث الكمية بنجاح ", "تحديث  الكمية", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("هل تريد حذف الرصيد المحدد؟؟", "حذف رصيد أول", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                prd.Delete_prd_first_rseed(Convert.ToInt32(dgv__first_rseed.CurrentRow.Cells[0].Value));
                dgv__first_rseed.DataSource = prd.search_prd_first_rseed(txtname.Text);
                txt_total_first_rseed.Text = (from DataGridViewRow row in dgv__first_rseed.Rows
                                              where row.Cells[5].FormattedValue.ToString() != string.Empty
                                              select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
                txt_qte_first_rseed.Text = (from DataGridViewRow row in dgv__first_rseed.Rows
                                            where row.Cells[3].FormattedValue.ToString() != string.Empty
                                            select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
                refresh();
            }
        }
    }
}
