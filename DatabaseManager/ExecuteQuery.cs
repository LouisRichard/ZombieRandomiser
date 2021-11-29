using System.Collections.Generic;
using System.Data.SQLite;

namespace DataBaseManager
{
    public class ExecuteQuery
    {
        /// <summary>
        /// Executes a SELECT querry sent in parameter
        /// </summary>
        /// <param name="query">String SELECT query</param>
        /// <returns>List of string containing every result</returns>
        public static List<string> Select(string query)
        {
            SQLiteCommand command = DbConnector.ConnectToDatabase(false); //open db connection
            List<string> result = new List<string>();
            command.CommandText = query;
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    result.Add(reader.GetString(0));
                }
                catch
                {
                    result.Add(reader.GetInt32(0).ToString());
                }
            }

            return result;
        }
    }
}
