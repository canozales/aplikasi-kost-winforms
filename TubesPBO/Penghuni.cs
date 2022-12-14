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
    public partial class Penghuni : Form
    {
        SQLPenghuni SQLPenghuni = new SQLPenghuni();
        SQLKamar daftarKamar = new SQLKamar();
        public Penghuni()
        {
            InitializeComponent();
            tablePenghuni.DataSource = SQLPenghuni.getTable("penghuni");
            tablePenghuni.Columns["nama"].DisplayIndex = 1;
            tablePenghuni.Columns["kamar"].DisplayIndex = 0;

            tablePenghuni.Columns["Pekerjaan"].Visible = false;
            tablePenghuni.Columns["foto"].Visible = false;

            tablePenghuni.Columns["nama"].Width = 150;
            tablePenghuni.Columns["kamar"].Width = 60;
            tablePenghuni.Columns["telp"].Width = 170;
            tablePenghuni.Columns["ttl"].Width = 220;

            tablePenghuni.Columns["kamar"].HeaderText = "Kamar";
            tablePenghuni.Columns["nama"].HeaderText = "Nama Lengkap";
            tablePenghuni.Columns["ttl"].HeaderText = "Tempat Tanggal Lahir";
            tablePenghuni.Columns["telp"].HeaderText = "No Telpon";
            tablePenghuni.Columns["tanggalberakhir"].HeaderText = "Berakhir";

            comboKamar.DataSource = daftarKamar.kamarKosong();
            comboKamar.DisplayMember = "kamar";
            comboKamar.ValueMember = "kamar";
            comboKamar.SelectedIndex = -1;

            comboBoxKamar.DataSource = daftarKamar.kamarKosong();
            comboBoxKamar.DisplayMember = "kamar";
            comboBoxKamar.ValueMember = "kamar";
            comboBoxKamar.SelectedIndex = -1;

            this.Select();

        }
        private void Penghuni_Load(object sender, EventArgs e)
        {
            
        }
        public void refreshTable()
        {
            tablePenghuni.DataSource = SQLPenghuni.getTable("penghuni");
            tablePenghuni.Sort(tablePenghuni.Columns["kamar"], ListSortDirection.Ascending);

            comboKamar.DataSource = daftarKamar.kamarKosong();
            comboKamar.DisplayMember = "kamar";
            comboKamar.ValueMember = "kamar";
            comboKamar.SelectedIndex = -1;

            comboBoxKamar.DataSource = daftarKamar.kamarKosong();
            comboBoxKamar.DisplayMember = "kamar";
            comboBoxKamar.ValueMember = "kamar";
            comboBoxKamar.SelectedIndex = -1;

            //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //imageColumn = (DataGridViewImageColumn)tablePenghuni.Columns[6];
            //imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        public void clear()
        {
            kotaknama.Clear();
            kotaktelp.Clear();
            kotakttl.Clear();
            kotakpekerjaan.Clear();
            kotaksisahari.Clear();
            perpanjangkost.Clear();
            kotakfoto.Image = null;

            comboBoxKamar.SelectedIndex = -1;
            comboBoxKamar.SelectedIndex = -1;
            comboKamar.SelectedIndex = -1;
            comboKamar.SelectedIndex = -1;

            comboKamar.Visible = true;
            pelapiscomboKamar.Visible = false;

            kotaksisahari.ReadOnly = false;
            kotaksisahari.Enabled = true;

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (kotaknama.Text == "" || comboKamar.Text == "" || kotakttl.Text == "" || kotaktelp.Text == "" ||
                kotakpekerjaan.Text == "" || kotaksisahari.Text == "" || kotakfoto.Image == null)
            {
                MessageBox.Show("Periksa Kembali Data Penghuni !", "Tambah Penghuni", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    kotakfoto.Image.Save(ms, kotakfoto.Image.RawFormat);
                    byte[] foto = ms.ToArray();

                    DateTime tanggalberakhir = DateTime.Today;
                    tanggalberakhir = tanggalberakhir.AddDays(int.Parse(kotaksisahari.Text));

                    if (SQLPenghuni.insertPenghuni(kotaknama.Text, int.Parse(comboKamar.Text), kotakttl.Text,
                        kotakpekerjaan.Text, kotaktelp.Text, tanggalberakhir, foto))
                    {
                        daftarKamar.ubahStatus(int.Parse(comboKamar.Text));
                        refreshTable();
                        MessageBox.Show("Penghuni berhasil ditambahkan !", "Tambah Penghuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();

                    }
                    else
                    {
                        MessageBox.Show("Terdapat Kesalahan !", "Tambah Penghuni", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void tombolUpdate_Click(object sender, EventArgs e)
        {
            if (kotaknama.Text == "" || pelapiscomboKamar.Text == "" || kotakttl.Text == "" || kotaktelp.Text == "" ||
                 kotakpekerjaan.Text == "" || kotaksisahari.Text == "" || kotakfoto.Image == null)
            {
                MessageBox.Show("Terdapat Data Kosong !", "Update Penghuni", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    kotakfoto.Image.Save(ms, kotakfoto.Image.RawFormat);
                    byte[] foto = ms.ToArray();

                    DateTime tanggalberakhir = DateTime.Today;
                    tanggalberakhir = tanggalberakhir.AddDays(int.Parse(kotaksisahari.Text));

                    if (SQLPenghuni.updatePenghuni(kotaknama.Text, int.Parse(pelapiscomboKamar.Text), kotakttl.Text,
                        kotakpekerjaan.Text, kotaktelp.Text, tanggalberakhir, foto))
                    {
                        refreshTable();
                        MessageBox.Show("Penghuni berhasil diupdate !", "Update Penghuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();

                    }
                    else
                    {
                        MessageBox.Show("Terdapat Kesalahan !", "Update Penghuni", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void tombolClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void tombolUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg";
            if (opf.ShowDialog() == DialogResult.OK)
                kotakfoto.Image = Image.FromFile(opf.FileName);
        }

        private void tombolDelete_Click(object sender, EventArgs e)
        {
            if (kotaknama.Text != "" && pelapiscomboKamar.Text != "" && kotakttl.Text != "" && kotaktelp.Text != "" &&
                 kotakpekerjaan.Text != "" && kotaksisahari.Text != "" && kotakfoto.Image != null)
            {
                if (MessageBox.Show($"Ingin menghapus {kotaknama.Text} ?", "Hapus Penghuni", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    if (SQLPenghuni.deleteRow(int.Parse(pelapiscomboKamar.Text)))
                    {
                        daftarKamar.ubahStatus(int.Parse(pelapiscomboKamar.Text));
                        refreshTable();
                        MessageBox.Show("Penghuni berhasil dihapus !", "Hapus Penghuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Terdapat Kesalahan !", "Hapus Penghuni", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }

        }
        public void hapusOtomatis()
        {
            DataTable daftarPenghuni = SQLPenghuni.getTable("penghuni");
            DateTime hariIni = DateTime.Today;

            foreach(DataRow row in daftarPenghuni.Rows)
            {
                if ((DateTime)row["tanggalberakhir"] <= hariIni.AddDays(-3))                
                {
                    daftarKamar.ubahStatus((int)row["kamar"]);
                    SQLPenghuni.deleteRow((int)row["kamar"]);
                }
            }
        }
        private void tablePenghuni_Click(object sender, EventArgs e)
        {
            try
            {
                kotaksisahari.ReadOnly = true;
                kotaksisahari.Enabled = false;

                //comboKamar.Enabled = true;
                //comboKamar.SelectedIndex = ((int)tablePenghuni.CurrentRow.Cells[1].Value) - 1; 
                //comboKamar.Text = tablePenghuni.CurrentRow.Cells[1].Value.ToString();

                if (comboKamar.Visible) { comboKamar.Visible = false; }

                pelapiscomboKamar.Enabled = true;
                pelapiscomboKamar.Visible = true;
                pelapiscomboKamar.Text = tablePenghuni.CurrentRow.Cells[1].Value.ToString();
                pelapiscomboKamar.Enabled = false;

                kotaknama.Text = tablePenghuni.CurrentRow.Cells[0].Value.ToString();
                kotakttl.Text = tablePenghuni.CurrentRow.Cells[2].Value.ToString();
                kotakpekerjaan.Text = tablePenghuni.CurrentRow.Cells[3].Value.ToString();
                kotaktelp.Text = tablePenghuni.CurrentRow.Cells[4].Value.ToString();

                DateTime tanggalberakhir = (DateTime)tablePenghuni.CurrentRow.Cells[5].Value;
                DateTime tanggalsekarang = DateTime.Today;
                int sisahari = (tanggalberakhir - tanggalsekarang).Days;
                kotaksisahari.Text = sisahari.ToString();

                byte[] img = (byte[])tablePenghuni.CurrentRow.Cells[6].Value;
                MemoryStream ms = new MemoryStream(img);
                kotakfoto.Image = Image.FromStream(ms);
            }
            catch
            {
                MessageBox.Show("Table Masih Kosong !", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                clear();
            }

        }
        private void tombolPindah_Click(object sender, EventArgs e)
        {
            if (kotaknama.Text != "" && pelapiscomboKamar.Text != "" && kotakttl.Text != "" && kotaktelp.Text != "" &&
                kotakpekerjaan.Text != "" && kotaksisahari.Text != "" && kotakfoto.Image != null && comboBoxKamar.Text != "")
            {
                if (MessageBox.Show($"Pindah ke Kamar {comboBoxKamar.Text} ?", "Pindah Kamar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    if (SQLPenghuni.pindahKamar(kotaknama.Text, kotaktelp.Text, int.Parse(comboBoxKamar.Text)))
                    {
                        daftarKamar.ubahStatus(int.Parse(comboBoxKamar.Text));
                        daftarKamar.ubahStatus(int.Parse(pelapiscomboKamar.Text));
                        MessageBox.Show("Penghuni berhasil dipindahkan !", "Pindah Kamar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        refreshTable();
                    }
                    else
                    {
                        MessageBox.Show("Terdapat Kesalahan !", "Pindah Kamar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }
        private void tombolPerpanjang_Click(object sender, EventArgs e)
        {
            if (kotaknama.Text != "" && pelapiscomboKamar.Text != "" && kotakttl.Text != "" && kotaktelp.Text != "" &&
                     kotakpekerjaan.Text != "" && kotaksisahari.Text != "" && kotakfoto.Image != null && perpanjangkost.Text != "")
            {
                if (MessageBox.Show($"Perpanjang {perpanjangkost.Text} bulan ?", "Perpanjang Kost", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    if (SQLPenghuni.tambahHari(int.Parse(perpanjangkost.Text), int.Parse(pelapiscomboKamar.Text)))
                    {
                        MessageBox.Show("Waktu Berhasil ditambah !", "Perpanjang Kost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        refreshTable();
                    }
                     else
                    {
                        MessageBox.Show("Terdapat Kesalahan !", "Perpanjang Kost", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void Penghuni_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_upload_Click(object sender, EventArgs e)
        {

        }

        private void telp_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void kamar_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void sisahari_TextChanged(object sender, EventArgs e)
        {

        }

        private void pekerjaan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ttl_TextChanged(object sender, EventArgs e)
        {

        }

        private void BottomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxKamar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void perpanjangkost_TextChanged(object sender, EventArgs e)
        {

        }

        private void kotaknama_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void kotakttl_KeyDown(object sender, KeyEventArgs e)
        {

        }


    }
}
