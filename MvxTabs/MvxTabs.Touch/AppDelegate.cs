using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;

namespace MvxTabs.Touch {

    [Register("AppDelegate")]
    public partial class AppDelegate : MvxApplicationDelegate {

        public override UIWindow Window { get; set; }

        public UIStoryboard Storyboard { get; set; }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions) {
            Window = new UIWindow(UIScreen.MainScreen.Bounds);

            Storyboard = UIStoryboard.FromName("MainStoryboard", null);

            var setup = new Setup(this, Window);
            setup.Initialize();
            var startup = Mvx.Resolve<IMvxAppStart>();
            startup.Start();

            Window.MakeKeyAndVisible();
            return true;
        }
    }
}

