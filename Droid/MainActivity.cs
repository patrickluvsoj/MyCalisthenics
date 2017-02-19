using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

//Mobile Center Dependency
using Microsoft.Azure.Mobile;

namespace MyCalisthenics.Droid
{
	[Activity(Label = "MyCalisthenics.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			MobileCenter.Configure("3dfc70c9-ba7f-414c-99e3-3af3a7d471e1");

			string dbpath = LocalFilePathHelper.GetLocalFilePath();

			LoadApplication(new App(dbpath));
		}
	}
}
