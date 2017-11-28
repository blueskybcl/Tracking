using MvvmCross.Forms.Views;
using Tracking.Core.ViewModels;

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