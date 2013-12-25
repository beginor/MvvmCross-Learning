using System;
using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;
using MvxTabs.Core.Data;
using System.Linq;

namespace MvxTabs.Core.ViewModels {

	public class FirstFragmentViewModel : MvxViewModel {

		public HomeViewModel Home {
			get;
			private set;
		}

		public FirstFragmentViewModel(HomeViewModel home) {
			Home = home;
		}

	}
}

