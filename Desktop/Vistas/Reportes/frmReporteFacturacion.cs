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
    public partial class frmReporteFacturacion : FormBaseSinToolbar
    {
        private Dictionary<string, object> Parametros { get; set; }
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private long idCliente;

        public frmReporteFacturacion ()
        {
            InitializeComponent();
            this.idCliente = 0;
            dtpFechaDesde.Value = DateTime.Now.AddMonths(-1);            
            Cargador.cargarNombresClientes(txtCliente,"");
            cargar();
        }

        private void frmReporteFacturacion_Load(object sender, EventArgs e)
        {
            this.rpvGeneral.RefreshReport();
        }

        protected void cargar()
        {
            this.fechaDesde = dtpFechaDesde.Value; 
            this.fechaHasta = dtpFechaHasta.Value;

            //Comienzo carga de reporte
            LocalReport Reporte = new LocalReport();
            byte[] reporte;

            reporte = Desktop.Reportes.ReporteFacturacion;

            Stream archivoReporte = new MemoryStream(reporte);
            Reporte.LoadReportDefinition(archivoReporte);

            Parametros = new Dictionary<string, object>();
            Parametros.Add("fd", fechaDesde.ToShortDateString());
            Parametros.Add("fh", fechaHasta.ToShortDateString());
            Parametros.Add("idCli", idCliente.ToString());

            DataSet dataSet = obtenerDataSet("ReporteFacturacion");
            ReportDataSource origenDatos = new ReportDataSource("DataSet1", dataSet.Tables[0]);

            List<ReportParameter> paramsReporte = new List<ReportParameter>();
            paramsReporte.Add(new ReportParameter("fd", fechaDesde.ToShortDateString()));
            paramsReporte.Add(new ReportParameter("fh", fechaHasta.ToShortDateString()));
            paramsReporte.Add(new ReportParameter("idCli", idCliente.ToString()));

            Reporte.DataSources.Add(origenDatos);
            Reporte.SetParameters(paramsReporte);

            this.setLocalReport(rpvGeneral, Reporte);

            rpvGeneral.RefreshReport();
        }

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

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            idCliente = ((Cliente)Global.Servicio.buscarUnCliente(txtCliente.Text.Trim(), "")).id;
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            txtCliente_KeyPress(sender, new KeyPressEventArgs((char)Keys.Enter));
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
