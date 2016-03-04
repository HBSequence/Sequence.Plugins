// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//

using Foundation;

namespace PluginTestApp.Touch.Views
{
	[Register ("ItemEntries")]
	partial class ItemEntries
	{
		[Outlet]
		UIKit.UIImageView ImageMain { get; set; }

		[Outlet]
		UIKit.UILabel LabelEntryNo { get; set; }

		[Outlet]
		UIKit.UILabel LabelTitle { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ImageMain != null) {
				ImageMain.Dispose ();
				ImageMain = null;
			}

			if (LabelTitle != null) {
				LabelTitle.Dispose ();
				LabelTitle = null;
			}

			if (LabelEntryNo != null) {
				LabelEntryNo.Dispose ();
				LabelEntryNo = null;
			}
		}
	}
}
