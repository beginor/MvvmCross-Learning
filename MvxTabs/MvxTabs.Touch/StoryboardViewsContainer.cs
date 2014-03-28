using System;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.ViewModels;

namespace MvxTabs.Touch {

    public class StoryboardViewsContainer : MvxTouchViewsContainer {

        protected override IMvxTouchView CreateViewOfType(Type viewType, MvxViewModelRequest request) {
            var typeName = viewType.Name;
            var appDelegate = UIApplication.SharedApplication.Delegate as AppDelegate;
            if (appDelegate != null) {
                var view = appDelegate.Storyboard.InstantiateViewController(typeName);
                return (MvxViewController)view;
            }

            return base.CreateViewOfType(viewType, request);
        }
    }
}

