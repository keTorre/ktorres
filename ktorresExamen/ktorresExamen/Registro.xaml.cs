using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ktorresExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text =usuario;

        }

        private void btnCalcularPmensual_Clicked(object sender, EventArgs e)
        {
            double pagoAdicional = 4000 * 0.05;
            double pagoInicial = Convert.ToDouble(txtMontoInicial.Text);
            double pagoMensual = ((4000 - pagoInicial) / 5) + pagoAdicional;
            string nombre = txtNombre.Text;
            lblPagoMensual.Text = Convert.ToString(pagoMensual);


        }

        private void btnGuardarInformacion_Clicked(object sender, EventArgs e)
        {
            string usuario = lblUsuario.Text;
            double pagoAdicional = 4000 * 0.05;
            string nombre = txtNombre.Text;
            double pagoInicial = Convert.ToDouble(txtMontoInicial.Text);
            double pagoMensual = ((4000 - pagoInicial) / 5) + pagoAdicional;
            DisplayAlert("Guardado con Exito", nombre, "Cerrar");
            Navigation.PushAsync(new Resumen(nombre, pagoInicial, pagoMensual,usuario));
        }
    }
}