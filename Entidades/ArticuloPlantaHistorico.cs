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
    
    public partial class ArticuloPlantaHistorico
    {
        public long id { get; set; }
        public long idArticulo { get; set; }
        public long idPlanta { get; set; }
        public int idMoneda { get; set; }
        public decimal precio { get; set; }
        public System.DateTime fechaCambio { get; set; }
    
        public virtual ArticuloPlanta ArticuloPlanta { get; set; }
    }
}
