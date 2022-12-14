using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesPBO.Script
{
    class DBConnect
    {
        private MySqlConnection connect = new MySqlConnection(@"server=localhost;userid=root;database=kost");
        public MySqlConnection getConnection()
        {
            return connect;
        }
        public void openConnect()
        {
            if (this.connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }
        public void closeConnect()
        {
            if (this.connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }

    }
}
