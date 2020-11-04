using Controles;
using Desktop.Vistas.Administracion;
using Entidades;
using Frontend.Controles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Desktop.Vistas.Ventas
{
    public partial class frmFacturas : FormBaseConToolbar
    {
        private Comprobante_Factura factura;
        private Cliente cliente;
        private Planta planta;
        private FEAfip.DTOConsultaObligadoRespuesta sujetoObligado;

        private bool SujetoObligado => sujetoObligado?.Obligado ?? false;
        private decimal MontoObligado => sujetoObligado?.MontoDesde ?? 0;
        private Moneda MonedaFCE => Global.Servicio.obtenerMoneda(0);        
        private bool esMiPyme => SujetoObligado && Global.Servicio.ConviertePrecio(factura.importe, factura.Moneda, MonedaFCE) >= MontoObligado;
        private int tipoAfipA => esMiPyme ? 201 : 1;
        private int tipoAfipB => esMiPyme ? 206 : 6;

        private long nroFacturaComun = 0;
        private long nroFacturaMiPyme = 0;

        private readonly string _nroRemito;

        public frmFacturas(string nroRemito = null)
        {
            InitializeComponent();
            _nroRemito = nroRemito;                      
        }

        protected override void cargar()
        {
            Cargador.cargarMonedas(cboMoneda);
            cboMoneda.SelectedIndex = cboMoneda.FindStringExact("Peso");                
            gpbDatosFact.Enabled = false;
            gpbDatos.Enabled = false;
            gpbTotales.Enabled = false;
            dgvItems.Enabled = false;
            dgvRemitos.Enabled = false;
            Cargador.cargarNombresClientes(txtRazonSocial);
            Cargador.cargarPuntosVta(cboPtoVenta,"factura");
            cboPtoVenta.SelectedIndex = cboPtoVenta.FindStringExact("3");
            btnEliminar.Text = "Anular";

            nroFacturaMiPyme = 0;
            nroFacturaMiPyme = 0;
            sujetoObligado = null;

            if (!string.IsNullOrEmpty(_nroRemito))
            {
                cambiarEstado(Estados.Agregar);
                agregar();
                dgvRemitos.Rows[0].Cells[0].Value = _nroRemito;
                FacturarRemito(_nroRemito);
            }
        }

        protected override void agregar()
        {
            factura = new Comprobante_Factura();
            cliente = null;
            planta = null;

            nroFacturaMiPyme = 0;
            nroFacturaMiPyme = 0;
            sujetoObligado = null;

            limpiarControles(gpbDatos);
            limpiarControles(gpbDatosFact);
            limpiarControles(gpbTotales);
            cboMoneda.SelectedIndex = cboMoneda.FindStringExact("Peso");
            cboPtoVenta.SelectedIndex = cboPtoVenta.FindStringExact("3");
            dgvItems.Rows.Clear();
            dgvRemitos.Rows.Clear();
            gpbDatos.Enabled = true;
            gpbTotales.Enabled = true;
            gpbDatosFact.Enabled = true;
            dgvRemitos.Enabled = true;
            dtpFecVtoCAE.Format = DateTimePickerFormat.Custom;
            dtpFecVtoCAE.CustomFormat = " ";
        }

        protected override void modificar()
        {
            if (factura.pv != 3 || factura.estadoCarga == 1)
            {
                Mensaje msg = new Mensaje("No se puede modificar una factura ya generada.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msg.Show();
                cambiarEstado(Estados.Consultar);
                return;
            }

            gpbDatos.Enabled = true;
            gpbDatosFact.Enabled = true;
            gpbTotales.Enabled = true;
            dgvItems.Enabled = true;
            dgvRemitos.Enabled = true;
            txtDomicilio.Focus();
        }

        protected override bool eliminar()
        {
            if (factura != null)
            {
                Mensaje mensajeConfirmacion = new Mensaje("La Factura tipo '"+ factura.tipo +"', número '" + factura.numero.ToString() + "' será anulada ¿Está seguro?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                mensajeConfirmacion.ShowDialog();

                if (mensajeConfirmacion.resultado == DialogResult.OK)
                {
                    try
                    {
                        Mensaje mensajeExito;
                        //se pudo eliminar Cliente físicamente
                        Global.Servicio.anularComprobante(factura, Global.DatosSesion);
                        mensajeExito = new Mensaje("La Factura tipo '"+ factura.tipo +"', número '" + factura.numero.ToString() + "' ha sido anulada con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
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
                Mensaje unMensaje = new Mensaje("Debe seleccionar una factura.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return false;
        }

        protected override void limpiar()
        {
            factura = null;
            sujetoObligado = null;
            nroFacturaComun = 0;
            nroFacturaMiPyme = 0;

            limpiarControles(gpbDatos);
            limpiarControles(gpbDatosFact);
            limpiarControles(gpbTotales);
            dgvItems.Rows.Clear();
            dgvRemitos.Rows.Clear();

            gpbDatos.Enabled = false;
            gpbDatosFact.Enabled = false;
            dgvItems.Enabled = false;
            dgvRemitos.Enabled = false;
        }

        protected override bool cargarBusqueda()
        {
            frmBusquedaComp frmBusquedaComp = new frmBusquedaComp();
            frmBusquedaComp.Tipo = "factura";
            DialogResult res = frmBusquedaComp.ShowDialog();

            if (res == DialogResult.OK)
            {
                factura = (Comprobante_Factura)frmBusquedaComp.comprobanteSeleccionado;
                planta = factura.Planta;
                cliente = factura.Planta.Cliente;                               

                cargarDatos(factura);
                
                return true;
            }

            return false;
        }

        private void cargarDatos(Comprobante_Factura factura)
        {
            cboPtoVenta.SelectedIndex = cboPtoVenta.FindStringExact(factura.pv.ToString());                        
            actualizarDatosAfip();
                
            dtpFecha.Value = factura.fechaIngreso;
            dtpFechaVto.Value = factura.vencimiento;
            txtPlanta.Text = factura.Planta.nombre;            
            txtObs.Text = factura.observacion;

            //txtRazonSocial.Text = factura.Planta.Cliente.razonSocial;
            //txtDomicilio.Text = factura.Planta.Cliente.direccion;
            //txtLocalidad.Text = factura.Planta.Cliente.Localidad.nombre;
            //txtSitIva.Text = factura.Planta.Cliente.SituacionFrenteIva.nombre;            
            //txtCUIT.Text = factura.Planta.Cliente.cuit;
            completarCamposCliente(factura.Planta.Cliente);

            txtNroFactura.Text = factura.numero.ToString();
            txtCondVta.Text = factura.condVta;

            if (factura.Moneda != null)
                cboMoneda.SelectedIndex = cboMoneda.FindStringExact(factura.Moneda.nombre);
            else
                cboMoneda.SelectedIndex = cboMoneda.FindStringExact("Peso");

            txtSubTotal.Text = Math.Round(factura.subtotal,2).ToString("0.00");
            txtIva.Text = Math.Round(factura.totalIva,2).ToString("0.00");
            txtTotal.Text = Math.Round(factura.importe, 2).ToString("0.00");
            txtOrdenCompra.Text = factura.ordenCompra;                      

            int i=0;
            dgvItems.Rows.Clear();
            foreach(VentaArticuloPlanta itemFact in factura.VentaArticuloPlanta)
            {
                decimal precioCalc;
                precioCalc = Global.Servicio.ConviertePrecio(itemFact.precio, itemFact.Moneda, (Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value);
                dgvItems.Rows.Add();
                ArticuloPlanta artPla = factura.Planta.ArticuloPlanta.Where(a => a.idArticulo == itemFact.TipoArticulo.id).First();
                dgvItems.Rows[i].Tag = artPla;
                dgvItems.Rows[i].Cells["clmArt"].Value = factura.Planta.codigo + artPla.contador.ToString();                
                dgvItems.Rows[i].Cells["clmCant"].Value = Math.Round(itemFact.cantidad,2).ToString("0.00");
                dgvItems.Rows[i].Cells["clmUnidad"].Value = itemFact.TipoArticulo.Unidad.abreviatura;
                dgvItems.Rows[i].Cells["clmDesc"].Value = itemFact.TipoArticulo.nombre;
                dgvItems.Rows[i].Cells["clmDescripAdic"].Value = itemFact.descripAdicional;
                dgvItems.Rows[i].Cells["clmMon"].Value = ((Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value).simbologia;
                dgvItems.Rows[i].Cells["clmPrecio"].Value = precioCalc;
                dgvItems.Rows[i].Cells["clmPrecio"].Tag = itemFact.precio;
                if (factura.Planta.Cliente.idSituacionFrenteIva == 4)
                    dgvItems.Rows[i].Cells["clmImp"].Value = Math.Round((Math.Round(itemFact.cantidad,2) * precioCalc),2);
                else
                    dgvItems.Rows[i].Cells["clmImp"].Value = Math.Round((Math.Round(itemFact.cantidad,2) * precioCalc * ((itemFact.iva/100) + 1)),2);
                dgvItems.Rows[i].Cells["clmIVA"].Value = Math.Round(itemFact.iva,2);
                dgvItems.Rows[i].Cells["clmRem"].Value = itemFact.Comprobante_Comprobante_Remito != null ? itemFact.Comprobante_Comprobante_Remito.numero.ToString() : "";
                dgvItems.Rows[i].Cells["clmIdRem"].Value = itemFact.Comprobante_Comprobante_Remito != null ? itemFact.Comprobante_Comprobante_Remito.id.ToString() : "";
                
                i++;                
            }

            i = 0;
            dgvRemitos.Rows.Clear();
            foreach (Comprobante_Remito rem in factura.Comprobante_Remito)
            {
                dgvRemitos.Rows.Add();
                dgvRemitos.Rows[i].Cells["clmNroRemito"].Value = rem.numero.ToString();
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
                //obtenerNroFactura();
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
                //obtenerNroFactura();
            }
        }

        private void dgvItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox celda = e.Control as TextBox;
            switch (dgvItems.CurrentCell.OwningColumn.Name)
            {
                case "clmArt":
                    Cargador.cargarArticuloPlanta(celda, planta);
                    break;
                case "clmDesc":
                    Cargador.cargarArticulosDePlanta(celda, planta);
                    break;
                case "clmPrecio":
                    ArticuloPlanta artPla = (ArticuloPlanta)dgvItems.Rows[dgvItems.CurrentCell.RowIndex].Tag;
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

            if (dgvItems[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmArt")
            {
                ArticuloPlanta artPla = Global.Servicio.BuscarUnArticuloPlanta(dgvItems.EditingControl.Text);
                if (artPla != null) 
                { 
                    dgvItems.Rows[e.RowIndex].Tag = artPla;
                    dgvItems.EditingControl.Text = artPla.Planta.codigo.Trim() + artPla.contador.ToString().Trim();
                    dgvItems[dgvItems.Columns["clmDesc"].Index, e.RowIndex].Value = artPla.TipoArticulo.nombre;
                    dgvItems[dgvItems.Columns["clmUnidad"].Index, e.RowIndex].Value = artPla.TipoArticulo.Unidad.abreviatura;
                    dgvItems[dgvItems.Columns["clmMon"].Index, e.RowIndex].Value = ((Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value).simbologia;
                    dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].Value = Global.Servicio.ConviertePrecio(artPla.precio,artPla.Moneda, (Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value);
                    dgvItems.Rows[e.RowIndex].Cells["clmPrecio"].Tag = null;

                    if (dgvItems[dgvItems.Columns["clmDesc"].Index, e.RowIndex].FormattedValue != "")
                        calcularImportes(decimal.Parse(dgvItems[dgvItems.Columns["clmCant"].Index, e.RowIndex].FormattedValue.ToString()), decimal.Parse(dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].Value.ToString()), e.RowIndex);                        
                }
                else
                {
                    dgvItems.Rows[e.RowIndex].Tag = null;
                    dgvItems[dgvItems.Columns["clmDesc"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmUnidad"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmCant"].Index, e.RowIndex].Value = "0";
                    dgvItems[dgvItems.Columns["clmMon"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmImp"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmIVA"].Index, e.RowIndex].Value = "21";
                    calcularImportes(0, 0, e.RowIndex);
                }
            }

            if (dgvItems[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmDesc")
            {
                ArticuloPlanta artPla = Global.Servicio.BuscarUnArticuloPlantaXDesc(planta, dgvItems.EditingControl.Text);
                if (artPla != null)
                {
                    dgvItems.Rows[e.RowIndex].Tag = artPla;
                    dgvItems[dgvItems.Columns["clmArt"].Index, e.RowIndex].Value = artPla.Planta.codigo.Trim() + artPla.contador.ToString().Trim();
                    dgvItems.EditingControl.Text = artPla.TipoArticulo.nombre;
                    dgvItems[dgvItems.Columns["clmUnidad"].Index, e.RowIndex].Value = artPla.TipoArticulo.Unidad.abreviatura;
                    dgvItems[dgvItems.Columns["clmMon"].Index, e.RowIndex].Value = ((Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value).simbologia;
                    dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].Value = Global.Servicio.ConviertePrecio(artPla.precio,artPla.Moneda, (Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value);
                    dgvItems.Rows[e.RowIndex].Cells["clmPrecio"].Tag = null;

                    if (dgvItems[dgvItems.Columns["clmArt"].Index, e.RowIndex].FormattedValue != "")
                        calcularImportes(decimal.Parse(dgvItems[dgvItems.Columns["clmCant"].Index, e.RowIndex].FormattedValue.ToString()), decimal.Parse(dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].Value.ToString()), e.RowIndex);                        
                }
                else
                {
                    dgvItems.Rows[e.RowIndex].Tag = null;
                    dgvItems[dgvItems.Columns["clmArt"].Index, e.RowIndex].Value = "";                    
                    dgvItems[dgvItems.Columns["clmUnidad"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmCant"].Index, e.RowIndex].Value = "0";
                    dgvItems[dgvItems.Columns["clmMon"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmImp"].Index, e.RowIndex].Value = "";
                    dgvItems[dgvItems.Columns["clmIVA"].Index, e.RowIndex].Value = "21";
                    calcularImportes(0, 0, e.RowIndex);
                }
            }

            if (dgvItems[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmCant")
            {
                decimal val;
                if (decimal.TryParse(dgvItems.EditingControl.Text, out val))
                {
                    if (dgvItems.Rows[e.RowIndex].Cells["clmIdRem"].FormattedValue.ToString() != "")
                    {
                        decimal valorAnt = decimal.Parse(dgvItems.Rows[e.RowIndex].Cells["clmCant"].FormattedValue.ToString());
                        if (val > valorAnt)
                        {
                            Mensaje msj;
                            msj = new Mensaje("No puede facturar una cantidad mayor a la pendiente de facturación", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                            msj.ShowDialog();
                            dgvItems.EditingControl.Text = valorAnt.ToString();
                            return;
                        }
                    }

                    if (dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].FormattedValue != "") 
                    {
                        calcularImportes(val, decimal.Parse(dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].Value.ToString()), e.RowIndex);
                    }
                }
                else
                {
                    dgvItems.EditingControl.Text = "0";
                    calcularImportes(0, 0, e.RowIndex);
                }
            }

            if (dgvItems[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmIVA")
            {
                decimal val;
                if (decimal.TryParse(dgvItems.EditingControl.Text, out val))
                {
                    if (dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].FormattedValue != "")
                    {
                        calcularImportes(decimal.Parse(dgvItems[dgvItems.Columns["clmCant"].Index, e.RowIndex].FormattedValue.ToString()), decimal.Parse(dgvItems[dgvItems.Columns["clmPrecio"].Index, e.RowIndex].Value.ToString()), e.RowIndex);
                    }
                }
                else
                {
                    dgvItems.EditingControl.Text = "0";
                    calcularImportes(0, 0, e.RowIndex);
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

        private void calcularImportes(decimal cantidad, decimal Precio,int fila)
        {            
            decimal sumaSinIVA = 0;
            decimal sumaConIVA = 0;
            decimal suma = 0;
            decimal total = 0;

            if (cliente != null) { 
                if (cliente.SituacionFrenteIva.nombre == "Responsable Inscripto") 
                {
                    if (fila != -1)
                        dgvItems[dgvItems.Columns["clmImp"].Index, fila].Value = Math.Round(Math.Round(cantidad,2) * Math.Round(Precio,2),2);

                    foreach (DataGridViewRow row in dgvItems.Rows)
                    {
                        if (!row.IsNewRow)
                        {                            
                            sumaSinIVA += Math.Round(decimal.Parse(row.Cells["clmImp"].Value.ToString()),2);
                            sumaConIVA += Math.Round(Math.Round(decimal.Parse(row.Cells["clmImp"].Value.ToString()),2) * ((decimal.Parse(row.Cells["clmIVA"].EditedFormattedValue.ToString()) / 100) + 1),2);
                        }
                    }                
                    txtIva.Text = Math.Round((sumaConIVA - sumaSinIVA),2).ToString("0.00");
                    txtSubTotal.Text = sumaSinIVA.ToString("0.00");
                    txtTotal.Text = sumaConIVA.ToString("0.00");
                    total = sumaConIVA; //por alguna razón el textbox no toma el valor al principio,
                }
                else
                {
                    if (fila != -1)
                        dgvItems[dgvItems.Columns["clmImp"].Index, fila].Value = Math.Round(Math.Round(cantidad,2) * Math.Round(Precio,2) * ((decimal.Parse(dgvItems.Rows[fila].Cells["clmIVA"].EditedFormattedValue.ToString()) / 100) + 1),2);
                    foreach (DataGridViewRow row in dgvItems.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            suma += Math.Round(decimal.Parse(row.Cells["clmImp"].Value.ToString()),2);                        
                        }
                    }   
                    txtIva.Text = "0.00";
                    txtSubTotal.Text = "0.00";
                    txtTotal.Text = suma.ToString("0.00");
                    total = suma; //por alguna razón el textbox no toma el valor al principio,
                }

                if (SujetoObligado)                    
                {
                    //si es sujeto obligado tengo que ir analizando que nro de comprobante va dependiendo del total
                    long nroFact;
                    if (Global.Servicio.ConviertePrecio(total, (Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value, MonedaFCE) >= MontoObligado)
                    {
                        nroFact = obtenerNroFactura(true, nroFacturaMiPyme > 0);
                        nroFacturaMiPyme = nroFact;
                    }
                    else
                    {
                        nroFact = obtenerNroFactura(false, nroFacturaComun > 0);
                        nroFacturaComun = nroFact;
                    }
                }
            }
        }

        protected override bool guardar()
        {
            try
            {
                if (dgvItems.Rows.Count <= 1)
                {
                    Mensaje error = new Mensaje("La grilla no puede estar vacía.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    error.ShowDialog();
                    return false;
                }

                if (cboPtoVenta.Text != "3")
                {
                    Mensaje mensajeConfirmacion = new Mensaje("El punto de venta seleccionado no corresponde a Facturación Electrónica ¿Desea continuar de todos modos?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                    mensajeConfirmacion.ShowDialog();

                    if (mensajeConfirmacion.resultado != DialogResult.OK)
                    {
                        return false;
                    }
                }

                if (cliente != null && planta != null)
                {
                    if (Estado == Estados.Agregar || cboPtoVenta.Text != "3")
                        factura = new Comprobante_Factura();
 
                    if (txtNroFactura.Text != "")
                        factura.numero = long.Parse(txtNroFactura.Text);
                    else
                        factura.numero = 0;

                    if (cliente.SituacionFrenteIva.nombre == "Responsable Inscripto")
                    {
                        factura.tipo = "A";
                        factura.subtotal = Math.Round(decimal.Parse(txtSubTotal.Text),2);
                        factura.totalIva = Math.Round(decimal.Parse(txtIva.Text),2);
                    }
                    else
                    {
                        factura.tipo = "B";
                        factura.subtotal = 0;
                        factura.totalIva = 0;
                    }

                    factura.Moneda = (Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value;
                    factura.fechaIngreso = dtpFecha.Value;
                    factura.Planta = planta;
                    factura.observacion = txtObs.Text;
                    factura.vencimiento = dtpFechaVto.Value;
                    factura.condVta = txtCondVta.Text;
                    factura.importe = Math.Round(decimal.Parse(txtTotal.Text),2);
                    factura.anulado = false;
                    factura.ordenCompra = txtOrdenCompra.Text;
                    factura.pv = int.Parse(cboPtoVenta.Text);

                    List<double[]> arregloIva = new List<double[]>();
                    List<decimal> ivaUsados = new List<decimal>();
                    
                    factura.VentaArticuloPlanta.Clear();

                    foreach (DataGridViewRow fila in dgvItems.Rows)
                    {
                        if (!fila.IsNewRow)
                        {
                            ArticuloPlanta artPla = (ArticuloPlanta)fila.Tag;
                            VentaArticuloPlanta venta = new VentaArticuloPlanta();
                            if (artPla != null)
                            {                                
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
                                venta.cantidad = Math.Round(decimal.Parse(fila.Cells["clmCant"].FormattedValue.ToString()),2);
                                venta.iva = Math.Round(decimal.Parse(fila.Cells["clmIVA"].FormattedValue.ToString()),2);
                                venta.descripAdicional = fila.Cells["clmDescripAdic"].FormattedValue.ToString();
                                if (fila.Cells["clmIdRem"].FormattedValue.ToString() != "")
                                    venta.idRemito = long.Parse(fila.Cells["clmIdRem"].FormattedValue.ToString());                                    
                                factura.VentaArticuloPlanta.Add(venta);
                                
                                if(ivaUsados.Contains(venta.iva))
                                {
                                    foreach (double[] i in arregloIva)
                                    {
                                        if(i[0] == (double)venta.iva)
                                        {
                                            i[1] += (double)Math.Round((Global.Servicio.ConviertePrecio(venta.precio, venta.Moneda, factura.Moneda) * venta.cantidad),2);
                                            i[2] += (double)Math.Round((Global.Servicio.ConviertePrecio(venta.precio, venta.Moneda, factura.Moneda) * venta.cantidad * (venta.iva / 100)),2);
                                        }
                                    }
                                }
                                else
                                {
                                    double[] itemIva = new double[3];
                                    itemIva[0] = (double)venta.iva;
                                    itemIva[1] = (double)Math.Round((Global.Servicio.ConviertePrecio(venta.precio, venta.Moneda, factura.Moneda) * venta.cantidad),2);
                                    itemIva[2] = (double)Math.Round((Global.Servicio.ConviertePrecio(venta.precio, venta.Moneda, factura.Moneda) * venta.cantidad * (venta.iva / 100)),2);
                                    arregloIva.Add(itemIva);
                                    ivaUsados.Add(venta.iva);
                                }
                                
                            }
                        }
                    }

                    factura.Comprobante_Remito.Clear();
                    foreach (DataGridViewRow fila in dgvRemitos.Rows)
                    {
                        if (!fila.IsNewRow)
                        {
                            Comprobante_Remito remito;
                            long nroRem;
                            if (long.TryParse(fila.Cells["clmNroRemito"].Value.ToString(), out nroRem))
                            {
                                remito = Global.Servicio.buscarUnRemito(nroRem);
                            }
                            else
                            {
                                remito = null;
                            }
                            factura.Comprobante_Remito.Add(remito);
                        }
                    }

                    factura.CE_MiPyme = esMiPyme;

                    //GUARDA LA FACTURA SIN CAE
                    factura.estadoCarga = 0;
                    if (Estado == Estados.Modificar && factura.pv == 3)                        
                        Global.Servicio.actualizarFactura(factura, Global.DatosSesion, true);
                    else
                        Global.Servicio.agregarFactura(factura, Global.DatosSesion);

                    bool result = true;
                    FEAfip.DTOSolicitud rtaAfip = new FEAfip.DTOSolicitud();   

                    if (cboPtoVenta.Text == "3")
                    {
                        double[][] arregloIva2 = arregloIva.ToArray();
                        double totIva = 0;

                        for (int i = 0; i < arregloIva2.Count(); i++)
                        {
                            arregloIva2[i][1] = Math.Round(arregloIva2[i][1], 2);
                            arregloIva2[i][2] = Math.Round(arregloIva2[i][2], 2);
                            if (factura.tipo == "B")
                            {
                                totIva += arregloIva2[i][2];
                            }
                        }

                        totIva = Math.Round(totIva, 2);

                        FEAfip.ServicioCAEClient service = new FEAfip.ServicioCAEClient();
                                             
                        int tipo;
                        double neto = 0;
                        if (factura.tipo == "A")
                        {
                            tipo = tipoAfipA;//1;
                            totIva = Math.Round((double)factura.totalIva,2);
                            neto = Math.Round((double)factura.subtotal,2);
                        }
                        else
                        {
                            tipo = tipoAfipB;//6;
                            neto = Math.Round((((double)factura.importe) - totIva),2);
                        }

                        try
                        {
                            var solicitud = new FEAfip.SolicitudRequest();
                            solicitud.tipoComp = tipo;
                            solicitud.puntoVenta = 3;
                            solicitud.concepto = 1;
                            solicitud.tdoc = 80;
                            solicitud.ndoc = long.Parse(factura.Planta.Cliente.cuit);
                            solicitud.nroComp = factura.numero;
                            solicitud.fecha = factura.fechaIngreso.ToString("yyyyMMdd");
                            solicitud.total = (double)factura.importe;
                            solicitud.neto = neto;
                            solicitud.iva = totIva;
                            solicitud.mon = factura.Moneda.abrevAfip;
                            solicitud.cotiz = (double)factura.Moneda.cotizacion;
                            solicitud.arrayIva = arregloIva2;
                            solicitud.compAsociados = null;
                            if (esMiPyme)
                            {
                                solicitud.fechaVto = factura.vencimiento.ToString("yyyyMMdd");
                            }
                            
                            rtaAfip = service.solicitar(solicitud);

                            if (rtaAfip.respuesta != "A")
                            {
                                throw new Exception("Solicitud Rechazada, no se pudo obtener CAE");
                            }

                            Mensaje msgCAE = new Mensaje("Solicitud a AFIP ejecutada con éxito", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                            msgCAE.ShowDialog();
                            factura.cae = rtaAfip.cae;
                            factura.fecVtoCae = DateTime.ParseExact(rtaAfip.FecVtoCAE, "yyyyMMdd", CultureInfo.InvariantCulture);
                            factura.estadoCarga = 1;
                            Global.Servicio.actualizarFactura(factura, Global.DatosSesion);
                            actualizarDatosAfip();
                        }
                        catch (Exception ex)
                        {
                            Mensaje errAfip = new Mensaje("ERROR EN LA LLAMADA A AFIP:" + ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                            errAfip.ShowDialog();
                            result = false;
                        }
                    }
                    
                    Mensaje unMensaje = new Mensaje("Factura cargada con éxito", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                    unMensaje.ShowDialog();

                    if (factura.pv == 1)
                    {
                        Global.Servicio.imprimirFactura(factura);
                        Global.Servicio.imprimirFactura(factura);
                    }
                    
                    //imprime la version digital
                    if (result)
                    {
                        Global.Servicio.imprimirFacturaDigital(factura);

                        if (factura.pv == 3)
                        {
                            var preguntaImpresion = new Mensaje("¿Desea enviar por mail la factura generada?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                            preguntaImpresion.ShowDialog();

                            if (preguntaImpresion.resultado == DialogResult.OK)
                            {
                                EnviarMail(factura);
                            }
                        }
                    }
                    else
                    {
                        if (rtaAfip.ErrorSolicitud != null)
                        {
                            frmErroresAfip form = new frmErroresAfip(rtaAfip);
                            form.Show();
                        }
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

        private void EnviarMail(Comprobante_Factura factura)
        {
            var formMails = new frmMails(factura);
            formMails.ShowDialog();            
        }

        private void actualizarDatosAfip()
        {            
            if (factura.cae != null)
                txtCAE.Text = factura.cae;
            else
                txtCAE.Text = "";

            if (factura.fecVtoCae != null)
            {
                dtpFecVtoCAE.Format = DateTimePickerFormat.Custom;
                dtpFecVtoCAE.CustomFormat = "dd/MM/yyyy";
                dtpFecVtoCAE.Value = (DateTime)factura.fecVtoCae;
            }
            else
            {
                dtpFecVtoCAE.Format = DateTimePickerFormat.Custom;
                dtpFecVtoCAE.CustomFormat = " ";
            }
        }

        private void completarCamposCliente(Cliente cliente)
        {
            txtCUIT.Text = cliente == null ? "" : cliente.cuit;
            txtRazonSocial.Text = cliente == null ? "" : cliente.razonSocial;
            txtDomicilio.Text = cliente == null ? "" : cliente.direccion;
            txtLocalidad.Text = cliente == null ? "" : cliente.Localidad.nombre;
            txtSitIva.Text = cliente == null ? "" : cliente.SituacionFrenteIva.nombre;

            sujetoObligado = null;

            if (cliente != null)
            {
                try
                {
                    using (var feClient = new FEAfip.ServicioCAEClient())
                    {
                        var requestConsulta = new FEAfip.DTOConsultaObligadoSolicitud();
                        requestConsulta.Cuit = long.Parse(cliente.cuit);
                        requestConsulta.FechaEmision = dtpFecha.Value;
                        sujetoObligado = feClient.ConsultarSujetoObligado(requestConsulta);
                    }
                }
                catch(Exception ex)
                {
                    Mensaje unMensaje = new Mensaje($"No se pudo conectar con AFIP para consultar padrón MiPyme. Error: {ex.Message}", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    unMensaje.ShowDialog();
                }
            }

            obtenerNroFactura();
        }

        private void completarDatosPlanta(Planta planta)
        {
            txtPlanta.Text = planta == null ? "" : planta.nombre;
            dgvItems.Rows.Clear();
            if (planta != null)
                dgvItems.Enabled = true;
        }

        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            cliente = Global.Servicio.buscarUnCliente("",txtCUIT.Text);  
            completarCamposCliente(cliente);
            planta = null;
            completarDatosPlanta(planta);
            //obtenerNroFactura();
        }

        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            cliente = Global.Servicio.buscarUnCliente(txtRazonSocial.Text.Trim(),"");
            completarCamposCliente(cliente);
            planta = null;
            completarDatosPlanta(planta);
            //obtenerNroFactura();
        }

        private void txtRazonSocial_Leave(object sender, EventArgs e)
        {
            txtRazonSocial_KeyPress(sender, new KeyPressEventArgs((char)Keys.Enter));
        }

        private void txtCUIT_Leave(object sender, EventArgs e)
        {
            txtCUIT_KeyPress(sender, new KeyPressEventArgs((char)Keys.Enter));
        }

        private long obtenerNroFactura(bool creditoElectronicoMiPyme = false, bool usarNumeracionCacheada = false)
        {
            string tipo;
            long numeroFactura = 0;

            if (cliente != null) 
            { 
                if (cliente.idSituacionFrenteIva == 4)
                    tipo = "A";
                else
                    tipo = "B";

                if (usarNumeracionCacheada)
                {
                    numeroFactura = creditoElectronicoMiPyme ? nroFacturaMiPyme : nroFacturaComun;
                }
                else
                {
                    numeroFactura = Global.Servicio.BuscarNroFactura(tipo, int.Parse(cboPtoVenta.Text), creditoElectronicoMiPyme);                    
                }

                txtNroFactura.Text = numeroFactura.ToString();
            }
            else
            {
                txtNroFactura.Text = "";
            }

            return numeroFactura;
        }

        private void dgvItems_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcularImportes(0,0,-1);
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            if (factura != null && Estado != Estados.Modificar && Estado != Estados.Agregar)
            {
                if (factura.pv == 1)
                {
                    Global.Servicio.imprimirFactura(factura);
                    Global.Servicio.imprimirFactura(factura);
                }
                if (factura.pv == 3)
                {
                    Global.Servicio.imprimirFacturaDigital(factura);
                }                
            }
            else
            {
                Mensaje unMensaje = new Mensaje("Debe seleccionar una Factura para reimprimir.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
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
                    artP=(ArticuloPlanta)fila.Tag;
                    fila.Cells["clmMon"].Value= mon.simbologia;                    
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

        private void btnVerErrores_Click(object sender, EventArgs e)
        {
            if (factura == null)
            {
                Mensaje msg = new Mensaje("Debe seleccionar una factura.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msg.Show();
                return;
            }

            int tipo;
            if (factura.tipo == "A")
                tipo = tipoAfipA;
            else
                tipo = tipoAfipB;

            FEAfip.ServicioCAEClient service = new FEAfip.ServicioCAEClient();
            FEAfip.DTOSolicitud solicitud = new FEAfip.DTOSolicitud();
            solicitud = service.obtenerUltimaSolicitudConError(tipo, int.Parse(cboPtoVenta.Text), long.Parse(txtNroFactura.Text));
            if (solicitud.ErrorSolicitud != null) 
            { 
                frmErroresAfip form = new frmErroresAfip(solicitud);
                form.Show();
            }
            else
            {
                Mensaje msg = new Mensaje("No hay errores para este comprobante", Mensaje.TipoMensaje.Informacion, Mensaje.Botones.OK);
                msg.Show();
            }
        }

        private void btnUltimoCompAut_Click(object sender, EventArgs e)
        {
            try
            {
                FEAfip.ServicioCAEClient service = new FEAfip.ServicioCAEClient();
                int nroCompA;
                int nroCompB;
                int nroCompAMiPyme;
                int nroCompBMiPyme;
                string mensaje = "";

                nroCompA = service.ObtenerUltimoAut(1, 3);
                nroCompB = service.ObtenerUltimoAut(6, 3);
                nroCompAMiPyme = service.ObtenerUltimoAut(201, 3);
                nroCompBMiPyme = service.ObtenerUltimoAut(206, 3);

                if (nroCompA != 0)
                {
                    FEAfip.DTOSolicitud solicitudA = new FEAfip.DTOSolicitud();
                    solicitudA = service.ConsultarCAE(1, 3, nroCompA);
                    Comprobante_Factura facturaA = Global.Servicio.buscarFactura(nroCompA, "A", 3, false);
                    facturaA.estadoCarga = 1;
                    facturaA.cae = solicitudA.cae;
                    facturaA.fecVtoCae = DateTime.ParseExact(solicitudA.FecVtoCAE, "yyyyMMdd", CultureInfo.InvariantCulture);
                    Global.Servicio.actualizarFactura(facturaA, Global.DatosSesion);
                    mensaje += "FACTURAS A:\n\r-Nro. Comprobante: " + nroCompA.ToString() + "\n\r-CAE: " + solicitudA?.cae + "\n\r-Fec. Vto. CAE: " + solicitudA?.FecVtoCAE.Substring(6, 2) + "/" + solicitudA?.FecVtoCAE.Substring(4, 2) + "/" + solicitudA?.FecVtoCAE.Substring(0, 4) + "\n\r";
                }

                if (nroCompB != 0)
                {
                    FEAfip.DTOSolicitud solicitudB = new FEAfip.DTOSolicitud();
                    solicitudB = service.ConsultarCAE(6, 3, nroCompB);
                    Comprobante_Factura facturaB = Global.Servicio.buscarFactura(nroCompB, "B", 3, false);
                    facturaB.estadoCarga = 1;
                    facturaB.cae = solicitudB.cae;
                    facturaB.fecVtoCae = DateTime.ParseExact(solicitudB.FecVtoCAE, "yyyyMMdd", CultureInfo.InvariantCulture);
                    Global.Servicio.actualizarFactura(facturaB, Global.DatosSesion);
                    mensaje += "FACTURAS B:\n\r-Nro. Comprobante: " + nroCompB.ToString() + "\n\r-CAE: " + solicitudB?.cae + "\n\r-Fec. Vto. CAE: " + solicitudB?.FecVtoCAE.Substring(6, 2) + "/" + solicitudB?.FecVtoCAE.Substring(4, 2) + "/" + solicitudB?.FecVtoCAE.Substring(0, 4) + "\n\r"; ;
                }

                if (nroCompAMiPyme != 0)
                {
                    FEAfip.DTOSolicitud solicitudA = new FEAfip.DTOSolicitud();
                    solicitudA = service.ConsultarCAE(201, 3, nroCompAMiPyme);
                    Comprobante_Factura facturaA = Global.Servicio.buscarFactura(nroCompAMiPyme, "A", 3, true);
                    facturaA.estadoCarga = 1;
                    facturaA.cae = solicitudA.cae;
                    facturaA.fecVtoCae = DateTime.ParseExact(solicitudA.FecVtoCAE, "yyyyMMdd", CultureInfo.InvariantCulture);
                    Global.Servicio.actualizarFactura(facturaA, Global.DatosSesion);
                    mensaje += "FACTURAS A (CE MiPyme):\n\r-Nro. Comprobante: " + nroCompAMiPyme.ToString() + "\n\r-CAE: " + solicitudA?.cae + "\n\r-Fec. Vto. CAE: " + solicitudA?.FecVtoCAE.Substring(6, 2) + "/" + solicitudA?.FecVtoCAE.Substring(4, 2) + "/" + solicitudA?.FecVtoCAE.Substring(0, 4) + "\n\r";
                }

                if (nroCompBMiPyme != 0)
                {
                    FEAfip.DTOSolicitud solicitudB = new FEAfip.DTOSolicitud();
                    solicitudB = service.ConsultarCAE(206, 3, nroCompBMiPyme);
                    Comprobante_Factura facturaB = Global.Servicio.buscarFactura(nroCompBMiPyme, "B", 3, false);
                    facturaB.estadoCarga = 1;
                    facturaB.cae = solicitudB.cae;
                    facturaB.fecVtoCae = DateTime.ParseExact(solicitudB.FecVtoCAE, "yyyyMMdd", CultureInfo.InvariantCulture);
                    Global.Servicio.actualizarFactura(facturaB, Global.DatosSesion);
                    mensaje += "FACTURAS B (CE MiPyme):\n\r-Nro. Comprobante: " + nroCompBMiPyme.ToString() + "\n\r-CAE: " + solicitudB?.cae + "\n\r-Fec. Vto. CAE: " + solicitudB?.FecVtoCAE.Substring(6, 2) + "/" + solicitudB?.FecVtoCAE.Substring(4, 2) + "/" + solicitudB?.FecVtoCAE.Substring(0, 4);
                }

                MessageBox.Show(mensaje, "Resultado AFIP");
            }
            catch (Exception ex)
            {
                Mensaje errAfip = new Mensaje("ERROR EN LA LLAMADA A AFIP:" + ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                errAfip.ShowDialog();
            } 
        }

        private void btnConsultarCAE_Click(object sender, EventArgs e)
        {
            if (factura == null)
            {
                Mensaje msg = new Mensaje("Debe seleccionar una factura.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msg.Show();
                return;
            }

            int tipo;
            if (factura.tipo == "A")
                tipo = tipoAfipA;
            else
                tipo = tipoAfipB;

            FEAfip.DTOSolicitud solicitud = new FEAfip.DTOSolicitud();

            try
            { 
                FEAfip.ServicioCAEClient service = new FEAfip.ServicioCAEClient();
                solicitud = service.ConsultarCAE(tipo, int.Parse(cboPtoVenta.Text), long.Parse(txtNroFactura.Text));
                if (solicitud != null)
                {                    
                    if (factura.estadoCarga != 1)
                    {
                        factura.cae = solicitud.cae;
                        factura.fecVtoCae = DateTime.ParseExact(solicitud.FecVtoCAE, "yyyyMMdd", CultureInfo.InvariantCulture);
                        factura.estadoCarga = 1;
                        Global.Servicio.actualizarFactura(factura, Global.DatosSesion);
                        actualizarDatosAfip();
                    }
                    
                    Mensaje mensajeConfirmacion = new Mensaje("CAE: " + solicitud.cae + " - " + "Fec. Vto.: " + DateTime.ParseExact(solicitud.FecVtoCAE, "yyyyMMdd", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy"), Mensaje.TipoMensaje.Informacion, Mensaje.Botones.OK);
                    mensajeConfirmacion.ShowDialog();
                }
                else
                {
                    Mensaje mensajeConfirmacion = new Mensaje("No existe CAE para esta factura", Mensaje.TipoMensaje.Informacion, Mensaje.Botones.OK);
                    mensajeConfirmacion.ShowDialog();
                }                
            }

            catch (Exception ex)
            {
                Mensaje errAfip = new Mensaje("ERROR EN LA LLAMADA A AFIP:" + ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                errAfip.ShowDialog();
            }
            
        }

        private void cboPtoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerNroFactura();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                FEAfip.ServicioCAEClient service = new FEAfip.ServicioCAEClient();
                string[] listaEstado = service.EstadoServidores();
                
                if (listaEstado != null)
                {
                    String mensaje = "AppServer: "+ listaEstado[0] + " - AuthServer: " + listaEstado[1] + " - DbServer: " + listaEstado[2];
                    Mensaje informe = new Mensaje(mensaje, Mensaje.TipoMensaje.Informacion, Mensaje.Botones.OK);
                    informe.ShowDialog();
                }
                else
                {
                    Mensaje errAfip = new Mensaje("No se pudo conectar con los Servidores de AFIP", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    errAfip.ShowDialog();
                }
                
            }
            catch (Exception ex)
            {
                Mensaje errAfip = new Mensaje("ERROR EN LA LLAMADA A AFIP" + ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                errAfip.ShowDialog();
            }
        }

        private void btnConsultarMonedas_Click(object sender, EventArgs e)
        {
            String mensaje="";
            FEAfip.ServicioCAEClient service = new FEAfip.ServicioCAEClient();
            string[][] listaMonedas = service.ObtenerMonHabilitadas();
            
            foreach (string[] mon in listaMonedas)
            {
                mensaje += mon[0] + " - " + mon[1] + Environment.NewLine;
            }

            MessageBox.Show(mensaje);
        }

        private void dgvRemitos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 1 || dgvRemitos.Rows[e.RowIndex].Cells[0].Value == null)
                return;
            long l;
            if (!long.TryParse(dgvRemitos.Rows[e.RowIndex].Cells[0].Value.ToString(), out l))
                return;

            FacturarRemito(dgvRemitos.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void FacturarRemito(string nroRemito)
        {
            Comprobante_Remito remito = Global.Servicio.buscarUnRemito(long.Parse(nroRemito));
            Mensaje msj;
            if (remito == null)
            {
                msj = new Mensaje("El remito seleccionado no existe", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msj.ShowDialog();
                return;
            }
            if (planta != null && planta != remito.Planta)
            {
                msj = new Mensaje("El remito seleccionado pertenece a otra planta.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msj.ShowDialog();
                return;
            }

            if (planta == null)
            {
                planta = remito.Planta;
                completarDatosPlanta(planta);
            }

            if (cliente == null && planta.Cliente != null)
            {
                cliente = planta.Cliente;
                completarCamposCliente(cliente);
            }

            bool hayItemsPendientes = false;

            foreach (VentaArticuloPlanta item in remito.VentaArticuloPlanta)
            {
                ArticuloPlanta artPla = Global.Servicio.BuscarUnArticuloPlantaXDesc(item.Comprobante.Planta, item.TipoArticulo.nombre);
                decimal cantRestante = Global.Servicio.CantidadPendienteFacturacion(item);
                if (cantRestante > 0)
                {
                    hayItemsPendientes = true;
                    int fila = dgvItems.Rows.Add();
                    dgvItems.Rows[fila].Tag = artPla;
                    dgvItems[dgvItems.Columns["clmArt"].Index, fila].Value = artPla.Planta.codigo.Trim() + artPla.contador.ToString().Trim();
                    dgvItems[dgvItems.Columns["clmCant"].Index, fila].Value = cantRestante.ToString();
                    dgvItems[dgvItems.Columns["clmDesc"].Index, fila].Value = item.TipoArticulo.nombre;
                    dgvItems[dgvItems.Columns["clmUnidad"].Index, fila].Value = item.TipoArticulo.Unidad.abreviatura;
                    dgvItems[dgvItems.Columns["clmMon"].Index, fila].Value = ((Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value).simbologia;
                    dgvItems[dgvItems.Columns["clmPrecio"].Index, fila].Value = Global.Servicio.ConviertePrecio(item.precio, item.Moneda, (Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value);
                    dgvItems.Rows[fila].Cells["clmPrecio"].Tag = item.precio;
                    dgvItems[dgvItems.Columns["clmRem"].Index, fila].Value = remito.numero.ToString();
                    dgvItems[dgvItems.Columns["clmIdRem"].Index, fila].Value = remito.id.ToString();
                    calcularImportes(decimal.Parse(dgvItems[dgvItems.Columns["clmCant"].Index, fila].FormattedValue.ToString()), decimal.Parse(dgvItems[dgvItems.Columns["clmPrecio"].Index, fila].Value.ToString()), fila);
                }
            }

            if (!hayItemsPendientes)
            {
                msj = new Mensaje("El remito seleccionado está facturado totalemte", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msj.ShowDialog();
                return;
            }
        }

        private void btnEnviarMail_Click(object sender, EventArgs e)
        {
            if (factura != null && Estado != Estados.Modificar && Estado != Estados.Agregar && factura.pv == 3)
            {
                EnviarMail(factura);
            }
            else
            {
                Mensaje unMensaje = new Mensaje("Debe seleccionar una Factura Electrónica para enviar por mail.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }
    }
}
