using System;
using Cirrious.MvvmCross.Droid.Fragging;
using Android.OS;
using Android.App;
using Android.Support.V4.View;
using MvxTabs.Droid.Adapters;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;
using MvxTabs.Core.ViewModels;
using Android.Views;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;

namespace MvxTabs.Droid.Views {

	public class FirstFragmentView : MvxFragment {

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
			base.OnCreateView(inflater, container, savedInstanceState);
			return this.BindingInflate(Resource.Layout.frag_first, null);
		}
	}
	
}
