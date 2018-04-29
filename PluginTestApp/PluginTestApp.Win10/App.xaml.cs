using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace PluginTestApp.Win10
{
    public abstract class PlaygroundApp : MvxApplication<MvxWindowsSetup<Core.App>, Core.App>
    {
    }

    /// <summary>
    ///     Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public sealed partial class App
    {
        public App()
        {
            InitializeComponent();
        }
    }
}