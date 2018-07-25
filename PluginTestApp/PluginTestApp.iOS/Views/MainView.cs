using PluginTestApp.Core.ViewModels;
using Sequence.Plugins.InfiniteScroll.iOS;
using MvvmCross.Platforms.Ios.Views;

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
            source.CreateBinding<MainViewModel>(this, vm => vm.Numbers);

            TableView1.RowHeight = 300;
            TableView1.Source = source;
        }
    }
}