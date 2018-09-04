//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Planta
    {
        public Planta()
        {
            this.CabeceraRutina = new HashSet<CabeceraRutina>();
            this.Comprobante = new HashSet<Comprobante>();
            this.DeterminantesPlanta = new HashSet<DeterminantesPlanta>();
            this.MuestraPlanta = new HashSet<MuestraPlanta>();
            this.ArticuloPlanta = new HashSet<ArticuloPlanta>();
        }
    
        public long id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public Nullable<long> idCliente { get; set; }
        public string nombreContacto1 { get; set; }
        public string cargoContacto1 { get; set; }
        public string nombreContacto2 { get; set; }
        public string cargoContacto2 { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public Nullable<long> idLocalidad { get; set; }
        public string emailContac1 { get; set; }
        public string emailContac2 { get; set; }
    
        public virtual ICollection<CabeceraRutina> CabeceraRutina { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Comprobante> Comprobante { get; set; }
        public virtual ICollection<DeterminantesPlanta> DeterminantesPlanta { get; set; }
        public virtual ICollection<MuestraPlanta> MuestraPlanta { get; set; }
        public virtual Localidad Localidad { get; set; }
        public virtual ICollection<ArticuloPlanta> ArticuloPlanta { get; set; }
    }
}
