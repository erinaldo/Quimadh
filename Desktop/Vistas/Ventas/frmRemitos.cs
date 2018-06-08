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
using Desktop.Vistas.Administracion;

namespace Desktop.Vistas.Ventas
{
    public partial class frmRemitos : FormBaseConToolbar
    {
        private Comprobante_Remito remito;
        private Cliente cliente;
        private Planta planta;

        public frmRemitos()
        {
            InitializeComponent();
        }

        protected override void cargar()
        {
            Cargador.cargarMonedas(cboMoneda);
            cboMoneda.SelectedIndex = cboMoneda.FindStringExact("Peso"); 
            txtNroRemito.Text = Global.Servicio.BuscaNroRemito().ToString();
            Cargador.cargarUnidades(cboUnidad);
            txtPeso.Text = "0";
            txtTotal.Text = "0";
            txtCantBultos.Text = "0";
            Cargador.cargarNombresClientes(txtRazonSocial);
            //txtCotiz.Text = Global.Servicio.obtenerCotizacionDolar().ToString("0.0000");
            gpbDatosRem.Enabled = false;
            gpbDatos.Enabled = false;
            gpbTotales.Enabled = false;
            dgvItems.Enabled = false;
            cboTipoRem.Items.Add("Aguas");
            cboTipoRem.Items.Add("Agricola");

            btnEliminar.Text = "Anular";
        }

        protected override void agregar()
        {
            remito = new Comprobante_Remito();
            cliente = null;
            planta = null;
            limpiarControles(gpbDatos);
            limpiarControles(gpbDatosRem);
            limpiarControles(gpbTotales);
            cboMoneda.SelectedIndex = cboMoneda.FindStringExact("Peso");   
            dgvItems.Rows.Clear();
            gpbDatos.Enabled = true;
            gpbDatosRem.Enabled = true;
            gpbTotales.Enabled = true;
            //dgvItems.Enabled = true;
            txtNroRemito.Text = Global.Servicio.BuscaNroRemito().ToString();
            //txtCotiz.Text = Global.Servicio.obtenerCotizacionDolar().ToString("0.0000");
        }

        protected override void modificar()
        {
            gpbDatos.Enabled = true;
            gpbDatosRem.Enabled = true;
            gpbTotales.Enabled = true;
            dgvItems.Enabled = true;
            txtDomicilio.Focus();
            //txtCotiz.Text = Global.Servicio.obtenerCotizacionDolar().ToString("0.0000");
        }

        protected override bool eliminar()
        {
            if (remito != null)
            {
                Mensaje mensajeConfirmacion = new Mensaje("El Remito número '" + remito.numero.ToString() + "' será anulado ¿Está seguro?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                mensajeConfirmacion.ShowDialog();

                if (mensajeConfirmacion.resultado == DialogResult.OK)
                {
                    try
                    {
                        Mensaje mensajeExito;
                        Global.Servicio.anularComprobante(remito, Global.DatosSesion);
                        mensajeExito = new Mensaje("El Remito número '" + remito.numero.ToString() + "' ha sido anulado con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
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
                Mensaje unMensaje = new Mensaje("Debe seleccionar un remito.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return false;
        }

        protected override void limpiar()
        {
            remito = null;
            if (Estado != Estados.Modificar)
            {
                // Limpia los datos del formulario
                limpiarControles(gpbDatos);
                limpiarControles(gpbDatosRem);
                limpiarControles(gpbTotales);
                dgvItems.Rows.Clear();
            }
            gpbDatos.Enabled = false;
            gpbDatosRem.Enabled = false;
            gpbTotales.Enabled = false;
            dgvItems.Enabled = false;
            //txtCotiz.Text = Global.Servicio.obtenerCotizacionDolar().ToString("0.0000");
        }

        protected override bool cargarBusqueda()
        {
            frmBusquedaComp frmBusquedaComp = new frmBusquedaComp();
            frmBusquedaComp.tipo = "remito";
            DialogResult res = frmBusquedaComp.ShowDialog();

            if (res == DialogResult.OK)
            {
                remito = (Comprobante_Remito)frmBusquedaComp.comprobanteSeleccionado;
                planta = remito.Planta;
                cliente = remito.Planta.Cliente;
                cargarDatos(remito);

                return true;
            }

            return false;
        }

        private void cargarDatos(Comprobante_Remito remito)
        {
            txtNroRemito.Text = remito.numero.ToString();
            dtpFecha.Value = remito.fechaIngreso;
            txtPlanta.Text = remito.Planta.nombre;
            txtRazonSocial.Text = remito.Planta.Cliente.razonSocial;
            txtObs.Text = remito.observacion;
            txtOrdenCompra.Text = remito.ordenCompra;
            txtEnviarA.Text = planta.direccion;
            cboTipoRem.SelectedIndex = cboTipoRem.FindStringExact(remito.tipo);
            txtDomicilio.Text = remito.Planta.Cliente.direccion;
            txtLocalidad.Text = remito.Planta.Cliente.Localidad.nombre;
            txtSitIva.Text = remito.Planta.Cliente.SituacionFrenteIva.nombre;
            txtCUIT.Text = remito.Planta.Cliente.cuit;
            txtCantBultos.Text = remito.cantidadBultos.ToString();
            cboUnidad.SelectedIndex = cboUnidad.FindStringExact(remito.Unidad.nombre);//remito.idUnidad;
            txtPeso.Text = remito.pesoTotalKg.ToString("0.00");
            cboMoneda.SelectedIndex = cboMoneda.FindStringExact(remito.Moneda.nombre);
            txtTotal.Text = remito.importe.ToString("0.00");
            
            int i = 0;
            dgvItems.Rows.Clear();
            foreach (VentaArticuloPlanta itemRem in remito.VentaArticuloPlanta)
            {
                decimal precioCalc;
                precioCalc = Global.Servicio.ConviertePrecio(itemRem.precio, itemRem.Moneda, (Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value);
                dgvItems.Rows.Add();
                ArticuloPlanta artPla = remito.Planta.ArticuloPlanta.Where(a => a.idArticulo == itemRem.TipoArticulo.id).First();
                dgvItems.Rows[i].Tag = artPla;
                dgvItems.Rows[i].Cells["clmArt"].Value = remito.Planta.codigo + artPla.contador.ToString();
                dgvItems.Rows[i].Cells["clmCant"].Value = itemRem.cantidad.ToString("0.00");
                dgvItems.Rows[i].Cells["clmUnidad"].Value = itemRem.TipoArticulo.Unidad.abreviatura;
                dgvItems.Rows[i].Cells["clmDesc"].Value = itemRem.TipoArticulo.nombre;
                dgvItems.Rows[i].Cells["clmLote"].Value = itemRem.lote;
                dgvItems.Rows[i].Cells["clmLote"].Tag = Global.Servicio.obtenerLote(itemRem.lote);
                Presentacion present;
                if (itemRem.idPresentacion != null)
                {
                    present = Global.Servicio.obtenerPresentacion((int)itemRem.idPresentacion);
                    dgvItems.Rows[i].Cells["clmPresent"].Value = "x " + present.litrosEnvase.ToString();
                    dgvItems.Rows[i].Cells["clmPresent"].Tag = present;
                }
                else
                {
                    dgvItems.Rows[i].Cells["clmPresent"].Value = "";
                    dgvItems.Rows[i].Cells["clmPresent"].Tag = null;
                }
                                
                dgvItems.Rows[i].Cells["clmMon"].Value = ((Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value).simbologia;
                dgvItems.Rows[i].Cells["clmPrecio"].Value = precioCalc;//Global.Servicio.ConviertePrecio(itemRem.precio,itemRem.Moneda,Global.Servicio.obtenerMoneda("$")).ToString("0.00");
                dgvItems.Rows[i].Cells["clmPrecio"].Tag = itemRem.precio;
                dgvItems.Rows[i].Cells["clmImp"].Value = (itemRem.cantidad * precioCalc);//decimal.Parse(dgvItems.Rows[i].Cells["clmPrecio"].Value.ToString())).ToString("0.00");

                i++;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente frmBusquedaCliente = new frmBusquedaCliente();
            DialogResult res = frmBusquedaCliente.ShowDialog();

            if (res == DialogResult.OK)
            {
                cliente = frmBusquedaCliente.clienteSeleccionado;
                completarCamposCliente(cliente);
                planta = null;
                completarDatosPlanta(planta);
            }
        }

        private void btnPlanta_Click(object sender, EventArgs e)
        {
            frmBusquedaPlanta frmBusquedaPlanta = new frmBusquedaPlanta();
            frmBusquedaPlanta.cliente = cliente;
            DialogResult res = frmBusquedaPlanta.ShowDialog();

            if (res == DialogResult.OK)
            {
                planta = frmBusquedaPlanta.plantaSeleccionada;
                completarDatosPlanta(planta);
                dgvItems.Enabled = true;
                if (cliente == null && planta.Cliente != null)
                {
                    cliente = planta.Cliente;
                    completarCamposCliente(cliente);
                }                
            }
        }

        private void completarCamposCliente(Cliente cliente)
        {
            txtCUIT.Text = cliente == null ? "" : cliente.cuit;
            txtRazonSocial.Text = cliente == null ? "" : cliente.razonSocial;
            txtDomicilio.Text = cliente == null ? "" : cliente.direccion;
            txtLocalidad.Text = cliente == null ? "" : cliente.Localidad.nombre;
            txtSitIva.Text = cliente == null ? "" : cliente.SituacionFrenteIva.nombre;
        }

        private void completarDatosPlanta(Planta planta)
        {
            txtPlanta.Text = planta == null ? "" : planta.nombre;
            txtEnviarA.Text = planta == null ? "" : planta.direccion;
            dgvItems.Rows.Clear();
            if (planta != null)
                dgvItems.Enabled = true;
        }

        private void dgvItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox celda = e.Control as TextBox;
            ArticuloPlanta artPla = (ArticuloPlanta)dgvItems.Rows[dgvItems.CurrentCell.RowIndex].Tag;
            switch (dgvItems.CurrentCell.OwningColumn.Name)
            {
                case "clmArt":
                    Cargador.cargarArticuloPlanta(celda, planta);
                    break;
                case "clmDesc":
                    Cargador.cargarArticulosDePlanta(celda, planta);
                    break;
                case "clmLote":
                    if (artPla != null)
                        Cargador.cargarLotes(celda, artPla.TipoArticulo, 0);
                    break;
                case "clmPresent":
                    Cargador.cargarPresentaciones(celda);
                    break;
                case "clmPrecio":
                    if (artPla != null)
                    {
                        Cargador.cargarPrecios(celda, artPla);
                    }
                    break;                
                default:
                    var lista = new List<string>();
                    AutoCompleteStringCollection listaAuto = new AutoCompleteStringCollection();
                    listaAuto.AddRange(lista.ToArray());
                    celda.AutoCompleteCustomSource = listaAuto;
                    celda.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    celda.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    break;
            }

        }

        private void dgvItems_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItems.EditingControl == null)
                return;

            if (dgvItems[e.ColumnIndex,e.RowIndex].OwningColumn.Name == "clmArt")
            {
                ArticuloPlanta artPla = Global.Servicio.buscarUnArticuloPlanta(dgvItems.EditingControl.Text);
                if (artPla != null)
                {
                    dgvItems.Rows[e.RowIndex].Tag = artPla;
                    dgvItems.EditingControl.Text = artPla.Planta.codigo.Trim() + artPla.contador.ToString().Trim();
                    dgvItems[dgvItems.Columns["clmDesc"].Index, e.RowIndex].Value = artPla.TipoArticulo.nombre;
                    dgvItems[dgvItems.Columns["clmUnidad"].Index, e.RowIndex].Value = artPla.TipoArticulo.Unidad.abreviatura;
                    dgvItems[dgvItems.Columns["clmMon"].Index, e.RowIndex].Value = ((Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value).simbologia;
                    dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].Value = Global.Servicio.ConviertePrecio(artPla.precio, artPla.Moneda, (Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value);
                    dgvItems.Rows[e.RowIndex].Cells["clmPrecio"].Tag = null;

                    if (dgvItems[dgvItems.Columns["clmDesc"].Index, e.RowIndex].FormattedValue != "")
                        calcularImportes(decimal.Parse(dgvItems[dgvItems.Columns["clmCant"].Index, e.RowIndex].FormattedValue.ToString()), decimal.Parse(dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].Value.ToString()), e.RowIndex);
                    calcularPeso();
                }
                else
                {
                    dgvItems.Rows[e.RowIndex].Tag = null;
                    dgvItems[dgvItems.Columns["clmDesc"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmCant"].Index, e.RowIndex].Value = "0";
                    dgvItems[dgvItems.Columns["clmUnidad"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmMon"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmImp"].Index, e.RowIndex].Value = "0";
                    calcularImportes(0, 0, e.RowIndex);
                    calcularPeso();
                }

            }

            if (dgvItems[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmDesc")
            {
                ArticuloPlanta artPla = Global.Servicio.buscarUnArticuloPlantaXDesc(planta, dgvItems.EditingControl.Text);
                if (artPla != null)
                {
                    dgvItems.Rows[e.RowIndex].Tag = artPla;
                    dgvItems[dgvItems.Columns["clmArt"].Index, e.RowIndex].Value = artPla.Planta.codigo.Trim() + artPla.contador.ToString().Trim();                    
                    dgvItems.EditingControl.Text = artPla.TipoArticulo.nombre;
                    dgvItems[dgvItems.Columns["clmUnidad"].Index, e.RowIndex].Value = artPla.TipoArticulo.Unidad.abreviatura;
                    dgvItems[dgvItems.Columns["clmMon"].Index, e.RowIndex].Value = ((Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value).simbologia;
                    dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].Value = Global.Servicio.ConviertePrecio(artPla.precio, artPla.Moneda, Global.Servicio.obtenerMoneda("$"));
                    dgvItems.Rows[e.RowIndex].Cells["clmPrecio"].Tag = null;

                    calcularPeso();
                    if (dgvItems[dgvItems.Columns["clmArt"].Index, e.RowIndex].FormattedValue != "")                    
                        calcularImportes(decimal.Parse(dgvItems[dgvItems.Columns["clmCant"].Index, e.RowIndex].FormattedValue.ToString()), decimal.Parse(dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].Value.ToString()), e.RowIndex);                        
                }
                else
                {
                    dgvItems.Rows[e.RowIndex].Tag = null;
                    dgvItems[dgvItems.Columns["clmArt"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmCant"].Index, e.RowIndex].Value = "0";
                    dgvItems[dgvItems.Columns["clmUnidad"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmMon"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmImp"].Index, e.RowIndex].Value = "0";
                    calcularImportes(0, 0, e.RowIndex);
                    calcularPeso();
                }
            }

            if (dgvItems[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmCant")
            {
                decimal val;
                if (decimal.TryParse(dgvItems.EditingControl.Text, out val))
                {
                    if (dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].FormattedValue != "")
                    {
                        calcularImportes(val, decimal.Parse(dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].Value.ToString()), e.RowIndex);
                        calcularPeso();
                    }
                }
                else
                {
                    dgvItems.EditingControl.Text= "0";
                    calcularImportes(0, 0, e.RowIndex);
                }
            }
            
            if (dgvItems[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmLote")
            {
                Lote lote = Global.Servicio.obtenerLote(dgvItems.EditingControl.Text);
                dgvItems[e.ColumnIndex, e.RowIndex].Tag = lote;
                if (lote == null)
                    dgvItems.EditingControl.Text = "";
            }

            if (dgvItems[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmPresent")
            {
                string[] textoCelda = dgvItems.EditingControl.Text.Split(new string[]{"x "},StringSplitOptions.None);
                int litros=0;
                if (textoCelda.Count() == 2)
                    int.TryParse(textoCelda[1], out litros);

                if (litros != 0)
                {
                    Presentacion present = Global.Servicio.obtenerPresentacionPorLitros(litros);
                    if (present != null)
                    {
                        dgvItems[e.ColumnIndex, e.RowIndex].Tag = present;
                        ArticuloPlanta artPla = (ArticuloPlanta)dgvItems.Rows[e.RowIndex].Tag;
                        if (artPla != null)
                        {
                            PreciosAdicionales precio = artPla.PreciosAdicionales.Where(p => p.idPresentacion == present.id).SingleOrDefault();
                            if (precio != null)
                            {
                                dgvItems.Rows[e.RowIndex].Cells["clmPrecio"].Tag = precio.precio;
                                dgvItems.Rows[e.RowIndex].Cells["clmPrecio"].Value = precio.precio.ToString("0.00");
                                calcularImportes(decimal.Parse(dgvItems[dgvItems.Columns["clmCant"].Index, e.RowIndex].FormattedValue.ToString()), decimal.Parse(dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].Value.ToString()), e.RowIndex);
                            }                                
                        }
                    }                        
                    else
                    {
                        dgvItems[e.ColumnIndex, e.RowIndex].Tag = null;
                        dgvItems.EditingControl.Text = "";
                    }
                }                    
                else
                {
                    dgvItems[e.ColumnIndex, e.RowIndex].Tag = null;
                    dgvItems.EditingControl.Text = "";
                }                    
            }

            if (dgvItems[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmPrecio")
            {
                ArticuloPlanta artPla = (ArticuloPlanta)dgvItems.Rows[e.RowIndex].Tag;
                if (artPla != null)
                {
                    decimal val;
                    if (decimal.TryParse(dgvItems.EditingControl.Text, out val))
                    {
                        var precios = artPla.PreciosAdicionales.Select(p => p.precio).ToList();
                        precios.Add(artPla.precio);
                        if (precios.Contains(val))
                        {
                            dgvItems.Rows[e.RowIndex].Cells["clmPrecio"].Tag = val;
                            calcularImportes(decimal.Parse(dgvItems[dgvItems.Columns["clmCant"].Index, e.RowIndex].FormattedValue.ToString()), decimal.Parse(dgvItems.EditingControl.Text), e.RowIndex);

                            var present = artPla.PreciosAdicionales.Where(p => p.precio.ToString("0.00") == val.ToString("0.00")).SingleOrDefault();
                            if (present != null)
                            {
                                dgvItems.Rows[e.RowIndex].Cells["clmPresent"].Tag = present.Presentacion;
                                dgvItems.Rows[e.RowIndex].Cells["clmPresent"].Value = "x " + present.Presentacion.litrosEnvase.ToString();
                            }                            
                        }
                        else
                        {
                            dgvItems.Rows[e.RowIndex].Cells["clmPrecio"].Tag = 0;
                            dgvItems.EditingControl.Text = "0.00";
                            calcularImportes(0, 0, e.RowIndex);
                        }
                    }
                    else
                    {
                        dgvItems.Rows[e.RowIndex].Cells["clmPrecio"].Tag = 0;
                        dgvItems.EditingControl.Text = "0.00";
                        calcularImportes(0, 0, e.RowIndex);
                    }
                }
                else
                {
                    dgvItems.Rows[e.RowIndex].Cells["clmPrecio"].Tag = null;
                    dgvItems.EditingControl.Text = "";
                }
            }
        }

        private void calcularImportes(decimal cantidad, decimal Precio, int fila)
        {
            if (fila != -1)
                dgvItems[dgvItems.Columns["clmImp"].Index, fila].Value = cantidad * Precio;

            decimal suma = 0;
              
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.Index!=-1 && !row.IsNewRow && row.Tag != null)
                {
                    suma += decimal.Parse(row.Cells["clmImp"].FormattedValue.ToString());
                }
            }                

            txtTotal.Text = suma.ToString("0.00");                        
        }

        private void calcularPeso()
        {
            decimal peso=0;

            foreach (DataGridViewRow row in dgvItems.Rows)
            {               
                if (!row.IsNewRow && row.Tag != null)
                {
                    if (((ArticuloPlanta)row.Tag).TipoArticulo.idUnidad == ((Unidad)((ComboBoxItem)cboUnidad.SelectedItem).Value).id)
                    {
                        peso += decimal.Parse(row.Cells["clmCant"].EditedFormattedValue.ToString());
                    }
                }
            }
            txtPeso.Text = peso.ToString();
        }

        protected override bool guardar()
        {
            try
            {
                if (cliente != null && planta != null)
                {
                    if (txtEnviarA.Text.Trim() == "")
                    {
                        Mensaje unMensaje = new Mensaje("Debe ingresar una dirección de envío", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                        unMensaje.ShowDialog();
                        return false;
                    }

                    if (Estado == Estados.Agregar)
                        remito = new Comprobante_Remito();

                    if (txtNroRemito.Text != "")
                        remito.numero = long.Parse(txtNroRemito.Text);
                    else
                        remito.numero = 0;

                    remito.Moneda = (Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value;
                    remito.Planta = planta;
                    remito.observacion = txtObs.Text;
                    remito.anulado = false;
                    remito.tipo = cboTipoRem.Text;                    
                    remito.fechaIngreso = dtpFecha.Value;
                    remito.ordenCompra = txtOrdenCompra.Text;
                    remito.idUnidad = ((Unidad)((ComboBoxItem)cboUnidad.SelectedItem).Value).id;
                    remito.importe = 0;

                    remito.VentaArticuloPlanta.Clear();

                    foreach (DataGridViewRow fila in dgvItems.Rows)
                    {
                        if (!fila.IsNewRow)
                        {
                            ArticuloPlanta artPla = (ArticuloPlanta)fila.Tag;
                            VentaArticuloPlanta venta = new VentaArticuloPlanta();
                            if (artPla != null)
                            {
                                remito.importe += decimal.Parse(fila.Cells["clmImp"].Value.ToString());
                                venta.TipoArticulo = artPla.TipoArticulo;
                                venta.Moneda = artPla.Moneda;
                                decimal precio;
                                if (fila.Cells["clmPrecio"].Tag != null)
                                {
                                    precio = (decimal)fila.Cells["clmPrecio"].Tag;
                                }
                                else
                                {
                                    precio = artPla.precio;
                                }

                                venta.precio = precio;
                                venta.cotizacion = artPla.Moneda.cotizacion;
                                venta.cantidad = decimal.Parse(fila.Cells["clmCant"].FormattedValue.ToString());
                                venta.lote = fila.Cells["clmLote"].FormattedValue.ToString();
                                Presentacion present = (Presentacion)fila.Cells["clmPresent"].Tag;
                                if (present != null)
                                    venta.idPresentacion = present.id;
                                remito.VentaArticuloPlanta.Add(venta);

                                //genera salidas de los productos remitados
                                Salida salida = new Salida();
                                salida.idCliente = planta.idCliente;
                                salida.fecha = remito.fechaIngreso;
                                salida.cantidad = venta.cantidad;
                                //si ingresó lote
                                if (fila.Cells["clmLote"].Tag != null)
                                {                                                                        
                                    salida.Lote = (Lote)fila.Cells["clmLote"].Tag;                                  
                                }
                                else
                                {
                                    salida.Lote = Global.Servicio.obtenerLoteProductoFinal(artPla.TipoArticulo, Global.DatosSesion);
                                }
                                //si ingresó presentación
                                if (fila.Cells["clmPresent"].Tag != null)
                                    salida.idPresentacion = ((Presentacion)fila.Cells["clmPresent"].Tag).id;

                                venta.Salida.Add(salida);//para que se grabe en el add del remito
                                salida.VentaArticuloPlanta = venta; //para que lo hereden las salidas hijas en el cálculo
                                Global.Servicio.ObtenerSalidasMateriasPrimas(salida, Global.DatosSesion);                                                
                            }
                        }
                    }

                    if (txtPeso.Text.Trim() == "")
                    {
                        DialogResult pregunta = MessageBox.Show("¿Está seguro que desea dejar la cantidad medida en 0?", "Atención", MessageBoxButtons.YesNo);
                        if (pregunta == DialogResult.Yes)
                            remito.pesoTotalKg = 0;
                        else
                            return false;
                    }
                    else
                        remito.pesoTotalKg = decimal.Parse(txtPeso.Text);

                    if (txtCantBultos.Text.Trim() == "")
                    {
                        DialogResult pregunta = MessageBox.Show("¿Está seguro que desea dejar la cantidad de bultos en 0?", "Atención", MessageBoxButtons.YesNo);
                        if (pregunta == DialogResult.Yes)
                            remito.cantidadBultos = 0;
                        else
                            return false;
                    }                        
                    else
                        remito.cantidadBultos = int.Parse(txtCantBultos.Text);

                    if (Estado == Estados.Agregar)
                        Global.Servicio.agregarRemito(remito, Global.DatosSesion);
                    else
                        Global.Servicio.actualizarRemito(remito, Global.DatosSesion);

                    Mensaje msj = new Mensaje("Remito guardado con éxito", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                    msj.ShowDialog();

                    if (Estado == Estados.Agregar)
                    {
                        Global.Servicio.imprimirRemito(remito, txtEnviarA.Text, chkImprimirPrecios.Checked);
                        Global.Servicio.imprimirRemito(remito, txtEnviarA.Text, chkImprimirPrecios.Checked);
                        Global.Servicio.imprimirRemito(remito, txtEnviarA.Text, chkImprimirPrecios.Checked);

                        Global.Servicio.imprimirRemitoDigital(remito, txtEnviarA.Text, chkImprimirPrecios.Checked);
                    }
                        
                    return true;
                }
                else
                {
                    Mensaje unMensaje = new Mensaje("Debe seleccionar un cliente y una planta.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    unMensaje.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
                return false;
            }
            return false;
        }

        private void cboUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularPeso();
        }

        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            cliente = Global.Servicio.buscarUnCliente("", txtCUIT.Text);
            completarCamposCliente(cliente);
            planta = null;
            completarDatosPlanta(planta);
        }

        private void txtCUIT_Leave(object sender, EventArgs e)
        {
            txtCUIT_KeyPress(sender, new KeyPressEventArgs((char)Keys.Enter));
        }

        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            cliente = Global.Servicio.buscarUnCliente(txtRazonSocial.Text.Trim(), "");
            completarCamposCliente(cliente);
            planta = null;
            completarDatosPlanta(planta);
        }

        private void txtRazonSocial_Leave(object sender, EventArgs e)
        {
            txtRazonSocial_KeyPress(sender, new KeyPressEventArgs((char)Keys.Enter));
        }

        private void dgvItems_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcularImportes(0, 0, -1);
            calcularPeso();
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            if (remito != null && Estado != Estados.Modificar && Estado != Estados.Agregar)
            {
                Global.Servicio.imprimirRemito(remito, txtEnviarA.Text, chkImprimirPrecios.Checked);
                Global.Servicio.imprimirRemito(remito, txtEnviarA.Text, chkImprimirPrecios.Checked);
                Global.Servicio.imprimirRemito(remito, txtEnviarA.Text, chkImprimirPrecios.Checked);
            }
            else
            {
                Mensaje unMensaje = new Mensaje("Debe seleccionar un Remito para reimprimir.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        private void cboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Moneda mon = (Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value;
            txtCotiz.Text = Global.Servicio.obtenerCotizacionMoneda(mon.id).ToString("0.0000");
            ArticuloPlanta artP;            
            foreach (DataGridViewRow fila in dgvItems.Rows)
            {
                if (!fila.IsNewRow)
                {                    
                    artP = (ArticuloPlanta)fila.Tag;
                    fila.Cells["clmMon"].Value = mon.simbologia;

                    decimal precio;
                    if (fila.Cells["clmPrecio"].Tag != null)
                        precio = (decimal)fila.Cells["clmPrecio"].Tag;
                    else
                        precio = artP.precio;
                    
                    fila.Cells["clmPrecio"].Value = Global.Servicio.ConviertePrecio(precio, artP.Moneda, mon);
                    calcularImportes(decimal.Parse(fila.Cells["clmCant"].FormattedValue.ToString()), decimal.Parse(fila.Cells["clmPrecio"].FormattedValue.ToString()), fila.Index);
                }
            }
        }
    }
}
