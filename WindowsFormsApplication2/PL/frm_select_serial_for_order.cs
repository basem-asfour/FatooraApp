using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication2.BL;

namespace WindowsFormsApplication2.PL
{
    public partial class frm_select_serial_for_order : Form
    {
        private readonly int _productId;
        private readonly int _requiredQte;
        private readonly List<string> _excludeSerials;
        private readonly cls_product_serials _clsSerials = new cls_product_serials();

        /// <summary>
        /// Comma-separated serials selected by user. Null if cancelled.
        /// </summary>
        public string SelectedSerialsCommaSeparated { get; private set; }

        public frm_select_serial_for_order(int productId, int requiredQte, List<string> excludeSerialsInCurrentOrder = null)
        {
            _productId = productId;
            _requiredQte = requiredQte;
            _excludeSerials = excludeSerialsInCurrentOrder ?? new List<string>();
            InitializeComponent();
        }

        private void frm_select_serial_for_order_Load(object sender, EventArgs e)
        {
            lbl_info.Text = string.Format("اختر السيريالات المطلوبة (الكمية المطلوبة: {0})", _requiredQte);

            DataTable dt = _clsSerials.GetAvailableSerialsForProduct(_productId);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد سيريالات متاحة لهذا الصنف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            var excludeSet = new HashSet<string>(_excludeSerials.Select(s => s.Trim()), StringComparer.OrdinalIgnoreCase);
            var rowsToRemove = new List<DataRow>();
            foreach (DataRow row in dt.Rows)
            {
                var serial = row["serial"]?.ToString()?.Trim();
                if (!string.IsNullOrEmpty(serial) && excludeSet.Contains(serial))
                    rowsToRemove.Add(row);
            }
            foreach (var r in rowsToRemove)
                dt.Rows.Remove(r);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد سيريالات متاحة (جميع السيريالات مستخدمة في الفاتورة الحالية)", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            if (dt.Rows.Count < _requiredQte)
            {
                MessageBox.Show(string.Format("السيريالات المتاحة ({0}) أقل من الكمية المطلوبة ({1}). يرجى تقليل الكمية أو إضافة سيريالات جديدة للصنف.", dt.Rows.Count, _requiredQte),
                    "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dgv_serials.DataSource = dt;
            if (dgv_serials.Columns.Contains("id"))
                dgv_serials.Columns["id"].Visible = false;
            if (dgv_serials.Columns.Contains("product_id"))
                dgv_serials.Columns["product_id"].Visible = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            var selected = new List<string>();
            foreach (DataGridViewRow row in dgv_serials.SelectedRows)
            {
                if (row.Cells["serial"]?.Value != null)
                {
                    var s = row.Cells["serial"].Value.ToString().Trim();
                    if (!string.IsNullOrEmpty(s) && !selected.Contains(s))
                        selected.Add(s);
                }
            }

            if (selected.Count != _requiredQte)
            {
                MessageBox.Show(string.Format("يجب اختيار {0} سيريال بالضبط. تم اختيار {1}.", _requiredQte, selected.Count),
                    "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SelectedSerialsCommaSeparated = string.Join(",", selected);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            SelectedSerialsCommaSeparated = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
