using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StationStopLine.Common
{
    public static class Embedded
    {
        private static readonly Assembly _assembly;
        private static readonly string[] _resources;

        static Embedded()
        {
            _assembly = typeof(Embedded).GetTypeInfo().Assembly;
            _resources = _assembly.GetManifestResourceNames();
        }

        public static Stream Load(string name)
        {
            name = $".Media.Fonts.{name}";
            name = _resources.FirstOrDefault(n => n.EndsWith(name));

            Stream stream = null;
            if (name != null)
            {
                stream = _assembly.GetManifestResourceStream(name);
            }

            return stream;
        }
    }
}
