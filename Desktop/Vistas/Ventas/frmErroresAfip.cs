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
using System.Drawing.Printing;
using System.Globalization;

namespace Desktop.Vistas.Ventas
{       
    public partial class frmErroresAfip : FormBaseSinToolbar
    {
        private FEAfip.DTOSolicitud solicitud;

        public frmErroresAfip()
        {
            InitializeComponent();
        }

        public frmErroresAfip(FEAfip.DTOSolicitud solicitud)
        {
            this.solicitud = solicitud;
            InitializeComponent();
        }

        private void frmErroresAfip_Load(object sender, EventArgs e)
        {
            int i = 0;            

            foreach (FEAfip.DTOObservSolicitud obs in solicitud.ObservacionSolicitud)
            {
                dgvObserv.Rows.Add();
                dgvObserv.Rows[i].Tag = obs;
                dgvObserv.Rows[i].Cells["clmObsCod"].Value = obs.CodObserv.ToString();
                dgvObserv.Rows[i].Cells["clmObsDesc"].Value = obs.DescObserv.ToString();
                i++;
            }

            i = 0;
            foreach (FEAfip.DTOErrorSolicitud error in solicitud.ErrorSolicitud)
            {
                dgvErrores.Rows.Add();
                dgvErrores.Rows[i].Tag = error;
                dgvErrores.Rows[i].Cells["clmErrCod"].Value = error.CodError.ToString();
                dgvErrores.Rows[i].Cells["clmErrDesc"].Value = error.DescError.ToString();
                i++;
            }

            i = 0;
            foreach (FEAfip.DTOEventoSolicitud ev in solicitud.EventoSolicitud)
            {
                //try
                //{
                    dgvEventos.Rows.Add();
                    dgvEventos.Rows[i].Tag = ev;
                    dgvEventos.Rows[i].Cells["clmEvCod"].Value = ev.CodEvent.ToString();
                    dgvEventos.Rows[i].Cells["clmEvDesc"].Value = ev.DescEvent.ToString();
                    i++;
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                
            }
        }
    }
}
