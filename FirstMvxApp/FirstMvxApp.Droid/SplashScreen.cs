using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace FirstMvxApp {

	[Activity(Label = "FirstMvxApp", MainLauncher = true, NoHistory = true)]
	public class SplashScreen : MvxSplashScreenActivity {

		public SplashScreen() : base(Resource.Layout.splash_screen) {
		}
	}
}


