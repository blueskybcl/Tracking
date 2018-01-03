
using System;
using SQLite;

namespace StationStopLine.SQLite
{
    public class BaseData
    {
        public DateTime CreateOn { get; set; } = DateTime.Now;
    }

    public class KanbanData : BaseData
    {
        [PrimaryKey]
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class GridData : BaseData
    {
        [PrimaryKey]
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
