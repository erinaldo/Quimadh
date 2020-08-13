using Controles;
using Entidades;
using System;
using System.Windows.Forms;

namespace Desktop.Vistas.Administracion
{
    public partial class frmPlanta : FormBaseSinToolbar
    {
        private Planta planta;
        private Cliente cliente;
        private String abm;
        private frmClientes formPadre;

        public frmPlanta(frmClientes padre,Cliente cli,Planta pla, String abm, String nombrePlanta = "")
        {
            planta = pla;
            cliente = cli;
            this.abm = abm;
            InitializeComponent();
            formPadre = padre;
            txtNombre.Text = nombrePlanta;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Planta plantaGuardada;
            if(planta == null)
            {
                planta = new Planta();
            }

            planta.codigo = txtCodigo.Text;
            planta.nombre = txtNombre.Text;
            planta.direccion = txtDireccion.Text;
            //planta.idLocalidad = (cboLocalidad.SelectedItem != "Seleccionar" && cboLocalidad.SelectedItem != null) ? ((Localidad)((ComboBoxItem)cboLocalidad.SelectedItem).Value).id : -1;
            planta.Localidad = (cboLocalidad.SelectedItem != "Seleccionar" && cboLocalidad.SelectedItem != null) ? ((Localidad)((ComboBoxItem)cboLocalidad.SelectedItem).Value) : null;
            planta.nombreContacto1 = txtNomCont1.Text;
            planta.cargoContacto1 = txtCargoCont1.Text;
            planta.telefono1 = txtTel1.Text;
            planta.emailContac1 = txtMailCont1.Text;
            planta.nombreContacto2 = txtNomCont2.Text;
            planta.cargoContacto2 = txtCargoCont2.Text;
            planta.telefono2 = txtTel2.Text;
            planta.emailContac2 = txtMailCont2.Text;

            if (abm == "a")
            {
                //Global.Servicio.agregarPlanta(planta, Global.DatosSesion);                
                cliente.Planta.Add(planta);
                //Global.Servicio.actualizarCliente(cliente, null);
            }

            Mensaje mensajeExito;
            mensajeExito = new Mensaje("La planta '" + planta.codigo + " - " + planta.nombre.Trim() + "' ha sido guardada con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
            mensajeExito.ShowDialog();

            this.Close();
        }

        private void frmPlanta_Load(object sender, EventArgs e)
        {
            //planta = new Planta();
            Cargador.cargarLocalidad(cboLocalidad, "Seleccionar");

            if (abm == "m")
            {
                cargarDatos();
            }
        }

        private void frmPlanta_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPadre.cargarDatos(cliente);
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            planta = Global.Servicio.buscarUnaPlanta(txtCodigo.Text, "");
            if (planta != null)
            {
                if (planta.Cliente != null & planta.Cliente != cliente)
                {
                    Mensaje mensaje = new Mensaje("Esta planta ya está asociada a un cliente.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    mensaje.ShowDialog();
                    return;
                }
                cargarDatos();
            }
            
        }

        private void cargarDatos()
        {
            txtCodigo.Text = planta.codigo;
            txtNombre.Text = planta.nombre;
            txtDireccion.Text = planta.direccion;
            if (planta.Localidad != null)
            {
                cboLocalidad.SelectedIndex = cboLocalidad.FindStringExact(planta.Localidad.nombre);
            }            
            txtNomCont1.Text = planta.nombreContacto1;
            txtNomCont2.Text = planta.nombreContacto2;
            txtCargoCont1.Text = planta.cargoContacto1;
            txtCargoCont2.Text = planta.cargoContacto2;
            txtMailCont1.Text = planta.emailContac1;
            txtMailCont2.Text = planta.emailContac2;
            txtTel1.Text = planta.telefono1;
            txtTel2.Text = planta.telefono2;
        }
    }
}
