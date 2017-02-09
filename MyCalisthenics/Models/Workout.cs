using System;
using SQLite;

namespace MyCalisthenics
{
	[Table("workout")]
	public class Workout
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public int Pulluprep { get; set; }
		public int Chinuprep { get; set; }
		public int Pushuprep { get; set; }
		public int Deadliftrep { get; set; }
	}
}
