using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace MyCalisthenics
{
	public partial class MyCalisthenicsList : ContentPage
	{
		public static IList<Workout> workouts {get; set;}

		public MyCalisthenicsList()
		{
			InitializeComponent();
		}

		public void OnNewWorkout(object sender, EventArgs e)
		{
			var workout = new Workout();
			workout.Workoutdate = DateTime.Today;
			workout.Icon = "check.png";

			Navigation.PushAsync(new MyCalisthenicsPage(workout));
		}

		async void OnDelete(object sender, EventArgs e)
		{
			var menuitem = (MenuItem)sender;
			var workout = (Workout)menuitem.BindingContext;
			//workouts.Remove(workout);
			await App.WorkoutDB.DeleteWorkoutAsync(workout);
			OnAppearing();
			//BindingContext = await App.WorkoutDB.GetallWorkoutsAsync();

		}

		public void OnTapped(object sender, ItemTappedEventArgs e)
		{
			if (e.Item == null)
			{
				return;
			}

			var workout = (Workout)e.Item;
			Navigation.PushAsync(new MyCalisthenicsPage(workout));
		}

		protected async override void OnAppearing()
		{
			BindingContext =  await App.WorkoutDB.GetallWorkoutsAsync();
		}
	}
	
}
