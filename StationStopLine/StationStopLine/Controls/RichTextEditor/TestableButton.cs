using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StationStopLine.Controls.RichTextEditor
{
    public class TestableButton : Button
    {
        public event EventHandler TestClickHandler;

        public TestableButton()
        {
            MessagingCenter.Send(this, "register");
        }

        public void TestClick()
        {
            TestClickHandler(this, EventArgs.Empty);
        }
    }
}
