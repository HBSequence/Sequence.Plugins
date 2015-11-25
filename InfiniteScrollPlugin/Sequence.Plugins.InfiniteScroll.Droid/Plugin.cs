using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;

namespace Sequence.Plugins.InfiniteScroll.Droid
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