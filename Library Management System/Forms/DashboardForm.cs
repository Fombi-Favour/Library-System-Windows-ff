using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Management_System.Forms
{
    public partial class DashboardForm : Form
    {
        MySqlConnection conn = new MySqlConnection(
            "server = localhost; userid = favour; password = favour; database = library;"
            );
        public DashboardForm()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.lang);
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnAbt_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            conn.Open();
            //Counting books
            MySqlDataAdapter adp = new MySqlDataAdapter("Select count(*) from book", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            lblBooks.Text = dt.Rows[0][0].ToString();
            //Counting students
            MySqlDataAdapter adp1 = new MySqlDataAdapter("Select count(StudName) from Issue ", conn);
            DataTable dt1 = new DataTable();
            adp1.Fill(dt1);
            lblStudents.Text = dt1.Rows[0][0].ToString();
            //Counting Issue books
            MySqlDataAdapter adp2 = new MySqlDataAdapter("Select count(*) from Issue", conn);
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2);
            lblIssue.Text = dt2.Rows[0][0].ToString();
            //Counting Return books
            MySqlDataAdapter adp3 = new MySqlDataAdapter("Select count(*) from breturn", conn);
            DataTable dt3 = new DataTable();
            adp3.Fill(dt3);
            lblreturn.Text = dt3.Rows[0][0].ToString();
            conn.Close();
        }
    }
}
