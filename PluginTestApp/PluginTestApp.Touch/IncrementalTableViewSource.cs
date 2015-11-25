using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.ExtensionMethods;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Touch.Views;
using Foundation;
using Nito.AsyncEx;
using Sequence.Plugins.InfiniteScroll;
using UIKit;

namespace PluginTestApp.Touch
{
    public class IncrementalTableViewSource : MvxSimpleTableViewSource
    {
        int _lastViewedPosition = 0;

        public IncrementalTableViewSource(UITableView tableView, NSString cellIdentifier) : base(tableView, cellIdentifier)
        {
        }

        public IncrementalTableViewSource(UITableView tableView, string bindingText) : base(tableView, bindingText)
        {
        }

        public IncrementalTableViewSource(IntPtr handle) : base(handle)
        {
        }

        public void CreateBinding<TSource>(MvxViewController controller, Expression<Func<TSource, object>> sourceProperty)
        {
            controller.CreateBinding(this).To<TSource>(sourceProperty).Apply();
            LoadMoreItems();
        }
                  
        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            int position = indexPath.Row;

            if ((position > _lastViewedPosition) && (position == (ItemsSource.Count() - 1)))
            {
                _lastViewedPosition = position;
                LoadMoreItems();
            }

            return base.GetOrCreateCellFor(tableView, indexPath, item);
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
                await source.LoadMoreItemsAsync();
            }
        }
    }
}
