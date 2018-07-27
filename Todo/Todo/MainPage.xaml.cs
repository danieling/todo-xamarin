using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Todo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usuarioEntry.Text) || string.IsNullOrWhiteSpace(passwordEntry.Text))
                resultadoLabel.Text = "Debe escribir usuario y contraseña";
            else
            {
                resultadoLabel.Text = "Inicio de sesion exitoso";
                await Navigation.PushAsync(new NewTodo());
            }
        }
    }
}
