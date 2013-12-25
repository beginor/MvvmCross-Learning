using System;
using Cirrious.MvvmCross.Droid.Fragging;
using Android.OS;
using Android.App;
using Android.Support.V4.View;
using MvxTabs.Droid.Adapters;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;
using MvxTabs.Core.ViewModels;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;

namespace MvxTabs.Droid.Views {

	public class SecondFragmentView : MvxFragment {

		public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Bundle savedInstanceState) {
			base.OnCreateView(inflater, container, savedInstanceState);
			return this.BindingInflate(Resource.Layout.frag_second, null);
		}
	}
	
}
