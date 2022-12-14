using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TubesPBO.Script
{
    abstract class SQLUmum
    {
        protected DBConnect connect = new DBConnect();
        public bool deleteRow(int kamar)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `penghuni` WHERE `kamar` = @1", connect.getConnection());

            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = kamar;

            connect.openConnect();

            if(command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        public bool deleteRow(string nama, string telpon)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `pekerja` WHERE `nama` = @1 AND `telp` = @2", connect.getConnection());

            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = nama;
            command.Parameters.Add("@2", MySqlDbType.VarChar).Value = telpon;

            connect.openConnect();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public DataTable getTable(string tabel)
        {
            MySqlCommand command = new MySqlCommand($"SELECT * FROM `{tabel}` ", connect.getConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }


    }
}
