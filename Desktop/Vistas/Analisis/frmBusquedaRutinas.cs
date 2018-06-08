using Controles;
using Entidades;
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
    public partial class frmBusquedaRutinas : FormBusqueda
    {
        public List<CabeceraRutina> rutina;
        private Planta planta;
        private Cliente cliente;

        private Boolean cargaRealizada;

        public frmBusquedaRutinas()
        {
            InitializeComponent();
            cargaRealizada = false;
        }

        protected override void cargar()
        {
            if (!cargaRealizada)
            {
                Cargador.cargarPlantas(cboPlanta, "Sin especificar");
                Cargador.cargarClientes(cboCliente, "Sin especificar");
                cboPlanta.Focus();
                dtpFechaDesde.Value = DateTime.Now.AddYears(-1);
                cargaRealizada = true;
            }                 
        }

        protected override bool buscar(int numeroRegistros, bool esBusquedaInicial)
        {
            //// Obtenemos los datos de búsqueda
            //Planta planta = cboPlanta.SelectedItem != null ? ((Planta)((ComboBoxItem)cboPlanta.SelectedItem).Value) : null;
            //Cliente cliente = null;
            
            ////Sólo en caso de que no seleccione planta se evalúa la selección del cliente
            //if (planta == null)
            //    cliente = cboCliente.SelectedItem != null ? ((Cliente)((ComboBoxItem)cboCliente.SelectedItem).Value) : null;
            //else
            //    cboCliente.SelectedIndex = -1;

            //Si en la apertura del frm no existen entidades para mostrar,
            //no debe mostrarse el frm.
            if (esBusquedaInicial && !existenEntidades())
            {
                Mensaje mensaje = new Mensaje("No existen datos cargados para la entidad.", Mensaje.TipoMensaje.Informacion, Mensaje.Botones.OK);
                mensaje.ShowDialog();
                return false;
            }

            try
            {
                // Obtenemos el resultado
                List<CabeceraRutina> resultado = Global.Servicio.buscarRutinas(cliente, planta, cboTipoRutina.Text, dtpFechaDesde.Value, dtpFechaHasta.Value, numeroRegistros);
                ltvBusqueda.Items.Clear();
                // Listamos los clientes
                foreach (CabeceraRutina cab in resultado)
                {
                    string analisis = cab.fechaAnalisis != null ? cab.fechaAnalisis.Value.ToShortDateString() : "Sin datos";
                    string muestreo = cab.fechaMuestreo != null ? cab.fechaMuestreo.Value.ToShortDateString() : "Sin datos";
                    string[] datos = new string[] { cab.id.ToString(), cab.Planta.nombre, analisis, muestreo };
                    ListViewItem item = new ListViewItem(datos);
                    item.Tag = cab;
                    ltvBusqueda.Items.Add(item);
                }

                if (resultado.Count <= 0 && !esBusquedaInicial)
                {
                    //Mensaje mensaje = new Mensaje("Sin resultados.", Mensaje.TipoMensaje.Informacion, Mensaje.Botones.OK);
                    //mensaje.ShowDialog();
                    MessageBox.Show("Sin resultados.");
                }

            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return true;
        }

        ///// <summary>
        ///// Cuando iniciamos el frm, comprueba que existan entidades cargadas para mostrar.
        ///// Para eso, se utiliza este método.
        ///// </summary>
        ///// <returns></returns>
        private bool existenEntidades()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return false;
        }

        protected override bool aceptar()
        {
            rutina = new List<CabeceraRutina>();
            // Si seleccionó al menos un cliente
            if (ltvBusqueda.SelectedItems.Count > 0)
            {
                for (int i = 0; i < ltvBusqueda.SelectedItems.Count; i++)
                {
                    object tag = ltvBusqueda.SelectedItems[i].Tag;

                    rutina.Add((CabeceraRutina)tag);
                }

                this.DialogResult = DialogResult.OK;

                //this.Close();
                this.Hide();

                return true;
            }

            Mensaje mensaje = new Mensaje("Debe seleccionar un Determinante.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
            mensaje.ShowDialog();

            return false;
        }

        protected override void limpiar()
        {
            base.limpiar();
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cliente = cboCliente.SelectedItem != null ? ((Cliente)((ComboBoxItem)cboCliente.SelectedItem).Value) : null;

            if (cliente != null)
            {
                Cargador.cargarPlantas(cboPlanta, cliente, "Sin especificar");
                cboPlanta.Enabled = true;
            }
        }

        private void cboPlanta_SelectedIndexChanged(object sender, EventArgs e)
        {
            planta = cboPlanta.SelectedItem != null ? ((Planta)((ComboBoxItem)cboPlanta.SelectedItem).Value) : null;
            //if (planta != null)
            //{
            //    cliente = planta.Cliente;
            //    //cboCliente.SelectedIndex = cboCliente.FindStringExact(cliente.razonSocial);
            //    //cboPlanta.SelectedIndex = cboPlanta.FindStringExact(planta.nombre);
            //}
        }
    }
}
