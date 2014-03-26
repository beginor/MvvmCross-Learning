using System;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using MonoTouch.UIKit;

namespace MvxTabs.Touch {

    public class StoryboardViewPresenter : MvxTouchViewPresenter {

        public StoryboardViewPresenter(UIApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window) {
        }

        protected override UINavigationController CreateNavigationController(UIViewController viewController) {
            var appDel = ApplicationDelegate as AppDelegate;
            var navigationController = appDel.Storyboard.InstantiateInitialViewController() as UINavigationController;
            if (navigationController != null) {
                navigationController.PushViewController(viewController, false);
                return navigationController;
            }
            return base.CreateNavigationController(viewController);
        }
    }
}

