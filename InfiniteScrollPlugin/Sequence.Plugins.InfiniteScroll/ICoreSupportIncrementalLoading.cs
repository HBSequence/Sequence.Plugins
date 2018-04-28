using System.Threading.Tasks;

namespace Sequence.Plugins.InfiniteScroll
{
    public interface ICoreSupportIncrementalLoading
    {
        Task LoadMoreItemsAsync();
    }
}
