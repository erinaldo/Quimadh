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
    
    public partial class Pago_Cheque : InstrumentoPago
    {
        public int Numero { get; set; }
        public short IdBanco { get; set; }
        public decimal CuitLibrador { get; set; }
        public string NombreLibrador { get; set; }
        public System.DateTime FechaVto { get; set; }
        public bool Propio { get; set; }
        public bool Electronico { get; set; }
    
        public virtual Banco Banco { get; set; }
    }
}
