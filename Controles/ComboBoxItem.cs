using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public ComboBoxItem(string text, object entity)
        {
            Text = text;
            Value = entity;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
