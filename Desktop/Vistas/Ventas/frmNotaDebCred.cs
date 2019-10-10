using Controles;
using Desktop.Vistas.Administracion;
using Entidades;
using Frontend.Controles;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Desktop.Vistas.Ventas
{
    public partial class frmNotaDebCred : FormBaseConToolbar
    {
        private Comprobante_Devolucion notaCred;
        private Comprobante_Recargo notaDeb;
        private Cliente cliente;
        private Planta planta;

        private FEAfip.DTOConsultaObligadoRespuesta sujetoObligado;
        private bool SujetoObligado => sujetoObligado?.Obligado ?? false;
        private decimal MontoObligado => sujetoObligado?.MontoDesde ?? 0;

        private long nroNotaComun = 0;
        private long nroNotaMiPyme = 0;

        public frmNotaDebCred()
        {
            InitializeComponent();
        }

        protected override void cargar()
        {
            sujetoObligado = null;
            nroNotaMiPyme = 0;
            nroNotaComun = 0;

            Cargador.cargarMonedas(cboMoneda);
            cboMoneda.SelectedIndex = cboMoneda.FindStringExact("Peso");   
            txtSubtotal.Text = "0";
            txtIVA.Text = "0";
            txtTotal.Text = "0";
            Cargador.cargarNombresClientes(txtRazonSocial);
            gpbDatosNota.Enabled = false;
            gpbDatos.Enabled = false;
            gpbTotales.Enabled = false;
            dgvItems.Enabled = false;
            txtNroCompAsoc.Tag = null;

            btnEliminar.Text = "Anular";
        }

        protected override void agregar()
        {
            notaDeb = new Comprobante_Recargo();
            notaCred = new Comprobante_Devolucion();
            cliente = null;
            planta = null;
            limpiarControles(gpbDatos);
            limpiarControles(gpbDatosNota);
            limpiarControles(gpbTotales);
            dgvItems.Rows.Clear();
            gpbDatos.Enabled = true;
            gpbDatosNota.Enabled = true;
            gpbTotales.Enabled = true;
            cboMoneda.SelectedIndex = cboMoneda.FindStringExact("Peso");
            cboTipoNota_SelectedIndexChanged(new object(),new EventArgs());
            txtNroCompAsoc.Tag = null;
            dtpFecVtoCAE.Format = DateTimePickerFormat.Custom;
            dtpFecVtoCAE.CustomFormat = " ";
        }

        protected override void modificar()
        {
            if (cboTipoNota.Text == "")
            {
                Mensaje msg = new Mensaje("Selccione un tipo de nota", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msg.Show();
                cambiarEstado(Estados.Consultar);
                return;
            }

            if (cboTipoNota.Text == "Nota Crédito")
            {
                if (notaCred.pv != 3 || notaCred.estadoCarga == 1)
                {
                    Mensaje msg = new Mensaje("No se puede modificar una nota de crédito ya generada.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    msg.Show();
                    cambiarEstado(Estados.Consultar);
                    return;
                }
            }
            if (cboTipoNota.Text == "Nota Débito")
            {
                if (notaDeb.pv != 3 || notaDeb.estadoCarga == 1)
                {
                    Mensaje msg = new Mensaje("No se puede modificar una nota de débito ya generada.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    msg.Show();
                    cambiarEstado(Estados.Consultar);
                    return;
                }
            }
            gpbDatos.Enabled = true;
            gpbDatosNota.Enabled = true;
            gpbTotales.Enabled = true;
            dgvItems.Enabled = true;
            txtDomicilio.Focus();       
        }

        protected override bool eliminar()
        {
            if (cboTipoNota.Text == "Nota Crédito")
            {
                if (notaCred != null)
                {
                    Mensaje mensajeConfirmacion = new Mensaje("La Nota de crédito número '" + notaCred.numero.ToString() + "' será anulada ¿Está seguro?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                    mensajeConfirmacion.ShowDialog();

                    if (mensajeConfirmacion.resultado == DialogResult.OK)
                    {
                        try
                        {
                            Mensaje mensajeExito;
                            Global.Servicio.anularComprobante(notaCred, Global.DatosSesion);
                            mensajeExito = new Mensaje("La Nota de crédito número '" + notaCred.numero.ToString() + "' ha sido anulada con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
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
                    Mensaje unMensaje = new Mensaje("Debe seleccionar una nota de crédito.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
                    unMensaje.ShowDialog();
                }
            }
            else
            {
                if (notaDeb != null)
                {
                    Mensaje mensajeConfirmacion = new Mensaje("La Nota de débito número '" + notaDeb.numero.ToString() + "' será anulada ¿Está seguro?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                    mensajeConfirmacion.ShowDialog();

                    if (mensajeConfirmacion.resultado == DialogResult.OK)
                    {
                        try
                        {
                            Mensaje mensajeExito;
                            Global.Servicio.anularComprobante(notaDeb, Global.DatosSesion);
                            mensajeExito = new Mensaje("La Nota de débito número '" + notaDeb.numero.ToString() + "' ha sido anulada con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
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
                    Mensaje unMensaje = new Mensaje("Debe seleccionar una nota de débito.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
                    unMensaje.ShowDialog();
                }
            }
            
            return false;
        }

        protected override void limpiar()
        {
            notaCred = null;
            notaDeb = null;

            sujetoObligado = null;
            nroNotaMiPyme = 0;
            nroNotaComun = 0;

            limpiarControles(gpbDatos);
            limpiarControles(gpbDatosNota);
            limpiarControles(gpbTotales);
            dgvItems.Rows.Clear();

            gpbDatos.Enabled = false;
            gpbDatosNota.Enabled = false;
            gpbTotales.Enabled = false;
            dgvItems.Enabled = false;            
            txtNroCompAsoc.Tag = null;
        }

        protected override bool cargarBusqueda()
        {
            if (cboTipoNota.Text == "")
            {
                Mensaje msg = new Mensaje("Selccione un tipo de nota", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msg.Show();
                return false;
            }

            if (cboTipoNota.Text == "Nota Crédito")
            {
                frmBusquedaComp frmBusquedaComp = new frmBusquedaComp();
                frmBusquedaComp.tipo = "notaCredito";
                DialogResult res = frmBusquedaComp.ShowDialog();

                if (res == DialogResult.OK)
                {
                    notaCred = (Comprobante_Devolucion)frmBusquedaComp.comprobanteSeleccionado;
                    planta = notaCred.Planta;
                    cliente = notaCred.Planta.Cliente;
                    cargarDatos(notaCred);
                    return true;
                }
            }
            else
            {
                frmBusquedaComp frmBusquedaComp = new frmBusquedaComp();
                frmBusquedaComp.tipo = "notaDebito";
                DialogResult res = frmBusquedaComp.ShowDialog();

                if (res == DialogResult.OK)
                {
                    notaDeb = (Comprobante_Recargo)frmBusquedaComp.comprobanteSeleccionado;
                    planta = notaDeb.Planta;
                    cliente = notaDeb.Planta.Cliente;
                    cargarDatos(notaDeb);
                    return true;
                }
            }

            return false;
        }

        private void cargarDatos(Comprobante_Devolucion notaCred)
        {
            txtNroNota.Text = notaCred.numero.ToString();
            dtpFecha.Value = notaCred.fechaIngreso;
            txtPlanta.Text = notaCred.Planta.nombre;
            txtRazonSocial.Text = notaCred.Planta.Cliente.razonSocial;
            txtDomicilio.Text = notaCred.Planta.Cliente.direccion;
            txtLocalidad.Text = notaCred.Planta.Cliente.Localidad.nombre;
            txtSitIva.Text = notaCred.Planta.Cliente.SituacionFrenteIva.nombre;
            txtCUIT.Text = notaCred.Planta.Cliente.cuit;
            txtSubtotal.Text = Math.Round(notaCred.subtotal,2).ToString("0.00");
            txtIVA.Text = Math.Round(notaCred.totalIva,2).ToString("0.00");
            txtTotal.Text = Math.Round(notaCred.importe,2).ToString("0.00");
            txtMotivo.Text = notaCred.motivo;
            cboPtoVta.SelectedIndex = cboPtoVta.FindStringExact(notaCred.pv.ToString());
            txtCondVta.Text = notaCred.condVta;
            if (notaCred.cae != null)
                txtCAE.Text = notaCred.cae;
            if (notaCred.fecVtoCae != null)
            { 
                dtpFecVtoCAE.Format = DateTimePickerFormat.Custom;
                dtpFecVtoCAE.CustomFormat = "dd/MM/yyyy";
                dtpFecVtoCAE.Value = (DateTime)notaCred.fecVtoCae;
            }
            else
            {
                dtpFecVtoCAE.Format = DateTimePickerFormat.Custom;
                dtpFecVtoCAE.CustomFormat = " ";
            }

            if (notaCred.ComprobanteAnul != null) 
            { 
                switch (notaCred.ComprobanteAnul.GetType().BaseType.Name)
                {
                    case "Comprobante_Factura":
                        cboTipoCompAsoc.SelectedIndex = cboTipoCompAsoc.FindStringExact("factura");
                        txtNroCompAsoc.Text = ((Comprobante_Factura)notaCred.ComprobanteAnul).numero.ToString();
                        break;
                    case "Comprobante_Recargo":
                        cboTipoCompAsoc.SelectedIndex = cboTipoCompAsoc.FindStringExact("nota débito");
                        txtNroCompAsoc.Text = ((Comprobante_Recargo)notaCred.ComprobanteAnul).numero.ToString();
                        break;
                }
                txtNroCompAsoc.Tag = notaCred.ComprobanteAnul;
            }
            else
            {
                cboTipoCompAsoc.SelectedIndex = -1;
                txtNroCompAsoc.Text = "";
                txtNroCompAsoc.Tag = null;
            }


            int i = 0;
            dgvItems.Rows.Clear();
            foreach (ItemNota itemN in notaCred.ItemNota)
            {
                dgvItems.Rows.Add();
                dgvItems.Rows[i].Cells["clmCant"].Value = Math.Round(((decimal)itemN.cantidad),2).ToString("0.00");
                dgvItems.Rows[i].Cells["clmDetalle"].Value = itemN.descripcion;
                dgvItems.Rows[i].Cells["clmMon"].Value = notaCred.Moneda.simbologia;
                dgvItems.Rows[i].Cells["clmImporte"].Value = Math.Round(itemN.importe,2).ToString("0.00");
                dgvItems.Rows[i].Cells["clmIVA"].Value = Math.Round(((decimal)itemN.iva),2).ToString("0.00");
                decimal total = 0;
                if (cliente.SituacionFrenteIva.nombre == "Responsable Inscripto")
                    total = Math.Round(Math.Round((decimal)itemN.cantidad,2) * Math.Round((decimal)itemN.importe,2),2);
                else
                    total = Math.Round(Math.Round((decimal)itemN.cantidad,2) * Math.Round((decimal)itemN.importe,2) * (((decimal)itemN.iva / 100) + 1),2);
                dgvItems.Rows[i].Cells["clmTotal"].Value = total.ToString("0.00");              

                i++;
            }
        }

        private void cargarDatos(Comprobante_Recargo notaDeb)
        {
            txtNroNota.Text = notaDeb.numero.ToString();
            dtpFecha.Value = notaDeb.fechaIngreso;
            txtPlanta.Text = notaDeb.Planta.nombre;
            txtRazonSocial.Text = notaDeb.Planta.Cliente.razonSocial;
            txtDomicilio.Text = notaDeb.Planta.Cliente.direccion;
            txtLocalidad.Text = notaDeb.Planta.Cliente.Localidad.nombre;
            txtSitIva.Text = notaDeb.Planta.Cliente.SituacionFrenteIva.nombre;
            txtCUIT.Text = notaDeb.Planta.Cliente.cuit;
            txtSubtotal.Text = Math.Round(notaDeb.subtotal,2).ToString("0.00");
            txtIVA.Text = Math.Round(notaDeb.totalIva,2).ToString("0.00");
            txtTotal.Text = Math.Round(notaDeb.importe,2).ToString("0.00");
            txtMotivo.Text = notaDeb.motivo;
            cboPtoVta.SelectedIndex = cboPtoVta.FindStringExact(notaDeb.pv.ToString());
            txtCondVta.Text = notaDeb.condVta;
            if (notaDeb.cae != null)
                txtCAE.Text = notaDeb.cae;
            if (notaDeb.fecVtoCae != null)
            {
                dtpFecVtoCAE.Format = DateTimePickerFormat.Custom;
                dtpFecVtoCAE.CustomFormat = "dd/MM/yyyy";
                dtpFecVtoCAE.Value = (DateTime)notaDeb.fecVtoCae;
            }
            else
            {
                dtpFecVtoCAE.Format = DateTimePickerFormat.Custom;
                dtpFecVtoCAE.CustomFormat = " ";
            }

            if (notaDeb.ComprobanteAnul != null)
            {
                switch (notaDeb.ComprobanteAnul.GetType().BaseType.Name)
                {
                    case "Comprobante_Devolucion":
                        cboTipoCompAsoc.SelectedIndex = cboTipoCompAsoc.FindStringExact("nota crédito");
                        txtNroCompAsoc.Text = ((Comprobante_Devolucion)notaDeb.ComprobanteAnul).numero.ToString();
                        break;
                }
                txtNroCompAsoc.Tag = notaDeb.ComprobanteAnul;
            }
            else
            {
                cboTipoCompAsoc.SelectedIndex = -1;
                txtNroCompAsoc.Text = "";
                txtNroCompAsoc.Tag = null;
            }

            int i = 0;
            dgvItems.Rows.Clear();
            foreach (ItemNota itemN in notaDeb.ItemNota)
            {
                dgvItems.Rows.Add();
                dgvItems.Rows[i].Cells["clmCant"].Value = ((decimal)itemN.cantidad).ToString("0.00");
                dgvItems.Rows[i].Cells["clmDetalle"].Value = itemN.descripcion;
                dgvItems.Rows[i].Cells["clmMon"].Value = notaDeb.Moneda.simbologia;
                dgvItems.Rows[i].Cells["clmImporte"].Value = Math.Round(itemN.importe,2).ToString("0.00");
                dgvItems.Rows[i].Cells["clmIVA"].Value = Math.Round(((decimal)itemN.iva),2).ToString("0.00");
                decimal total=0;
                if (cliente.SituacionFrenteIva.nombre == "Responsable Inscripto")
                    total = Math.Round(Math.Round((decimal)itemN.cantidad,2) * Math.Round((decimal)itemN.importe,2),2);
                else
                    total = Math.Round(Math.Round((decimal)itemN.cantidad,2) * Math.Round((decimal)itemN.importe,2) * (((decimal)itemN.iva / 100) + 1),2);
                dgvItems.Rows[i].Cells["clmTotal"].Value = total.ToString("0.00");

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

        private long ObtenerNroNota(bool creditoElectronicoMiPyme = false, bool usarNumeracionCacheada = false)
        {
            long numeroNota = 0;

            if (cliente != null)
            {
                string tipo;
                if (cliente.SituacionFrenteIva.id == 4)
                {
                    tipo = "A";
                }
                else
                {
                    tipo = "B";
                }

                switch (cboTipoNota.Text)
                {
                    case "Nota Crédito":
                        numeroNota = Global.Servicio.BuscarNroNotaCred(tipo, int.Parse(cboPtoVta.Text), creditoElectronicoMiPyme);
                        break;
                    case "Nota Débito":
                        numeroNota = Global.Servicio.BuscarNroNotaDeb(tipo, int.Parse(cboPtoVta.Text), creditoElectronicoMiPyme);
                        break;
                    default:
                        numeroNota = 0;
                        break;
                }
            }
            else
            {
                numeroNota = 0;
            }

            txtNroNota.Text = numeroNota == 0 ? string.Empty : numeroNota.ToString();

            return numeroNota;
            
        }

        private void completarCamposCliente(Cliente cliente)
        {
            ObtenerNroNota();
            txtCUIT.Text = cliente == null ? "" : cliente.cuit;
            txtRazonSocial.Text = cliente == null ? "" : cliente.razonSocial;
            txtDomicilio.Text = cliente == null ? "" : cliente.direccion;
            txtLocalidad.Text = cliente == null ? "" : cliente.Localidad.nombre;
            txtSitIva.Text = cliente == null ? "" : cliente.SituacionFrenteIva.nombre;

            sujetoObligado = null;

            if (cliente != null)
            {
                using (var feClient = new FEAfip.ServicioCAEClient())
                {
                    var requestConsulta = new FEAfip.DTOConsultaObligadoSolicitud();
                    requestConsulta.Cuit = long.Parse(cliente.cuit);
                    requestConsulta.FechaEmision = dtpFecha.Value;
                    sujetoObligado = feClient.ConsultarSujetoObligado(requestConsulta);
                }
            }
        }

        private void completarDatosPlanta(Planta planta)
        {
            txtPlanta.Text = planta == null ? "" : planta.nombre;
            if (planta != null)
                dgvItems.Enabled = true;
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
                if (cboTipoNota.Text=="") 
                {
                    Mensaje error = new Mensaje("Debe seleccionar un tipo de nota.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    error.ShowDialog();
                    return false;
                }

                if (dgvItems.Rows.Count <= 1)
                {
                    Mensaje error = new Mensaje("La grilla no puede estar vacía.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    error.ShowDialog();
                    return false;
                }

                if (cboPtoVta.Text != "3")
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
                    if (cboTipoNota.Text=="Nota Crédito")
                    {
                        if (Estado == Estados.Agregar || cboPtoVta.Text != "3")
                            notaCred = new Comprobante_Devolucion();

                        if (txtNroNota.Text != "")
                            notaCred.numero = long.Parse(txtNroNota.Text);
                        else
                            notaCred.numero = 0;

                        notaCred.Planta = planta;
                        notaCred.fechaIngreso = dtpFecha.Value;//DateTime.Now;
                        notaCred.motivo = txtMotivo.Text;
                        notaCred.condVta = txtCondVta.Text;
                        notaCred.anulado = false;
                        notaCred.pv = int.Parse(cboPtoVta.Text);
                        notaCred.ComprobanteAnul = (Comprobante)txtNroCompAsoc.Tag;
                        notaCred.Moneda = (Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value;

                        if (cliente.SituacionFrenteIva.nombre == "Responsable Inscripto")
                        {
                            notaCred.tipo = "A";
                            if (txtSubtotal.Text != "")
                                notaCred.subtotal = Math.Round(decimal.Parse(txtSubtotal.Text),2);
                            else
                                notaCred.subtotal = 0;
                            if (txtIVA.Text != "")
                                notaCred.totalIva = Math.Round(decimal.Parse(txtIVA.Text),2);
                            else
                                notaCred.totalIva = 0;
                        }
                        else
                        {
                            notaCred.tipo = "B";
                            notaCred.subtotal = 0;
                            notaCred.totalIva = 0;
                        }
                        if (txtTotal.Text != "")
                            notaCred.importe = Math.Round(decimal.Parse(txtTotal.Text),2);
                        else
                            notaCred.importe = 0;

                        List<double[]> arregloIva = new List<double[]>();
                        List<decimal> ivaUsados = new List<decimal>();

                        notaCred.ItemNota.Clear();

                        foreach (DataGridViewRow fila in dgvItems.Rows)
                        {
                            if (!fila.IsNewRow)
                            {
                                ItemNota item = new ItemNota();
                                item.importe = Math.Round(decimal.Parse(fila.Cells["clmImporte"].FormattedValue.ToString()),2);
                                item.iva = Math.Round(decimal.Parse(fila.Cells["clmIVA"].FormattedValue.ToString()),2);
                                item.descripcion = fila.Cells["clmDetalle"].Value.ToString();
                                item.cantidad = Math.Round(decimal.Parse(fila.Cells["clmCant"].FormattedValue.ToString()),2);

                                notaCred.ItemNota.Add(item);

                                if (ivaUsados.Contains((decimal)item.iva))
                                {
                                    foreach (double[] i in arregloIva)
                                    {
                                        if (i[0] == (double)item.iva)
                                        {
                                            i[1] += (double)Math.Round((decimal)(Math.Round((decimal)item.importe,2) * item.cantidad),2); 
                                            i[2] += (double)Math.Round((decimal)(Math.Round((decimal)item.importe,2) * item.cantidad * (item.iva / 100)),2);                                            
                                        }
                                    }
                                }
                                else
                                {
                                    double[] itemIva = new double[3];
                                    itemIva[0] = (double)item.iva;
                                    itemIva[1] = (double)Math.Round((decimal)(Math.Round((decimal)item.importe,2) * item.cantidad),2); 
                                    itemIva[2] = (double)Math.Round((decimal)(Math.Round((decimal)item.importe,2) * item.cantidad * (item.iva / 100)),2);                                     
                                    arregloIva.Add(itemIva);
                                    ivaUsados.Add((decimal)item.iva);
                                }
                            }
                        }

                        notaCred.estadoCarga = 0;
                        if (Estado == Estados.Modificar & cboPtoVta.Text == "3")
                            Global.Servicio.actualizarNotaCred(notaCred, Global.DatosSesion);
                        else
                            Global.Servicio.agregarNotaCred(notaCred, Global.DatosSesion);

                        bool result = true;  
                        FEAfip.DTOSolicitud rtaAfip = new FEAfip.DTOSolicitud();   

                        if (cboPtoVta.Text == "3")
                        {
                            double[][] arregloIva2 = arregloIva.ToArray();
                            double totIva = 0;

                            for (int i = 0; i < arregloIva2.Count(); i++)
                            {
                                arregloIva2[i][1] = Math.Round(arregloIva2[i][1], 2);
                                arregloIva2[i][2] = Math.Round(arregloIva2[i][2], 2);
                                if (notaCred.tipo == "B")
                                {
                                    totIva += arregloIva2[i][2];
                                }
                            }

                            totIva = Math.Round(totIva, 2);

                            FEAfip.ServicioCAEClient service = new FEAfip.ServicioCAEClient();

                            int tipo;
                            double neto = 0;
                            if (notaCred.tipo == "A")
                            {                                
                                tipo = 3;
                                totIva = Math.Round((double)notaCred.totalIva,2);
                                neto = Math.Round((double)notaCred.subtotal,2);
                            }
                            else
                            {                                
                                tipo = 8;
                                neto = Math.Round((((double)notaCred.importe) - totIva),2);
                            }

                            try
                            {
                                long[][] arregloComAsoc = null;
                                if (txtNroCompAsoc.Text != "")
                                {                   
                                    arregloComAsoc = new long[1][] { new long[3] };
                                    arregloComAsoc[0][0] = long.Parse(cboPtoVta.Text);
                                    arregloComAsoc[0][1] = tipo;
                                    arregloComAsoc[0][2] = long.Parse(txtNroCompAsoc.Text);
                                }

                                var solicitud = new FEAfip.SolicitudRequest();
                                solicitud.tipoComp = tipo;
                                solicitud.puntoVenta = 3;
                                solicitud.concepto = 1;
                                solicitud.tdoc = 80;
                                solicitud.ndoc = long.Parse(notaCred.Planta.Cliente.cuit);
                                solicitud.nroComp = notaCred.numero;
                                solicitud.fecha = notaCred.fechaIngreso.ToString("yyyyMMdd");
                                solicitud.total = (double)notaCred.importe;
                                solicitud.neto = Math.Round(neto, 2);
                                solicitud.iva = totIva;
                                solicitud.mon = notaCred.Moneda.abrevAfip;
                                solicitud.cotiz = (double)notaCred.Moneda.cotizacion;
                                solicitud.arrayIva = arregloIva2;
                                solicitud.compAsociados = arregloComAsoc;
                                //rtaAfip = service.solicitar(tipo, 3, 1, 80, long.Parse(notaCred.Planta.Cliente.cuit), notaCred.numero, notaCred.fechaIngreso.ToString("yyyyMMdd"), (double)notaCred.importe, Math.Round(neto, 2), totIva, notaCred.Moneda.abrevAfip, (double)notaCred.Moneda.cotizacion, arregloIva2, arregloComAsoc);
                                rtaAfip = service.solicitar(solicitud);

                                if (rtaAfip.respuesta != "A")
                                {
                                    throw new Exception("Solicitud Rechazada, no se pudo obtener CAE");
                                }

                                Mensaje msgCAE = new Mensaje("Solicitud a AFIP ejecutada con éxito", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                                msgCAE.ShowDialog();
                                notaCred.cae = rtaAfip.cae;
                                notaCred.fecVtoCae = DateTime.ParseExact(rtaAfip.FecVtoCAE, "yyyyMMdd", CultureInfo.InvariantCulture);
                                notaCred.estadoCarga = 1;
                                Global.Servicio.actualizarNotaCred(notaCred, Global.DatosSesion);
                                
                            }
                            catch (Exception ex)
                            {
                                Mensaje errAfip = new Mensaje("ERROR EN LA LLAMADA A AFIP:" + ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                                errAfip.ShowDialog();
                                result = false;
                            }
                        }

                        Mensaje unMensaje = new Mensaje("Nota de crédito cargada con éxito", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                        unMensaje.ShowDialog();

                        if (notaCred.pv == 1)
                        {
                            Global.Servicio.imprimirNota(notaCred);
                            Global.Servicio.imprimirNota(notaCred);
                        }

                        //imprime la version digital
                        if (result)
                        {
                            Global.Servicio.imprimirNotaDigital(notaCred);
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
                        if (Estado == Estados.Agregar || cboPtoVta.Text != "3")
                            notaDeb = new Comprobante_Recargo();
                        if (txtNroNota.Text != "")
                            notaDeb.numero = long.Parse(txtNroNota.Text);
                        else
                            notaDeb.numero = 0;

                        notaDeb.Planta = planta;
                        notaDeb.fechaIngreso = dtpFecha.Value;
                        notaDeb.motivo = txtMotivo.Text;
                        notaDeb.condVta = txtCondVta.Text;
                        notaDeb.anulado = false;
                        notaDeb.ComprobanteAnul = (Comprobante)txtNroCompAsoc.Tag;
                        notaDeb.pv = int.Parse(cboPtoVta.Text);
                        notaDeb.Moneda = (Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value;

                        if (cliente.SituacionFrenteIva.nombre == "Responsable Inscripto")
                        {
                            notaDeb.tipo = "A";
                            if (txtSubtotal.Text != "")
                                notaDeb.subtotal = Math.Round(decimal.Parse(txtSubtotal.Text),2);
                            else
                                notaDeb.subtotal = 0;
                            if (txtIVA.Text != "")
                                notaDeb.totalIva = Math.Round(decimal.Parse(txtIVA.Text),2);
                            else
                                notaDeb.totalIva = 0;
                        }
                        else
                        {
                            notaDeb.tipo = "B";
                            notaDeb.subtotal = 0;
                            notaDeb.totalIva = 0;
                        }
                        if (txtTotal.Text != "")
                            notaDeb.importe = Math.Round(decimal.Parse(txtTotal.Text),2);
                        else
                            notaDeb.importe = 0;

                        List<double[]> arregloIva = new List<double[]>();
                        List<decimal> ivaUsados = new List<decimal>();

                        notaDeb.ItemNota.Clear();

                        foreach (DataGridViewRow fila in dgvItems.Rows)
                        {
                            if (!fila.IsNewRow)
                            {
                                ItemNota item = new ItemNota();

                                item.importe = Math.Round(decimal.Parse(fila.Cells["clmImporte"].FormattedValue.ToString()),2);
                                item.iva = Math.Round(decimal.Parse(fila.Cells["clmIVA"].FormattedValue.ToString()),2);
                                item.descripcion = fila.Cells["clmDetalle"].Value.ToString();
                                item.cantidad = Math.Round(decimal.Parse(fila.Cells["clmCant"].FormattedValue.ToString()),2);
                                notaDeb.ItemNota.Add(item);

                                if (ivaUsados.Contains((decimal)item.iva))
                                {
                                    foreach (double[] i in arregloIva)
                                    {
                                        if (i[0] == (double)item.iva)
                                        {
                                            i[1] += (double)Math.Round((decimal)(item.importe * item.cantidad),2); 
                                            i[2] += (double)Math.Round((decimal)(item.importe * item.cantidad * (item.iva / 100)),2); 
                                        }
                                    }
                                }
                                else
                                {
                                    double[] itemIva = new double[3];
                                    itemIva[0] = (double)item.iva;
                                    itemIva[1] = (double)Math.Round((decimal)(item.importe * item.cantidad),2);
                                    itemIva[2] = (double)Math.Round((decimal)(item.importe * item.cantidad * (item.iva / 100)),2); 
                                    arregloIva.Add(itemIva);
                                    ivaUsados.Add((decimal)item.iva);
                                }
                            }
                        }

                        notaDeb.estadoCarga = 0;
                        if (Estado == Estados.Modificar & cboPtoVta.Text == "3")
                            Global.Servicio.actualizarNotaDeb(notaDeb, Global.DatosSesion);
                        else
                            Global.Servicio.agregarNotaDeb(notaDeb, Global.DatosSesion);

                        bool result = true;
                        FEAfip.DTOSolicitud rtaAfip = new FEAfip.DTOSolicitud();

                        if (cboPtoVta.Text == "3")
                        {
                            double[][] arregloIva2 = arregloIva.ToArray();
                            double totIva = 0;

                            for (int i = 0; i < arregloIva2.Count(); i++)
                            {
                                arregloIva2[i][1] = Math.Round(arregloIva2[i][1], 2);
                                arregloIva2[i][2] = Math.Round(arregloIva2[i][2], 2);
                                if (notaDeb.tipo == "B")
                                {
                                    totIva += arregloIva2[i][2];
                                }
                            }

                            totIva = Math.Round(totIva, 2);

                            FEAfip.ServicioCAEClient service = new FEAfip.ServicioCAEClient();

                            int tipo;
                            double neto = 0;
                            if (notaDeb.tipo == "A")
                            {
                                tipo = 2;
                                totIva = Math.Round((double)notaDeb.totalIva,2);
                                neto = Math.Round((double)notaDeb.subtotal,2);
                            }
                            else
                            {
                                tipo = 7;
                                neto = Math.Round((((double)notaDeb.importe) - totIva),2);
                            }

                            try
                            {
                                long[][] arregloComAsoc = null;
                                if (txtNroCompAsoc.Text != "")
                                {
                                    arregloComAsoc = new long[1][] { new long[3] };
                                    arregloComAsoc[0][0] = long.Parse(cboPtoVta.Text);
                                    arregloComAsoc[0][1] = tipo;
                                    arregloComAsoc[0][2] = long.Parse(txtNroCompAsoc.Text);
                                }

                                var solicitud = new FEAfip.SolicitudRequest();
                                solicitud.tipoComp = tipo;
                                solicitud.puntoVenta = 3;
                                solicitud.concepto = 1;
                                solicitud.tdoc = 80;
                                solicitud.ndoc = long.Parse(notaDeb.Planta.Cliente.cuit);
                                solicitud.nroComp = notaDeb.numero;
                                solicitud.fecha = notaDeb.fechaIngreso.ToString("yyyyMMdd");
                                solicitud.total = (double)notaDeb.importe;
                                solicitud.neto = Math.Round(neto, 2);
                                solicitud.iva = totIva;
                                solicitud.mon = notaDeb.Moneda.abrevAfip;
                                solicitud.cotiz = (double)notaDeb.Moneda.cotizacion;
                                solicitud.arrayIva = arregloIva2;
                                solicitud.compAsociados = arregloComAsoc;
                                //rtaAfip = service.solicitar(tipo, 3, 1, 80, long.Parse(notaDeb.Planta.Cliente.cuit), notaDeb.numero, notaDeb.fechaIngreso.ToString("yyyyMMdd"), (double)notaDeb.importe, Math.Round(neto, 2), totIva, notaDeb.Moneda.abrevAfip, (double)notaDeb.Moneda.cotizacion, arregloIva2, arregloComAsoc);
                                rtaAfip = service.solicitar(solicitud);
                                
                                if (rtaAfip.respuesta != "A")
                                {
                                    throw new Exception("Solicitud Rechazada, no se pudo obtener CAE");
                                }

                                Mensaje msgCAE = new Mensaje("Solicitud a AFIP ejecutada con éxito", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                                msgCAE.ShowDialog();
                                notaDeb.cae = rtaAfip.cae;
                                notaDeb.fecVtoCae = DateTime.ParseExact(rtaAfip.FecVtoCAE, "yyyyMMdd", CultureInfo.InvariantCulture);
                                notaDeb.estadoCarga = 1;
                                Global.Servicio.actualizarNotaDeb(notaDeb, Global.DatosSesion);

                            }
                            catch (Exception ex)
                            {
                                Mensaje errAfip = new Mensaje("ERROR EN LA LLAMADA A AFIP:" + ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                                errAfip.ShowDialog();
                                result = false;
                            }
                        }

                        Mensaje unMensaje = new Mensaje("Nota de débito cargada con éxito", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                        unMensaje.ShowDialog();

                        if (notaDeb.pv == 1)
                        {
                            Global.Servicio.imprimirNota(notaDeb);
                            Global.Servicio.imprimirNota(notaDeb);
                        }

                        //imprime la version digital
                        if (result)
                        {
                            Global.Servicio.imprimirNotaDigital(notaDeb);
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

        private void cboTipoNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipoNota.Text)
            {
                case "Nota Crédito":
                    Cargador.cargarPuntosVta(cboPtoVta, "notaCredito");
                    cboPtoVta.SelectedIndex = cboPtoVta.FindStringExact("3");
                    
                    cboTipoCompAsoc.Items.Clear();
                    ComboBoxItem itemF = new ComboBoxItem("Factura", "factura");
                    ComboBoxItem itemND = new ComboBoxItem("Nota Débito", "notaDebito");
                    cboTipoCompAsoc.Items.Add(itemF);
                    cboTipoCompAsoc.Items.Add(itemND);
                    break;
                case "Nota Débito":
                    Cargador.cargarPuntosVta(cboPtoVta, "notaDebito");
                    cboPtoVta.SelectedIndex = cboPtoVta.FindStringExact("3");

                    cboTipoCompAsoc.Items.Clear();
                    ComboBoxItem itemNC = new ComboBoxItem("Nota Crédito", "notaCredito");
                    cboTipoCompAsoc.Items.Add(itemNC);
                    break;
                default:
                    txtNroNota.Text="";
                    break;
            }           

        }

        private void dgvItems_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItems.EditingControl == null)
                return;

            dgvItems[dgvItems.Columns["clmMon"].Index, e.RowIndex].Value = ((Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value).simbologia;

            if (dgvItems[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmCant")
            {
                decimal val;
                if (decimal.TryParse(dgvItems.EditingControl.Text, out val))
                {
                    calcularImportes(val, decimal.Parse(dgvItems.Rows[e.RowIndex].Cells["clmImporte"].FormattedValue.ToString()), e.RowIndex);
                }
                else
                {
                    dgvItems.EditingControl.Text = "0";
                    calcularImportes(0, decimal.Parse(dgvItems.Rows[e.RowIndex].Cells["clmImporte"].FormattedValue.ToString()), e.RowIndex);
                }
            }

            if (dgvItems[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmImporte")
            {
                decimal val;
                if (decimal.TryParse(dgvItems.EditingControl.Text, out val))
                {
                    calcularImportes(decimal.Parse(dgvItems.Rows[e.RowIndex].Cells["clmCant"].FormattedValue.ToString()), val, e.RowIndex);
                }
                else
                {
                    dgvItems.EditingControl.Text = "0";
                    calcularImportes(decimal.Parse(dgvItems.Rows[e.RowIndex].Cells["clmCant"].FormattedValue.ToString()), 0, e.RowIndex);
                }
            }

            if (dgvItems[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "clmIVA")
            {
                decimal val;
                if (decimal.TryParse(dgvItems.EditingControl.Text, out val))
                {
                    calcularImportes(decimal.Parse(dgvItems.Rows[e.RowIndex].Cells["clmCant"].FormattedValue.ToString()), decimal.Parse(dgvItems.Rows[e.RowIndex].Cells["clmImporte"].FormattedValue.ToString()), e.RowIndex);
                }
                else
                {
                    dgvItems.EditingControl.Text = "21";
                    calcularImportes(decimal.Parse(dgvItems.Rows[e.RowIndex].Cells["clmCant"].FormattedValue.ToString()), decimal.Parse(dgvItems.Rows[e.RowIndex].Cells["clmImporte"].FormattedValue.ToString()), e.RowIndex);
                }
            }
        }

        private void calcularImportes(decimal cant, decimal precio, int fila)
        {
            decimal sumaSinIva = 0;
            decimal sumaConIva = 0;
            decimal suma = 0;

            if (cliente.SituacionFrenteIva.nombre == "Responsable Inscripto")
            {
                if (fila != -1)
                    dgvItems.Rows[fila].Cells["clmTotal"].Value = Math.Round(Math.Round(cant, 2) * Math.Round(precio, 2),2);
                    
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        sumaSinIva += Math.Round(decimal.Parse(row.Cells["clmTotal"].FormattedValue.ToString()),2);
                        sumaConIva += Math.Round(Math.Round(decimal.Parse(row.Cells["clmTotal"].FormattedValue.ToString()),2) * ((decimal.Parse(row.Cells["clmIVA"].EditedFormattedValue.ToString()) / 100) + 1),2);
                    }
                }
                txtSubtotal.Text = sumaSinIva.ToString("0.00");
                txtIVA.Text = Math.Round((sumaConIva - sumaSinIva),2).ToString("0.00");
                txtTotal.Text = sumaConIva.ToString("0.00");
            }
            else
            {
                dgvItems.Rows[fila].Cells["clmTotal"].Value = Math.Round(Math.Round(cant, 2) * Math.Round(precio, 2) * ((decimal.Parse(dgvItems.Rows[fila].Cells["clmIVA"].EditedFormattedValue.ToString()) / 100) + 1),2);
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        suma += Math.Round(decimal.Parse(row.Cells["clmTotal"].FormattedValue.ToString()),2);                        
                    }
                }
                txtSubtotal.Text = "0";
                txtIVA.Text = "0";
                txtTotal.Text = suma.ToString("0.00");
            }

            if (SujetoObligado)
            {
                //si es sujeto obligado tengo que ir analizando que nro de comprobante va dependiendo del total
                long nroNota;
                if (decimal.Parse(txtTotal.Text) >= MontoObligado)
                {
                    nroNota = ObtenerNroNota(true, nroNotaMiPyme > 0);
                    nroNotaMiPyme = nroNota;
                }
                else
                {
                    nroNota = ObtenerNroNota(false, nroNotaComun > 0);
                    nroNotaComun = nroNota;
                }
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
            calcularImportes(0, 0, -1);
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {            
            if (cboTipoNota.Text == "Nota Crédito")
            {            
                if (notaCred != null && Estado != Estados.Modificar && Estado != Estados.Agregar)
                {
                    if (notaCred.pv == 1)
                    {
                        Global.Servicio.imprimirNota(notaCred);
                        Global.Servicio.imprimirNota(notaCred);
                    }
                    if (notaCred.pv == 3)
                    {
                        Global.Servicio.imprimirNotaDigital(notaCred);
                    }                    
                }
                else
                {
                    Mensaje unMensaje = new Mensaje("Debe seleccionar una Nota de Crédito para reimprimir.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    unMensaje.ShowDialog();
                }
            }
            else
            {
                if (notaDeb != null && Estado != Estados.Modificar && Estado != Estados.Agregar)
                {
                    if (notaDeb.pv == 1)
                    {
                        Global.Servicio.imprimirNota(notaDeb);
                        Global.Servicio.imprimirNota(notaDeb);
                    }
                    if (notaDeb.pv == 3)
                    {
                        Global.Servicio.imprimirNotaDigital(notaDeb);
                    } 
                }
                else
                {
                    Mensaje unMensaje = new Mensaje("Debe seleccionar una Nota de Débito para reimprimir.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    unMensaje.ShowDialog();
                }
            }
        }

        private void btnBuscarFact_Click(object sender, EventArgs e)
        {
            if (cboTipoCompAsoc.Text == "")
            {
                Mensaje unMensaje = new Mensaje("Debe seleccionar una tipo de comprobante asociado", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
                return;
            }

            frmBusquedaComp frmBusquedaComp = new frmBusquedaComp();
            frmBusquedaComp.tipo = ((Controles.ComboBoxItem)cboTipoCompAsoc.SelectedItem).Value.ToString();            
            DialogResult res = frmBusquedaComp.ShowDialog();

            Comprobante comprobanteAnul;

            if (res == DialogResult.OK)
            {
                comprobanteAnul = frmBusquedaComp.comprobanteSeleccionado;
                if (cboTipoNota.Text == "Nota Crédito")
                {
                    if (comprobanteAnul.GetType().BaseType.Name == "Comprobante_Factura" || comprobanteAnul.GetType().Name == "Comprobante_Factura")
                    {
                        txtNroCompAsoc.Text = ((Comprobante_Factura)comprobanteAnul).numero.ToString();
                    }
                    if (comprobanteAnul.GetType().BaseType.Name == "Comprobante_Recargo" || comprobanteAnul.GetType().Name == "Comprobante_Recargo")
                    {
                        txtNroCompAsoc.Text = ((Comprobante_Recargo)comprobanteAnul).numero.ToString();
                    }

                    notaCred.ComprobanteAnul = comprobanteAnul;
                }
                if (cboTipoNota.Text == "Nota Débito")
                {
                    if (comprobanteAnul.GetType().BaseType.Name == "Comprobante_Devolucion" || comprobanteAnul.GetType().Name == "Comprobante_Devolucion")
                    {
                        txtNroCompAsoc.Text = ((Comprobante_Devolucion)comprobanteAnul).numero.ToString();
                    }

                    notaDeb.ComprobanteAnul = comprobanteAnul;
                }

                txtNroCompAsoc.Tag = comprobanteAnul;
            }
        }

        private void btnConsultarUltimoAut_Click(object sender, EventArgs e)
        {
            if (cboTipoNota.Text == "")
            {
                Mensaje msg = new Mensaje("Seleccione un tipo de nota.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msg.ShowDialog();
                return;
            }

            try 
            { 
                if (cboTipoNota.Text == "Nota Crédito")
                {                
                    FEAfip.ServicioCAEClient service = new FEAfip.ServicioCAEClient();
                    int nroCompA; int nroCompB;
                    string mensaje = "";

                    nroCompA = service.ObtenerUltimoAut(3, 3);
                    nroCompB = service.ObtenerUltimoAut(8, 3);
                                                                                                            
                    if (nroCompA != 0)
                    {
                        FEAfip.DTOSolicitud solicitudA = new FEAfip.DTOSolicitud();
                        solicitudA = service.ConsultarCAE(3, 3, nroCompA);
                        Comprobante_Devolucion notaA = Global.Servicio.buscarNotaCred(nroCompA, "A", 3);
                        notaA.estadoCarga = 1;
                        notaA.cae = solicitudA.cae;
                        notaA.fecVtoCae = DateTime.ParseExact(solicitudA.FecVtoCAE, "yyyyMMdd", CultureInfo.InvariantCulture);
                        Global.Servicio.actualizarNotaCred(notaA, Global.DatosSesion);
                        mensaje += "NOTAS CRED A:\n\r-Nro. Comprobante: " + nroCompA.ToString() + "\n\r-CAE: " + notaA.cae + "\n\r-Fec. Vto. CAE: " + solicitudA.FecVtoCAE.Substring(6, 2) + "/" + solicitudA.FecVtoCAE.Substring(4, 2) + "/" + solicitudA.FecVtoCAE.Substring(0, 4) + "\n\r";
                    }                

                    if (nroCompB != 0)
                    {
                        FEAfip.DTOSolicitud solicitudB = new FEAfip.DTOSolicitud();    
                        solicitudB = service.ConsultarCAE(8, 3, nroCompB);
                        Comprobante_Devolucion notaB = Global.Servicio.buscarNotaCred(nroCompB, "B", 3);
                        notaB.estadoCarga = 1;
                        notaB.cae = solicitudB.cae;
                        notaB.fecVtoCae = DateTime.ParseExact(solicitudB.FecVtoCAE, "yyyyMMdd", CultureInfo.InvariantCulture);
                        Global.Servicio.actualizarNotaCred(notaB, Global.DatosSesion);
                        mensaje += "NOTAS CRED B:\n\r-Nro. Comprobante: " + nroCompB.ToString() + "\n\r-CAE: " + notaB.cae + "\n\r-Fec. Vto. CAE:-" + solicitudB.FecVtoCAE.Substring(6, 2) + "/" + solicitudB.FecVtoCAE.Substring(4, 2) + "/" + solicitudB.FecVtoCAE.Substring(0, 4);
                    }                

                    MessageBox.Show(mensaje, "Resultado AFIP");
                }
                else
                {
                    FEAfip.ServicioCAEClient service = new FEAfip.ServicioCAEClient();
                    int nroCompA; int nroCompB;
                    string mensaje = "";

                    nroCompA = service.ObtenerUltimoAut(2, 3);
                    nroCompB = service.ObtenerUltimoAut(7, 3);                    

                    if (nroCompA != 0)
                    {
                        FEAfip.DTOSolicitud solicitudA = new FEAfip.DTOSolicitud();
                        solicitudA = service.ConsultarCAE(2, 3, nroCompA);
                        Comprobante_Recargo notaA = Global.Servicio.buscarNotaDeb(nroCompA, "A", 3);
                        notaA.estadoCarga = 1;
                        notaA.cae = solicitudA.cae;
                        notaA.fecVtoCae = DateTime.ParseExact(solicitudA.FecVtoCAE, "yyyyMMdd", CultureInfo.InvariantCulture);
                        Global.Servicio.actualizarNotaDeb(notaA, Global.DatosSesion);
                        mensaje += "NOTAS DEB A:\n\r-Nro. Comprobante: " + nroCompA.ToString() + "\n\r-CAE: " + notaA.cae + "\n\r-Fec. Vto. CAE: " + solicitudA.FecVtoCAE.Substring(6, 2) + "/" + solicitudA.FecVtoCAE.Substring(4, 2) + "/" + solicitudA.FecVtoCAE.Substring(0, 4) + "\n\r";
                    }

                    if (nroCompB != 0)
                    {
                        FEAfip.DTOSolicitud solicitudB = new FEAfip.DTOSolicitud();
                        solicitudB = service.ConsultarCAE(7, 3, nroCompB);
                        Comprobante_Recargo notaB = Global.Servicio.buscarNotaDeb(nroCompB, "B", 3);
                        notaB.estadoCarga = 1;
                        notaB.cae = solicitudB.cae;
                        notaB.fecVtoCae = DateTime.ParseExact(solicitudB.FecVtoCAE, "yyyyMMdd", CultureInfo.InvariantCulture);
                        Global.Servicio.actualizarNotaDeb(notaB, Global.DatosSesion);
                        mensaje += "NOTAS DEB B:\n\r-Nro. Comprobante: " + nroCompB.ToString() + "\n\r-CAE: " + notaB.cae + "\n\r-Fec. Vto. CAE: " + solicitudB.FecVtoCAE.Substring(6, 2) + "/" + solicitudB.FecVtoCAE.Substring(4, 2) + "/" + solicitudB.FecVtoCAE.Substring(0, 4);
                    }

                    MessageBox.Show(mensaje, "Resultado AFIP");
                }
            }
            catch (Exception ex)
            {
                Mensaje errAfip = new Mensaje("ERROR EN LA LLAMADA A AFIP:" + ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                errAfip.ShowDialog();
            }
        }

        private void btnErroresAfip_Click(object sender, EventArgs e)
        {
            int tipo;
            if (cboTipoNota.Text == "Nota Crédito")
            {
                if (notaCred == null)
                {
                    Mensaje msg = new Mensaje("Debe seleccionar una Nota de Crédito.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    msg.Show();
                    return;
                }

                if (notaCred.tipo == "A")
                    tipo = 3;
                else
                    tipo = 8;

                FEAfip.ServicioCAEClient service = new FEAfip.ServicioCAEClient();
                FEAfip.DTOSolicitud solicitud = new FEAfip.DTOSolicitud();
                solicitud = service.obtenerUltimaSolicitudConError(tipo, int.Parse(cboPtoVta.Text), long.Parse(txtNroNota.Text));
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
            else
            {
                if (notaDeb == null)
                {
                    Mensaje msg = new Mensaje("Debe seleccionar una Nota de Débito.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    msg.Show();
                    return;
                }

                if (notaDeb.tipo == "A")
                    tipo = 2;
                else
                    tipo = 7;

                FEAfip.ServicioCAEClient service = new FEAfip.ServicioCAEClient();
                FEAfip.DTOSolicitud solicitud = new FEAfip.DTOSolicitud();
                solicitud = service.obtenerUltimaSolicitudConError(tipo, int.Parse(cboPtoVta.Text), long.Parse(txtNroNota.Text));
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
        }

        private void btnConsultarCAE_Click(object sender, EventArgs e)
        {
            if (cboTipoNota.Text == "Nota Crédito")
            {
                if (notaCred == null)
                {
                    Mensaje msg = new Mensaje("Debe seleccionar una Nota de Crédito.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    msg.Show();
                    return;
                }

                int tipo;
                if (notaCred.tipo == "A")
                    tipo = 3;
                else
                    tipo = 8;

                FEAfip.DTOSolicitud solicitud = new FEAfip.DTOSolicitud();

                try
                {
                    FEAfip.ServicioCAEClient service = new FEAfip.ServicioCAEClient();
                    solicitud = service.ConsultarCAE(tipo, int.Parse(cboPtoVta.Text), long.Parse(txtNroNota.Text));
                    if (solicitud != null)
                    {
                        notaCred.cae = solicitud.cae;
                        notaCred.fecVtoCae = DateTime.ParseExact(solicitud.FecVtoCAE, "yyyyMMdd", CultureInfo.InvariantCulture);
                        notaCred.estadoCarga = 1;
                        Global.Servicio.actualizarNotaCred(notaCred, Global.DatosSesion);

                        Mensaje mensajeConfirmacion = new Mensaje("CAE: " + notaCred.cae + " - " + "Fec. Vto.: " + ((DateTime)notaCred.fecVtoCae).ToString("dd/MM/yyyy"), Mensaje.TipoMensaje.Informacion, Mensaje.Botones.OK);
                        mensajeConfirmacion.ShowDialog();
                    }
                    else
                    {
                        Mensaje mensajeConfirmacion = new Mensaje("No existe CAE para esta Nota de Crédito", Mensaje.TipoMensaje.Informacion, Mensaje.Botones.OK);
                        mensajeConfirmacion.ShowDialog();
                    }
                }

                catch (Exception ex)
                {
                    Mensaje errAfip = new Mensaje("ERROR EN LA LLAMADA A AFIP:" + ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    errAfip.ShowDialog();
                }
            }

            if (cboTipoNota.Text == "Nota Débito")
            {
                if (notaDeb == null)
                {
                    Mensaje msg = new Mensaje("Debe seleccionar una Nota de Débito.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    msg.Show();
                    return;
                }

                int tipo;
                if (notaDeb.tipo == "A")
                    tipo = 2;
                else
                    tipo = 7;

                FEAfip.DTOSolicitud solicitud = new FEAfip.DTOSolicitud();

                try
                {
                    FEAfip.ServicioCAEClient service = new FEAfip.ServicioCAEClient();
                    solicitud = service.ConsultarCAE(tipo, int.Parse(cboPtoVta.Text), long.Parse(txtNroNota.Text));
                    if (solicitud != null)
                    {
                        notaDeb.cae = solicitud.cae;
                        notaDeb.fecVtoCae = DateTime.ParseExact(solicitud.FecVtoCAE, "yyyyMMdd", CultureInfo.InvariantCulture);
                        notaDeb.estadoCarga = 1;
                        Global.Servicio.actualizarNotaDeb(notaDeb, Global.DatosSesion);

                        Mensaje mensajeConfirmacion = new Mensaje("CAE: " + notaDeb.cae + " - " + "Fec. Vto.: " + ((DateTime)notaDeb.fecVtoCae).ToString("dd/MM/yyyy"), Mensaje.TipoMensaje.Informacion, Mensaje.Botones.OK);
                        mensajeConfirmacion.ShowDialog();
                    }
                    else
                    {
                        Mensaje mensajeConfirmacion = new Mensaje("No existe CAE para esta Nota de Débito", Mensaje.TipoMensaje.Informacion, Mensaje.Botones.OK);
                        mensajeConfirmacion.ShowDialog();
                    }
                }

                catch (Exception ex)
                {
                    Mensaje errAfip = new Mensaje("ERROR EN LA LLAMADA A AFIP:" + ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                    errAfip.ShowDialog();
                }
            }
        }

        private void cboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Moneda mon = (Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value;
            txtCotiz.Text = Global.Servicio.obtenerCotizacionMoneda(mon.id).ToString("0.0000");
            foreach (DataGridViewRow fila in dgvItems.Rows)
            {
                if (!fila.IsNewRow)
                {            
                    fila.Cells["clmMon"].Value = mon.simbologia;            
                }
            }
        }

        private void cboPtoVta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerNroNota();
        }

        private void cboTipoCompAsoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNroCompAsoc.Text = "";
        }        
    }
}
