using Base;
using Controles;
using Entidades;
using Frontend.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Vistas.Sistemas
{
    public partial class frmParametrosSistema : FormBaseConToolbar
    {
        public frmParametrosSistema()
        {
            InitializeComponent();
            btnAgregar.Visible = false;
            btnBuscar.Visible = false;
            btnEliminar.Visible = false; 
        }

        protected override void modificar()
        {
            ltvParametrosSistema.ReadOnly = false;
            ltvParametrosSistema.Columns[0].ReadOnly = true;
            ltvParametrosSistema.Columns[1].ReadOnly = true;
            ltvParametrosSistema.Columns[2].ReadOnly = true;
            ltvParametrosSistema.Columns[3].ReadOnly = false;
        }

        protected override bool guardar()
        {
            List<ParametroSistema> parametrosSistema = new List<ParametroSistema>();
            ParametroSistema param;
            int aux1;
            long aux2;
            bool aux3;
            decimal aux4;
            try
            {
                foreach (DataGridViewRow fila in ltvParametrosSistema.Rows)
                {
                    if (fila.Tag != null)
                    {
                        param = (ParametroSistema)fila.Tag;
                        param.nombre = fila.Cells[0].Value.ToString();
                        param.descripcion = fila.Cells[1].Value.ToString();
                        param.tipoDato = fila.Cells[2].Value.ToString();

                        switch (param.tipoDato)
                        {
                            case "Cadena":
                                break;
                            case "Entero(9)":
                                if (!int.TryParse(fila.Cells[3].Value.ToString(), out aux1))
                                    throw new Exception("Dato '" + fila.Cells[3].Value.ToString() + "' no válido para un tipo de dato Entero(9)");
                                break;
                            case "Entero(18)":
                                if (!long.TryParse(fila.Cells[3].Value.ToString(), out aux2))
                                    throw new Exception("Dato '" + fila.Cells[3].Value.ToString() + "' no válido para un tipo de dato Entero(18)");
                                break;
                            case "Lógico":
                                if (!bool.TryParse(fila.Cells[3].Value.ToString(), out aux3))
                                    throw new Exception("Dato '" + fila.Cells[3].Value.ToString() + "' no válido para un tipo de dato Lógico");
                                break;
                            case "Decimal":
                                if (!decimal.TryParse(fila.Cells[3].Value.ToString(), out aux4))
                                    throw new Exception("Dato '" + fila.Cells[3].Value.ToString() + "' no válido para un tipo de dato Decimal");
                                break;
                            default:
                                throw new Exception("Tipo de dato no encontrado");
                        }

                        param.valor = fila.Cells[3].Value.ToString();

                        parametrosSistema.Add(param);
                    }
                }

                Global.Servicio.modificarParametrosSistema(parametrosSistema, Global.DatosSesion);

                Mensaje msj = new Mensaje("Parámetros modificados con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                msj.ShowDialog();
                limpiar();
                return true;
            }
            catch (ExcepcionValidacion ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return false;

        }

        protected override void limpiar()
        {
            ltvParametrosSistema.ReadOnly = true;
        }

        protected override bool cargarBusqueda()
        {
            // Obtenemos los parametros
            List<ParametroSistema> parametrosSistema = Global.Servicio.obtenerTodosParametrosSistema();
            int indiceAux;
            foreach (ParametroSistema param in parametrosSistema)
            {
                indiceAux = ltvParametrosSistema.Rows.Add();

                ltvParametrosSistema.Rows[indiceAux].Cells[0].Value = param.nombre;
                ltvParametrosSistema.Rows[indiceAux].Cells[1].Value = param.descripcion;
                ltvParametrosSistema.Rows[indiceAux].Cells[2].Value = param.tipoDato;
                ltvParametrosSistema.Rows[indiceAux].Cells[3].Value = param.valor;

                ltvParametrosSistema.Rows[indiceAux].Tag = param;
            }

            return true;
        }

        private void frmParametrosSistema_Shown(object sender, EventArgs e)
        {
            cargarBusqueda();
            cambiarEstado(Estados.Consultar);
        }


    }
}
