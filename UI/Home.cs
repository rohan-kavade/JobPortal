using JobPortal.UI;
using JobPortal.UI.Company;
using JobPortal.UI.Jobseeker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }

        private void jobseekerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegJobseeker RegJ = new RegJobseeker();           
            RegJ.Show();
            this.Hide();
            RegJ.Closed += (s, args) => this.Close();

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogJobseeker LogJ = new LogJobseeker();
            LogJ.Show();
            this.Hide();
            LogJ.Closed += (s, args) => this.Close();
        }

        private void registrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegCompany RegC = new RegCompany();
            RegC.Show();
            this.Hide();
            RegC.Closed += (s, args) => this.Close();
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LogCompany LogC = new LogCompany();
            LogC.Show();
            this.Hide();
            LogC.Closed += (s, args) => this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogAdmin LogA = new LogAdmin();
            LogA.Show();
            this.Hide();
            LogA.Closed += (s, args) => this.Close();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback Fed = new Feedback();
            Fed.Show();
            this.Hide();
            Fed.Closed += (s, args) => this.Close();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactUs Con = new ContactUs();
            Con.Show();
            this.Hide();
            Con.Closed += (s, args) => this.Close();
        }
    }
}
