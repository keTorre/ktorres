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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnIniciar_Clicked_1(object sender, EventArgs e)
        {
            string usuario = "estudiante2022";
            string contraseña = "uisrael2022";
            if (txtUsuario.Text == usuario && txtContraseña.Text == contraseña)
            {
                DisplayAlert("Bienvenido", usuario, "Cerrar");
                Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                DisplayAlert("Error", "Usuario o contraseña Incorrecta", "Error");
            }
        }
    }
}
