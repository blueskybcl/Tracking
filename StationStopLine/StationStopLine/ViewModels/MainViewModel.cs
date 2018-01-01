using System;
using System.Collections.Generic;
using System.Text;
using StationStopLine.Models;

namespace StationStopLine.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            foreach (string name in Enum.GetNames(typeof(GeometryType)))
            {
                ListItems.Add(name);
            }
        }

        public IList<string> ListItems { get; set; } = new List<string>();
    }
}
