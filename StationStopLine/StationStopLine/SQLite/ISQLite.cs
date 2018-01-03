
using SQLite;

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
