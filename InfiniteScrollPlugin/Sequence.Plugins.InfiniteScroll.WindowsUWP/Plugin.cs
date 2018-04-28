using MvvmCross;
using MvvmCross.Plugin;

namespace Sequence.Plugins.InfiniteScroll.WindowsUWP
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<IIncrementalCollectionFactory>(new IncrementalCollectionFactory());
        }
    }
}