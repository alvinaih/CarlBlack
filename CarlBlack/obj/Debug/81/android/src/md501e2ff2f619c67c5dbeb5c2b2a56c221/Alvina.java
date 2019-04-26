package md501e2ff2f619c67c5dbeb5c2b2a56c221;


public class Alvina
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("CarlBlack.Alvina, CarlBlack", Alvina.class, __md_methods);
	}


	public Alvina ()
	{
		super ();
		if (getClass () == Alvina.class)
			mono.android.TypeManager.Activate ("CarlBlack.Alvina, CarlBlack", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
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
