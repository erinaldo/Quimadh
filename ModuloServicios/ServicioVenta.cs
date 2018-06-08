﻿using Base;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Transactions;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Diagnostics;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ModuloServicios
{
    public partial class Servicios
    {
        #region Factura

        public Comprobante_Factura buscarFactura(long numComp, string tipo, int pv)
        {
            //_contexto.Configuration.LazyLoadingEnabled = false;
            IQueryable<Comprobante_Factura> queryF;

            queryF = _contexto.Comprobante.OfType<Comprobante_Factura>();
            if (pv != 0)
                queryF = queryF.Where(c => c.pv == pv);
            if (tipo != "")
                queryF = queryF.Where(c => c.tipo == tipo);
            if (numComp != 0)
                queryF = queryF.Where(c => c.numero == numComp);

            return queryF.FirstOrDefault();
        }

        public List<Comprobante> buscarComprobantes(string codPlanta, string nomPlanta, long numComp, string tipo, int pv, string nomCliente, int numeroRegistros)
        {
            //_contexto.Configuration.LazyLoadingEnabled = false;
            IQueryable<Comprobante> query;
            IQueryable<Comprobante_Factura> queryF;
            IQueryable<Comprobante_Remito> queryRem;
            IQueryable<Comprobante_Recibo> queryRec;
            IQueryable<Comprobante_Devolucion> queryNc;
            IQueryable<Comprobante_Recargo> queryNd;
            switch (tipo)            
            {
                case "factura":
                    queryF = _contexto.Comprobante.OfType<Comprobante_Factura>();
                    if (pv != 0)
                        queryF = queryF.Where(c => c.pv == pv);
                    if (numComp != 0)
                        queryF = queryF.Where(c => c.numero == numComp);
                    if (codPlanta != "")
                        queryF = queryF.Where(c => c.Planta.codigo.Contains(codPlanta));
                    if (nomPlanta != "")
                        queryF = queryF.Where(c => c.Planta.nombre.Contains(nomPlanta));
                    if (nomCliente != "")
                        queryF = queryF.Where(c => c.Planta.Cliente.razonSocial.Contains(nomCliente));
                    query = queryF;
                    break;
                case "remito":
                    queryRem = _contexto.Comprobante.OfType<Comprobante_Remito>();
                    if (numComp != 0)
                        queryRem = queryRem.Where(c => c.numero == numComp);
                    if (codPlanta != "")
                        queryRem = queryRem.Where(c => c.Planta.codigo.Contains(codPlanta));
                    if (nomPlanta != "")
                        queryRem = queryRem.Where(c => c.Planta.nombre.Contains(nomPlanta));
                    if (nomCliente != "")
                        queryRem = queryRem.Where(c => c.Planta.Cliente.razonSocial.Contains(nomCliente));
                    query = queryRem;
                    break;
                case "recibo":
                    queryRec = _contexto.Comprobante.OfType<Comprobante_Recibo>();
                    if (numComp != 0)
                        queryRec = queryRec.Where(c => c.numero == numComp);
                    if (codPlanta != "")
                        queryRec = queryRec.Where(c => c.Planta.codigo.Contains(codPlanta));
                    if (nomPlanta != "")
                        queryRec = queryRec.Where(c => c.Planta.nombre.Contains(nomPlanta));
                    if (nomCliente != "")
                        queryRec = queryRec.Where(c => c.Planta.Cliente.razonSocial.Contains(nomCliente));
                    query = queryRec;
                    break;
                case "notaCredito":
                    queryNc = _contexto.Comprobante.OfType<Comprobante_Devolucion>();
                    if (pv != 0)
                        queryNc = queryNc.Where(c => c.pv == pv);
                    if (numComp != 0)
                        queryNc = queryNc.Where(c => c.numero == numComp);
                    if (codPlanta != "")
                        queryNc = queryNc.Where(c => c.Planta.codigo.Contains(codPlanta));
                    if (nomPlanta != "")
                        queryNc = queryNc.Where(c => c.Planta.nombre.Contains(nomPlanta));
                    if (nomCliente != "")
                        queryNc = queryNc.Where(c => c.Planta.Cliente.razonSocial.Contains(nomCliente));
                    query = queryNc;
                    break;
                default:
                    queryNd = _contexto.Comprobante.OfType<Comprobante_Recargo>();
                    if (pv != 0)
                        queryNd = queryNd.Where(c => c.pv == pv);
                    if (numComp != 0)
                        queryNd = queryNd.Where(c => c.numero == numComp);
                    if (codPlanta != "")
                        queryNd = queryNd.Where(c => c.Planta.codigo.Contains(codPlanta));
                    if (nomPlanta != "")
                        queryNd = queryNd.Where(c => c.Planta.nombre.Contains(nomPlanta));
                    if (nomCliente != "")
                        queryNd = queryNd.Where(c => c.Planta.Cliente.razonSocial.Contains(nomCliente));
                    query = queryNd;
                    break;
            }

            return query.OrderByDescending(c => c.id).Take(numeroRegistros).ToList();
        }

        public List<Comprobante_Factura> obtenerTodosComprobantesFact(int numeroRegistros)
        {
            return _contexto.Comprobante.OfType<Comprobante_Factura>().Take(numeroRegistros).ToList();
        }

        public void anularComprobante(Comprobante comprobante,Metadata metadata)
        {
            comprobante.anulado = true;    
            //si es remito hay que eliminar las salidas asociadas
            if (comprobante.GetType() == typeof(Comprobante_Remito))
            {
                foreach (VentaArticuloPlanta v in comprobante.VentaArticuloPlanta)
                {
                    _contexto.Salida.RemoveRange(v.Salida);
                }
            }

            _contexto.SaveChanges();
            GenerarLog<Comprobante>(comprobante, Acciones.Log.BAJA, metadata);
        }

        private void ValidarFactura(Comprobante_Factura factura, Acciones.Log accion = Acciones.Log.ALTA)
        {
            //int lonObs = factura.observacion.Length;
            int lonCondVta = factura.condVta.Length;
            string mensaje = "";

            if (lonCondVta == 0)
                mensaje = "Debe ingresar una condición de venta." + Environment.NewLine;

            if (factura.numero == 0)
                mensaje = "Ingrese un número de factura.";

            if (accion == Acciones.Log.ALTA)
            { 
                bool existe = (from f in _contexto.Comprobante.OfType<Comprobante_Factura>()
                               where f.numero.Equals(factura.numero) 
                               where f.tipo.Equals(factura.tipo)
                               where f.pv.Equals(factura.pv)
                               select f).Any();
            
                if (existe)
                    mensaje = "Ya existe el número de factura.";
            }

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);
        }

        public Comprobante_Factura agregarFactura(Comprobante_Factura factura, Metadata metadata)
        {
            Comprobante_Factura facturaGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarFactura(factura);
                foreach (Comprobante_Remito remito in factura.Comprobante_Remito)
                {
                    if (remito == null)
                        throw new ExcepcionValidacion("Algúno de los remitos cargados no existe");
                }

                //*************************LIMPIADOR DE ENTITY FRAMEWORK***********************************
                //var manager = ((IObjectContextAdapter)_contexto).ObjectContext;
                //var objectStateEntries = manager.ObjectStateManager.GetObjectStateEntries(EntityState.Added);

                //foreach (var objectStateEntry in objectStateEntries)
                //{
                //    if (objectStateEntry.Entity != null)
                //        manager.Detach(objectStateEntry.Entity);
                //}
                //*************************LIMPIADOR DE ENTITY FRAMEWORK***********************************

                facturaGuardada = (Comprobante_Factura)_contexto.Comprobante.Add(factura);                

                _contexto.SaveChanges();

                GenerarLog<Comprobante_Factura>(factura, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return facturaGuardada;
        }

        public Comprobante_Factura actualizarFactura(Comprobante_Factura factura, Metadata metadata, Boolean recargaItemsFactura=false)
        {
            Comprobante_Factura facturaGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarFactura(factura, Acciones.Log.MODIFICACION);
               
                if (recargaItemsFactura)
                {
                    IQueryable<VentaArticuloPlanta> ventas;
                    ventas = (IQueryable<VentaArticuloPlanta>)_contexto.VentaArticuloPlanta.Where(v => v.idComprobante == factura.id);
                    _contexto.VentaArticuloPlanta.RemoveRange(ventas);
                }                
                
                _contexto.SaveChanges();

                GenerarLog<Comprobante_Factura>(factura, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return facturaGuardada;
        }

        public long BuscarNroFactura(string tipo, int pv)
        {
            long numero=0;
            
            numero = _contexto.Comprobante.OfType<Comprobante_Factura>().Where(f => f.tipo == tipo).Where(f => f.pv == pv).Any() ? _contexto.Comprobante.OfType<Comprobante_Factura>().Where(f => f.tipo == tipo).Where(f => f.pv == pv).Max(f => f.numero) : 0;            
            return numero + 1;
        }

        public void imprimirFactura(Comprobante_Factura factura)
        {
            int x = -2; //VALORES NUEVOS
            int y = 21;
            String remitos = "";

            foreach (Comprobante_Remito rem in factura.Comprobante_Remito)
            {
                remitos += "/1-"+ rem.numero.ToString();                    
            }
            if (remitos != "")
                remitos = remitos.Substring(1,remitos.Length - 1);

            Font printFont = new Font("Arial", 10);
            Font printFontG = new Font("Arial", 10, FontStyle.Bold);
            SolidBrush printSolid = new SolidBrush(Color.Black);
            PrintDocument pd = new PrintDocument();
            string fecha = factura.fechaIngreso.Day.ToString("00") + "      " + factura.fechaIngreso.Month.ToString("00") + "     " + factura.fechaIngreso.Year.ToString();
            decimal precio;

            pd.PrintPage += delegate(object sender, PrintPageEventArgs e)
            {

                //Image imagen = Image.FromFile("C:/Users/marianoPC/Desktop/quimadh/Sistema/1 - Investigación Preliminar/Información del Cliente/Comprobantes/Factura1.jpg");
                //e.Graphics.DrawImage(imagen, 45, 45);
                //e.Graphics.DrawString(factura.numero.ToString("00000000"), printFontG, printSolid, new RectangleF(x + 606, y + 87, 500, 500));               
                
                e.Graphics.DrawString(fecha, printFont, printSolid, new Rectangle(x + 640, y + 136, 200, 200));
                e.Graphics.DrawString(factura.Planta.Cliente.razonSocial, printFont, printSolid, new Rectangle(x + 130, y + 225, 500, 500));
                e.Graphics.DrawString(factura.Planta.Cliente.direccion, printFont, printSolid, new Rectangle(x + 500, y + 225, 500, 500));
                e.Graphics.DrawString(factura.Planta.Cliente.Localidad.nombre, printFont, printSolid, new Rectangle(x + 500, y + 265, 500, 500));
                e.Graphics.DrawString(factura.Planta.Cliente.SituacionFrenteIva.nombre, printFont, printSolid, new Rectangle(x + 110, y + 297, 500, 500));
                if (remitos != "")
                    e.Graphics.DrawString("Rto: " + remitos + " / oc: " + factura.ordenCompra, printFont, printSolid, new Rectangle(x + 260, y + 287, 500, 500));
                e.Graphics.DrawString(factura.Planta.Cliente.cuit, printFont, printSolid, new Rectangle(x + 120, y + 317, 200, 200));
                e.Graphics.DrawString(factura.condVta, printFont, printSolid, new Rectangle(x + 197, y + 337, 200, 200));
                y += 390;
                foreach (VentaArticuloPlanta venta in factura.VentaArticuloPlanta)
                {
                    e.Graphics.DrawString(venta.cantidad.ToString(), printFont, printSolid, new Rectangle(x + 55, y, 500, 500));
                    e.Graphics.DrawString(venta.TipoArticulo.nombre + " " + venta.descripAdicional, printFont, printSolid, new Rectangle(x + 132, y, 500, 500));
                    if (factura.tipo == "A")
                    {
                        precio = ConviertePrecio(venta.precio, venta.Moneda, factura.Moneda);
                        e.Graphics.DrawString(precio.ToString("0.00"), printFont, printSolid, new Rectangle(x + 517, y, 500, 500));
                        e.Graphics.DrawString((venta.cantidad * precio).ToString("0.00"), printFont, printSolid, new Rectangle(x + 643, y, 500, 500));
                    }
                    else
                    {
                        precio = ConviertePrecio((venta.precio * ((venta.iva / 100) + 1)), venta.Moneda, factura.Moneda);
                        e.Graphics.DrawString(precio.ToString("0.00"), printFont, printSolid, new Rectangle(x + 517, y, 500, 500));
                        e.Graphics.DrawString((venta.cantidad * precio).ToString("0.00"), printFont, printSolid, new Rectangle(x + 643, y, 500, 500));
                    }
                    
                    y += 15;
                }
                y = 750;
                e.Graphics.DrawString(factura.observacion, printFont, printSolid, new Rectangle(x + 130, y, 650, 650));
                y = 815;
                decimal subtotal = factura.subtotal;
                decimal iva = factura.totalIva;
                decimal total = factura.importe;
                //if (factura.Planta.Cliente.SituacionFrenteIva.nombre == "Responsable Inscripto")
                if (factura.tipo == "A")
                {
                    e.Graphics.DrawString(factura.vencimiento.ToString("dd/MM/yyyy"), printFont, printSolid, new Rectangle(x + 235, y + 22, 500, 500));
                    e.Graphics.DrawString(subtotal.ToString("0.00"), printFont, printSolid, new Rectangle(x + 645, y + 19, 500, 500));
                    e.Graphics.DrawString("0.00", printFont, printSolid, new Rectangle(x + 645, y + 51, 500, 500));
                    e.Graphics.DrawString(subtotal.ToString("0.00"), printFont, printSolid, new Rectangle(x + 645, y + 83, 500, 500));
                    e.Graphics.DrawString(iva.ToString("0.00"), printFont, printSolid, new Rectangle(x + 645, y + 115, 500, 500));
                    e.Graphics.DrawString("0.00", printFont, printSolid, new Rectangle(x + 645, y + 147, 500, 500));
                }
                
                if (factura.Moneda.simbologia != "$")
                {
                    e.Graphics.DrawString(factura.Moneda.simbologia, printFontG, printSolid, new Rectangle(x + 635, y + 178, 500, 500));
                }
                e.Graphics.DrawString(total.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 662, y + 178, 500, 500));
               
            };
            // Print the document.
            ParametroSistema paramImpresora = obtenerParametroSistemaPorNombre("Impresora " + System.Environment.MachineName);
            pd.PrinterSettings.PrinterName = paramImpresora.valor; 

            pd.Print();
        }

        public void imprimirFacturaDigital(Comprobante_Factura factura)
        {
            string remitos = "";
            foreach (Comprobante_Remito rem in factura.Comprobante_Remito)
            {
                remitos += "/1-" + rem.numero.ToString();
            }
            if (remitos != "")
                remitos = remitos.Substring(1, remitos.Length - 1);

            int x;
            int y;

            Image imagen;
            if (factura.tipo=="A")
            {
                imagen = Image.FromFile("C:/Quimadh/Factura1.jpg");
                x = 525;
                y = -7;
            }
            else
            {
                imagen = Image.FromFile("C:/Quimadh/Factura2.jpg");
                x = 535;
                y = 10;
            }
                

            Bitmap bm = new Bitmap(imagen, imagen.Size);
            Graphics graf = Graphics.FromImage(bm);

            Font printFont = new Font("Arial", 20);
            Font printFontG = new Font("Arial", 20, FontStyle.Bold);
            SolidBrush printSolid = new SolidBrush(Color.Black);
            string fecha = factura.fechaIngreso.Day.ToString("00") + "      " + factura.fechaIngreso.Month.ToString("00") + "     " + factura.fechaIngreso.Year.ToString();
            decimal precio;
            
            graf.DrawString(factura.pv.ToString("0000") + " - " + factura.numero.ToString("00000000"), printFontG, printSolid, new RectangleF(x + 500, y + 105, 500, 500));

            graf.DrawString(fecha, printFont, printSolid, new Rectangle(x + 686, y + 192, 2000, 2000));
            graf.DrawString(factura.Planta.Cliente.razonSocial, printFont, printSolid, new Rectangle(x - 300 , y + 363, 500, 500));
            graf.DrawString(factura.Planta.Cliente.direccion, printFont, printSolid, new Rectangle(x + 440, y + 366, 500, 500));
            graf.DrawString(factura.Planta.Cliente.Localidad.nombre, printFont, printSolid, new Rectangle(x + 440, y + 450, 500, 500));
            graf.DrawString(factura.Planta.Cliente.SituacionFrenteIva.nombre, printFont, printSolid, new Rectangle(x - 320, y + 520, 500, 500));
            if (remitos != "")
                graf.DrawString("Rto: " + remitos + " / oc: " + factura.ordenCompra, printFont, printSolid, new Rectangle(x - 30, y + 500, 500, 500));
            graf.DrawString(factura.Planta.Cliente.cuit, printFont, printSolid, new Rectangle(x - 320, y + 550, 200, 200));
            graf.DrawString(factura.condVta, printFont, printSolid, new Rectangle(x - 225, y + 591, 200, 200));
            y += 695;
            foreach (VentaArticuloPlanta venta in factura.VentaArticuloPlanta)
            {
                graf.DrawString(venta.cantidad.ToString(), printFont, printSolid, new Rectangle(x - 480 , y, 500, 500));
                graf.DrawString(venta.TipoArticulo.nombre + " " + venta.descripAdicional, printFont, printSolid, new Rectangle(x - 250, y, 600, 600));
                if (factura.tipo == "A")
                {
                    precio = ConviertePrecio(venta.precio, venta.Moneda, factura.Moneda);
                    graf.DrawString(precio.ToString("0.00"), printFont, printSolid, new Rectangle(x + 480, y, 500, 500));
                    graf.DrawString((venta.cantidad * precio).ToString("0.00"), printFont, printSolid, new Rectangle(x + 700, y, 500, 500));
                }
                else
                {
                    precio = ConviertePrecio((venta.precio * ((venta.iva / 100) + 1)), venta.Moneda, factura.Moneda);
                    graf.DrawString(precio.ToString("0.00"), printFont, printSolid, new Rectangle(x + 490, y, 500, 500));
                    graf.DrawString((venta.cantidad * precio).ToString("0.00"), printFont, printSolid, new Rectangle(x + 700, y, 500, 500));
                }

                y += 30;
            }


            y = 1370;

            graf.DrawString(factura.observacion, printFont, printSolid, new Rectangle(x - 250, y, 1000, 1000));
            if (factura.tipo == "A")
            {
                y = 1535;
            }
            else
            {
                y = 1585;
            }
            decimal subtotal = factura.subtotal;
            decimal iva = factura.totalIva;
            decimal total = factura.importe;
           
            if (factura.tipo == "A")
            {
                graf.DrawString(factura.vencimiento.ToString("dd/MM/yyyy"), printFont, printSolid, new Rectangle(x - 100, y + 22, 500, 500));
                graf.DrawString(subtotal.ToString("0.00"), printFont, printSolid, new Rectangle(x + 728, y + 20, 500, 500));
                graf.DrawString("0.00", printFont, printSolid, new Rectangle(x + 728, y + 84, 500, 500));
                graf.DrawString(subtotal.ToString("0.00"), printFont, printSolid, new Rectangle(x + 728, y + 149, 500, 500));
                graf.DrawString(iva.ToString("0.00"), printFont, printSolid, new Rectangle(x + 728, y + 209, 500, 500));
                graf.DrawString("0.00", printFont, printSolid, new Rectangle(x + 728, y + 272, 500, 500));
            }

            //if (factura.Moneda.simbologia != "$")
            //{                
            //    graf.DrawString(factura.Moneda.simbologia, printFontG, printSolid, new Rectangle(x + 670, y + 334, 500, 500));
            //}

            graf.DrawString(factura.Moneda.simbologia + " " + total.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 720, y + 334, 500, 500));
            
            if (factura.pv == 3)
            {
                graf.DrawString("CAE: " + factura.cae, printFontG, printSolid, new Rectangle(x + 480, y + 430, 500, 500));
                graf.DrawString("VENC.: " + ((DateTime)factura.fecVtoCae).ToString("dd/MM/yyyy"), printFontG, printSolid, new Rectangle(x + 480, y + 465, 500, 500));
            }            

            ParametroSistema paramCarpeta = obtenerParametroSistemaPorNombre("CarpetaComprobantes");

            string directorio = paramCarpeta.valor + "/Facturas";
            if (!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);

            bm.Save(directorio + "/" + factura.pv.ToString() + "-" + factura.numero.ToString() + "-" + factura.tipo + ".png");
            
            graf.Dispose();

            if (factura.pv == 3)
            {
                ParametroSistema paramImpresora = obtenerParametroSistemaPorNombre("Impresora " + System.Environment.MachineName);
                //Process printjob = new Process();
                //printjob.StartInfo.FileName = directorio + "/" + factura.numero.ToString() + "-" + factura.tipo + ".png";
                //printjob.StartInfo.UseShellExecute = true;
                //printjob.StartInfo.CreateNoWindow = true;                
                //printjob.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                //printjob.StartInfo.Verb = "print";
                //printjob.Start();

                PrintDocument pd = new PrintDocument();
                pd.PrintPage += delegate(object sender, PrintPageEventArgs e)
                {
                    if (factura.tipo == "A")
                    {
                        bm.SetResolution(179, 183);
                    }
                    else
                    {
                        bm.SetResolution(183, 185);
                    }
                    e.Graphics.DrawImage(bm, 0, 0);
                };
                pd.PrinterSettings.PrinterName = paramImpresora.valor;
                pd.Print();
            }
        }

        public decimal ConviertePrecio(decimal importe, Moneda monedaVenta, Moneda monedaAConvertir)
        {
            //decimal dolar = Math.Round(obtenerCotizacionDolar(),2);
            decimal cotizOrigen = Math.Round(obtenerCotizacionMoneda(monedaVenta.id), 2);
            decimal cotizDestino = Math.Round(obtenerCotizacionMoneda(monedaAConvertir.id), 2);
            importe = Math.Round(importe, 2);

            //if (monedaAConvertir.id == 0)
            //{
            //    if (monedaVenta.id == 0)
            //        return importe;
            //    else
            //        return Math.Round(importe * dolar, 2);
            //}
            //else
            //{
            //    if (monedaVenta.id == 0)
            //        return Math.Round(importe / dolar, 2);
            //    else
            //        return importe;
            //}

            if (monedaAConvertir.id == monedaVenta.id)
            {
                //si la moneda de la venta es la misma que la del artículo no necesita convertir
                return importe;
            }
            else
            {
                if (monedaAConvertir.id == 0)
                {
                    //si la conversión es de moneda extranjera a pesos
                    return Math.Round(importe * cotizOrigen, 2);
                }
                if (monedaVenta.id == 0)
                {
                    //si la conversión es de pesos a moneda extranjera
                    return Math.Round(importe / cotizDestino, 2);
                }

                //si la conversión es entre monedas extranjeras
                decimal conversionPesos = Math.Round(importe * cotizOrigen, 2);
                decimal conversionME = Math.Round(conversionPesos / cotizDestino, 2);
                return conversionME;
            }

        }

        #endregion

        #region Remito

        public long BuscaNroRemito()
        {
            long numero;
            numero = _contexto.Comprobante.OfType<Comprobante_Remito>().Any() ? _contexto.Comprobante.OfType<Comprobante_Remito>().Max(r => r.numero) : 0;
            return numero + 1;
        }

        private void validarRemito(Comprobante_Remito remito, Acciones.Log accion = Acciones.Log.ALTA)
        {
            string mensaje = "";

            if (remito.tipo == "")
                mensaje = "Seleccione un tipo de remito";

            if (remito.numero == 0)
                mensaje = "Ingrese un número de remito";

            if (accion == Acciones.Log.ALTA)
            {
                bool existe = (from r in _contexto.Comprobante.OfType<Comprobante_Remito>()
                               where r.numero.Equals(remito.numero)
                               select r).Any();

                if (existe)
                    mensaje = "Ya existe el número de remito";
            }
                
            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);
        }

        public List<Comprobante_Remito> obtenerTodosComprobantesRem(int numeroRegistros)
        {
            return _contexto.Comprobante.OfType<Comprobante_Remito>().Take(numeroRegistros).ToList();
        }

        public Comprobante_Remito agregarRemito(Comprobante_Remito remito, Metadata metadata)
        {
            Comprobante_Remito remitoGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                validarRemito(remito);

                remitoGuardado = (Comprobante_Remito)_contexto.Comprobante.Add(remito);
                _contexto.SaveChanges();

                GenerarLog<Comprobante_Remito>(remito, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return remitoGuardado;
        }

        public Comprobante_Factura actualizarRemito(Comprobante_Remito remito, Metadata metadata)
        {
            Comprobante_Factura remitoGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                validarRemito(remito, Acciones.Log.MODIFICACION);

                IQueryable<VentaArticuloPlanta> ventas;
                ventas = (IQueryable<VentaArticuloPlanta>)_contexto.VentaArticuloPlanta.Where(v => v.idComprobante == remito.id);

                foreach (VentaArticuloPlanta v in ventas)
                {
                    _contexto.Salida.RemoveRange(v.Salida);
                }
                
                _contexto.VentaArticuloPlanta.RemoveRange(ventas);

                _contexto.SaveChanges();

                GenerarLog<Comprobante_Remito>(remito, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return remitoGuardado;
        }

        public void imprimirRemito(Comprobante_Remito remito, string enviarA, bool imprimirPrecios)
        {
            decimal cotiz = _contexto.Moneda.Where(m => m.nombre == "Dólar").Select(m => m.cotizacion).First();
            decimal precio;
            int x = -20; //VALORES NUEVOS
            int y = -7;
            y = 24;
            x = -2;            
            Font printFont = new Font("Arial", 10);
            Font printFontG = new Font("Arial", 15, FontStyle.Bold);
            SolidBrush printSolid = new SolidBrush(Color.Black);
            PrintDocument pd = new PrintDocument();
            string fecha = remito.fechaIngreso.Day.ToString("00") + "      " + remito.fechaIngreso.Month.ToString("00") + "     " + remito.fechaIngreso.Year.ToString();
            pd.PrintPage += delegate(object sender, PrintPageEventArgs e)
            {                
                e.Graphics.DrawString(fecha, printFont, printSolid, new Rectangle(x + 640, y + 136, 200, 200));
                e.Graphics.DrawString(remito.Planta.Cliente.razonSocial, printFont, printSolid, new Rectangle(x + 130, y + 225, 500, 500));
                e.Graphics.DrawString(remito.Planta.Cliente.direccion, printFont, printSolid, new Rectangle(x + 500, y + 225, 500, 500));                
                e.Graphics.DrawString(remito.Planta.Cliente.Localidad.nombre, printFont, printSolid, new Rectangle(x + 500, y + 265, 500, 500));
                e.Graphics.DrawString(remito.Planta.Cliente.SituacionFrenteIva.nombre, printFont, printSolid, new Rectangle(x + 110, y + 297, 500, 500));

                if (remito.ordenCompra != "")
                    e.Graphics.DrawString("oc: " + remito.ordenCompra, printFont, printSolid, new Rectangle(x + 260, y + 287, 500, 500));

                e.Graphics.DrawString(remito.Planta.Cliente.cuit, printFont, printSolid, new Rectangle(x + 500, y + 297, 200, 200));
                e.Graphics.DrawString("Enviar a: " + enviarA, printFont, printSolid, new Rectangle(x + 460, y + 325, 500, 500));

                y += 390;
                foreach (VentaArticuloPlanta venta in remito.VentaArticuloPlanta)
                {                    
                    precio = ConviertePrecio(venta.precio, venta.Moneda, remito.Moneda);
                    e.Graphics.DrawString(venta.cantidad.ToString("0.00"), printFont, printSolid, new Rectangle(x + 55, y, 500, 500));
                    e.Graphics.DrawString(venta.TipoArticulo.nombre + "    " + venta.lote, printFont, printSolid, new Rectangle(x + 132, y, 500, 500));
                    if (imprimirPrecios)
                    {
                        e.Graphics.DrawString(precio.ToString("0.00"), printFont, printSolid, new Rectangle(x + 517, y, 500, 500));
                        e.Graphics.DrawString((venta.cantidad * precio).ToString("0.00"), printFont, printSolid, new Rectangle(x + 643, y, 500, 500));
                    }
                    
                    y += 15;
                }
                y = 800;
                e.Graphics.DrawString(remito.observacion, printFont, printSolid, new Rectangle(x + 130, y, 650, 650));
                y = 875;                
                e.Graphics.DrawString("Cantidad de Bultos: " + remito.cantidadBultos.ToString(), printFont, printSolid, new Rectangle(x + 150, y, 500, 500));
                e.Graphics.DrawString("Peso Total ("+ remito.Unidad.abreviatura +"): " + remito.pesoTotalKg.ToString("0.00"), printFont, printSolid, new Rectangle(x + 150, y + 20, 500, 500));
                if (imprimirPrecios)
                    e.Graphics.DrawString("Valor Total Declarado: "+ remito.Moneda.simbologia + " " + remito.importe.ToString("0.00"), printFont, printSolid, new Rectangle(x + 150, y + 40, 500, 500));
                e.Graphics.DrawString("La Mercadería viaja por cuenta y riesgo del comprador", printFont, printSolid, new Rectangle(x + 150, y + 85, 500, 500));
                e.Graphics.DrawString("Cotización 1 u$s = $" + cotiz.ToString("0.0000"), printFont, printSolid, new Rectangle(x + 150, y + 105, 500, 500));
                e.Graphics.DrawString("Recibí Conforme: ........................................................." , printFont, printSolid, new Rectangle(x + 150, y + 150, 500, 500));
            };
            // Print the document.
            ParametroSistema paramImpresora = obtenerParametroSistemaPorNombre("Impresora " + System.Environment.MachineName);
            //if (paramImpresora !=null)
            pd.PrinterSettings.PrinterName = paramImpresora.valor;
            pd.Print();
        }

        public void imprimirRemitoDigital(Comprobante_Remito remito, string enviarA, bool imprimirPrecios)
        {
            decimal cotiz = _contexto.Moneda.Where(m => m.nombre == "Dólar").Select(m => m.cotizacion).First();
            decimal precio;
            Image imagen = Image.FromFile("C:/Quimadh/Remito.jpg");
            
            Bitmap bm = new Bitmap(imagen, imagen.Size);
            Graphics graf = Graphics.FromImage(bm);

            int x = 538; //VALORES NUEVOS
            int y = 5;
            Font printFont = new Font("Arial", 20);
            Font printFontG = new Font("Arial", 20, FontStyle.Bold);
            SolidBrush printSolid = new SolidBrush(Color.Black);
            string fecha = remito.fechaIngreso.Day.ToString("00") + "      " + remito.fechaIngreso.Month.ToString("00") + "     " + remito.fechaIngreso.Year.ToString();

            graf.DrawString(remito.numero.ToString("00000000"), printFontG, printSolid, new RectangleF(x + 606, y + 87, 500, 500));

            graf.DrawString(fecha, printFont, printSolid, new Rectangle(x + 686, y + 192, 2000, 2000));
            graf.DrawString(remito.Planta.Cliente.razonSocial, printFont, printSolid, new Rectangle(x - 300, y + 363, 500, 500));
            graf.DrawString(remito.Planta.Cliente.direccion, printFont, printSolid, new Rectangle(x + 440, y + 366, 500, 500));
            graf.DrawString(remito.Planta.Cliente.Localidad.nombre, printFont, printSolid, new Rectangle(x + 440, y + 450, 500, 500));
            graf.DrawString(remito.Planta.Cliente.SituacionFrenteIva.nombre, printFont, printSolid, new Rectangle(x - 320, y + 520, 500, 500));
            if (remito.ordenCompra != "")
                graf.DrawString("oc: " + remito.ordenCompra, printFont, printSolid, new Rectangle(x - 30, y + 500, 500, 500));
            graf.DrawString(remito.Planta.Cliente.cuit, printFont, printSolid, new Rectangle(x + 440, y + 520, 200, 200));
            graf.DrawString("Enviar a: " + enviarA, printFont, printSolid, new Rectangle(x + 225, y + 585, 500, 500));

            y += 695;
            foreach (VentaArticuloPlanta venta in remito.VentaArticuloPlanta)
            {
                precio = ConviertePrecio(venta.precio, venta.Moneda, remito.Moneda);
                graf.DrawString(venta.cantidad.ToString("0.00"), printFont, printSolid, new Rectangle(x - 480, y, 500, 500));
                graf.DrawString(venta.TipoArticulo.nombre + "    " + venta.lote, printFont, printSolid, new Rectangle(x - 170, y, 600, 600));
                if (imprimirPrecios)
                {
                    graf.DrawString(precio.ToString("0.00"), printFont, printSolid, new Rectangle(x + 480, y, 500, 500));
                    graf.DrawString((venta.cantidad * precio).ToString("0.00"), printFont, printSolid, new Rectangle(x + 700, y, 500, 500));
                }
                
                y += 30;
            }
            y = 1400;
            graf.DrawString(remito.observacion, printFont, printSolid, new Rectangle(x - 170, y, 1000, 1000));
            y = 1600;

            graf.DrawString("Cantidad de Bultos: " + remito.cantidadBultos.ToString(), printFont, printSolid, new Rectangle(x + 80, y, 500, 500));
            graf.DrawString("Peso Total (" + remito.Unidad.abreviatura + "): " + remito.pesoTotalKg.ToString("0.00"), printFont, printSolid, new Rectangle(x + 80, y + 35, 500, 500));
            if (imprimirPrecios)
                graf.DrawString("Valor Total Declarado: " + remito.Moneda.simbologia + " " + remito.importe.ToString("0.00"), printFont, printSolid, new Rectangle(x + 80, y + 70, 500, 500));            
            graf.DrawString("La Mercadería viaja por cuenta y riesgo del comprador", printFont, printSolid, new Rectangle(x + 80, y + 105, 1000, 1000));
            graf.DrawString("Cotización 1 u$s = $" + cotiz.ToString("0.0000"), printFont, printSolid, new Rectangle(x + 80, y + 140, 500, 500));
            graf.DrawString("Recibí Conforme: ...........................................", printFont, printSolid, new Rectangle(x + 70, y + 240, 1000, 1000));

            ParametroSistema paramCarpeta = obtenerParametroSistemaPorNombre("CarpetaComprobantes");

            string directorio = paramCarpeta.valor + "/Remitos/" + remito.tipo;
            if (!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);

            bm.Save(directorio + "/" + remito.numero.ToString() + ".png");
            graf.Dispose();

        }

        public Comprobante_Remito buscarUnRemito(long numRemito)
        {
            return _contexto.Comprobante.OfType<Comprobante_Remito>().Where(r => r.numero == numRemito).FirstOrDefault();
        }

        public decimal CantidadPendienteFacturacion(VentaArticuloPlanta itemRemito)
        {
            List<VentaArticuloPlanta> listaItems = _contexto.VentaArticuloPlanta.Where(i => i.idRemito == itemRemito.idComprobante && i.idArticulo == itemRemito.idArticulo && i.Comprobante.anulado == false).ToList();
            decimal cantFacturada = listaItems.Count() == 0 ? 0 : listaItems.Sum(i => i.cantidad);           
            return itemRemito.cantidad - cantFacturada;
        }

        #endregion

        #region Recibo

        public Comprobante_Recibo agregarRecibo(Comprobante_Recibo recibo, Metadata metadata)
        {
            Comprobante_Recibo reciboGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarRecibo(recibo);

                reciboGuardado = (Comprobante_Recibo)_contexto.Comprobante.Add(recibo);
                _contexto.SaveChanges();

                GenerarLog<Comprobante_Recibo>(recibo, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return reciboGuardado;
        }

        public long BuscarNroRecibo()
        {
            long numero;
            numero = _contexto.Comprobante.OfType<Comprobante_Recibo>().Any() ? _contexto.Comprobante.OfType<Comprobante_Recibo>().Max(r => r.numero) : 0;
            return numero + 1;
        }

        public List<Comprobante_Recibo> obtenerTodosComprobantesRec(int numeroRegistros)
        {
            return _contexto.Comprobante.OfType<Comprobante_Recibo>().Take(numeroRegistros).ToList();
        }

        private void ValidarRecibo(Comprobante_Recibo recibo)
        {
            string mensaje = "";

            if (recibo.numero == 0)
                mensaje = "Ingrese un número de recibo.";

            if (recibo.importe == 0)
                mensaje = "El importe debe ser mayor a cero.";

            //foreach (ItemRecibo item in recibo.ItemRecibo)
            //{
            //    if (item.fechaIzq.ToString("yyyyMMdd") == "19000101")
            //        mensaje = "Alguna fecha del lado izquierdo es incorrecta.";
            //    if (item.fechaDer.ToString("yyyyMMdd") == "19000101")
            //        mensaje = "Alguna fecha del lado derecho es incorrecta.";
            //}

            bool existe = (from r in _contexto.Comprobante.OfType<Comprobante_Recibo>()
                           where r.numero.Equals(recibo.numero)
                           select r).Any();

            if (existe)
                mensaje = "Ya existe el número de recibo.";

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);
        }

        public void imprimirRecibo(Comprobante_Recibo recibo)
        {
            DateTime fi;
            DateTime fd;
            decimal ii;
            decimal id;

            int x = -2; //VALORES NUEVOS
            int y = 24;
            Font printFont = new Font("Arial", 10);
            Font printFontG = new Font("Arial", 15, FontStyle.Bold);
            SolidBrush printSolid = new SolidBrush(Color.Black);
            PrintDocument pd = new PrintDocument();            
            string fecha = recibo.fechaIngreso.Day.ToString("00") + "      " + recibo.fechaIngreso.Month.ToString("00") + "     " + recibo.fechaIngreso.Year.ToString();
            pd.PrintPage += delegate(object sender, PrintPageEventArgs e)
            {
                e.Graphics.DrawString(fecha, printFont, printSolid, new Rectangle(x + 630, y + 128, 200, 200)); //x + 635, y + 136
                e.Graphics.DrawString(recibo.Planta.Cliente.razonSocial, printFont, printSolid, new Rectangle(x + 130, y + 223, 500, 500));
                e.Graphics.DrawString(recibo.Planta.Cliente.direccion, printFont, printSolid, new Rectangle(x + 497, y + 223, 500, 500));
                e.Graphics.DrawString(recibo.Planta.Cliente.Localidad.nombre, printFont, printSolid, new Rectangle(x + 497, y + 265, 500, 500));
                e.Graphics.DrawString(recibo.Planta.Cliente.SituacionFrenteIva.nombre, printFont, printSolid, new Rectangle(x + 110, y + 300, 500, 500));
                e.Graphics.DrawString(recibo.Planta.Cliente.cuit, printFont, printSolid, new Rectangle(x + 490, y + 300, 200, 200));
                
                y += 390;
                foreach (ItemRecibo item in recibo.ItemRecibo)
                {
                    if (item.fechaIzq != null)
                    {
                        fi = (DateTime)item.fechaIzq;
                        e.Graphics.DrawString(fi.ToString("dd/MM/yyyy"), printFont, printSolid, new Rectangle(x + 55, y, 500, 500));
                    }
                    if (item.importeIzq != null)
                    {
                        ii = (decimal)item.importeIzq;
                        e.Graphics.DrawString(ii.ToString("0.00"), printFont, printSolid, new Rectangle(x + 330, y, 500, 500));
                    }
                    if (item.fechaDer != null)
                    {
                        fd = (DateTime)item.fechaDer;
                        e.Graphics.DrawString(fd.ToString("dd/MM/yyyy"), printFont, printSolid, new Rectangle(x + 420, y, 500, 500));
                    }
                    if (item.importeDer != null)
                    {
                        id = (decimal)item.importeDer;
                        e.Graphics.DrawString(id.ToString("0.00"), printFont, printSolid, new Rectangle(x + 690, y, 500, 500));   
                    }
                    
                    e.Graphics.DrawString(item.descripIzq, printFont, printSolid, new Rectangle(x + 150, y, 500, 500));                                        
                    e.Graphics.DrawString(item.descripDer, printFont, printSolid, new Rectangle(x + 520, y, 500, 500));
                    
                    y += 15;
                }
                y = 800;               
                e.Graphics.DrawString("TOTAL: " + recibo.importe.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 100, y + 178, 500, 500));
                e.Graphics.DrawString("TOTAL: " + recibo.importe.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 600, y + 178, 500, 500));
            };
            // Print the document.
            ParametroSistema paramImpresora = obtenerParametroSistemaPorNombre("Impresora " + System.Environment.MachineName);
            pd.PrinterSettings.PrinterName = paramImpresora.valor;
            pd.Print();
        }

        public void imprimirReciboDigital(Comprobante_Recibo recibo)
        {
            DateTime fi;
            DateTime fd;
            decimal ii;
            decimal id;

            Image imagen = Image.FromFile("C:/Quimadh/Recibo.jpg");

            Bitmap bm = new Bitmap(imagen, imagen.Size);
            Graphics graf = Graphics.FromImage(bm);

            int x = 540; //VALORES NUEVOS
            int y = 7;
            Font printFont = new Font("Arial", 20);
            Font printFontG = new Font("Arial", 20, FontStyle.Bold);
            SolidBrush printSolid = new SolidBrush(Color.Black);
            string fecha = recibo.fechaIngreso.Day.ToString("00") + "      " + recibo.fechaIngreso.Month.ToString("00") + "     " + recibo.fechaIngreso.Year.ToString();

            graf.DrawString(recibo.numero.ToString("00000000"), printFontG, printSolid, new RectangleF(x + 610, y + 93, 500, 500));

            graf.DrawString(fecha, printFont, printSolid, new Rectangle(x + 686, y + 192, 2000, 2000));
            graf.DrawString(recibo.Planta.Cliente.razonSocial, printFont, printSolid, new Rectangle(x - 300, y + 363, 500, 500));
            graf.DrawString(recibo.Planta.Cliente.direccion, printFont, printSolid, new Rectangle(x + 490, y + 366, 500, 500));
            graf.DrawString(recibo.Planta.Cliente.Localidad.nombre, printFont, printSolid, new Rectangle(x + 490, y + 447, 500, 500));
            graf.DrawString(recibo.Planta.Cliente.SituacionFrenteIva.nombre, printFont, printSolid, new Rectangle(x - 330, y + 515, 500, 500));
            graf.DrawString(recibo.Planta.Cliente.cuit, printFont, printSolid, new Rectangle(x + 440, y + 520, 200, 200));

            y += 685;
            foreach (ItemRecibo item in recibo.ItemRecibo)
            {
                if (item.fechaIzq != null)
                    {
                        fi = (DateTime)item.fechaIzq;
                        graf.DrawString(fi.ToString("dd/MM/yyyy"), printFont, printSolid, new Rectangle(x - 450, y, 500, 500));
                    }
                    if (item.importeIzq != null)
                    {
                        ii = (decimal)item.importeIzq;
                        graf.DrawString(ii.ToString("0.00"), printFont, printSolid, new Rectangle(x - 250, y, 500, 500));
                    }
                    if (item.fechaDer != null)
                    {
                        fd = (DateTime)item.fechaDer;
                        graf.DrawString(fd.ToString("dd/MM/yyyy"), printFont, printSolid, new Rectangle(x + 300, y, 500, 500));
                    }
                    if (item.importeDer != null)
                    {
                        id = (decimal)item.importeDer;
                        graf.DrawString(id.ToString("0.00"), printFont, printSolid, new Rectangle(x + 500, y, 500, 500));   
                    }

                    graf.DrawString(item.descripIzq, printFont, printSolid, new Rectangle(x - 50, y, 500, 500));
                    graf.DrawString(item.descripDer, printFont, printSolid, new Rectangle(x + 700, y, 500, 500));
                    
                    y += 40;
            }
            y = 1500;
            graf.DrawString("TOTAL: " + recibo.importe.ToString("0.00"), printFontG, printSolid, new Rectangle(x - 200 , y + 178, 500, 500));
            graf.DrawString("TOTAL: " + recibo.importe.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 400, y + 178, 500, 500));

            ParametroSistema paramCarpeta = obtenerParametroSistemaPorNombre("CarpetaComprobantes");

            string directorio = paramCarpeta.valor + "/Recibos";
            if (!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);
            bm.Save(directorio +"/" + recibo.numero.ToString() + ".png");
            graf.Dispose();
        }

        #endregion

        #region Notas

        public long BuscarNroNotaCred(string tipo, int pv)
        {
            long numero;
            numero = _contexto.Comprobante.OfType<Comprobante_Devolucion>().Where(n => n.tipo == tipo).Where(n => n.pv == pv).Any() ? _contexto.Comprobante.OfType<Comprobante_Devolucion>().Where(n => n.tipo == tipo).Where(n => n.pv == pv).Max(nc => nc.numero) : 0;
            return numero + 1;
        }

        public Comprobante_Devolucion buscarNotaCred(long numComp, string tipo, int pv)
        {
            IQueryable<Comprobante_Devolucion> queryN;

            queryN = _contexto.Comprobante.OfType<Comprobante_Devolucion>();
            if (pv != 0)
                queryN = queryN.Where(c => c.pv == pv);
            if (tipo != "")
                queryN = queryN.Where(c => c.tipo == tipo);
            if (numComp != 0)
                queryN = queryN.Where(c => c.numero == numComp);

            return queryN.FirstOrDefault();
        }

        public Comprobante_Recargo buscarNotaDeb(long numComp, string tipo, int pv)
        {
            IQueryable<Comprobante_Recargo> queryN;

            queryN = _contexto.Comprobante.OfType<Comprobante_Recargo>();
            if (pv != 0)
                queryN = queryN.Where(c => c.pv == pv);
            if (tipo != "")
                queryN = queryN.Where(c => c.tipo == tipo);
            if (numComp != 0)
                queryN = queryN.Where(c => c.numero == numComp);

            return queryN.FirstOrDefault();
        }

        public Comprobante_Devolucion agregarNotaCred(Comprobante_Devolucion notaCred, Metadata metadata)
        {
            Comprobante_Devolucion notaCredGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarNota(notaCred);

                notaCredGuardada = (Comprobante_Devolucion)_contexto.Comprobante.Add(notaCred);
                _contexto.SaveChanges();

                GenerarLog<Comprobante_Devolucion>(notaCred, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return notaCredGuardada;
        }

        public Comprobante_Devolucion actualizarNotaCred(Comprobante_Devolucion notaCred, Metadata metadata)
        {
            Comprobante_Devolucion notaCredGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarNota(notaCred, Acciones.Log.MODIFICACION);

                IQueryable<ItemNota> items;
                IQueryable<Comprobante_Devolucion> notasReemplazadas = (IQueryable<Comprobante_Devolucion>)_contexto.Comprobante.OfType<Comprobante_Devolucion>().Where(n => n.tipo == notaCred.tipo).Where(n => n.pv == notaCred.pv).Where(n => n.numero == notaCred.numero).Where(n => n.id != notaCred.id);
                foreach (Comprobante_Devolucion n in notasReemplazadas)
                {
                    items = (IQueryable<ItemNota>)_contexto.ItemNota.Where(i => i.idDevolucion == n.id);
                    _contexto.ItemNota.RemoveRange(items);
                }

                _contexto.Comprobante.RemoveRange(notasReemplazadas);
                _contexto.SaveChanges();

                GenerarLog<Comprobante_Devolucion>(notaCred, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return notaCredGuardada;
        }

        public List<Comprobante_Devolucion> obtenerTodosComprobantesNC(int numeroRegistros)
        {
            return _contexto.Comprobante.OfType<Comprobante_Devolucion>().Take(numeroRegistros).ToList();
        }

        public List<Comprobante_Recargo> obtenerTodosComprobantesND(int numeroRegistros)
        {
            return _contexto.Comprobante.OfType<Comprobante_Recargo>().Take(numeroRegistros).ToList();
        }

        public long BuscarNroNotaDeb(string tipo, int pv)
        {
            long numero;
            numero = _contexto.Comprobante.OfType<Comprobante_Recargo>().Where(n => n.tipo == tipo).Where(n => n.pv == pv).Any() ? _contexto.Comprobante.OfType<Comprobante_Recargo>().Where(n => n.tipo == tipo).Where(n => n.pv == pv).Max(nd => nd.numero) : 0;
            return numero + 1;
        }


        public Comprobante_Recargo agregarNotaDeb(Comprobante_Recargo notaDeb, Metadata metadata)
        {
            Comprobante_Recargo notaDebGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarNota(notaDeb);

                notaDebGuardada = (Comprobante_Recargo)_contexto.Comprobante.Add(notaDeb);
                _contexto.SaveChanges();

                GenerarLog<Comprobante_Recargo>(notaDeb, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return notaDebGuardada;
        }

        public Comprobante_Recargo actualizarNotaDeb(Comprobante_Recargo notaDeb, Metadata metadata)
        {
            Comprobante_Recargo notaDebGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarNota(notaDeb, Acciones.Log.MODIFICACION);

                IQueryable<ItemNota> items;
                IQueryable<Comprobante_Recargo> notasReemplazadas = (IQueryable<Comprobante_Recargo>)_contexto.Comprobante.OfType<Comprobante_Recargo>().Where(n => n.tipo == notaDeb.tipo).Where(n => n.pv == notaDeb.pv).Where(n => n.numero == notaDeb.numero).Where(n => n.id != notaDeb.id);
                foreach (Comprobante_Recargo n in notasReemplazadas)
                {
                    items = (IQueryable<ItemNota>)_contexto.ItemNota.Where(i => i.idRecargo == n.id);
                    _contexto.ItemNota.RemoveRange(items);
                }

                _contexto.Comprobante.RemoveRange(notasReemplazadas);
                _contexto.SaveChanges();

                GenerarLog<Comprobante_Recargo>(notaDeb, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return notaDebGuardada;
        }

        private void ValidarNota(Comprobante nota, Acciones.Log accion = Acciones.Log.ALTA)
        {
            string mensaje = "";
            bool existe;
            int lonCondVta;

            if (nota.importe == 0)
                mensaje = "El importe total debe ser mayor a cero.";

            if (nota.GetType().BaseType.Name == "Comprobante_Devolucion" || nota.GetType().Name == "Comprobante_Devolucion")
            {
                if (((Comprobante_Devolucion)nota).numero == 0)
                    mensaje = "Ingrese un número de nota de cédito.";

                if (accion == Acciones.Log.ALTA)
                {                
                    existe = (from n in _contexto.Comprobante.OfType<Comprobante_Devolucion>()
                               where n.numero.Equals(((Comprobante_Devolucion)nota).numero)
                               where n.tipo.Equals(((Comprobante_Devolucion)nota).tipo)
                               where n.pv.Equals(((Comprobante_Devolucion)nota).pv)
                               select n).Any();

                    if (existe)
                        mensaje = "El número de nota de cédito ya existe.";
                }

                lonCondVta = ((Comprobante_Devolucion)nota).condVta.Length;
                if (lonCondVta == 0)
                    mensaje = "Debe ingresar una condición de venta";
            }
            else
            {
                if (((Comprobante_Recargo)nota).numero == 0)
                    mensaje = "Ingrese un número de nota de débito.";

                if (accion == Acciones.Log.ALTA)
                {
                    existe = (from n in _contexto.Comprobante.OfType<Comprobante_Recargo>()
                              where n.numero.Equals(((Comprobante_Recargo)nota).numero)
                              where n.tipo.Equals(((Comprobante_Recargo)nota).tipo)
                              where n.pv.Equals(((Comprobante_Recargo)nota).pv)
                              select n).Any();

                    if (existe)
                        mensaje = "El número de nota de débito ya existe.";
                }

                lonCondVta = ((Comprobante_Recargo)nota).condVta.Length;
                if (lonCondVta == 0)
                    mensaje = "Debe ingresar una condición de venta";
            }

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);
        }

        public void imprimirNota(Comprobante_Recargo nota)
        {
            int x = -2; //VALORES NUEVOS
            int y = 21;
            Font printFont = new Font("Arial", 10);
            Font printFontG = new Font("Arial", 15, FontStyle.Bold);
            SolidBrush printSolid = new SolidBrush(Color.Black);
            PrintDocument pd = new PrintDocument();
            string fecha = nota.fechaIngreso.Day.ToString("00") + "      " + nota.fechaIngreso.Month.ToString("00") + "     " + nota.fechaIngreso.Year.ToString();
            pd.PrintPage += delegate(object sender, PrintPageEventArgs e)
            {
                //Image imagen = Image.FromFile("C:/Users/marianoPC/Desktop/quimadh/Sistema/1 - Investigación Preliminar/Información del Cliente/Comprobantes/Nota de Debito.jpg");
                //e.Graphics.DrawImage(imagen, 0, 0);
                //e.Graphics.DrawString(recibo.numero.ToString("00000000"), printFontG, printSolid, new RectangleF(x + 606, y + 87, 500, 500));
                e.Graphics.DrawString(fecha, printFont, printSolid, new Rectangle(x + 640, y + 136, 200, 200));
                e.Graphics.DrawString(nota.Planta.Cliente.razonSocial, printFont, printSolid, new Rectangle(x + 130, y + 225, 500, 500));
                e.Graphics.DrawString(nota.Planta.Cliente.direccion, printFont, printSolid, new Rectangle(x + 500, y + 225, 500, 500));
                e.Graphics.DrawString(nota.Planta.Cliente.Localidad.nombre, printFont, printSolid, new Rectangle(x + 500, y + 265, 500, 500));
                e.Graphics.DrawString(nota.Planta.Cliente.SituacionFrenteIva.nombre, printFont, printSolid, new Rectangle(x + 110, y + 297, 500, 500));
                e.Graphics.DrawString(nota.Planta.Cliente.cuit, printFont, printSolid, new Rectangle(x + 120, y + 317, 200, 200));
                e.Graphics.DrawString(nota.condVta, printFont, printSolid, new Rectangle(x + 197, y + 337, 200, 200));

                y += 390;
                foreach (ItemNota item in nota.ItemNota)
                {
                    e.Graphics.DrawString(item.cantidad.ToString(), printFont, printSolid, new Rectangle(x + 55, y, 500, 500));
                    e.Graphics.DrawString(item.descripcion, printFont, printSolid, new Rectangle(x + 132, y, 500, 500));
                    if (nota.Planta.Cliente.idSituacionFrenteIva == 4)
                    {
                        e.Graphics.DrawString(item.importe.ToString("0.00"), printFont, printSolid, new Rectangle(x + 517, y, 500, 500));
                        e.Graphics.DrawString(((decimal)item.cantidad * item.importe).ToString("0.00"), printFont, printSolid, new Rectangle(x + 643, y, 500, 500));
                    }
                    else
                    {
                        e.Graphics.DrawString((item.importe * (((decimal)item.iva / 100) + 1)).ToString("0.00"), printFont, printSolid, new Rectangle(x + 517, y, 500, 500));
                        e.Graphics.DrawString(((decimal)item.cantidad * item.importe * (((decimal)item.iva / 100) + 1)).ToString("0.00"), printFont, printSolid, new Rectangle(x + 643, y, 500, 500));
                    }

                    y += 15;
                }
                y = 783;
                e.Graphics.DrawString(nota.subtotal.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 645, y + 110, 500, 500));
                e.Graphics.DrawString(nota.totalIva.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 645, y + 140, 500, 500));
                e.Graphics.DrawString("0.00", printFontG, printSolid, new Rectangle(x + 645, y + 170, 500, 500));

                if (nota.Moneda.simbologia != "$")               
                    e.Graphics.DrawString(nota.Moneda.simbologia + " " + nota.importe.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 645, y + 210, 500, 500));                
                else
                    e.Graphics.DrawString(nota.importe.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 645, y + 210, 500, 500));
            };
            // Print the document.
            ParametroSistema paramImpresora = obtenerParametroSistemaPorNombre("Impresora " + System.Environment.MachineName);
            pd.PrinterSettings.PrinterName = paramImpresora.valor;
            pd.Print();
        }

        public void imprimirNota(Comprobante_Devolucion nota)
        {
            int x = -2; //VALORES NUEVOS
            int y = 21;
            Font printFont = new Font("Arial", 10);
            Font printFontG = new Font("Arial", 15, FontStyle.Bold);
            SolidBrush printSolid = new SolidBrush(Color.Black);
            PrintDocument pd = new PrintDocument();
            string fecha = nota.fechaIngreso.Day.ToString("00") + "      " + nota.fechaIngreso.Month.ToString("00") + "     " + nota.fechaIngreso.Year.ToString();
            pd.PrintPage += delegate(object sender, PrintPageEventArgs e)
            {                
                e.Graphics.DrawString(fecha, printFont, printSolid, new Rectangle(x + 640, y + 136, 200, 200));
                e.Graphics.DrawString(nota.Planta.Cliente.razonSocial, printFont, printSolid, new Rectangle(x + 130, y + 225, 500, 500));
                e.Graphics.DrawString(nota.Planta.Cliente.direccion, printFont, printSolid, new Rectangle(x + 500, y + 225, 500, 500));
                e.Graphics.DrawString(nota.Planta.Cliente.Localidad.nombre, printFont, printSolid, new Rectangle(x + 500, y + 265, 500, 500));
                e.Graphics.DrawString(nota.Planta.Cliente.SituacionFrenteIva.nombre, printFont, printSolid, new Rectangle(x + 110, y + 297, 500, 500));
                e.Graphics.DrawString(nota.Planta.Cliente.cuit, printFont, printSolid, new Rectangle(x + 120, y + 317, 200, 200));
                e.Graphics.DrawString(nota.condVta, printFont, printSolid, new Rectangle(x + 197, y + 337, 200, 200));

                y += 390;
                foreach (ItemNota item in nota.ItemNota)
                {
                    e.Graphics.DrawString(item.cantidad.ToString(), printFont, printSolid, new Rectangle(x + 55, y, 500, 500));
                    e.Graphics.DrawString(item.descripcion, printFont, printSolid, new Rectangle(x + 132, y, 500, 500));                    
                    if (nota.Planta.Cliente.idSituacionFrenteIva == 4)
                    {
                        e.Graphics.DrawString(item.importe.ToString("0.00"), printFont, printSolid, new Rectangle(x + 517, y, 500, 500));
                        e.Graphics.DrawString(((decimal)item.cantidad * item.importe).ToString("0.00"), printFont, printSolid, new Rectangle(x + 643, y, 500, 500));
                    }
                    else
                    {
                        e.Graphics.DrawString((item.importe * (((decimal)item.iva / 100) + 1)).ToString("0.00"), printFont, printSolid, new Rectangle(x + 517, y, 500, 500));
                        e.Graphics.DrawString(((decimal)item.cantidad * item.importe * (((decimal)item.iva / 100) + 1)).ToString("0.00"), printFont, printSolid, new Rectangle(x + 643, y, 500, 500));
                    }
                    
                    y += 15;
                }
                y = 783;
                e.Graphics.DrawString(nota.subtotal.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 645, y + 110, 500, 500));
                e.Graphics.DrawString(nota.totalIva.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 645, y + 140, 500, 500));
                e.Graphics.DrawString("0.00", printFontG, printSolid, new Rectangle(x + 645, y + 170, 500, 500));
                if (nota.Moneda.simbologia != "$")
                    e.Graphics.DrawString(nota.Moneda.simbologia + " " + nota.importe.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 645, y + 210, 500, 500));
                else
                e.Graphics.DrawString(nota.importe.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 645, y + 210, 500, 500));
            };
            // Print the document.
            ParametroSistema paramImpresora = obtenerParametroSistemaPorNombre("Impresora " + System.Environment.MachineName);
            pd.PrinterSettings.PrinterName = paramImpresora.valor;
            pd.Print();
        }

        public void imprimirNotaDigital(Comprobante_Devolucion nota)
        {
            Image imagen;
            if (nota.tipo == "A")
            {
                imagen = Image.FromFile("C:/Quimadh/Nota de Credito.jpg");
            }
            else
            {
                imagen = Image.FromFile("C:/Quimadh/Nota de Credito2.jpg");
            }

            Bitmap bm = new Bitmap(imagen, imagen.Size);
            Graphics graf = Graphics.FromImage(bm);

            int x = 544; //VALORES NUEVOS
            int y = 18;
            Font printFont = new Font("Arial", 20);
            Font printFontG = new Font("Arial", 20, FontStyle.Bold);
            SolidBrush printSolid = new SolidBrush(Color.Black);
            string fecha = nota.fechaIngreso.Day.ToString("00") + "      " + nota.fechaIngreso.Month.ToString("00") + "     " + nota.fechaIngreso.Year.ToString();

            graf.DrawString(nota.pv.ToString("0000") + " - " + nota.numero.ToString("00000000"), printFontG, printSolid, new RectangleF(x + 465, y + 105, 500, 500));

            graf.DrawString(fecha, printFont, printSolid, new Rectangle(x + 686, y + 192, 2000, 2000));
            graf.DrawString(nota.Planta.Cliente.razonSocial, printFont, printSolid, new Rectangle(x - 300, y + 357, 500, 500));
            graf.DrawString(nota.Planta.Cliente.direccion, printFont, printSolid, new Rectangle(x + 460, y + 366, 500, 500));
            graf.DrawString(nota.Planta.Cliente.Localidad.nombre, printFont, printSolid, new Rectangle(x + 460, y + 447, 500, 500));
            graf.DrawString(nota.Planta.Cliente.SituacionFrenteIva.nombre, printFont, printSolid, new Rectangle(x - 330, y + 500, 500, 500));
            graf.DrawString(nota.Planta.Cliente.cuit, printFont, printSolid, new Rectangle(x - 300, y + 540, 200, 200));
            graf.DrawString(nota.condVta, printFont, printSolid, new Rectangle(x - 220, y + 583, 200, 200));

            y += 685;
            foreach (ItemNota item in nota.ItemNota)
            {
                graf.DrawString(((decimal)item.cantidad).ToString("0.00"), printFont, printSolid, new Rectangle(x - 485, y, 500, 500));
                graf.DrawString(item.descripcion, printFont, printSolid, new Rectangle(x - 360, y, 500, 500));
                if (nota.Planta.Cliente.idSituacionFrenteIva == 4)
                {
                    graf.DrawString(item.importe.ToString("0.00"), printFont, printSolid, new Rectangle(x + 440, y, 500, 500));
                    graf.DrawString(((decimal)item.cantidad * item.importe).ToString("0.00"), printFont, printSolid, new Rectangle(x + 690, y, 500, 500));
                }
                else
                {
                    graf.DrawString((item.importe * (((decimal)item.iva / 100) + 1)).ToString("0.00"), printFont, printSolid, new Rectangle(x + 440, y, 500, 500));
                    graf.DrawString(((decimal)item.cantidad * item.importe * (((decimal)item.iva / 100) + 1)).ToString("0.00"), printFont, printSolid, new Rectangle(x + 690, y, 500, 500));
                }

                y += 40;
            }
            y = 1580;
            if (nota.tipo == "A")
            {
                graf.DrawString(nota.subtotal.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 690, y + 125, 500, 500));
                graf.DrawString(nota.totalIva.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 690, y + 190, 500, 500));
                graf.DrawString("0.00", printFontG, printSolid, new Rectangle(x + 690, y + 250, 500, 500));            
            }
            graf.DrawString(nota.Moneda.simbologia + " " + nota.importe.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 690, y + 320, 500, 500));

            if (nota.pv == 3)
            {
                graf.DrawString("CAE: " + nota.cae, printFontG, printSolid, new Rectangle(x + 480, y + 400, 500, 500));
                graf.DrawString("VENC.: " + ((DateTime)nota.fecVtoCae).ToString("dd/MM/yyyy"), printFontG, printSolid, new Rectangle(x + 480, y + 440, 500, 500));
            }   

            ParametroSistema paramCarpeta = obtenerParametroSistemaPorNombre("CarpetaComprobantes");
            
            string directorio = paramCarpeta.valor + "/Notas Credito";
            if (!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);
            bm.Save(directorio + "/" + nota.pv.ToString() + "-" + nota.numero.ToString() + ".png");
            graf.Dispose();

            if (nota.pv == 3)
            {
                ParametroSistema paramImpresora = obtenerParametroSistemaPorNombre("Impresora " + System.Environment.MachineName);

                PrintDocument pd = new PrintDocument();
                pd.PrintPage += delegate(object sender, PrintPageEventArgs e)
                {
                    bm.SetResolution(183, 180);
                    e.Graphics.DrawImage(bm, 0, 0);
                };
                pd.PrinterSettings.PrinterName = paramImpresora.valor;
                pd.Print();
            }
        }

        public void imprimirNotaDigital(Comprobante_Recargo nota)
        {
            Image imagen;
            if (nota.tipo == "A")
            {
                imagen = Image.FromFile("C:/Quimadh/Nota de Debito.jpg");
            }
            else
            {
                imagen = Image.FromFile("C:/Quimadh/Nota de Debito2.jpg");
            }            

            Bitmap bm = new Bitmap(imagen, imagen.Size);
            Graphics graf = Graphics.FromImage(bm);

            int x = 560; //VALORES NUEVOS
            int y = 26;
            Font printFont = new Font("Arial", 20);
            Font printFontG = new Font("Arial", 20, FontStyle.Bold);
            SolidBrush printSolid = new SolidBrush(Color.Black);
            string fecha = nota.fechaIngreso.Day.ToString("00") + "      " + nota.fechaIngreso.Month.ToString("00") + "     " + nota.fechaIngreso.Year.ToString();

            graf.DrawString(nota.pv.ToString("0000") + " - " + nota.numero.ToString("00000000"), printFontG, printSolid, new RectangleF(x + 465, y + 105, 500, 500));

            graf.DrawString(fecha, printFont, printSolid, new Rectangle(x + 686, y + 192, 2000, 2000));
            graf.DrawString(nota.Planta.Cliente.razonSocial, printFont, printSolid, new Rectangle(x - 300, y + 357, 500, 500));
            graf.DrawString(nota.Planta.Cliente.direccion, printFont, printSolid, new Rectangle(x + 460, y + 366, 500, 500));
            graf.DrawString(nota.Planta.Cliente.Localidad.nombre, printFont, printSolid, new Rectangle(x + 460, y + 447, 500, 500));
            graf.DrawString(nota.Planta.Cliente.SituacionFrenteIva.nombre, printFont, printSolid, new Rectangle(x - 330, y + 503, 500, 500));
            graf.DrawString(nota.Planta.Cliente.cuit, printFont, printSolid, new Rectangle(x - 300, y + 543, 200, 200));
            graf.DrawString(nota.condVta, printFont, printSolid, new Rectangle(x - 220, y + 586, 200, 200));

            y += 685;
            foreach (ItemNota item in nota.ItemNota)
            {
                graf.DrawString(((decimal)item.cantidad).ToString("0.00"), printFont, printSolid, new Rectangle(x - 485, y, 500, 500));
                graf.DrawString(item.descripcion, printFont, printSolid, new Rectangle(x - 360, y, 500, 500));
                if (nota.Planta.Cliente.idSituacionFrenteIva == 4)
                {
                    graf.DrawString(item.importe.ToString("0.00"), printFont, printSolid, new Rectangle(x + 440, y, 500, 500));
                    graf.DrawString(((decimal)item.cantidad * item.importe).ToString("0.00"), printFont, printSolid, new Rectangle(x + 690, y, 500, 500));
                }
                else
                {
                    graf.DrawString((item.importe * (((decimal)item.iva / 100) + 1)).ToString("0.00"), printFont, printSolid, new Rectangle(x + 440, y, 500, 500));
                    graf.DrawString(((decimal)item.cantidad * item.importe * (((decimal)item.iva / 100) + 1)).ToString("0.00"), printFont, printSolid, new Rectangle(x + 690, y, 500, 500));
                }

                y += 40;
            }
            y = 1580;
            if (nota.tipo == "A")
            {
                graf.DrawString(nota.subtotal.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 690, y + 125, 500, 500));
                graf.DrawString(nota.totalIva.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 690, y + 190, 500, 500));
                graf.DrawString("0.00", printFontG, printSolid, new Rectangle(x + 690, y + 250, 500, 500));
            }
            graf.DrawString(nota.Moneda.simbologia + " " + nota.importe.ToString("0.00"), printFontG, printSolid, new Rectangle(x + 690, y + 320, 500, 500));

            if (nota.pv == 3)
            {
                graf.DrawString("CAE: " + nota.cae, printFontG, printSolid, new Rectangle(x + 480, y + 400, 500, 500));
                graf.DrawString("VENC.: " + ((DateTime)nota.fecVtoCae).ToString("dd/MM/yyyy"), printFontG, printSolid, new Rectangle(x + 480, y + 440, 500, 500));
            }  

            ParametroSistema paramCarpeta = obtenerParametroSistemaPorNombre("CarpetaComprobantes");

            string directorio = paramCarpeta.valor + "/Notas Debito";
            if (!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);
            bm.Save(directorio + "/" + nota.pv.ToString() + "-" + nota.numero.ToString() + ".png");
            graf.Dispose();

            if (nota.pv == 3)
            {
                ParametroSistema paramImpresora = obtenerParametroSistemaPorNombre("Impresora " + System.Environment.MachineName);

                PrintDocument pd = new PrintDocument();
                pd.PrintPage += delegate(object sender, PrintPageEventArgs e)
                {
                    bm.SetResolution(185, 180);
                    e.Graphics.DrawImage(bm, 0, 0);
                };
                pd.PrinterSettings.PrinterName = paramImpresora.valor;
                pd.Print();
            }
        }
        #endregion

        #region VentaArticuloPlanta

        private void ValidarVenta(VentaArticuloPlanta venta, Acciones.Log accion = Acciones.Log.ALTA)
        {
            string mensaje = "";

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);
        }

        #endregion

        #region PuntosVta

        public List<Rel_Pv_Comprobante> ObtenerPuntosVenta(string tipo)
        {
            return _contexto.Rel_Pv_Comprobante.Where(pv => pv.Comprobante == tipo).ToList();
        }
        #endregion

    }
}
