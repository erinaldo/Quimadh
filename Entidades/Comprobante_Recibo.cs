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
    
    public partial class Comprobante_Recibo : Comprobante
    {
        public Comprobante_Recibo()
        {
            this.ItemRecibo = new HashSet<ItemRecibo>();
            this.InstrumentoPago = new HashSet<InstrumentoPago>();
            this.Comprobante_Factura = new HashSet<Comprobante_Factura>();
        }
    
        public string formaPago { get; set; }
        public long numero { get; set; }
        public Nullable<decimal> Retenciones { get; set; }
        public Nullable<decimal> TipoCambio { get; set; }
    
        public virtual ICollection<ItemRecibo> ItemRecibo { get; set; }
        public virtual ICollection<InstrumentoPago> InstrumentoPago { get; set; }
        public virtual ICollection<Comprobante_Factura> Comprobante_Factura { get; set; }
    }
}
