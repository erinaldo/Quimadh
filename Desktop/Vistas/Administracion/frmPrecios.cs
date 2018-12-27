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
    public partial class frmPrecios : FormBaseConToolbar
    {
        private ArticuloPlanta ArticuloPlanta;
        private Cliente cliente;

        public frmPrecios()
        {
            InitializeComponent();
        }

        public override void usuarioAutorizado()
        {
            //Seguridad.tienePermisos(this.GetType().Name, Global.Formularios);
        }

        protected override void cargar()
        {
            Cargador.cargarArticulos(cboArticulo);
            Cargador.cargarPlantas(cboPlanta, "Sin especificar");    
            Cargador.cargarClientes(cboCliente, "Sin especificar");                    
            Cargador.cargarMonedas(cboMoneda);
            
            gpbPrecios.Enabled = false;
            dgvPrecios.Enabled = false;
        }

        protected override void agregar()
        {
            ArticuloPlanta = new ArticuloPlanta();
            limpiarControles(gpbPrecios);
            dgvPrecios.Rows.Clear();
            dgvPreciosHist.Rows.Clear();
            gpbPrecios.Enabled = true;
            dgvPrecios.Enabled = true;
            cboMoneda.SelectedIndex = 0;
            cboCliente.SelectedIndex = 0;
            Cargador.cargarPlantas(cboPlanta, "Sin especificar");
            cboPlanta.SelectedIndex = 0;
            cboCliente.Focus();
        }

        protected override void modificar()
        {
            gpbPrecios.Enabled = true;
            dgvPrecios.Enabled = true;
            cboPlanta.Focus();
        }

        protected override bool guardar()
        {
            if (cboPlanta.Text.ToLower() == "sin especificar" || cboPlanta.SelectedItem == null)
            {
                Mensaje mensaje = new Mensaje("Seleccione una planta", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                mensaje.ShowDialog();
                return false;
            }
            if (cboArticulo.Text.ToLower() == "sin especificar" || cboArticulo.SelectedItem == null)
            {
                Mensaje mensaje = new Mensaje("Seleccione un artículo", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                mensaje.ShowDialog();
                return false;
            }

            ArticuloPlantaHistorico aph = new ArticuloPlantaHistorico();
            if (Estado == Estados.Modificar)
            {
                aph.ArticuloPlanta = ArticuloPlanta;
                aph.idMoneda = ArticuloPlanta.idMoneda;
                aph.precio = ArticuloPlanta.precio;
                aph.fechaCambio = ArticuloPlanta.fechaCambio;
            }

            ArticuloPlanta.idArticulo = cboArticulo.SelectedItem != null ? ((TipoArticulo)((ComboBoxItem)cboArticulo.SelectedItem).Value).id : -1;
            ArticuloPlanta.idPlanta = cboPlanta.SelectedItem != null ? ((Planta)((ComboBoxItem)cboPlanta.SelectedItem).Value).id : -1;
            ArticuloPlanta.idMoneda = cboMoneda.SelectedItem != null ? ((Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value).id : -1;
            ArticuloPlanta.precio = decimal.Parse(txtPrecioInicial.Text);
            ArticuloPlanta.fechaCambio = DateTime.Now;

            try
            {
                string cadenaMensaje = "";

                //Guarda los precios adicionales
                ArticuloPlanta.PreciosAdicionales.Clear();
                foreach (DataGridViewRow fila in dgvPrecios.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        Presentacion present = (Presentacion)fila.Cells["clmPresent"].Tag;
                        PreciosAdicionales precioAdicional = new PreciosAdicionales();
                        if (present != null)
                        {
                            precioAdicional.Presentacion = present;
                            precioAdicional.precio = decimal.Parse(fila.Cells["clmPrecio"].FormattedValue.ToString());
                            ArticuloPlanta.PreciosAdicionales.Add(precioAdicional);
                        }
                    }
                }

                // Guardamos los datos del ArticuloPlanta
                if (Estado == Estados.Agregar)
                {
                    ArticuloPlanta = Global.Servicio.agregarArticuloPlanta(ArticuloPlanta, Global.DatosSesion);
                    cadenaMensaje = "Precio dado de Alta exitosamente.";
                }
                else
                {
                    Global.Servicio.actualizarArticuloPlanta(ArticuloPlanta, aph, Global.DatosSesion);                    
                    cadenaMensaje = "Precio Modificado con éxito.";                    
                }
                
                lblUltimaModificacion.Text = "Última modificación: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                CargarPreciosHist();

                // Mostramos mensaje de éxito
                Mensaje mensaje = new Mensaje(cadenaMensaje, Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                mensaje.ShowDialog();
                // Indica que el ArticuloPlanta se guardó correctamente
                return true;
            }      
            catch (Exception ex)
            {
                Mensaje unMensaje;

                if (ex.Message.Contains("key")) //Ver si la excepcion es del tipo System.InvalidOperationException
                {
                    unMensaje = new Mensaje("No es posible cambiar la Planta o el Artículo a una relación ya cargada.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    unMensaje.ShowDialog();
                }
                else
                {
                    unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    unMensaje.ShowDialog();
                }
            }

            return false;
        }

        protected override bool eliminar()
        {
            if (ArticuloPlanta != null)
            {
                Mensaje mensajeConfirmacion = new Mensaje("El precio del artículo '" + ArticuloPlanta.TipoArticulo.nombre + "' para la planta '" + ArticuloPlanta.Planta.nombre + "' será eliminado ¿Está seguro?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                mensajeConfirmacion.ShowDialog();

                if (mensajeConfirmacion.resultado == DialogResult.OK)
                {
                    try
                    {
                        Mensaje mensajeExito;
                        //se pudo eliminar ArticuloPlanta físicamente
                        Global.Servicio.eliminarArticuloPlanta(ArticuloPlanta, Global.DatosSesion);
                        mensajeExito = new Mensaje("El precio ha sido eliminado con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
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
                Mensaje unMensaje = new Mensaje("Debe seleccionar un artículo-planta.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return false;
        }

        protected override void limpiar()
        {
            if (Estado != Estados.Modificar)
            {
                // Limpia los datos del formulario
                limpiarControles(gpbPrecios);
                lblUltimaModificacion.Text = "Última modificación: ";
            }
            gpbPrecios.Enabled = false;
            dgvPrecios.Enabled = false;
        }

        protected override bool cargarBusqueda()
        {
            frmBusquedaPrecios frmBusquedaArticulo = new frmBusquedaPrecios();
            DialogResult res = frmBusquedaArticulo.ShowDialog();
            lblUltimaModificacion.Text = "Última modificación: ";

            if (res == DialogResult.OK)
            {
                ArticuloPlanta = frmBusquedaArticulo.articuloSeleccionado;
                txtPrecioInicial.Text = ArticuloPlanta.precio.ToString();
                cboMoneda.SelectedIndex = cboMoneda.FindStringExact(ArticuloPlanta.Moneda.nombre);
                if (ArticuloPlanta.Planta.Cliente != null)
                    cboCliente.SelectedIndex = cboCliente.FindStringExact(ArticuloPlanta.Planta.Cliente.razonSocial);
                else
                {
                    Cargador.cargarPlantas(cboPlanta, "Sin especificar");
                    Cargador.cargarClientes(cboCliente, "Sin especificar");      
                    cboCliente.SelectedIndex = 0;
                }
                    
                cboPlanta.SelectedIndex = cboPlanta.FindStringExact(ArticuloPlanta.Planta.nombre);                
                cboArticulo.SelectedIndex = cboArticulo.FindStringExact(ArticuloPlanta.TipoArticulo.nombre);
                txtNumero.Text = ArticuloPlanta.Planta.codigo + ArticuloPlanta.contador.ToString();
                lblUltimaModificacion.Text = "Última modificación: " + ArticuloPlanta.fechaCambio.ToShortDateString() + " " + ArticuloPlanta.fechaCambio.ToShortTimeString();

                cboMoneda_SelectedIndexChanged(null, null);
                txtPrecioInicial_KeyUp(null, null);

                int i = 0;
                dgvPrecios.Rows.Clear();
                foreach(PreciosAdicionales pa in ArticuloPlanta.PreciosAdicionales)
                {
                    dgvPrecios.Rows.Add();
                    dgvPrecios.Rows[i].Cells["clmPresent"].Value = "x " + pa.Presentacion.litrosEnvase.ToString();
                    dgvPrecios.Rows[i].Cells["clmPresent"].Tag = pa.Presentacion;
                    dgvPrecios.Rows[i].Cells["clmPrecio"].Value = pa.precio.ToString("0.00");

                    i++;
                }

                CargarPreciosHist();

                return true;
            }

            return false;
        }

        private void CargarPreciosHist()
        {
            int j = 0;
            var preciosHist = ArticuloPlanta.ArticuloPlantaHistorico.OrderByDescending(ap => ap.fechaCambio).Take(2).ToList();
            dgvPreciosHist.Rows.Clear();
            foreach (ArticuloPlantaHistorico ph in preciosHist)
            {
                dgvPreciosHist.Rows.Add();
                dgvPreciosHist.Rows[j].Cells["clmFecha"].Value = ph.fechaCambio;
                dgvPreciosHist.Rows[j].Cells["clmMoneda"].Value = ph.Moneda.simbologia;
                dgvPreciosHist.Rows[j].Cells["clmPrecioHist"].Value = ph.precio;

                j++;
            }
        }

        private bool validar()
        {
            return false;
        }

        private void cboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtCotizacion.Text =  ((Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value).cotizacion.ToString();
        }

        private void txtPrecioInicial_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txtIVA.Text = (decimal.Parse(txtPrecioInicial.Text) * decimal.Parse("0.21")).ToString();
                txtPrecioFinal.Text = (decimal.Parse(txtIVA.Text) + decimal.Parse(txtPrecioInicial.Text)).ToString();
            }
            catch (Exception ex)
            { }
        }

        private void cboPlanta_SelectedIndexChanged(object sender, EventArgs e)
        {
            long idPlanta = cboPlanta.SelectedItem != null && !cboPlanta.SelectedItem.ToString().Equals("Sin especificar") ? ((Planta)((ComboBoxItem)cboPlanta.SelectedItem).Value).id : -1;
            if (idPlanta != -1)
                txtNumero.Text = Global.Servicio.obtenerProximoNumero(idPlanta).ToString();
            else
                txtNumero.Text = "";
        }

        private void cboArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoArticulo articulo = cboArticulo.SelectedItem != null ? ((TipoArticulo)((ComboBoxItem)cboArticulo.SelectedItem).Value) : null;

            if (articulo != null)
                txtUnidad.Text = Global.Servicio.obtenerUnidades().Where(u => u.id == articulo.idUnidad).First().abreviatura;
            else
                txtUnidad.Text = "";
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

        private void dgvPrecios_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvPrecios.CurrentCell.OwningColumn.Name == "clmPresent")
            {
                TextBox celda = e.Control as TextBox;
                Cargador.cargarPresentaciones(celda);
            }
        }

        private void dgvPrecios_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPrecios.EditingControl == null)
                return;

            if (dgvPrecios[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmPresent")
            {
                string[] textoCelda = dgvPrecios.EditingControl.Text.Split(new string[] { "x " }, StringSplitOptions.None);
                int litros = 0;
                if (textoCelda.Count() == 2)
                    int.TryParse(textoCelda[1], out litros);

                if (litros != 0)
                {
                    Presentacion present = Global.Servicio.obtenerPresentacionPorLitros(litros);
                    if (present != null)
                        dgvPrecios[e.ColumnIndex, e.RowIndex].Tag = present;
                    else
                    {
                        dgvPrecios[e.ColumnIndex, e.RowIndex].Tag = null;
                        dgvPrecios.EditingControl.Text = "";
                    }
                }
                else
                {
                    dgvPrecios[e.ColumnIndex, e.RowIndex].Tag = null;
                    dgvPrecios.EditingControl.Text = "";
                }
            }

            if (dgvPrecios[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmPrecio")
            {
                decimal val;
                if (decimal.TryParse(dgvPrecios.EditingControl.Text, out val))
                {
                    dgvPrecios.EditingControl.Text = val.ToString("0.00");
                }
                else
                {
                    dgvPrecios.EditingControl.Text = "0";
                }
            }
        }

    }
}
