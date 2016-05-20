using System.Collections;
using System.Threading.Tasks;
using Android.Content;
using Android.Views;
using MvvmCross.Binding.Droid.Views;
using Nito.AsyncEx;
using MvvmCross.Binding.ExtensionMethods;

namespace Sequence.Plugins.InfiniteScroll.Droid
{
    public class IncrementalAdapter : MvxAdapter
    {
        private int _lastViewedPosition = 0;

        public IncrementalAdapter(Context context)
            : base(context)
        {
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if ((position > _lastViewedPosition) && (position >= (ItemsSource.Count() - 1)))
            {
                _lastViewedPosition = position;
                LoadMoreItems();
            }

            return base.GetView(position, convertView, parent);
        }

        protected override void SetItemsSource(IEnumerable value)
        {
            base.SetItemsSource(value);
            _lastViewedPosition = 0;
            LoadMoreItems();
        }

        private void LoadMoreItems()
        {
            INotifyTaskCompletion taskCompletion = NotifyTaskCompletion.Create(LoadMoreItemsAsync());
        }

        public async Task LoadMoreItemsAsync()
        {
            ICoreSupportIncrementalLoading source = ItemsSource as ICoreSupportIncrementalLoading;

            if (source != null)
            {
                await source.LoadMoreItemsAsync();
            }
        }
    }
}