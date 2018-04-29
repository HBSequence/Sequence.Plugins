using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;

namespace PluginTestApp.Droid.Views
{
    [Activity(Label = "View for MainViewModel")]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
        }
    }
}