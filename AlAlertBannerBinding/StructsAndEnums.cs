using System;

namespace ALAlertBannerEnums {

	public enum ALAlertBannerStyle : uint {
		ALAlertBannerStyleSuccess = 0,
		ALAlertBannerStyleFailure,
		ALAlertBannerStyleNotify,
		ALAlertBannerStyleWarning
	}

	public enum ALAlertBannerPosition : uint {
		ALAlertBannerPositionTop = 0,
		ALAlertBannerPositionBottom,
		ALAlertBannerPositionUnderNavBar
	}

	public enum ALAlertBannerState : uint {
		ALAlertBannerStateShowing = 0,
		ALAlertBannerStateHiding,
		ALAlertBannerStateMovingForward,
		ALAlertBannerStateMovingBackward,
		ALAlertBannerStateVisible,
		ALAlertBannerStateHidden
	}
}

