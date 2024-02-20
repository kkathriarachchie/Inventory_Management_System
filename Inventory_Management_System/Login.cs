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

namespace Inventory_Management_System
{

    public partial class Login : Form
    {

        public static bool isAdmin = false;

        public static string send_userUsername = "";
        public static string send_adminUsername = "";

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\University\Campus Sem 5\ITS 3551 Software Engineering (II)\Project\Inventory_Management_System\Inventory_Management_System\DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_admLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                if (txt_admUsername.Text != string.Empty && txt_admPassword.Text != string.Empty)
                {
                    cmd = new SqlCommand("select * from [admDetails] where Adm_Username='" + txt_admUsername.Text + "' and Adm_Password='" + txt_admPassword.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        send_adminUsername = txt_admUsername.Text;
                        isAdmin = true;
                        txt_admUsername.Clear();
                        txt_admPassword.Clear();
                        Dashboard dashboard = new Dashboard();
                        dashboard.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("No Account avilable with this admin username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter values in the admin username and admin password fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("An error occurred during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_usreLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (txt_userUsername.Text != string.Empty && txt_userPassword.Text != string.Empty)
                {

                    cmd = new SqlCommand("select * from [userDetails] where Username='" + txt_userUsername.Text + "' and Password='" + txt_userPassword.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        isAdmin = false;
                        send_userUsername = txt_userUsername.Text;

                        txt_userUsername.Clear();
                        txt_userPassword.Clear();

                        Dashboard dashboard = new Dashboard();
                        dashboard.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("No Account avilable with this username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter values in the username and password fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("An error occurred during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_signup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void chk_user_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_user_showPassword.Checked)
            {
                txt_userPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txt_userPassword.UseSystemPasswordChar = true;
            }
        }

        private void chk_adm_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_adm_showPassword.Checked)
            {
                txt_admPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txt_admPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
