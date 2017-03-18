using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace MyCalisthenics
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyCalisthenicsList : ContentPage
	{
		public MyCalisthenicsList()
		{
			InitializeComponent();
		}

		async void OnNewWorkout(object sender, EventArgs e)
		{
			var workout = new Workout { 
				Workoutdate = DateTime.Today
			};

			await Navigation.PushAsync(new MyCalisthenicsPage(workout));
		}

		async void OnDelete(object sender, EventArgs e)
		{
			var menuitem = (MenuItem)sender;
			var workout = (Workout)menuitem.BindingContext;
			await App.WorkoutDB.DeleteWorkoutAsync(workout);
			OnAppearing();
		}

		async void OnTapped(object sender, ItemTappedEventArgs e)
		{
			if (e.Item == null)
			{
				return;
			}

			var workout = (Workout)e.Item;
			await Navigation.PushAsync(new MyCalisthenicsPage(workout));
		}

		protected async override void OnAppearing()
		{
			BindingContext =  await App.WorkoutDB.GetallWorkoutsAsync();
		}
	}
	
}
