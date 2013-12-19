using System;
using Cirrious.MvvmCross.ViewModels;
using MvxTabs.Core.ViewModels;
using Cirrious.CrossCore;

namespace MvxTabs.Core {

	public class App : MvxApplication{

		public override void Initialize() {
			base.Initialize();
			RegisterAppStart<HomeViewModel>();
		}
	}
}

