using System;
using Cirrious.MvvmCross.ViewModels;

namespace CollectionAndDetail.Core {

    public class App : MvxApplication {

        public App() {
        }

        public override void Initialize() {
            base.Initialize();
            RegisterAppStart<CategoryViewModel>();
        }

        public override void LoadPlugins(Cirrious.CrossCore.Plugins.IMvxPluginManager pluginManager) {
            base.LoadPlugins(pluginManager);
            pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.Sqlite.PluginLoader>();
        }
    }
}

