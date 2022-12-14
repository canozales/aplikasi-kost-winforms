using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TubesPBO.Script;
using System.Security.Cryptography;

namespace TubesPBO {
    public partial class LoginForm : Form {

        private MainForm main { get; set; }
        private SQLAdmin admin { get; set; }

        public LoginForm(MainForm x)
        {
            InitializeComponent();
            this.admin = new SQLAdmin();
            this.main = x;
        }

        public static string getHashSha256(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(kotakPassword.Text == "" || kotakUsername.Text == "")
            {
                MessageBox.Show("Username / Password Empty !", "Login Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                string password = getHashSha256(kotakPassword.Text);
                if (admin.accountVerified(kotakUsername.Text, getHashSha256(kotakPassword.Text)))
                {
                    this.Hide();
                    main.Show();
                } else
                {
                    MessageBox.Show("Wrong Username / Password !", "Login Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void kotakPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                guna2GradientButton1.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing)
            {           
                e.Cancel = true;
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
