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
    class DbIssue
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=library";
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

        public static void AddIssue(Issue iss)
        {
            string sql = "Insert into issue_return values (NULL, @IssueStudName, @IssueStudClass, @IssueBookName, @IssueBookID, @IssueIssueDate, NULL)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IssueStudName", MySqlDbType.VarChar).Value = iss.StudName;
            cmd.Parameters.Add("@IssueStudClass", MySqlDbType.VarChar).Value = iss.StudClass;
            cmd.Parameters.Add("@IssueBookName", MySqlDbType.VarChar).Value = iss.BookName;
            cmd.Parameters.Add("@IssueBookID", MySqlDbType.VarChar).Value = iss.BookID;
            cmd.Parameters.Add("@IssueIssueDate", MySqlDbType.Date).Value = iss.IssueDate;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Issue book not insert.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void UpdateIssue(Issue iss, string id)
        {
            string sql = "Update issue_return set StudName = @IssueStudName, StudClass = @IssueStudClass, BookName = @IssueBookName, IssueDate = @IssueIssueDate where BookID = @IssueBookID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IssueStudName", MySqlDbType.VarChar).Value = iss.StudName;
            cmd.Parameters.Add("@IssueStudClass", MySqlDbType.VarChar).Value = iss.StudClass;
            cmd.Parameters.Add("@IssueBookName", MySqlDbType.VarChar).Value = iss.BookName;
            cmd.Parameters.Add("@IssueBookID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@IssueIssueDate", MySqlDbType.Date).Value = iss.IssueDate;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Issue book not update. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void DeleteIssue(string id)
        {
            string sql = "Delete from issue_return where BookID = @IssueBookID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IssueBookID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Issue book not delete. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();
        }
    }
}
