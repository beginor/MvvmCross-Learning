using Cirrious.MvvmCross.Touch.Platform;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore.Platform;

namespace FirstMvxApp {

	public class Setup : MvxTouchSetup {

		public Setup(MvxApplicationDelegate appDelegate, UIWindow window) : base(appDelegate, window) {
		}

		protected override IMvxApplication CreateApp() {
			return new App();
		}

		protected override IMvxTrace CreateDebugTrace() {
			return new DebugTrace();
		}

	}

}

