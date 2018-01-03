
using System;
using System.IO;
using SQLite;
using StationStopLine.Common;

namespace StationStopLine.SQLite
{
    public interface IBaseService
    {
        void Delete<T>(long id) where T : class;
        void DeleteAll<T>() where T : class;
        void DropTable<T>() where T : class;
        void Add<T>(T obj) where T : class;
    }

    public class BaseService: IBaseService
    {
        protected readonly SQLiteConnection _sqLiteConnection;

        public BaseService()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string path = Path.Combine(documentsPath, Constants.BaseSets.SQLiteFilename);
            _sqLiteConnection = new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.FullMutex, true);

        }

        public void Init()
        {
            _sqLiteConnection.CreateTable<KanbanData>();
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

    public class KanbanService : BaseService
    {
        public void AddKanban(KanbanData kanban)
        {
            if (_sqLiteConnection.Find<KanbanData>(kanban.Id) != null)
            {
                _sqLiteConnection.Update(kanban);
            }
            else
            {
                _sqLiteConnection.Insert(kanban);
            }
        }

        public KanbanData GetKanban(long id)
        {
            if (_sqLiteConnection.Find<KanbanData>(id) != null)
            {
                return _sqLiteConnection.Get<KanbanData>(id);
            }

            return null;
        }
    }
}
