using Base;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ModuloServicios
{
    public partial class Servicios
    {
        private QuimadhEntities _contexto = new QuimadhEntities();

        public DateTime obtenerFechaHora()
        {
            return DateTime.Now;
        }

        #region "Ingreso Usuario"

        public Usuario autenticarUsuario(string nombreUsuario, string sha2)
        {
            Usuario usuario = _contexto.Usuario.Include("FormularioUsuario").Where(u => u.nombreUsuario.Equals(nombreUsuario) && u.clave.Equals(sha2)).FirstOrDefault();

            if (usuario != null)
            {
                if (usuario.inactivo)
                {
                    GenerarLogMensaje("Ingreso con datos correctos y el usuario inhabilitado '" + nombreUsuario + "'", Acciones.Log.LOGIN, null);
                    throw new Exception("Usuario no habilitado. Solicitar el alta al Administrador.");
                }
                GenerarLog<Usuario>(usuario, Acciones.Log.LOGIN, null);
                return usuario;
            }
            else
            {
                GenerarLogMensaje("Ingreso fallido con el usuario '" + nombreUsuario + "'", Acciones.Log.LOGIN, null);
                return null;
            }
        }

        #endregion

        /// <summary>
        /// Crea un registro de Log donde se detallan los valores de
        /// la entidad, la acción que se realizó sobre ella y
        /// los datos de la sesión de usuario que realizó dicha acción.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entidad"></param>
        /// <param name="accion"></param>
        /// <param name="metadata"></param>
        private void GenerarLog<T>(T entidad, Acciones.Log accion, Metadata metadata)
        {
            //using (TransactionScope scope = new TransactionScope())
            //{
            Log entrada = new Log();
            //En caso de que el metadata ingresado sea null, le asignamos el id del administrador
            entrada.idUsuario = metadata != null ? metadata.idUsuario : 1;
            entrada.operacion = ((char)accion).ToString();
            entrada.detalle = ObtenerPropiedades<T>(entidad);
            entrada.idEntidad = Convert.ToInt64(ObtenerClave<T>(entidad));
            entrada.nombreEntidad = entidad.GetType().Name.IndexOf("_") == -1 ? entidad.GetType().Name : entidad.GetType().Name.Substring(0, entidad.GetType().Name.IndexOf("_"));
            entrada.fechahora = DateTime.Now;
            _contexto.Log.Add(entrada);
            _contexto.SaveChanges();

            //    scope.Complete();
            //}
        }

        /// <summary>
        /// Crea un registro de Log donde se registra un mensaje
        /// la acción que se realizó y los datos de la sesión de 
        /// usuario que realizó dicha acción.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entidad"></param>
        /// <param name="accion"></param>
        /// <param name="metadata"></param>
        private void GenerarLogMensaje(String mensaje, Acciones.Log accion, Metadata metadata)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Log entrada = new Log();
                //En caso de que el metadata ingresado sea null, le asignamos el id del administrador
                entrada.idUsuario = metadata != null ? metadata.idUsuario : 1;
                entrada.operacion = ((char)accion).ToString();
                entrada.detalle = mensaje;
                entrada.nombreEntidad = "Mensaje Personalizado";
                entrada.fechahora = DateTime.Now;
                _contexto.Log.Add(entrada);
                _contexto.SaveChanges();

                scope.Complete();
            }
        }

        /// <summary>
        /// Devuelve las propiedades de la entidad especificada
        /// listadas en una cadena. La cadena se forma como una
        /// secuencia de pares Propiedad=Valor separados por punto
        /// y coma. Por ejemplo:
        ///          Propiedad1=Valor1; Propiedad2=Valor2; ...
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <param name="entidad"></param>
        /// <returns></returns>
        private string ObtenerPropiedades<T>(T entidad)
        {
            List<string> detalle = new List<string>();

            PropertyInfo[] propiedades = typeof(T).GetProperties();

            foreach (PropertyInfo propiedad in propiedades)
            {
                //if (propiedad.GetCustomAttributes(typeof(EdmScalarPropertyAttribute), false).Length > 0)
                //{
                object valor = propiedad.GetValue(entidad, null);

                string par = propiedad.Name + "=";

                if (valor != null)
                    par += valor.ToString();
                else
                    par += "NULL";

                detalle.Add(par);
                //}
            }

            return string.Join("; ", detalle);
        }

        /// <summary>
        /// Devuelve el valor de la clave de la entidad especificada.
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <param name="entidad"></param>
        /// <returns></returns>
        private object ObtenerClave<T>(T entidad)
        {
            PropertyInfo[] propiedades = typeof(T).GetProperties();

            foreach (PropertyInfo propiedad in propiedades)
            {
                System.Object[] atributos = propiedad.GetCustomAttributes(true);

                foreach (object atributo in atributos)
                {
                    if (atributo is EdmScalarPropertyAttribute)
                    {
                        if ((atributo as EdmScalarPropertyAttribute).EntityKeyProperty == true)
                            return propiedad.GetValue(entidad, null);
                    }
                }
            }

            return null;
        }       
    }
}
