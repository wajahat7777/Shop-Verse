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
    public partial class SellerOrderFulfillment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False");

        public SellerOrderFulfillment()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            LoadOrdersWithCustomerNames();
            StatusComboBox.Items.Add("Pending");
            StatusComboBox.Items.Add("Shipped");
            StatusComboBox.Items.Add("Delivered");
            StatusComboBox.Items.Add("Cancelled");
        }

        private void LoadOrdersWithCustomerNames()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = @"
            SELECT O.OrderID, 
                   C.FirstName + ' ' + C.LastName AS [Customer Name], 
                   P.Name AS ProductDetails, 
                   OI.Quantity, 
                   O.OrderDate, 
                   O.Status
            FROM Orders O
            JOIN Customer C ON O.CustomerID = C.CustomerID
            JOIN OrderItem OI ON O.OrderID = OI.OrderID
            JOIN Products P ON OI.ProductID = P.ProductID";

                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading orders: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpSButt_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an order to update.");
                    return;
                }

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int orderId = Convert.ToInt32(selectedRow.Cells["OrderID"].Value);

                string newStatus = StatusComboBox.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(newStatus))
                {
                    MessageBox.Show("Please select a valid status.");
                    return;
                }

                string query = "UPDATE Orders SET Status = @Status WHERE OrderID = @OrderID";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Status", newStatus);
                    command.Parameters.AddWithValue("@OrderID", orderId);

                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order status updated successfully.");
                        LoadOrdersWithCustomerNames();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the order status. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the order status: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void BackButt_Click(object sender, EventArgs e)
        {
            SellerInterface sellerform = new SellerInterface();
            sellerform.Show();
            this.Hide();
        }
    }
}