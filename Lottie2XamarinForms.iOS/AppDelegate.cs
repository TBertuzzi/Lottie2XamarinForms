using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Lottie2XamarinForms.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override UIWindow Window { get; set; }


        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            if (Window == null)
            {
                Window = new UIWindow(frame: UIScreen.MainScreen.Bounds);
                var initialViewController = new SplashViewController();
                Window.RootViewController = initialViewController;
                Window.MakeKeyAndVisible();

                return true;
            }
            else
            {
                global::Xamarin.Forms.Forms.Init();
                LoadApplication(new App());

                return base.FinishedLaunching(app, options);
            }
        }
    }
}
