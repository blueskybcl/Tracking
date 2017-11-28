using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Forms.iOS;
using MvvmCross.Forms.Platform;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform.Converters;
using MvvmCross.Platform.Platform;
using UIKit;

namespace Tracking.iOS
{
    public class Setup : MvxFormsIosSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
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
            return new Core.FormsApp();
        }

        protected override IMvxViewDispatcher CreateViewDispatcher()
        {
            return base.CreateViewDispatcher();
        }

        protected override void FillValueConverters(IMvxValueConverterRegistry registry)
        {
            base.FillValueConverters(registry);
            //TODO: Do your code here
            //registry.AddOrOverwrite("BooleanToVisibility", new BooleanToVisibilityConverter());
        }

        protected override void InitializeIoC()
        {
            base.InitializeIoC();
            //Mvx.RegisterSingleton<ICryptography>(new AndroidCryptography());
        }
    }
}
