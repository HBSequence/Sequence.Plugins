using Foundation;
using MvvmCross.Platforms.Ios.Core;
using PluginTestApp.Core;

namespace PluginTestApp.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {
    }
}