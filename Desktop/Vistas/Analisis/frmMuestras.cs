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

namespace Desktop.Vistas.Analisis
{
    public partial class frmMuestras : FormBaseConToolbar
    {
        private Muestra Muestra;

        public frmMuestras()
        {
            InitializeComponent();
        }

        public override void usuarioAutorizado()
        {
            //Seguridad.tienePermisos(this.GetType().Name, Global.Formularios);
        }

        protected override void cargar()
        {
            gpbDatos.Enabled = false;
            txtCodigo.Focus();
        }

        protected override void agregar()
        {
            Muestra = new Muestra();
            limpiarControles(gpbDatos);
            gpbDatos.Enabled = true;
            txtCodigo.Focus();
        }

        protected override void modificar()
        {
            gpbDatos.Enabled = true;
            txtCodigo.Focus();
        }

        protected override bool guardar()
        {
            Muestra.Codigo = txtCodigo.Text;
            Muestra.Descripcion = txtDescripcion.Text;

            try
            {
                string cadenaMensaje = "";

                // Guardamos los datos del Muestra
                if (Estado == Estados.Agregar)
                {
                    Muestra = Global.Servicio.agregarMuestra(Muestra, Global.DatosSesion);
                    cadenaMensaje = "Muestra dada de Alta exitosamente.";
                }
                else
                {
                    Global.Servicio.actualizarMuestra(Muestra, Global.DatosSesion);
                    cadenaMensaje = "Muestra Modificada con éxito.";
                }

                // Mostramos mensaje de éxito
                Mensaje mensaje = new Mensaje(cadenaMensaje, Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                mensaje.ShowDialog();
                // Indica que el Muestra se guardó correctamente
                return true;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje;

                unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return false;
        }

        protected override bool eliminar()
        {
            if (Muestra != null)
            {
                Mensaje mensajeConfirmacion = new Mensaje("La muestra '" + Muestra.Codigo + "' será eliminada ¿Está seguro?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                mensajeConfirmacion.ShowDialog();

                if (mensajeConfirmacion.resultado == DialogResult.OK)
                {
                    try
                    {
                        Mensaje mensajeExito;
                        //se pudo eliminar Muestra físicamente
                        Global.Servicio.eliminarMuestra(Muestra, Global.DatosSesion);
                        mensajeExito = new Mensaje("La muestra ha sido eliminada con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
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
                Mensaje unMensaje = new Mensaje("Debe seleccionar una Muestra.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
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
            // Limpia los mensajes de error
            //errProvider.Clear();
            // Fija los campos para consulta
            gpbDatos.Enabled = false;
        }

        protected override bool cargarBusqueda()
        {
            frmBusquedaMuestras frmBusquedaArticulo = new frmBusquedaMuestras();
            DialogResult res = frmBusquedaArticulo.ShowDialog();

            if (res == DialogResult.OK)
            {
                Muestra = frmBusquedaArticulo.Muestra;
                txtCodigo.Text = Muestra.Codigo;
                txtDescripcion.Text = Muestra.Descripcion;

                return true;
            }

            return false;
        }

        private bool validar()
        {
            return false;
        }

    }
}
