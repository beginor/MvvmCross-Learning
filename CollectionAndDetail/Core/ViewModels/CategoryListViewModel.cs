using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;
using CollectionAndDetail.Core.Models;

namespace CollectionAndDetail.Core.ViewModels {

    public class CategoryListViewModel : MvxViewModel {

        IList<Category> categories;

        public IList<Category> Categories {
            get {
                return categories;
            }
            set {
                categories = value;
                RaisePropertyChanged(() => Categories);
            }
        }

        public override void Start() {
            base.Start();
            if (Categories == null) {

            }
        }
    }
}

