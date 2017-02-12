using Xamarin.Forms;
using SQLite;
using Xamarin.Forms.Xaml;

namespace MyCalisthenics
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class App : Application
	{
		public static WorkoutDatabase WorkoutDB { get; set;}

		public App(string dbpath)
		{
			InitializeComponent();

			WorkoutDB = new WorkoutDatabase(dbpath);

			MainPage = new MyCalisthenicsPage(WorkoutDB);
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
