using System;
using System.Collections.Generic;
using System.Text;
using SkiaSharp;
using Xamarin.Forms;

namespace StationStopLine.Models
{
    public class Graphic
    {
        public long Id { get; set; }
        public GeometryType GeometryType { get; set; }
        public string FillColor { get; set; } = "#FFD2691E";
        public float StrokeWidth { get; set; } = 5;
        public List<Line> Lines { get; set; } = new List<Line>();
        public object RefrenceData { get; set; }
    }
}
