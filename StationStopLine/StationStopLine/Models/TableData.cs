using System;
using System.Collections.Generic;
using System.Text;

namespace StationStopLine.Models
{
    public class TableData
    {
        public byte[] Uplink { get; set; }
        public byte[] Downlink { get; set; }
        public List<RowData> RowDatas { get; set; } = new List<RowData>();
        public byte[] Note { get; set; }
    }
}
