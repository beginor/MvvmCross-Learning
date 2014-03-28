using System;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.ViewModels;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Touch.Views.Presenters;

namespace MvxTabs.Touch {

    public class Setup : MvxTouchSetup {

        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window) {
        }

        protected override IMvxApplication CreateApp() {
            return new MvxTabs.Core.App();
        }

        /*
        protected override IMvxTouchViewPresenter CreatePresenter() {
            return new StoryboardViewPresenter(ApplicationDelegate, Window);
        }
        */

        protected override IMvxTouchViewsContainer CreateTouchViewsContainer() {
            return new StoryboardViewsContainer();
        }
    }
}

