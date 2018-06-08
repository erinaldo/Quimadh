using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public static class Acciones
    {
        /// <summary>
        /// Estas serán las opciones a mostrar en el combobox de 
        /// estado de entidad.
        /// </summary>
        public enum Log
        {
            ALTA = 'A',
            BAJA = 'B',
            MODIFICACION = 'M',
            LOGIN = 'L',
            TODAS = 'T'
        };
    }
}
