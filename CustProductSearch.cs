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
    public partial class CustProductSearch : Form
    {
        

        public CustProductSearch()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server=DESKTOP-A8PIF3V;Database=Project;Trusted_Connection=True");

        private void ProductSearch_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
        }

        private void LoadCategories()
        {
            try
            {
                con.Open();

                string query = "SELECT CategoryID, Name FROM Category";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow newRow = dt.NewRow();
                newRow["CategoryID"] = DBNull.Value;
                newRow["Name"] = "All Categories";
                dt.Rows.InsertAt(newRow, 0);

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

        private void LoadProducts()
        {
            try
            {
                con.Open();

                string query = @"
            SELECT P.ProductID, P.Name, P.Description, P.Price, C.Name AS CategoryName
            FROM Products P
            JOIN Category C ON P.CategoryID = C.CategoryID";

                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Bind data to the grid view
                ProductsGridView.DataSource = dt;

                // Check if the "AddToCart" button column exists, if not add it
                if (!ProductsGridView.Columns.Contains("AddToCart"))
                {
                    DataGridViewButtonColumn addButtonColumn = new DataGridViewButtonColumn();
                    addButtonColumn.HeaderText = "Add to Cart";
                    addButtonColumn.Text = "Add";
                    addButtonColumn.Name = "AddToCart"; // Set the name of the column
                    addButtonColumn.UseColumnTextForButtonValue = true;
                    ProductsGridView.Columns.Add(addButtonColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading products: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void SearchButt_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = @"
                    SELECT P.ProductID, P.Name, P.Description, P.Price, C.Name AS CategoryName
                    FROM Products P
                    JOIN Category C ON P.CategoryID = C.CategoryID
                    WHERE (@SearchKeyword IS NULL OR P.Name LIKE '%' + @SearchKeyword + '%')
                      AND (@CategoryID IS NULL OR P.CategoryID = @CategoryID)
                      AND (@MinPrice IS NULL OR P.Price >= @MinPrice)
                      AND (@MaxPrice IS NULL OR P.Price <= @MaxPrice);";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@SearchKeyword", string.IsNullOrWhiteSpace(SearchTxt.Text) ? (object)DBNull.Value : SearchTxt.Text);
                command.Parameters.AddWithValue("@CategoryID", CategoryComboBox.SelectedValue == DBNull.Value ? (object)DBNull.Value : CategoryComboBox.SelectedValue);
                command.Parameters.AddWithValue("@MinPrice", MinPriceNumeric.Value == 0 ? (object)DBNull.Value : MinPriceNumeric.Value);
                command.Parameters.AddWithValue("@MaxPrice", MaxPriceNumeric.Value == 0 ? (object)DBNull.Value : MaxPriceNumeric.Value);

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ProductsGridView.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No products match the search criteria.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var clickedColumn = ProductsGridView.Columns[e.ColumnIndex];

                if (clickedColumn != null && clickedColumn.Name == "AddToCart")
                {
                    try
                    {
                        int productId = Convert.ToInt32(ProductsGridView.Rows[e.RowIndex].Cells["ProductID"].Value);

                        AddToCart(productId, 1, 1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while adding the product to the cart: " + ex.Message);
                    }
                }
            }
        }

        private void AddToCart(int productId, int quantity, int customerId)
        {
            try
            {
                con.Open();

                string checkQuery = "SELECT Quantity FROM ShoppingCart WHERE CustomerID = @CustomerID AND ProductID = @ProductID";
                SqlCommand checkCommand = new SqlCommand(checkQuery, con);
                checkCommand.Parameters.AddWithValue("@CustomerID", customerId);
                checkCommand.Parameters.AddWithValue("@ProductID", productId);

                object result = checkCommand.ExecuteScalar();

                if (result != null)
                {
                    int existingQuantity = Convert.ToInt32(result);
                    int newQuantity = existingQuantity + quantity;

                    string updateQuery = "UPDATE ShoppingCart SET Quantity = @Quantity WHERE CustomerID = @CustomerID AND ProductID = @ProductID";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                    updateCommand.Parameters.AddWithValue("@Quantity", newQuantity);
                    updateCommand.Parameters.AddWithValue("@CustomerID", customerId);
                    updateCommand.Parameters.AddWithValue("@ProductID", productId);
                    updateCommand.ExecuteNonQuery();
                }
                else
                {
                    string insertQuery = "INSERT INTO ShoppingCart (CustomerID, ProductID, Quantity) VALUES (@CustomerID, @ProductID, @Quantity)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, con);
                    insertCommand.Parameters.AddWithValue("@CustomerID", customerId);
                    insertCommand.Parameters.AddWithValue("@ProductID", productId);
                    insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                    insertCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Product added to cart.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the product to the cart: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ViewCartLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
               
                CustShoppingCart cartForm = new CustShoppingCart();
                cartForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the cart: " + ex.Message);
            }
        }
        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MinPriceNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MaxPriceNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //go back
            CustInterface custInterface = new CustInterface();      
            custInterface.Show();
            this.Hide();
        }
    }
}