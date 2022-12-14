using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesPBO.Script
{
    class SQLPenghuni : SQLUmum
    {
        public bool insertPenghuni(string nama, int kamar, string ttl, string pekerjaan, string telp, DateTime tanggalberakhir, byte[] foto)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `penghuni` VALUES(@1, @2, @3, @4, @5, @6, @7)", connect.getConnection());

            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = nama;
            command.Parameters.Add("@2", MySqlDbType.Int32).Value = kamar;
            command.Parameters.Add("@3", MySqlDbType.VarChar).Value = ttl;
            command.Parameters.Add("@4", MySqlDbType.VarChar).Value = pekerjaan;
            command.Parameters.Add("@5", MySqlDbType.VarChar).Value = telp;
            command.Parameters.Add("@6", MySqlDbType.Date).Value = tanggalberakhir;
            command.Parameters.Add("@7", MySqlDbType.LongBlob).Value = foto;

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

        public bool updatePenghuni(string nama, int kamar, string ttl, string pekerjaan, string telp, DateTime tanggalberakhir, byte[] foto)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `penghuni` SET `nama` = @1, `ttl` = @3, " +
                "`pekerjaan` = @4, `telp` = @5, `tanggalberakhir` = @6, `foto` = @7 WHERE `kamar` = @2", connect.getConnection());

            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = nama;
            command.Parameters.Add("@2", MySqlDbType.Int32).Value = kamar;
            command.Parameters.Add("@3", MySqlDbType.VarChar).Value = ttl;
            command.Parameters.Add("@4", MySqlDbType.VarChar).Value = pekerjaan;
            command.Parameters.Add("@5", MySqlDbType.VarChar).Value = telp;
            command.Parameters.Add("@6", MySqlDbType.Date).Value = tanggalberakhir;
            command.Parameters.Add("@7", MySqlDbType.LongBlob).Value = foto;

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

        public bool pindahKamar(string nama, string telp, int kamar)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `penghuni` SET `kamar` = @1 WHERE " +
                "`nama` = @2 AND `telp` = @3", connect.getConnection());

            command.Parameters.Add("@1", MySqlDbType.Int32).Value = kamar;
            command.Parameters.Add("@2", MySqlDbType.VarChar).Value = nama;
            command.Parameters.Add("@3", MySqlDbType.VarChar).Value = telp;

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

        public bool tambahHari(int bulan, int kamar)
        {
            MySqlCommand command = new MySqlCommand("SELECT `tanggalberakhir` FROM `penghuni` WHERE `kamar` = @1", connect.getConnection());
            command.Parameters.Add("@1", MySqlDbType.Int32).Value = kamar;

            connect.openConnect();

            DateTime time = (DateTime)command.ExecuteScalar();
            time = time.AddMonths(bulan);

            connect.closeConnect();

            MySqlCommand command2 = new MySqlCommand("UPDATE `penghuni` SET `tanggalberakhir` = @3 WHERE `kamar` = @4 ", connect.getConnection());
            command2.Parameters.Add("@4", MySqlDbType.Int32).Value = kamar;
            command2.Parameters.Add("@3", MySqlDbType.Date).Value = time;

            connect.openConnect();
            if (command2.ExecuteNonQuery() == 1)
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
