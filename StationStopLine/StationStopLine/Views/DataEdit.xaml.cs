using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StationStopLine.Views
{
	public partial class DataEdit : PopupPage
    {
		public DataEdit ()
		{
			InitializeComponent ();
		}
        
        protected override Task OnAppearingAnimationEnd()
        {
            return Content.FadeTo(0.5);
        }
        
        protected override Task OnDisappearingAnimationBegin()
        {
            return Content.FadeTo(1);
        }

        private void EditDataCanvas_OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
	    {
	      
	    }

	    private void EditDataCanvas_OnTouch(object sender, SKTouchEventArgs e)
	    {
	       
	    }

	    private void ButtonSave_OnClicked(object sender, EventArgs e)
	    {
	        
	    }

	    private void ButtonCancel_OnClicked(object sender, EventArgs e)
	    {
	        PopupNavigation.PopAsync();
        }

	    private void RightTriangle_OnClicked(object sender, EventArgs e)
	    {
	        
	    }

	    private void SuperscriptAndSubscript_OnClicked(object sender, EventArgs e)
	    {
	        
	    }
	}
}