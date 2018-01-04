using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using StationStopLine.Controls.RichTextEditor;
using UIKit;
using Xamarin.Forms;

namespace StationStopLine.iOS.Renderers
{
    public class RegisterEditorIOS : RegisterEditor
    {
        public RegisterEditorIOS()
        {
            MessagingCenter.Subscribe<HtmlEditor>(this, "register", (editor) =>
            {
                var renderer = new HtmlEditorRendererIOS();
                renderer.SetElement(editor);


            });

            MessagingCenter.Subscribe<TestableButton>(this, "register", (button) =>
            {
                var renderer = new ButtonCustomRendererIOS();
                renderer.SetElement(button);
            });
        }
    }
}