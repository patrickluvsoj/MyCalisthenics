using Xamarin.Forms;
using SQLite;

namespace MyCalisthenics
{
	public partial class App : Application
	{
		public static WorkoutDatabase WorkoutDB { get; set;}

		public App(string dbpath)
		{
			InitializeComponent();

			WorkoutDB = new WorkoutDatabase(dbpath);

			MainPage = new MyCalisthenicsPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
