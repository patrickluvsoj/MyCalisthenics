using System;
namespace MyCalisthenics.iOS
{
	public static class LocalFilePathHelper
	{
		public static string GetFolderPath()
		{
			string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libfilepath = System.IO.Path.Combine(folderpath, "..", "Library", "Database");
			string dbpath = System.IO.Path.Combine(libfilepath, "workouts.db3");
			return dbpath;
		}
	}
}
