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
    
    public partial class TipoArticulo
    {
        public TipoArticulo()
        {
            this.Lote = new HashSet<Lote>();
            this.VentaArticuloPlanta = new HashSet<VentaArticuloPlanta>();
            this.ComposicionArticulos = new HashSet<ComposicionArticulos>();
            this.ComposicionArticulos1 = new HashSet<ComposicionArticulos>();
            this.ArticuloPlanta = new HashSet<ArticuloPlanta>();
        }
    
        public long id { get; set; }
        public string nombre { get; set; }
        public Nullable<int> idUnidad { get; set; }
        public Nullable<int> idUnidadStock { get; set; }
    
        public virtual ICollection<Lote> Lote { get; set; }
        public virtual Unidad Unidad { get; set; }
        public virtual Unidad Unidad1 { get; set; }
        public virtual ICollection<VentaArticuloPlanta> VentaArticuloPlanta { get; set; }
        public virtual ICollection<ComposicionArticulos> ComposicionArticulos { get; set; }
        public virtual ICollection<ComposicionArticulos> ComposicionArticulos1 { get; set; }
        public virtual ICollection<ArticuloPlanta> ArticuloPlanta { get; set; }
    }
}
