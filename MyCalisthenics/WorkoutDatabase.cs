using System;
using SQLite;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;

namespace MyCalisthenics
{
	public class WorkoutDatabase
	{
		readonly SQLiteAsyncConnection database;

		public WorkoutDatabase(string dbpath)
		{
			database = new SQLiteAsyncConnection(dbpath);
			database.CreateTableAsync<Workout>();
		}

		public async Task<List<Workout>> GetallWorkoutsAsync()
		{
			return await database.Table<Workout>().ToListAsync();
		}

		public async Task<int> SaveWorkoutAsync(Workout workout)
		{
			if(workout.Id != 0)
			{
				return await database.UpdateAsync(workout);
			}
			return await database.InsertAsync(workout);
		}

		public async Task<int> DeleteWorkoutAsync(Workout workout)
		{
			return await database.DeleteAsync(workout);
		}

		//TODO: Make sure image renders in ListviewItems
	}
}
