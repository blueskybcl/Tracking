//------------------------------------------------------------------------------
// DataTable.cs
//
// <copyright from='2005' to='2015' company='Smartware Enterprises Inc'> 
// Copyright (c) Smartware Enterprises Inc. All Rights Reserved. 
// Information Contained Herein is Proprietary and Confidential. 
// </copyright>
//
// Created: 07/14/2015
// Owner: Yuanjie Liu
//
//------------------------------------------------------------------------------

using System;
using SQLite.Net.Attributes;

namespace StationStopLine.SQLite
{
    public class BaseData
    {
        public DateTime CreateOn { get; set; }
    }

    public class KanbanData : BaseData
    {
        public KanbanData()
        {
        }

        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
    
}
