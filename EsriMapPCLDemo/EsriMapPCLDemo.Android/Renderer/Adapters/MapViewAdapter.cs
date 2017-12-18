using System;
using Esri.ArcGISRuntime.UI.Controls;
using CusMapView = EsriMapPCLDemo.Controls.MapView;
using EsriMapView = Esri.ArcGISRuntime.Xamarin.Forms.MapView;

namespace EsriMapPCLDemo.Droid.Renderer.Adapters
{
    public sealed class MapViewAdapter
    {
        private MapViewAdapter()
        {
        }

        public static readonly MapViewAdapter Instance = new MapViewAdapter();

        public EsriMapView Adapter(CusMapView cusMapView)
        {
            EsriMapView XFMapView = new EsriMapView();
            //TODO: Attach custom property
            return XFMapView;
        }
    }
}