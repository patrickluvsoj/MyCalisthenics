using System;
using System.IO;

namespace MyCalisthenics.iOS
{
	public static class LocalFilePathHelper
	{
		public static string GetFolderPath()
		{
			string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libfilepath = Path.Combine(folderpath, "..", "Library", "Database");

			if (!Directory.Exists(libfilepath))
			{
				Directory.CreateDirectory(libfilepath);
			}

			return Path.Combine(libfilepath, "workouts.db3");

		}
	}
}
