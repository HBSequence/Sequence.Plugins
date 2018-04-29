using System;

using Android.App;
using Android.Runtime;
using MvvmCross.Droid.Support.V7.AppCompat;
using PluginTestApp.Core;

namespace PluginTestApp.Droid
{
    [Application]
    public class MainApplication : MvxAppCompatApplication<Setup, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}