﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuimadhEntities : DbContext
    {
        public QuimadhEntities()
            : base("name=QuimadhEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CabeceraRutina> CabeceraRutina { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Comprobante> Comprobante { get; set; }
        public virtual DbSet<DatosRutina> DatosRutina { get; set; }
        public virtual DbSet<Determinante> Determinante { get; set; }
        public virtual DbSet<DeterminantesPlanta> DeterminantesPlanta { get; set; }
        public virtual DbSet<Formulario> Formulario { get; set; }
        public virtual DbSet<FormularioUsuario> FormularioUsuario { get; set; }
        public virtual DbSet<Localidad> Localidad { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Moneda> Moneda { get; set; }
        public virtual DbSet<Muestra> Muestra { get; set; }
        public virtual DbSet<MuestraPlanta> MuestraPlanta { get; set; }
        public virtual DbSet<Parametros> Parametros { get; set; }
        public virtual DbSet<ParametroSistema> ParametroSistema { get; set; }
        public virtual DbSet<Planta> Planta { get; set; }
        public virtual DbSet<SituacionFrenteIva> SituacionFrenteIva { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }
        public virtual DbSet<Unidad> Unidad { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<ItemRecibo> ItemRecibo { get; set; }
        public virtual DbSet<CabeceraRutinaFirmantes> CabeceraRutinaFirmantes { get; set; }
        public virtual DbSet<Rel_Pv_Comprobante> Rel_Pv_Comprobante { get; set; }
        public virtual DbSet<EstadoComprobante> EstadoComprobante { get; set; }
        public virtual DbSet<Presentacion> Presentacion { get; set; }
        public virtual DbSet<Lote> Lote { get; set; }
        public virtual DbSet<ItemNota> ItemNota { get; set; }
        public virtual DbSet<VentaArticuloPlanta> VentaArticuloPlanta { get; set; }
        public virtual DbSet<TipoArticulo> TipoArticulo { get; set; }
        public virtual DbSet<ComposicionArticulos> ComposicionArticulos { get; set; }
        public virtual DbSet<Entrada> Entrada { get; set; }
        public virtual DbSet<Salida> Salida { get; set; }
        public virtual DbSet<ArticuloPlanta> ArticuloPlanta { get; set; }
        public virtual DbSet<ArticuloPlantaHistorico> ArticuloPlantaHistorico { get; set; }
        public virtual DbSet<PreciosAdicionales> PreciosAdicionales { get; set; }
        public virtual DbSet<Archivos> Archivos { get; set; }
        public virtual DbSet<MailFactura> MailFactura { get; set; }
        public virtual DbSet<TipoTarjeta> TipoTarjeta { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<MarcaTarjeta> MarcaTarjeta { get; set; }
        public virtual DbSet<Saldos> Saldos { get; set; }
        public virtual DbSet<ComprobanteProveedor> ComprobanteProveedor { get; set; }
        public virtual DbSet<OrdenPagoProveedor> OrdenPagoProveedor { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<InstrumentoPago> InstrumentoPago { get; set; }
    }
}
