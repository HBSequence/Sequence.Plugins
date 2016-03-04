using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;

namespace Sequence.Plugins.InfiniteScroll.WindowsUWP
{
    public class Plugin
        : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<IIncrementalCollectionFactory>(new IncrementalCollectionFactory());
        }
    }
}