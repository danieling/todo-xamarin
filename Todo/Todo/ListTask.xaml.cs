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

            var btn_newTask = new ToolbarItem()
            {
                Text = "+"
            };
            btn_newTask.Clicked += AddTask;
            ToolbarItems.Add(btn_newTask);
		}

        async void AddTask(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewTodo());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            using(SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(App.DBPath))
            {
                List<NewTask> tasks;
                tasks = conexion.Table<NewTask>().Where(t => t.TaskComplete == false).ToList();
                listTasksView.ItemsSource = tasks;
            }
        }
        
        void taskComplete(object sender, System.EventArgs e)
        {
            using(SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(App.DBPath))
            {
                var taskAcomplish = (sender as MenuItem).CommandParameter as NewTask;
                taskAcomplish.TaskComplete = true;
                conexion.Update(taskAcomplish);
                List<NewTask> tasks = conexion.Table<NewTask>().Where(t => t.TaskComplete == false).ToList();
                listTasksView.ItemsSource = tasks;
            }
        }
    }
}