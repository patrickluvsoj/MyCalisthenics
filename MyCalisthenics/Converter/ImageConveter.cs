using System;
using System.Globalization;
using Xamarin.Forms;
namespace MyCalisthenics
{
	public class ImageConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string imagestring = (string)value;
			return ImageSource.FromResource("MyCalisthenics.Images." + imagestring);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
