using Controles;
using Entidades;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Vistas.Reportes
{
    public partial class frmTotalLts : FormBaseSinToolbar
    {
        private Dictionary<string, object> Parametros;

        public frmTotalLts()
        {
            InitializeComponent();

            Cargador.cargarPresentaciones(cboPresentacion, "Sin Seleccionar...");
            Cargador.cargarArticulos(cboArticulo, "Sin Seleccionar...");
            //Cargador.cargarLotesTodos(cboLote);

            cargar();
        }

        private void frmTotalLts_Load(object sender, EventArgs e)
        {           
            var nombresClientes = Global.Servicio.obtenerTodosClientes(0).Select(c => c.razonSocial).ToList();
            var nombresVendedores = Global.Servicio.ObtenerNombresVendedores();
            nombresClientes.AddRange(nombresVendedores);

            Cargador.cargarLista(txtClienteVendedor, nombresClientes);
        }

        protected void cargar()
        {
            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;
            string cliente = string.IsNullOrEmpty(txtClienteVendedor.Text) ? null : txtClienteVendedor.Text;
            string lote = string.IsNullOrEmpty(cboLote.Text) ? null : cboLote.Text;
            string articulo = cboArticulo.Text.Equals("Sin Seleccionar...") ? null : cboArticulo.Text;
            string presentacion = cboPresentacion.Text.Equals("Sin Seleccionar...") ? null : cboPresentacion.Text;
            bool detallarArticulos = chkDetallarArticulos.Checked;            

            //Comienzo carga de reporte
            LocalReport Reporte = new LocalReport();
            byte[] reporte;

            reporte = Desktop.Reportes.ConsultaTotalesLts;

            Stream archivoReporte = new MemoryStream(reporte);
            Reporte.LoadReportDefinition(archivoReporte);

            Parametros = new Dictionary<string, object>();
            Parametros.Add("fechaDesde", fechaDesde.ToShortDateString());
            Parametros.Add("fechaHasta", fechaHasta.ToShortDateString());
            Parametros.Add("clienteVendedor", cliente);
            Parametros.Add("lote", lote);
            Parametros.Add("articulo", articulo);
            Parametros.Add("presentacion", presentacion);
            Parametros.Add("incluirDescripcionPorArticulo", detallarArticulos);


            DataSet dataSet = obtenerDataSet("ConsultaTotalLts");
            ReportDataSource origenDatos = new ReportDataSource("ConsultaTotalLts", dataSet.Tables[0]);

            List<ReportParameter> paramsReporte = new List<ReportParameter>();
            paramsReporte.Add(new ReportParameter("fechaDesde", fechaDesde.ToShortDateString()));
            paramsReporte.Add(new ReportParameter("fechaHasta", fechaHasta.ToShortDateString()));
            paramsReporte.Add(new ReportParameter("clienteVendedor", cliente));
            paramsReporte.Add(new ReportParameter("lote", lote));
            paramsReporte.Add(new ReportParameter("articulo", articulo));
            paramsReporte.Add(new ReportParameter("presentacion", presentacion));
            paramsReporte.Add(new ReportParameter("incluirDescripcionPorArticulo", detallarArticulos.ToString()));
            
            Reporte.DataSources.Add(origenDatos);
            Reporte.SetParameters(paramsReporte);

            this.setLocalReport(rpvGeneral, Reporte);

            rpvGeneral.RefreshReport();
        }

        /// <summary>
        /// Setea el reporte a visualizar en el visor de reportes especificado.
        /// </summary>
        /// <param name="reportViewer"></param>
        /// <param name="report"></param>
        public void setLocalReport(ReportViewer reportViewer, LocalReport report)
        {
            var currentReportProperty = reportViewer.GetType().GetProperty("CurrentReport", BindingFlags.NonPublic | BindingFlags.Instance);
            if (currentReportProperty != null)
            {
                var currentReport = currentReportProperty.GetValue(reportViewer, null);
                var localReportField = currentReport.GetType().GetField("m_localReport", BindingFlags.NonPublic | BindingFlags.Instance);
                if (localReportField != null)
                {
                    localReportField.SetValue(currentReport, report);
                }
            }
            reportViewer.RefreshReport();
        }

        protected DataSet obtenerDataSet(string procedimiento)
        {
            try
            {
                DataSet res = Global.Servicio.EjecutarSP(procedimiento, Parametros);

                if (res.Tables.Count == 0)
                {
                    Mensaje unMensaje = new Mensaje("No se han encontrado datos del reporte.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
                    unMensaje.ShowDialog();
                }

                return res;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje("Error inesperado: " + ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return null;
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void cboArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoArticulo tipoArt = cboArticulo.SelectedItem != null ? ((TipoArticulo)((ComboBoxItem)cboArticulo.SelectedItem).Value) : null;
            if (tipoArt != null)
            {
                Cargador.cargarLotes(cboLote, tipoArt, 2);
            }
            else
            {
                cboLote.Items.Clear();
            }  
        }
    }
}
