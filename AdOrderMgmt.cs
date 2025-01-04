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
                
    public partial class AdOrderMgmt : Form
    {
        private string connectionString = "Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False";

        public AdOrderMgmt()
        {
            InitializeComponent();
        }

        private void AdOrderMgmt_Load(object sender, EventArgs e)
        {
            LoadOrders();
            PopulateOrderStatusComboBox();
        }

        // This method will retrieve and load orders into the DataGridView
        private void LoadOrders(string status = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                SELECT o.OrderID, o.CustomerID, o.OrderDate, 
                       (SELECT SUM(oi.Quantity * oi.Price) 
                        FROM OrderItem oi 
                        WHERE oi.OrderID = o.OrderID) AS TotalAmount, 
                       o.Status
                FROM Orders o";

                    if (!string.IsNullOrEmpty(status))
                    {
                        query += " WHERE o.Status = @Status";
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    if (!string.IsNullOrEmpty(status))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@Status", status);
                    }

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewOrders.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading orders: " + ex.Message);
                }
            }
        }


        private void PopulateOrderStatusComboBox()
        {
            // Assuming standard order statuses; adapt as needed
            comboBoxOrderStatus.Items.Clear();
            comboBoxOrderStatus.Items.AddRange(new[] { "Pending", "Shipped", "Delivered", "Cancelled" });
            comboBoxOrderStatus.SelectedIndex = 0; // Default selection
        }

        // Load order details for a selected order
        private void LoadOrderDetails(int orderId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                SELECT oi.OrderItemID, p.Name AS ProductName, oi.Quantity, oi.Price 
                FROM OrderItem oi
                JOIN Products p ON oi.ProductID = p.ProductID
                WHERE oi.OrderID = @OrderID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewOrderDetails.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading order details: " + ex.Message);
                }
            }
        }



        private void UpdateOrderStatus(int orderId, string newStatus)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "UPDATE Orders SET Status = @Status WHERE OrderID = @OrderID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@OrderID", orderId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order status updated successfully.");
                    LoadOrders(); // Refresh the order list
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating order status: " + ex.Message);
                }
            }
        }


        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateStatusButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells["OrderID"].Value);
                string newStatus = comboBoxOrderStatus.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(newStatus))
                {
                    UpdateOrderStatus(orderId, newStatus);
                }
                else
                {
                    MessageBox.Show("Please select a status to update.");
                }
            }
            else
            {
                MessageBox.Show("Please select an order to update.");
            }
        }



        private void comboBoxOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void ViewOrderButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells["OrderID"].Value);
                LoadOrderDetails(orderId);
            }
            else
            {
                MessageBox.Show("Please select an order to view details.");
                dataGridViewOrderDetails.DataSource = null; // Clear the details grid
            }
        }

        private void dataGridViewOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells["OrderID"].Value);
                LoadOrderDetails(orderId);
            }
            else
            {
                dataGridViewOrderDetails.DataSource = null;
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string selectedStatus = comboBoxOrderStatus.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedStatus))
            {
                LoadOrders(selectedStatus);
            }
            else
            {
                MessageBox.Show("Please select a status to filter.");
            }
        }
    }
}
