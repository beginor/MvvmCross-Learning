using System;
using Cirrious.MvvmCross.ViewModels;

namespace MvxTabs.Core.ViewModels {

	public class FourthFragmentViewModel : MvxViewModel {

		public HomeViewModel Home {
			get;
			private set;
		}

		public FourthFragmentViewModel(HomeViewModel home) {
			Home = home;
		}

	}
}
