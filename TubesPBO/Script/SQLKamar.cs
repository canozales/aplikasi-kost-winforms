using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesPBO.Script
{
    class SQLKamar : SQLUmum
    {
        //protected DBConnect connect = new DBConnect();

        public string jumlahKamarKosong()
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM `kamar` WHERE `status` = 'READY'", connect.getConnection());
            connect.openConnect();
            string jumlah = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return jumlah;
        }

        public DataTable kamarKosong()
        {
            MySqlCommand command = new MySqlCommand("SELECT `kamar` FROM `kamar` WHERE `status` = 'READY'", connect.getConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        public DataTable lihatPenghuni(int kamar)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `penghuni` WHERE `kamar` = @1", connect.getConnection());
            command.Parameters.Add("@1", MySqlDbType.Int32).Value = kamar;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        public string lihatStatusKamar(int kamar)
        {
            MySqlCommand command = new MySqlCommand("SELECT `status` FROM `kamar` WHERE `kamar` = @1", connect.getConnection());
            command.Parameters.Add("@1", MySqlDbType.Int32).Value = kamar;

            connect.openConnect();
            string status = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return status;
        }

        public bool ubahStatus(int kamar)
        {
            MySqlCommand command;
            if (lihatStatusKamar(kamar) == "READY")
            {
               command = new MySqlCommand("UPDATE `kamar` SET `STATUS` = 'FULL' WHERE `kamar` = @1 ", connect.getConnection());

            } 
            else
            {
                command = new MySqlCommand("UPDATE `kamar` SET `STATUS` = 'READY' WHERE `kamar` = @1 ", connect.getConnection());
            }
            command.Parameters.Add("@1", MySqlDbType.Int32).Value = kamar;

            connect.openConnect();

            if(command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            } else
            {
                connect.closeConnect();
                return false;
            }

        }
    }
}
