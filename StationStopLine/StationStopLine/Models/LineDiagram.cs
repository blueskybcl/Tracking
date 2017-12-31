using System;
using System.Collections.Generic;
using System.Text;

namespace StationStopLine.Models
{
    public class LineDiagram
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Graphic> Graphics { get; set; } = new List<Graphic>();
    }
}
