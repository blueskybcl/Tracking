//------------------------------------------------------------------------------
// ISQLite.cs
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

using SQLite.Net;

namespace StationStopLine.SQLite
{
    public interface ISQLite
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <param name="sqliteFilename">The sqlite filename.</param>
        /// <returns>SQLiteConnection.</returns>
        SQLiteConnection GetConnection(string sqliteFilename);
    }
}
