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
	public unsafe static partial class ALSystemVersion  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::UIKit.UIDevice");
		
		[Export ("iOSVersion")]
		[CompilerGenerated]
		public static float IOSVersion (this global::UIKit.UIDevice This)
		{
			return ApiDefinition.Messaging.float_objc_msgSend (class_ptr, Selector.GetHandle ("iOSVersion"));
		}
		
	} /* class ALSystemVersion */
}
