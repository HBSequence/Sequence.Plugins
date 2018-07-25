using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Sequence.Plugins.InfiniteScroll.Shared
{
    public class IncrementalCollectionFactory : IIncrementalCollectionFactory
    {
        public ObservableCollection<T> GetCollection<T>(Func<int, int, Task<ObservableCollection<T>>> sourceDataFunc, int defaultPageSize = 10)
        {
            return new IncrementalCollection<T>(sourceDataFunc, defaultPageSize);
        }
    }
}
