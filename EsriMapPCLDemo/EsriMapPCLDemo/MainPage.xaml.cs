using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsriMapPCLDemo.Controls;
using Xamarin.Forms;

namespace EsriMapPCLDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MapView.Map = new Map
            {
                BaseMapName = "Streets",
                MapType = MapType.Imagery
            };
        }
    }
}
