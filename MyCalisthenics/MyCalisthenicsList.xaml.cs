using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace MyCalisthenics
{
	public partial class MyCalisthenicsList : ContentPage
	{
		//private IList<Workout> workouts { get; set; }

		public MyCalisthenicsList()
		{
			BindingContext = WorkoutGenerator.workoutCollection;
			InitializeComponent();
			//workouts = WorkoutGenerator.workoutCollection;

		}

		//TODO: Wire-up workout detail page from Toolbar
		public void OnNewWorkout(object sender, EventArgs e)
		{
			Navigation.PushAsync(new MyCalisthenicsPage());
		}

		//TODO: Ensure workouts are saved
		//TODO: Ensure that when workouts are changed or deleted in SQL, UI is updated
		//TODO: Add OnDelete method
		//TODO: Add OnTapped method
		//TODO: Add Data time as titile of ListView & an image
	}
	
}
