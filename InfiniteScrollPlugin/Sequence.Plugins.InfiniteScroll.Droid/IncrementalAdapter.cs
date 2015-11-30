using System.Collections;
using System.Threading.Tasks;
using Android.Content;
using Android.Views;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Nito.AsyncEx;

namespace Sequence.Plugins.InfiniteScroll.Droid
{
    public class IncrementalAdapter : MvxAdapter
    {
        private int _lastCount;
        private int _maxPositionReached;

        public IncrementalAdapter(Context context)
            : base(context)
        {
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if ((position >= _maxPositionReached) && (position == _lastCount))
            {
                _maxPositionReached = position;
                LoadMoreItems();
            }

            return base.GetView(position, convertView, parent);
        }

        protected override void SetItemsSource(IEnumerable value)
        {
            base.SetItemsSource(value);
            LoadMoreItems();
        }

        private void LoadMoreItems()
        {          
            AsyncContext.Run(() => LoadMoreItemsAsync());
        }

        public async Task LoadMoreItemsAsync()
        {
            ICoreSupportIncrementalLoading source = ItemsSource as ICoreSupportIncrementalLoading;

            if (source != null)
            {
                _lastCount = Count;
                await source.LoadMoreItemsAsync();
            }
        }
    }
}