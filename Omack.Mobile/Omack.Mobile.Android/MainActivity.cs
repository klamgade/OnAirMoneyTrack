using System;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Omack.Data.Shared;

namespace Omack.Mobile.Droid
{
	[Activity (Label = "Omack.Mobile.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var item = SampleData.Current.Items.SingleOrDefault(i => i.Id == 1);
            Button button = FindViewById<Button> (Resource.Id.myButton);            
			button.Click += delegate {
                button.Text = "Hello. I am sameer !!!";
            };
		}
	}
}


