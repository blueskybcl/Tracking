using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using MvvmCross.Forms.Views;
using SkiaSharp;
using Tracking.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tracking.Core.Views
{
  public partial class FirstPage : MvxContentPage
  {
	public FirstPage()
	{
	  InitializeComponent();
	}

	private void ChartTypeTab_Tapped(object sender, int e)
	{
	  FirstViewModel viewModel = BindingContext.DataContext as FirstViewModel;
	  if (viewModel == null) return;

	  viewModel.ChangeChartType(e);
	  chartView.InvalidateSurface();
	}
  }
}