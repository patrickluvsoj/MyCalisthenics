using System;
using SQLite;

namespace MyCalisthenics
{
	public class WorkoutDatabase
	{
		private readonly SQLiteConnection conn;

		//public string StatusMessage { get; set; }

		public WorkoutDatabase(string dbpath)
		{
			conn = new SQLiteConnection(dbpath);
			conn.CreateTable<Workout>();
		}

		//TODO
		////#1 Write a method to add workouts to database
		/// #2 Write a method to get all workout items
		/// #3 Write a method to get specific workout item
		//public void InsertWorkout(string pullup)
		//{
		//	try
		//	{
		//		if(string.IsNullOrEmpty(pullup))
		//		{
		//			throw new Exception("Valid name required");
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		StatusMessage = string.Format("Failed to add {0}. Error: {1}", pullup, ex.Message);
		//	}

		//	conn.Insert(new Workout{Pulluprep=pullup});
		//}

		//Write a method to get all workout records
	}
}
