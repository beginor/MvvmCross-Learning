using System;
using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;

namespace FirstMvxApp.ViewModels {

	public class FirstViewModel : MvxViewModel {

		private string firstName;
		private string lastName;
		private string fullName;

		public string FirstName {
			get {
				return firstName;
			}
			set {
				firstName = value;
				RaisePropertyChanged("FirstName");
			}
		}

		public string LastName {
			get {
				return lastName;
			}
			set {
				lastName = value;
				RaisePropertyChanged("LastName");
			}
		}

		public string FullName {
			get {
				return fullName;
			}
			set {
				fullName = value;
				RaisePropertyChanged("FullName");
			}
		}

		public ICommand FullNameCommand {
			get {
				return new MvxCommand(() => FullName = string.Format("{0} {1}", FirstName, LastName));
			}
		}
	}
}

