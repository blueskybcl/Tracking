

using System.ComponentModel;
using Esri.ArcGISRuntime.UI.Controls;
using EsriMapPCLDemo.Droid.Renderer;
using EsriMapPCLDemo.Droid.Renderer.Adapters;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using CusMapView = EsriMapPCLDemo.Controls.MapView;
using EsriMapView = Esri.ArcGISRuntime.Xamarin.Forms.MapView;

[assembly:ExportRenderer(typeof(CusMapView),typeof(MapViewRenderer))]

namespace EsriMapPCLDemo.Droid.Renderer
{
    public class MapViewRenderer : ViewRenderer<CusMapView, MapView>
    {
        private EsriMapView OriginMapView;

        protected override void OnElementChanged(ElementChangedEventArgs<CusMapView> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null)
            {

            }

            CusMapView currentElement = e.NewElement;
            if (currentElement != null)
            {
                OriginMapView = MapViewAdapter.Instance.Adapter(currentElement);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

        }
    }
}