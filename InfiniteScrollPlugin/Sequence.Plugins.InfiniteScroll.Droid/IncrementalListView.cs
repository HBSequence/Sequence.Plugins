using Android.Content;
using Android.Util;
using MvvmCross.Binding.Droid.Views;

namespace Sequence.Plugins.InfiniteScroll.Droid
{
    public class IncrementalListView : MvxListView
    {
        public IncrementalListView(Context context, IAttributeSet attrs)
            : base(context, attrs, new IncrementalAdapter(context))
        {
        }
    }
}