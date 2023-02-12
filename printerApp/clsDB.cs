using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printerApp
{
    public class clsDB
    {
        // conexión a DB mysql
        private static string server = "127.0.0.1";
        private static string user = "root";
        private static string password = "hesoyam";
        private static string database = "laesmeralda";

        public static DataTable getData(string qry)
        {
            try
            {
                string strConn = $"server={server};uid={user};database={database};pwd={password}";
                MySqlConnection Myconn = new MySqlConnection(strConn);
                MySqlCommand Mycommand = new MySqlCommand(qry, Myconn);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = Mycommand;
                DataTable info = new DataTable();
                MyAdapter.Fill(info);
                return info;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
