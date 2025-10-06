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
    public partial class frm_corrupted_prd : Form
    {
        BL.cls_products prd = new BL.cls_products();
        DataTable dt_combobox=new DataTable();
        public frm_corrupted_prd()
        {
            InitializeComponent();
            dt_combobox = prd.get_all_products();
            txtnme.DataSource = dt_combobox;
            txtnme.DisplayMember = "اسم الصنف";
            txtnme.ValueMember = "id";
            dataGridView1.DataSource = prd.search_corrupted_prd("");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            frm_products_list frm = new frm_products_list();
            frm.ShowDialog();
            txtnme.SelectedValue = Convert.ToInt32(frm.dgvprdcts.CurrentRow.Cells[0].Value);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            prd.add_corrupted_product(Convert.ToInt32(txtnme.SelectedValue), Convert.ToInt32(txt_qte.Text), txt_reason.Text, dateTimePicker1.Text);
            prd.update_product_after_mrtg3_mshtriat(Convert.ToInt32(txtnme.SelectedValue), Convert.ToInt32(txt_qte.Text));
            dataGridView1.DataSource = prd.search_corrupted_prd("");
            txt_reason.Text = "";
            txt_qte.Text = "";
            txtnme.Text = "";
            MessageBox.Show("تمت الإضافة بنجاح ", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtnme.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            txt_qte.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_reason.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           // dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = prd.search_corrupted_prd(textBox1.Text);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            prd.edit_corrupted_prd(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),Convert.ToInt32(txtnme.SelectedValue), Convert.ToInt32(txt_qte.Text), txt_reason.Text, dateTimePicker1.Text);
            dataGridView1.DataSource = prd.search_corrupted_prd("");
            txt_reason.Text = "";
            txt_qte.Text = "";
            txtnme.Text = "";
            MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("عند الحذف سيتم استرجاع الكمية التالفة ","عملية الحذف",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
            {
                prd.delete_corrupted_prd(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                dataGridView1.DataSource = prd.search_corrupted_prd("");
                txt_reason.Text = "";
                txt_qte.Text = "";
                txtnme.Text = "";
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
