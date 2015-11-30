package md565c7f5e2dbb7857350ed5ba668a79a77;


public class MvxSimpleBindingActivity
	extends md586d4272feba75b4cf4f2f8fcfff47386.MvxActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Cirrious.MvvmCross.Droid.Simple.MvxSimpleBindingActivity, Cirrious.MvvmCross.Droid, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null", MvxSimpleBindingActivity.class, __md_methods);
	}


	public MvxSimpleBindingActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MvxSimpleBindingActivity.class)
			mono.android.TypeManager.Activate ("Cirrious.MvvmCross.Droid.Simple.MvxSimpleBindingActivity, Cirrious.MvvmCross.Droid, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
