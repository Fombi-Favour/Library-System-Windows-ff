﻿using System;
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
    public partial class BookReturned : Form
    {
        public BookReturned()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.lang);
            InitializeComponent();
        }

        public void Display()
        {
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new MenuForm().ShowDialog();
            this.Close();
        }

        private void BookReturned_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GVlist2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                //Edit
                return;
            }
            if(e.ColumnIndex == 2)
            {
                //Delete
                if (Properties.Settings.Default.lang == "en-US")
                {
                    var result = RJMessageBox.Show("Are you sure to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DbBook.DeleteBook(GVlist2.Rows[e.RowIndex].Cells[2].Value.ToString());
                        Display();
                    }
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    var result = RJMessageBox.Show("Êtes-vous sûr de supprimer?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DbBook.DeleteBook(GVlist2.Rows[e.RowIndex].Cells[2].Value.ToString());
                        Display();
                    }
                }
                return;
            }
        }

        private void BookReturned_Load(object sender, EventArgs e)
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
