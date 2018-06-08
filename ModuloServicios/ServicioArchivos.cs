using Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using System.IO.Compression;

namespace ModuloServicios
{
    public partial class Servicios
    {
        //public Byte[] recuperarArchivo(long idRutina)
        //{
        //    return _contexto.Archivos.Where(a => a.idRutina == idRutina).Select(a => a.archivo).FirstOrDefault();
        //}

        public bool existeArchivo(long idRutina)
        {
            return _contexto.Archivos.Where(a => a.idRutina == idRutina).Any();
        }

        public bool almacenarArchivo(long idRutina, byte[] archivo, string extension = ".doc")
        {
            try
            {
                Archivos file = _contexto.Archivos.Where(a => a.idRutina == idRutina).FirstOrDefault();

                //Nuevo archivo lo inicializo
                if (file == null)
                {
                    file = new Archivos();
                    file.extension = extension;
                    file.idRutina = idRutina;
                    _contexto.Archivos.Add(file);
                }
                //file.archivo = archivo;
                
                _contexto.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("El archvio \"{0}\" no ha podido ser almacenado. El mismo ha quedado almacenado localmente en C:\\Quimadh\\Reportes. Detalles del error: {1}", idRutina + extension, ex.Message));
            }

        }

        /// <summary>
        /// Verifica si hay algún archivo local en la PC para almacenarlo en el servidor
        /// </summary>
        public void corroboraArchivosLocales()
        { 
            Regex esRutina = new Regex("\\d+\\.doc");
            string archivosEncontrados = Environment.NewLine;
            foreach(string archivo in Directory.EnumerateFiles(@"C:\Quimadh\Reportes"))
            {
                if (esRutina.Match(archivo).Success && !archivo.Contains("~$"))
                { 
                    archivosEncontrados = archivosEncontrados + archivo + Environment.NewLine;
                }
            }
            if (archivosEncontrados != Environment.NewLine)
                throw new Exception("Se han encontrado rutinas sin almacenar en el servidor. Detalles: " + archivosEncontrados + " ¿Desea almacenarlas ahora?");
        }

        public int almacenaArchivosLocales()
        {
            int contador = 0;
            Regex esRutina = new Regex("\\d+\\.doc");
            long idRutina;
            string bkp = @"C:\Quimadh\Reportes\" + DateTime.Now.ToString("MMMM yyyy", CultureInfo.CurrentCulture).Replace(" ", " de ");
            string bkpName = DateTime.Now.ToString("dd-MM-yyyy hh.mm.ss", CultureInfo.CurrentCulture);
            string archivosEncontrados = Environment.NewLine;
            foreach (string archivo in Directory.EnumerateFiles(@"C:\Quimadh\Reportes"))
            {
                if (esRutina.Match(archivo).Success && !archivo.Contains("~$"))
                {
                    idRutina = long.Parse(archivo.Replace(".doc", "").Replace(@"C:\Quimadh\Reportes\", ""));
                    
                    //string directorio = archivo.Replace(".doc", "");
                    //string archivoZip = directorio + ".zip";
                    //if (!Directory.Exists(directorio))
                    //    Directory.CreateDirectory(directorio);

                    //File.Copy(archivo, String.Format(@"{0}\{1}.doc", directorio, idRutina));

                    //ZipFile.CreateFromDirectory(directorio, archivoZip);

                    almacenarArchivo(idRutina, File.ReadAllBytes(archivo));

                    //almacenarArchivo(idRutina, File.ReadAllBytes(archivoZip),".zip");

                    if (!Directory.Exists(bkp))
                    {
                        Directory.CreateDirectory(bkp);
                    }                    

                    File.Copy(archivo, String.Format(@"{0}\{1} {2}.bkp.doc", bkp, idRutina, bkpName));

                    //--------pasa a carpeta compartida
                    ParametroSistema paramCarpeta = obtenerParametroSistemaPorNombre("CarpetaReportes");

                    if (File.Exists(String.Format(@"{0}\{1}.doc", paramCarpeta.valor, idRutina)))
                    {
                        File.Delete(String.Format(@"{0}\{1}.doc", paramCarpeta.valor, idRutina));
                    }
                    File.Copy(archivo, String.Format(@"{0}\{1}.doc", paramCarpeta.valor, idRutina));
                    //--------
                    File.Delete(archivo);

                    contador++;
                }
            }
            return contador;
        }

    }
}
