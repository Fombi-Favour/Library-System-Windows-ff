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
    public partial class AddIssueForm : Form
    {
        public AddIssueForm()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.lang);
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            txtStudName.Text = txtClass.Text = txtBkName.Text = txtBkid.Text = txtDateIssue.Text = string.Empty;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if(txtStudName.Text.Trim().Length < 3)
            {
                if(Properties.Settings.Default.lang == "en-US")
                {
                    MessageBox.Show("Student name is empty ( > 3).");
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    MessageBox.Show("Nom d'élève est vide ( > 3).");
                }

                return;
            }
            if (txtClass.Text.Trim().Length < 1)
            {
                if(Properties.Settings.Default.lang == "en-US")
                {
                    MessageBox.Show("Student class is empty ( > 1).");
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    MessageBox.Show("Classe d'élève est vide ( > 1).");
                }

                return;
            }
            if (txtBkName.Text.Trim().Length == 0)
            {
                if(Properties.Settings.Default.lang == "en-US")
                {
                    MessageBox.Show("Book name is empty ( > 1).");
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    MessageBox.Show("Nom du livre est vide ( > 1).");
                }

                return;
            }
            if (txtBkid.Text.Trim().Length == 0)
            {
                if(Properties.Settings.Default.lang == "en-US")
                {
                    MessageBox.Show("BookID is empty ( > 1).");
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    MessageBox.Show("LivreID est vide ( > 1).");
                }

                return;
            }
            if (txtDateIssue.Text.Trim().Length == 0)
            {
                if(Properties.Settings.Default.lang == "en-US")
                {
                    MessageBox.Show("Date issue is empty ( > 1).");
                }
                else if (Properties.Settings.Default.lang == "en-US")
                {
                    MessageBox.Show("Date empruntée est vide ( > 1).");
                }

                return;
            }
            if (btnIssue.Text == "SAVE" || btnIssue.Text == "ENREGISTRER")
            {
                Issue iss = new Issue(txtStudName.Text.Trim(), txtClass.Text.Trim(), txtBkName.Text.Trim(), txtBkid.Text.Trim(), txtDateIssue.Value.ToLongDateString());
                DbIssue.AddIssue(iss);
            }
        }
    }
}
