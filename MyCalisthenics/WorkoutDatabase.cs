using System;
using SQLite;
namespace MyCalisthenics
{
	public class WorkoutDatabase
	{
		public WorkoutDatabase(string dbpath)
		{
			var conn = new SQLiteConnection(dbpath);
			conn.CreateTable<Workout>();

			//TODO
			//Write a method to add workouts to database
			//Write a method to get all workout records
		}
	}
}
