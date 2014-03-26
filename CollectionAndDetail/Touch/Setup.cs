using System;
using Cirrious.MvvmCross.Touch.Platform;
using MonoTouch.UIKit;

namespace CollectionAndDetail.Touch {

    public class Setup : MvxTouchSetup {

        public Setup(MvxApplicationDelegate appDelegate, UIWindow window) : base(appDelegate, window) {
        }

        protected override Cirrious.MvvmCross.ViewModels.IMvxApplication CreateApp() {
            return new CollectionAndDetail.Core.App();
        }

        public override void LoadPlugins(Cirrious.CrossCore.Plugins.IMvxPluginManager pluginManager) {
            pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.Sqlite.PluginLoader>();
            base.LoadPlugins(pluginManager);
        }

        protected override void AddPluginsLoaders(Cirrious.CrossCore.Plugins.MvxLoaderPluginRegistry loaders) {
            loaders.AddConventionalPlugin<Cirrious.MvvmCross.Plugins.Sqlite.Touch.Plugin>();
            base.AddPluginsLoaders(loaders);
        }

    }
}

