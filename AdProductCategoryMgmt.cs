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
    public partial class AdProductCategoryMgmt : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False");

        public AdProductCategoryMgmt()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void ProductCategoryAdMgmt_Load(object sender, EventArgs e)
        {
            this.categoryTableAdapter.Fill(this.projectDataSet.Category);
            LoadCategories();
            LoadProducts();
        }

        private void LoadCategories()
        {
            try
            {
                con.Open();
                string query = "SELECT CategoryID, Name FROM Category";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                CategoryGridView.DataSource = dt;

                // Add Button Columns for Edit and Delete if they don't exist
                if (!CategoryGridView.Columns.Contains("Edit"))
                {
                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                    {
                        HeaderText = "Edit",
                        Text = "Edit",
                        Name = "Edit",
                        UseColumnTextForButtonValue = true
                    };
                    CategoryGridView.Columns.Add(editButtonColumn);
                }

                if (!CategoryGridView.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                    {
                        HeaderText = "Delete",
                        Text = "Delete",
                        Name = "Delete",
                        UseColumnTextForButtonValue = true
                    };
                    CategoryGridView.Columns.Add(deleteButtonColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // Load Products into DataGridView
        private void LoadProducts()
        {
            try
            {
                con.Open();
                string query = @"
                SELECT P.ProductID, P.Name, P.Description, P.Price, C.Name AS CategoryName
                FROM Products P
                JOIN Category C ON P.CategoryID = C.CategoryID";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ProductGridView.DataSource = dt;

                // Add Button Columns for Edit and Delete if they don't exist
                if (!ProductGridView.Columns.Contains("Edit"))
                {
                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                    {
                        HeaderText = "Edit",
                        Text = "Edit",
                        Name = "Edit",
                        UseColumnTextForButtonValue = true
                    };
                    ProductGridView.Columns.Add(editButtonColumn);
                }

                if (!ProductGridView.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                    {
                        HeaderText = "Delete",
                        Text = "Delete",
                        Name = "Delete",
                        UseColumnTextForButtonValue = true
                    };
                    ProductGridView.Columns.Add(deleteButtonColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // Save Category
        private void SaveCategoryButton_Click(object sender, EventArgs e)
        {
            string categoryName = NameText.Text;

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Category name cannot be empty.");
                return;
            }

            try
            {
                con.Open();
                string query = @"
                    INSERT INTO Category (Name)
                    VALUES (@CategoryName)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@CategoryName", categoryName);
                command.ExecuteNonQuery();

                MessageBox.Show("Category added successfully.");
                LoadCategories(); // Refresh categories grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving category: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        private void EditCategory(int categoryId)
        {
            try
            {
                con.Open();
                string query = "SELECT Name FROM Category WHERE CategoryID = @CategoryID";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@CategoryID", categoryId);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    NameText.Text = reader["Name"].ToString();
                    NameText.Tag = categoryId;  // Set the Tag to store the category ID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing category: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void DeleteCategory(int categoryId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Products WHERE CategoryID = @CategoryID";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, con);
                    checkCommand.Parameters.AddWithValue("@CategoryID", categoryId);
                    int productCount = (int)checkCommand.ExecuteScalar();
                    if (productCount > 0)
                    {
                        DialogResult result = MessageBox.Show("This category has products associated with it. Do you want to delete the products as well?", "Delete Products", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            string deleteProductsQuery = "DELETE FROM Products WHERE CategoryID = @CategoryID";
                            SqlCommand deleteProductsCommand = new SqlCommand(deleteProductsQuery, con);
                            deleteProductsCommand.Parameters.AddWithValue("@CategoryID", categoryId);
                            deleteProductsCommand.ExecuteNonQuery();
                            MessageBox.Show("Products deleted successfully.");

                            LoadProducts();
                        }
                        else
                        {
                            MessageBox.Show("Category deletion cancelled.");
                            return;
                        }
                    }

                    string deleteCategoryQuery = "DELETE FROM Category WHERE CategoryID = @CategoryID";
                    SqlCommand deleteCategoryCommand = new SqlCommand(deleteCategoryQuery, con);
                    deleteCategoryCommand.Parameters.AddWithValue("@CategoryID", categoryId);
                    deleteCategoryCommand.ExecuteNonQuery();
                    MessageBox.Show("Category deleted successfully.");

                    LoadCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting category: " + ex.Message);
            }
        }




        // Edit Product
        private void EditProdAd(int productId)
        {
            try
            {
                con.Open();
                string query = "SELECT Name, Description, Price, CategoryID FROM Products WHERE ProductID = @ProductID";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ProductID", productId);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    NameTxt.Text = reader["Name"].ToString();
                    DescTxt.Text = reader["Description"].ToString();
                    PriceTxt.Text = reader["Price"].ToString();
                    CategoryComboBox.SelectedValue = reader["CategoryID"];

                    NameTxt.Tag = productId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing product: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // Delete Product
        private void DeleteProdAd(int productId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    string query = "DELETE FROM Products WHERE ProductID = @ProductID";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@ProductID", productId);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully.");
                    LoadProducts(); // Refresh the products grid
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }
        }


        private void CategoryManagementForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
        }

        private void ProductGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ProductGridView.Columns[e.ColumnIndex].Name == "Edit")
                {
                    int productId = Convert.ToInt32(ProductGridView.Rows[e.RowIndex].Cells["ProductID"].Value);
                    EditProdAd(productId);
                }
                else if (ProductGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int productId = Convert.ToInt32(ProductGridView.Rows[e.RowIndex].Cells["ProductID"].Value);
                    DeleteProdAd(productId);
                }
            }
        }

        private void CategoryGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (CategoryGridView.Columns[e.ColumnIndex].Name == "Edit")
                {
                    int categoryId = Convert.ToInt32(CategoryGridView.Rows[e.RowIndex].Cells["CategoryID"].Value);
                    EditCategory(categoryId);
                }
                else if (CategoryGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int categoryId = Convert.ToInt32(CategoryGridView.Rows[e.RowIndex].Cells["CategoryID"].Value);
                    DeleteCategory(categoryId);
                }
            }
        }

        private void LoadCategoriesIntoComboBox()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();

                    string query = "SELECT CategoryID, Name FROM Category";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    CategoryComboBox.DataSource = dt;
                    CategoryComboBox.DisplayMember = "Name";
                    CategoryComboBox.ValueMember = "CategoryID";
                    if (dt.Rows.Count > 0)
                        CategoryComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories into ComboBox: " + ex.Message);
            }
        }

        private void AddCat_Click(object sender, EventArgs e)
        {
            string categoryName = NameText.Text;
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Category name cannot be empty.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();

                    string query = "INSERT INTO Category (Name) VALUES (@CategoryName)";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@CategoryName", categoryName);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Category added successfully.");

                    NameText.Clear();

                    LoadCategoriesIntoComboBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding category: " + ex.Message);
            }
        }


        private void EditCat_Click(object sender, EventArgs e)
        {

        }

        private void DeleteCat_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButtonCat_Click(object sender, EventArgs e)
        {
            string categoryName = NameText.Text;

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Category name cannot be empty.");
                return;
            }

            // Check if we are editing or adding a new category
            int categoryId = Convert.ToInt32(NameText.Tag);

            try
            {
                con.Open();
                string query;
                if (categoryId == 0)
                {
                    query = "INSERT INTO Category (Name) VALUES (@CategoryName)";
                }
                {
                    query = "UPDATE Category SET Name = @CategoryName WHERE CategoryID = @CategoryID";
                }

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@CategoryName", categoryName);
                if (categoryId != 0) command.Parameters.AddWithValue("@CategoryID", categoryId);

                command.ExecuteNonQuery();
                MessageBox.Show("Category saved successfully.");
                LoadCategories(); // Refresh categories grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving category: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {

        }

        private void EditProduct_Click(object sender, EventArgs e)
        {

        }

        private void SaveProductButton_Click_1(object sender, EventArgs e)
        {
            string productName = NameTxt.Text;
            string productDescription = DescTxt.Text;
            decimal price = decimal.TryParse(PriceTxt.Text, out price) ? price : 0;
            int categoryId = Convert.ToInt32(CategoryComboBox.SelectedValue);

            if (string.IsNullOrWhiteSpace(productName) || price <= 0 || categoryId <= 0)
            {
                MessageBox.Show("Product details are incomplete.");
                return;
            }

            int productId = Convert.ToInt32(NameTxt.Tag);

            try
            {
                con.Open();
                string query;
                if (productId == 0)  // Adding a new product
                {
                    query = @"
                INSERT INTO Products (CategoryID, Name, Description, Price)
                VALUES (@CategoryID, @Name, @Description, @Price)";
                }
                else  // Editing an existing product
                {
                    query = @"
                UPDATE Products 
                SET CategoryID = @CategoryID, Name = @Name, Description = @Description, Price = @Price
                WHERE ProductID = @ProductID";
                }

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@CategoryID", categoryId);
                command.Parameters.AddWithValue("@Name", productName);
                command.Parameters.AddWithValue("@Description", productDescription);
                command.Parameters.AddWithValue("@Price", price);
                if (productId != 0) command.Parameters.AddWithValue("@ProductID", productId);

                command.ExecuteNonQuery();
                MessageBox.Show("Product saved successfully.");
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void CancelProductButton_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string productName = NameTxt.Text;
            string productDescription = DescTxt.Text;
            decimal price;
            bool isPriceValid = decimal.TryParse(PriceTxt.Text, out price);
            int categoryId = Convert.ToInt32(CategoryComboBox.SelectedValue);  // Get selected category ID

            if (string.IsNullOrWhiteSpace(productName) || !isPriceValid || price <= 0 || categoryId <= 0)
            {
                MessageBox.Show("Please fill in all fields correctly. Ensure price is a valid positive number and category is selected.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    string query = @"
                INSERT INTO Products (CategoryID, Name, Description, Price)
                VALUES (@CategoryID, @Name, @Description, @Price)";

                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                    command.Parameters.AddWithValue("@Name", productName);
                    command.Parameters.AddWithValue("@Description", productDescription);
                    command.Parameters.AddWithValue("@Price", price);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Product added successfully.");

                    NameTxt.Clear();
                    DescTxt.Clear();
                    PriceTxt.Clear();
                    CategoryComboBox.SelectedIndex = -1;

                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }


        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

