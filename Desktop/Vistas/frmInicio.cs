using Controles;
using Desktop.Vistas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Desktop
{
    public partial class frmInicio : FormBaseSinToolbar
    {

        List<Control> asteriscos = new List<Control>();
        List<Control> opciones = new List<Control>();
        string[] datosBoton1;
        string[] datosBoton2;
        string[] datosBoton3;
        string[] datosBoton4;
        int botonActivo = 0;

        public frmInicio()
        {
            InitializeComponent();

            datosBoton1 = new string[] { "Artículos", "Clientes", "Cotizaciones", "Precios", "Entradas", "Salidas", "Lotes", "Consulta Stock", "Consulta Salidas", "Lotes Cerrados" };
            datosBoton2 = new string[] { "Facturas", "Remitos", "Recibos", "Notas Deb/Cred", "Reporte Facturas", "Reporte Remitos", "Reporte Pagos" };
            datosBoton3 = new string[] { "Determinaciones", "Muestras", "Importación de Rutinas", "Firmas" };
            datosBoton4 = new string[] { "Backup", "Parametrizaciones" };
            
            asteriscos.Add(ast1); opciones.Add(opcion1);
            asteriscos.Add(ast2); opciones.Add(opcion2);
            asteriscos.Add(ast3); opciones.Add(opcion3);
            asteriscos.Add(ast4); opciones.Add(opcion4);
            asteriscos.Add(ast5); opciones.Add(opcion5);
            asteriscos.Add(ast6); opciones.Add(opcion6);
            asteriscos.Add(ast7); opciones.Add(opcion7);
            asteriscos.Add(ast8); opciones.Add(opcion8);
            asteriscos.Add(ast9); opciones.Add(opcion9);
            asteriscos.Add(ast10); opciones.Add(opcion10);
            asteriscos.Add(ast11); opciones.Add(opcion11);
            asteriscos.Add(ast12); opciones.Add(opcion12);

            pcbBoton1.BackgroundImage = Resources.usuariosSel;
            pcbMenu.Visible = true;
            mostrarOpciones(datosBoton1);
            botonActivo = 1;

            pcbBoton2.BackgroundImage = Resources.facturacionNew;
            pcbBoton3.BackgroundImage = Resources.rutinas;
            pcbBoton4.BackgroundImage = Resources.config;
        }

        #region "Manejo de Formularios"

        private void abrirFormulario(string nombreFrm)
        {
            //try
            //{
                //Seguridad.tienePermisos(nombreFrm, Global.Formularios);

                Form frm = frmFactory.Get(nombreFrm);
                frm.Location = new Point(
                                     pnlFondo.Width / 2 - frm.Size.Width / 2,
                                     pnlFondo.Height / 2 - frm.Size.Height / 2);
                frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
            //    unMensaje.ShowDialog();
            //}
        }

        #endregion

        //según el botón 
        //y la opción que selecciona el usuario (asterisco) se abre frm.
        public void eleccionUsuario(int nroBoton, int nroAsterisco)
        {
            switch (nroBoton)
            {
                //Administración
                #region administracion
                case 1:
                    {
                        //{ "Artículos", "Clientes", "Cotización Dólar", "Precios", "Reimprimir comprobantes" };
                        switch (nroAsterisco)
                        {
                            case 1:
                                {
                                    abrirFormulario("frmArticulos");
                                    break;
                                }
                            case 2:
                                {
                                    abrirFormulario("frmClientes");
                                    break;
                                }
                            case 3:
                                {
                                    abrirFormulario("frmCotizacion");
                                    break;
                                }
                            case 4:
                                {
                                    abrirFormulario("frmPrecios");
                                    break;
                                }
                            case 5:
                                {
                                    abrirFormulario("frmEntradas");
                                    break;
                                }
                            case 6:
                                {
                                    abrirFormulario("frmSalidas");
                                    break;
                                }
                            case 7:
                                {
                                    abrirFormulario("frmLotes");
                                    break;
                                }
                            case 8:
                                {
                                    abrirFormulario("frmConsultaStock");
                                    break;
                                }
                            case 9:
                                {
                                    abrirFormulario("frmTotalLts");
                                    break;
                                }
                            case 10:
                                {
                                    abrirFormulario("frmLotesCerrados");
                                    break;
                                }

                        }

                        break;
                    }
                #endregion

                #region ventas
                case 2:
                    {
                        switch (nroAsterisco)
                        {
                            case 1:
                                {
                                    abrirFormulario("frmFacturas");
                                    break;
                                }
                            case 2:
                                {
                                    abrirFormulario("frmRemitos");
                                    break;
                                }
                            case 3:
                                {
                                    abrirFormulario("frmRecibos");
                                    break;
                                }
                            case 4:
                                {
                                    abrirFormulario("frmNotaDebCred");
                                    break;
                                }
                            case 5:
                                {
                                    abrirFormulario("frmReporteFacturacion");
                                    break;
                                }
                            case 6:
                                {
                                    abrirFormulario("frmReporteRemitos");
                                    break;
                                }
                            case 7:
                                {
                                    abrirFormulario("frmRelPagosFacturas");
                                    break;
                                }
                        }
                        break;
                    }
                #endregion

                //ANÁLISIS
                #region analisis
                case 3:
                    {
                        //{ "Determinantes", "Muestras", "Planilla Cliente" };
                        switch (nroAsterisco)
                        {
                            case 1:
                                {
                                    abrirFormulario("frmDeterminantes");
                                    break;
                                }
                            case 2:
                                {
                                    abrirFormulario("frmMuestras");
                                    break; 
                                }
                            case 3:
                                {
                                    abrirFormulario("frmImportarRutina");
                                    break;                                    
                                }
                            case 4:
                                {
                                    abrirFormulario("frmFirmas");
                                    break;
                                }
                            //case 5:
                            //    {
                            //        abrirFormulario("frmVendedor");
                            //        break;
                            //    }
                        }
                        break;
                    }
                #endregion

                //SISTEMAS
                #region sistemas
                case 4:
                    {
                        //{ "Clientes", "Evaluación de vendedores", "Inventario detallado", "Inventario resumido", "Log de acciones de usuarios", 
                        //"Prefacturas", "Pronóstico de ventas", "Proveedores", "Rendimiento de cortes por proveedor", 
                        //"Usuarios", "Vendedores", "Ventas por vendedor" };
                        switch (nroAsterisco)
                        {
                            case 1:
                                {
                                    DialogResult dialog;
                                    Mensaje unMensaje = new Mensaje("Backup efectuado con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK); ;
                                    folderBrowserDialog1.SelectedPath = Environment.CurrentDirectory;
                                    dialog = folderBrowserDialog1.ShowDialog();

                                    if (dialog == System.Windows.Forms.DialogResult.OK)
                                    {
                                        try
                                        {
                                            Global.Servicio.hacerBackup(folderBrowserDialog1.SelectedPath);
                                        }
                                        catch (Exception ex)
                                        {
                                            unMensaje = new Mensaje("Ha ocurrido un error inesperado. Pruebe efectuando backup en un medio distinto. Detalles: " + ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                                        }
                                    }
                                    else
                                    {
                                        unMensaje = new Mensaje("Backup cancelado.", Mensaje.TipoMensaje.Informacion, Mensaje.Botones.OK); ;
                                    }
                                    unMensaje.ShowDialog();
                                    break;
                                }
                            case 2:
                                {
                                    abrirFormulario("frmParametrosSistema");
                                    break;
                                }                                                        
                        }

                        break;
                    }
                #endregion

            }
        }

        #region clics

        private void ast1_Click(object sender, EventArgs e)
        {
            eleccionUsuario(botonActivo, 1);
        }

        private void ast2_Click(object sender, EventArgs e)
        {
            eleccionUsuario(botonActivo, 2);
        }

        private void ast3_Click(object sender, EventArgs e)
        {
            eleccionUsuario(botonActivo, 3);
        }

        private void ast4_Click(object sender, EventArgs e)
        {
            eleccionUsuario(botonActivo, 4);
        }

        private void ast5_Click(object sender, EventArgs e)
        {
            eleccionUsuario(botonActivo, 5);
        }

        private void ast6_Click(object sender, EventArgs e)
        {
            eleccionUsuario(botonActivo, 6);
        }

        private void ast7_Click(object sender, EventArgs e)
        {
            eleccionUsuario(botonActivo, 7);
        }

        private void ast8_Click(object sender, EventArgs e)
        {
            eleccionUsuario(botonActivo, 8);
        }


        private void ast9_Click(object sender, EventArgs e)
        {
            eleccionUsuario(botonActivo, 9);
        }

        private void ast10_Click(object sender, EventArgs e)
        {
            eleccionUsuario(botonActivo, 10);
        }


        #endregion

        #region EventosBotones
        private void pcbBoton1_MouseEnter(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Hand;
            pcbBoton1.BackgroundImage = Resources.usuariosSel;
            pcbMenu.Visible = true;
            mostrarOpciones(datosBoton1);
            botonActivo = 1;

            pcbBoton2.BackgroundImage = Resources.facturacionNew;
            pcbBoton3.BackgroundImage = Resources.rutinas;
            pcbBoton4.BackgroundImage = Resources.config;
            lblSeccion.Text = "Administración";
        }

        private void pcbBoton1_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pcbBoton2_MouseEnter(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Hand;
            pcbBoton2.BackgroundImage = Resources.facturacionNewSel;
            pcbMenu.Visible = true;
            mostrarOpciones(datosBoton2);
            botonActivo = 2;
            pcbBoton1.BackgroundImage = Resources.usuarios;
            pcbBoton3.BackgroundImage = Resources.rutinas;
            pcbBoton4.BackgroundImage = Resources.config;
            lblSeccion.Text = "Ventas";
        }

        private void pcbBoton2_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pcbBoton3_MouseEnter(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Hand;
            pcbBoton3.BackgroundImage = Resources.rutinasSel;
            pcbMenu.Visible = true;
            mostrarOpciones(datosBoton3);
            botonActivo = 3;
            pcbBoton1.BackgroundImage = Resources.usuarios;
            pcbBoton2.BackgroundImage = Resources.facturacionNew;            
            pcbBoton4.BackgroundImage = Resources.config;
            lblSeccion.Text = "Análisis";
        }

        private void pcbBoton3_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pcbBoton4_MouseEnter(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Hand;
            pcbBoton4.BackgroundImage = Resources.configSel;
            pcbMenu.Visible = true;
            mostrarOpciones(datosBoton4);
            botonActivo = 4;
            pcbBoton1.BackgroundImage = Resources.usuarios;
            pcbBoton2.BackgroundImage = Resources.facturacionNew;
            pcbBoton3.BackgroundImage = Resources.rutinas;
            lblSeccion.Text = "Sistemas";
        }

        private void pcbBoton4_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        #endregion

        private void mostrarOpciones(string[] textos)
        {

            int cuantos = textos.Length;

            for (int i = asteriscos.Count; i > cuantos; i--)
            {
                asteriscos[i - 1].Visible = false;
                opciones[i - 1].Visible = false;
            }

            for (int i = 0; i < cuantos; i++)
            {
                asteriscos[i].Visible = true;
                opciones[i].Visible = true;
                opciones[i].Text = textos[i];
            }

        }        

        private void ast1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            ast1.ForeColor = Color.FromArgb(252, 243, 102);
            opcion1.ForeColor = Color.FromArgb(252, 243, 102);            
        }

        private void ast1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            ast1.ForeColor = Color.White;
            opcion1.ForeColor = Color.White;
        }

        private void ast2_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            ast2.ForeColor = Color.FromArgb(252, 243, 102);
            opcion2.ForeColor = Color.FromArgb(252, 243, 102);            
        }

        private void ast2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            ast2.ForeColor = Color.White;
            opcion2.ForeColor = Color.White;
        }

        private void ast3_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            ast3.ForeColor = Color.FromArgb(252, 243, 102);
            opcion3.ForeColor = Color.FromArgb(252, 243, 102);            
        }

        private void ast3_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            ast3.ForeColor = Color.White;
            opcion3.ForeColor = Color.White;
        }

        private void ast4_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            ast4.ForeColor = Color.FromArgb(252, 243, 102);
            opcion4.ForeColor = Color.FromArgb(252, 243, 102);            
        }

        private void ast4_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            ast4.ForeColor = Color.White;
            opcion4.ForeColor = Color.White;
        }

        private void ast5_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            ast5.ForeColor = Color.FromArgb(252, 243, 102);
            opcion5.ForeColor = Color.FromArgb(252, 243, 102); 
        }
        private void ast5_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            ast5.ForeColor = Color.White;
            opcion5.ForeColor = Color.White;
        }

        private void ast6_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            ast6.ForeColor = Color.FromArgb(252, 243, 102);
            opcion6.ForeColor = Color.FromArgb(252, 243, 102); 
        }

        private void ast6_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            ast6.ForeColor = Color.White;
            opcion6.ForeColor = Color.White;
        }

        private void ast7_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            ast7.ForeColor = Color.FromArgb(252, 243, 102);
            opcion7.ForeColor = Color.FromArgb(252, 243, 102); 
        }

        private void ast7_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            ast7.ForeColor = Color.White;
            opcion7.ForeColor = Color.White;
        }        

        private void ast8_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            ast8.ForeColor = Color.FromArgb(252, 243, 102);
            opcion8.ForeColor = Color.FromArgb(252, 243, 102); 
        }

        private void ast8_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            ast8.ForeColor = Color.White;
            opcion8.ForeColor = Color.White;
        }


        private void ast9_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            ast9.ForeColor = Color.FromArgb(252, 243, 102);
            opcion9.ForeColor = Color.FromArgb(252, 243, 102); 
        }

        private void ast10_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            ast10.ForeColor = Color.FromArgb(252, 243, 102);
            opcion10.ForeColor = Color.FromArgb(252, 243, 102); 
        }

        private void ast10_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            ast10.ForeColor = Color.White;
            opcion10.ForeColor = Color.White;
        }

        private void ast9_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            ast9.ForeColor = Color.White;
            opcion9.ForeColor = Color.White;
        }     

        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            (new frmLogin()).Show();
        }
                
                                              
    }
}
