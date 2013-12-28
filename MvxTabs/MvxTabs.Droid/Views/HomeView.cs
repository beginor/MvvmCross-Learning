using System;
using Cirrious.MvvmCross.Droid.Fragging;
using Android.OS;
using Android.App;
using Android.Support.V4.View;
using MvxTabs.Droid.Adapters;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;
using MvxTabs.Core.ViewModels;
using Android.Widget;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using System.Linq;

namespace MvxTabs.Droid.Views {

	[Activity(Label = "Home", Theme = "@android:style/Theme.Holo.Light.DarkActionBar")]
	public class HomeView : MvxFragmentActivity {

		private ViewPager viewPager;
		private HomeFragmentPagerAdapter adapter;

		private int lastViewPagerIndex;

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
					ViewModel = ViewModel.First
				},
				new HomeFragmentPagerAdapter.FragmentInfo {
					FragmentType = typeof(SecondFragmentView),
					Title = "Tab2",
					ViewModel = ViewModel.Second
				},
				new HomeFragmentPagerAdapter.FragmentInfo {
					FragmentType = typeof(ThirdFragmentView),
					Title = "Tab3",
					ViewModel = ViewModel.Third
				},
				new HomeFragmentPagerAdapter.FragmentInfo {
					FragmentType = typeof(FourthFragmentView),
					Title = "Tab4",
					ViewModel = ViewModel.Fourth
				}
			};

			viewPager = FindViewById<ViewPager>(Resource.Id.view_home_viewpager);
			adapter = new HomeFragmentPagerAdapter(this, SupportFragmentManager, fragments);
			viewPager.Adapter = adapter;

			this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

			Action<object, ActionBar.TabEventArgs> tabSelectedHandler = (sender, e) => {
				var selectedIndex = ActionBar.SelectedNavigationIndex;
				if (selectedIndex != viewPager.CurrentItem) {
					viewPager.SetCurrentItem(selectedIndex, true);
				}
			};
			foreach (var fraginfo in fragments) {
				var tab = ActionBar.NewTab();
				tab.SetText(fraginfo.Title);

				tab.TabSelected += new EventHandler<ActionBar.TabEventArgs>(tabSelectedHandler);
				ActionBar.AddTab(tab);
			}

			viewPager.PageSelected += (sender, e) => {
				var selectedIndex = e.Position;
				if (ActionBar.SelectedNavigationIndex != selectedIndex) {
					ActionBar.SetSelectedNavigationItem(selectedIndex);
				}
				if (this.ShouldRecreateOptionsMenu(viewPager.CurrentItem)) {
					this.InvalidateOptionsMenu();
				}
				lastViewPagerIndex = viewPager.CurrentItem;
			};

			viewPager.SetCurrentItem(lastViewPagerIndex, false);
		}

		bool ShouldRecreateOptionsMenu(int currentViewPagerIndex) {
			return (lastViewPagerIndex != 3 && currentViewPagerIndex == 3)
				 || (lastViewPagerIndex == 3 && currentViewPagerIndex != 3);
		}

		public override bool OnCreateOptionsMenu(Android.Views.IMenu menu) {
			MenuInflater.Inflate(Resource.Menu.view_home, menu);
			var spinnerItem = menu.FindItem(Resource.Id.view_home_action_spinner);
			var spinner = spinnerItem.ActionView as Spinner;
			if (spinner != null) {
				spinner.Adapter = new MvxAdapter(this, (IMvxAndroidBindingContext)BindingContext) {
					ItemsSource = ViewModel.Items,
					ItemTemplateId = Resource.Layout.view_home_option_spinner_item,
					DropDownItemTemplateId = Resource.Layout.view_home_option_spinner_dropdown_item
				};
				spinner.ItemSelected += (sender, e) => {
					var item = ViewModel.Items.ElementAt(e.Position);
					ViewModel.SelectedItem = item;
				};

				var index = ViewModel.Items.IndexOf(ViewModel.SelectedItem);
				spinner.SetSelection(index);

				spinnerItem.SetVisible(viewPager.CurrentItem != 3);
			}
			return true;
		}
	}
}

