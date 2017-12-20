using System.ComponentModel;
using Esri.ArcGISRuntime.UI.Controls;
using EsriMapPCLDemo.iOS.Renderer;
using EsriMapPCLDemo.iOS.Renderer.Adapters;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using CusMapView = EsriMapPCLDemo.Controls.MapView;

[assembly: ExportRenderer(typeof(CusMapView), typeof(MapViewRenderer))]
namespace EsriMapPCLDemo.iOS.Renderer
{
    public class MapViewRenderer : ViewRenderer<CusMapView, MapView>
    {
        private MapView OriginMapView;

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

            if (Control == null)
            {
                SetNativeControl(OriginMapView);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }
    }
}
