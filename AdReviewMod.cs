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
using System.Xml.Linq;

namespace Project
{
    public partial class AdReviewMod : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False");
        public AdReviewMod()
        {
            InitializeComponent();
        }
        private void LoadReviews(int statusID)
        {

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    string query = "SELECT r.ReviewID, r.CustomerID, r.ProductID, r.Rating, r.Comment, s.StatusName " +
                                   "FROM Review r INNER JOIN ReviewStatus s ON r.StatusID = s.StatusID " +
                                   "WHERE r.StatusID = @StatusID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@StatusID", statusID);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    ReviewGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading reviews: " + ex.Message);
                }
            }
        }

        private void PopulateReviewStatusFilter()
        {
            comboBoxReviewStatus.Items.Clear();  // Clear any existing items

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    string query = "SELECT StatusID, StatusName FROM ReviewStatus";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBoxReviewStatus.DataSource = dt;
                    comboBoxReviewStatus.DisplayMember = "StatusName";
                    comboBoxReviewStatus.ValueMember = "StatusID";

                    if (comboBoxReviewStatus.Items.Count > 0)
                    {
                        comboBoxReviewStatus.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading review statuses: " + ex.Message);
                }
            }
        }


        private int GetStatusIDByName(string statusName)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    string query = "SELECT StatusID FROM ReviewStatus WHERE StatusName = @StatusName";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StatusName", statusName);

                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Status not found.");
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching StatusID: " + ex.Message);
                    return -1;
                }
            }
        }

        private void ReviewGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ApproveReview(int reviewID)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    string query = "UPDATE Review SET StatusID = (SELECT StatusID FROM ReviewStatus WHERE StatusName = 'Approved') WHERE ReviewID = @ReviewID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ReviewID", reviewID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Review approved.");
                    int statusID = Convert.ToInt32(comboBoxReviewStatus.SelectedValue);
                    LoadReviews(statusID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error approving review: " + ex.Message);
                }
            }
        }

        private void RejectReview(int reviewID, string rejectionReason)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    string fetchQuery = "SELECT Comment FROM Review WHERE ReviewID = @ReviewID";
                    SqlCommand fetchCmd = new SqlCommand(fetchQuery, con);
                    fetchCmd.Parameters.AddWithValue("@ReviewID", reviewID);

                    con.Open();
                    SqlDataReader reader = fetchCmd.ExecuteReader();

                    string existingComment = string.Empty;
                    if (reader.Read())
                    {
                        existingComment = reader["Comment"].ToString();
                    }
                    reader.Close();
                    string updatedComment = existingComment + " (Rejection Reason: " + rejectionReason + ")";

                    string updateQuery = "UPDATE Review SET StatusID = (SELECT StatusID FROM ReviewStatus WHERE StatusName = 'Rejected'), Comment = @UpdatedComment WHERE ReviewID = @ReviewID";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                    updateCmd.Parameters.AddWithValue("@UpdatedComment", updatedComment);
                    updateCmd.Parameters.AddWithValue("@ReviewID", reviewID);

                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Review rejected.");
                    int selectedStatusID = Convert.ToInt32(comboBoxReviewStatus.SelectedValue);
                    LoadReviews(selectedStatusID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error rejecting review: " + ex.Message);
                }
            }
        }


        private void comboBoxReviewStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void RejectButton_Click_1(object sender, EventArgs e)
        {
            if (ReviewGridView.SelectedRows.Count > 0)
            {
                int reviewID = Convert.ToInt32(ReviewGridView.SelectedRows[0].Cells["ReviewID"].Value);
                string rejectionReason = txtRejectionReason.Text;

                if (string.IsNullOrEmpty(rejectionReason))
                {
                    MessageBox.Show("Please provide a reason for rejection.");
                    return;
                }

                RejectReview(reviewID, rejectionReason);
            }
            else
            {
                MessageBox.Show("Please select a review to reject.");
            }
        }

        private void ApproveButton_Click_1(object sender, EventArgs e)
        {
            if (ReviewGridView.SelectedRows.Count > 0)
            {
                int reviewID = Convert.ToInt32(ReviewGridView.SelectedRows[0].Cells["ReviewID"].Value);
                ApproveReview(reviewID);
            }
            else
            {
                MessageBox.Show("Please select a review to approve.");
            }
        }

        private void AdReviewMod_Load_1(object sender, EventArgs e)
        {
            PopulateReviewStatusFilter();
            int pendingStatusID = GetStatusIDByName("Pending");
            LoadReviews(pendingStatusID);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ReviewGridView.SelectedRows.Count > 0)
            {
                int reviewID = Convert.ToInt32(ReviewGridView.SelectedRows[0].Cells["ReviewID"].Value);

                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
                {
                    try
                    {
                        string query = "SELECT StatusID FROM Review WHERE ReviewID = @ReviewID";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@ReviewID", reviewID);

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int statusID = Convert.ToInt32(reader["StatusID"]);
                            comboBoxReviewStatus.SelectedValue = statusID; // Set the combo box to the current status
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading review for editing: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a review to edit.");
            }
        }


        private void FilterButton_Click(object sender, EventArgs e)
        {
            int selectedStatusID = (int)comboBoxReviewStatus.SelectedValue;
            LoadReviews(selectedStatusID);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ReviewGridView.SelectedRows.Count > 0)
            {
                int reviewID = Convert.ToInt32(ReviewGridView.SelectedRows[0].Cells["ReviewID"].Value);
                int newStatusID = (int)comboBoxReviewStatus.SelectedValue; // Get the selected status ID from combo box

                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8PIF3V;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
                {
                    try
                    {
                        string query = "UPDATE Review SET StatusID = @StatusID WHERE ReviewID = @ReviewID";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@StatusID", newStatusID);
                        cmd.Parameters.AddWithValue("@ReviewID", reviewID);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Review status updated successfully.");
                            int selectedStatusID = (int)comboBoxReviewStatus.SelectedValue;
                            LoadReviews(selectedStatusID);  // Reload reviews based on selected status
                        }
                        else
                        {
                            MessageBox.Show("Error updating review status.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving review status: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a review to save.");
            }
        }
    }
}
