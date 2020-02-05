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
    public partial class JDashboard : Form
    {
        public JDashboard()
        {
            InitializeComponent();
            jHome1.BringToFront();
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
            jProfile1.BringToFront();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jChangePass1.BringToFront();
        }

        private void postJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applyJob1.BringToFront();
        }

        private void appliedJobReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jApplied1.BringToFront();
        }

        private void JDashboard_Load(object sender, EventArgs e)
        {
           label3.Text = Class1.uname;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
