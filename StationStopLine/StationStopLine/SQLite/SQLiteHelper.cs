//------------------------------------------------------------------------------
// SQLiteHelper.cs
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
using System.Collections.Generic;
using System.Linq;

using SQLite.Net;
using StationStopLine.Common;
using Xamarin.Forms;

namespace StationStopLine.SQLite
{
    public sealed class SQLiteHelper
    {
        public readonly SQLiteConnection SqLiteConnection;

        private static SQLiteHelper _instance;
        private static readonly object _padLock = new object();

        private SQLiteHelper()
        {
            SqLiteConnection = DependencyService.Get<ISQLite>().GetConnection(Constants.BaseSets.SQLiteFilename);
            SqLiteConnection.CreateTable<KanbanData>();
        }

        public static SQLiteHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SQLiteHelper();
                        }
                    }
                }
                return _instance;
            }
        }
    }

    public interface IBaseService
    {
        T Retrieve<T>(long id) where T : class;
        TableQuery<T> RetrieveAll<T>() where T : class;
        void Delete<T>(long id) where T : class;
        void DeleteAll<T>() where T : class;
        void DropTable<T>() where T : class;
        void Add<T>(T obj) where T : class;
    }

    public class BaseService: IBaseService
    {
        protected readonly SQLiteConnection _sqLiteConnection;

        public BaseService(SQLiteConnection sqLiteConnection)
        {
            _sqLiteConnection = sqLiteConnection;
        }

        public TableQuery<T> RetrieveAll<T>() where T : class
        {
            return _sqLiteConnection.Table<T>();
        }

        public T Retrieve<T>(long id) where T : class
        {
            return _sqLiteConnection.Find<T>(id);
        }

        public void Delete<T>(long id) where T : class
        {
            _sqLiteConnection.Delete<T>(id);
        }

        public void DeleteAll<T>() where T : class
        {
            _sqLiteConnection.DeleteAll<T>();
        }

        public void DropTable<T>() where T : class
        {
            _sqLiteConnection.DropTable<T>();
        }

        public void Add<T>(T obj) where T : class
        {
            _sqLiteConnection.Insert(obj);
        }

    }
}
