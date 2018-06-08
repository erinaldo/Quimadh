using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public partial class DecimalIndistinto
    {
        public decimal parse(string number)
        {
            decimal numberValue = -1;

            if (number.Contains(',') && number.Contains('.'))
                decimal.TryParse(number, out numberValue);
            else
            { 
                
            }

            return 0.0M;
        }
    }
}
