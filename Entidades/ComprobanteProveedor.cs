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
    
    public partial class ComprobanteProveedor
    {
        public ComprobanteProveedor()
        {
            this.OrdenPagoProveedor = new HashSet<OrdenPagoProveedor>();
        }
    
        public long Id { get; set; }
        public short PtoVta { get; set; }
        public int Numero { get; set; }
        public System.DateTime FechaComprobante { get; set; }
        public decimal Importe { get; set; }
        public decimal Retencion { get; set; }
        public string Tipo { get; set; }
    
        public virtual ICollection<OrdenPagoProveedor> OrdenPagoProveedor { get; set; }
    }
}