using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using FirstMvxApp.ViewModels;

namespace FirstMvxApp.Views {

	public partial class FirstView : MvxViewController {

		public FirstView() : base("FirstView", null) {
		}

		public override void ViewDidLoad() {
			base.ViewDidLoad();
			this.Title = "First Mvx View";
			var bindings = this.CreateBindingSet<FirstView, FirstViewModel>();
			bindings.Bind(FirstNameTextField).TwoWay().To(vm => vm.FirstName);
			bindings.Bind(LastNameTextField).TwoWay().To(vm => vm.LastName);
			bindings.Bind(GetFullNameButton).To("FullNameCommand");
			bindings.Bind(FullNameLabel).To(vm => vm.FullName);
			bindings.Bind(GoToDetailButton).To("GoToDetailCommand");
			bindings.Apply();
		}
	}
}

