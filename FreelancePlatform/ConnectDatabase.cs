using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancePlatform
{
    public class ConnectDatabase
    {

        private const string SERVER = "server=localhost;port=3306;uid=root;pwd=root;database=freelanceplatform;SslMode=none;convert zero datetime=True";
        private MySqlConnection conn;

        public ConnectDatabase()
        {
            this.conn = new MySqlConnection(SERVER);
        }

        public MySqlConnection getConnection()
        {
            conn.Open();
            return conn;
        }
    }
}
