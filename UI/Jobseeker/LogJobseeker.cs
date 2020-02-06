using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace JobPortal.UI.Jobseeker
{
    public partial class LogJobseeker : Form
    {
        public LogJobseeker()
        {
            InitializeComponent();
        }
        static string cs = ConfigurationManager.ConnectionStrings["JobPortal.Properties.Settings.cs"].ConnectionString;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Class1.uname = txtMail.Text;

            if (txtMail.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from JobseekerDetails where j_mail=@j_mail and j_password=@j_password", con);
                cmd.Parameters.AddWithValue("@j_mail", txtMail.Text);
                cmd.Parameters.AddWithValue("@j_password", txtPass.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    Form f2 = new JDashboard();
                    f2.Show();
                    homeLink.LinkVisited = true;
                    this.Hide();
                    f2.Closed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
