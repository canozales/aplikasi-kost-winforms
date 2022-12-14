using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TubesPBO.Script;

namespace TubesPBO
{
    public partial class Keuangan : Form
    {
        SQLKamar kamar = new SQLKamar();

        public Keuangan()
        {
            InitializeComponent();
        
        }
        public void refreshKeuangan()
        {
            jumlahKamar.Text = "Jumlah Kamar Disewa (" + (16 - int.Parse(kamar.jumlahKamarKosong())).ToString() + ")";
            kotakDisewa.Text = "Rp " + (3 * (16 - int.Parse(kamar.jumlahKamarKosong()))).ToString() + ".000.000";

            int totalGaji = 0;
            DataTable daftarPekerja = (DataTable)kamar.getTable("pekerja");

            foreach (DataRow row in daftarPekerja.Rows)
            {
                totalGaji += int.Parse(Regex.Replace(row["upah"].ToString(), @"\D+", String.Empty));
            }

            kotakUpah.Text = "Rp " + String.Format("{0:n0}", totalGaji);

            kotakBersih.Text = "Rp " + String.Format("{0:n0}", int.Parse(Regex.Replace(kotakDisewa.Text, @"\D+", String.Empty)) -
               int.Parse(Regex.Replace(kotakUpah.Text, @"\D+", String.Empty)));

            DateTime x = DateTime.Today;
            tanggal.Text = x.ToString("dd MMMM yyyy");
        }

        private void Keuangan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
