using System;
using ObjCRuntime;

[assembly: LinkWith ("libALAlertBannerSDK.a", LinkTarget.Simulator | LinkTarget.ArmV7, Frameworks="QuartzCore", SmartLink = true, ForceLoad = true)]
