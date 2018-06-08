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
    public partial class frmLotes : FormBaseConToolbar
    {
        private Lote lote;        

        public frmLotes()
        {
            InitializeComponent();
        }

        protected override void cargar()
        {
            Cargador.cargarArticulos(cboArticulo,"Sin Seleccionar...");
            Cargador.cargarUnidades(cboUnidad, "Sin Seleccionar...");
            //cboArticulo.SelectedIndex = -1;
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Abierto");
            cboEstado.Items.Add("Cerrado");
            cboEstado.SelectedIndex = 0;
            gpbDatos.Enabled = false;
        }

        protected override void agregar()
        {
            lote = new Lote();
            limpiarControles(gpbDatos);            
            cargar();
            cboEstado.Enabled = false;
            cboEstado.SelectedText = "Abierto";
            dtpFechaCierre.Visible = false;
            gpbDatos.Enabled = true;
        }

        protected override void modificar()
        {
            gpbDatos.Enabled = true;
            cboEstado.Enabled = true;
            cboArticulo.Focus();
        }

        protected override bool guardar()
        {
            try
            {
                lote.idTipoArticulo = cboArticulo.SelectedIndex != 0 ? ((TipoArticulo)((ComboBoxItem)cboArticulo.SelectedItem).Value).id : -1;
                lote.numero = txtNroLote.Text;
                lote.fechaElaboracion = dtpFechaElab.Value;
                lote.fechaVencimiento = dtpFechaVto.Value;
                //lote.idUnidad = cboUnidad.SelectedIndex != 0 ? ((Unidad)((ComboBoxItem)cboUnidad.SelectedItem).Value).id : -1;

                if (Estado == Estados.Agregar)
                {
                    lote.fechaInicio = DateTime.Now;
                    lote.fechaCierre = null;
                    Global.Servicio.agregarLote(lote, Global.DatosSesion);
                }
                else
                {
                    if (cboEstado.Text == "Cerrado")
                        lote.fechaCierre = dtpFechaCierre.Value;
                    else
                        lote.fechaCierre = null;

                    Global.Servicio.actualizarLote(lote, Global.DatosSesion);
                }
                
                Mensaje mensajeExito;
                mensajeExito = new Mensaje("El lote ha sido cargado con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                mensajeExito.ShowDialog();
                return true;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
                return false;
            }
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

        protected override bool cargarBusqueda()
        {
            frmBusquedaLote frmBusquedaLote = new frmBusquedaLote();
            DialogResult res = frmBusquedaLote.ShowDialog();

            if (res == DialogResult.OK)
            {
                lote = frmBusquedaLote.loteSeleccionado;
                cboArticulo.SelectedIndex = cboArticulo.FindStringExact(lote.TipoArticulo.nombre);
                txtNroLote.Text = lote.numero;
                cboEstado.Text = lote.fechaCierre == null ? "Abierto" : "Cerrado";
                dtpFechaInicio.Value = lote.fechaInicio;
                //cboUnidad.SelectedIndex = cboUnidad.FindStringExact(lote.Unidad.nombre);
                
                if (lote.fechaCierre != null)
                    dtpFechaCierre.Value = (DateTime)lote.fechaCierre;
                
                //if (lote.numero.Substring(0,3) != "MP-")
                //{
                dtpFechaElab.Value = (DateTime)lote.fechaElaboracion;
                dtpFechaVto.Value = (DateTime)lote.fechaVencimiento; 
                //}
                return true;
            }

            return false;
        }

        protected override bool eliminar()
        {
            if (lote != null)
            {
                Mensaje mensajeConfirmacion = new Mensaje("El lote será eliminado ¿Está seguro?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                mensajeConfirmacion.ShowDialog();

                if (mensajeConfirmacion.resultado == DialogResult.OK)
                {
                    try
                    {
                        Mensaje mensajeExito;
                        Global.Servicio.eliminarLote(lote, Global.DatosSesion);
                        mensajeExito = new Mensaje("El lote nro. " + lote.numero + " ha sido eliminado con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
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
                Mensaje unMensaje = new Mensaje("Debe seleccionar un lote.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return false;
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpFechaCierre.Visible = (cboEstado.Text == "Cerrado");
            lblFecCierre.Visible = (cboEstado.Text == "Cerrado");
        }
    }
}
