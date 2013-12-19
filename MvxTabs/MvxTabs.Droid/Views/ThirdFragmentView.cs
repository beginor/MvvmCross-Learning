using System;
using Cirrious.MvvmCross.Droid.Fragging;
using Android.OS;
using Android.App;
using Android.Support.V4.View;
using MvxTabs.Droid.Adapters;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;
using MvxTabs.Core.ViewModels;

namespace MvxTabs.Droid.Views {

	public class ThirdFragmentView : MvxFragment {

		public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Bundle savedInstanceState) {
			var view = inflater.Inflate(Resource.Layout.frag_third, container, false);
			return view;
		}
	}
	
}
