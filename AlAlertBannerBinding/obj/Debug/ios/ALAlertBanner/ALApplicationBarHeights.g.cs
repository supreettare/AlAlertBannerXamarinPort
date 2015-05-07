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
	public unsafe static partial class ALApplicationBarHeights  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::UIKit.UIApplication");
		
		[Export ("navigationBarHeight")]
		[CompilerGenerated]
		public static global::System.nfloat NavigationBarHeight (this global::UIKit.UIApplication This)
		{
			return ApiDefinition.Messaging.nfloat_objc_msgSend (class_ptr, Selector.GetHandle ("navigationBarHeight"));
		}
		
		[Export ("statusBarHeight")]
		[CompilerGenerated]
		public static global::System.nfloat StatusBarHeight (this global::UIKit.UIApplication This)
		{
			return ApiDefinition.Messaging.nfloat_objc_msgSend (class_ptr, Selector.GetHandle ("statusBarHeight"));
		}
		
	} /* class ALApplicationBarHeights */
}
