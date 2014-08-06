namespace AzureMobileServicesTest

open System
open MonoTouch.UIKit
open MonoTouch.Foundation

[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit UIApplicationDelegate ()

    let window = new UIWindow (UIScreen.MainScreen.Bounds)

    // This method is invoked when the application is ready to run.
    override this.FinishedLaunching (app, options) =

        // Error FS1108: The type 'Uri' is required here and is unavailable. You must add a reference to assembly 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'. (FS1108)
        let MobileService = new Microsoft.WindowsAzure.MobileServices.MobileServiceClient("", "")

        window.RootViewController <- new AzureMobileServicesTestViewController ()
        window.MakeKeyAndVisible ()
        true

module Main =
    [<EntryPoint>]
    let main args =
        UIApplication.Main (args, null, "AppDelegate")
        0

