using System;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore;
using System.Collections.Generic;
using MvxTabs.Core.Data;
using System.Linq;

namespace MvxTabs.Core.ViewModels {

	public class HomeViewModel : MvxViewModel {

		private FirstFragmentViewModel first;
		private SecondFragmentViewModel second;
		private ThirdFragmentViewModel third;
		private FourthFragmentViewModel fourth;

		public FirstFragmentViewModel First {
			get {
				return first ?? (first = Mvx.IocConstruct<FirstFragmentViewModel>());
			}
		}

		public SecondFragmentViewModel Second {
			get {
				return second ?? (second = Mvx.IocConstruct<SecondFragmentViewModel>());
			}
		}

		public ThirdFragmentViewModel Third {
			get {
				return third ?? (third = Mvx.IocConstruct<ThirdFragmentViewModel>());
			}
		}

		public FourthFragmentViewModel Fourth {
			get {
				return fourth ?? (fourth = Mvx.IocConstruct<FourthFragmentViewModel>());
			}
		}

		IList<Item> items;
		Item selectedItem;

		public Item SelectedItem {
			get {
				return selectedItem;
			}
			set {
				if (value != selectedItem) {
					selectedItem = value;
					RaisePropertyChanged(() => SelectedItem);
				}
			}
		}

		public IList<Item> Items {
			get {
				return items;
			}
			set {
				items = value;
				RaisePropertyChanged(() => Items);
			}
		}

		public HomeViewModel() {
			this.items = new List<Item> {
				new Item { ItemId = 1, ItemName = "OS2" },
				new Item { ItemId = 2, ItemName = "NO2" },
				new Item { ItemId = 3, ItemName = "O3_1" },
				new Item { ItemId = 4, ItemName = "O3_8" },
				new Item { ItemId = 5, ItemName = "PM10" },
				new Item { ItemId = 6, ItemName = "PM25" },
				new Item { ItemId = 7, ItemName = "AQI" },
				new Item { ItemId = 8, ItemName = "CO" }
			};
			this.selectedItem = items.ElementAt(5);
			Mvx.RegisterSingleton(this);
		}
	}
}

