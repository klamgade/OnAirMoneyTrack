﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace Omack.Android
{
    [Activity(Label = "Omack.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.myButton);
            //int count = 0;
            //button.Click += delegate {
            //    button.Text = string.Format("{0} clicks!", count++);
            //};

        }
    }
}
