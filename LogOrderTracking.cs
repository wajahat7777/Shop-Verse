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
    public partial class LogOrderTracking : Form
    {
        public LogOrderTracking()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False");
        int customerId = 1; // Replace with the logged-in customer's ID

        private void OrderTracking_Load(object sender, EventArgs e)
        {
            LoadCustomerInformation();
            LoadOrderDetails();
        }

        private void LoadCustomerInformation()
        {
            try
            {
                con.Open();

                string query = @"
            SELECT FirstName + ' ' + LastName AS FullName, 
                   Email, 
                   Address 
            FROM Customer 
            WHERE CustomerID = @CustomerID";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@CustomerID", customerId);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    string fullName = reader["FullName"].ToString();
                    string email = reader["Email"].ToString();
                    string address = reader["Address"].ToString();

                    // Populate the TextBox with customer information
                    CustomerInfoTxtBox.Text = $"Name: {fullName}\n" +
                                              $"Email: {email}\n" +
                                              $"Address: {address}";
                }
                else
                {
                    CustomerInfoTxtBox.Text = "Customer information not found.";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading customer information: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void LoadOrderDetails()
        {
            try
            {
                con.Open();

                string query = @"
                SELECT O.OrderID, 
                       O.OrderDate, 
                       O.Status, 
                       O.PaymentOption, 
                       O.ShippingOption,
                       SUM(OI.Quantity * OI.Price) AS TotalAmount
                FROM Orders O
                JOIN OrderItem OI ON O.OrderID = OI.OrderID
                WHERE O.CustomerID = @CustomerID
                GROUP BY O.OrderID, O.OrderDate, O.Status, O.PaymentOption, O.ShippingOption";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@CustomerID", customerId);

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                OrderGridView.DataSource = dt;

                // Update column headers
                OrderGridView.Columns["OrderID"].HeaderText = "Order ID";
                OrderGridView.Columns["OrderDate"].HeaderText = "Order Date";
                OrderGridView.Columns["Status"].HeaderText = "Status";
                OrderGridView.Columns["PaymentOption"].HeaderText = "Payment Method";
                OrderGridView.Columns["ShippingOption"].HeaderText = "Shipping Method";
                OrderGridView.Columns["TotalAmount"].HeaderText = "Total Amount";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading order details: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = @"
                SELECT O.OrderID, 
                       O.OrderDate, 
                       O.Status, 
                       O.PaymentOption, 
                       O.ShippingOption,
                       SUM(OI.Quantity * OI.Price) AS TotalAmount
                FROM Orders O
                JOIN OrderItem OI ON O.OrderID = OI.OrderID
                WHERE O.CustomerID = @CustomerID AND O.OrderDate >= @StartDate
                GROUP BY O.OrderID, O.OrderDate, O.Status, O.PaymentOption, O.ShippingOption";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@CustomerID", customerId);
                command.Parameters.AddWithValue("@StartDate", StartDatePicker.Value.Date);

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                OrderGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering orders: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void CustomerInfoLbl_Click(object sender, EventArgs e)
        {

        }


        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = StatusComboBox.SelectedItem?.ToString();

            // If "All" is selected, load all orders
            if (selectedStatus == "All" || string.IsNullOrEmpty(selectedStatus))
            {
                LoadOrderDetails();
                return;
            }

            // Otherwise, filter based on the selected status
            try
            {
                con.Open();

                string query = @"
                SELECT O.OrderID, 
                       O.OrderDate, 
                       O.Status, 
                       O.PaymentOption, 
                       O.ShippingOption,
                       SUM(OI.Quantity * OI.Price) AS TotalAmount
                FROM Orders O
                JOIN OrderItem OI ON O.OrderID = OI.OrderID
                WHERE O.CustomerID = @CustomerID AND O.Status = @Status
                GROUP BY O.OrderID, O.OrderDate, O.Status, O.PaymentOption, O.ShippingOption";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@CustomerID", customerId);
                command.Parameters.AddWithValue("@Status", selectedStatus);

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                OrderGridView.DataSource = dt;

                // Update column headers
                OrderGridView.Columns["OrderID"].HeaderText = "Order ID";
                OrderGridView.Columns["OrderDate"].HeaderText = "Order Date";
                OrderGridView.Columns["Status"].HeaderText = "Status";
                OrderGridView.Columns["PaymentOption"].HeaderText = "Payment Method";
                OrderGridView.Columns["ShippingOption"].HeaderText = "Shipping Method";
                OrderGridView.Columns["TotalAmount"].HeaderText = "Total Amount";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering orders: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void CustomerInfoTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderTracking_Load_1(object sender, EventArgs e)
        {

        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
