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
    class DbBook
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

        public static void AddBook(Book bk)
        {
            string sql = "Insert into book values (NULL, @BookID, @BookName, @BookAuthor)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@BookID", MySqlDbType.VarChar).Value = bk.ID;
            cmd.Parameters.Add("@BookName", MySqlDbType.VarChar).Value = bk.Name;
            cmd.Parameters.Add("@BookAuthor", MySqlDbType.VarChar).Value = bk.Author;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Succesfully. \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Book not insert. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateBook(Book bk, string sn)
        {
            string sql = "Update book set ID = @BookID, Name = @BookName, Author = @BookAuthor where sn = @BookSN";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@BookSN", MySqlDbType.VarChar).Value = sn;
            cmd.Parameters.Add("@BookID", MySqlDbType.VarChar).Value = bk.ID;
            cmd.Parameters.Add("@BookName", MySqlDbType.VarChar).Value = bk.Name;
            cmd.Parameters.Add("@BookAuthor", MySqlDbType.VarChar).Value = bk.Author;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Succesfully. \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Book not update. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteBook(string id)
        {
            string sql = "Delete from book where ID = @BookID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@BookID", MySqlDbType.VarChar).Value = id;
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Succesfully. \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Book not delete. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
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
