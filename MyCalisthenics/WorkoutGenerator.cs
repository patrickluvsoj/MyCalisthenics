using System;

namespace MyCalisthenics
{
	public static class WorkoutGenerator
	{
		public static Workout GetWorkout()
		{
			return new Workout
			{
				Pulluprep = "0",
				Pushuprep = "0",
				Deadliftrep = "0",
				Chinuprep = "0"
			};
		}
	}
}
