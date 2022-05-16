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
        private readonly BookIssued _parent;
        public string studName, studClass, bookName, bookID, issueDate;

        public AddIssueForm(BookIssued parent)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.lang);
            InitializeComponent();
            _parent = parent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateInfo()
        {
            if(Properties.Settings.Default.lang == "en-US")
            {
                lblText.Text = "Update Book Issue";
                btnIssue.Text = "UPDATE";
                txtStudName.Text = studName;
                txtClass.Text = studClass;
                txtBkName.Text = bookName;
                txtBkid.Text = bookID;
                DPdate.Text = issueDate;
            }
            else if(Properties.Settings.Default.lang == "fr")
            {
                lblText.Text = "Mettre à Jour le Livre Emprunter";
                btnIssue.Text = "MISE À JOUR";
                txtStudName.Text = studName;
                txtClass.Text = studClass;
                txtBkName.Text = bookName;
                txtBkid.Text = bookID;
                DPdate.Text = issueDate;
            }
        }

        public void Clear()
        {
            txtStudName.Text = txtClass.Text = txtBkName.Text = txtBkid.Text = string.Empty;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if(txtStudName.Text.Trim().Length < 3)
            {
                if(Properties.Settings.Default.lang == "en-US")
                {
                    DialogResult result = RJMessageBox.Show("Student name is empty ( > 3).");
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    DialogResult result = RJMessageBox.Show("Nom d'élève est vide ( > 3).");
                }

                return;
            }
            if (txtClass.Text.Trim().Length < 1)
            {
                if(Properties.Settings.Default.lang == "en-US")
                {
                    DialogResult result = RJMessageBox.Show("Student class is empty ( > 1).");
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    DialogResult result = RJMessageBox.Show("Classe d'élève est vide ( > 1).");
                }

                return;
            }
            if (txtBkName.Text.Trim().Length == 0)
            {
                if(Properties.Settings.Default.lang == "en-US")
                {
                    DialogResult result = RJMessageBox.Show("Book name is empty ( > 1).");
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    DialogResult result = RJMessageBox.Show("Nom du livre est vide ( > 1).");
                }

                return;
            }
            if (txtBkid.Text.Trim().Length == 0)
            {
                if(Properties.Settings.Default.lang == "en-US")
                {
                    DialogResult result = RJMessageBox.Show("BookID is empty ( > 1).");
                }
                else if (Properties.Settings.Default.lang == "fr")
                {
                    DialogResult result = RJMessageBox.Show("LivreID est vide ( > 1).");
                }

                return;
            }

            if(btnIssue.Text == "SAVE" || btnIssue.Text == "ENREGISTRER")
            {
                Issue iss = new Issue(txtStudName.Text.Trim(), txtClass.Text.Trim(), txtBkName.Text.Trim(), txtBkid.Text.Trim(), DPdate.Value);
                DbIssue.AddIssue(iss);
                Clear();
            }
            if(btnIssue.Text == "UPDATE" || btnIssue.Text == "MISE À JOUR")
            {
                Issue iss = new Issue(txtStudName.Text.Trim(), txtClass.Text.Trim(), txtBkName.Text.Trim(), txtBkid.Text.Trim(), DPdate.Value);
                DbIssue.UpdateIssue(iss);
                this.Hide();
            }
            _parent.Display();
        }
    }
}
