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
    
    public partial class ComposicionArticulos
    {
        public long id { get; set; }
        public long idArticuloPadre { get; set; }
        public long idArticuloHijo { get; set; }
        public decimal cantComposicion { get; set; }
        public decimal factorConversion { get; set; }
    
        public virtual TipoArticulo TipoArticulo { get; set; }
        public virtual TipoArticulo TipoArticulo1 { get; set; }
    }
}
