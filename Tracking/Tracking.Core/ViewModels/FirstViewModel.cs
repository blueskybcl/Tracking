
using System.Threading.Tasks;
using Microcharts;
using MvvmCross.Core.ViewModels;
using SkiaSharp;

namespace Tracking.Core.ViewModels
{
  public class FirstViewModel : MvxViewModel
  {
	private Entry[] _entries;
	private Chart _chart;

	public override void Prepare()
	{
	  base.Prepare();
	  
	}

	public override Task Initialize()
	{
	  _entries = new Entry[]
		{
		 new Entry(200)
		 {
			 Label = "January",
			 ValueLabel = "200",
			 Color = SKColor.Parse("#266489")
		 },
		 new Entry(400)
		 {
			 Label = "February",
			 ValueLabel = "400",
			 Color = SKColor.Parse("#68B9C0")
		 },
		 new Entry(-100)
		 {
			 Label = "March",
			 ValueLabel = "-100",
			 Color = SKColor.Parse("#90D585")
		 }
		};

	  MyChart = new BarChart { Entries = _entries };
	  return base.Initialize();
	}

	public Chart MyChart
	{
	  get => _chart;
	  set => SetProperty(ref _chart, value);
	}
	
	public void ChangeChartType(int selectedSegment)
	{
	  switch (selectedSegment)
	  {
		case 0:
		  MyChart = new BarChart { Entries = _entries };
		  break;

		case 1:
		  MyChart = new PointChart { Entries = _entries };
		  break;

		case 2:
		  MyChart = new LineChart { Entries = _entries };
		  break;

		case 3:
		  MyChart = new DonutChart { Entries = _entries };
		  break;

		case 4:
		  MyChart = new RadialGaugeChart { Entries = _entries };
		  break;

		case 5:
		  MyChart = new RadarChart { Entries = _entries };
		  break;
	  }
	}
  }
}
