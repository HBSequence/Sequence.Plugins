using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Sequence.Plugins.InfiniteScroll
{
    public interface IIncrementalCollectionFactory
    {
        ObservableCollection<T> GetCollection<T>(Func<int, int, Task<ObservableCollection<T>>> sourceDataFunc,
            int defaultPageSize = 10);
    }
}
