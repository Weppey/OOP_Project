﻿using System;
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
using System.Drawing.Drawing2D;
using Microsoft.Web.WebView2.Core;
using System.IO;
using System.Diagnostics;


namespace OOP_Project
{
    public partial class movie_details_form : KryptonForm
    {
        private movie _moovie;
        private int currentUserId;
        private int movieId;
        private ToolTip tooltip = new ToolTip();
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;

        private string userType;
        private bool isFavorited = false;

        private int currentMovieId;
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=remmmdb;Uid=root;Pwd=;";
        public int selectedMovieId;
        private string currentUserType;
        public movie_details_form(movie moovie, int userId, int interactionId = 0, string comment = "")
        {
            InitializeComponent();
            _moovie = moovie;
            currentUserId = userId;

            movieId = moovie.Id;        // <-- set this first
            currentMovieId = movieId;    // <-- then assign
            selectedMovieId = movieId;
            poster_pb.SizeMode = PictureBoxSizeMode.Zoom;


            //Tooltip messages
            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 100;
            tooltip.ReshowDelay = 100;
            tooltip.ShowAlways = true;
            tooltip.SetToolTip(description_lbl, "Close");

            CurvePanel(movie_panel, 30);
            movie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

            CurvePanel(movieDetails_panel, 30);
            movieDetails_panel.Resize += (s, args) => CurvePanel(movieDetails_panel, 20);

            CurvePanel(commentBorder_panel, 30);
            commentBorder_panel.Resize += (s, args) => CurvePanel(commentBorder_panel, 20);

            CurvePanel(comments_panel, 30);
            comments_panel.Resize += (s, args) => CurvePanel(comments_panel, 20);

            CurvePanel(ratings_panel, 30);
            ratings_panel.Resize += (s, args) => CurvePanel(ratings_panel, 20);
            ApplyTheme(this);
        }


        public void ApplyTheme(Form movie_details_form)
        {
            Color labelForeColor = ThemeManager.IsDarkMode ? Color.Gray : Color.Gray;
            Color panelColor = ThemeManager.IsDarkMode ? Color.FromArgb(26, 26, 26) : Color.DarkGray;
            Color moviePanelColor = ThemeManager.IsDarkMode ? Color.FromArgb(26, 26, 26) : Color.LightGray;

            this.BackColor = panelColor;
            navigationDock_panel.BackColor = panelColor;

            if (movie_details_form != null)
            {
                movie_details_form.BackColor = panelColor;

                // Apply to all controls
                ThemeManager.ApplyThemeToControls(
                    movie_details_form.Controls,
                    labelForeColor,
                    panelColor,
                    panelColor,
                    panelColor,
                    panelColor
                );
            }

            // Local panels
            movieDetails_panel.BackColor = moviePanelColor;
            movie_panel.BackColor = moviePanelColor;
            movie_panel.BackColor = moviePanelColor;
            genre_lbl.ForeColor = ThemeManager.IsDarkMode ? Color.White : Color.Black;
            dateRelease_lbl.ForeColor = ThemeManager.IsDarkMode ? Color.White : Color.Black;
            description_lbl.ForeColor = ThemeManager.IsDarkMode ? Color.White : Color.FromArgb(30, 30, 30);

            title_lbl.ForeColor = ThemeManager.IsDarkMode ? Color.White : Color.Black;
        }


        private void CurvePanel(System.Windows.Forms.Panel panel, int radius) // Method to apply curved corners to a panel
        {
            GraphicsPath path = new GraphicsPath(); // Method to apply curved corners to a panel
            path.StartFigure(); // Start the shape definition

            // Add arcs to the path to define the four rounded corners
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Top-left corner
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90); // Top-left corner
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90); // Bottom-right corner
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90); // Bottom-left corner
            path.CloseFigure(); // Close the shape definition
            panel.Region = new Region(path); // Apply the custom shape to the panel by setting its Region property
        }
        private void MovieDetailsForm_Load(object sender, EventArgs e)
        {
            //  movie_panel.Size = new Size(981, 575);
            //this.Size = new Size(1052, 672);
            LoadComments();
            FetchCurrentRatingFromDatabase();

            webView21.CoreWebView2InitializationCompleted += WebView2_CoreWebView2InitializationCompleted;
            // Update movie details on the form
            title_lbl.Text = _moovie.Title;
            description_lbl.Text = _moovie.Description;
            genre_lbl.Text = _moovie.Genre;
            dateRelease_lbl.Text = "Year released: " + _moovie.ReleaseYear;

            LoadTrailerAsync();


            // Attach the click event handlers
            ratingStar1_btn.Click += StarButton_Click;
            ratingStar2_btn.Click += StarButton_Click;
            ratingStar3_btn.Click += StarButton_Click;
            ratingStar4_btn.Click += StarButton_Click;
            ratingStar5_btn.Click += StarButton_Click;


            try
            {
                // Check if ImageUrl is provided
                if (!string.IsNullOrEmpty(_moovie.ImageUrl))
                {
                    poster_pb.Load(_moovie.ImageUrl); // Try loading the image
                    this.BackgroundImage = poster_pb.Image;
                    movie_panel.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    // Image URL is missing
                    poster_pb.Image = Properties.Resources.fallback;
                    MessageBox.Show("Movie poster is missing.", "Missing Poster", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Something went wrong while loading the image
                poster_pb.Image = Properties.Resources.fallback;
                MessageBox.Show("Error loading movie poster: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Check if the movie is marked as favorite (you can expand this logic as needed)
            CheckFavoriteStatus();
        }

        private void FetchCurrentRatingFromDatabase()
        {
            string query = @"SELECT rating FROM movie_interaction WHERE user_id = @userId AND movie_id = @movieId";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", currentUserId); // current logged-in user
                        cmd.Parameters.AddWithValue("@movieId", movieId); // current movie

                        var result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            int rating = Convert.ToInt32(result);
                            SetStars(rating); // Show existing rating
                        }
                        else
                        {
                            SetStars(0); // No rating found — show all unselected
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to fetch rating: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void WebView2_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                // WebView2 is initialized, now load the trailer
                LoadTrailerAsync();
            }
            else
            {
                MessageBox.Show("WebView2 initialization failed: " + e.InitializationException.Message);
            }
        }
        private async Task LoadTrailerAsync()
        {
            string trailerUrl = GetTrailerUrl(movieId);

            if (string.IsNullOrEmpty(trailerUrl))
            {
                MessageBox.Show("Trailer URL is missing for this movie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (webView21 == null)
            {
                MessageBox.Show("WebView2 control is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await webView21.EnsureCoreWebView2Async();

            if (trailerUrl.Contains("youtu"))
            {
                string videoId = ExtractYouTubeVideoId(trailerUrl);
                if (string.IsNullOrEmpty(videoId))
                {
                    MessageBox.Show("Invalid YouTube URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Construct the embed URL
                string embedUrl = $"https://www.youtube.com/embed/{videoId}?autoplay=1&controls=1";

                // Create HTML to embed in WebView2
                string html = $@"
        <html>
            <body style='margin:0px;padding:0px;overflow:hidden;background-color:black;'>
                <iframe width='100%' height='100%' src='{embedUrl}' frameborder='0' allowfullscreen></iframe>
            </body>
        </html>";

                // Navigate to the constructed HTML
                webView21.NavigateToString(html);
            }
            else
            {
                // Handle other video formats (MP4) here
                string html = $@"
        <html>
            <body style='margin:0px;padding:0px;overflow:hidden;background-color:black;'>
                <video width='100%' height='100%' controls autoplay>
                    <source src='{trailerUrl}' type='video/mp4'>
                    Your browser does not support the video tag.
                </video>
            </body>
        </html>";

                webView21.NavigateToString(html);
            }
        }

        private string ExtractYouTubeVideoId(string url)
        {
            if (url.Contains("youtu.be/"))
            {
                // Short YouTube link
                var uri = new Uri(url);
                return uri.AbsolutePath.Trim('/');
            }
            else if (url.Contains("youtube.com/watch"))
            {
                // Regular YouTube link
                var query = System.Web.HttpUtility.ParseQueryString(new Uri(url).Query);
                return query["v"];
            }
            return "";
        }


        private string GetTrailerUrl(int movieId)
        {
            string trailerUrl = "";
            string connectionString = "Server=localhost;Database=remmmdb;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT trailer_link FROM movies WHERE movie_id = @movieId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@movieId", movieId);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    trailerUrl = result.ToString();
                }
            }

            return trailerUrl;
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
            if (userId <= 0 || movieId <= 0)
            {
                MessageBox.Show("Invalid user or movie ID. Please ensure both are valid.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            MessageBox.Show("This movie is already in your favorites.", "Already Favorited", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            MessageBox.Show("Movie has been successfully added to your favorites!", "Added to Favorites", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            isFavorited = true;  // Update favorite status
                            favorite_btn.Text = "Remove from Favorites";  // Correct text after adding
                                                                          // Create an instance of FavoriteControl
                            FavoriteControl favoriteControl = new FavoriteControl(userType, currentUserId);
                            favoriteControl.Reload();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add movie to favorites. Please try again later.", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding to favorites: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show("Movie has been successfully removed from your favorites.", "Removed from Favorites", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            isFavorited = false;  // Update favorite status
                            favorite_btn.Text = "Add to Favorites";  // Correct text after removal
                            FavoriteControl favoriteControl = new FavoriteControl(userType, currentUserId);
                            favoriteControl.Reload();
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove movie from favorites. Please try again later.", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing from favorites: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void close_pb_Click(object sender, EventArgs e)
        {
            // Stop the video by setting the src to a blank page or empty content
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.Navigate("about:blank");
            }

            // Close the form
            Close();
        }


        private void description_lbl_Click(object sender, EventArgs e)
        {
            bool isExpanded = description_lbl.Height > 125;

            if (!isExpanded)
            {
                tooltip.SetToolTip(description_lbl, "Close");
                description_lbl.Height = 200;
                description_lbl.BackColor = ThemeManager.IsDarkMode ? Color.DarkGray : Color.Silver;
                description_lbl.ForeColor = ThemeManager.IsDarkMode ? Color.White : Color.Black;
                movieDetails_panel.AutoScroll = true;
                movie_panel.AutoScroll = true;
            }
            else
            {
                tooltip.SetToolTip(description_lbl, "Expand");
                description_lbl.Height = 125;
                description_lbl.BackColor = Color.Transparent;
                description_lbl.ForeColor = ThemeManager.IsDarkMode ? Color.White : Color.FromArgb(30, 30, 30);
                movieDetails_panel.AutoScroll = false;
                movie_panel.AutoScroll = false;
            }
        }


        private Timer expandTimer;
        private int targetWidth;
        private int currentWidth;
        private bool isAnimating = false; // Flag to track animation state

        private void StartExpandAnimation()
        {
            if (isAnimating) return; // Prevent animation if one is already in progress

            isAnimating = true; // Mark animation as in progress
            ratings_panel.Visible = true;
            targetWidth = 195;  // Set this to the final width (195 in your case)
            currentWidth = 0;   // Start with the panel collapsed (width = 0)

            ratings_panel.Width = currentWidth;  // Set initial width

            expandTimer = new Timer();
            expandTimer.Interval = 1;  // Speed of the expansion (milliseconds)
            expandTimer.Tick += (s, e) =>
            {
                currentWidth += 15; // Increased increment to speed up the expansion (adjust as needed)
                if (currentWidth >= targetWidth)
                {
                    currentWidth = targetWidth;
                    expandTimer.Stop(); // Stop the timer once the panel has expanded fully
                    isAnimating = false; // Mark animation as finished
                }

                ratings_panel.Width = currentWidth;  // Update the width of the panel
            };
            expandTimer.Start();
        }

        private void UpdateMovieAverageRating(int movieId)
        {
            string averageQuery = @"SELECT AVG(rating) FROM movie_interaction WHERE movie_id = @movieId";
            string updateMovieQuery = @"UPDATE movies SET rating = @averageRating WHERE movie_id = @movieId";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Get average rating
                    double averageRating = 0;
                    using (MySqlCommand avgCmd = new MySqlCommand(averageQuery, conn))
                    {
                        avgCmd.Parameters.AddWithValue("@movieId", movieId);
                        object result = avgCmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            averageRating = Math.Round(Convert.ToDouble(result), 2); // Round to 2 decimal places
                        }
                    }

                    // Update the movie's rating
                    using (MySqlCommand updateCmd = new MySqlCommand(updateMovieQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@averageRating", averageRating);
                        updateCmd.Parameters.AddWithValue("@movieId", movieId);
                        updateCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update movie average rating: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void StartCollapseAnimation()
        {
            if (isAnimating) return; // Prevent animation if one is already in progress

            isAnimating = true; // Mark animation as in progress
            int currentWidth = ratings_panel.Width;

            expandTimer = new Timer();
            expandTimer.Interval = 1;  // Speed of the collapse (milliseconds)
            expandTimer.Tick += (s, e) =>
            {
                currentWidth -= 15; // Increased decrement to speed up the collapse (adjust as needed)
                if (currentWidth <= 0)
                {
                    currentWidth = 0;
                    expandTimer.Stop(); // Stop the timer once the panel has collapsed fully
                    ratings_panel.Visible = false;  // Hide the panel once collapsed
                    isAnimating = false; // Mark animation as finished
                }

                ratings_panel.Width = currentWidth;  // Update the width of the panel
            };
            expandTimer.Start();
        }

        private void ratings_btn_Click(object sender, EventArgs e)
        {
            if (!ratings_panel.Visible)
            {
                // Start expanding animation for the ratings panel
                StartExpandAnimation();
            }
            else
            {
                // Start collapsing animation for the ratings panel
                StartCollapseAnimation();
            }
        }


        private void InitializeStars()
        {
            KryptonButton[] stars = { ratingStar1_btn, ratingStar2_btn, ratingStar3_btn, ratingStar4_btn, ratingStar5_btn };

            for (int i = 0; i < stars.Length; i++)
            {
                int rating = i + 1;
                stars[i].Click += (s, e) =>
                {
                    SetStars(rating);
                    SaveRatingToDatabase(rating);
                };
            }
        }

        KryptonButton[] stars;
        int currentRating = 0; // store selected rating


        private void SaveRatingToDatabase(int rating)
        {
            string query = @"SELECT COUNT(*) FROM movie_interaction 
                     WHERE user_id = @userId AND movie_id = @movieId";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the rating already exists in the database
                    using (MySqlCommand checkCmd = new MySqlCommand(query, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@userId", currentUserId); // current logged-in user
                        checkCmd.Parameters.AddWithValue("@movieId", movieId); // current movie

                        int ratingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        // If rating exists, update it
                        if (ratingCount > 0)
                        {
                            string updateQuery = @"UPDATE movie_interaction 
                                           SET rating = @rating 
                                           WHERE user_id = @userId AND movie_id = @movieId";

                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@rating", rating);
                                updateCmd.Parameters.AddWithValue("@userId", currentUserId);
                                updateCmd.Parameters.AddWithValue("@movieId", movieId);

                                updateCmd.ExecuteNonQuery(); UpdateMovieAverageRating(movieId);

                            }
                        }
                        else
                        {
                            // If no existing rating, insert new record
                            string insertQuery = @"INSERT INTO movie_interaction (user_id, movie_id, rating, created_at) 
                                           VALUES (@userId, @movieId, @rating, @createdAt)";

                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@userId", currentUserId);
                                insertCmd.Parameters.AddWithValue("@movieId", movieId);
                                insertCmd.Parameters.AddWithValue("@rating", rating);
                                insertCmd.Parameters.AddWithValue("@createdAt", DateTime.Now);

                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save rating: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetStars(int rating)
        {
            KryptonButton[] stars = { ratingStar1_btn, ratingStar2_btn, ratingStar3_btn, ratingStar4_btn, ratingStar5_btn };

            for (int i = 0; i < stars.Length; i++)
            {
                if (i < rating)
                    stars[i].Values.Image = Properties.Resources.icons8_star_28_yellow; // Yellow star for selected
                else
                    stars[i].Values.Image = Properties.Resources.icons8_star_white; // Gray star for unselected
            }

            currentRating = rating; // Store the current rating
        }

        private void StarButton_Click(object sender, EventArgs e)
        {
            // Get the clicked star's rating (determine which star was clicked)
            int rating = 0;
            if (sender == ratingStar1_btn) rating = 1;
            else if (sender == ratingStar2_btn) rating = 2;
            else if (sender == ratingStar3_btn) rating = 3;
            else if (sender == ratingStar4_btn) rating = 4;
            else if (sender == ratingStar5_btn) rating = 5;

            // Set the stars and save the rating to the database
            SetStars(rating);
            SaveRatingToDatabase(rating);
        }

        private void submit_comment_btn_Click(object sender, EventArgs e)
        {
            string commentText = comment_tb.Text.Trim();
            if (string.IsNullOrEmpty(commentText) || commentText == "Enter comments...")
            {
                comment_tb.BackColor = Color.MistyRose; // Light red background to warn
                ToolTip tooltip = new ToolTip();
                tooltip.ToolTipTitle = "Invalid Comment";
                tooltip.Show("Please enter a comment before submitting.", comment_tb, 0, -40, 2000);

                return;
            }
            else
            {
                comment_tb.BackColor = Color.White; // Reset background if valid
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the movie exists
                    string checkMovieQuery = "SELECT COUNT(*) FROM movies WHERE movie_id = @movieId";
                    using (MySqlCommand checkMovieCmd = new MySqlCommand(checkMovieQuery, conn))
                    {
                        checkMovieCmd.Parameters.AddWithValue("@movieId", currentMovieId);

                        int movieCount = Convert.ToInt32(checkMovieCmd.ExecuteScalar());
                        if (movieCount == 0)
                        {
                            MessageBox.Show("The selected movie does not exist.");
                            return;
                        }
                    }

                    // Insert a new comment (ALWAYS insert, even if same user)
                    string insertQuery = "INSERT INTO movie_interaction (user_id, movie_id, comment, created_at) VALUES (@userId, @movieId, @comment, NOW())";
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@userId", currentUserId);
                        insertCmd.Parameters.AddWithValue("@movieId", currentMovieId);
                        insertCmd.Parameters.AddWithValue("@comment", commentText);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                comment_tb.Clear();
                LoadComments(); // Refresh comments
                comment_tb.ForeColor = Color.Gray;
                comment_tb.Text = "Enter comments...";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error posting comment: " + ex.Message);
            }
        }


        private void editComment_btn_Click(object sender, EventArgs e)
        {
            // Assuming you have the Interaction ID stored in the UserControl or retrieved in some way
            int interactionId = 123; // Replace with actual Interaction ID

            string currentComment = comment_lbl.Text; // Assuming you have a label for the comment text

            // Show the comment in the text box to edit
            comment_tb.Text = currentComment;
            comment_tb.Focus(); // Optionally focus the textbox for editing

            // Change the button to save changes
            submit_comment_btn.Text = "Save Changes"; // Or change it to something indicating editing

            // Handle the Save Changes functionality
            submit_comment_btn.Click += new EventHandler((object clickSender, EventArgs clickE) =>
            {
                string updatedComment = comment_tb.Text.Trim();
                if (!string.IsNullOrEmpty(updatedComment) && updatedComment != "Enter comments...")
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();

                            string updateQuery = "UPDATE movie_interaction SET comment = @comment WHERE interaction_id = @interactionId";
                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@comment", updatedComment);
                                updateCmd.Parameters.AddWithValue("@interactionId", interactionId);
                                updateCmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Comment updated successfully!");
                        comment_tb.Clear();
                        LoadComments(); // Refresh comments
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating comment: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid comment.");
                }
            }
            );
        }

        public void LoadComments()
        {
            comments_panel.Controls.Clear();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT i.interaction_id, i.user_id, u.username, u.avatar, 
                       i.comment, i.created_at, i.edited_comment
                FROM movie_interaction i
                JOIN users u ON i.user_id = u.user_id
                WHERE i.movie_id = @movieId AND i.comment IS NOT NULL
                ORDER BY i.created_at DESC"; // Using created_at for sorting

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@movieId", currentMovieId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                Label noCommentLabel = new Label
                                {
                                    Text = "No comments yet. Be the first to comment!",
                                    Font = new Font("Segoe UI", 10, FontStyle.Italic),
                                    ForeColor = Color.Gray,
                                    AutoSize = true,
                                    Margin = new Padding(1)
                                };
                                comments_panel.Controls.Add(noCommentLabel);
                            }
                            else
                            {
                                while (reader.Read())
                                {
                                    string username = reader["username"]?.ToString() ?? "Unknown";
                                    string comment = reader["comment"]?.ToString() ?? "";
                                    DateTime createdAt = reader.GetDateTime("created_at");
                                    int interactionId = reader.GetInt32("interaction_id");
                                    int commentUserId = reader.GetInt32("user_id");

                                    // Check if edited_comment exists and show "[Edited]" in the commentReply_lbl
                                    bool isEdited = !reader.IsDBNull(reader.GetOrdinal("edited_comment")) && Convert.ToBoolean(reader["edited_comment"]);

                                    commentCard card = new commentCard();
                                    card.SetComment(username, comment, createdAt);

                                    // Add "[Edited]" to the commentReply_lbl if the comment was edited
                                    if (isEdited)
                                    {
                                        card.isEdited();
                                    }
                                    else
                                    {
                                        card.isNotEdited();
                                    }

                                    // Handle avatar
                                    if (!reader.IsDBNull(reader.GetOrdinal("avatar")))
                                    {
                                        byte[] avatarBytes = (byte[])reader["avatar"];
                                        if (avatarBytes.Length > 0)
                                        {
                                            using (MemoryStream ms = new MemoryStream(avatarBytes))
                                            using (Image avatarImage = Image.FromStream(ms))
                                            {
                                                card.SetAvatar((Image)avatarImage.Clone());
                                            }
                                        }
                                        else
                                        {
                                            card.SetAvatar(null);
                                        }
                                    }
                                    else
                                    {
                                        card.SetAvatar(null);
                                    }

                                    // Assign current and comment user info
                                    card.CommentOwnerId = commentUserId;
                                    card.CurrentUserId = currentUserId;
                                    card.UserType = currentUserType;

                                    card.InitializeCommentCard(interactionId, commentUserId, currentUserId, currentMovieId);

                                    card.Width = comments_panel.Width - 30;
                                    card.Margin = new Padding(1);
                                    comments_panel.Controls.Add(card);

                                    comment_tb.ForeColor = Color.Gray;
                                    comment_tb.Text = "Enter comments...";
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading comments: " + ex.Message);
            }
        }


        private void comment_btn_Click_1(object sender, EventArgs e)
        {
            if (!submit_comment_btn.Visible)
            {
                submit_comment_btn.Visible = true;
                comment_tb.Visible = true;

                movie_panel.AutoScroll = true;

            }
            else
            {

                submit_comment_btn.Visible = false;
                comment_tb.Visible = false;

                movie_panel.AutoScroll = false;
            }
        }

        private void comment_tb_Leave(object sender, EventArgs e)
        {
            if (comment_tb.Text == "")
            {
                comment_tb.ForeColor = Color.Gray;
                comment_tb.Text = "Enter comments...";
            }

            }   

        private void comment_tb_Enter(object sender, EventArgs e)
        {
            if (comment_tb.Text == "Enter comments...")
            {
                comment_tb.BackColor = Color.White;
                comment_tb.ForeColor = Color.Black;
                comment_tb.Text = "";
            }
        }
        private void watch_btn_Click(object sender, EventArgs e)
        {


            int movieId = selectedMovieId; // Get this from your context

            string connectionString = "Server=localhost;Database=remmmdb;Uid=root;Pwd=;";
            string query = "SELECT movie_url FROM movies WHERE movie_id = @movieId";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@movieId", movieId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string movieUrl = reader["movie_url"].ToString();

                                if (!string.IsNullOrWhiteSpace(movieUrl) && Uri.IsWellFormedUriString(movieUrl, UriKind.Absolute))
                                {
                                    movie_stream_control webForm = new movie_stream_control(movieUrl);
                                    webForm.Show(); // or Show()
                                }
                                else
                                {
                                    MessageBox.Show("Invalid or missing movie URL.");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void close_pb_MouseEnter(object sender, EventArgs e)
        {
            close_pb.BackColor = Color.FromArgb(226, 0, 39);
        }
        private void close_pb_MouseLeave(object sender, EventArgs e)
        {
            close_pb.BackColor = Color.Transparent;
        }
    }
}
