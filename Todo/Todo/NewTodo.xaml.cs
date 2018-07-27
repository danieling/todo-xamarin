using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Todo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewTodo : ContentPage
	{
		public NewTodo ()
		{
			InitializeComponent ();
		}

        private void Guardar_Todo(object sender, EventArgs e)
        {

        }
    }
}