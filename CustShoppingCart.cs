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
    public partial class CustShoppingCart : Form
    {
        public CustShoppingCart()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server=DESKTOP-A8PIF3V;Database=Project;Trusted_Connection=True");
        int customerId = 1; // Replace with logged-in customer's ID

        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            LoadCartItems();
            UpdateTotalPrice();
        }

        public void LoadCartItems()
        {
            try
            {
                con.Open();
                string query = @"
            SELECT P.Name AS ProductName, 
                   P.Price, 
                   SUM(SC.Quantity) AS TotalQuantity, 
                   SUM(P.Price * SC.Quantity) AS Total
            FROM ShoppingCart SC
            JOIN Products P ON SC.ProductID = P.ProductID
            WHERE SC.CustomerID = @CustomerID
            GROUP BY P.Name, P.Price";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@CustomerID", customerId);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                CartGridView.DataSource = dt;

                if (CartGridView.Columns.Contains("ProductName"))
                    CartGridView.Columns["ProductName"].HeaderText = "Product Name";
                if (CartGridView.Columns.Contains("Price"))
                    CartGridView.Columns["Price"].HeaderText = "Price";
                if (CartGridView.Columns.Contains("TotalQuantity"))
                    CartGridView.Columns["TotalQuantity"].HeaderText = "Quantity";
                if (CartGridView.Columns.Contains("Total"))
                    CartGridView.Columns["Total"].HeaderText = "Total Price";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading cart items: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        public void UpdateTotalPrice()
        {
            try
            {
                con.Open();
                string query = @"
                    SELECT SUM(P.Price * SC.Quantity) AS TotalPrice
                    FROM ShoppingCart SC
                    JOIN Products P ON SC.ProductID = P.ProductID
                    WHERE SC.CustomerID = @CustomerID";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@CustomerID", customerId);
                object result = command.ExecuteScalar();

                TotalPriceLbl.Text = "Total Price: $" + (result != DBNull.Value ? Convert.ToDecimal(result).ToString("0.00") : "0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while calculating total price: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void RemoveButt_Click(object sender, EventArgs e)
        {
            if (CartGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            string productName = CartGridView.SelectedRows[0].Cells["ProductName"].Value.ToString();
            decimal price = Convert.ToDecimal(CartGridView.SelectedRows[0].Cells["Price"].Value);

            try
            {
                con.Open();
                string deleteQuery = @"
            DELETE FROM ShoppingCart 
            WHERE CustomerID = @CustomerID 
            AND ProductID = (SELECT ProductID FROM Products WHERE Name = @ProductName AND Price = @Price)";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, con);
                deleteCommand.Parameters.AddWithValue("@CustomerID", customerId);
                deleteCommand.Parameters.AddWithValue("@ProductName", productName);
                deleteCommand.Parameters.AddWithValue("@Price", price);
                deleteCommand.ExecuteNonQuery();

                MessageBox.Show("Item removed from the cart.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing the item: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            LoadCartItems();
            UpdateTotalPrice();
        }

        private void CheckoutButt_Click(object sender, EventArgs e) //place order button
        {
            if (CartGridView.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Add items to proceed with the order.");
                return;
            }

            if (string.IsNullOrEmpty(PaymentMethodComboBox.Text))
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            if (string.IsNullOrEmpty(ShippingMethodComboBox.Text))
            {
                MessageBox.Show("Please select a shipping option.");
                return;
            }

            try
            {
                con.Open();

                string orderQuery = @"
            INSERT INTO Orders (CustomerID, OrderDate, Status, PaymentOption, ShippingOption)
            OUTPUT INSERTED.OrderID
            VALUES (@CustomerID, GETDATE(), 'Pending', @PaymentOption, @ShippingOption)";
                SqlCommand orderCommand = new SqlCommand(orderQuery, con);
                orderCommand.Parameters.AddWithValue("@CustomerID", customerId);
                orderCommand.Parameters.AddWithValue("@PaymentOption", PaymentMethodComboBox.Text);
                orderCommand.Parameters.AddWithValue("@ShippingOption", ShippingMethodComboBox.Text);
                int orderId = (int)orderCommand.ExecuteScalar();

                // Step 2: Insert order items into OrderItem table
                string orderItemQuery = @"
            INSERT INTO OrderItem (OrderID, ProductID, Quantity, Price)
            SELECT @OrderID, SC.ProductID, SC.Quantity, P.Price
            FROM ShoppingCart SC
            JOIN Products P ON SC.ProductID = P.ProductID
            WHERE SC.CustomerID = @CustomerID";
                SqlCommand orderItemCommand = new SqlCommand(orderItemQuery, con);
                orderItemCommand.Parameters.AddWithValue("@OrderID", orderId);
                orderItemCommand.Parameters.AddWithValue("@CustomerID", customerId);
                orderItemCommand.ExecuteNonQuery();

                // Step 3: Clear the shopping cart
                string clearCartQuery = "DELETE FROM ShoppingCart WHERE CustomerID = @CustomerID";
                SqlCommand clearCartCommand = new SqlCommand(clearCartQuery, con);
                clearCartCommand.Parameters.AddWithValue("@CustomerID", customerId);
                clearCartCommand.ExecuteNonQuery();

                MessageBox.Show("Order placed successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while placing the order: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            LoadCartItems();
            UpdateTotalPrice();
        }

        private void BackButt_Click(object sender, EventArgs e)
        {
            CustProductSearch F1 = new CustProductSearch();
            F1.Show();
            this.Hide();
        }

        private void TotalPriceLbl_Click(object sender, EventArgs e)
        {

        }

        private void CartGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PaymentMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShippingMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
