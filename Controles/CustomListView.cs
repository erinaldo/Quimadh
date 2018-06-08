using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class CustomListView : ListView
    {
        // Se utiliza para controlar el ordenamiento ascendente o descendente 
        // por columna del listView
        private int ordenColumna = -1;

        public CustomListView()
        {
            InitializeComponent();
        }

        public CustomListView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void CustomListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determina si la columna es la misma que la última columna clickeada
            if (e.Column != ordenColumna)
            {
                // Establece la columna de ordenamiento a la última columna
                ordenColumna = e.Column;
                // Establece el ordenamiento ascendente por defecto
                this.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determina cuál fue el último tipo de ordenamiento y lo invierte
                if (this.Sorting == SortOrder.Ascending)
                    this.Sorting = SortOrder.Descending;
                else
                    this.Sorting = SortOrder.Ascending;
            }

            // Llama al método de ordenamiento
            this.Sort();

            // Establece la propiedad de ordenamiento en base a la columna
            this.ListViewItemSorter = new ListViewItemComparer(e.Column, this.Sorting);
        }
    }
}
