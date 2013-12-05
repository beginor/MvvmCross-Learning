using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace FirstMvxApp.Views {

	[Activity]			
	public class FirstView : MvxActivity {

		protected override void OnCreate(Bundle bundle) {
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.first_view);
		}
	}
}

