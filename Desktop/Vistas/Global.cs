using Entidades;
using ModuloServicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Vistas
{
    /// <summary>
    /// Esta clase contiene variables comunes a todos los formularios
    /// de la aplicación.
    /// </summary>
    public class Global
    {
        private static Servicios servicio;
        private static Metadata datosSesion;
        private static List<Formulario> formularios;

        // Instancia de Servicio
        public static Servicios Servicio
        {
            get
            {
                if (servicio == null)
                    servicio = new Servicios();

                return servicio;
            }
        }

        public static Metadata DatosSesion
        {
            get
            {             
                return datosSesion;
            }
            set
            {
                datosSesion = value;
            }
        }

        public static List<Formulario> Formularios
        {
            get
            {
                return formularios;
            }
            set
            {
                formularios = value;
            }
        }
    }
}
