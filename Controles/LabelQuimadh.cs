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
    public partial class LabelQuimadh : Label
    {
        public LabelQuimadh()
        {
            InitializeComponent();
        }

        public LabelQuimadh(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
