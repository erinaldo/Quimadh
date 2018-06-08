using Controles;
using Entidades;
using Frontend.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Vistas.Administracion
{
    public partial class frmEntradas : FormBaseConToolbar
    {
        private Entrada entrada;
        private frmBusquedaEntrada frmBusquedaEntrada;

        public frmEntradas()
        {
            InitializeComponent();
        }

        protected override void cargar()
        {
            Cargador.cargarArticulos(cboArticulo,"Sin Seleccionar...");
            Cargador.cargarPresentaciones(cboPresentacion, "Sin Seleccionar...");
            cboTipo.Items.Clear();
            cboTipo.Items.Add("Productos");
            cboTipo.Items.Add("Materia Prima / Insumos");
            cboTipo.SelectedIndex = 0;
            gpbDatos.Enabled = false;
        }

        protected override void agregar()
        {
            entrada = new Entrada();
            limpiarControles(gpbDatos);
            cargar();
            gpbDatos.Enabled = true;
            cboArticulo.Focus();
        }

        protected override void modificar()
        {
            gpbDatos.Enabled = true;
            cboArticulo.Focus();
        }

        protected override bool guardar()
        {            
            try
            {
                if (cboTipo.Text == "Productos")
                {
                    entrada.Lote = cboLote.SelectedItem != null ? ((Lote)((ComboBoxItem)cboLote.SelectedItem).Value) : null;
                }
                else
                {
                    Lote loteMp = cboArticulo.SelectedIndex != 0 ? (Global.Servicio.obtenerLoteMateriaPrima((TipoArticulo)((ComboBoxItem)cboArticulo.SelectedItem).Value, Global.DatosSesion)) : null;
                    entrada.Lote = loteMp;                    
                }                
                entrada.idPresentacion = cboPresentacion.SelectedIndex != 0 ? ((Presentacion)((ComboBoxItem)cboPresentacion.SelectedItem).Value).id : -1;
                entrada.cantidad = decimal.Parse(txtCantidad.Text != "" ? txtCantidad.Text : "0");
                entrada.fecha = dtpFecha.Value;
                entrada.concepto = txtConcepto.Text;

                //ICollection<ComposicionArticulos> entradasCalculadas = entrada.Lote.TipoArticulo.ComposicionArticulos;
                //entrada.Entrada1.Clear();
                //foreach (ComposicionArticulos comp in entradasCalculadas)
                //{
                //    Entrada entCalc = new Entrada();
                //    entCalc.Lote = Global.Servicio.obtenerLoteMateriaPrima(comp.TipoArticulo1, Global.DatosSesion);
                //    entCalc.idPresentacion = entrada.idPresentacion;                  
                //    entCalc.cantidad = Math.Round(entrada.cantidad * comp.cantComposicion * comp.factorConversion,2);
                //    entCalc.concepto = entrada.concepto;
                //    entCalc.fecha = entrada.fecha;
                //    //agrega las entradas derivadas
                //    entrada.Entrada1.Add(entCalc);
                //}

                string cadenaMensaje = "";

                if (Estado == Estados.Agregar)
                {                                        
                    entrada = Global.Servicio.agregarEntrada(entrada, Global.DatosSesion);
                    cadenaMensaje = "Entrada dada de alta exitosamente.";
                }
                else
                {
                    Global.Servicio.actualizarEntrada(entrada, Global.DatosSesion);
                    cadenaMensaje = "Entrada modificada con éxito.";
                }

                Mensaje mensaje = new Mensaje(cadenaMensaje, Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                mensaje.ShowDialog();
                return true;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return false;
        }

        protected override void limpiar()
        {
            if (Estado != Estados.Modificar)
            {
                // Limpia los datos del formulario
                limpiarControles(gpbDatos);
            }
            gpbDatos.Enabled = false;
        }

        protected override bool eliminar()
        {
            if (entrada != null)
            {
                Mensaje mensajeConfirmacion = new Mensaje("La entrada será eliminada ¿Está seguro?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                mensajeConfirmacion.ShowDialog();

                if (mensajeConfirmacion.resultado == DialogResult.OK)
                {
                    try
                    {
                        Mensaje mensajeExito;
                        Global.Servicio.eliminarEntrada(entrada, Global.DatosSesion);
                        mensajeExito = new Mensaje("La entrada ha sido eliminada con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                        mensajeExito.ShowDialog();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                        unMensaje.ShowDialog();
                    }
                }
            }
            else
            {
                Mensaje unMensaje = new Mensaje("Debe seleccionar una entrada.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return false;
        }

        protected override bool cargarBusqueda()
        {
            if (frmBusquedaEntrada == null)
                frmBusquedaEntrada = new frmBusquedaEntrada();

            DialogResult res = frmBusquedaEntrada.ShowDialog();

            if (res == DialogResult.OK)
            {
                entrada = frmBusquedaEntrada.entradaSeleccionada;
                cboArticulo.SelectedIndex = cboArticulo.FindStringExact(entrada.Lote.TipoArticulo.nombre);
                cboLote.SelectedIndex = cboLote.FindStringExact(entrada.Lote.numero.ToString());                
                cboPresentacion.SelectedIndex = cboPresentacion.FindStringExact("x " + entrada.Presentacion.litrosEnvase.ToString());
                txtCantidad.Text = entrada.cantidad.ToString();
                txtConcepto.Text = entrada.concepto.ToString();
                dtpFecha.Value = entrada.fecha;
                if (entrada.Lote.numero.Substring(0, 3) == "MP-")
                    cboTipo.Text = "Materia Prima / Insumos";                    
                else
                    cboTipo.Text = "Productos";

                return true;
            }

            return false;
        }

        private void lnkNuevoLote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLotes f = new frmLotes();
            f.ShowDialog();
            cboArticulo_SelectedIndexChanged(sender, e);
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {            
            cboLote.Visible = (cboTipo.Text == "Productos");
            lblLote.Visible = (cboTipo.Text == "Productos");

            if (cboTipo.Text != "Productos")
                lblUnidad.Text = "";

        }

        private void cboArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoArticulo tipoArt = cboArticulo.SelectedItem != null ? ((TipoArticulo)((ComboBoxItem)cboArticulo.SelectedItem).Value) : null;
            if (tipoArt != null)
            {
                Cargador.cargarLotes(cboLote, tipoArt, 3);
                lblUnidad.Text = tipoArt.Unidad1 != null ? tipoArt.Unidad1.abreviatura : "Sin unidad";
            }
            else
            {
                cboLote.Items.Clear();
            }                
        }

    }
}
