using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal.UI.Company
{
    public partial class CProfile: UserControl
    {
        public CProfile()
        {
            InitializeComponent();
            cmHome1.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            cmHome1.BringToFront();
        }

        private void basicDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cBasic1.BringToFront();
        }

        private void cBasic1_Load(object sender, EventArgs e)
        {

        }
    }
}
