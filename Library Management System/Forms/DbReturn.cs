using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Forms
{
    class DbReturn
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=library;";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        public static void AddReturn(Issue iss, Return ret)
        {
            string sql = "Insert ignore into breturn(@ReturnStudName, @ReturnStudClass, @ReturnBookName, @ReturnBookID, @ReturnIssueDate) select @IssueStudName, @IssueStudClass, @IssueBookName, @IssueBookID, @IssueIssueDate from issue";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ReturnStudentName", MySqlDbType.VarChar).Value = ret.StudName;
            cmd.Parameters.Add("@ReturnStudentClass", MySqlDbType.VarChar).Value = ret.StudClass;
            cmd.Parameters.Add("@ReturnBookName", MySqlDbType.VarChar).Value = ret.BookName;
            cmd.Parameters.Add("@ReturnBookID", MySqlDbType.VarChar).Value = ret.BookID;
            cmd.Parameters.Add("@ReturnIssueDate", MySqlDbType.Date).Value = ret.IssueDate;
            try
            {
                cmd.ExecuteNonQuery();
                var result = RJMessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                var result = RJMessageBox.Show("Book return not insert. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();
        }

        
    }
}
