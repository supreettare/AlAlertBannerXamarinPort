using System;
using System.Drawing;

using Foundation;
using UIKit;
using ALAlertBannerEnums;

namespace ALAlertBanner.Sample
{
	public partial class ALAlertBanner_SampleViewController : UIViewController
	{

		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public ALAlertBanner_SampleViewController (IntPtr handle) : base (handle)
		{
			
		}
			
		partial void UIButton5_TouchUpInside (UIButton sender)
		{
			var alert = ALAlertBanner.AlertBannerForView(this.View, ALAlertBannerStyle.ALAlertBannerStyleFailure, ALAlertBannerPosition.ALAlertBannerPositionTop, "Greg test");

			alert.AllowTapToDismiss = false;
			alert.SecondsToShow = 4;
			alert.BannerOpacity = 1;

			alert.Show();
		}


	}
}

