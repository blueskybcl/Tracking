using System;
using System.Collections.Generic;
using System.Text;

namespace StationStopLine.Models
{
    public class Graphic
    {
        public int Id { get; set; }
        public GeometryType GeometryType { get; set; } = GeometryType.UnKnown;
        public object Value { get; set; }
    }
}
