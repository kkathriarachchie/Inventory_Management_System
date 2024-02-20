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
    public partial class SignUp : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\University\Campus Sem 5\ITS 3551 Software Engineering (II)\Project\Inventory_Management_System\Inventory_Management_System\DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                if (txt_address.Text != string.Empty && txt_confim_password.Text != string.Empty && txt_email.Text != string.Empty && txt_name.Text != string.Empty && txt_password.Text != string.Empty && txt_username.Text != string.Empty)
                {

                    string password = txt_password.Text;
                    int passwordLength = password.Length;

                    if (passwordLength >= 8 && passwordLength <= 12)
                    {
                        if (txt_password.Text == txt_confim_password.Text)
                        {
                            cmd = new SqlCommand("select * from [userDetails] where Username='" + txt_username.Text + "'", con);
                            dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                dr.Close();
                                MessageBox.Show("Username already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                dr.Close();
                                cmd = new SqlCommand("insert into [userDetails] (Username,Name,Email,Address,Password) values(@username,@name,@email,@address,@password)", con);
                                cmd.Parameters.AddWithValue("username", txt_username.Text);
                                cmd.Parameters.AddWithValue("name", txt_name.Text);
                                cmd.Parameters.AddWithValue("email", txt_email.Text);
                                cmd.Parameters.AddWithValue("address", txt_address.Text);
                                cmd.Parameters.AddWithValue("password", txt_password.Text);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Your account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter both password same. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password must be 8 to 12 characters.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("An error occurred during signup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_show_password.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
                txt_confim_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                txt_confim_password.UseSystemPasswordChar = true;
            }
        }
    }
}
