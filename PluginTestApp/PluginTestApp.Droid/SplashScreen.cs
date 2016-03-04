using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace PluginTestApp.Droid
{
    [Activity(
        Label = "PluginTestApp.Droid"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}