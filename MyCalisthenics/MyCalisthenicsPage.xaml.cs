using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System.Collections;

namespace MyCalisthenics
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyCalisthenicsPage : ContentPage
	{
		//readonly WorkoutDatabase workoutdb;
		//eadonly ObservableCollection<Workout> workout;

		public MyCalisthenicsPage(Workout workout)
		{
			//this.workout = WorkoutGenerator.GetWorkout();

			//assign SQLite connect to this object's property
			//this.workoutdb = workoutdb;

			//set the Binding context to instance of workout model
			BindingContext = workout;

			InitializeComponent();

		}

		void OnDoneClicked(object sender, EventArgs e)
		{
			//	string pullup = workout.Pulluprep;
			//	string chinup = workout.Chinuprep;
			//	string pushup = workout.Pushuprep;
			//	string deadlift = workout.Deadliftrep;
			//	string workoutresult = pullup + ", " + chinup + ", " + pushup + ", " + deadlift;

			//call method to insert workout model to SQLite database by way of binding context
			var result = (Workout)BindingContext;
			//this.DisplayAlert("Finished Workout Result", result.Pulluprep, "OK");

			if(result.Id == 0)
			{
				MyCalisthenicsList.workouts.Remove(result);
			}

			MyCalisthenicsList.workouts.Add(result);
			Navigation.PopAsync();
		}
	}
}
