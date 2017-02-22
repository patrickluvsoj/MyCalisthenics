using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace MyCalisthenics
{
	public partial class MyCalisthenicsList : ContentPage
	{
		public static IList<Workout> workouts {get; set;}

		public MyCalisthenicsList()
		{
			workouts = WorkoutGenerator.workoutCollection;
			BindingContext = workouts;
			InitializeComponent();
		}

		public void OnNewWorkout(object sender, EventArgs e)
		{
			var workout = new Workout();
			workout.Workoutdate = DateTime.Today;
			workout.Icon = "check.png";

			Navigation.PushAsync(new MyCalisthenicsPage(workout));
		}

		//TODO: Add OnDelete method
		public void OnDelete(object sender, EventArgs e)
		{
			var menuitem = (MenuItem)sender;
			var workout = (Workout)menuitem.BindingContext;
			workouts.Remove(workout);

		}

		//TODO: Add OnTapped method
		public void OnTapped(object sender, ItemTappedEventArgs e)
		{
			if (e.Item == null)
			{
				return;
			}

			var workout = (Workout)e.Item;
			Navigation.PushAsync(new MyCalisthenicsPage(workout));
		}

		//public override void OnAppearing()
		//{
		//}

		//TODO: Add support for image in listview
		//TODO: Ensure workouts are saved in SQLdatabase
		//TODO: Ensure that when workouts are changed or deleted in SQL, UI is updated
	}
	
}
