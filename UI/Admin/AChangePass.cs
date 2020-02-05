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
using JobPortal.UI.Admin;

namespace JobPortal.UI.Admin
{
    public partial class AChangePass : UserControl
    {
        public AChangePass()
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
                cmd.CommandText = "update AdminDetails set a_password ='" + txtPassCon.Text + "' where a_mail = '" + lblUser.Text + "' ";
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
        
        private void AChangePass_Load_1(object sender, EventArgs e)
        {
            lblUser.Text = label.uname;
        }
    }
}
