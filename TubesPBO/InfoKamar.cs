using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TubesPBO.Script;

namespace TubesPBO
{
    public partial class InfoKamar : Form
    {
        SQLKamar sqlkamar = new SQLKamar();
        private DataRow data;
        public DataRow GetData() { return data; }
        public void SetData(DataRow newData) { this.data = newData;}
        

        public InfoKamar(int x)
        {
            InitializeComponent();
            SetData(sqlkamar.lihatPenghuni(x).Rows[0]);
            //this.data = sqlkamar.lihatPenghuni(x).Rows[0];
        }
        private void InfoKamar_Load(object sender, EventArgs e)
        {
            labelNama.Text = GetData()["nama"].ToString();
            //labelNama.Text = data["nama"].ToString();
            labelKamar.Text = "Kamar " + data["kamar"].ToString();
            labelTtl.Text = data["ttl"].ToString();
            labelKerja.Text = data["pekerjaan"].ToString();

            DateTime sekarang = DateTime.Today;
            labelSisa.Text = "Sisa Waktu : " + 
                ((DateTime)data["tanggalberakhir"] - sekarang).Days.ToString() + " Hari";

            byte[] gambar = (byte[])data["foto"];
            MemoryStream ms = new MemoryStream(gambar);
            kotakFoto.Image = Image.FromStream(ms);         
        }


        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.BackColor = Color.FromArgb(180, 180, 180);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.Transparent;
        }
        bool bukanAltF4 = false;
        private void label6_Click(object sender, EventArgs e)
        {
            bukanAltF4 = true;
            this.Close();
            bukanAltF4 = false;
        }

        private void InfoKamar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing)
            {
                if (!bukanAltF4)
                    e.Cancel = true;
            }
        }
    }
}
