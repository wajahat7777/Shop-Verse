using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class SellerReg : Form
    {
        string connectionString;
        public SellerReg()
        {
            InitializeComponent();
            connectionString = "Server=DESKTOP-A8PIF3V;Database=Project;Trusted_Connection=True;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sign up button
            // Retrieve input values
            string firstName = FNameTxt.Text.Trim();
            string lastName = LNameTxt.Text.Trim();
            string email = MailTxt.Text.Trim();
            string password = PassTxt.Text.Trim();

            // Perform validation checks
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("First Name is required.");
                return;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last Name is required.");
                return;
            }

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

            if (!IsStrongPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters long, include an uppercase letter, a lowercase letter, a number, and a special character.");
                return;
            }


            // Save data to database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO SELLER (FirstName, LastName, Email, Password) " +
                                   "VALUES (@FirstName, @LastName, @Email, @Password)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Registration successful!");
                            Login logIn = new Login();
                            logIn.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            
        }

        private void FNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, pattern))
                return false;
            return true;
        }

        // Password strength validation method
        private bool IsStrongPassword(string password)
        {

            if (password.Length>=8)
            {
                if (Regex.IsMatch(password, @"[A-Z]") &&  Regex.IsMatch(password, @"[a-z]") && Regex.IsMatch(password, @"\d") &&  Regex.IsMatch(password, @"[!@#$%^&*(),.?""{}|<>]"))
                    return true;
                return false;
            }
            return false;

        }
        private void SellerLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void CustomerReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerReg customerReg = new CustomerReg();    
               customerReg.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
