using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCameraControl
{
    class NumericComparer : IComparer
    {
        private int columnIndex;
        private ListSortDirection sortDirection;

        public NumericComparer(int columnIndex, ListSortDirection sortDirection)
        {
            this.columnIndex = columnIndex;
            this.sortDirection = sortDirection;
        }

        public int Compare(object x, object y)
        {
            var row1 = x as DataGridViewRow;
            var row2 = y as DataGridViewRow;

            double val1 = 0, val2 = 0;

            double.TryParse(row1?.Cells[columnIndex].Value?.ToString(), out val1);
            double.TryParse(row2?.Cells[columnIndex].Value?.ToString(), out val2);

            int result = val1.CompareTo(val2);
            return sortDirection == ListSortDirection.Ascending ? result : -result;
        }
    }
}
