using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication2.UI;

namespace WindowsFormsApplication2.PL
{
    public partial class frm_product_serials : Form
    {
        BL.cls_product_serials clsSerials = new BL.cls_product_serials();
        BL.cls_products clsProducts = new BL.cls_products();
        DataTable dt_products;
        int? preselectedProductId;

        public frm_product_serials(int? preselectedProductId = null)
        {
            this.preselectedProductId = preselectedProductId;
            InitializeComponent();
            ApplyModernTheme();
        }

        private void ApplyModernTheme()
        {
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = ModernTheme.NormalFont;
            if (label_product != null) ModernTheme.StyleLabel(label_product, LabelStyle.Normal);
            if (label_serial != null) ModernTheme.StyleLabel(label_serial, LabelStyle.Normal);
            if (label_notes != null) ModernTheme.StyleLabel(label_notes, LabelStyle.Normal);
            if (txt_serial != null) ModernTheme.StyleTextBox(txt_serial);
            if (txt_notes != null) ModernTheme.StyleTextBox(txt_notes);
            if (dataGridView1 != null) ModernTheme.StyleDataGridView(dataGridView1);
            if (groupBox1 != null) ModernTheme.StyleGroupBox(groupBox1);
            if (btn_add != null) ModernTheme.StyleButton(btn_add, ButtonStyle.Success);
            if (btn_edit != null) ModernTheme.StyleButton(btn_edit, ButtonStyle.Primary);
            if (btn_delete != null) ModernTheme.StyleButton(btn_delete, ButtonStyle.Danger);
        }

        private void frm_product_serials_Load(object sender, EventArgs e)
        {
            dt_products = clsProducts.get_all_products();
            combo_product.DataSource = dt_products;
            combo_product.DisplayMember = "اسم الصنف";
            combo_product.ValueMember = "id";

            if (preselectedProductId.HasValue && dt_products.Rows.Count > 0)
            {
                try
                {
                    combo_product.SelectedValue = preselectedProductId.Value;
                }
                catch { combo_product.SelectedIndex = 0; }
            }
            else if (combo_product.Items.Count > 0)
            {
                combo_product.SelectedIndex = 0;
            }

            LoadSerials();
        }

        private void combo_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSerials();
        }

        private int? GetSelectedProductId()
        {
            var sv = combo_product.SelectedValue;
            if (sv == null || sv == DBNull.Value) return null;
            if (sv is DataRowView drv)
            {
                var v = drv["id"];
                return (v != null && v != DBNull.Value) ? Convert.ToInt32(v) : (int?)null;
            }
            try { return Convert.ToInt32(sv); } catch { return null; }
        }

        private void LoadSerials()
        {
            int? productId = GetSelectedProductId();
            if (!productId.HasValue)
            {
                dataGridView1.DataSource = null;
                return;
            }
            var dt = clsSerials.GetSerialsByProduct(productId.Value);
            dataGridView1.DataSource = dt;
            if (dataGridView1.Columns.Count > 1 && dataGridView1.Columns.Contains("product_id"))
                dataGridView1.Columns["product_id"].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int? productId = GetSelectedProductId();
            if (!productId.HasValue)
            {
                MessageBox.Show("يرجى اختيار صنف أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_serial.Text))
            {
                MessageBox.Show("يرجى إدخال السيريال", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_serial.Focus();
                return;
            }
            clsSerials.AddProductSerial(productId.Value, txt_serial.Text.Trim(), txt_notes.Text.Trim());
            MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_serial.Clear();
            txt_notes.Clear();
            txt_serial.Focus();
            LoadSerials();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("يرجى اختيار سيريال للتعديل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            string serial = dataGridView1.CurrentRow.Cells["serial"].Value?.ToString() ?? "";
            string notes = dataGridView1.CurrentRow.Cells["notes"].Value?.ToString() ?? "";

            using (var frm = new Form())
            {
                frm.Text = "تعديل السيريال";
                frm.Size = new Size(400, 180);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.FormBorderStyle = FormBorderStyle.FixedDialog;
                frm.RightToLeft = RightToLeft.Yes;
                frm.RightToLeftLayout = true;

                var lblSerial = new Label { Text = "السيريال:", Location = new Point(320, 25), AutoSize = true };
                var txtSerial = new TextBox { Text = serial, Location = new Point(20, 22), Size = new Size(290, 25) };
                var lblNotes = new Label { Text = "ملاحظات:", Location = new Point(320, 60), AutoSize = true };
                var txtNotes = new TextBox { Text = notes, Location = new Point(20, 57), Size = new Size(290, 25) };
                var btnOk = new Button { Text = "حفظ", DialogResult = DialogResult.OK, Location = new Point(220, 95), Size = new Size(90, 30) };
                var btnCancel = new Button { Text = "إلغاء", DialogResult = DialogResult.Cancel, Location = new Point(120, 95), Size = new Size(90, 30) };

                frm.Controls.AddRange(new Control[] { lblSerial, txtSerial, lblNotes, txtNotes, btnOk, btnCancel });
                frm.AcceptButton = btnOk;
                frm.CancelButton = btnCancel;

                if (frm.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(txtSerial.Text))
                {
                    clsSerials.UpdateProductSerial(id, txtSerial.Text.Trim(), txtNotes.Text.Trim());
                    MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSerials();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btn_edit_Click(sender, e);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("يرجى اختيار سيريال للحذف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("هل تريد حذف هذا السيريال؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            clsSerials.DeleteProductSerial(id);
            MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadSerials();
        }
    }
}
