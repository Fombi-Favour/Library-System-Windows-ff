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
            if(Properties.Settings.Default.lang == "en-US")
            {
                lblText.Text = "Update Book";
                btnSave.Text = "UPDATE";
                txtBkid.Text = iD;
                txtBkname.Text = name;
                txtBkauthor.Text = author;
            }
            else if (Properties.Settings.Default.lang == "fr")
            {
                lblText.Text = "Livre de Mise à Jour";
                btnSave.Text = "MISE À JOUR";
                txtBkid.Text = iD;
                txtBkname.Text = name;
                txtBkauthor.Text = author;
            }
        }

        public void Clear()
        {
            txtBkid.Text = txtBkname.Text = txtBkauthor.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtBkid.Text.Trim().Length < 3)
            {
                if(Properties.Settings.Default.lang == "en-US")
                {
                    DialogResult result = RJMessageBox.Show("BookID is empty ( > 3).");
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    DialogResult result = RJMessageBox.Show("LivreID est vide ( > 3).");
                }

                return;
            }
            if(txtBkname.Text.Trim().Length < 1)
            {
                if(Properties.Settings.Default.lang == "en-US")
                {
                    DialogResult result = RJMessageBox.Show("Book name is empty ( < 1).");
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    DialogResult result = RJMessageBox.Show("Nom du livre est vide ( < 1).");
                }

                return;
            }
            if(txtBkauthor.Text.Trim().Length == 0)
            {
                if(Properties.Settings.Default.lang == "en-US")
                {
                    DialogResult result = RJMessageBox.Show("Book author is empty ( > 1).");
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    DialogResult result = RJMessageBox.Show("L'auteur du livre est vide ( > 1).");
                }

                return;
            }
            if(btnSave.Text == "SAVE" || btnSave.Text == "ENREGISTRER")
            {
                Book bk = new Book(txtBkid.Text.Trim(), txtBkname.Text.Trim(), txtBkauthor.Text.Trim());
                DbBook.AddBook(bk);
                Clear();
            }
            if(btnSave.Text == "UPDATE" || btnSave.Text == "MISE À JOUR")
            {
                Book bk = new Book(txtBkid.Text.Trim(), txtBkname.Text.Trim(), txtBkauthor.Text.Trim());
                DbBook.UpdateBook(bk, iD);
            }
            _parent.Display();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
