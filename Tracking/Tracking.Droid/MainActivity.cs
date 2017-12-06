using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Forms.Droid.Views;

namespace Tracking.Droid
{
    [Activity(
       Label = "MvvmCrossApp1",
       Icon = "@mipmap/ic_launcher",
       Theme = "@style/MyTheme",
       ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MvxFormsAppCompatActivity//<MainViewModel>
    {
    }
}