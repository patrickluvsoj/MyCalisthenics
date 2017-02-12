using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCalisthenics
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyCalisthenicsPage : ContentPage
	{
		readonly WorkoutDatabase workoutdb;
		readonly Workout workout;

		public MyCalisthenicsPage(WorkoutDatabase workoutdb)
		{
 			this.workout = WorkoutGenerator.GetWorkout();

			//assign SQLite connect to this object's property
			this.workoutdb = workoutdb;

			//set the Binding context to instance of workout model
			this.BindingContext = workout;

			InitializeComponent();

		}

		void OnDoneClicked(object sender, EventArgs e)
		{
			string pullup = workout.Pulluprep;
			string chinup = workout.Chinuprep;
			string pushup = workout.Pushuprep;
			string deadlift = workout.Deadliftrep;
			string workoutresult = pullup + ", " + chinup + ", " + pushup + ", " + deadlift;

			//call method to insert workout model to SQLite database by way of binding context
			this.DisplayAlert("Finished Workout Result", workoutresult, "OK");
		}
	}
}
