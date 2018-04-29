using MvvmCross.IoC;
using MvvmCross.ViewModels;
using PluginTestApp.Core.ViewModels;

namespace PluginTestApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }

        /// <summary>
        /// Do any UI bound startup actions here
        /// </summary>
        /// <param name="hint"></param>
        public override void Startup(object hint)
        {
            base.Startup(hint);
        }

        /// <summary>
        /// If the application is restarted (eg primary activity on Android 
        /// can be restarted) this method will be called before Startup
        /// is called again
        /// </summary>
        public override void Reset()
        {
            base.Reset();
        }
    }
}
