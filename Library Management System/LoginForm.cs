using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Common.Cache;

namespace Library_Management_System
{
    public partial class LoginForm : Form
    {
        MySqlConnection conn = new MySqlConnection(
            "server = localhost; userid = favour; password = favour; database = library;"
            );
        MySqlCommand cmd;
        string query;
        MySqlDataReader reader;

        public LoginForm()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.lang);
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkLblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterForm().ShowDialog();
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            query = "Select * from users where name='"+ txtuser.Text + "' and password='" + txtpass.Text + "' ";
            SelectData(query);
            Clear();
        }

        private void Clear()
        {
            txtuser.Text = txtpass.Text = string.Empty;
        }

        private void SelectData(string query)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserLoginCache.userID = reader.GetInt32(0);
                        UserLoginCache.School = reader.GetString(1);
                        UserLoginCache.UserName = reader.GetString(2);
                        UserLoginCache.Password = reader.GetString(3);

                        new WelcomeForm().ShowDialog();
                        this.Hide();
                    }
                }
                else
                {
                    if(Properties.Settings.Default.lang == "en-US")
                    {
                        var result = RJMessageBox.Show("Unable to log in. Try again!!");
                    }
                    else if (Properties.Settings.Default.lang == "fr")
                    {
                        var result = RJMessageBox.Show("Impossible de se connecter. Essayer à nouveau!!");
                    }
                    conn.Close();
                }
                if (txtuser.Text == "" || txtpass.Text == "")
                {
                    if (Properties.Settings.Default.lang == "en-US")
                    {
                        var result = RJMessageBox.Show("Fill in the information", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if(Properties.Settings.Default.lang == "fr")
                    {
                        var result = RJMessageBox.Show("Remplir des informations", "Manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                var result = RJMessageBox.Show(ex.Message);
            }
        }
    }
}
