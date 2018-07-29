using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Todo.Resources;
using System.Globalization;

namespace Todo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            //LocalizationResources.Culture = new CultureInfo("es-BO");
            usuarioEntry.Placeholder = LocalizationResources.Username;
            passwordEntry.Placeholder = LocalizationResources.PASSWORD;
            btn_signin.Text = LocalizationResources.BTN_SIGNIN;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usuarioEntry.Text) || string.IsNullOrWhiteSpace(passwordEntry.Text))
            {
                resultadoLabel.TextColor = Color.IndianRed;
                resultadoLabel.Text = LocalizationResources.msg_alert;
            }
            else
            {
                resultadoLabel.TextColor = Color.AliceBlue;
                resultadoLabel.Text = LocalizationResources.msg_info;
                await Navigation.PushAsync(new ListTask());
            }
        }
    }
}
