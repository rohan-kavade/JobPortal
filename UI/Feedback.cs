using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal.UI
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void homeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f1 = new Home();
            f1.Show();
            homeLink.LinkVisited = true;
            this.Hide();
            f1.Closed += (s, args) => this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
