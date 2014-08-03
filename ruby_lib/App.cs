using System;
using Xamarin.Forms;

namespace ruby_lib
{
    public class App
    {
        public static Page GetMainPage ()
        {	
            // need navigation page to use Navigation.PushAsync
            return new NavigationPage(new TableViewMenuDemoPage ());
        }
    }
}