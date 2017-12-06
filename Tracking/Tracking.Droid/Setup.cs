using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views;
using MvvmCross.Forms.Droid.Platform;
using MvvmCross.Forms.Platform;
using MvvmCross.Platform.Converters;
using MvvmCross.Platform.Platform;

namespace Tracking.Droid
{
    public class Setup : MvxFormsAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override MvxFormsApplication CreateFormsApplication()
        {
            Xamarin.FormsBaiduMaps.Init(null);
            return new Core.FormsApp();
        }
    }
}
