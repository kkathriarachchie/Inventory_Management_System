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
    public partial class Dashboard : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\University\Campus Sem 5\ITS 3551 Software Engineering (II)\Project\Inventory_Management_System\Inventory_Management_System\DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public Dashboard()
        {
            InitializeComponent();
            display_data();
            permissions();
        }

        public void display_data()
        {
            try
            {
                con.Open();

                cmd = new SqlCommand("select * from [Product]", con);
                cmd.ExecuteNonQuery();

                DataTable dta = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dta);
                dtg_product.DataSource = dta;

                lbl_inv_total.Text = "Total Inventory Value : " + CalculateColumnTotal(dtg_product, "Total_Value").ToString();
                lbl_item_quan.Text = "Total Item Quantity : " + CalculateColumnTotal(dtg_product, "Quantity").ToString("#");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during display_data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void permissions()
        {

            if (Login.isAdmin == false)
            {
                btn_addProduct.Enabled = false;
                btn_deleteProduct.Enabled = false;
            }
            else
            {
                btn_addProduct.Enabled = true;
                btn_deleteProduct.Enabled = true;
            }
        }

        public static decimal CalculateColumnTotal(DataGridView dataGridView, string columnName)
        {
            decimal total = 0;
            try
            {
                if (dataGridView.Columns.Contains(columnName))
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (!row.IsNewRow && row.Cells[columnName].Value != null)
                        {
                            if (decimal.TryParse(row.Cells[columnName].Value.ToString(), out decimal cellValue))
                            {
                                total += cellValue;
                            }
                            else
                            {
                                MessageBox.Show($"Value in row {row.Index + 1}, column '{columnName}' is not a valid decimal.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Column '{columnName}' does not exist in the DataGridView.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during CalculateColumnTotal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return total;
        }


        public void display_data(string searchProduct)
        {
            try
            {
                con.Open();

                cmd = new SqlCommand("select * from [Product] where Product_Name = '" + searchProduct + "'", con);
                cmd.ExecuteNonQuery();

                DataTable dta = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dta);
                dtg_product.DataSource = dta;
                lbl_inv_total.Text = "Total Inventory Value : " + CalculateColumnTotal(dtg_product, "Total_Value").ToString();
                lbl_item_quan.Text = "Total Item Quantity : " + CalculateColumnTotal(dtg_product, "Quantity").ToString("#");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during display_data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            Add_Product add_Product = new Add_Product();
            add_Product.ShowDialog();
        }

        private void btn_updateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_product.SelectedRows.Count > 0)
                {

                    DataGridViewRow selectedRow = dtg_product.SelectedRows[0];

                    string Id = selectedRow.Cells["Id"].Value.ToString();
                    string Product_Name = selectedRow.Cells["Product_Name"].Value.ToString();
                    string Unit_Price = selectedRow.Cells["Unit_Price"].Value.ToString();
                    string Quantity = selectedRow.Cells["Quantity"].Value.ToString();
                    string Supplier_Name = selectedRow.Cells["Supplier_Name"].Value.ToString();
                    string Supplier_Phone_Number = selectedRow.Cells["Supplier_Phone_Number"].Value.ToString();

                    if (Id != string.Empty && Product_Name != string.Empty && Unit_Price != string.Empty && Quantity != string.Empty && Supplier_Name != string.Empty && Supplier_Phone_Number != string.Empty)
                    {
                        Update_Product update_Product_bt = new Update_Product(Id, Product_Name, Unit_Price, Quantity, Supplier_Name, Supplier_Phone_Number);
                        update_Product_bt.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Selected row may contain some empty cells.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please select a row before click update product button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during update product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_product.SelectedRows.Count > 0)
                {

                    DataGridViewRow selectedRow = dtg_product.SelectedRows[0];

                    string Id = selectedRow.Cells["Id"].Value.ToString();
                    string Product_Name = selectedRow.Cells["Product_Name"].Value.ToString();

                    if (Product_Name != string.Empty && Id != string.Empty)
                    {
                        Delete_Product delete_Product = new Delete_Product(Product_Name,Id);
                        delete_Product.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Selected row may contain some empty cells.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please select a row before click delete product button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during delete product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_getReport_Click(object sender, EventArgs e)
        {
            Get_Report get_Report = new Get_Report();
            get_Report.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text != string.Empty)
                {
                    con.Open();

                    cmd = new SqlCommand("select * from [Product] where Product_Name='" + txt_search.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        con.Close();
                        display_data(txt_search.Text);
                        txt_search.Clear();

                    }
                    else
                    {
                        dr.Close();
                        con.Close();
                        MessageBox.Show("No Account avilable with this Product name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter product name value in search field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {

            try
            {
                display_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during sycn: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag?.ToString();
                textBox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }
    }
}
