using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    /// <summary>
    /// Implementa el ordenamiento manual por columna en un control
    /// de tipo ListView.
    /// </summary>
    public class ListViewItemComparer : IComparer
    {
        private int columna;
        private SortOrder orden;

        public ListViewItemComparer()
        {
            columna = 0;
            orden = SortOrder.Ascending;
        }

        public ListViewItemComparer(int column, SortOrder order)
        {
            columna = column;
            this.orden = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal = -1;

            returnVal = String.Compare(((ListViewItem)x).SubItems[columna].Text, ((ListViewItem)y).SubItems[columna].Text);

            // Si el ordenamiento es descendente
            if (orden == SortOrder.Descending)
                returnVal *= -1; // Invierte el valor retornado por string.compare

            return returnVal;
        }
    }
}
