using System;
using FirstMvxApp.ViewModels;
using Cirrious.MvvmCross.ViewModels;

namespace FirstMvxApp {

	public class App : MvxApplication {

		public override void Initialize() {
			base.Initialize();
			RegisterAppStart<FirstViewModel>();
		}
	}
}

