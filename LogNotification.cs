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
    public partial class LogNotification : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False");

        public LogNotification()
        {
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            LoadDeliveryStatuses();
            LoadShipments();
        }

        private void LoadDeliveryStatuses()
        {
            DeliveryStatusComboBox.Items.Clear();
            DeliveryStatusComboBox.Items.Add("All");
            DeliveryStatusComboBox.Items.Add("Pending");
            DeliveryStatusComboBox.Items.Add("In Transit");
            DeliveryStatusComboBox.Items.Add("Delivered");
            DeliveryStatusComboBox.SelectedIndex = 0; // Default to "All"
        }

        private void LoadShipments()
        {
            try
            {
                con.Open();

                string query = @"
                SELECT S.ShipmentID, 
                       S.OrderID, 
                       S.AssignedTo, 
                       S.Status, 
                       S.EstimatedDeliveryDate, 
                       S.ActualDeliveryDate, 
                       C.FirstName + ' ' + C.LastName AS CustomerName
                FROM Shipments S
                JOIN Orders O ON S.OrderID = O.OrderID
                JOIN Customer C ON O.CustomerID = C.CustomerID";

                if (DeliveryStatusComboBox.SelectedItem.ToString() != "All")
                {
                    query += " WHERE S.Status = @Status";
                }

                SqlCommand command = new SqlCommand(query, con);
                if (DeliveryStatusComboBox.SelectedItem.ToString() != "All")
                {
                    command.Parameters.AddWithValue("@Status", DeliveryStatusComboBox.SelectedItem.ToString());
                }

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DeliveryGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading shipments: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void DeliveryStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadShipments();
        }

        private void NotifyButton_Click(object sender, EventArgs e)
        {
            if (DeliveryGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a shipment to notify the customer.");
                return;
            }

            try
            {
                int shipmentId = Convert.ToInt32(DeliveryGridView.SelectedRows[0].Cells["ShipmentID"].Value);
                int orderId = Convert.ToInt32(DeliveryGridView.SelectedRows[0].Cells["OrderID"].Value);
                string status = DeliveryGridView.SelectedRows[0].Cells["Status"].Value.ToString();
                string customerName = DeliveryGridView.SelectedRows[0].Cells["CustomerName"].Value.ToString();
                DateTime? deliveryDate = DeliveryGridView.SelectedRows[0].Cells["ActualDeliveryDate"].Value as DateTime?;

                string message = deliveryDate.HasValue
                    ? $"Dear {customerName}, your order (ID: {orderId}) was delivered on {deliveryDate.Value.ToShortDateString()}."
                    : $"Dear {customerName}, your order (ID: {orderId}) is currently '{status}'.";

                con.Open();

                string notificationQuery = @"
                INSERT INTO Notifications (CustomerID, ShipmentID, Message)
                SELECT C.CustomerID, S.ShipmentID, @Message
                FROM Shipments S
                JOIN Orders O ON S.OrderID = O.OrderID
                JOIN Customer C ON O.CustomerID = C.CustomerID
                WHERE S.ShipmentID = @ShipmentID";

                SqlCommand command = new SqlCommand(notificationQuery, con);
                command.Parameters.AddWithValue("@Message", message);
                command.Parameters.AddWithValue("@ShipmentID", shipmentId);
                command.ExecuteNonQuery();

                MessageBox.Show("Notification sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending notification: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }
    }
}
