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
	[Register("ALAlertBannerManager", true)]
	public unsafe partial class ALAlertBannerManager : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ALAlertBannerManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ALAlertBannerManager () : base (NSObjectFlag.Empty)
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
		protected ALAlertBannerManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ALAlertBannerManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("alertBannersInView:")]
		[CompilerGenerated]
		public virtual NSObject[] AlertBannersInView (global::UIKit.UIView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("alertBannersInView:"), view.Handle));
			} else {
				return NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("alertBannersInView:"), view.Handle));
			}
		}
		
		[Export ("forceHideAllAlertBannersInView:")]
		[CompilerGenerated]
		public virtual void ForceHideAllAlertBannersInView (global::UIKit.UIView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("forceHideAllAlertBannersInView:"), view.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("forceHideAllAlertBannersInView:"), view.Handle);
			}
		}
		
		[Export ("hideAlertBannersInView:")]
		[CompilerGenerated]
		public virtual void HideAlertBannersInView (global::UIKit.UIView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("hideAlertBannersInView:"), view.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("hideAlertBannersInView:"), view.Handle);
			}
		}
		
		[Export ("hideAllAlertBanners")]
		[CompilerGenerated]
		public virtual void HideAllAlertBanners ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("hideAllAlertBanners"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hideAllAlertBanners"));
			}
		}
		
		[Export ("sharedManager")]
		[CompilerGenerated]
		public static ALAlertBannerManager SharedManager ()
		{
			return  Runtime.GetNSObject<ALAlertBannerManager> (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedManager")));
		}
		
	} /* class ALAlertBannerManager */
}
