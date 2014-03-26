using System;
using Cirrious.MvvmCross.ViewModels;

namespace CollectionAndDetail.Core.ViewModels {

    public class Test2ViewModel : MvxViewModel {

        string helloWorld = "Hello, MvvmCross!";

        public string HelloWorld {
            get {
                return helloWorld;
            }
            set {
                helloWorld = value;
                RaisePropertyChanged("HelloWorld");
            }
        }

    }

}
