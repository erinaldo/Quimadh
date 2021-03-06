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
    
    public partial class Comprobante
    {
        public Comprobante()
        {
            this.Comprobante_DevolucionAnul = new HashSet<Comprobante_Devolucion>();
            this.Comprobante_RecargoAnul = new HashSet<Comprobante_Recargo>();
            this.VentaArticuloPlanta = new HashSet<VentaArticuloPlanta>();
        }
    
        public long id { get; set; }
        public decimal importe { get; set; }
        public System.DateTime fechaIngreso { get; set; }
        public bool debe { get; set; }
        public long idPlanta { get; set; }
        public decimal subtotal { get; set; }
        public decimal totalIva { get; set; }
        public Nullable<bool> anulado { get; set; }
        public int estadoCarga { get; set; }
        public bool CE_MiPyme { get; set; }
    
        public virtual Planta Planta { get; set; }
        public virtual EstadoComprobante EstadoComprobante { get; set; }
        public virtual ICollection<Comprobante_Devolucion> Comprobante_DevolucionAnul { get; set; }
        public virtual ICollection<Comprobante_Recargo> Comprobante_RecargoAnul { get; set; }
        public virtual ICollection<VentaArticuloPlanta> VentaArticuloPlanta { get; set; }
    }
}
