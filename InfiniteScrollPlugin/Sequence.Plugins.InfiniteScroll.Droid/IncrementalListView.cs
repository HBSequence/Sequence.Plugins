using System;
using Android.Content;
using Android.Runtime;
using Android.Util;
using MvvmCross.Binding.Droid.Views;

namespace Sequence.Plugins.InfiniteScroll.Droid
{
    public class IncrementalListView : MvxListView
    {
        protected IncrementalListView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
            // Added to support rehydration cases, when the app has been tombstoned.
        }

        public IncrementalListView(Context context, IAttributeSet attrs)
            : base(context, attrs, new IncrementalAdapter(context))
        {
        }
    }
}