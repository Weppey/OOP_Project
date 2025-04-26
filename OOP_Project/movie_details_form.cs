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
using System.Drawing.Drawing2D;
using Microsoft.Web.WebView2.Core;


namespace OOP_Project
{
    public partial class movie_details_form : KryptonForm
    {
        private movie _moovie;
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
        private int currentUserId;
        private int movieId;
        private ToolTip tooltip = new ToolTip();
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;


        private bool isFavorited = false;

        public int MovieID { get; set; }
        public int CurrentUserId { get; set; }
        private MySqlConnection connection;
        public movie_details_form(movie moovie, int userId)
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

            CurvePanel(movie_panel, 30);
            movie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);
            CurvePanel(movieDetails_panel, 30);
            movieDetails_panel.Resize += (s, args) => CurvePanel(movieDetails_panel, 20);
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
            webView21.CoreWebView2InitializationCompleted += WebView2_CoreWebView2InitializationCompleted;
            // Update movie details on the form
            title_lbl.Text = _moovie.Title;
            description_lbl.Text = _moovie.Description;
            genre_lbl.Text = _moovie.Genre;
            dateRelease_lbl.Text = "Year released: " + _moovie.ReleaseYear;

            LoadTrailerAsync();

            try
            {
                // Load movie poster if available
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
            catch (Exception ex)
            {
                // In case of an error loading the poster or trailer, show fallback and log the error
                poster_pb.Image = Properties.Resources.fallback;
                MessageBox.Show("Error loading movie details: " + ex.Message);
            }

            // Check if the movie is marked as favorite (you can expand this logic as needed)
            CheckFavoriteStatus();
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
            string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";

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
           // MessageBox.Show($"AddToFavorites called with UserID: {userId}, MovieID: {movieId}");
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
            // Stop the video by setting the src to a blank page or empty content
            if (webView21!= null && webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.Navigate("about:blank");
            }

            // Close the form
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
