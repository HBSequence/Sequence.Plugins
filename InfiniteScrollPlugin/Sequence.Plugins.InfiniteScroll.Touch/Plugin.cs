using System;
using System.Collections.Generic;
using System.Text;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;

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
