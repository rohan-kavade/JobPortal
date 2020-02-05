using JobPortal.UI.Jobseeker;
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

namespace JobPortal.UI.Company
{
    public partial class RegCompany : Form
    {
        public RegCompany()
        {
            InitializeComponent();
        }
       static string connectionSting = ConfigurationManager.ConnectionStrings["JobPortal.Properties.Settings.cs"].ConnectionString;
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

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtMail.Text == "" || txtPass.Text == "" || txtPassCon.Text == "")
                MessageBox.Show("Please fill all Mandatory fields");
            else if (txtPass.Text != txtPassCon.Text)
                MessageBox.Show("Password do not match");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionSting))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("insert into CompanyDetails (c_name, c_mail, c_password) values(@c_name,@c_mail,@c_password)", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@c_name", txtName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@c_mail", txtMail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@c_password", txtPass.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Clear();
                }
                Form f2 = new LogCompany();
                f2.Show();
                this.Hide();
                f2.Closed += (s, args) => this.Close();
            }
            void Clear()
            {
                txtName.Text = txtMail.Text = txtPass.Text = txtPassCon.Text = "";
            }
        }
    }
}
