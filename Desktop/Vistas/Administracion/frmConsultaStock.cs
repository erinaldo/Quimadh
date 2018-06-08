using Controles;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Vistas.Administracion
{
    public partial class frmConsultaStock : FormBaseSinToolbar
    {
        public frmConsultaStock()
        {
            InitializeComponent();
        }

        private void cboArticulo_Click(object sender, EventArgs e)
        {
            //TipoArticulo tipoArt = cboArticulo.SelectedItem != null ? ((TipoArticulo)((ComboBoxItem)cboArticulo.SelectedItem).Value) : null;
            //if (tipoArt != null)
            //    Cargador.cargarLotes(cboLote, tipoArt, "Sin Seleccionar...");
            //else
            //    cboLote.Items.Clear();
        }

        private void frmConsultaStock_Load(object sender, EventArgs e)
        {
            Cargador.cargarArticulos(cboArticulo, "Sin Seleccionar...");
            Cargador.cargarPresentaciones(cboPresentacion, "Sin Seleccionar...");
        }

        //private void cboArticulo_Leave(object sender, EventArgs e)
        //{
        //    TipoArticulo tipoArt = cboArticulo.SelectedItem != null ? ((TipoArticulo)((ComboBoxItem)cboArticulo.SelectedItem).Value) : null;
        //    if (tipoArt != null)
        //        Cargador.cargarLotes(cboLote, tipoArt, true,"Sin Seleccionar...");
        //    else
        //        cboLote.Items.Clear();
        //}

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            TipoArticulo tipoArt = cboArticulo.SelectedItem != null ? ((TipoArticulo)((ComboBoxItem)cboArticulo.SelectedItem).Value) : null;

            if (tipoArt == null)
            {
                Mensaje mensajeErr;
                mensajeErr = new Mensaje("Seleccione un artículo", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                mensajeErr.ShowDialog();
                return;
            }
                
            Lote lote = cboLote.SelectedItem != null ? ((Lote)((ComboBoxItem)cboLote.SelectedItem).Value) : null;
            Presentacion present = cboPresentacion.SelectedItem != null ? ((Presentacion)((ComboBoxItem)cboPresentacion.SelectedItem).Value) : null;
            decimal stock = Global.Servicio.calcularStock(tipoArt, lote, present);
            txtStock.Text = stock.ToString("0.00");
        }

        private void cboArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoArticulo tipoArt = cboArticulo.SelectedItem != null ? ((TipoArticulo)((ComboBoxItem)cboArticulo.SelectedItem).Value) : null;
            if (tipoArt != null)
            {
                Cargador.cargarLotes(cboLote, tipoArt, 2, "Sin Seleccionar...");
                lblUnidad.Text = tipoArt.Unidad1 != null ? tipoArt.Unidad1.abreviatura : "Sin unidad";
            }                
            else
                cboLote.Items.Clear();
        }
    }
}
