using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;

namespace OOP_Project
{
    public partial class movie_details_form : KryptonForm
    {
        // Properties to store movieID and currentUserId
        public int MovieID { get; set; }
        public int CurrentUserId { get; set; }
        private string userType;
        private int currentUserId;

        public movie_details_form(int movieID, int currentUserId)
        {
            InitializeComponent();
            MovieID = movieID;  
            CurrentUserId = currentUserId;;
            LoadMovieDetails(); // 🔥 Load when form opens
        }

        private void LoadMovieDetails()
        {
            string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
            string query = "SELECT title, description, genre, release_year, image_url FROM Movies WHERE movie_id = @movieID";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@movieID", MovieID);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string title = reader["title"]?.ToString();
                        string description = reader["description"]?.ToString();
                        string genre = reader["genre"]?.ToString();
                        int releaseYear = reader.GetInt32("release_year");
                        string imageUrl = reader["image_url"]?.ToString();

                        title_lbl.Text = title;
                        description_lbl.Text = description;
                        releaseDate_lbl.Text = $"Release Year: {releaseYear}";

                        // Genre display handling
                        if (genre_chklb is CheckedListBox checkedList)
                        {
                            checkedList.Items.Clear();
                            foreach (string g in genre.Split(','))
                            {
                                checkedList.Items.Add(g.Trim());
                            }
                        }
                        else
                        {
                            genre_chklb.Text = $"Genre: {genre}";
                        }

                        try
                        {
                            if (Uri.IsWellFormedUriString(imageUrl, UriKind.Absolute))
                            {
                                using (var webClient = new WebClient())
                                {
                                    byte[] imageBytes = webClient.DownloadData(imageUrl);
                                    using (var stream = new MemoryStream(imageBytes))
                                    {
                                        poster_pb.Image = Image.FromStream(stream);
                                    }
                                }
                            }
                            else
                            {
                                poster_pb.Image = Image.FromFile(imageUrl);
                            }
                        }
                        catch
                        {
                            poster_pb.Image = Properties.Resources.Netflix_N_Symbol_logo;
                        }
                    }
                }
            }
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

            // 🔍 Check if the user exists
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

                // ✅ Proceed if user exists
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO movie_interaction (user_id, movie_id, rating, comment) VALUES (@userID, @movieID, @rating, @comment)", conn))
                {
                    cmd.Parameters.AddWithValue("@userID", CurrentUserId);
                    cmd.Parameters.AddWithValue("@movieID", MovieID);
                    cmd.Parameters.AddWithValue("@rating", rating);
                    cmd.Parameters.AddWithValue("@comment", comment);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Your rating and comment have been submitted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                            home_form homeForm = new home_form(userType, CurrentUserId); // Pass both userType and userId
                            homeForm.Refresh();         
                            this.Close(); // Optionally close the form
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

    }
}
