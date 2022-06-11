using POS_App.General;
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
using POS_App.Screens;

namespace POS_App
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                /*string constr = app_settings.ConnectionString();
                MessageBox.Show(constr);*/
                SqlConnection con = new SqlConnection(App_settings.ConnectionString());
                con.Open();
                SqlCommand cmd = new SqlCommand("verify_user_login", con);

                cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userid", IDTextbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", passwordTextbox.Text.Trim());
                try
                {
                    
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        //MessageBox.Show("Login Successful...");
                        this.Hide();
                        Dashborad df = new Dashborad();
                        df.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Creditenials!", "Failed to login...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Exception");
                }

            }
        }

        private bool isvalid()
        {
            if (IDTextbox.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Enter a valid User ID", "Enter Again...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (passwordTextbox.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Enter the correct password", "Enter Again...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
