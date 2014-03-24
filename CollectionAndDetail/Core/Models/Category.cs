using Cirrious.MvvmCross.Plugins.Sqlite;

namespace CollectionAndDetail.Core.Models {

    [Table("Categories")]
    public class Category {
       
        [Column("categoryId")]
        public long CategoryId {
            get;
            set;
        }

        [Column("CategoryName")]
        public string CategoryName {
            get;
            set;
        }

        [Column("Description")]
        public string Description {
            get;
            set;
        }
    }
}

