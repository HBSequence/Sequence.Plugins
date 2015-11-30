package md519faceac1a9328241fcd012c522c23ef;


public class SplashScreen
	extends md586d4272feba75b4cf4f2f8fcfff47386.MvxSplashScreenActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("PluginTestApp.Droid.SplashScreen, PluginTestApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SplashScreen.class, __md_methods);
	}


	public SplashScreen () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SplashScreen.class)
			mono.android.TypeManager.Activate ("PluginTestApp.Droid.SplashScreen, PluginTestApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
