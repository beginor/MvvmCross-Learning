using System;
using Cirrious.MvvmCross.Droid.Fragging;
using Android.OS;
using Android.App;
using Android.Support.V4.View;
using MvxTabs.Droid.Adapters;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;
using MvxTabs.Core.ViewModels;

namespace MvxTabs.Droid.Views {

	[Activity(Label = "Home")]
	public class HomeView : MvxFragmentActivity {

		private ViewPager viewPager;
		private HomeFragmentPagerAdapter adapter;

		public new HomeViewModel ViewModel {
			get { return (HomeViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		protected override void OnCreate(Bundle bundle) {
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.view_home);

			var fragments = new [] {
				new HomeFragmentPagerAdapter.FragmentInfo {
					FragmentType = typeof(FirstFragment),
					Title = "Tab1",
					ViewModel = ViewModel.First
				},
				new HomeFragmentPagerAdapter.FragmentInfo {
					FragmentType = typeof(SecondFragment),
					Title = "Tab2",
					ViewModel = ViewModel.Second
				},
				new HomeFragmentPagerAdapter.FragmentInfo {
					FragmentType = typeof(ThirdFragment),
					Title = "Tab3",
					ViewModel = ViewModel.Third
				}
			};

			viewPager = FindViewById<ViewPager>(Resource.Id.view_home_viewpager);
			adapter = new HomeFragmentPagerAdapter(this, SupportFragmentManager, fragments);
			viewPager.Adapter = adapter;
		}

		public class FirstFragment : MvxFragment {

			public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Bundle savedInstanceState) {
				var view = inflater.Inflate(Resource.Layout.frag_first, container, false);
				return view;
			}
		}

		public class SecondFragment : MvxFragment {

			public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Bundle savedInstanceState) {
				var view = inflater.Inflate(Resource.Layout.frag_second, container, false);
				return view;
			}
		}

		public class ThirdFragment : MvxFragment {

			public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Bundle savedInstanceState) {
				var view = inflater.Inflate(Resource.Layout.frag_third, container, false);
				return view;
			}
		}
	}
}

