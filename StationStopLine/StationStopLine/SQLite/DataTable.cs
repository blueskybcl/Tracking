
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
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
    
}
