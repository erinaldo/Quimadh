using Controles;
using Desktop.Vistas.Administracion;
using Entidades;
using Frontend.Controles;
using System;
using System.Windows.Forms;

namespace Desktop.Vistas.Ventas
{
    public partial class frmRecibos : FormBaseConToolbar
    {
        private Comprobante_Recibo recibo;
        private Cliente cliente;
        private Planta planta;

        public frmRecibos()
        {
            InitializeComponent();
        }

        protected override void cargar()
        {
            txtNroRecibo.Text = Global.Servicio.BuscarNroRecibo().ToString();
            txtTotal1.Text = "0";
            txtTotal2.Text = "0";
            Cargador.cargarNombresClientes(txtRazonSocial);
            gpbDatosRec.Enabled = false;
            gpbDatos.Enabled = false;
            gpbTotales.Enabled = false;
            dgvItems.Enabled = false;
            btnPago.Enabled = false;

            btnEliminar.Text = "Anular";
        }

        protected override void agregar()
        {
            recibo = new Comprobante_Recibo();
            cliente = null;
            planta = null;
            limpiarControles(gpbDatos);
            limpiarControles(gpbDatosRec);
            limpiarControles(gpbTotales);
            dgvItems.Rows.Clear();
            gpbDatos.Enabled = true;
            gpbDatosRec.Enabled = true;
            gpbTotales.Enabled = true;
            dgvItems.Enabled = true;
            txtNroRecibo.Text = Global.Servicio.BuscarNroRecibo().ToString();
            btnPago.Enabled = true;
        }

        protected override void modificar()
        {
            //recibo = new Comprobante_Recibo();
            gpbDatos.Enabled = true;
            gpbDatosRec.Enabled = false;
            gpbTotales.Enabled = false;
            dgvItems.Enabled = false;
            btnPago.Enabled = true;
            txtDomicilio.Focus();
        }

        protected override bool eliminar()
        {
            if (recibo != null)
            {
                Mensaje mensajeConfirmacion = new Mensaje("El Recibo número '" + recibo.numero.ToString() + "' será anulado ¿Está seguro?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                mensajeConfirmacion.ShowDialog();

                if (mensajeConfirmacion.resultado == DialogResult.OK)
                {
                    try
                    {
                        Mensaje mensajeExito;
                        Global.Servicio.anularComprobante(recibo, Global.DatosSesion);
                        mensajeExito = new Mensaje("El Recibo número '" + recibo.numero.ToString() + "' ha sido anulado con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
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
                Mensaje unMensaje = new Mensaje("Debe seleccionar un recibo.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return false;
        }

        protected override void limpiar()
        {
            //recibo = null;
            if (Estado != Estados.Modificar)
            {
                // Limpia los datos del formulario
                limpiarControles(gpbDatos);
                limpiarControles(gpbDatosRec);
                limpiarControles(gpbTotales);
                dgvItems.Rows.Clear();
            }
            gpbDatos.Enabled = false;
            gpbDatosRec.Enabled = false;
            gpbTotales.Enabled = false;
            dgvItems.Enabled = false;
            btnPago.Enabled = false;
        }

        protected override bool cargarBusqueda()
        {
            frmBusquedaComp frmBusquedaComp = new frmBusquedaComp();
            frmBusquedaComp.Tipo = "recibo";
            DialogResult res = frmBusquedaComp.ShowDialog();

            if (res == DialogResult.OK)
            {
                recibo = (Comprobante_Recibo)frmBusquedaComp.comprobanteSeleccionado;
                planta = recibo.Planta;
                cliente = recibo.Planta.Cliente;
                cargarDatos(recibo);

                return true;
            }

            return false;
        }

        private void cargarDatos(Comprobante_Recibo recibo)
        {
            DateTime fi;
            DateTime fd;
            decimal ii;
            decimal id;

            txtNroRecibo.Text = recibo.numero.ToString();
            dtpFecha.Value = recibo.fechaIngreso;
            txtPlanta.Text = recibo.Planta.nombre;
            txtRazonSocial.Text = recibo.Planta.Cliente.razonSocial;
            txtDomicilio.Text = recibo.Planta.Cliente.direccion;
            txtLocalidad.Text = recibo.Planta.Cliente.Localidad.nombre;
            txtSitIva.Text = recibo.Planta.Cliente.SituacionFrenteIva.nombre;
            txtCUIT.Text = recibo.Planta.Cliente.cuit;            
            txtTotal1.Text = recibo.importe.ToString("0.00");
            txtTotal2.Text = recibo.importe.ToString("0.00");

            int i = 0;
            dgvItems.Rows.Clear();
            foreach (ItemRecibo itemRec in recibo.ItemRecibo)
            {
                dgvItems.Rows.Add();
                if (itemRec.fechaIzq != null)
                {
                    fi = (DateTime)itemRec.fechaIzq;
                    dgvItems.Rows[i].Cells["clmFechaIzq"].Value = fi.ToString("dd/MM/yyyy");
                }
                    
                dgvItems.Rows[i].Cells["clmDescIzq"].Value = itemRec.descripIzq;

                if (itemRec.importeIzq != null)
                {
                    ii = (decimal)itemRec.importeIzq;
                    dgvItems.Rows[i].Cells["clmImporteIzq"].Value = ii.ToString("0.00");
                }
                if (itemRec.fechaDer != null)
                {
                    fd = (DateTime)itemRec.fechaDer;
                    dgvItems.Rows[i].Cells["clmFechaDer"].Value = fd.ToString("dd/MM/yyyy");
                }
                                
                dgvItems.Rows[i].Cells["clmDescDer"].Value = itemRec.descripDer;

                if (itemRec.importeDer != null)
                {
                    id = (decimal)itemRec.importeDer;
                    dgvItems.Rows[i].Cells["clmImporteDer"].Value = id.ToString("0.00");
                }
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

        protected override bool guardar()
        {
            try
            {
                if (dgvItems.Rows.Count <= 1)
                {
                    Mensaje msjErr = new Mensaje("La grilla no puede estar vacía.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    msjErr.ShowDialog();
                    return false;
                }

                if (txtTotal1.Text != txtTotal2.Text)
                {
                    Mensaje msjErr = new Mensaje("Los totales no coinciden.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    msjErr.ShowDialog();
                    return false;
                }

                if (cliente != null && planta != null)
                {
                    if (Estado == Estados.Agregar)
                    {
                        //recibo = new Comprobante_Recibo();
                        if (txtNroRecibo.Text != "")
                            recibo.numero = long.Parse(txtNroRecibo.Text);
                        else
                            recibo.numero = 0;
                        if (txtTotal1.Text != "")
                            recibo.importe = decimal.Parse(txtTotal1.Text);
                        else
                            recibo.importe = 0;

                        recibo.Planta = planta;
                        recibo.fechaIngreso = dtpFecha.Value;
                        recibo.anulado = false;
                        recibo.formaPago = txtFormaPago.Text;

                        foreach (DataGridViewRow fila in dgvItems.Rows)
                        {
                            if (!fila.IsNewRow)
                            {
                                ItemRecibo item = new ItemRecibo();

                                if (fila.Cells["clmImporteIzq"].FormattedValue.ToString().Trim() != "")
                                    item.importeIzq = decimal.Parse(fila.Cells["clmImporteIzq"].Value.ToString());
                                item.descripIzq = fila.Cells["clmDescIzq"].FormattedValue.ToString();
                                if (fila.Cells["clmFechaIzq"].FormattedValue.ToString().Trim() != "")
                                    item.fechaIzq = DateTime.Parse(fila.Cells["clmFechaIzq"].Value.ToString());
                                if (fila.Cells["clmImporteDer"].FormattedValue.ToString().Trim() != "")
                                    item.importeDer = decimal.Parse(fila.Cells["clmImporteDer"].Value.ToString());
                                item.descripDer = fila.Cells["clmDescDer"].FormattedValue.ToString();
                                if (fila.Cells["clmFechaDer"].FormattedValue.ToString().Trim() != "")
                                    item.fechaDer = DateTime.Parse(fila.Cells["clmFechaDer"].Value.ToString());

                                recibo.ItemRecibo.Add(item);
                            }
                        }

                        Global.Servicio.AgregarRecibo(recibo, Global.DatosSesion);
                        Mensaje unMensaje = new Mensaje("Recibo cargado con éxito", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                        unMensaje.ShowDialog();

                        Global.Servicio.ImprimirRecibo(recibo);
                        Global.Servicio.ImprimirRecibo(recibo);

                        Global.Servicio.ImprimirReciboDigital(recibo);
                    }
                    else if (Estado == Estados.Modificar)
                    {
                        Global.Servicio.ActualizarRecibo(recibo, Global.DatosSesion);
                        Mensaje unMensaje = new Mensaje("Recibo modificado con éxito", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                    }
                    
                    return true;
                }
                else
                {
                    Mensaje unMensaje = new Mensaje("Debe seleccionar un cliente y una planta.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    unMensaje.ShowDialog();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
                return false;
            }
        }

        private void dgvItems_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItems.EditingControl == null)
                return;

            if (dgvItems[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmFechaIzq" || dgvItems[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmFechaDer")
            {
                DateTime fec;
                if (DateTime.TryParse(dgvItems.EditingControl.Text, out fec) && fec.Year>1900)
                {
                    dgvItems.EditingControl.Text = fec.ToString("dd/MM/yyyy");                    
                }
                else
                {
                    dgvItems.EditingControl.Text = "";
                }
            }

            if (dgvItems[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmImporteIzq")
            {
                decimal valI;
                if (!decimal.TryParse(dgvItems.EditingControl.Text, out valI))
                {
                    dgvItems.EditingControl.Text = "";
                }

                decimal sumaI = 0;
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        sumaI += decimal.Parse(row.Cells["clmImporteIzq"].EditedFormattedValue.ToString() == "" ? "0" : row.Cells["clmImporteIzq"].EditedFormattedValue.ToString());
                    }
                }
                txtTotal1.Text = sumaI.ToString("0.00");
            }
            if (dgvItems[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmImporteDer")
            {
                decimal valD;
                if (! decimal.TryParse(dgvItems.EditingControl.Text, out valD))
                {
                    dgvItems.EditingControl.Text = "";
                }

                decimal sumaD = 0;
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        sumaD += decimal.Parse(row.Cells["clmImporteDer"].EditedFormattedValue.ToString() == "" ? "0" : row.Cells["clmImporteDer"].EditedFormattedValue.ToString());
                    }
                }
                txtTotal2.Text = sumaD.ToString("0.00");
            }
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
            decimal sumaI = 0;
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (!row.IsNewRow)
                {
                    sumaI += decimal.Parse(row.Cells["clmImporteIzq"].EditedFormattedValue.ToString());
                }
            }
            txtTotal1.Text = sumaI.ToString("0.00");

            decimal sumaD = 0;
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (!row.IsNewRow)
                {
                    sumaD += decimal.Parse(row.Cells["clmImporteDer"].EditedFormattedValue.ToString());
                }
            }
            txtTotal2.Text = sumaD.ToString("0.00");
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            if (recibo != null && Estado != Estados.Modificar && Estado != Estados.Agregar)
            {
                Global.Servicio.ImprimirRecibo(recibo);
                Global.Servicio.ImprimirRecibo(recibo);

                Global.Servicio.ImprimirReciboDigital(recibo);
            }
            else
            {
                Mensaje unMensaje = new Mensaje("Debe seleccionar un Recibo para reimprimir.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                Mensaje unMensaje = new Mensaje("Debe seleccionar el cliente antes de cargar el pago", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();

                return;
            }

            var formPagos = new frmPagos(recibo, cliente);
            formPagos.ShowDialog();
        }
    }
}
