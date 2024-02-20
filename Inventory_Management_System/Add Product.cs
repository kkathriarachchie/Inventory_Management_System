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
    public partial class Add_Product : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\University\Campus Sem 5\ITS 3551 Software Engineering (II)\Project\Inventory_Management_System\Inventory_Management_System\DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        Dashboard dashboard = new Dashboard();

        public Add_Product()
        {
            InitializeComponent();
            
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {

            con.Open();

            if (txt_productName.Text != string.Empty && txt_unitPrice.Text != string.Empty && txt_quantity.Text != string.Empty && txt_supplierName.Text != string.Empty)
            {

                try
                {
                    cmd = new SqlCommand("select * from [Product] where Product_Name='" + txt_productName.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Product Name already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        string phoneNumber = new string(txt_supplierPhone_number.Text.Where(char.IsDigit).ToArray());

                        if (phoneNumber.Length == 10)
                        {
                            txt_supplierPhone_number.ForeColor = System.Drawing.Color.Black;
                            cmd = new SqlCommand("insert into [Product] (Product_Name,Unit_Price,Quantity,Supplier_Name,Supplier_Phone_Number,Total_Value) values(@proName,@unitPrice,@quantity,@supName,@supPhone,@totValue)", con);
                            cmd.Parameters.AddWithValue("proName", txt_productName.Text);
                            cmd.Parameters.AddWithValue("unitPrice", txt_unitPrice.Text);
                            cmd.Parameters.AddWithValue("quantity", txt_quantity.Text);
                            cmd.Parameters.AddWithValue("supName", txt_supplierName.Text);
                            cmd.Parameters.AddWithValue("supPhone", txt_supplierPhone_number.Text);

                            double totalVal = Double.Parse(txt_unitPrice.Text) * Double.Parse(txt_quantity.Text);

                            cmd.Parameters.AddWithValue("totValue", totalVal.ToString("#.##"));
                            cmd.ExecuteNonQuery();
                            dashboard.display_data();
                            MessageBox.Show("Data successfully inserted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            txt_supplierPhone_number.ForeColor = System.Drawing.Color.Red;
                            MessageBox.Show("Invalid phone number. Please enter 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during add product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
