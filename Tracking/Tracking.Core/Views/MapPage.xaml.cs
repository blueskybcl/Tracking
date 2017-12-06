using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using MvvmCross.Forms.Views;
using Xamarin.Forms;
using Xamarin.Forms.BaiduMaps;

namespace Tracking.Core.Views
{
    public partial class MapPage : MvxContentPage
    {
		public MapPage ()
		{
			InitializeComponent ();

            IMapManager mapManager = DependencyService.Get<IMapManager>();
            mapManager.CoordinateType = CoordType.GCJ02;
            Map.Loaded += MapLoaded;
            //IOfflineMap offlineMap = DependencyService.Get<IOfflineMap>();
            //offlineMap.HasUpdate += (_, e) => {
            //    Debug.WriteLine("OfflineMap has update: " + e.CityID);
            //};
            //offlineMap.Downloading += (_, e) => {
            //    Debug.WriteLine("OfflineMap downloading: " + e.CityID);
            //};

            //var list = offlineMap.HotList;
            //list = offlineMap.AllList;
            ////offlineMap.Remove(131);
            //var curr = offlineMap.Current;
            ////offlineMap.Start(27);
            ////offlineMap.Start(75);
            //curr = offlineMap.Current;
            
            //ICalculateUtils calc = DependencyService.Get<ICalculateUtils>();
            //Debug.WriteLine(calc.CalculateDistance(
            //    new Coordinate(40, 116),
            //    new Coordinate(41, 117)
            //));//139599.429229778 in iOS, 139689.085961837 in Android
        }
        
        public void MapLoaded(object sender, EventArgs x)
        {
            Map.ShowScaleBar = true;
            InitLocationService();
            InitEvents();

            Coordinate[] coords = {
                new Coordinate(40.044, 116.391),
                new Coordinate(39.861, 116.284),
                new Coordinate(39.861, 116.468)
            };

            Map.Polygons.Add(new Polygon
            {
                Points = new ObservableCollection<Coordinate>(coords),
                Color = Color.Blue,
                FillColor = Color.Red.MultiplyAlpha(0.7),
                Width = 2
            });

            Map.Circles.Add(new Circle
            {
                Coordinate = Map.Center,
                Color = Color.Green,
                FillColor = Color.Yellow.MultiplyAlpha(0.2),
                Radius = 200,
                Width = 2
            });

            Task.Run(() => {
                for (; ; )
                {
                    Task.Delay(1000).Wait();

                    var p = Map.Polygons[0].Points[0];
                    p = new Coordinate(p.Latitude + 0.002, p.Longitude);
                    Map.Polygons[0].Points[0] = p;

                    Map.Circles[0].Radius += 100;
                }
            });
            
            IProjection proj = Map.Projection;
            var coord = proj.ToCoordinate(new Point(100, 100));
            Debug.WriteLine(proj.ToScreen(coord));
        }

        private static bool moved = false;
        public void InitLocationService()
        {
            Map.LocationService.LocationUpdated += (_, e) => {
                if (!moved)
                {
                    Map.Center = e.Coordinate;
                    moved = true;
                }
            };

            Map.LocationService.Failed += (_, e) => {
                Debug.WriteLine("Location failed: " + e.Message);
            };

            Map.LocationService.Start();
        }

        public void InitEvents()
        {
            BtnTrack.Clicked += (_, e) => {
                if (Map.ShowUserLocation)
                {
                    Map.UserTrackingMode = UserTrackingMode.None;
                    Map.ShowUserLocation = false;
                }
                else
                {
                    Map.UserTrackingMode = UserTrackingMode.Follow;
                    Map.ShowUserLocation = true;
                }
            };

            Map.LongClicked += (_, e) => {
                AddPin(e.Coordinate);
            };

            Map.StatusChanged += (_, e) => {
                //Debug.WriteLine(map.Center + " @" + map.ZoomLevel);
            };
        }

        void AddPin(Coordinate coord)
        {
            Pin annotation = new Pin
            {
                Title = coord,
                Coordinate = coord,
                Animate = true,
                Draggable = true,
                Enabled3D = true,
                Image = XImage.FromStream(
                    typeof(MapPage).GetTypeInfo().Assembly.GetManifestResourceStream("Tracking.Core.Images.pin_purple.png")
                )
            };
            Map.Pins.Add(annotation);

            annotation.Drag += (o, e) => {
                Pin self = o as Pin;
                self.Title = null;//self.Coordinate;
                int i = Map.Pins.IndexOf(self);

                if (Map.Polylines.Count > 0 && i > -1)
                {
                    Map.Polylines[0].Points[i] = self.Coordinate;
                }
            };

            annotation.Clicked += (_, e) => {
                Debug.WriteLine("clicked");
                ((Pin)_).Image = XImage.FromStream(
                    typeof(MapPage).GetTypeInfo().Assembly.GetManifestResourceStream("Tracking.Core.Images.start.png")
                );
            };

            if (0 == Map.Polylines.Count && Map.Pins.Count > 1)
            {
                Polyline polyline = new Polyline
                {
                    Points = new ObservableCollection<Coordinate> {
                        Map.Pins[0].Coordinate, Map.Pins[1].Coordinate
                    },
                    Width = 4,
                    Color = Color.Purple
                };

                Map.Polylines.Add(polyline);
            }
            else if (Map.Polylines.Count > 0)
            {
                Map.Polylines[0].Points.Add(annotation.Coordinate);
            }
        }
    }
}