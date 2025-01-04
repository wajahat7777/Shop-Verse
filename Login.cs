using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        string connectionString;

        public Login()
        {
            connectionString = "Server=DESKTOP-A8PIF3V;Database=Project;Trusted_Connection=True;";
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e) { }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // For seller login checkbox (optional feature)
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void PassTxt_TextChanged(object sender, EventArgs e) { }

        private void MailTxt_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = MailTxt.Text.Trim();
            string password = PassTxt.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email is required.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is required.");
                return;
            }

            // Attempt login
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query;
                    bool isSeller = false;
                    if (checkBox1.Checked)
                    {
                        query="SELECT COUNT(*) FROM Seller WHERE Email = @Email AND Password = @Password COLLATE SQL_Latin1_General_CP1_CI_AS";
                        isSeller = true;
                    }
                    else
                    {
                        query = "SELECT COUNT(*) FROM Customer WHERE Email = @Email AND Password = @Password COLLATE SQL_Latin1_General_CP1_CI_AS";
                    }
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int result = (int)cmd.ExecuteScalar();
                        if (result > 0)
                        {
                            MessageBox.Show("Login successful!");
                            // Proceed to the next form or functionality
                            if (!isSeller)
                            {
                                CustInterface custInterfaceForm = new CustInterface();
                                custInterfaceForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                SellerInterface sellerInterface = new SellerInterface();    
                                sellerInterface.Show(); 
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while trying to log in: " + ex.Message);
                }
            }
        }

        private void CustomerReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
     
            CustomerReg cusRegForm = new CustomerReg();
            cusRegForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Redirect to seller registration
            SellerReg sellerReg=new SellerReg();
            sellerReg.Show();   
            this.Hide(); 
            

        }

  
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, pattern))
                return false;
            return true;
        }
    }
}
