// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Demo
{
	[Register ("TreeTableViewCell")]
	partial class TreeTableViewCell
	{
		[Outlet]
		UIKit.UIButton AdditionalButton { get; set; }

		[Outlet]
		UIKit.UILabel CustomTitleLabel { get; set; }

		[Outlet]
		UIKit.UILabel DetailsLabel { get; set; }

		[Action ("AdditionButtonTapped:")]
		partial void AdditionButtonTapped (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (AdditionalButton != null) {
				AdditionalButton.Dispose ();
				AdditionalButton = null;
			}

			if (CustomTitleLabel != null) {
				CustomTitleLabel.Dispose ();
				CustomTitleLabel = null;
			}

			if (DetailsLabel != null) {
				DetailsLabel.Dispose ();
				DetailsLabel = null;
			}
		}
	}
}
