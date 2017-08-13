using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace SCD_Mobile.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());
            App.ScreenWidth = (int)UIScreen.MainScreen.Bounds.Width;

            return base.FinishedLaunching(app, options);
        }
    }
}
