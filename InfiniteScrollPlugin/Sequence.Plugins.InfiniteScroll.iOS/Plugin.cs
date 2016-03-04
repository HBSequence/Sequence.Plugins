using MvvmCross.Platform.Plugins;
using MvvmCross.Platform;

namespace Sequence.Plugins.InfiniteScroll.Touch
{
    public class Plugin
        : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<IIncrementalCollectionFactory>(new Shared.IncrementalCollectionFactory());
        }
    }
}