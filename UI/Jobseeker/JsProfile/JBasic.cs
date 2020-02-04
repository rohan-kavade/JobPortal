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

namespace JobPortal.UI.Jobseeker.JsProfile
{
    public partial class JBasic : UserControl
    {
        public JBasic()
        {
            InitializeComponent();            
        }
        string cs = @"Data Source=DESKTOP-O1T1LH0\SQLEXPRESS;Initial Catalog=jobportal;Integrated Security=True";
        private void JBasic_Load(object sender, EventArgs e)
        {
            label2.Text = Class1.uname;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(cs))
            {
                sqlCon.Open();
               // SqlCommand sqlCmd = new SqlCommand("insert into CompanyDetails (c_name, c_mail, c_password) values(@c_name,@c_mail,@c_password)", sqlCon);
               // sqlCmd.Parameters.AddWithValue("@c_name", txtName.Text.Trim());
               // sqlCmd.Parameters.AddWithValue("@c_mail", txtMail.Text.Trim());
               // sqlCmd.Parameters.AddWithValue("@c_password", txtPass.Text.Trim());
               // sqlCmd.ExecuteNonQuery();
              //  MessageBox.Show("Account Created Successfully");
              //  Clear();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.jobseekerDetailsTableAdapter.FillBy(this.jobportalDataSet.JobseekerDetails, txtMailToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
