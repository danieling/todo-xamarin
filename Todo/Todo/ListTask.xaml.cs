using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Todo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListTask : ContentPage
	{
		public ListTask ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            using(SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(App.DBPath))
            {
                List<NewTask> tasks;
                tasks = conexion.Table<NewTask>().ToList();
                listTasksView.ItemsSource = tasks;
            }
        }
    }
}