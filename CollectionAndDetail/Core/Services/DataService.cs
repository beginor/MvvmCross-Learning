using Cirrious.MvvmCross.Plugins.Sqlite;
using CollectionAndDetail.Core.Models;
using System.Collections.Generic;

namespace CollectionAndDetail.Core.Services {

    public class DataService {

        readonly ISQLiteConnection connection;

        public DataService(ISQLiteConnection connection) {
            this.connection = connection;
        }

        public IList<Category> LoadCategories() {
            return connection.Query<Category>("Select * From Categories");
        }
    }
}

