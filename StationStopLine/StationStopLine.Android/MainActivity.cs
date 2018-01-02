using System;
using Acr.UserDialogs;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xam.Plugin.Droid;
using Xamarin.Forms;

namespace StationStopLine.Droid
{
    [Activity(Label = "StationStopLine", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            PopupEffect.Init();
            base.OnCreate(bundle);

            UserDialogs.Init(this);
            Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

