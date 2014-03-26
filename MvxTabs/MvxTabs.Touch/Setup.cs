using System;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.ViewModels;
using MonoTouch.UIKit;

namespace MvxTabs.Touch {

    public class Setup : MvxTouchSetup {

        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window) {
        }

        protected override IMvxApplication CreateApp() {
            return new MvxTabs.Core.App();
        }

        protected override Cirrious.MvvmCross.Touch.Views.Presenters.IMvxTouchViewPresenter CreatePresenter() {
            return new StoryboardViewPresenter(ApplicationDelegate, Window);
        }

        protected override Cirrious.MvvmCross.Touch.Views.IMvxTouchViewsContainer CreateTouchViewsContainer() {
            return new StoryboardViewsContainer();
        }
    }
}

