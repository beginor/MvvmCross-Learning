// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace CollectionAndDetail.Touch.Views
{
	[Register ("Test2View")]
	partial class Test2View
	{
		[Outlet]
		MonoTouch.UIKit.UILabel Label { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Label != null) {
				Label.Dispose ();
				Label = null;
			}
		}
	}
}
