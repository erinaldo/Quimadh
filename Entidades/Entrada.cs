//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entrada
    {
        public long id { get; set; }
        public int idPresentacion { get; set; }
        public string nroLote { get; set; }
        public decimal cantidad { get; set; }
        public string concepto { get; set; }
        public System.DateTime fecha { get; set; }
    
        public virtual Lote Lote { get; set; }
        public virtual Presentacion Presentacion { get; set; }
    }
}
