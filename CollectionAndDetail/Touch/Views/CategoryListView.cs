using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;

namespace CollectionAndDetail.Touch.Views {

    public partial class CategoryListView : MvxViewController {

        bool initialized;

        public CategoryListView() : base("CategoryListView", null) {
            initialized = true;
        }

        public CategoryListView(IntPtr handle) : base(handle) {
            //initialized = true;
        }

        public override void DidReceiveMemoryWarning() {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
            
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad() {
            if (!initialized) {
                return;
            }
            base.ViewDidLoad();
            
            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}

