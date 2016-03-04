// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//

using Foundation;

namespace PluginTestApp.Touch.Views
{
	[Register ("MainView")]
	partial class MainView
	{		
		[Outlet]
		UIKit.UITableView TableView1 { get; set; }
		
		void ReleaseDesignerOutlets ()
		{	
			if (TableView1 != null) {
				TableView1.Dispose ();
				TableView1 = null;
			}
		}
	}
}
