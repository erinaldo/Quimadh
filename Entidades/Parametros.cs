//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parametros
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public string cuit { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string ingresosBrutos { get; set; }
        public Nullable<System.DateTime> inicioActividades { get; set; }
        public string email { get; set; }
        public string sitioWeb { get; set; }
        public Nullable<int> version { get; set; }
        public int idSituacionFrenteIva { get; set; }
    
        public virtual SituacionFrenteIva SituacionFrenteIva { get; set; }
    }
}
