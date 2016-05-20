using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.ExtensionMethods;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using Foundation;
using Nito.AsyncEx;
using UIKit;
using System.Collections;
using MvvmCross.Binding.Attributes;

namespace Sequence.Plugins.InfiniteScroll.iOS
{
    public class IncrementalTableViewSource : MvxSimpleTableViewSource
    {
        private int _lastViewedPosition = 0;

        public IncrementalTableViewSource(UITableView tableView, NSString cellIdentifier) : base(tableView, cellIdentifier)
        {
        }

        public IncrementalTableViewSource(UITableView tableView, string nibName) : base(tableView, nibName)
        {
        }

        public IncrementalTableViewSource(IntPtr handle) : base(handle)
        {
        }


        [MvxSetToNullAfterBinding]
        public override IEnumerable ItemsSource
        {
            get { return base.ItemsSource; }
            set
            {
                if (base.ItemsSource == value)
                    return;
                base.ItemsSource = value;
                _lastViewedPosition = 0;
                LoadMoreItems();
            }
        }

        /*
        public void CreateBinding<TSource>(MvxViewController controller, Expression<Func<TSource, object>> sourceProperty)
        {
            controller.CreateBinding(this).To(sourceProperty).Apply();
            _lastViewedPosition = 0;
            LoadMoreItems();
        }*/

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            int position = indexPath.Row;

            if ((position > _lastViewedPosition) && (position >= (ItemsSource.Count() - 1)))
            {
                _lastViewedPosition = position;
                LoadMoreItems();
            }

            return base.GetOrCreateCellFor(tableView, indexPath, item);
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