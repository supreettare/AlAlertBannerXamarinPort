using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using ALAlertBannerEnums;

namespace ALAlertBanner {

	// @interface ALAlertBanner : UIView
	[BaseType (typeof (UIView))]
	public partial interface ALAlertBanner {

		// @property (readonly, nonatomic) ALAlertBannerStyle style;
		[Export ("style")]
		ALAlertBannerStyle Style { get; }

		// @property (readonly, nonatomic) ALAlertBannerPosition position;
		[Export ("position")]
		ALAlertBannerPosition Position { get; }

		// @property (readonly, nonatomic) ALAlertBannerState state;
		[Export ("state")]
		ALAlertBannerState State { get; }

		// @property (nonatomic) NSTimeInterval secondsToShow;
		[Export ("secondsToShow")]
		double SecondsToShow { get; set; }

		// @property (nonatomic) BOOL allowTapToDismiss;
		[Export ("allowTapToDismiss")]
		bool AllowTapToDismiss { get; set; }

		// @property (nonatomic) NSTimeInterval showAnimationDuration;
		[Export ("showAnimationDuration")]
		double ShowAnimationDuration { get; set; }

		// @property (nonatomic) NSTimeInterval hideAnimationDuration;
		[Export ("hideAnimationDuration")]
		double HideAnimationDuration { get; set; }

		// @property (nonatomic) CGFloat bannerOpacity;
		[Export ("bannerOpacity")]
		nfloat BannerOpacity { get; set; }

		// @property (nonatomic, weak) id<ALAlertBannerViewDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<ALAlertBannerViewDelegate> delegate;
		[Wrap ("WeakDelegate")]
		ALAlertBannerViewDelegate Delegate { get; set; }

		// @property (nonatomic) BOOL isScheduledToHide;
		[Export ("isScheduledToHide")]
		bool IsScheduledToHide { get; set; }

		// @property (copy, nonatomic) void (^)(ALAlertBanner *) tappedBlock;
		[Export ("tappedBlock", ArgumentSemantic.Copy)]
		Action<ALAlertBanner> TappedBlock { get; set; }

		// @property (nonatomic) NSTimeInterval fadeInDuration;
		[Export ("fadeInDuration")]
		double FadeInDuration { get; set; }

		// @property (nonatomic) BOOL showShadow;
		[Export ("showShadow")]
		bool ShowShadow { get; set; }

		// @property (nonatomic) BOOL shouldForceHide;
		[Export ("shouldForceHide")]
		bool ShouldForceHide { get; set; }

		// +(ALAlertBanner *)alertBannerForView:(UIView *)view style:(ALAlertBannerStyle)style position:(ALAlertBannerPosition)position title:(NSString *)title;
		[Static, Export ("alertBannerForView:style:position:title:")]
		ALAlertBanner AlertBannerForView (UIView view, ALAlertBannerStyle style, ALAlertBannerPosition position, string title);

		// +(ALAlertBanner *)alertBannerForView:(UIView *)view style:(ALAlertBannerStyle)style position:(ALAlertBannerPosition)position title:(NSString *)title subtitle:(NSString *)subtitle;
		[Static, Export ("alertBannerForView:style:position:title:subtitle:")]
		ALAlertBanner AlertBannerForView (UIView view, ALAlertBannerStyle style, ALAlertBannerPosition position, string title, string subtitle);

		// +(ALAlertBanner *)alertBannerForView:(UIView *)view style:(ALAlertBannerStyle)style position:(ALAlertBannerPosition)position title:(NSString *)title subtitle:(NSString *)subtitle tappedBlock:(void (^)(ALAlertBanner *))tappedBlock;
		[Static, Export ("alertBannerForView:style:position:title:subtitle:tappedBlock:")]
		ALAlertBanner AlertBannerForView (UIView view, ALAlertBannerStyle style, ALAlertBannerPosition position, string title, string subtitle, Action<ALAlertBanner> tappedBlock);

		// -(void)show;
		[Export ("show")]
		void Show ();

		// -(void)hide;
		[Export ("hide")]
		void Hide ();

		// +(NSArray *)alertBannersInView:(UIView *)view;
		[Static, Export ("alertBannersInView:")]
		NSObject [] AlertBannersInView (UIView view);

		// +(void)hideAllAlertBanners;
		[Static, Export ("hideAllAlertBanners")]
		void HideAllAlertBanners ();

		// +(void)hideAlertBannersInView:(UIView *)view;
		[Static, Export ("hideAlertBannersInView:")]
		void HideAlertBannersInView (UIView view);

		// +(void)forceHideAllAlertBannersInView:(UIView *)view;
		[Static, Export ("forceHideAllAlertBannersInView:")]
		void ForceHideAllAlertBannersInView (UIView view);
	}

	// @interface ALSystemVersion (UIDevice)
	[Category]
	[BaseType (typeof (UIDevice))]
	public partial interface ALSystemVersion {

		// +(float)iOSVersion;
		[Static, Export ("iOSVersion")]
		float IOSVersion ();
	}

	// @interface ALApplicationBarHeights (UIApplication)
	[Category]
	[BaseType (typeof (UIApplication))]
	public partial interface ALApplicationBarHeights {

		// +(CGFloat)navigationBarHeight;
		[Static, Export ("navigationBarHeight")]
		nfloat NavigationBarHeight ();

		// +(CGFloat)statusBarHeight;
		[Static, Export ("statusBarHeight")]
		nfloat StatusBarHeight ();
	}

	// @protocol ALAlertBannerViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	public partial interface ALAlertBannerViewDelegate {

		// @required -(void)showAlertBanner:(ALAlertBanner *)alertBanner hideAfter:(NSTimeInterval)delay;
		[Export ("showAlertBanner:hideAfter:")]
		[Abstract]
		void HideAfter (ALAlertBanner alertBanner, double delay);

		// @required -(void)hideAlertBanner:(ALAlertBanner *)alertBanner forced:(BOOL)forced;
		[Export ("hideAlertBanner:forced:")]
		[Abstract]
		void Forced (ALAlertBanner alertBanner, bool forced);

		// @required -(void)alertBannerWillShow:(ALAlertBanner *)alertBanner inView:(UIView *)view;
		[Export ("alertBannerWillShow:inView:")]
		[Abstract]
		void AlertBannerWillShow (ALAlertBanner alertBanner, UIView view);

		// @required -(void)alertBannerDidShow:(ALAlertBanner *)alertBanner inView:(UIView *)view;
		[Export ("alertBannerDidShow:inView:")]
		[Abstract]
		void AlertBannerDidShow (ALAlertBanner alertBanner, UIView view);

		// @required -(void)alertBannerWillHide:(ALAlertBanner *)alertBanner inView:(UIView *)view;
		[Export ("alertBannerWillHide:inView:")]
		[Abstract]
		void AlertBannerWillHide (ALAlertBanner alertBanner, UIView view);

		// @required -(void)alertBannerDidHide:(ALAlertBanner *)alertBanner inView:(UIView *)view;
		[Export ("alertBannerDidHide:inView:")]
		[Abstract]
		void AlertBannerDidHide (ALAlertBanner alertBanner, UIView view);
	}

	// @interface  (ALAlertBanner)
//	[Category]
//	[BaseType (typeof (ALAlertBanner))]
	public partial interface ALAlertBanner {

		// @property (nonatomic, weak) id<ALAlertBannerViewDelegate> delegate;
//		[Export ("delegate", ArgumentSemantic.Weak)]
//		[NullAllowed]
//		NSObject WeakDelegate { get; set; }
	
//		// @property (nonatomic, weak) id<ALAlertBannerViewDelegate> delegate;
//		[Wrap ("WeakDelegate")]
//		ALAlertBannerViewDelegate Delegate { get; set; }

//		// @property (nonatomic) BOOL isScheduledToHide;
//		[Export ("isScheduledToHide")]
//		bool IsScheduledToHide { get; set; }

		// @property (copy, nonatomic) void (^)(ALAlertBanner *) tappedBlock;
//		[Export ("tappedBlock", ArgumentSemantic.Copy)]
//		Action<ALAlertBanner> TappedBlock { get; set; }

		// @property (nonatomic) NSTimeInterval fadeInDuration;
//		[Export ("fadeInDuration")]
//		double FadeInDuration { get; set; }

		// @property (nonatomic) BOOL showShadow;
//		[Export ("showShadow")]
//		bool ShowShadow { get; set; }

		// @property (nonatomic) BOOL shouldForceHide;
//		[Export ("shouldForceHide")]
//		bool ShouldForceHide { get; set; }

		// -(void)showAlertBanner;
//		[Export ("showAlertBanner")]
//		void ShowAlertBanner ();

		// -(void)hideAlertBanner;
		[Export ("hideAlertBanner")]
		void HideAlertBanner ();

		// -(void)pushAlertBanner:(CGFloat)distance forward:(BOOL)forward delay:(double)delay;
		[Export ("pushAlertBanner:forward:delay:")]
		void PushAlertBanner (nfloat distance, bool forward, double delay);

		// -(void)updateSizeAndSubviewsAnimated:(BOOL)animated;
		[Export ("updateSizeAndSubviewsAnimated:")]
		void UpdateSizeAndSubviewsAnimated (bool animated);

		// -(void)updatePositionAfterRotationWithY:(CGFloat)yPos animated:(BOOL)animated;
		[Export ("updatePositionAfterRotationWithY:animated:")]
		void UpdatePositionAfterRotationWithY (nfloat yPos, bool animated);

		// -(id)nextAvailableViewController:(id)view;
		[Export ("nextAvailableViewController:")]
		NSObject NextAvailableViewController (NSObject view);
	}

	// @interface ALAlertBannerManager : NSObject
	[BaseType (typeof (NSObject))]
	public partial interface ALAlertBannerManager {

		// +(ALAlertBannerManager *)sharedManager;
		[Static, Export ("sharedManager")]
		ALAlertBannerManager SharedManager ();

		// -(NSArray *)alertBannersInView:(UIView *)view;
		[Export ("alertBannersInView:")]
		NSObject [] AlertBannersInView (UIView view);

		// -(void)hideAllAlertBanners;
		[Export ("hideAllAlertBanners")]
		void HideAllAlertBanners ();

		// -(void)hideAlertBannersInView:(UIView *)view;
		[Export ("hideAlertBannersInView:")]
		void HideAlertBannersInView (UIView view);

		// -(void)forceHideAllAlertBannersInView:(UIView *)view;
		[Export ("forceHideAllAlertBannersInView:")]
		void ForceHideAllAlertBannersInView (UIView view);
	}
}


