using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Model;
using Todo.Resources;
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
            NewTask newTask = new NewTask()
            {
                Nombre = nombreEntry.Text,
                Fecha = dateline.Date,
                Hora = timeline.Time,
                TaskComplete = false
            };

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.DBPath))
            {
                connection.CreateTable<NewTask>();
                var resultado = connection.Insert(newTask);
                if (resultado > 0)
                    DisplayAlert(LocalizationResources.msg_success, LocalizationResources.msg_save, "OK");
            }
        }
    }
}