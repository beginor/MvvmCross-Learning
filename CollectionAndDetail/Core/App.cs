using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Plugins.Sqlite;
using CollectionAndDetail.Core.Services;
using CollectionAndDetail.Core.ViewModels;

namespace CollectionAndDetail.Core {

    public class App : MvxApplication {

        public override void Initialize() {
            base.Initialize();
            RegisterAppStart<CategoryViewModel>();
            InitializeDataService();
        }

        public override void LoadPlugins(Cirrious.CrossCore.Plugins.IMvxPluginManager pluginManager) {
            base.LoadPlugins(pluginManager);
            pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.Sqlite.PluginLoader>();
        }

        void InitializeDataService() {
            var fact = Mvx.Resolve<ISQLiteConnectionFactory>();
            var conn = fact.Create("");
            var dataService = new DataService(conn);
            Mvx.RegisterSingleton(dataService);
        }
    }
}

