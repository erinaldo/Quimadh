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
    public partial class frmGraficoQuimadh : FormBaseSinToolbar
    {
        private Dictionary<string, object> Parametros { get; set; }
        public string ProcedimientoAlmacenado { get; set; }
        private string DataSet { get; set; }
        private string DataSet2 { get; set; }
        private LocalReport Reporte { get; set; }
        private long idPlanta;
        private long idMuestra;
        private long idDeterminante;
        private DateTime fechaDesde;
        private DateTime fechaHasta;

        public enum orientacionDef { Horizontal = 1, Vertical = 2 }
        public orientacionDef orientacion;

        public frmGraficoQuimadh(long idPlanta, long idMuestra, long idDeterminante, DateTime fechaDesde, DateTime fechaHasta)
        {
            InitializeComponent();

            this.idPlanta = idPlanta;
            this.idMuestra = idMuestra;
            this.idDeterminante = idDeterminante;
            dtpFechaDesde.Value = fechaDesde.AddMonths(-6);
            dtpFechaHasta.Value = fechaHasta.AddMonths(6);
            cargar();
        }

        private void frmGraficoQuimadh_Load(object sender, EventArgs e)
        {
            this.rpvGeneral.RefreshReport();
        }

        protected void cargar()
        {
            //Muestra muestra = Global.Servicio.obtenerMuestra(idMuestra);
            //Determinante determinante = Global.Servicio.obtenerDeterminante(idDeterminante);
            Planta planta = Global.Servicio.obtenerPlanta(idPlanta);

            lblPlanta.Text = String.Format("Planta: {0}.", planta.nombre.Trim());// Determinación: {1}. Muestra: {2}.", planta.nombre.Trim(), determinante.nombre.Trim(), muestra.Descripcion.Trim());

            this.fechaDesde = dtpFechaDesde.Value; 
            this.fechaHasta = dtpFechaHasta.Value; 

            //Comienzo carga de reporte
            LocalReport Reporte = new LocalReport();
            byte[] reporte;

            reporte = Desktop.Reportes.GraficoQuimadhMuestraDeterminante;

            Stream archivoReporte = new MemoryStream(reporte);
            Reporte.LoadReportDefinition(archivoReporte);

            Parametros = new Dictionary<string, object>();
            Parametros.Add("fechaDesde", fechaDesde.ToShortDateString());
            Parametros.Add("fechaHasta", fechaHasta.ToShortDateString());
            Parametros.Add("idPlanta", idPlanta.ToString());
            Parametros.Add("idMuestra", idMuestra.ToString());
            Parametros.Add("idDeterminante", idDeterminante.ToString());
            if (String.IsNullOrEmpty(txtMinimo.Text))
                Parametros.Add("valorMinimo", "999999999999.9999");
            else
                Parametros.Add("valorMinimo", txtMinimo.Text);

            if (String.IsNullOrEmpty(txtMaximo.Text))
                Parametros.Add("valorMaximo", "999999999999.9999");
            else
                Parametros.Add("valorMaximo", txtMaximo.Text);
            
            DataSet dataSet = obtenerDataSet("GraficosRutinaPlanta");
            ReportDataSource origenDatos = new ReportDataSource("DataSet1", dataSet.Tables[0]);

            List<ReportParameter> paramsReporte = new List<ReportParameter>();
            paramsReporte.Add(new ReportParameter("fechaDesde", fechaDesde.ToShortDateString()));
            paramsReporte.Add(new ReportParameter("fechaHasta", fechaHasta.ToShortDateString()));
            paramsReporte.Add(new ReportParameter("idPlanta", idPlanta.ToString()));
            paramsReporte.Add(new ReportParameter("idMuestra", idMuestra.ToString()));
            paramsReporte.Add(new ReportParameter("idDeterminante", idDeterminante.ToString()));

            if (String.IsNullOrEmpty(txtMinimo.Text))
                paramsReporte.Add(new ReportParameter("valorMinimo", "999999999999.9999"));
            else
                paramsReporte.Add(new ReportParameter("valorMinimo", txtMinimo.Text));  

            if (String.IsNullOrEmpty(txtMaximo.Text))
                paramsReporte.Add(new ReportParameter("valorMaximo", "999999999999.9999"));
            else
                paramsReporte.Add(new ReportParameter("valorMaximo", txtMaximo.Text));

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
    }
}
