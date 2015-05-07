using System;
using UIKit;

namespace ALAlertBanner.Sample
{
	public class AlAlertBannerLocal: ALAlertBannerViewDelegate
	{
		readonly UIViewController parent;
		public AlAlertBannerLocal (UIViewController parent)
		{
			this.parent = parent;

		}

		#region ALAlertBannerViewDelegate implementation

		public override void HideAfter (ALAlertBanner alertBanner, double delay)
		{
			//alertBanner.Show ();
		}

		public override void Forced (ALAlertBanner alertBanner, bool forced)
		{
			throw new NotImplementedException ();
		}

		public override void AlertBannerWillShow (ALAlertBanner alertBanner, UIView view)
		{
			
		}

		public override void AlertBannerDidShow (ALAlertBanner alertBanner, UIView view)
		{
			throw new NotImplementedException ();
		}

		public override void AlertBannerWillHide (ALAlertBanner alertBanner, UIView view)
		{
			throw new NotImplementedException ();
		}

		public override void AlertBannerDidHide (ALAlertBanner alertBanner, UIView view)
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

