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

			var nav = new NavigationPage(new MyCalisthenicsList());
			nav.BarTextColor = Color.FromHex("#545454");

			MainPage = nav;
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
