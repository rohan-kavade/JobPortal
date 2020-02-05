using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal.UI.Admin
{
    public partial class ADashboard : Form
    {
        public ADashboard()
        {
            InitializeComponent();
            aHome1.BringToFront();
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f1 = new Home();
            f1.Show();
            LogoutLink.LinkVisited = true;
            this.Hide();
            f1.Closed += (s, args) => this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aChangePass1.BringToFront();
        }

        private void postJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aStudent1.BringToFront();
        }

        private void appliedJobReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aCompany1.BringToFront();
        }
    }
}
