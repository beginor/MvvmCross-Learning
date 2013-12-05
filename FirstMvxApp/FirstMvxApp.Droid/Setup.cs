using Cirrious.MvvmCross.Droid.Platform;
using Android.Content;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore.Platform;

namespace FirstMvxApp {

	public class Setup : MvxAndroidSetup {

		public Setup(Context applicationContext) : base(applicationContext) {
		}

		protected override IMvxApplication CreateApp() {
			return new App();
		}

		protected override IMvxTrace CreateDebugTrace() {
			return new DebugTrace();
		}

	}
}

