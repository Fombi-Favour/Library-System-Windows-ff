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
    public partial class BookForm : Form
    {
        AddBookForm form;

        public BookForm()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.lang);
            InitializeComponent();
            form = new AddBookForm(this);
        }

        public void Display()
        {
            DbBook.DisplayAndSearch("Select ID, Name, Author from book", GVlist);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }

        private void BookForm_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new MenuForm().ShowDialog();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbBook.DisplayAndSearch("Select ID, Name, Author from book where Name like '%"+ txtSearch.Text +"%'", GVlist);
        }

        private void GVlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                //Edit
                form.Clear();
                form.iD = GVlist.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.name = GVlist.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.author = GVlist.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {
                //Delete
                if(Properties.Settings.Default.lang == "en-US")
                {
                    var result = RJMessageBox.Show("Are you sure to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if ( result == DialogResult.Yes)
                    {
                        DbBook.DeleteBook(GVlist.Rows[e.RowIndex].Cells[2].Value.ToString());
                        Display();
                    }
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    var result = RJMessageBox.Show("Êtes-vous sûr de supprimer?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DbBook.DeleteBook(GVlist.Rows[e.RowIndex].Cells[2].Value.ToString());
                        Display();
                    }
                }
                return;
            }
        }

        private void BookForm_Load(object sender, EventArgs e)
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
