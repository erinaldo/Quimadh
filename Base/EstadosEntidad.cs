using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class EstadoEntidad
    {
        public int idEstado { get; set; }

        public string nombre { get; set; }

        
    }

    /// <summary>
    /// Estas serán las opciones a mostrar en el combobox de 
    /// estado de entidad.
    /// </summary>
    public enum EstadosEntidad
    {
        Activo = 0,
        Inactivo = 1,
        Todos = -1
    };
}
