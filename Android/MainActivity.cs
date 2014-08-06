using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using System.Reflection;

namespace ruby_lib.Android
{
    [Activity (Label = "ruby_lib.Android.Android", MainLauncher = true)]
    public class MainActivity : AndroidActivity
    {
        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            Map<String,Integer> stringIds = new Map<String, Integer>();
            FieldInfo[] fields = Resource.String.GetType().GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
            foreach (FieldInfo field in fields) {
                if (!field.IsInitOnly && field.IsLiteral) {
                    stringIdsMap.add (field, field.GetValue(null));
                }
            }


            Context.Resources.GetString (Resource.String.hello);

            Xamarin.Forms.Forms.Init (this, bundle);

            SetPage (App.GetMainPage ());
        }
    }
}

