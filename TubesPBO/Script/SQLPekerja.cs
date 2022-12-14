using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesPBO.Script
{
    class SQLPekerja : SQLUmum
    {

        public bool insertPekerja(string nama, DateTime kelahiran, string telp, string pekerjaan, string upah, byte[] foto)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `pekerja` VALUES(@1,@2,@3,@4,@5,@6)", connect.getConnection() );

            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = nama;
            command.Parameters.Add("@2", MySqlDbType.Date).Value = kelahiran;
            command.Parameters.Add("@3", MySqlDbType.VarChar).Value = telp;
            command.Parameters.Add("@4", MySqlDbType.VarChar).Value = pekerjaan;
            command.Parameters.Add("@5", MySqlDbType.VarChar).Value = upah;
            command.Parameters.Add("@6", MySqlDbType.LongBlob).Value = foto;

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

        public bool updatePekerja(string nama, DateTime kelahiran, string telp, string pekerjaan, string upah, byte[] foto)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `pekerja` SET `nama` = @1, `kelahiran` = @2, `telp` = @3, " +
                "`pekerjaan` = @4, `upah` = @5, `foto` = @6 WHERE `nama` = @1", connect.getConnection());

            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = nama;
            command.Parameters.Add("@2", MySqlDbType.Date).Value = kelahiran;
            command.Parameters.Add("@3", MySqlDbType.VarChar).Value = telp;
            command.Parameters.Add("@4", MySqlDbType.VarChar).Value = pekerjaan;
            command.Parameters.Add("@5", MySqlDbType.VarChar).Value = upah;
            command.Parameters.Add("@6", MySqlDbType.LongBlob).Value = foto;

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


    }
}
