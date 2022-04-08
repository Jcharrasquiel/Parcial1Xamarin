using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Parcial1Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Cuenta(object sender, EventArgs e)
        {
            
            double total = double.Parse(Total.Text);
            double numero = double.Parse(Numero.Text);
            double propina = double.Parse(Propina.Text);

            double VrPropina = total * (propina / 100);
            double IndPropina = VrPropina / numero;
            double Totalmaspropina = VrPropina + total;
            double Totalind = Totalmaspropina / numero;

            VrPropina = Math.Round(VrPropina);
            IndPropina = Math.Round(IndPropina);
            Totalmaspropina = Math.Round(Totalmaspropina);
            Totalind = Math.Round(Totalind);

            this.VrPropina.Text = VrPropina.ToString();
            this.IndPropina.Text = IndPropina.ToString();
            this.Totalmaspropina.Text = Totalmaspropina.ToString();
            this.Totalind.Text = Totalind.ToString();

            DisplayAlert("Exito", "Su cuenta ha sido calculada", "OK");

        }

        private void Limpiar(object sender, EventArgs e)
        {
            Total.Text = string.Empty;
            Numero.Text = string.Empty;
            Propina.Text = string.Empty;
            VrPropina.Text = string.Empty;
            IndPropina.Text = string.Empty;
            Totalmaspropina.Text = string.Empty;
            Totalind.Text = string.Empty;

            DisplayAlert("Exito", "Campos vacios", "OK");
        }
    }
}
