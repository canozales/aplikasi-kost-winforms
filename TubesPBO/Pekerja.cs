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
    public partial class Pekerja : Form
    {
        SQLPekerja pekerja = new SQLPekerja();        
        public Pekerja()
        {
            InitializeComponent();
            refreshTable();

            tablepekerja.Columns["kelahiran"].Visible = false;

            tablepekerja.Columns["nama"].Width = 170;
            tablepekerja.Columns["telp"].Width = 135;
            tablepekerja.Columns["pekerjaan"].Width = 145;
            tablepekerja.Columns["upah"].Width = 110;

            tablepekerja.Columns["nama"].HeaderText = "Nama";
            tablepekerja.Columns["telp"].HeaderText = "Telepon";
            tablepekerja.Columns["pekerjaan"].HeaderText = "Pekerjaan";
            tablepekerja.Columns["upah"].HeaderText = "Bayaran";
            tablepekerja.Columns["foto"].HeaderText = "Foto";

            this.Select();
        }

        private void Pekerja_Load(object sender, EventArgs e)
        {

        }
        public void refreshTable()
        {
            tablepekerja.DataSource = pekerja.getTable("pekerja");
            tablepekerja.Sort(tablepekerja.Columns["nama"], ListSortDirection.Ascending);

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)tablepekerja.Columns[5];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        public void clear()
        {
            kotaknama.Enabled = true;
            kotaknama.Clear();
            kotakbayaran.Clear();
            kotakpekerjaan.Clear();
            kotaktelpon.Clear();
            kotakfoto.Image = null;
            kotaktanggal.Value = new DateTime(2000, 1, 1);
        }
        private void tomboladd_Click(object sender, EventArgs e)
        {
            if (kotaknama.Enabled)
            {
                if (kotaknama.Text == "" || kotakbayaran.Text == "" || kotaktelpon.Text == "" ||
                    kotakpekerjaan.Text == "" || kotakfoto.Image == null)
                {
                    MessageBox.Show("Periksa Kembali Data Pekerja !", "Tambah Pekerja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        kotakfoto.Image.Save(ms, kotakfoto.Image.RawFormat);
                        byte[] foto = ms.ToArray();

                        if (pekerja.insertPekerja(kotaknama.Text, (DateTime)kotaktanggal.Value, kotaktelpon.Text,
                            kotakpekerjaan.Text, kotakbayaran.Text, foto))
                        {
                            MessageBox.Show("Pekerja Baru Berhasil Ditambah !", "Tambah Pekerja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                            refreshTable();
                        }
                        else
                        {
                            MessageBox.Show("Terdapat Kesalahan !", "Tambah Pekerja", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            } 
        }
        private void tombolupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg";
            if (opf.ShowDialog() == DialogResult.OK)
                kotakfoto.Image = Image.FromFile(opf.FileName);
        }

        private void tombolclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void tomboldelete_Click(object sender, EventArgs e)
        {
            if (kotaknama.Text != "" && kotakbayaran.Text != "" && kotaktelpon.Text != "" &&
                 kotakpekerjaan.Text != "" && kotakfoto.Image != null)
            {
                if (MessageBox.Show($"Ingin memberhentikan {kotaknama.Text} ?", "Berhentikan Pekerja", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {

                    if (pekerja.deleteRow(kotaknama.Text, kotaktelpon.Text))
                    {
                        MessageBox.Show("Pekerja berhasil diberhentikan !", "Berhentikan Pekerja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        refreshTable();
                    } else
                    {
                        MessageBox.Show("Terdapat Kesalahan !", "Berhentikan Pekerja", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void tobolupdate_Click(object sender, EventArgs e)
        {
            if (kotaknama.Text != "" && kotakbayaran.Text != "" && kotaktelpon.Text != "" &&
                kotakpekerjaan.Text != "" && kotakfoto.Image != null)
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    kotakfoto.Image.Save(ms, kotakfoto.Image.RawFormat);
                    byte[] foto = ms.ToArray();

                    if (pekerja.updatePekerja(kotaknama.Text, (DateTime)kotaktanggal.Value, kotaktelpon.Text ,
                        kotakpekerjaan.Text, kotakbayaran.Text, foto))
                    {
                        MessageBox.Show("Pekerja Berhasil Diupdate !", "Update Pekerja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        refreshTable();
                    }
                    else
                    {
                        MessageBox.Show("Terdapat Kesalahan !", "Update Pekerja", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Periksa Kembali Data Pekerja !", "Update Pekerja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tablepekerja_Click(object sender, EventArgs e)
        {
            try
            {
                kotaknama.Text = tablepekerja.CurrentRow.Cells[0].Value.ToString();
                kotaktanggal.Value = (DateTime)tablepekerja.CurrentRow.Cells[1].Value;
                kotaktelpon.Text = tablepekerja.CurrentRow.Cells[2].Value.ToString();
                kotakpekerjaan.Text = tablepekerja.CurrentRow.Cells[3].Value.ToString();
                kotakbayaran.Text = tablepekerja.CurrentRow.Cells[4].Value.ToString();

                byte[] img = (byte[])tablepekerja.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(img);
                kotakfoto.Image = Image.FromStream(ms);

                kotaknama.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Table Masih Kosong !", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                clear();
            }

        }

        private void Pekerja_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
