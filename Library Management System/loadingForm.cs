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

namespace Library_Management_System
{
    public partial class loadingForm : Form
    {
        public loadingForm()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.lang);
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar.Value += 1;
            if(ProgressBar.Value == 100)
            {
                timer1.Stop();
            }
        }

        private void loadingForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
