using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Security.Cryptography;

namespace Comun.Base
{
    /// <summary>
    /// Esta clase contendrá métodos útiles y genéricos utilizados por varias clases
    /// </summary>
    public class Utiles
    {        

        /// <summary>
        /// Capitaliza (modifica la primer letra a Mayúscula y el resto a Minúscula en cada palabra de la frase)
        /// la frase pasada como argumento
        /// Ejemplo: "MI nombre ES PEDRO"
        /// Retorno: "Mi Nombre Es Pedro"
        /// </summary>
        /// <param name="fraseACapitalizar">Frase a transformar</param>
        /// <returns>Frase transformada</returns>
        public static String capitalizarFrase(String fraseACapitalizar)
        {
            String fraseADevolver;
            //Algo para tener en cuenta es que una frase con todas las letras en mayúsculas, 
            //no se va a convertir a tipo título, antes de eso hay que convertirlo a minúscula 
            //(toLower) y luego ToTitleCase. Por las dudas, lo realizamos a continuación.
            fraseADevolver = fraseACapitalizar.ToLower(CultureInfo.InvariantCulture);
            //Llamamos al método nativo ToTitleCase
            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(fraseADevolver);
        }

        /// <summary>
        /// Obtiene el hash en base a la codificación SHA-2 (256 bits)
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>En base64, la cadena ingresada, según: http://hash.online-convert.com/es/generador-sha256 </returns>
        public static string obtenerHash(string cadena)
        {
            SHA256 sha = SHA256.Create();

            byte[] bytes = Encoding.UTF8.GetBytes(cadena);

            return Convert.ToBase64String(sha.ComputeHash(bytes)).Trim();
        }

        /// <summary>
        /// Coloca el foco en el TextBox pasado como argumento y selecciona el texto del mismo.
        /// </summary>
        /// <param name="txt"></param>
        //public static void ponerFocoYSeleccionar(TextBox txt)
        //{
        //    txt.Focus();
        //    txt.SelectionStart = 0;
        //    txt.SelectionLength = txt.Text.Length;
        //}

        /// <summary>
        /// Devuelve el primer día del mes actual.
        /// </summary>
        /// <returns></returns>
        public static DateTime obtenerPrimerDiaDelMes()
        {
            // obtenemos el mes actual
            int mes = DateTime.Now.Month;
            // obtenemos el año actual
            int anio = DateTime.Now.Year;

            return Convert.ToDateTime("01/" + mes + "/" + anio);
        } // fin del método obtenerPrimerDiaDelMes
    }
}
