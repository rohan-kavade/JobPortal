using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using JobPortal.UI.Jobseeker;

namespace JobPortal.UI.Company
{
    public partial class LogCompany : Form
    {
        public LogCompany()
        {
            InitializeComponent();
        }
       
    static string cs = ConfigurationManager.ConnectionStrings["JobPortal.Properties.Settings.cs"].ConnectionString;
   
    private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

            Form f1 = new CDashboard();
            f1.Show();            
            this.Hide();
            f1.Closed += (s, args) => this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label.uname = txtMail.Text;
            if (txtMail.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from CompanyDetails where c_mail=@c_mail and c_password=@c_password", con);
                cmd.Parameters.AddWithValue("@c_mail", txtMail.Text);
                cmd.Parameters.AddWithValue("@c_password", txtPass.Text);
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
                    Form f1 = new CDashboard();
                    f1.Show();
                    linkLabel1.LinkVisited = true;
                    this.Hide();
                    f1.Closed += (s, args) => this.Close();
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
        
        private void homeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f2 = new Home();
            f2.Show();
            homeLink.LinkVisited = true;
            this.Hide();
            f2.Closed += (s, args) => this.Close();
        }
    }
}
