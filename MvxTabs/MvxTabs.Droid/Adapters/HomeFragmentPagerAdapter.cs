using System;
using System.Collections.Generic;
using System.Linq;
using Android.Content;
using Android.Support.V4.App;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore;

namespace MvxTabs.Droid.Adapters {

	public class HomeFragmentPagerAdapter : FragmentPagerAdapter {

		private readonly Context context;

		public IEnumerable<FragmentInfo> Fragments {
			get;
			private set;
		}

		public HomeFragmentPagerAdapter(Context context, FragmentManager fm, IEnumerable<FragmentInfo> fragments) : base(fm) {
			this.context = context;
			Fragments = fragments;
		}

		public override int Count {
			get {
				return Fragments.Count();
			}
		}

		public override Fragment GetItem(int position) {
			var fragInfo = Fragments.ElementAt(position);
			var fragment = Fragment.Instantiate(context, FragmentJavaName(fragInfo.FragmentType));
			((MvxFragment)fragment).ViewModel = LoadViewModel(fragInfo.ViewModelType);
			return fragment;
		}

		private static IMvxViewModel LoadViewModel(Type viewModelType) {
			var loader = Mvx.Resolve<IMvxViewModelLoader>();
			var request = new MvxViewModelRequest {
				ViewModelType = viewModelType
			};
			return loader.LoadViewModel(request, null);
		}

		string FragmentJavaName(Type fragmentType) {
			var namespaceText = fragmentType.Namespace ?? string.Empty;
			if (namespaceText.Length > 0) {
				namespaceText = namespaceText.ToLowerInvariant() + ".";
			}
			return namespaceText + fragmentType.Name;
		}

		public override Java.Lang.ICharSequence GetPageTitleFormatted(int position) {
			return new Java.Lang.String(Fragments.ElementAt(position).Title);
		}

		public class FragmentInfo {

			public string Title { get; set; }

			public Type FragmentType { get; set; }

			public Type ViewModelType { get; set; }

		}
	}
}

