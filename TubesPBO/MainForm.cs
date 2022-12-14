using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TubesPBO.Script;
using System.Threading.Tasks;

namespace TubesPBO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }
        private SQLKamar sqlkamar = new SQLKamar();
        private Penghuni penghuni = new Penghuni();
        private Pekerja pekerja = new Pekerja();
        private Keuangan laporan = new Keuangan();
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            tombolKamar.ForeColor = Color.Turquoise;
            penghuni.hapusOtomatis();
            refreshStatusKamar();
        }
        public void refreshStatusKamar()
        {

            label4.Text = sqlkamar.lihatStatusKamar(1);
            label5.Text = sqlkamar.lihatStatusKamar(2);
            label6.Text = sqlkamar.lihatStatusKamar(3);
            label7.Text = sqlkamar.lihatStatusKamar(4);

            label9.Text = sqlkamar.lihatStatusKamar(5);
            label10.Text = sqlkamar.lihatStatusKamar(6);
            label11.Text = sqlkamar.lihatStatusKamar(7);
            label12.Text = sqlkamar.lihatStatusKamar(8);

            label13.Text = sqlkamar.lihatStatusKamar(9);
            label14.Text = sqlkamar.lihatStatusKamar(10);
            label15.Text = sqlkamar.lihatStatusKamar(11);
            label16.Text = sqlkamar.lihatStatusKamar(12);

            label17.Text = sqlkamar.lihatStatusKamar(13);
            label18.Text = sqlkamar.lihatStatusKamar(14);
            label19.Text = sqlkamar.lihatStatusKamar(15);
            label20.Text = sqlkamar.lihatStatusKamar(16);

            labelAvailable.Text ="Kamar Tersedia : " +  sqlkamar.jumlahKamarKosong();

            var labels = new List<Label> { label4, label5, label6, label7, label9, label10, label11, label12, 
            label13, label14, label15, label16, label17, label18, label19, label20};
            foreach (var label in labels)
            {
                if(label.Text == "READY")
                {
                    label.ForeColor = Color.LightGreen;
                } else
                {
                    label.ForeColor = Color.Coral;
                }
            }

        }
        private void gantiMainPanel(Form nextForm)
        {
            nextForm.TopLevel = false;
            nextForm.FormBorderStyle = FormBorderStyle.None;
            nextForm.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(nextForm);
            MainPanel.Tag = nextForm;

            nextForm.BringToFront();
            nextForm.Show();
            

        }
        private void tombolKamar_Click(object sender, EventArgs e)
        {
            tombolKamar.ForeColor = Color.Turquoise;
            tombolPenghuni.ForeColor = Color.White;
            tombolPekerja.ForeColor = Color.White;
            tombolFitur.ForeColor = Color.White;

            MainPanel.Controls.Remove(penghuni);
            MainPanel.Controls.Remove(pekerja);
            MainPanel.Controls.Remove(laporan);
            refreshStatusKamar();
        }
        private void tombolPenghuni_Click(object sender, EventArgs e)
        {
            tombolKamar.ForeColor = Color.White;
            tombolPenghuni.ForeColor = Color.Turquoise;
            tombolPekerja.ForeColor = Color.White;
            tombolFitur.ForeColor = Color.White;

            // penghuni.refreshTable();
            penghuni.clear();
            gantiMainPanel(penghuni);         
        }
        private void tombolPekerja_Click(object sender, EventArgs e)
        {
            tombolKamar.ForeColor = Color.White;
            tombolPenghuni.ForeColor = Color.White;
            tombolPekerja.ForeColor = Color.Turquoise;
            tombolFitur.ForeColor = Color.White;

            pekerja.clear();
            gantiMainPanel(pekerja);
        }
        private void tombolFitur_Click(object sender, EventArgs e)
        {
            tombolKamar.ForeColor = Color.White;
            tombolPenghuni.ForeColor = Color.White;
            tombolPekerja.ForeColor = Color.White;
            tombolFitur.ForeColor = Color.Turquoise;

            laporan.refreshKeuangan();
            gantiMainPanel(laporan);
        }
        private void tombolExit_Click(object sender, EventArgs e)
        {
            LoginForm x = new LoginForm(this);
            this.Hide();
            x.Show();
            
            
        }

        // Kamar 1
        private void panel1_Click(object sender, EventArgs e)
        {
            if (label4.Text == "FULL")
                gantiMainPanel(new InfoKamar(1));
        }
        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            if (label4.Text == "FULL")
                gantiMainPanel(new InfoKamar(1));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "FULL")
                gantiMainPanel(new InfoKamar(1));
        }

        // Kamar 2
        private void label5_Click_1(object sender, EventArgs e)
        {
            if (label5.Text == "FULL")
                gantiMainPanel(new InfoKamar(2));
        }
        private void guna2TextBox2_Click(object sender, EventArgs e)
        {
            if (label5.Text == "FULL")
                gantiMainPanel(new InfoKamar(2));
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (label5.Text == "FULL")
                gantiMainPanel(new InfoKamar(2));
        }
        // Kamar 3
        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text == "FULL")
                gantiMainPanel(new InfoKamar(3));
        }

        private void guna2TextBox3_Click(object sender, EventArgs e)
        {
            if (label6.Text == "FULL")
                gantiMainPanel(new InfoKamar(3));
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (label6.Text == "FULL")
                gantiMainPanel(new InfoKamar(3));
        }


        // Kamar 4
        private void label7_Click(object sender, EventArgs e)
        {
            if (label7.Text == "FULL")
                gantiMainPanel(new InfoKamar(4));
        }

        private void guna2TextBox4_Click(object sender, EventArgs e)
        {
            if (label7.Text == "FULL")
                gantiMainPanel(new InfoKamar(4));
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (label7.Text == "FULL")
                gantiMainPanel(new InfoKamar(4));
        }
        // Kamar 5
        private void label9_Click(object sender, EventArgs e)
        {
            if (label9.Text == "FULL")
                gantiMainPanel(new InfoKamar(5));
        }

        private void guna2TextBox5_Click(object sender, EventArgs e)
        {
            if (label9.Text == "FULL")
                gantiMainPanel(new InfoKamar(5));
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (label9.Text == "FULL")
                gantiMainPanel(new InfoKamar(5));
        }

        // Kamar 6
        private void label10_Click(object sender, EventArgs e)
        {
            if (label10.Text == "FULL")
                gantiMainPanel(new InfoKamar(6));
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (label10.Text == "FULL")
                gantiMainPanel(new InfoKamar(6));
        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {
            if (label10.Text == "FULL")
                gantiMainPanel(new InfoKamar(6));
        }
        // Kamar 7
        private void label11_Click(object sender, EventArgs e)
        {
            if (label11.Text == "FULL")
                gantiMainPanel(new InfoKamar(7));
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            if (label11.Text == "FULL")
                gantiMainPanel(new InfoKamar(7));
        }

        private void guna2TextBox7_Click(object sender, EventArgs e)
        {
            if (label11.Text == "FULL")
                gantiMainPanel(new InfoKamar(7));
        }
        // Kamar 8
        private void label12_Click(object sender, EventArgs e)
        {
            if (label12.Text == "FULL")
                gantiMainPanel(new InfoKamar(8));
        }

        private void guna2TextBox8_Click(object sender, EventArgs e)
        {
            if (label12.Text == "FULL")
                gantiMainPanel(new InfoKamar(8));
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            if (label12.Text == "FULL")
                gantiMainPanel(new InfoKamar(8));
        }
        // Kamar 9
        private void label13_Click(object sender, EventArgs e)
        {
            if (label13.Text == "FULL")
                gantiMainPanel(new InfoKamar(9));
        }

        private void guna2TextBox9_Click(object sender, EventArgs e)
        {
            if (label13.Text == "FULL")
                gantiMainPanel(new InfoKamar(9));
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            if (label13.Text == "FULL")
                gantiMainPanel(new InfoKamar(9));
        }
        // Kamar 10
        private void label14_Click(object sender, EventArgs e)
        {
            if (label14.Text == "FULL")
                gantiMainPanel(new InfoKamar(10));
        }

        private void guna2TextBox10_Click(object sender, EventArgs e)
        {
            if (label14.Text == "FULL")
                gantiMainPanel(new InfoKamar(10));
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            if (label14.Text == "FULL")
                gantiMainPanel(new InfoKamar(10));
        }
        // Kamar 11
        private void label15_Click(object sender, EventArgs e)
        {
            if (label15.Text == "FULL")
                gantiMainPanel(new InfoKamar(11));
        }

        private void guna2TextBox11_Click(object sender, EventArgs e)
        {
            if (label15.Text == "FULL")
                gantiMainPanel(new InfoKamar(11));
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            if (label15.Text == "FULL")
                gantiMainPanel(new InfoKamar(11));
        }
        // Kamar 12
        private void label16_Click(object sender, EventArgs e)
        {
            if (label16.Text == "FULL")
                gantiMainPanel(new InfoKamar(12));
        }

        private void guna2TextBox12_Click(object sender, EventArgs e)
        {
            if (label16.Text == "FULL")
                gantiMainPanel(new InfoKamar(12));
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            if (label16.Text == "FULL")
                gantiMainPanel(new InfoKamar(12));
        }
        // Kamar 13
        private void label17_Click(object sender, EventArgs e)
        {
            if (label17.Text == "FULL")
                gantiMainPanel(new InfoKamar(13));
        }

        private void guna2TextBox13_Click(object sender, EventArgs e)
        {
            if (label17.Text == "FULL")
                gantiMainPanel(new InfoKamar(13));
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            if (label17.Text == "FULL")
                gantiMainPanel(new InfoKamar(13));
        }
        // Kamar 14
        private void label18_Click(object sender, EventArgs e)
        {
            if (label18.Text == "FULL")
                gantiMainPanel(new InfoKamar(14));
        }

        private void guna2TextBox14_Click(object sender, EventArgs e)
        {
            if (label18.Text == "FULL")
                gantiMainPanel(new InfoKamar(14));
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            if (label18.Text == "FULL")
                gantiMainPanel(new InfoKamar(14));
        }
        // Kamar 15
        private void label19_Click(object sender, EventArgs e)
        {
            if (label19.Text == "FULL")
                gantiMainPanel(new InfoKamar(15));
        }

        private void guna2TextBox15_Click(object sender, EventArgs e)
        {
            if (label19.Text == "FULL")
                gantiMainPanel(new InfoKamar(15));
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            if (label19.Text == "FULL")
                gantiMainPanel(new InfoKamar(15));
        }
        // Kamar 16
        private void label20_Click(object sender, EventArgs e)
        {
            if (label20.Text == "FULL")
                gantiMainPanel(new InfoKamar(16));
        }

        private void guna2TextBox16_Click(object sender, EventArgs e)
        {
            if (label20.Text == "FULL")
                gantiMainPanel(new InfoKamar(16));
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            if (label20.Text == "FULL")
                gantiMainPanel(new InfoKamar(16));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
