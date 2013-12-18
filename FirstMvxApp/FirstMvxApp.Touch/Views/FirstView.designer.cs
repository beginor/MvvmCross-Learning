// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace FirstMvxApp.Views
{
	[Register ("FirstView")]
	partial class FirstView
	{
		[Outlet]
		MonoTouch.UIKit.UITextField FirstNameTextField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel FullNameLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton GetFullNameButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton GoToDetailButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField LastNameTextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FirstNameTextField != null) {
				FirstNameTextField.Dispose ();
				FirstNameTextField = null;
			}

			if (FullNameLabel != null) {
				FullNameLabel.Dispose ();
				FullNameLabel = null;
			}

			if (GetFullNameButton != null) {
				GetFullNameButton.Dispose ();
				GetFullNameButton = null;
			}

			if (LastNameTextField != null) {
				LastNameTextField.Dispose ();
				LastNameTextField = null;
			}

			if (GoToDetailButton != null) {
				GoToDetailButton.Dispose ();
				GoToDetailButton = null;
			}
		}
	}
}
