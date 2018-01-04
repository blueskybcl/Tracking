using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using StationStopLine.Controls.RichTextEditor;
using StationStopLine.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TestableButton), typeof(ButtonCustomRendererIOS))]
namespace StationStopLine.iOS.Renderers
{
    public class ButtonCustomRendererIOS : ButtonRenderer
    {
        public ButtonCustomRendererIOS()
        {
        }


        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var button = (TestableButton)e.NewElement;
                button.TestClickHandler += (sender, f) =>
                {
                    Control.SendActionForControlEvents(UIKit.UIControlEvent.TouchUpInside);
                };
            }

        }
    }
}