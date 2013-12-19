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
					FragmentType = typeof(FirstFragmentView),
					Title = "Tab1",
					ViewModelType = typeof(FirstFragmentViewModel)
				},
				new HomeFragmentPagerAdapter.FragmentInfo {
					FragmentType = typeof(SecondFragmentView),
					Title = "Tab2",
					ViewModelType = typeof(SecondFragmentViewModel)
				},
				new HomeFragmentPagerAdapter.FragmentInfo {
					FragmentType = typeof(ThirdFragmentView),
					Title = "Tab3",
					ViewModelType = typeof(ThirdFragmentViewModel)
				}
			};

			viewPager = FindViewById<ViewPager>(Resource.Id.view_home_viewpager);
			adapter = new HomeFragmentPagerAdapter(this, SupportFragmentManager, fragments);
			viewPager.Adapter = adapter;
		}

	}



	
}

