using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace TeamJocas
{
    class MYSQLCONNECTION
    {
        public MySqlConnection conn;
        public void Connection()
        {
            conn = new MySqlConnection("server = localhost; user id = root; database = teamjocas");
            // MYSQLCONNECTION conn = new MYSQLCONNECTION ();
            // conn.Connection();
        }
    }
}
