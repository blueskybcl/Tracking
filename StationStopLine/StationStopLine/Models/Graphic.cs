using System;
using System.Collections.Generic;
using System.Text;
using SkiaSharp;

namespace StationStopLine.Models
{
    public class Graphic
    {
        public long Id { get; set; }
        public GeometryType GeometryType { get; set; }
        public SKColor FillColor { get; set; } = SKColors.Black;
        public float StrokeWidth { get; set; } = 5;
        public SKPoint[] Points { get; set; }
        public object RefrenceData { get; set; }
    }
}
