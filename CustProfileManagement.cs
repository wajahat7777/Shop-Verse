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
    public partial class CustProfileManagement : Form
    {
        public CustProfileManagement()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server=DESKTOP-A8PIF3V;Database=Project;Trusted_Connection=True");

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void OrderHistoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            //only for first name
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangePassButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string firstName = FullNameTextBox.Text.Trim();
                string lastName = LastNameTxt.Text.Trim();
                string email = textBox2.Text.Trim();
                string oldPassword = textBox3.Text.Trim();
                string newPassword = textBox5.Text.Trim();
                string payPreference= payPrefTxt.Text.Trim();
                string address = textBox4.Text.Trim();
                string state = stateTxt.Text.Trim();


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

                if (string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Address is required.");
                    return;
                }

                if (string.IsNullOrEmpty(oldPassword))
                {
                    MessageBox.Show("Please enter your old password.");
                    return;
                }

                if (string.IsNullOrEmpty(newPassword))
                {
                    MessageBox.Show("New Password is required.");
                    return;
                }

                if (!IsStrongPassword(newPassword))
                {
                    MessageBox.Show("Password must be at least 8 characters long, include an uppercase letter, a lowercase letter, a number, and a special character.");
                    return;
                }

                if (string.IsNullOrEmpty(state))
                {
                    MessageBox.Show("State is required.");
                    return;
                }

                if (string.IsNullOrEmpty(payPreference))
                {
                    MessageBox.Show("Payment Preference is Required");
                    return;
                }
                string valQuery = "SELECT COUNT(*) FROM Customer WHERE Email=@Email AND Password=@OldPassword";

                using (SqlCommand cmd = new SqlCommand(valQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@OldPassword", oldPassword);
                    int count = (int)cmd.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("The old password is incorrect or the email does not exist.");
                        return;
                    }
                }

                string updateQuery = "UPDATE Customer SET Password=@NewPassword WHERE Email=@Email";

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                    int count = cmd.ExecuteNonQuery();
                    if (count == 0)
                    {
                        MessageBox.Show("Error occurred while updating password. Please try again.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Password changed successfully.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while changing the password: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string firstName = FullNameTextBox.Text.Trim();
                string lastName = LastNameTxt.Text.Trim();
                string email = textBox2.Text.Trim();
                string payPreference = payPrefTxt.Text.Trim();
                string address = textBox4.Text.Trim();
                string state = stateTxt.Text.Trim();

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

                if (string.IsNullOrEmpty(payPreference))
                {
                    MessageBox.Show("Payment Preference is required.");
                    return;
                }

                if (string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Address is required.");
                    return;
                }

                if (string.IsNullOrEmpty(state))
                {
                    MessageBox.Show("State is required.");
                    return;
                }

                string updateProfileQuery = "UPDATE Customer SET FirstName=@FirstName, LastName=@LastName, PaymentPreference=@PaymentPreference, Address=@Address, State=@State WHERE Email=@Email";

                using (SqlCommand cmd = new SqlCommand(updateProfileQuery, con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PaymentPreference", payPreference);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@State", state);

                    int count = cmd.ExecuteNonQuery();
                    if (count == 0)
                    {
                        MessageBox.Show("Error occurred while updating the profile. Please try again.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Profile updated successfully.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the profile: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LastNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void payPrefTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void stateTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustInterface custInterface = new CustInterface();
            custInterface.Show();
            this.Hide();
        }
    }
    
}
