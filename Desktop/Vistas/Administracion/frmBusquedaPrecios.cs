using Controles;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Desktop.Vistas.Administracion
{
    public partial class frmBusquedaPrecios : FormBusqueda
    {
        public ArticuloPlanta articuloSeleccionado { get; set; }
        private Cliente cliente;

        public frmBusquedaPrecios()
        {
            InitializeComponent();
        }

        protected override void cargar()
        {
            Cargador.cargarPlantas(cboPlanta, "Sin seleccionar");
            Cargador.cargarClientes(cboCliente, "Sin especificar");       
            Cargador.cargarArticulos(cboArticulo, "Sin seleccionar");
            Cargador.cargarMonedas(cboMoneda, "Sin seleccionar");
        }

        protected override bool buscar(int numeroRegistros, bool esBusquedaInicial)
        {
            // Obtenemos los datos de búsqueda
            string nombre = txtPrecioInicial.Text.Trim();
            string codigo = txtCodigo.Text;
            Moneda unidad = cboMoneda.SelectedItem != null && !cboMoneda.SelectedItem.ToString().Equals("Sin especificar") ? ((Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value) : null;
            Planta planta = cboPlanta.SelectedItem != null && !cboPlanta.SelectedItem.ToString().Equals("Sin especificar") ? ((Planta)((ComboBoxItem)cboPlanta.SelectedItem).Value) : null;
            TipoArticulo tipoArticulo = cboArticulo.SelectedItem != null && !cboArticulo.SelectedItem.ToString().Equals("Sin especificar") ? ((TipoArticulo)((ComboBoxItem)cboArticulo.SelectedItem).Value) : null;

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
                decimal precioInicial = 0;

                decimal.TryParse(txtPrecioInicial.Text, out precioInicial);

                // Obtenemos el resultado
                List<ArticuloPlanta> resultado = Global.Servicio.BuscarArticulosPlanta(tipoArticulo, cliente, planta, precioInicial, codigo, chkMostraEliminados.Checked, numeroRegistros);

                // Listamos los artículos
                foreach (ArticuloPlanta articulo in resultado)
                {
                    string[] datos = new string[] { articulo.Planta.codigo + articulo.contador.ToString(), articulo.Planta.nombre, articulo.TipoArticulo.nombre,
                        articulo.Moneda.nombre, articulo.precio.ToString(), articulo.fechaCambio.ToShortDateString(), articulo.eliminado.HasValue ? "SI" : "NO" };
                    ListViewItem item = new ListViewItem(datos);
                    item.Tag = articulo;
                    ltvBusqueda.Items.Add(item);
                }

                if (chkMostrarHistorico.Checked && numeroRegistros - resultado.Count > 0)
                {
                    // Obtenemos el resultado
                    List<ArticuloPlantaHistorico> result = Global.Servicio.BuscarArticulosPlantaHistorico(tipoArticulo, planta, precioInicial, codigo, chkMostraEliminados.Checked, numeroRegistros - resultado.Count);

                    // Listamos los artículos
                    foreach (ArticuloPlantaHistorico articulo in result)
                    {
                        string[] datos = new string[] { articulo.ArticuloPlanta.Planta.codigo + articulo.ArticuloPlanta.contador.ToString(), articulo.ArticuloPlanta.Planta.nombre, articulo.ArticuloPlanta.TipoArticulo.nombre, articulo.ArticuloPlanta.Moneda.nombre,
                            articulo.precio.ToString(), articulo.fechaCambio.ToShortDateString(), articulo.ArticuloPlanta.eliminado.HasValue ? "SI" : "NO"};
                        ListViewItem item = new ListViewItem(datos);
                        item.Tag = articulo;
                        ltvBusqueda.Items.Add(item);
                    }
                }

                if (resultado.Count <= 0 && !esBusquedaInicial)
                {
                    Mensaje mensaje = new Mensaje("Sin resultados.", Mensaje.TipoMensaje.Informacion, Mensaje.Botones.OK);
                    mensaje.ShowDialog();
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
                List<ArticuloPlanta> resultado = Global.Servicio.ObtenerTodosArticulosPlanta(1);

                return (resultado.Count > 0);
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
            // Si seleccionó al menos un cliente
            if (ltvBusqueda.SelectedItems.Count > 0)
            {
                object tag = ltvBusqueda.SelectedItems[0].Tag;

                if (tag != null)
                {
                    try
                    {
                        tag = ((ArticuloPlantaHistorico)tag).ArticuloPlanta;
                    }catch(Exception ex) {}

                    articuloSeleccionado = (ArticuloPlanta)tag;

                    this.DialogResult = DialogResult.OK;

                    this.Close();

                    return true;
                }
            }

            Mensaje mensaje = new Mensaje("Debe seleccionar un Artículo.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
            mensaje.ShowDialog();

            return false;
        }

        protected override void limpiar()
        {
            base.limpiar();

            cboPlanta.SelectedIndex = 0;
            cboArticulo.SelectedIndex = 0;
            cboMoneda.SelectedIndex = 0;
            txtPrecioInicial.Text = "";
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
    }
}
