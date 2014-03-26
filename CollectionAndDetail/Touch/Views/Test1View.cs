using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Binding.BindingContext;
using CollectionAndDetail.Core.ViewModels;

namespace CollectionAndDetail.Touch.Views {

    public partial class Test1View : MvxViewController {

        public Test1View() : base("Test1View", null) {
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();
            var bs = this.CreateBindingSet<Test1View, Test1ViewModel>();

            bs.Bind(Label).To(m => m.HelloWorld);
            bs.Bind(Button).To("ShowTest2");

            bs.Apply();
            Mvx.Trace("Test1View Loaded!");
        }
    }
}

