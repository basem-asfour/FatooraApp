using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.BL
{
    class RowComparer : System.Collections.IComparer
    {
        private static int sortOrderModifier = 1;

        public RowComparer(SortOrder sortOrder)
        {
            if (sortOrder == SortOrder.Descending)
            {
                sortOrderModifier = -1;
            }
            else if (sortOrder == SortOrder.Ascending)
            {
                sortOrderModifier = 1;
            }
        }

        public int Compare(object x, object y)
        {
            DataGridViewRow DataGridViewRow1 = (DataGridViewRow)x;
            DataGridViewRow DataGridViewRow2 = (DataGridViewRow)y;

            // Try to sort based on the Last Name column.
            int CompareResult = System.DateTime.Compare(
                   Convert.ToDateTime(DataGridViewRow1.Cells[2].Value),
                   Convert.ToDateTime(DataGridViewRow2.Cells[2].Value));

            // If the Last Names are equal, sort based on the First Name.
            if (CompareResult == 0)
            {
                CompareResult = System.DateTime.Compare(
                   Convert.ToDateTime( DataGridViewRow1.Cells[2].Value),
                   Convert.ToDateTime( DataGridViewRow2.Cells[2].Value));
            }
            return CompareResult * sortOrderModifier;
        }
    }
}
