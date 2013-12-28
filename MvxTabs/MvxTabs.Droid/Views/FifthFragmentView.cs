using System;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using Android.Views;
using Android.OS;

namespace MvxTabs.Droid.Views {

	public class FifthFragmentView : MvxFragment {

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
			base.OnCreateView(inflater, container, savedInstanceState);
			return this.BindingInflate(Resource.Layout.frag_5, null);
		}

	}
}
