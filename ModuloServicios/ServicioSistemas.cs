using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ModuloServicios
{
    public partial class Servicios
    {

        public bool hacerBackup(string path)
        {
            try
            {
                //string nombreBackup = "Quimadh.bak";
                //string pathBackup = _contexto.Database.SqlQuery<String>("select filename from master.dbo.sysaltfiles where name = db_name()").First();

                //pathBackup = pathBackup.Replace(@"\\", @"\");
                //pathBackup = pathBackup.Replace("DATA\\Quimadh.mdf", @"BACKUP\");

                //pathBackup += nombreBackup;

                //File.Delete(pathBackup);

                //_contexto.Database.CommandTimeout = 0;
                //_contexto.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, @"BACKUP DATABASE [Quimadh] TO DISK = N'" + pathBackup + "' WITH NOFORMAT, NOINIT,  NAME = N'Quimadh-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10");

                //File.Copy(pathBackup, path + @"\" + DateTime.Now.ToShortDateString().Replace("/", "-") + " " + DateTime.Now.ToShortTimeString().Replace(":", "-") + " " + nombreBackup);
                //File.Copy(pathBackup, pathBackup.Replace("Quimadh", "Q-" + DateTime.Now.ToShortDateString().Replace("/", "-")) + "-" + DateTime.Now.Millisecond);

                Backup("Quimadh", path);
                Backup("FactElect", path);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return true;
        }

        private void Backup(string nombreBase, string path)
        {
            string nombreBackup = nombreBase + ".bak";
            string pathBackup = _contexto.Database.SqlQuery<String>("select filename from master.dbo.sysaltfiles where name = @nombreBase", new SqlParameter("@nombreBase", nombreBase)).First();

            pathBackup = pathBackup.Replace(@"\\", @"\");
            pathBackup = pathBackup.Replace("DATA\\"+ nombreBase +".mdf", @"BACKUP\");

            pathBackup += nombreBackup;

            File.Delete(pathBackup);

            _contexto.Database.CommandTimeout = 0;
            _contexto.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, @"BACKUP DATABASE ["+ nombreBase + "] TO DISK = N'" + pathBackup + "' WITH NOFORMAT, NOINIT,  NAME = N'"+ nombreBase +"-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10");

            File.Copy(pathBackup, path + @"\" + DateTime.Now.ToShortDateString().Replace("/", "-") + " " + DateTime.Now.ToShortTimeString().Replace(":", "-") + " " + nombreBackup);
            File.Copy(pathBackup, pathBackup.Replace(nombreBase, nombreBase.Substring(0,1)+ "-" + DateTime.Now.ToShortDateString().Replace("/", "-")) + "-" + DateTime.Now.Millisecond);
        }

        #region "ParametroSistema"

        public List<ParametroSistema> obtenerTodosParametrosSistema()
        {
            return _contexto.ParametroSistema.OrderBy(p => p.nombre).ToList();
        }

        public ParametroSistema obtenerParametroSistemaPorNombre(string nombre)
        {
            return _contexto.ParametroSistema.Where(p => p.nombre.ToUpper().Equals(nombre.ToUpper())).FirstOrDefault();
        }

        public List<ParametroSistema> modificarParametrosSistema(List<ParametroSistema> parametros, Metadata metadata)
        {

            using (TransactionScope scope = new TransactionScope())
            {
                ParametroSistema paramAux;

                foreach (ParametroSistema parametro in parametros)
                {
                    paramAux = _contexto.ParametroSistema.Where(p => p.id == parametro.id).FirstOrDefault();

                    if (paramAux != null)
                    {
                        paramAux.nombre = parametro.nombre;
                        paramAux.tipoDato = parametro.tipoDato;

                        if (!paramAux.valor.Equals(parametro.valor))
                        {
                            paramAux.valor = parametro.valor;
                            GenerarLog<ParametroSistema>(paramAux, Base.Acciones.Log.MODIFICACION, metadata);
                        }
                    }

                }

                _contexto.SaveChanges();

                scope.Complete();
            }

            return _contexto.ParametroSistema.OrderBy(p => p.nombre).ToList();
        }

        #endregion
    }
}
