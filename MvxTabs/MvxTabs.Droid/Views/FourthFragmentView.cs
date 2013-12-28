using System;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;

namespace MvxTabs.Droid.Views {

	public class FourthFragmentView : MvxFragment {

		public override void OnCreate(Android.OS.Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);
		}

		public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState) {
			base.OnCreateView(inflater, container, savedInstanceState);
			return this.BindingInflate(Resource.Layout.frag_4, null);
		}
		
	}
}

