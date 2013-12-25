using System;
using Cirrious.MvvmCross.ViewModels;

namespace MvxTabs.Core.ViewModels {

	public class ThirdFragmentViewModel : MvxViewModel {

		public HomeViewModel Home {
			get;
			private set;
		}

		public ThirdFragmentViewModel(HomeViewModel home) {
			Home = home;
		}

	}
}

