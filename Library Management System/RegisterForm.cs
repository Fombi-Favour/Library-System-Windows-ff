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

namespace Library_Management_System
{
    public partial class RegisterForm : Form
    {
        MySqlConnection conn = new MySqlConnection(
            "server = localhost; userid = favour; password = favour; database = library;"
            );
        MySqlCommand cmd;
        string query;
        int result;

        public RegisterForm()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.lang);
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkLblLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            query = "Insert into `users`(`school`, `name`, `password`) values" +
                "('"+txtsch.Text+"' " +
                ",'"+txtuser.Text+"' " +
                ",'"+txtpass.Text+"')";
            if(Properties.Settings.Default.lang == "en-US")
            {
                InsertData(query, "Unable to register");
            }
            else if (Properties.Settings.Default.lang == "fr")
            {
                InsertData(query, "Impossible d'enregistrer");
            }
            Clear();
        }

        private void Clear()
        {
            txtsch.Text = txtuser.Text = txtpass.Text = String.Empty;
        }

        private void InsertData(string query, string msg_false)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    new WelcomeForm().ShowDialog();
                    this.Close();
                }
                else
                {
                    DialogResult result = RJMessageBox.Show(msg_false);
                }
                if (txtsch.Text == "" || txtuser.Text == "" || txtpass.Text == "")
                {
                    if (Properties.Settings.Default.lang == "en-US")
                    {
                        var result = RJMessageBox.Show("Fill in the information", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Properties.Settings.Default.lang == "fr")
                    {
                        var result = RJMessageBox.Show("Remplir des informations", "Manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                var result = RJMessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
