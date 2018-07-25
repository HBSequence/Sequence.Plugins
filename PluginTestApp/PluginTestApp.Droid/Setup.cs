using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.ViewModels;
using PluginTestApp.Core;

namespace PluginTestApp.Droid
{
    public class Setup : MvxAppCompatSetup<App>
    {
        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}