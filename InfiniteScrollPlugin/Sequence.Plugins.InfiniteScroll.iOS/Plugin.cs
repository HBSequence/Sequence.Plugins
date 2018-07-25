using MvvmCross;
using MvvmCross.Plugin;

namespace Sequence.Plugins.InfiniteScroll.iOS
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<IIncrementalCollectionFactory>(new Shared.IncrementalCollectionFactory());
        }
    }
}