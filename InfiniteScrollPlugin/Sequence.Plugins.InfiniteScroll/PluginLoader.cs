using MvvmCross;
using MvvmCross.Plugin;
using Sequence.Plugins.InfiniteScroll.Shared;

namespace Sequence.Plugins.InfiniteScroll
{
    [MvxPlugin]
    public class PluginLoader : IMvxPlugin
    {
        public static readonly PluginLoader Instance = new PluginLoader();


        public void Load()
        {
            Mvx.RegisterSingleton<IIncrementalCollectionFactory>(new IncrementalCollectionFactory());
        }
    }
}
