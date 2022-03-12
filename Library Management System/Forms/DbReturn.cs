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

        public static void AddReturn(Return ret)
        {
            string sql = "Insert into breturn values(NULL, @ReturnStudName, @ReturnStudClass, @ReturnBookName, @ReturnBookID, @ReturnIssueDate, NULL)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ReturnStudName", MySqlDbType.VarChar).Value = ret.StudName;
            cmd.Parameters.Add("@ReturnStudClass", MySqlDbType.VarChar).Value = ret.StudClass;
            cmd.Parameters.Add("@ReturnBookName", MySqlDbType.VarChar).Value = ret.BookName;
            cmd.Parameters.Add("@ReturnBookID", MySqlDbType.VarChar).Value = ret.BookID;
            cmd.Parameters.Add("@ReturnIssueDate", MySqlDbType.VarChar).Value = ret.IssueDate;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Book return not insert. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
