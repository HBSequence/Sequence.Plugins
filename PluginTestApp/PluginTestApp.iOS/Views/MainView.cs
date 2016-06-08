using PluginTestApp.Core.ViewModels;
using Sequence.Plugins.InfiniteScroll.iOS;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;

namespace PluginTestApp.iOS.Views
{
    public partial class MainView : MvxViewController
    {
        public MainView() : base("MainView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            IncrementalTableViewSource source = new IncrementalTableViewSource(TableView1, ItemEntries.Key);
            this.CreateBinding(source).To<MainViewModel>(vm => vm.Numbers).Apply();

            TableView1.RowHeight = 300;
            TableView1.Source = source;
        }
    }
}