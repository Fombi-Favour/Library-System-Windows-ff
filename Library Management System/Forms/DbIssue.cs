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
            string sql = "datasource=localhost;port=3306;username=root;password=;database=library; convert zero datetime=true";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                var result = RJMessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        public static void AddIssue(Issue iss)
        {
            string sql = "Insert into issue values (NULL, @IssueStudName, @IssueStudClass, @IssueBookName, @IssueBookID, NULL)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IssueStudName", MySqlDbType.VarChar).Value = iss.StudName;
            cmd.Parameters.Add("@IssueStudClass", MySqlDbType.VarChar).Value = iss.StudClass;
            cmd.Parameters.Add("@IssueBookName", MySqlDbType.VarChar).Value = iss.BookName;
            cmd.Parameters.Add("@IssueBookID", MySqlDbType.VarChar).Value = iss.BookID;
            try
            {
                cmd.ExecuteNonQuery();
                if (Properties.Settings.Default.lang == "en-US")
                {
                    var result = RJMessageBox.Show("Added Succesfully. \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    var result = RJMessageBox.Show("Ajouté avec Succès. \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                if (Properties.Settings.Default.lang == "en-US")
                {
                    var result = RJMessageBox.Show("Book issue not insert. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    var result = RJMessageBox.Show("Livre emprunter pas insérer. \n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }

        public static void UpdateIssue(Issue iss, string id)
        {
            string sql = "Update issue set StudName = @IssueStudName, StudClass = @IssueStudClass, BookName = @IssueBookName where BookID = @IssueBookID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IssueStudName", MySqlDbType.VarChar).Value = iss.StudName;
            cmd.Parameters.Add("@IssueStudClass", MySqlDbType.VarChar).Value = iss.StudClass;
            cmd.Parameters.Add("@IssueBookName", MySqlDbType.VarChar).Value = iss.BookName;
            cmd.Parameters.Add("@IssueBookID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                if (Properties.Settings.Default.lang == "en-US")
                {
                    var result = RJMessageBox.Show("Updated Succesfully. \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    var result = RJMessageBox.Show("Mise à Jour avec Succès. \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                if (Properties.Settings.Default.lang == "en-US")
                {
                    var result = RJMessageBox.Show("Book issue not update. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    var result = RJMessageBox.Show("Livre emprunté non mise à jour. \n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }

        public static void DeleteIssue(string id)
        {
            string sql = "Delete from issue where BookID = @IssueBookID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IssueBookID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                if (Properties.Settings.Default.lang == "en-US")
                {
                    var result = RJMessageBox.Show("Deleted Succesfully. \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    var result = RJMessageBox.Show("Suprimé avec Succès. \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                if (Properties.Settings.Default.lang == "en-US")
                {
                    var result = RJMessageBox.Show("Book issue not delete. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    var result = RJMessageBox.Show("Livre emprunter pas supprimer. \n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
