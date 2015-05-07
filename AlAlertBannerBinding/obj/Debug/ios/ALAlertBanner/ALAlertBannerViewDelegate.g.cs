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
	[Protocol (Name = "ALAlertBannerViewDelegate", WrapperType = typeof (ALAlertBannerViewDelegateWrapper))]
	public interface IALAlertBannerViewDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("showAlertBanner:hideAfter:")]
		[Preserve (Conditional = true)]
		void HideAfter (ALAlertBanner alertBanner, global::System.Double delay);
		
		[CompilerGenerated]
		[Export ("hideAlertBanner:forced:")]
		[Preserve (Conditional = true)]
		void Forced (ALAlertBanner alertBanner, bool forced);
		
		[CompilerGenerated]
		[Export ("alertBannerWillShow:inView:")]
		[Preserve (Conditional = true)]
		void AlertBannerWillShow (ALAlertBanner alertBanner, global::UIKit.UIView view);
		
		[CompilerGenerated]
		[Export ("alertBannerDidShow:inView:")]
		[Preserve (Conditional = true)]
		void AlertBannerDidShow (ALAlertBanner alertBanner, global::UIKit.UIView view);
		
		[CompilerGenerated]
		[Export ("alertBannerWillHide:inView:")]
		[Preserve (Conditional = true)]
		void AlertBannerWillHide (ALAlertBanner alertBanner, global::UIKit.UIView view);
		
		[CompilerGenerated]
		[Export ("alertBannerDidHide:inView:")]
		[Preserve (Conditional = true)]
		void AlertBannerDidHide (ALAlertBanner alertBanner, global::UIKit.UIView view);
		
	}
	
	internal sealed class ALAlertBannerViewDelegateWrapper : BaseWrapper, IALAlertBannerViewDelegate {
		public ALAlertBannerViewDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public ALAlertBannerViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("showAlertBanner:hideAfter:")]
		[CompilerGenerated]
		public void HideAfter (ALAlertBanner alertBanner, global::System.Double delay)
		{
			if (alertBanner == null)
				throw new ArgumentNullException ("alertBanner");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double (this.Handle, Selector.GetHandle ("showAlertBanner:hideAfter:"), alertBanner.Handle, delay);
		}
		
		[Export ("hideAlertBanner:forced:")]
		[CompilerGenerated]
		public void Forced (ALAlertBanner alertBanner, bool forced)
		{
			if (alertBanner == null)
				throw new ArgumentNullException ("alertBanner");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("hideAlertBanner:forced:"), alertBanner.Handle, forced);
		}
		
		[Export ("alertBannerWillShow:inView:")]
		[CompilerGenerated]
		public void AlertBannerWillShow (ALAlertBanner alertBanner, global::UIKit.UIView view)
		{
			if (alertBanner == null)
				throw new ArgumentNullException ("alertBanner");
			if (view == null)
				throw new ArgumentNullException ("view");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("alertBannerWillShow:inView:"), alertBanner.Handle, view.Handle);
		}
		
		[Export ("alertBannerDidShow:inView:")]
		[CompilerGenerated]
		public void AlertBannerDidShow (ALAlertBanner alertBanner, global::UIKit.UIView view)
		{
			if (alertBanner == null)
				throw new ArgumentNullException ("alertBanner");
			if (view == null)
				throw new ArgumentNullException ("view");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("alertBannerDidShow:inView:"), alertBanner.Handle, view.Handle);
		}
		
		[Export ("alertBannerWillHide:inView:")]
		[CompilerGenerated]
		public void AlertBannerWillHide (ALAlertBanner alertBanner, global::UIKit.UIView view)
		{
			if (alertBanner == null)
				throw new ArgumentNullException ("alertBanner");
			if (view == null)
				throw new ArgumentNullException ("view");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("alertBannerWillHide:inView:"), alertBanner.Handle, view.Handle);
		}
		
		[Export ("alertBannerDidHide:inView:")]
		[CompilerGenerated]
		public void AlertBannerDidHide (ALAlertBanner alertBanner, global::UIKit.UIView view)
		{
			if (alertBanner == null)
				throw new ArgumentNullException ("alertBanner");
			if (view == null)
				throw new ArgumentNullException ("view");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("alertBannerDidHide:inView:"), alertBanner.Handle, view.Handle);
		}
		
	}
}
namespace ALAlertBanner {
	[Protocol]
	[Register("ALAlertBannerViewDelegate", true)]
	[Model]
	public unsafe abstract partial class ALAlertBannerViewDelegate : NSObject, IALAlertBannerViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ALAlertBannerViewDelegate () : base (NSObjectFlag.Empty)
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
		protected ALAlertBannerViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ALAlertBannerViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("alertBannerDidHide:inView:")]
		[CompilerGenerated]
		public abstract void AlertBannerDidHide (ALAlertBanner alertBanner, global::UIKit.UIView view);
		[Export ("alertBannerDidShow:inView:")]
		[CompilerGenerated]
		public abstract void AlertBannerDidShow (ALAlertBanner alertBanner, global::UIKit.UIView view);
		[Export ("alertBannerWillHide:inView:")]
		[CompilerGenerated]
		public abstract void AlertBannerWillHide (ALAlertBanner alertBanner, global::UIKit.UIView view);
		[Export ("alertBannerWillShow:inView:")]
		[CompilerGenerated]
		public abstract void AlertBannerWillShow (ALAlertBanner alertBanner, global::UIKit.UIView view);
		[Export ("hideAlertBanner:forced:")]
		[CompilerGenerated]
		public abstract void Forced (ALAlertBanner alertBanner, bool forced);
		[Export ("showAlertBanner:hideAfter:")]
		[CompilerGenerated]
		public abstract void HideAfter (ALAlertBanner alertBanner, global::System.Double delay);
	} /* class ALAlertBannerViewDelegate */
}
