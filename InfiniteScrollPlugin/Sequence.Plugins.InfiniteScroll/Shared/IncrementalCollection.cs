using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Sequence.Plugins.InfiniteScroll.Shared
{
    public class IncrementalCollection<T> : ObservableCollection<T>, ICoreSupportIncrementalLoading
    {
        private readonly Func<int, int, Task<IEnumerable<T>>> _sourceDataFunc;
        private int _defaultPageSize;

        public IncrementalCollection(Func<int, int, Task<IEnumerable<T>>> sourceDataFunc, int defaultPageSize)
        {
            _sourceDataFunc = sourceDataFunc;
            _defaultPageSize = defaultPageSize;
        }

        public int DefaultPageSize
        {
            get { return _defaultPageSize; }
            set { _defaultPageSize = value; }
        }

        public async Task LoadMoreItemsAsync()
        {
            var sourceData = await _sourceDataFunc(Count, _defaultPageSize);

            foreach (T dataItem in sourceData)
            {
                Add(dataItem);
            }
        }
    }
}
