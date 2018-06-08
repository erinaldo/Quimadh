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
    
    public partial class CabeceraRutina
    {
        public CabeceraRutina()
        {
            this.DatosRutina = new HashSet<DatosRutina>();
        }
    
        public long id { get; set; }
        public Nullable<long> idPlanta { get; set; }
        public Nullable<System.DateTime> fechaMuestreo { get; set; }
        public Nullable<System.DateTime> fechaAnalisis { get; set; }
        public string observaciones { get; set; }
        public string tipoRutina { get; set; }
        public int idCabeceraRutinaFirmante { get; set; }
    
        public virtual Planta Planta { get; set; }
        public virtual ICollection<DatosRutina> DatosRutina { get; set; }
        public virtual CabeceraRutinaFirmantes CabeceraRutinaFirmantes { get; set; }
    }
}
