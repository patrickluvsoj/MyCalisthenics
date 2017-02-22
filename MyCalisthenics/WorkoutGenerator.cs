using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyCalisthenics
{
	public static class WorkoutGenerator
	{
		public static IList<Workout> workoutCollection { get; set;}

		static WorkoutGenerator()
		{
			workoutCollection = new ObservableCollection<Workout>
			{
				new Workout
				{
					Id = 0,
					Icon = "check.png",
					Workoutdate = DateTime.Today,
					Pulluprep = "I did it 6 times",
					Pushuprep = "0",
					Deadliftrep = "0",
					Chinuprep = "0",
				},

				new Workout
				{
					Id = 1,
					Icon = "check.png",
					Workoutdate = DateTime.Today,
					Pulluprep = "I did it 8 times",
					Pushuprep = "1",
					Deadliftrep = "1",
					Chinuprep = "1",
				},

				new Workout
				{
					Id = 2,
					Icon = "check.png",
					Workoutdate = DateTime.Today,
					Pulluprep = " I did it 10 times!",
					Pushuprep = "2",
					Deadliftrep = "2",
					Chinuprep = "2",
				}
			};
		}
	}
}