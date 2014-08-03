using System;
#if __IOS__
using MonoTouch.Foundation;
#endif

namespace ruby_lib
{
    public static class Catalog
    {
        public static string GetString (string id)
        {
            #if __ANDROID__
            return "not yet implemented";
            #endif

            #if __IOS__
            return NSBundle.MainBundle.LocalizedString(id, null);
            #endif
        }
    }
}