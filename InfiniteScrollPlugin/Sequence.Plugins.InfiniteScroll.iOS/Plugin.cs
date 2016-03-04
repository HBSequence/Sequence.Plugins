using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;

namespace Sequence.Plugins.InfiniteScroll.iOS
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