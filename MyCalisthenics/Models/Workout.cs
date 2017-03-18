using System;
using SQLite;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyCalisthenics
{
	[Table("workout")]
	public class Workout : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Icon { get; set; }
		public DateTime Workoutdate { get; set; }

		string pulluprep;
		public string Pulluprep { 
			get
			{
				return pulluprep;
				
			}
			set
			{
				if(pulluprep != value)
				{
					pulluprep = value;
					RaisePropertyChanged();
				}
			} 
		}

		public string Chinuprep { get; set; }
		public string Pushuprep { get; set; }
		public string Deadliftrep { get; set; }

		void RaisePropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
