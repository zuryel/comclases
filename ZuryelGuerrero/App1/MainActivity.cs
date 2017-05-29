using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App1
{
    [Activity(Label = "ZuryelGuerrero", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button button;
        TextView textViewDev;

    
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            Button button = FindViewById<Button>(Resource.Id.MyButton);
            textViewDev = FindViewById<TextView>(Resource.Id.textViewDev);
            button.Click += Button_Click;
        

           
        }

        private async void Button_Click(object sender, EventArgs e)
        {
            textViewDev.Text = "Zuryel Guerrero Zapata";

           
               button.Text = "Gracias por el click";
        }
    }
}

