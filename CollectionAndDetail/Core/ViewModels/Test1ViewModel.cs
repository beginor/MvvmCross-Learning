using System;
using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;

namespace CollectionAndDetail.Core.ViewModels {

    public class Test1ViewModel : MvxViewModel {

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

        public ICommand ShowTest2 {
            get {
                return new MvxCommand(() => ShowViewModel<Test2ViewModel>());
            }
        }
    }


}

