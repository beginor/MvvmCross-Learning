using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;

namespace FirstMvxApp.Views {

	public partial class DetailView : MvxViewController {

		public DetailView() : base("DetailView", null) {
		}

		public override void ViewDidLoad() {
			base.ViewDidLoad();
			Title = "Detail View";
		}
	}
}

