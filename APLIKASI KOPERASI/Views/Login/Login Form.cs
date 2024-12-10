using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using APLIKASI_KOPERASI.Properties;

using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APLIKASI_KOPERASI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(66, 145, 66); // Darker green
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(76, 175, 80); // Original green
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validasi Login
            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login Berhasil!", "Selamat Datang", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Berpindah ke MainForm setelah login berhasil
                Main_Form mainForm = new Main_Form();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(19, 94, 143), Color.FromArgb(20, 147, 227), 45F);
            Graphics g = this.CreateGraphics();
            g.FillRectangle(brush, this.ClientRectangle);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
