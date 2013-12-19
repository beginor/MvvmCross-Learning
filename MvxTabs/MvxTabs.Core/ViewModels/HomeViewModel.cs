using System;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore;

namespace MvxTabs.Core.ViewModels {

	public class HomeViewModel : MvxViewModel {

		private FirstFragmentViewModel first;
		private SecondFragmentViewModel second;
		private ThirdFragmentViewModel third;

		public FirstFragmentViewModel First {
			get {
				return first ?? (first = LoadViewModel<FirstFragmentViewModel>());
			}
		}

		public SecondFragmentViewModel Second {
			get {
				return second ?? (second = LoadViewModel<SecondFragmentViewModel>());
			}
		}

		public ThirdFragmentViewModel Third {
			get {
				return third ?? (third = LoadViewModel<ThirdFragmentViewModel>());
			}
		}

		private static T LoadViewModel<T>() {
			var loader = Mvx.Resolve<IMvxViewModelLoader>();
			var request = new MvxViewModelRequest {
				ViewModelType = typeof(T)
			};
			return (T)loader.LoadViewModel(request, null);
		}
	}
}

