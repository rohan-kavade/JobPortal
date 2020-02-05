using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using JobPortal.UI.Jobseeker;

namespace JobPortal.UI.Company
{
    public partial class CChangePass : UserControl
    {
        public CChangePass()
        {
            InitializeComponent();
        }
        static string cs = ConfigurationManager.ConnectionStrings["JobPortal.Properties.Settings.cs"].ConnectionString;

        private void updateLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (txtPass.Text != txtPassCon.Text)
            {
                MessageBox.Show("Password do not match");
                con.Close();
            }
            else
            {
                cmd.CommandText = "update CompanyDetails set c_password ='" + txtPassCon.Text + "' where c_mail = '" + lblUser.Text + "' ";
                cmd.ExecuteNonQuery();
                con.Close();
                Clear();
                MessageBox.Show("Password Updated");
                Clear();
            }

            void Clear()
            {
                txtPass.Text = txtPassCon.Text = "";
            }
        }

        private void CChangePass_Load(object sender, EventArgs e)
        {
            lblUser.Text = label.uname;
        }
    }
}
