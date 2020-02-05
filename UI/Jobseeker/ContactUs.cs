using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal.UI.Jobseeker
{
    public partial class ContactUs : Form
    {
        public ContactUs()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f1 = new Home();
            f1.Show();
            homeLink.LinkVisited = true;
            this.Hide();
            f1.Closed += (s, args) => this.Close();
        }
    }
}
