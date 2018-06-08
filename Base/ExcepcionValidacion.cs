using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class ExcepcionValidacion : Exception
    {
        public ExcepcionValidacion(string mensaje)
            : base(mensaje)
        { }
    }
}
