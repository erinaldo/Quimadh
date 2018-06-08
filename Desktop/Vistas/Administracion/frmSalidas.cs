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
    public partial class frmSalidas : FormBaseConToolbar
    {
        private Salida salida;
        private frmBusquedaSalida frmBusquedaSalida;

        public frmSalidas()
        {
            InitializeComponent();
        }

        protected override void cargar()
        {
            Cargador.cargarArticulos(cboArticulo, "Sin Seleccionar...");
            Cargador.cargarPresentaciones(cboPresentacion, "Sin Seleccionar...");
            Cargador.cargarClientes(cboCliente, "Sin Seleccionar...");
            cboTipo.Items.Clear();
            cboTipo.Items.Add("Productos");
            cboTipo.Items.Add("Materia Prima / Insumos");
            cboTipo.SelectedIndex = 0;
            Cargador.cargarVendedores(cboVendedor, "Sin Seleccionar...", Global.Servicio.ObtenerNombresVendedores());
            gpbDatos.Enabled = false;
        }

        protected override void agregar()
        {
            salida = new Salida();
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
                    salida.Lote = cboLote.SelectedItem != null ? ((Lote)((ComboBoxItem)cboLote.SelectedItem).Value) : null;
                }
                else
                {
                    Lote loteMp = cboArticulo.SelectedIndex != 0 ? (Global.Servicio.obtenerLoteMateriaPrima((TipoArticulo)((ComboBoxItem)cboArticulo.SelectedItem).Value, Global.DatosSesion)) : null;
                    salida.Lote = loteMp;
                }
                //if (cboPresentacion.SelectedIndex != 0)
                salida.idPresentacion = cboPresentacion.SelectedIndex != 0 ? ((Presentacion)((ComboBoxItem)cboPresentacion.SelectedItem).Value).id : (int?)null;
                salida.cantidad = decimal.Parse(txtCantidad.Text != "" ? txtCantidad.Text : "0");
                salida.fecha = dtpFecha.Value;
                //if (cboVendedor.SelectedItem != null && ((ComboBoxItem)cboVendedor.SelectedItem).Value != null)
                if (cboVendedor.Text != "Sin Seleccionar..." && !string.IsNullOrWhiteSpace(cboVendedor.Text))
                    salida.nombreVendedor = cboVendedor.Text;
                else
                    salida.nombreVendedor = "";
                salida.idCliente = cboCliente.SelectedIndex > 0 ? ((Cliente)((ComboBoxItem)cboCliente.SelectedItem).Value).id : (long?)null;                

                string cadenaMensaje = "";

                if (Estado == Estados.Agregar)
                {
                    salida = Global.Servicio.agregarSalida(salida, Global.DatosSesion);
                    cadenaMensaje = "Salida dada de alta exitosamente.";
                }
                else
                {
                    Global.Servicio.actualizarSalida(salida, Global.DatosSesion);
                    cadenaMensaje = "Salida modificada con éxito.";
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
            if (salida != null)
            {
                Mensaje mensajeConfirmacion = new Mensaje("La salida será eliminada ¿Está seguro?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                mensajeConfirmacion.ShowDialog();

                if (mensajeConfirmacion.resultado == DialogResult.OK)
                {
                    try
                    {
                        Mensaje mensajeExito;
                        Global.Servicio.eliminarSalida(salida, Global.DatosSesion);
                        mensajeExito = new Mensaje("La salida ha sido eliminada con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
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
                Mensaje unMensaje = new Mensaje("Debe seleccionar una salida.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return false;
        }

        protected override bool cargarBusqueda()
        {
            if (frmBusquedaSalida == null)
                frmBusquedaSalida = new frmBusquedaSalida();

            DialogResult res = frmBusquedaSalida.ShowDialog();

            if (res == DialogResult.OK)
            {
                Cargador.cargarVendedores(cboVendedor, "", Global.Servicio.ObtenerNombresVendedores());
                salida = frmBusquedaSalida.salidaSeleccionada;
                if (salida.Cliente != null)
                {
                    //string clienteNombre = Global.Servicio.obtenerTodosClientes(int.MaxValue).Where(c => c.id == salida.idCliente).First().razonSocial;
                    cboCliente.SelectedIndex = cboCliente.FindStringExact(salida.Cliente.razonSocial);
                }
                else
                {
                    cboCliente.SelectedIndex = -1;
                }
                cboTipo.SelectedIndex = salida.Lote.numero.Substring(0,3) == "MP-" ? 1:0;
                cboArticulo.SelectedIndex = cboArticulo.FindStringExact(salida.Lote.TipoArticulo.nombre);
                cboLote.SelectedIndex = cboLote.FindStringExact(salida.Lote.numero.ToString());                
                cboPresentacion.SelectedIndex = cboPresentacion.FindStringExact(salida.Presentacion == null ? "Sin seleccionar...": "x " + salida.Presentacion.litrosEnvase.ToString());
                txtCantidad.Text = salida.cantidad.ToString();
                dtpFecha.Value = salida.fecha.Value;                
                cboVendedor.SelectedIndex = cboVendedor.FindStringExact(salida.nombreVendedor);

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

        private void frmSalidas_Load(object sender, EventArgs e)
        {

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboLote.Visible = (cboTipo.Text == "Productos");
            lblLote.Visible = (cboTipo.Text == "Productos");

            if (cboTipo.Text != "Productos")
                lblUnidad.Text = "";
        }
    }
}
