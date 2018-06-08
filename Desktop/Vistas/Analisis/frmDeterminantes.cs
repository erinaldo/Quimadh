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
    public partial class frmDeterminantes : FormBaseConToolbar
    {
        private Determinante Determinante;

        public frmDeterminantes()
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
            cboGrupo.SelectedIndex = 0;
        }

        protected override void agregar()
        {
            Determinante = new Determinante();
            limpiarControles(gpbDatos);
            gpbDatos.Enabled = true;
            cboGrupo.SelectedIndex = 0;
            txtNombre.Focus();
        }

        protected override void modificar()
        {
            gpbDatos.Enabled = true;
            txtNombre.Focus();
        }

        protected override bool guardar()
        {
            Determinante.nombre = txtNombre.Text;
            Determinante.unidad = txtUnidad.Text;
            Determinante.grupo = short.Parse(cboGrupo.Text);

            try
            {
                string cadenaMensaje = "";

                // Guardamos los datos del Determinante
                if (Estado == Estados.Agregar)
                {
                    Determinante = Global.Servicio.agregarDeterminante(Determinante, Global.DatosSesion);
                    cadenaMensaje = "Determinante dado de Alta exitosamente.";
                }
                else
                {
                    Global.Servicio.actualizarDeterminante(Determinante, Global.DatosSesion);
                    cadenaMensaje = "Determinante Modificado con éxito.";
                }

                // Mostramos mensaje de éxito
                Mensaje mensaje = new Mensaje(cadenaMensaje, Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                mensaje.ShowDialog();
                // Indica que el Determinante se guardó correctamente
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
            if (Determinante != null)
            {
                Mensaje mensajeConfirmacion = new Mensaje("El Determinante '" + Determinante.nombre + "' será eliminado ¿Está seguro?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                mensajeConfirmacion.ShowDialog();

                if (mensajeConfirmacion.resultado == DialogResult.OK)
                {
                    try
                    {
                        Mensaje mensajeExito;
                        //se pudo eliminar Determinante físicamente
                        Global.Servicio.eliminarDeterminante(Determinante, Global.DatosSesion);
                        mensajeExito = new Mensaje("El Determinante ha sido eliminado con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
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
                Mensaje unMensaje = new Mensaje("Debe seleccionar un determinante.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
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
            frmBusquedaDeterminantes frmBusquedaArticulo = new frmBusquedaDeterminantes();
            DialogResult res = frmBusquedaArticulo.ShowDialog();

            if (res == DialogResult.OK)
            {
                Determinante = frmBusquedaArticulo.Determinante;
                txtNombre.Text = Determinante.nombre;
                txtUnidad.Text = Determinante.unidad;
                cboGrupo.SelectedIndex = cboGrupo.FindString(Determinante.grupo.ToString());

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
