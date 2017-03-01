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
		public MyCalisthenicsPage(Workout workout)
		{
			BindingContext = workout;
			InitializeComponent();
		}

		async void OnDoneClicked(object sender, EventArgs e)
		{
			var result = (Workout)BindingContext;

			await App.WorkoutDB.SaveWorkoutAsync(result);
			await Navigation.PopAsync();
		}
	}
}
