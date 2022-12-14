using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesPBO.Script
{
    class SQLAdmin
    {
        DBConnect connect = new DBConnect();

        public bool accountVerified(string username, string password)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `admin` WHERE `username` = @1 AND `password` = @2",
                connect.getConnection());

            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@2", MySqlDbType.VarChar).Value = password;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
