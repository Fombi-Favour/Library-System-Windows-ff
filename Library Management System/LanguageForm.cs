using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class LanguageForm : Form
    {
        public LanguageForm()
        {
            InitializeComponent();
        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.lang = "en-US";
            this.Hide();
            new loadingForm().ShowDialog();
        }

        private void btnFr_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.lang = "fr";
            this.Hide();
            new loadingForm().ShowDialog();
        }
    }
}
