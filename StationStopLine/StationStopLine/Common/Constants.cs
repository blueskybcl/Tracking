using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StationStopLine.Common
{
     public  class Constants
    {
        public static class BaseSets
        {
            public const string SQLiteFilename = "StationLineSQLite.db3";
        }

        public static class Fonts
        {
            public static Stream EmbeddedFont => Embedded.Load("corbel.ttf");
        }
    }
}
