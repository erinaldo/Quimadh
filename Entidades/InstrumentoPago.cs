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
    
    public partial class InstrumentoPago
    {
        public long Id { get; set; }
        public long IdRecibo { get; set; }
        public decimal Importe { get; set; }
        public bool Efectivo { get; set; }
    
        public virtual Comprobante_Recibo Comprobante_Comprobante_Recibo { get; set; }
    }
}
