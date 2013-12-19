using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace MvxTabs.Droid {

	[Activity(Label = "MvxTabs", MainLauncher = true, NoHistory = true)]
	public class SplashScreen : MvxSplashScreenActivity {

		public SplashScreen() : base(Resource.Layout.splash_screen) {
		}

	}
}


