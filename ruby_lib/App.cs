using System;
using Xamarin.Forms;

namespace ruby_lib
{
    public class App
    {
        public static Page GetMainPage ()
        {	
            return new TableViewMenuDemoPage ();
        }
    }
}