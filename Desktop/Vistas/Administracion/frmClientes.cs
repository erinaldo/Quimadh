using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frontend.Controles;
using Entidades;
using Controles;

namespace Desktop.Vistas.Administracion
{
    public partial class frmClientes : FormBaseConToolbar
    {
        private Cliente cliente;
        private Planta[] plantasClienteAnt;

        public frmClientes()
        {
            InitializeComponent();
            //cboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
        }

        public void automatizarClienteReducido(string razonSocial, string direccion, string nombrePlanta)
        {
            Localidad l = Global.Servicio.buscaUnaLocalidad("SANTA FE");
            SituacionFrenteIva sfi = Global.Servicio.obtenerTodosSitIva().Where(s => s.nombre.Equals("Consumidor Final")).First();
            Planta p = new Planta();
            Cliente c = new Cliente();
            c.razonSocial = razonSocial;
            c.direccion = direccion;
            c.idSituacionFrenteIva = sfi.id;
            c.idLocalidad = l.id;
            c.nombreContacto = "";
            c.cargoContacto = "";
            c.cuit = "";
            c.telefono = "";
            c.telefono2 = "";
            c.fax = "";
            c.email = "";
            c.fechaAlta = DateTime.Now;
            c.fechaBaja = null;
            p.nombre = nombrePlanta;
            p.codigo = nombrePlanta.Substring(0, Math.Min(nombrePlanta.Length, 5));
            p.direccion = "";           
            c.Planta.Add(p);

            Global.Servicio.agregarCliente(c, Global.DatosSesion);

            cliente = Global.Servicio.buscarClientes(razonSocial, "", 100).Where(cli => cli.direccion.Equals(direccion) && cli.idSituacionFrenteIva == sfi.id && cli.idLocalidad == l.id).First();
            plantasClienteAnt = new Planta[cliente.Planta.Count()];
            cliente.Planta.CopyTo(plantasClienteAnt, 0);
            cambiarEstado(Estados.Consultar);
            cargarDatos(cliente);
            this.ShowDialog();
        }

        public override void usuarioAutorizado()
        {
            //Seguridad.tienePermisos(this.GetType().Name, Global.Formularios);
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
            cliente.nombreContacto = txtNomContacto.Text;
            cliente.cargoContacto = txtCargoContacto.Text;
            cliente.direccion = txtDireccion.Text;
            cliente.telefono = txtTelefono.Text;
            cliente.telefono2 = txtTel2.Text;
            cliente.fax = txtFax.Text;
            cliente.email = txtEmail.Text;
            cliente.idSituacionFrenteIva = cboSitIva.SelectedItem !=null ? ((SituacionFrenteIva)((ComboBoxItem)cboSitIva.SelectedItem).Value).id : -1;
            cliente.idLocalidad = (cboLocalidad.SelectedItem != "Seleccionar" && cboLocalidad.SelectedItem !=null) ? ((Localidad)((ComboBoxItem)cboLocalidad.SelectedItem).Value).id : -1;

            cliente.fechaAlta = DateTime.Now;
            cliente.Planta.Clear();
            foreach (DataGridViewRow fila in dgvPlantas.Rows)
            {
                if (!fila.IsNewRow)
                {
                    Planta planta;
                    planta = (Planta)fila.Tag;  

                    cliente.Planta.Add(planta);
                }            
            }

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
                // Indica que el Cliente se guardó correctamente

                plantasClienteAnt = new Planta[cliente.Planta.Count()];
                cliente.Planta.CopyTo(plantasClienteAnt,0);

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
                cliente.Planta = (ICollection<Planta>)plantasClienteAnt.ToList();
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
                plantasClienteAnt = new Planta[cliente.Planta.Count()];                   
                cliente.Planta.CopyTo(plantasClienteAnt,0);
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
            txtNomContacto.Text = cliente.nombreContacto;
            txtCUIT.Text = cliente.cuit;
            txtCargoContacto.Text = cliente.cargoContacto;
            txtDireccion.Text = cliente.direccion;
            txtFax.Text = cliente.fax;
            txtTelefono.Text = cliente.telefono;
            txtTel2.Text = cliente.telefono2;
            txtEmail.Text = cliente.email;
            cboLocalidad.SelectedIndex = cboLocalidad.FindStringExact(cliente.Localidad.nombre);
            cboSitIva.SelectedIndex = cboSitIva.FindStringExact(cliente.SituacionFrenteIva.nombre);

            dgvPlantas.Rows.Clear();
            int i = 0;
            foreach (Planta planta in cliente.Planta)
            {
                dgvPlantas.Rows.Add();
                dgvPlantas.Rows[i].Tag = planta;
                dgvPlantas.Rows[i].Cells["clmId"].Value = planta.id.ToString();
                dgvPlantas.Rows[i].Cells["clmCodigo"].Value = planta.codigo.ToString();
                dgvPlantas.Rows[i].Cells["clmDescrip"].Value = planta.nombre.ToString();
                dgvPlantas.Rows[i].Cells["clmDirPlanta"].Value = planta.direccion == null ? "" : planta.direccion.ToString();
                dgvPlantas.Rows[i].Cells["clmLocalidad"].Value = planta.Localidad == null ? "" : planta.Localidad.nombre;
                i++;
            }
        }

        private void dgvPlantas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPlantas.CurrentCell.OwningColumn.Name == "clmEditar")
            {
                frmPlanta formPlanta = new frmPlanta(this,cliente, (Planta)(dgvPlantas.Rows[e.RowIndex].Tag), "m");
                formPlanta.ShowDialog();
            }

            if (dgvPlantas.CurrentCell.OwningColumn.Name == "clmEliminar")
            {
                Mensaje pregunta = new Mensaje("¿Está seguro que desea eliminar la planta " + ((Planta)dgvPlantas.Rows[e.RowIndex].Tag).codigo + "?", Mensaje.TipoMensaje.Alerta , Mensaje.Botones.SiNo);
                pregunta.ShowDialog();
                if (pregunta.resultado == DialogResult.OK)
                {
                    cliente.Planta.Remove((Planta)dgvPlantas.Rows[e.RowIndex].Tag);
                    cargarDatos(cliente);
                }
            }
        }

        private void btnNuevaPlanta_Click(object sender, EventArgs e)
        {
            if (cliente.razonSocial == null)
            {
                Mensaje unMensaje = new Mensaje("Debe seleccionar un cliente.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
                return;
            }
            frmPlanta formPlanta = new frmPlanta(this,cliente, null, "a");
            formPlanta.ShowDialog();
        }

        private void frmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (plantasClienteAnt != null)
                cliente.Planta = (ICollection<Planta>)plantasClienteAnt.ToList();
        }

    }
}
