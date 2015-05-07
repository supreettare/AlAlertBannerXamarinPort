//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using MapKit;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using NewsstandKit;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;

namespace ALAlertBanner {
	[Register("ALAlertBanner", true)]
	public unsafe partial class ALAlertBanner : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ALAlertBanner");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ALAlertBanner () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public ALAlertBanner (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ALAlertBanner (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ALAlertBanner (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("alertBannerForView:style:position:title:")]
		[CompilerGenerated]
		public static ALAlertBanner AlertBannerForView (global::UIKit.UIView view, global::ALAlertBannerEnums.ALAlertBannerStyle style, global::ALAlertBannerEnums.ALAlertBannerPosition position, string title)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (title == null)
				throw new ArgumentNullException ("title");
			var nstitle = NSString.CreateNative (title);
			
			ALAlertBanner ret;
			ret =  Runtime.GetNSObject<ALAlertBanner> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_UInt32_IntPtr (class_ptr, Selector.GetHandle ("alertBannerForView:style:position:title:"), view.Handle, (UInt32)style, (UInt32)position, nstitle));
			NSString.ReleaseNative (nstitle);
			
			return ret;
		}
		
		[Export ("alertBannerForView:style:position:title:subtitle:")]
		[CompilerGenerated]
		public static ALAlertBanner AlertBannerForView (global::UIKit.UIView view, global::ALAlertBannerEnums.ALAlertBannerStyle style, global::ALAlertBannerEnums.ALAlertBannerPosition position, string title, string subtitle)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (title == null)
				throw new ArgumentNullException ("title");
			if (subtitle == null)
				throw new ArgumentNullException ("subtitle");
			var nstitle = NSString.CreateNative (title);
			var nssubtitle = NSString.CreateNative (subtitle);
			
			ALAlertBanner ret;
			ret =  Runtime.GetNSObject<ALAlertBanner> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_UInt32_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("alertBannerForView:style:position:title:subtitle:"), view.Handle, (UInt32)style, (UInt32)position, nstitle, nssubtitle));
			NSString.ReleaseNative (nstitle);
			NSString.ReleaseNative (nssubtitle);
			
			return ret;
		}
		
		[Export ("alertBannerForView:style:position:title:subtitle:tappedBlock:")]
		[CompilerGenerated]
		public unsafe static ALAlertBanner AlertBannerForView (global::UIKit.UIView view, global::ALAlertBannerEnums.ALAlertBannerStyle style, global::ALAlertBannerEnums.ALAlertBannerPosition position, string title, string subtitle, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<ALAlertBanner> tappedBlock)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (title == null)
				throw new ArgumentNullException ("title");
			if (subtitle == null)
				throw new ArgumentNullException ("subtitle");
			if (tappedBlock == null)
				throw new ArgumentNullException ("tappedBlock");
			var nstitle = NSString.CreateNative (title);
			var nssubtitle = NSString.CreateNative (subtitle);
			BlockLiteral *block_ptr_tappedBlock;
			BlockLiteral block_tappedBlock;
			block_tappedBlock = new BlockLiteral ();
			block_ptr_tappedBlock = &block_tappedBlock;
			block_tappedBlock.SetupBlock (Trampolines.SDActionArity1V0.Handler, tappedBlock);
			
			ALAlertBanner ret;
			ret =  Runtime.GetNSObject<ALAlertBanner> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_UInt32_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("alertBannerForView:style:position:title:subtitle:tappedBlock:"), view.Handle, (UInt32)style, (UInt32)position, nstitle, nssubtitle, (IntPtr) block_ptr_tappedBlock));
			NSString.ReleaseNative (nstitle);
			NSString.ReleaseNative (nssubtitle);
			block_ptr_tappedBlock->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("alertBannersInView:")]
		[CompilerGenerated]
		public static NSObject[] AlertBannersInView (global::UIKit.UIView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			return NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("alertBannersInView:"), view.Handle));
		}
		
		[Export ("forceHideAllAlertBannersInView:")]
		[CompilerGenerated]
		public static void ForceHideAllAlertBannersInView (global::UIKit.UIView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("forceHideAllAlertBannersInView:"), view.Handle);
		}
		
		[Export ("hide")]
		[CompilerGenerated]
		public virtual void Hide ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("hide"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hide"));
			}
		}
		
		[Export ("hideAlertBanner")]
		[CompilerGenerated]
		public virtual void HideAlertBanner ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("hideAlertBanner"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hideAlertBanner"));
			}
		}
		
		[Export ("hideAlertBannersInView:")]
		[CompilerGenerated]
		public static void HideAlertBannersInView (global::UIKit.UIView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("hideAlertBannersInView:"), view.Handle);
		}
		
		[Export ("hideAllAlertBanners")]
		[CompilerGenerated]
		public static void HideAllAlertBanners ()
		{
			ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("hideAllAlertBanners"));
		}
		
		[Export ("nextAvailableViewController:")]
		[CompilerGenerated]
		public virtual NSObject NextAvailableViewController (NSObject view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				return Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("nextAvailableViewController:"), view.Handle));
			} else {
				return Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("nextAvailableViewController:"), view.Handle));
			}
		}
		
		[Export ("pushAlertBanner:forward:delay:")]
		[CompilerGenerated]
		public virtual void PushAlertBanner (global::System.nfloat distance, bool forward, global::System.Double delay)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_nfloat_bool_Double (this.Handle, Selector.GetHandle ("pushAlertBanner:forward:delay:"), distance, forward, delay);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat_bool_Double (this.SuperHandle, Selector.GetHandle ("pushAlertBanner:forward:delay:"), distance, forward, delay);
			}
		}
		
		[Export ("show")]
		[CompilerGenerated]
		public virtual void Show ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("show"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("show"));
			}
		}
		
		[Export ("updatePositionAfterRotationWithY:animated:")]
		[CompilerGenerated]
		public virtual void UpdatePositionAfterRotationWithY (global::System.nfloat yPos, bool animated)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_nfloat_bool (this.Handle, Selector.GetHandle ("updatePositionAfterRotationWithY:animated:"), yPos, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat_bool (this.SuperHandle, Selector.GetHandle ("updatePositionAfterRotationWithY:animated:"), yPos, animated);
			}
		}
		
		[Export ("updateSizeAndSubviewsAnimated:")]
		[CompilerGenerated]
		public virtual void UpdateSizeAndSubviewsAnimated (bool animated)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("updateSizeAndSubviewsAnimated:"), animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("updateSizeAndSubviewsAnimated:"), animated);
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowTapToDismiss {
			[Export ("allowTapToDismiss")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowTapToDismiss"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowTapToDismiss"));
				}
			}
			
			[Export ("setAllowTapToDismiss:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowTapToDismiss:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAllowTapToDismiss:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat BannerOpacity {
			[Export ("bannerOpacity")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("bannerOpacity"));
				} else {
					return ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bannerOpacity"));
				}
			}
			
			[Export ("setBannerOpacity:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setBannerOpacity:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setBannerOpacity:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public ALAlertBannerViewDelegate Delegate {
			get {
				return WeakDelegate as /**/ALAlertBannerViewDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double FadeInDuration {
			[Export ("fadeInDuration")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("fadeInDuration"));
				} else {
					return ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fadeInDuration"));
				}
			}
			
			[Export ("setFadeInDuration:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setFadeInDuration:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setFadeInDuration:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double HideAnimationDuration {
			[Export ("hideAnimationDuration")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("hideAnimationDuration"));
				} else {
					return ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hideAnimationDuration"));
				}
			}
			
			[Export ("setHideAnimationDuration:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setHideAnimationDuration:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setHideAnimationDuration:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsScheduledToHide {
			[Export ("isScheduledToHide")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isScheduledToHide"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isScheduledToHide"));
				}
			}
			
			[Export ("setIsScheduledToHide:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsScheduledToHide:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsScheduledToHide:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::ALAlertBannerEnums.ALAlertBannerPosition Position {
			[Export ("position")]
			get {
				if (IsDirectBinding) {
					return (global::ALAlertBannerEnums.ALAlertBannerPosition) ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("position"));
				} else {
					return (global::ALAlertBannerEnums.ALAlertBannerPosition) ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("position"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Double SecondsToShow {
			[Export ("secondsToShow")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("secondsToShow"));
				} else {
					return ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secondsToShow"));
				}
			}
			
			[Export ("setSecondsToShow:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setSecondsToShow:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setSecondsToShow:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldForceHide {
			[Export ("shouldForceHide")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldForceHide"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldForceHide"));
				}
			}
			
			[Export ("setShouldForceHide:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldForceHide:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldForceHide:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double ShowAnimationDuration {
			[Export ("showAnimationDuration")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("showAnimationDuration"));
				} else {
					return ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showAnimationDuration"));
				}
			}
			
			[Export ("setShowAnimationDuration:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setShowAnimationDuration:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setShowAnimationDuration:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowShadow {
			[Export ("showShadow")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showShadow"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showShadow"));
				}
			}
			
			[Export ("setShowShadow:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowShadow:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowShadow:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::ALAlertBannerEnums.ALAlertBannerState State {
			[Export ("state")]
			get {
				if (IsDirectBinding) {
					return (global::ALAlertBannerEnums.ALAlertBannerState) ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
				} else {
					return (global::ALAlertBannerEnums.ALAlertBannerState) ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("state"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::ALAlertBannerEnums.ALAlertBannerStyle Style {
			[Export ("style")]
			get {
				if (IsDirectBinding) {
					return (global::ALAlertBannerEnums.ALAlertBannerStyle) ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("style"));
				} else {
					return (global::ALAlertBannerEnums.ALAlertBannerStyle) ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("style"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public unsafe virtual global::System.Action<ALAlertBanner> TappedBlock {
			[Export ("tappedBlock", ArgumentSemantic.Copy)]
			get {
				BlockLiteral *ret;
				if (IsDirectBinding) {
					ret = (BlockLiteral *)ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tappedBlock"));
				} else {
					ret = (BlockLiteral *)ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tappedBlock"));
				}
				if (ret == null)
					return null;
				return (global::System.Action<ALAlertBanner>) (ret->Target);
			}
			
			[Export ("setTappedBlock:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDActionArity1V0.Handler, value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTappedBlock:"), (IntPtr) block_ptr_value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTappedBlock:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class ALAlertBanner */
}
