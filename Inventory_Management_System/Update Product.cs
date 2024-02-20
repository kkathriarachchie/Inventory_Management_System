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
    public partial class Update_Product : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\University\Campus Sem 5\ITS 3551 Software Engineering (II)\Project\Inventory_Management_System\Inventory_Management_System\DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        Dashboard dashboard = new Dashboard();

        private int current_quantityValue = 0;


        public Update_Product(string send_Id, string send_Product_Name, string send_Unit_Price, string send_Quantity, string send_Supplier_Name, string send_Supplier_Phone_Number)
        {
           

            InitializeComponent();
            txt_productId.Text = send_Id;
            txt_productName.Text = send_Product_Name;
            txt_unitPrice.Text = send_Unit_Price;
            txt_productQuantity.Text = send_Quantity;
            txt_supplierName.Text = send_Supplier_Name;
            txt_supplierPhone_number.Text = send_Supplier_Phone_Number;
            permissions();

        }


        public void permissions()
        {

            if (Login.isAdmin == false)
            {
                txt_productId.Enabled = false;
                txt_productName.Enabled = false;
                txt_supplierName.Enabled = false;
                txt_supplierPhone_number.Enabled = false;
                txt_unitPrice.Enabled = false;
            }
            else
            {
                txt_productId.Enabled = true;
                txt_productName.Enabled = true;
                txt_supplierName.Enabled = true;
                txt_supplierPhone_number.Enabled = true;
                txt_unitPrice.Enabled = true;
            }

        }

        private void btn_updateProduct_Click(object sender, EventArgs e)
        {

            con.Open();

            if (txt_productName.Text != string.Empty && txt_unitPrice.Text != string.Empty && txt_productQuantity.Text != string.Empty)
            {

                double totalVal = Double.Parse(txt_unitPrice.Text) * Double.Parse(txt_productQuantity.Text);

                cmd = new SqlCommand("update [Product] set Product_Name =@proName, Unit_Price = @unitPrice, Quantity = @quantity, Total_Value = @totValue, Supplier_Name = @supName, Supplier_Phone_Number = @supPhone  where Id = @id", con);
                cmd.Parameters.AddWithValue("@proName", txt_productName.Text);
                cmd.Parameters.AddWithValue("@unitPrice", txt_unitPrice.Text);
                cmd.Parameters.AddWithValue("@quantity", txt_productQuantity.Text);
                cmd.Parameters.AddWithValue("@supName", txt_supplierName.Text);
                cmd.Parameters.AddWithValue("@supPhone", txt_supplierPhone_number.Text);
                cmd.Parameters.AddWithValue("@totValue", totalVal.ToString());
                cmd.Parameters.AddWithValue("@id", txt_productId.Text);
                cmd.ExecuteNonQuery();
                dashboard.display_data();
                

                MessageBox.Show("Product details updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void btn_Increase_Click(object sender, EventArgs e)
        {
            current_quantityValue = int.Parse(txt_productQuantity.Text);
            current_quantityValue++;
            txt_productQuantity.Text = current_quantityValue.ToString();
        }

        private void btn_decrease_Click(object sender, EventArgs e)
        {
            current_quantityValue = int.Parse(txt_productQuantity.Text);
            current_quantityValue--;
            txt_productQuantity.Text = current_quantityValue.ToString();
        }
    }
}
