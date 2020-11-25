using Desktop.Vistas;
using Entidades;
using Frontend.Controles;
using ModuloServicios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.ServiceProcess;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Global.Servicio.EnviarMailFactura(null, "flores.marianon@gmail.com","");

            string advertencia = string.Empty;
            bool errorConBD = false;
            CultureInfo ci = new System.Globalization.CultureInfo("es-ES");
            ci.NumberFormat.CurrencyDecimalSeparator = ".";
            ci.NumberFormat.NumberDecimalSeparator = ".";
            ci.NumberFormat.NumberGroupSeparator = ",";
            ci.NumberFormat.CurrencyGroupSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;// new System.Globalization.CultureInfo("en-US");

            Application.EnableVisualStyles();
            SplashScreen.ShowSplashScreen();
            Application.DoEvents();
            SplashScreen.SetStatus("Inicializando módulo de Servicios...");

            SplashScreen.SetStatus("Verificando instancia DB...");
            string instancia = ConfigurationManager.AppSettings["InstanciaBD"];
            if (instancia != "SinServicio")
            {
                ServiceController sc = new ServiceController(instancia);
                try
                {
                    if (sc != null)
                    {
                        if (sc.Status == ServiceControllerStatus.Stopped)
                        {
                            sc.Start();
                            while (sc.Status == ServiceControllerStatus.Stopped)
                            {
                                Thread.Sleep(1000);
                                sc.Refresh();
                            }
                        }
                        if (sc.Status == ServiceControllerStatus.Running)
                        {
                            SplashScreen.SetStatus("Instancia ejecutándose correctamente...");
                        }
                    }
                    else
                    {
                        SplashScreen.SetStatus("Instancia no encontrada...");
                    }
                }
                catch (Exception ex)
                {
                    var message = "";
                    if (ex.InnerException != null)
                        message = ex.InnerException.Message;
                    else
                        message = ex.Message;

                    SplashScreen.CloseForm();
                    MessageBox.Show(String.Format("Ha ocurrido un error verificando el servicio de base de datos. Instancia: {0}. Detalles: {1} ¿Ha probado ejecutar la aplicación como administrador?{2}Aplicación abortada.", instancia, message, Environment.NewLine));
                    errorConBD = true;
                }
            }
            if (!errorConBD)
            {
                Thread.Sleep(1000);

                SplashScreen.SetStatus("Corroborando rutinas generadas...");
                try
                {
                    Global.Servicio.corroboraArchivosLocales();
                }
                catch (Exception ex)
                {
                    advertencia = ex.Message;
                }
                SplashScreen.SetStatus("Validando usuarios...");
                Usuario administrador = Global.Servicio.obtenerAdministrador();
                SplashScreen.SetStatus("Inicializando...");

                SplashScreen.CloseForm();

                frmLogin form = new frmLogin(advertencia);

                Application.Run(form);
            }
        }


    }
}
