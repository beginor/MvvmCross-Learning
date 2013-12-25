using System;
using Cirrious.MvvmCross.ViewModels;

namespace MvxTabs.Core.ViewModels {


	public class SecondFragmentViewModel : MvxViewModel {

		public HomeViewModel Home {
			get;
			private set;
		}

		public SecondFragmentViewModel(HomeViewModel home) {
			Home = home;
		}
	}
}

