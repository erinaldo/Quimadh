using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Frontend.Controles;
using Comun.Base;
using Entidades;

namespace Desktop.Vistas
{
    public static class Seguridad
    {
        /// <summary>
        /// Valida que el usuario tenga permisos para abrir el formulario cuyo nombre se
        /// pasa como parámetro. En caso de NO tener permisos, lanza una excepción de tipo
        /// ExcepcionSeguridad.
        /// </summary>
        /// <param name="nombreFormulario"></param>
        /// <param name="formulariosPermitidos"></param>
        public static void tienePermisos(string nombreFormulario, List<Formulario> formulariosPermitidos)
        {
            if (!string.IsNullOrEmpty(nombreFormulario) && formulariosPermitidos != null)
            {
                Formulario frm = formulariosPermitidos.Where(f => f.nombre.Equals(nombreFormulario)).FirstOrDefault();

                if (frm == null)
                    throw new Exception("Usuario sin permisos de acceso.");
            }
        }

        /// <summary>
        /// Valida que el usuario tenga permisos para acceder al formulario cuyo nombre
        /// se pasa como parámetro. En caso de NO tener permisos, devuelve false.
        /// </summary>
        /// <param name="nombreFormulario"></param>
        /// <param name="formulariosPermitidos"></param>
        /// <returns></returns>
        public static bool tienePermisosMenu(string nombreFormulario, List<Formulario> formulariosPermitidos)
        {
            if (!string.IsNullOrEmpty(nombreFormulario) && formulariosPermitidos != null)
            {
                Formulario frm = formulariosPermitidos.Where(f => f.nombre.Equals(nombreFormulario)).FirstOrDefault();

                return frm != null;
            }

            return true;
        }
    }
}
