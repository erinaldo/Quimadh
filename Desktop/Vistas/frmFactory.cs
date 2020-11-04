using Desktop.Vistas.Administracion;
using Desktop.Vistas.Analisis;
using Desktop.Vistas.Reportes;
using Desktop.Vistas.Sistemas;
using Desktop.Vistas.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Vistas
{
    public static class frmFactory
    {
        public static Form Get(string nombreFrm)
        {
            switch (nombreFrm)
            {
                case "frmArticulos":
                    return new frmArticulos();                
                case "frmClientes":
                    return new frmClientes();
                case "frmCotizacion":
                    return new frmCotizacion();
                case "frmPrecios":
                    return new frmPrecios();
                case "frmFacturas":
                    return new frmFacturas();
                case "frmRemitos":
                    return new frmRemitos();
                case "frmRecibos":
                    return new frmRecibos();
                case "frmNotaDebCred":
                    return new frmNotaDebCred();
                case "frmDeterminantes":
                    return new frmDeterminantes();
                case "frmMuestras":
                    return new frmMuestras();
                case "frmRutinas":
                    return new frmRutinas();
                case "frmImportarRutina":
                    return new frmImportarRutina();
                case "frmParametrosSistema":
                    return new frmParametrosSistema();
                case "frmFirmas":
                    return new frmFirmas();
                case "frmSalidas":
                    return new frmSalidas();
                case "frmEntradas":
                    return new frmEntradas();
                case "frmLotes":
                    return new frmLotes();
                case "frmConsultaStock":
                    return new frmConsultaStock();
                case "frmLotesCerrados":
                    return new frmLotesCerrados(0,"0");
                case "frmTotalLts":
                    return new frmTotalLts();
                case "frmReporteFacturacion":
                    return new frmReporteFacturacion();
                case "frmReporteRemitos":
                    return new frmReporteRemitos();
                case "frmRelPagosFacturas":
                    return new frmRelPagosFacturas();

                default: return null;
            }
        }
    }
}
