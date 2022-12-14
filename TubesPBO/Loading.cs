using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubesPBO
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        MainForm main;
        private void Loading_Load(object sender, EventArgs e)
        {
            main = new MainForm();
            timer1.Start();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            guna2CircleProgressBar1.Increment(2);
            if (startpoint > 50)
            {
                LoginForm login = new LoginForm(main);

                timer1.Stop();
                this.Hide();
                login.Show();
            }
        }

        private void Loading_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
