using System;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using Android.Views;
using Android.OS;

namespace MvxTabs.Droid.Views {

	public class FifthFragmentView : MvxFragment {

		public override void OnCreate(Bundle savedInstanceState) {
			SetHasOptionsMenu(true);
			base.OnCreate(savedInstanceState);
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
			base.OnCreateView(inflater, container, savedInstanceState);
			return this.BindingInflate(Resource.Layout.frag_5, null);
		}

		public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater) {
			inflater.Inflate(Resource.Menu.frag_5, menu);
		}

	}
}
