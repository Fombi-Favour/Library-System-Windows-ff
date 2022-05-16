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

namespace Library_Management_System.Forms
{
    public partial class BookIssued : Form
    {
        AddIssueForm form;
        public string id;

        public BookIssued()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.lang); 
            InitializeComponent();
            form = new AddIssueForm(this);
        }

        public void Display()
        {
            DbIssue.DisplayAndSearch("Select StudName, StudClass, BookName, BookID, IssueDate from issue", GVlist1);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuForm().Hide();
        }

        private void BookIssued_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbIssue.DisplayAndSearch("Select StudName, StudClass, BookName, BookID, IssueDate from issue where StudName like '%"+ txtSearch.Text +"%'", GVlist1);
        }

        private void GVlist1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                //Edit
                form.Clear();
                form.studName = GVlist1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.studClass = GVlist1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.bookName = GVlist1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.bookID = GVlist1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.issueDate = GVlist1.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {
                //Delete
                if (Properties.Settings.Default.lang == "en-US")
                {
                    var result = RJMessageBox.Show("Are you sure to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DbIssue.DeleteIssue(GVlist1.Rows[e.RowIndex].Cells[7].Value.ToString());
                        Display();
                    }
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    var result = RJMessageBox.Show("Êtes-vous sûr de supprimer?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DbIssue.DeleteIssue(GVlist1.Rows[e.RowIndex].Cells[7].Value.ToString());
                        Display();
                    }
                }
                return;
            }
            if(e.ColumnIndex == 2)
            {
                //Return
                var result = RJMessageBox.Show("Are you sure to return book?", "Return Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    DbReturn.AddReturn();
                }
                return;
            }
        }

        private void BookIssued_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.lang == "en-US")
            {
                txtSearch.PlaceholderText = "Search";
            }
            else if (Properties.Settings.Default.lang == "fr")
            {
                txtSearch.PlaceholderText = "Chercher";
            }
        }
    }
}
