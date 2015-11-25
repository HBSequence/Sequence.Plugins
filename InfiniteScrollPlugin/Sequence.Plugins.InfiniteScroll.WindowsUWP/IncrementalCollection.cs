using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Data;

namespace Sequence.Plugins.InfiniteScroll.WindowsUWP
{
    public class IncrementalCollection<T> : ObservableCollection<T>, ISupportIncrementalLoading
    {
        private readonly Func<int, int, Task<ObservableCollection<T>>> _sourceDataFunc;
        private int _defaultPageSize = 10;

        public IncrementalCollection(Func<int, int, Task<ObservableCollection<T>>> sourceDataFunc, int defaultPageSize)
        {
            HasMoreItems = true;
            _sourceDataFunc = sourceDataFunc;
            _defaultPageSize = defaultPageSize;
        }

        public int DefaultPageSize
        {
            get { return _defaultPageSize; }
            set { _defaultPageSize = value; }
        }

        public bool HasMoreItems { get; private set; }

        public IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync(uint count)
        {
            return InnerLoadMoreItemsAsync(count).AsAsyncOperation();
        }

        private async Task<LoadMoreItemsResult> InnerLoadMoreItemsAsync(uint expectedCount)
        {
            ObservableCollection<T> sourceData = await _sourceDataFunc(Count, _defaultPageSize);

            uint resultCount = 0;

            if (sourceData != null)
            {
                resultCount = (uint) sourceData.Count;

                foreach (T dataItem in sourceData)
                {
                    Add(dataItem);
                }
            }

            HasMoreItems = (resultCount > 0);

            return new LoadMoreItemsResult
            {
                Count = resultCount
            };
        }
    }
}