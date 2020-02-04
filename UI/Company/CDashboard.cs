using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal.UI.Company
{
    public partial class CDashboard : Form
    {
        public CDashboard()
        {
            InitializeComponent();
            cHome1.BringToFront();
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f1 = new Home();
            f1.Show();
            LogoutLink.LinkVisited = true;
            this.Hide();
            f1.Closed += (s, args) => this.Close();
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cProfile1.BringToFront();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cChangePass1.BringToFront();
        }

        private void postJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            postJob1.BringToFront();
        }

        private void appliedJobReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cApplied1.BringToFront();
        }
    }
}
