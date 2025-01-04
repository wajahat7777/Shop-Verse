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
    public partial class AdSellerCustomerMgmt : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False");

        public AdSellerCustomerMgmt()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void LoadCustomers()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    string query = "SELECT CustomerID, FirstName, LastName, Email, PaymentPreference, Address, State FROM Customer";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    CustomerGridView.DataSource = dt;

                    if (!CustomerGridView.Columns.Contains("Edit"))
                    {
                        DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                        editButtonColumn.HeaderText = "Edit";
                        editButtonColumn.Text = "Edit";
                        editButtonColumn.Name = "Edit";
                        editButtonColumn.UseColumnTextForButtonValue = true;
                        CustomerGridView.Columns.Add(editButtonColumn);
                    }

                    if (!CustomerGridView.Columns.Contains("Delete"))
                    {
                        DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                        deleteButtonColumn.HeaderText = "Delete";
                        deleteButtonColumn.Text = "Delete";
                        deleteButtonColumn.Name = "Delete";
                        deleteButtonColumn.UseColumnTextForButtonValue = true;
                        CustomerGridView.Columns.Add(deleteButtonColumn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }


        private void LoadSellers()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    string query = "SELECT SellerID, FirstName, LastName, Email FROM Seller";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    SellerGridView.DataSource = dt;

                    if (!SellerGridView.Columns.Contains("Edit"))
                    {
                        DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                        editButtonColumn.HeaderText = "Edit";
                        editButtonColumn.Text = "Edit";
                        editButtonColumn.Name = "Edit";
                        editButtonColumn.UseColumnTextForButtonValue = true;
                        SellerGridView.Columns.Add(editButtonColumn);
                    }

                    if (!SellerGridView.Columns.Contains("Delete"))
                    {
                        DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                        deleteButtonColumn.HeaderText = "Delete";
                        deleteButtonColumn.Text = "Delete";
                        deleteButtonColumn.Name = "Delete";
                        deleteButtonColumn.UseColumnTextForButtonValue = true;
                        SellerGridView.Columns.Add(deleteButtonColumn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sellers: " + ex.Message);
            }
        }


        private void EditCustomer(int customerId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    string query = "SELECT FirstName, LastName, Email, PaymentPreference, Address, State FROM Customer WHERE CustomerID = @CustomerID";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate textboxes with the selected customer's details
                        FirstNameText.Text = reader["FirstName"].ToString();
                        LastNameText.Text = reader["LastName"].ToString();
                        EmailText.Text = reader["Email"].ToString();
                        PaymentText.Text = reader["PaymentPreference"].ToString();
                        AddressText.Text = reader["Address"].ToString();
                        StateText.Text = reader["State"].ToString();

                        // Save the customer ID for future reference
                        FirstNameText.Tag = customerId;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing customer: " + ex.Message);
            }
        }




        private void DeleteCustomer(int customerId)
        {
            try
            {
                con.Open();
                string deleteOrdersQuery = "DELETE FROM Orders WHERE CustomerID = @CustomerID";
                SqlCommand deleteOrdersCommand = new SqlCommand(deleteOrdersQuery, con);
                deleteOrdersCommand.Parameters.AddWithValue("@CustomerID", customerId);
                deleteOrdersCommand.ExecuteNonQuery();

                string deleteCustomerQuery = "DELETE FROM Customer WHERE CustomerID = @CustomerID";
                SqlCommand deleteCustomerCommand = new SqlCommand(deleteCustomerQuery, con);
                deleteCustomerCommand.Parameters.AddWithValue("@CustomerID", customerId);
                deleteCustomerCommand.ExecuteNonQuery();

                MessageBox.Show("Customer and their associated orders deleted successfully.");
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting customer: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }





        private void EditSeller(int sellerId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    string query = "SELECT FirstName, LastName, Email FROM Seller WHERE SellerID = @SellerID";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@SellerID", sellerId);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate textboxes with the selected seller's details
                        FirstNameSeller.Text = reader["FirstName"].ToString();
                        LastNameSeller.Text = reader["LastName"].ToString();
                        EmailSeller.Text = reader["Email"].ToString();
                        FirstNameSeller.Tag = sellerId;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing seller: " + ex.Message);
            }
        }




        private void CustomerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (CustomerGridView.Columns[e.ColumnIndex].Name == "Edit")
                {
                    int customerId = Convert.ToInt32(CustomerGridView.Rows[e.RowIndex].Cells["CustomerID"].Value);
                    EditCustomer(customerId);
                }
                else if (CustomerGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int customerId = Convert.ToInt32(CustomerGridView.Rows[e.RowIndex].Cells["CustomerID"].Value);
                    DeleteCustomer(customerId);
                }
            }
        }


        private void SellerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (SellerGridView.Columns[e.ColumnIndex].Name == "Edit")
                {
                    int sellerId = Convert.ToInt32(SellerGridView.Rows[e.RowIndex].Cells["SellerID"].Value);
                    EditSeller(sellerId);
                }
                else if (SellerGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int sellerId = Convert.ToInt32(SellerGridView.Rows[e.RowIndex].Cells["SellerID"].Value);
                    DeleteSeller(sellerId);
                }
            }
        }


        private void DeleteSeller(int sellerId)
        {
            try
            {
                con.Open();
                string deleteProductsQuery = "DELETE FROM SellerProduct WHERE SellerID = @SellerID";
                SqlCommand deleteProductsCommand = new SqlCommand(deleteProductsQuery, con);
                deleteProductsCommand.Parameters.AddWithValue("@SellerID", sellerId);
                deleteProductsCommand.ExecuteNonQuery();

                string deleteSellerQuery = "DELETE FROM Seller WHERE SellerID = @SellerID";
                SqlCommand deleteSellerCommand = new SqlCommand(deleteSellerQuery, con);
                deleteSellerCommand.Parameters.AddWithValue("@SellerID", sellerId);
                deleteSellerCommand.ExecuteNonQuery();

                MessageBox.Show("Seller and their associated products deleted successfully.");
                LoadSellers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting seller: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        private void AdminManage_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadSellers();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButtonCust_Click(object sender, EventArgs e)
        {
            if (FirstNameText.Tag == null)
            {
                MessageBox.Show("Please select a customer to edit.");
                return;
            }

            int customerId = (int)FirstNameText.Tag;

            try
            {
                con.Open();
                string query = @"
            UPDATE Customer 
            SET FirstName = @FirstName, 
                LastName = @LastName, 
                Email = @Email, 
                PaymentPreference = @PaymentPreference, 
                Address = @Address, 
                State = @State 
            WHERE CustomerID = @CustomerID";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@FirstName", FirstNameText.Text);
                command.Parameters.AddWithValue("@LastName", LastNameText.Text);
                command.Parameters.AddWithValue("@Email", EmailText.Text);
                command.Parameters.AddWithValue("@PaymentPreference", PaymentText.Text);
                command.Parameters.AddWithValue("@Address", AddressText.Text);
                command.Parameters.AddWithValue("@State", StateText.Text);
                command.Parameters.AddWithValue("@CustomerID", customerId);

                command.ExecuteNonQuery();
                MessageBox.Show("Customer updated successfully.");

                // Refresh the customer grid
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving customer: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void SaveButtonSell_Click(object sender, EventArgs e)
        {
            if (FirstNameSeller.Tag == null)
            {
                MessageBox.Show("Please select a seller to edit.");
                return;
            }

            int sellerId = (int)FirstNameSeller.Tag;

            try
            {
                con.Open();
                string query = @"
            UPDATE Seller 
            SET FirstName = @FirstName, 
                LastName = @LastName, 
                Email = @Email 
            WHERE SellerID = @SellerID";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@FirstName", FirstNameSeller.Text);
                command.Parameters.AddWithValue("@LastName", LastNameSeller.Text);
                command.Parameters.AddWithValue("@Email", EmailSeller.Text);
                command.Parameters.AddWithValue("@SellerID", sellerId);

                command.ExecuteNonQuery();
                MessageBox.Show("Seller updated successfully.");

                // Refresh the seller grid
                LoadSellers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving seller: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void StateText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
