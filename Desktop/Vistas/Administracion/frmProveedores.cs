using Controles;
using Entidades;
using Frontend.Controles;
using System;
using System.Windows.Forms;

namespace Desktop.Vistas.Administracion
{
    public partial class frmProveedores : FormBaseConToolbar
    {
        private Cliente cliente;

        public frmProveedores()
        {
            InitializeComponent();
        }                

        protected override void cargar()
        {
            Cargador.cargarLocalidad(cboLocalidad,"Seleccionar");
            Cargador.cargarSitIva(cboSitIva);
            gpbDatos.Enabled = false;
        }

        protected override void agregar()
        {
            cliente = new Cliente();
            limpiarControles(gpbDatos);
            gpbDatos.Enabled = true;
            txtRazonSocial.Focus();
        }

        protected override void modificar()
        {
            gpbDatos.Enabled = true;
            txtRazonSocial.Focus();
        }

        protected override bool guardar()
        {
            cliente.razonSocial = txtRazonSocial.Text;
            cliente.cuit = txtCUIT.Text;
            cliente.direccion = txtDireccion.Text;
            cliente.telefono = txtTelefono.Text;
            cliente.email = txtEmail.Text;
            cliente.idSituacionFrenteIva = cboSitIva.SelectedItem !=null ? ((SituacionFrenteIva)((ComboBoxItem)cboSitIva.SelectedItem).Value).id : -1;
            cliente.idLocalidad = (cboLocalidad.SelectedItem != "Seleccionar" && cboLocalidad.SelectedItem !=null) ? ((Localidad)((ComboBoxItem)cboLocalidad.SelectedItem).Value).id : -1;

            cliente.fechaAlta = DateTime.Now;

            try
            {
                string cadenaMensaje = "";
                
                // Guardamos los datos del Cliente
                if (Estado == Estados.Agregar)
                {
                    cliente = Global.Servicio.agregarCliente(cliente, Global.DatosSesion);
                    cadenaMensaje = "Cliente dado de Alta exitosamente.";
                }
                else
                {
                    Global.Servicio.actualizarCliente(cliente, Global.DatosSesion);
                    cadenaMensaje = "Cliente Modificado con éxito.";
                }

                // Mostramos mensaje de éxito
                Mensaje mensaje = new Mensaje(string.Format(cadenaMensaje, cliente.razonSocial), Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
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

        protected override bool eliminar()
        {
            if (cliente != null)
            {
                Mensaje mensajeConfirmacion = new Mensaje("El cliente '" + cliente.razonSocial + "' será eliminado ¿Está seguro?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                mensajeConfirmacion.ShowDialog();

                if (mensajeConfirmacion.resultado == DialogResult.OK)
                {
                    try
                    {
                        Mensaje mensajeExito;
                        //se pudo eliminar Cliente físicamente
                        Global.Servicio.eliminarCliente(cliente, Global.DatosSesion);
                        mensajeExito = new Mensaje("El cliente '" + cliente.razonSocial + " ha sido eliminado con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
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
                Mensaje unMensaje = new Mensaje("Debe seleccionar un cliente.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
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
            else
            {
                cargarDatos(cliente);                
            }
            gpbDatos.Enabled = false;
        }

        protected override bool cargarBusqueda()
        {
            frmBusquedaCliente frmBusquedaCliente = new frmBusquedaCliente();
            DialogResult res = frmBusquedaCliente.ShowDialog();

            if (res == DialogResult.OK)
            {
                cliente = frmBusquedaCliente.clienteSeleccionado;
                cargarDatos(cliente);

                return true;
            }

            return false;
        }

        private bool validar()
        {
            return false;
        }

        public void cargarDatos(Cliente cliente)
        {
            txtRazonSocial.Text = cliente.razonSocial;
            txtCUIT.Text = cliente.cuit;
            txtDireccion.Text = cliente.direccion;
            txtTelefono.Text = cliente.telefono;
            txtEmail.Text = cliente.email;
            cboLocalidad.SelectedIndex = cboLocalidad.FindStringExact(cliente.Localidad.nombre);
            cboSitIva.SelectedIndex = cboSitIva.FindStringExact(cliente.SituacionFrenteIva.nombre);           
        }

    }
}
