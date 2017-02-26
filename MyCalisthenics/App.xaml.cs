using Xamarin.Forms;
using SQLite;
using Xamarin.Forms.Xaml;

//Mobile Center Depedencies
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using System;

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

			MainPage = new NavigationPage(new MyCalisthenicsList());
		}

		protected override void OnStart()
		{
			MobileCenter.Start(typeof(Analytics), typeof(Crashes));
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
