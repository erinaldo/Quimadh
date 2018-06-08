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

namespace Desktop.Vistas.Administracion
{
    public partial class frmLotesCerrados : FormBaseSinToolbar
    {
        private Dictionary<string, object> Parametros { get; set; }
        private long idTipoArticulo;
        private string nroLote;

        public frmLotesCerrados(long idTipoArticulo,string nroLote)
        {
            InitializeComponent();
            this.idTipoArticulo = idTipoArticulo;
            this.nroLote = nroLote;
            cargar();
        }

        private void frmLotesCerrados_Load(object sender, EventArgs e)
        {
            Cargador.cargarArticulos(cboArticulo, "Sin Seleccionar...");
            this.rpvGeneral.RefreshReport();            
        }

        protected void cargar()
        {            
            //Comienzo carga de reporte
            LocalReport Reporte = new LocalReport();
            byte[] reporte;

            reporte = Desktop.Reportes.LotesCerrados;

            Stream archivoReporte = new MemoryStream(reporte);
            Reporte.LoadReportDefinition(archivoReporte);

            Parametros = new Dictionary<string, object>();
            Parametros.Add("idTipoArticulo", idTipoArticulo);
            Parametros.Add("nroLote", nroLote);

            DataSet dataSet = obtenerDataSet("LotesCerrados");
            ReportDataSource origenDatos = new ReportDataSource("DataSet1", dataSet.Tables[0]);

            List<ReportParameter> paramsReporte = new List<ReportParameter>();
            paramsReporte.Add(new ReportParameter("idTipoArticulo", idTipoArticulo.ToString()));
            paramsReporte.Add(new ReportParameter("nroLote", nroLote));

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

        private void cboArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoArticulo tipoArt = cboArticulo.SelectedItem != null ? ((TipoArticulo)((ComboBoxItem)cboArticulo.SelectedItem).Value) : null;
            if (tipoArt != null)
                Cargador.cargarLotes(cboLote, tipoArt, 1, "Sin Seleccionar...");
            else
                cboLote.Items.Clear();
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            this.idTipoArticulo = cboArticulo.Text != "Sin Seleccionar..." ? ((TipoArticulo)((ComboBoxItem)cboArticulo.SelectedItem).Value).id : 0;
            this.nroLote = cboLote.Text != "Sin Seleccionar..." && cboLote.Text.Trim() != "" ? cboLote.Text : "0";
            cargar();
        }
    }
}
