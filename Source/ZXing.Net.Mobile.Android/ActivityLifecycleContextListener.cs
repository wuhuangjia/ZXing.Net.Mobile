using Android.App;
using Android.Content;
using Android.OS;

namespace ZXing.Net.Mobile.Android
{
    public class ActivityLifecycleContextListener : Java.Lang.Object, Application.IActivityLifecycleCallbacks
    {
        public ActivityLifecycleContextListener ()
        {
        }

        Activity currentActivity = null;

        public Context Context { 
            get {
                return currentActivity ?? Application.Context;
            }
        }

        public void OnActivityCreated (Activity activity, Bundle savedInstanceState)
        {            
        }

        public void OnActivityDestroyed (Activity activity)
        {
        }

        public void OnActivityPaused (Activity activity)
        {            
        }

        public void OnActivityResumed (Activity activity)
        {
            currentActivity = activity;
        }

        public void OnActivitySaveInstanceState (Activity activity, Bundle outState)
        {
        }

        public void OnActivityStarted (Activity activity)
        {
        }

        public void OnActivityStopped (Activity activity)
        {
        }
    }
}

