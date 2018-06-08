using Controles;
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
    public partial class frmReporteAnalisis : FormBaseSinToolbar
    {
        private Dictionary<string, object> Parametros { get; set; }
        public string ProcedimientoAlmacenado { get; set; }
        private string DataSet { get; set; }
        private string DataSet2 { get; set; }
        private LocalReport Reporte { get; set; }
        private long idRutina;
        
        public enum orientacionDef { Horizontal = 1 , Vertical = 2 }
        public orientacionDef orientacion;

        public frmReporteAnalisis(long idRutina, orientacionDef orientacion)
        {
            InitializeComponent();
            this.idRutina = idRutina;
            this.orientacion = orientacion;
            cargar();
        }

        private void frmReporteAnalisis_Load(object sender, EventArgs e)
        {
            this.rpvGeneral.RefreshReport();
        }

        protected void cargar()
        {
            LocalReport Reporte = new LocalReport();
            byte[] reporte;

            reporte = Desktop.Reportes.Analisis;

            Stream archivoReporte = new MemoryStream(reporte);
            Reporte.LoadReportDefinition(archivoReporte);            

            Parametros = new Dictionary<string, object>();
            Parametros.Add("idRutina", idRutina);

            DataSet dataSet = obtenerDataSet("Rutina");
            DataSet dataSet2 = obtenerDataSet("MuestrasRutina");
            ReportDataSource origenDatos = new ReportDataSource("Rutina", dataSet.Tables[0]);
            ReportDataSource origenDatos2 = new ReportDataSource("MuestrasRutina", dataSet2.Tables[0]);

            List<ReportParameter> paramsReporte = new List<ReportParameter>();
            paramsReporte.Add(new ReportParameter("idRutina", idRutina.ToString()));
            Reporte.DataSources.Add(origenDatos);
            Reporte.DataSources.Add(origenDatos2);
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

    }
}
