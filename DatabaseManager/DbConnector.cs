using System.Data.SQLite;

namespace DataBaseManager
{
    public class DbConnector
    {

        /// <summary>
        /// Connect to the SQLite database.
        /// </summary>
        /// <param name="close">If true : Close database connection. If false : Open database connection.</param>
        /// <returns>SQLiteCommand cmd if database is getting opened.</returns>
        /// <returns>Null if database is getting closed.</returns>
        internal static SQLiteCommand ConnectToDatabase(bool close)
        {
            System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=ZombieDB.db3");
            System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn);

            if (!close)
            {
                conn.Open();
                return cmd;
            }
            else
            {
                cmd = null;
                conn.Close();
                return cmd;
            }
        }
    }
}
