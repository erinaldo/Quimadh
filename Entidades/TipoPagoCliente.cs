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
    
    public partial class TipoPagoCliente
    {
        public TipoPagoCliente()
        {
            this.Comprobante_Comprobante_Recibo = new HashSet<Comprobante_Recibo>();
        }
    
        public byte Id { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<Comprobante_Recibo> Comprobante_Comprobante_Recibo { get; set; }
    }
}
