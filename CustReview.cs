using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class CustReview : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-A8PIF3V;Database=Project;Trusted_Connection=True");
        int customerId = 1; 

        public CustReview()
        {
            InitializeComponent();
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void LoadProductList()
        {
            try
            {
                con.Open();

                string query = @"
                    SELECT DISTINCT P.ProductID, P.Name
                    FROM Orders O
                    JOIN OrderItem OI ON O.OrderID = OI.OrderID
                    JOIN Products P ON OI.ProductID = P.ProductID
                    WHERE O.CustomerID = @CustomerID";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@CustomerID", customerId);

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ProductComboBox.DataSource = dt;
                ProductComboBox.DisplayMember = "Name";
                ProductComboBox.ValueMember = "ProductID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the product list: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
          
        }

        private void ClearForm()
        {
            ProductComboBox.SelectedIndex = -1;
            RatingNumeric.Value = 1;
            ReviewTextBox.Clear();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RatingNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ReviewTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            // Validate the inputs
            if (ProductComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (string.IsNullOrWhiteSpace(ReviewTextBox.Text))
            {
                MessageBox.Show("Please enter a review.");
                return;
            }

            // Assuming email is provided in a text box named EmailTextBox
            string email = textBox1.Text;

            // Get the CustomerID using the email
            int customerId = GetCustomerIdByEmail(email);

            if (customerId == -1)
            {
                MessageBox.Show("Customer not found with the provided email.");
                return;
            }

            // Get the ProductID and other details
            int productId = Convert.ToInt32(ProductComboBox.SelectedValue);
            int rating = (int)RatingNumeric.Value;
            string reviewText = ReviewTextBox.Text;

            // Get the OrderID for the product
            int orderId = GetOrderIdForProduct(productId, customerId);

            if (orderId == -1)
            {
                MessageBox.Show("No order found for this product.");
                return;
            }

            // Assume 'Pending' status for new reviews
            int statusId = 1;  // Assuming 1 is the ID for 'Pending' status

            // Submit the review
            try
            {
                con.Open();

                string query = @"
            INSERT INTO Review (CustomerID, ProductID, OrderID, Rating, Comment, StatusID)
            VALUES (@CustomerID, @ProductID, @OrderID, @Rating, @Comment, @StatusID)";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@CustomerID", customerId);
                command.Parameters.AddWithValue("@ProductID", productId);
                command.Parameters.AddWithValue("@OrderID", orderId);
                command.Parameters.AddWithValue("@Rating", rating);
                command.Parameters.AddWithValue("@Comment", reviewText);
                command.Parameters.AddWithValue("@StatusID", statusId);

                command.ExecuteNonQuery();

                MessageBox.Show("Review submitted successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while submitting the review: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // Function to retrieve the CustomerID based on the email
        private int GetCustomerIdByEmail(string email)
        {
            int customerId = -1;

            try
            {
                con.Open();
                string query = "SELECT CustomerID FROM Customer WHERE Email = @Email";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Email", email);

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    customerId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while fetching customer ID: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return customerId;
        }

        // Function to retrieve the OrderID for the selected product
        private int GetOrderIdForProduct(int productId, int customerId)
        {
            int orderId = -1;

            try
            {
                con.Open();
                string query = @"
            SELECT TOP 1 Orders.OrderID
            FROM Orders
            JOIN OrderItem ON Orders.OrderID = OrderItem.OrderID
            WHERE Orders.CustomerID = @CustomerID
            AND OrderItem.ProductID = @ProductID
            AND Orders.OrderDate < GETDATE()
            ORDER BY Orders.OrderDate DESC";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@CustomerID", customerId);
                command.Parameters.AddWithValue("@ProductID", productId);

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    orderId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while fetching order ID: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return orderId;
        }


        private void BackButton_Click_1(object sender, EventArgs e)
        {
            CustInterface custInterface = new CustInterface();
            custInterface.Show();
            this.Hide();
        }
  

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
