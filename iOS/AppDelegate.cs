using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

//Mobile Center Dependecy
using Microsoft.Azure.Mobile;

namespace MyCalisthenics.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			// Code for starting up the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
#endif
			MobileCenter.Configure("17af7add-3d83-4fb4-8c90-c0dfc7c8e1f4");

			string dbpath = LocalFilePathHelper.GetFolderPath();

			LoadApplication(new App(dbpath));

			return base.FinishedLaunching(app, options);
		}
	}
}
