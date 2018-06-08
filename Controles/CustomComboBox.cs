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
    public partial class CustomComboBox : ComboBox
    {
        public CustomComboBox()
        {
            InitializeComponent();
        }

        public CustomComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void CustomComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.DroppedDown = false;
        }
    }
}
