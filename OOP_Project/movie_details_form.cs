using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;

namespace OOP_Project
{
    public partial class movie_details_form : KryptonForm
    {
        public int MovieID { get; set; }
        public int CurrentUserId { get; set; }
        private string userType;

        public movie_details_form(int movieID, int currentUserId)
        {
            InitializeComponent();
            MovieID = movieID;
            CurrentUserId = currentUserId;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (rating_cmb.SelectedItem == null)
            {
                MessageBox.Show("Please select a rating.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rating = Convert.ToInt32(rating_cmb.SelectedItem);
            string comment = comment_tb.Text.Trim();
            string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM users WHERE user_id = @userID", conn))
                {
                    checkCmd.Parameters.AddWithValue("@userID", CurrentUserId);
                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (exists == 0)
                    {
                        MessageBox.Show("Invalid user session. Please log in again.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO movie_interaction (user_id, movie_id, rating, comment) VALUES (@userID, @movieID, @rating, @comment)", conn))
                {
                    cmd.Parameters.AddWithValue("@userID", CurrentUserId);
                    cmd.Parameters.AddWithValue("@movieID", MovieID);
                    cmd.Parameters.AddWithValue("@rating", rating);
                    cmd.Parameters.AddWithValue("@comment", comment);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(
                        rowsAffected > 0 ? "Your rating and comment have been submitted." : "An error occurred. Please try again.",
                        rowsAffected > 0 ? "Success" : "Error",
                        MessageBoxButtons.OK,
                        rowsAffected > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error
                    );
                }
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove this movie?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
                string query = "DELETE FROM Movies WHERE movie_id = @movieID";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@movieID", MovieID);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Movie has been removed successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            var homeForm = new home_form(userType, CurrentUserId);
                            homeForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Movie not found or could not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void movie_details_form_Load(object sender, EventArgs e)
        {

        }
    }
}
