using System;
namespace MyCalisthenics.Droid
{
	public static class LocalFilePathHelper
	{
		public static string GetLocalFilePath()
		{
			string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string dbpath = System.IO.Path.Combine(folderpath, "workouts.db3");
			return dbpath;
		}
	}
}
