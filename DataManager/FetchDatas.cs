using System.Collections.Generic;
using DataBaseManager;

namespace DataManager
{
    public class FetchDatas
    {

        /// <summary>
        /// Returns every maps in the database
        /// </summary>
        /// <returns>All maps in a List of strings</returns>
        public static List<string> FetchAllMapNames()
        {
            string query = "SELECT `Name` FROM Maps";
            List<string> maps = new List<string>(ExecuteQuery.Select(query));

            return maps;
        }

        /// <summary>
        /// Returns all perks for a map
        /// </summary>
        /// <param name="mapID">Map ID in the database</param>
        /// <returns>All perks for said map in a list of string</returns>
        public static List<string> FetchPerksForMap(int mapID)
        {
            string query = "SELECT `Name` FROM Perks INNER JOIN PerksInMap ON PerksInMap.PerkID = Perks.ID WHERE PerksInMap.MapID = " + mapID;
            List<string> queryResult = new List<string>(ExecuteQuery.Select(query));

            return queryResult;
        }

        /// <summary>
        /// Returns the map ID from the map name
        /// </summary>
        /// <param name="mapName">Map name in string format</param>
        /// <returns>map ID</returns>
        public static int ReturnMapID(string mapName)
        {
            string query = "SELECT `ID` FROM Maps WHERE `Name` = '" + mapName + "'";
            List<string> mapIDTemp = new List<string>(ExecuteQuery.Select(query));

            int mapID = int.Parse(mapIDTemp[0]);
            return mapID;
        }

        /// <summary>
        /// Returns all guns availible on a map
        /// </summary>
        /// <param name="mapID">Map ID</param>
        /// <returns>All availible guns in a list of string</returns>
        public static List<string> FetchGunsForMap(int mapID)
        {
            string query = "SELECT `Name` FROM Guns INNER JOIN GunsInMap ON GunsInMap.GunID = Guns.ID WHERE GunsInMap.MapID = " + mapID;
            List<string> queryResult = new List<string>(ExecuteQuery.Select(query));

            return queryResult;
        }

    }
}
