using System;
using Cirrious.MvvmCross.Droid.Platform;
using Android.Content;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore.Platform;

namespace MvxTabs.Droid {

	public class Setup : MvxAndroidSetup {

		public Setup(Context applicationContext) : base(applicationContext) {
		}

		protected override IMvxApplication CreateApp() {
			return new MvxTabs.Core.App();
		}

		protected override IMvxTrace CreateDebugTrace() {
			return new DebugTrace();
		}

	}
}

