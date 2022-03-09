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
    public partial class AddBookForm : Form
    {
        private readonly BookForm _parent;
        public string iD, name, author, sn;

        public AddBookForm(BookForm parent)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.lang);
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            lblText.Text = "Update Book";
            btnSave.Text = "UPDATE";
            txtBkid.Text = iD;
            txtBkname.Text = name;
            txtBkauthor.Text = author;
        }

        public void Clear()
        {
            txtBkid.Text = txtBkname.Text = txtBkauthor.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtBkid.Text.Trim().Length < 3)
            {
                MessageBox.Show("BookID is empty ( > 3).");
                return;
            }
            if(txtBkname.Text.Trim().Length < 1)
            {
                MessageBox.Show("Book name is empty ( < 1).");
                return;
            }
            if(txtBkauthor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Book author is empty ( > 1).");
                return;
            }
            if(btnSave.Text == "SAVE")
            {
                Book bk = new Book(txtBkid.Text.Trim(), txtBkname.Text.Trim(), txtBkauthor.Text.Trim());
                DbBook.AddBook(bk);
                Clear();
            }
            if(btnSave.Text == "UPDATE")
            {
                Book bk = new Book(txtBkid.Text.Trim(), txtBkname.Text.Trim(), txtBkauthor.Text.Trim());
                DbBook.UpdateBook(bk, sn);
            }
            _parent.Display();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
