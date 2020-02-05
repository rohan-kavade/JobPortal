using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal.UI.Jobseeker
{
    public partial class JProfile : UserControl
    {
        public JProfile()
        {
            InitializeComponent();
            jpHome1.BringToFront();
        }

        private void basicDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            jBasic1.BringToFront();
        }

        private void personalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jPersonal1.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            jpHome1.BringToFront();
        }

        private void highSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            j10th1.BringToFront();
        }

        private void add12thToolStripMenuItem_Click(object sender, EventArgs e)
        {
            j12th1.BringToFront();
        }

        private void diplomaGraduateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jug1.BringToFront();
        }

        private void pGMastersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jpg1.BringToFront();
        }

        private void employmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jxp1.BringToFront();
        }

        private void addResumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jRes1.BringToFront();
        }
    }
}
