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
    public partial class LogShipmentTracking : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False");

        public LogShipmentTracking()
        {
            InitializeComponent();
            LoadOrders();
            LoadShipments();
        }

        private void LoadOrders()
        {
            using (SqlConnection localCon = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    localCon.Open();
                    string query = @"
            SELECT O.OrderID, 
                   C.FirstName + ' ' + C.LastName AS CustomerName, 
                   O.OrderDate, 
                   O.Status
            FROM Orders O
            JOIN Customer C ON O.CustomerID = C.CustomerID
            WHERE O.Status = 'Pending'"; // Only fetch orders with Pending status

                    SqlCommand command = new SqlCommand(query, localCon);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    OrdersGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading orders: " + ex.Message);
                }
            }
        }



        private void LoadShipments()
        {
            using (SqlConnection localCon = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    localCon.Open();
                    string query = @"
                SELECT ShipmentID, 
                       OrderID, 
                       AssignedTo, 
                       Status, 
                       EstimatedDeliveryDate, 
                       ActualDeliveryDate
                FROM Shipments";

                    SqlCommand command = new SqlCommand(query, localCon);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    ShipmentsGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading shipments: " + ex.Message);
                }
            }
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (ShipmentsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a shipment to update.");
                return;
            }

            int shipmentId = Convert.ToInt32(ShipmentsGridView.SelectedRows[0].Cells["ShipmentID"].Value);
            string newStatus = StatusComboBox.SelectedItem?.ToString();
            DateTime? actualDeliveryDate = newStatus == "Delivered" ? (DateTime?)ActualDeliveryPicker.Value : null;

            try
            {
                con.Open();
                string query = @"
                    UPDATE Shipments
                    SET Status = @Status, ActualDeliveryDate = @ActualDeliveryDate
                    WHERE ShipmentID = @ShipmentID";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Status", newStatus);
                command.Parameters.AddWithValue("@ActualDeliveryDate", (object)actualDeliveryDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@ShipmentID", shipmentId);
                command.ExecuteNonQuery();

                MessageBox.Show("Shipment status updated.");
                LoadShipments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating shipment: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            if (OrdersGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to assign.");
                return;
            }

            int orderId = Convert.ToInt32(OrdersGridView.SelectedRows[0].Cells["OrderID"].Value);
            string assignedTo = AssignedToComboBox.SelectedItem?.ToString();
            DateTime estimatedDeliveryDate = EstimatedDeliveryPicker.Value;

            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();

                // Insert the shipment into the Shipments table
                string query = @"
            INSERT INTO Shipments (OrderID, AssignedTo, EstimatedDeliveryDate)
            VALUES (@OrderID, @AssignedTo, @EstimatedDeliveryDate)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@OrderID", orderId);
                command.Parameters.AddWithValue("@AssignedTo", assignedTo);
                command.Parameters.AddWithValue("@EstimatedDeliveryDate", estimatedDeliveryDate);
                command.ExecuteNonQuery();

                // Update the order's status to "In Progress"
                string updateOrderQuery = "UPDATE Orders SET Status = 'In Progress' WHERE OrderID = @OrderID";
                SqlCommand updateOrderCommand = new SqlCommand(updateOrderQuery, con);
                updateOrderCommand.Parameters.AddWithValue("@OrderID", orderId);
                updateOrderCommand.ExecuteNonQuery();

                MessageBox.Show("Shipment assigned successfully.");

                // Refresh both grids
                LoadOrders();
                LoadShipments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning shipment: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void ShipmentTracking_Load(object sender, EventArgs e)
        {
            LoadOrders();
            LoadShipments();
        }

        private void AssignedToComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


