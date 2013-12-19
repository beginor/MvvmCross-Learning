using System;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore;

namespace MvxTabs.Core.ViewModels {

	public class HomeViewModel : MvxViewModel {

		private FirstViewModel first;
		private SecondViewModel second;
		private ThirdViewModel third;

		public FirstViewModel First {
			get {
				return first ?? (first = Mvx.Resolve<FirstViewModel>());
			}
		}

		public SecondViewModel Second {
			get {
				return second ?? (second = Mvx.Resolve<SecondViewModel>());
			}
		}

		public ThirdViewModel Third {
			get {
				return third ?? (third = Mvx.Resolve<ThirdViewModel>());
			}
		}
	}
}

