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
    public partial class frmArticulos : FormBaseConToolbar
    {
        private TipoArticulo Articulo;

        public frmArticulos()
        {
            InitializeComponent();
        }

        public override void usuarioAutorizado()
        {
            //Seguridad.tienePermisos(this.GetType().Name, Global.Formularios);
        }

        protected override void cargar()
        {
            Cargador.cargarUnidades(cboUnidad);
            Cargador.cargarUnidades(cboUnidadStock, "Sin Seleccionar...");

            gpbDatos.Enabled = false;
            dgvComposicion.Enabled = false;
        }

        protected override void agregar()
        {
            Articulo = new TipoArticulo();
            //limpiarControles(gpbDatos);
            limpiarControles(this);
            gpbDatos.Enabled = true;
            dgvComposicion.Enabled = true;
            txtNombre.Focus();
        }

        protected override void modificar()
        {
            gpbDatos.Enabled = true;
            dgvComposicion.Enabled = true;
            txtNombre.Focus();
        }

        protected override bool guardar()
        {
            Articulo.nombre = txtNombre.Text;
            Articulo.idUnidad = cboUnidad.SelectedItem != null ? ((Unidad)((ComboBoxItem)cboUnidad.SelectedItem).Value).id : -1;
            if (cboUnidadStock.SelectedIndex != 0 && cboUnidadStock.SelectedIndex !=-1)
                Articulo.idUnidadStock = ((Unidad)((ComboBoxItem)cboUnidadStock.SelectedItem).Value).id;

            Articulo.ComposicionArticulos.Clear();
            foreach (DataGridViewRow fila in dgvComposicion.Rows)
            {
                if (!fila.IsNewRow)
                {                 
                    ComposicionArticulos compHijo = (ComposicionArticulos)fila.Tag;
                    compHijo.cantComposicion = decimal.Parse(fila.Cells["clmCant"].FormattedValue.ToString());
                    compHijo.factorConversion = decimal.Parse(fila.Cells["clmFactor"].FormattedValue.ToString());
                    Articulo.ComposicionArticulos.Add(compHijo);
                }
            }

            try
            {
                string cadenaMensaje = "";

                // Guardamos los datos del Articulo
                if (Estado == Estados.Agregar)
                {
                    Articulo = Global.Servicio.agregarArticulo(Articulo, Global.DatosSesion);
                    cadenaMensaje = "Artículo dado de Alta exitosamente.";
                }
                else
                {
                    Global.Servicio.actualizarArticulo(Articulo, Global.DatosSesion);
                    cadenaMensaje = "Artículo Modificado con éxito.";
                }

                // Mostramos mensaje de éxito
                Mensaje mensaje = new Mensaje(string.Format(cadenaMensaje, Articulo.nombre), Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                mensaje.ShowDialog();
                // Indica que el Articulo se guardó correctamente
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
            if (Articulo != null)
            {
                Mensaje mensajeConfirmacion = new Mensaje("El artículo '" + Articulo.nombre + "' será eliminado ¿Está seguro?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                mensajeConfirmacion.ShowDialog();

                if (mensajeConfirmacion.resultado == DialogResult.OK)
                {
                    try
                    {
                        Mensaje mensajeExito;
                        //se pudo eliminar Articulo físicamente
                        Global.Servicio.eliminarArticulo(Articulo, Global.DatosSesion);
                        mensajeExito = new Mensaje("El artículo '" + Articulo.nombre+ " ha sido eliminado con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
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
                Mensaje unMensaje = new Mensaje("Debe seleccionar un artículo.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return false;
        }

        protected override void limpiar()
        {
            if (Estado != Estados.Modificar)
            {
                // Limpia los datos del formulario
                limpiarControles(this);
            }
            gpbDatos.Enabled = false;
            dgvComposicion.Enabled = false;
        }

        protected override bool cargarBusqueda()
        {
            frmBusquedaPrecio frmBusquedaArticulo = new frmBusquedaPrecio();
            DialogResult res = frmBusquedaArticulo.ShowDialog();

            if (res == DialogResult.OK)
            {
                Articulo = frmBusquedaArticulo.articuloSeleccionado;
                txtNombre.Text = Articulo.nombre;
                cboUnidad.SelectedIndex = cboUnidad.FindStringExact(Articulo.Unidad.nombre);
                if (Articulo.Unidad1 != null)
                    cboUnidadStock.SelectedIndex = cboUnidadStock.FindStringExact(Articulo.Unidad1.nombre);
                else
                    cboUnidadStock.SelectedIndex = 0;

                int i=0;
                dgvComposicion.Rows.Clear();
                foreach (ComposicionArticulos compHijos in Articulo.ComposicionArticulos)
                {
                    dgvComposicion.Rows.Add();
                    dgvComposicion.Rows[i].Tag = compHijos;
                    dgvComposicion.Rows[i].Cells["clmArt"].Value = compHijos.TipoArticulo1.nombre;
                    dgvComposicion.Rows[i].Cells["clmCant"].Value = compHijos.cantComposicion;
                    dgvComposicion.Rows[i].Cells["clmFactor"].Value = compHijos.factorConversion;
                    i++;
                }
                return true;
            }

            return false;
        }

        private bool validar()
        {
            return false;
        }

        private void dgvComposicion_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvComposicion.CurrentCell.OwningColumn.Name == "clmArt")
            {
                TextBox celda = e.Control as TextBox;
                Cargador.cargarArticulos(celda, "");
            }            
        }

        private void dgvComposicion_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvComposicion.EditingControl == null)
                return;

            switch (dgvComposicion[e.ColumnIndex, e.RowIndex].OwningColumn.Name)
            {
                case "clmArt":
                    TipoArticulo art = Global.Servicio.obtenerArticulo(dgvComposicion.EditingControl.Text);
                    if (art != null)
                    {                
                        ComposicionArticulos hijo = new ComposicionArticulos();
                        hijo.TipoArticulo1 = art;
                        dgvComposicion.Rows[e.RowIndex].Tag = hijo;
                    }      
                    break;
                case "clmCant":
                    decimal val;
                    if (decimal.TryParse(dgvComposicion.EditingControl.Text, out val))
                    {
                        if (val>0 && val <=1)
                            dgvComposicion.EditingControl.Text = Math.Round(val, 2).ToString();
                        else
                        {
                            dgvComposicion.EditingControl.Text = "0";
                            Mensaje unMensaje = new Mensaje("La proporción debe ser un número mayor a cero (0) y menor o igual a uno (1).", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                            unMensaje.ShowDialog();
                        }                            
                    }
                    else
                    {
                        dgvComposicion.EditingControl.Text = "0";
                        Mensaje unMensaje = new Mensaje("La proporción debe ser un número mayor a cero (0) y menor o igual a uno (1).", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                        unMensaje.ShowDialog();
                    }
                    break;
                case "clmFactor":
                    decimal valF;
                    if (decimal.TryParse(dgvComposicion.EditingControl.Text, out valF))
                    {
                        dgvComposicion.EditingControl.Text = Math.Round(valF, 2).ToString();
                    }
                    else
                    {
                        dgvComposicion.EditingControl.Text = "0";
                        Mensaje unMensaje = new Mensaje("El factor de conversión debe ser un número.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                        unMensaje.ShowDialog();
                    }
                    break;
                default:
                    return;
            }                              
        }
    }
}
