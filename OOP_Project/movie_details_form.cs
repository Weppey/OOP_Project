using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;

namespace OOP_Project
{
    public partial class movie_details_form : KryptonForm
    {
        private Movie _moovie;
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
        private int currentUserId;
        private int movieId;
        private ToolTip tooltip = new ToolTip();

        private bool isFavorited = false;

        public int MovieID { get; set; }
        public int CurrentUserId { get; set; }

        public movie_details_form(Movie moovie, int userId)
        {
            InitializeComponent();
            _moovie = moovie;
            currentUserId = userId;
            movieId = moovie.Id;
            poster_pb.SizeMode = PictureBoxSizeMode.Zoom;

            //Tooltip messages
            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 100;
            tooltip.ReshowDelay = 100;
            tooltip.ShowAlways = true;
            tooltip.SetToolTip(description_lbl, "Close");
        }

        private void MovieDetailsForm_Load(object sender, EventArgs e)
        {
            title_lbl.Text = _moovie.Title;
            description_lbl.Text = _moovie.Description;
            genre_lbl.Text = _moovie.Genre;
            dateRelease_lbl.Text = "Year released: " + _moovie.ReleaseYear;

            try
            {
                if (!string.IsNullOrEmpty(_moovie.ImageUrl))
                {
                    poster_pb.Load(_moovie.ImageUrl);
                    this.BackgroundImage = poster_pb.Image;
                    movie_panel.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    poster_pb.Image = Properties.Resources.fallback;
                }
            }
            catch
            {
                poster_pb.Image = Properties.Resources.fallback;
            }

            CheckFavoriteStatus(); // NEW LINE
        }

        private void CheckFavoriteStatus()
        {
            string query = "SELECT COUNT(*) FROM Favorites WHERE user_id = @userId AND movie_id = @movieId";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", currentUserId);
                        cmd.Parameters.AddWithValue("@movieId", movieId);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isFavorited = count > 0;
                        favorite_btn.Text = isFavorited ? "Remove from Favorites" : "Add to Favorites";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking favorite status: " + ex.Message);
            }
        }

        private void favorite_btn_Click(object sender, EventArgs e)
        {
            if (isFavorited)
            {
                RemoveFromFavorites(currentUserId, movieId);
            }
            else
            {
                AddToFavorites(currentUserId, movieId);
            }
        }

        private void AddToFavorites(int userId, int movieId)
        {
            MessageBox.Show($"AddToFavorites called with UserID: {userId}, MovieID: {movieId}");
            if (userId <= 0 || movieId <= 0)
            {
                MessageBox.Show("Invalid user or movie ID.");
                return;
            }

            string checkQuery = "SELECT COUNT(*) FROM Favorites WHERE user_id = @userId AND movie_id = @movieId";
            string insertQuery = "INSERT INTO Favorites (user_id, movie_id) VALUES (@userId, @movieId)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if already favorited
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@userId", userId);
                        checkCmd.Parameters.AddWithValue("@movieId", movieId);

                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (exists > 0)
                        {
                            MessageBox.Show("This movie is already in your favorites.");
                            isFavorited = true;
                            favorite_btn.Text = "Remove from Favorites";  // Correct text for already favorited
                            return;
                        }
                    }

                    // Insert if not already favorited
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@userId", userId);
                        insertCmd.Parameters.AddWithValue("@movieId", movieId);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Added to Favorites!");
                            isFavorited = true;  // Update favorite status
                            favorite_btn.Text = "Remove from Favorites";  // Correct text after adding
                        }
                        else
                        {
                            MessageBox.Show("Failed to add to favorites.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding to favorites: " + ex.Message);
            }
        }

        private void RemoveFromFavorites(int userId, int movieId)
        {
            string deleteQuery = "DELETE FROM Favorites WHERE user_id = @userId AND movie_id = @movieId";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@movieId", movieId);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Removed from favorites.");
                            isFavorited = false;  // Update favorite status
                            favorite_btn.Text = "Add to Favorites";  // Correct text after removal
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove from favorites.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing from favorites: " + ex.Message);
            }
        }


        // Other event handlers...

        private void comment_btn_Click(object sender, EventArgs e)
        {
            if (this.Size.Height == 620)
            {
                this.Size = new Size(1050, 700);
            }
            else
            {
                this.Size = new Size(1050, 620);
            }
        }

        private void close_pb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void description_lbl_Click(object sender, EventArgs e)
        {
            if (description_lbl.Width == 210)
            {
                tooltip.SetToolTip(description_lbl, "Close"); // Fixed missing closing quote
                description_lbl.Width = 300;
                description_lbl.BackColor = Color.Silver;
                description_lbl.ForeColor = Color.Black;
            }
            else
            {
                description_lbl.Width = 210;
                tooltip.SetToolTip(description_lbl, "Expand");
                description_lbl.BackColor = Color.Transparent;
                description_lbl.ForeColor = Color.White;
            }
        }

    }
}
