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
        public BookForm()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.lang);
            InitializeComponent();
        }

        public void Display()
        {
            DbBooks.DisplayAndSearch("Select ID, name, author from books", GVlist);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new AddBookForm(this).ShowDialog();
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
    }
}
