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

namespace Project
{
    public partial class SellerInvMgmt : Form
    {
        public SellerInvMgmt()
        {
            InitializeComponent();
        }

        private void InvMgmt_Load(object sender, EventArgs e)
        {
            BindCategories(); // Load categories into ComboBox
            BindData();       // Load product data into DataGridView
        }

        // Load categories into ComboBox
        private void BindCategories()
        {
            try
            {
                con.Open();

                // Query to fetch all categories
                string query = "SELECT CategoryID, Name FROM Category";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                da.Fill(dt);

                // Bind the DataTable to the ComboBox
                CategoryComboBox.DataSource = dt;
                CategoryComboBox.DisplayMember = "Name";
                CategoryComboBox.ValueMember = "CategoryID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading categories: " + ex.Message);
            }
            finally
            {
                con.Close(); 
            }
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Products (CategoryID, Name, Description, Price, StockQ) VALUES (@CategoryID, @Name, @Description, @Price, @StockQ)";
                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@CategoryID", CategoryComboBox.SelectedValue);
                command.Parameters.AddWithValue("@Name", NameTxt.Text);
                command.Parameters.AddWithValue("@Description", DescTxt.Text);
                command.Parameters.AddWithValue("@Price", decimal.Parse(PriceTxt.Text));
                command.Parameters.AddWithValue("@StockQ", int.Parse(StTxt.Text));

                // Execute the query
                command.ExecuteNonQuery();

                MessageBox.Show("Product added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
                BindData();
            }
        }
        void BindData()
        {
            try
            {
                con.Open();

                string query = @"
            SELECT P.ProductID, 
                   P.Name AS [Product Name], 
                   C.Name AS [Category], 
                   P.Description, 
                   P.Price, 
                   P.StockQ as Stock
            FROM Products P
            JOIN Category C ON P.CategoryID = C.CategoryID";

                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoryTableAdapter.FillBy(this.projectDataSet.Category);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void UpdateButt_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a product to update.");
                    return;
                }

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);

                int categoryId = Convert.ToInt32(CategoryComboBox.SelectedValue);
                string name = NameTxt.Text;
                string description = DescTxt.Text;
                decimal price = decimal.Parse(PriceTxt.Text);
                int stockQ = int.Parse(StTxt.Text);

                string query = "UPDATE Products SET CategoryID = @CategoryID, Name = @Name, Description = @Description, Price = @Price, StockQ = @StockQ WHERE ProductID = @ProductID";

                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
                {
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@StockQ", stockQ);
                    command.Parameters.AddWithValue("@ProductID", productId);

                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product updated successfully.");
                        BindData();
                    }
                    else
                    {
                        MessageBox.Show("No rows were updated. Please check the product ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the product: " + ex.Message);
            }
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a product to delete.");
                    return;
                }

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }

                string query = "DELETE FROM Products WHERE ProductID = @ProductID";

                using (SqlConnection con = new SqlConnection("Server=DESKTOP-A8PIF3V;Database=Project;Trusted_Connection=True;"))
                {
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@ProductID", productId);

                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product deleted successfully.");
                        BindData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the product. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the product: " + ex.Message);
            }
        }


        private void SearchButt_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = SearchTxt.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Please enter a search term.");
                    return;
                }

                string query = "SELECT * FROM Products WHERE Name LIKE @Keyword OR Description LIKE @Keyword";

                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
                {
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No products found matching the search term.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellerInterface SellerForm = new SellerInterface();
            SellerForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void StTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
