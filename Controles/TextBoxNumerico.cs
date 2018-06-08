using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class TextBoxNumerico : TextBoxQuimadh
    {
        public int Decimales { get; set; }
        public int Enteros { get; set; }
        private string TextoPrevio { get; set; }
        private char Separador { get; set; }
        /// <summary>
        /// Indica si la tecla enter permitirá avanzar a través de los controles del formulario.
        /// </summary>
        public Boolean EnterTabulacion { get; set; }

        public TextBoxNumerico()
            : base()
        {
            this.KeyPress += new KeyPressEventHandler(TextBoxNumerico_KeyPress);
            this.LostFocus += new EventHandler(TextBoxNumerico_LostFocus);
            this.Enter += new EventHandler(TextBoxNumerico_Enter);
            this.Click += new EventHandler(TextBoxNumerico_Click);
            this.Separador = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            this.TextAlign = HorizontalAlignment.Right;
            this.EnterTabulacion = true;
        }

        public override string Text
        {
            get
            {
                decimal valor;
                if (decimal.TryParse(base.Text, out valor))
                    if (valor == 0)
                        return "";

                return base.Text;
            }
            set
            {
                decimal valor = 0;
                if (decimal.TryParse(value, out valor))
                    if (valor == 0)
                        if (Decimales > 0)
                            base.Text = "0" + Separador + "00";
                        else
                            base.Text = "0";
                    else
                        //En caso de problemas con el formato, consultar: http://msdn.microsoft.com/es-es/library/dwhawy9k.aspx
                        if (Decimales == 0)
                            base.Text = valor.ToString("##########");
                        else
                            base.Text = valor.ToString("#######.#####");
                else
                    base.Text = value;
            }
        }

        void TextBoxNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {


                //Con texto seleccionado conviene no manipular el textbox, no trabaja bien
                if (this.SelectedText.Length == 0)
                {

                    if (e.KeyChar == 46)
                        e.KeyChar = Separador;

                    //Si presiona un separador (coma o punto) y no posee decimales no deberá admitir el ingreso del mismo
                    if (e.KeyChar.Equals(Separador) && Decimales == 0)
                        e.Handled = true;

                    // Valida que solo se admitan números y el caracter serparador decimal.
                    if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != Separador)
                        e.Handled = true;

                    // Valida que solo tenga un punto decimal
                    if (e.KeyChar == Separador && (sender as TextBox).Text.IndexOf(Separador) > -1)
                        e.Handled = true;

                    // Obtiene las partes
                    string[] partes = this.Text.Split(Separador);
                    Boolean ingresaEnteros = false;  //Variable que nos determina si se están ingresando enteros o decimales

                    //Me encuentro en decimales
                    if (this.SelectionStart > partes[0].Length)
                        ingresaEnteros = false;
                    else
                        ingresaEnteros = true;


                    //Si es un caracter de control no realizamos validaciones
                    if (!Char.IsControl(e.KeyChar))
                    {
                        //Valida que la parte entera del número no sea superior a los enteros asignados al inicio del control
                        if (partes[0].Length > Enteros - 1 && ingresaEnteros)
                            e.Handled = true;

                        //Valida que la parte decimal del número no sea superior a los decimales asignados al inicio del control
                        if (partes.Count() > 1)
                            if (partes[1].Length > Decimales - 1 && !ingresaEnteros)
                                e.Handled = true;

                    }
                }
            }
            catch (Exception ex)
            { }

        }

        void TextBoxNumerico_LostFocus(object sender, EventArgs e)
        {
            double numero = 0;
            if (Double.TryParse(this.Text, out numero))
                if (numero == 0)
                    this.Text = "0";
                else
                    this.Text = numero.ToString("#########.######");
            else
                this.Text = "0";
        }

        void TextBoxNumerico_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.Text))
            {
                this.SelectionStart = 0;
                this.SelectionLength = this.Text.Length;
            }
        }

        void TextBoxNumerico_Click(object sender, EventArgs e)
        {
            TextBoxNumerico_Enter(sender, e);
        }
    }
}
