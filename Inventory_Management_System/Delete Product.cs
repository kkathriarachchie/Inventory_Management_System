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
    public partial class Delete_Product : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\University\Campus Sem 5\ITS 3551 Software Engineering (II)\Project\Inventory_Management_System\Inventory_Management_System\DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        Dashboard dashboard = new Dashboard();
        public Delete_Product(string Product_Name, string Id)
        {
            InitializeComponent();
            txt_productId.Text = Id;
            txt_productName.Text = Product_Name;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_productName.Text != string.Empty)
                {
                    con.Open();

                    cmd = new SqlCommand("select * from [Product] where Id = @id", con);
                    cmd.Parameters.AddWithValue("id", txt_productId.Text);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        if (MessageBox.Show("Do you want to delete ''" + txt_productName.Text + "'' product permanently?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            cmd = new SqlCommand("delete from [Product] where Id = @id", con);
                            cmd.Parameters.AddWithValue("@id", txt_productId.Text);
                            cmd.ExecuteNonQuery();
                            dashboard.display_data();
                            MessageBox.Show($"'{txt_productName.Text}' Product is deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            txt_productId.Clear();
                            txt_productName.Clear();
                        }
                        else
                        {
                            txt_productId.Clear();
                            txt_productName.Clear();
                        }
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("No product avilable with this product name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please enter value in delete field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during delete product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_delete_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_delete.Checked)
            {
                btn_delete.Enabled = true;
            }
            else
            {
                btn_delete.Enabled = false;
            }
        }
    }
}
