using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace StationStopLine.Models
{
    public enum GeometryType
    {
        [Description("文本")]
        Text,
        [Description("直线")]
        Line,
        [Description("箭线")]
        ArrowLine,
        [Description("多段线")]
        PolyLine,
        [Description("多段箭线")]
        PolyArrowLine,
        [Description("半矩形箭线")]
        SemiRectArrowLine,
        [Description("半矩形直线")]
        SemiRectLine,
        [Description("半矩形多段箭线")]
        PolySemiRectArrowLine,
        [Description("半矩形多段线")]
        PolySemiRectLine
    } 
}
