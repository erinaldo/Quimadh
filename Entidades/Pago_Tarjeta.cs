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
    
    public partial class Pago_Tarjeta : InstrumentoPago
    {
        public byte IdTipoTarjeta { get; set; }
    
        public virtual TipoTarjeta TipoTarjeta { get; set; }
    }
}
