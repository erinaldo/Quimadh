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
    
    public partial class Determinante
    {
        public Determinante()
        {
            this.DatosRutina = new HashSet<DatosRutina>();
            this.DeterminantesPlanta = new HashSet<DeterminantesPlanta>();
        }
    
        public long id { get; set; }
        public string nombre { get; set; }
        public string unidad { get; set; }
        public Nullable<short> grupo { get; set; }
    
        public virtual ICollection<DatosRutina> DatosRutina { get; set; }
        public virtual ICollection<DeterminantesPlanta> DeterminantesPlanta { get; set; }
    }
}
