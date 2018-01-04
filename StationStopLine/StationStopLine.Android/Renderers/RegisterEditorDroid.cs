using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using StationStopLine.Controls.RichTextEditor;
using StationStopLine.Droid.Renderers;
using Xamarin.Forms;

[assembly: Dependency(typeof(RegisterEditorDroid))]
namespace StationStopLine.Droid.Renderers
{
    public class RegisterEditorDroid: RegisterEditor
    {
        public RegisterEditorDroid()
        {
            MessagingCenter.Subscribe<HtmlEditor>(this, "register", (editor) =>
            {
                var renderer = new HtmlEditorRendererDroid();
                renderer.SetElement(editor);
            });

            MessagingCenter.Subscribe<TestableButton>(this, "register", (button) =>
            {
                var renderer = new ButtonCustomRendererDroid();
                renderer.SetElement(button);
            });
        }
    }
}