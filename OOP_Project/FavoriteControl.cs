using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class FavoriteControl : UserControl
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
        string userType;
        int currentUserId;
        int userId;

        bool isLoading = false;
        int currentPage = 0;
        int pageSize = 20;


        public FavoriteControl(string userTypeFromLogin, int userIdFromLogin)
        {
            InitializeComponent();
            userType = userTypeFromLogin; // Store the user's type (admin or regular)
            currentUserId = userIdFromLogin; // Store the current user's ID
        }
        public void FavoriteControl_Load(object sender, EventArgs e)
        {
            // Fetch the favorite movies first
            List<movie> favoriteMovies = GetFavoriteMovies(currentUserId, 0, 10);  // Adjust limit and offset as needed

            // Display the favorite movies
            DisplayFavoriteMovies(favoriteMovies, favoriteMovie_flp);  // Display in the FlowLayoutPanel

            // Other UI adjustments
            CurvePanel(favoriteMovie_panel, 30);
            favoriteMovie_panel.Resize += (s, args) => CurvePanel(favoriteMovie_panel, 20);

            CurvePanel(favoriteMovie_flp, 30);
            favoriteMovie_flp.Resize += (s, args) => CurvePanel(favoriteMovie_flp, 20);
        }

        public void Reload()
        {
            favoriteMovie_panel.Controls.Clear();

            // Fetch the updated list of favorite movies after removal or addition.
            List<movie> favoriteMovies = GetFavoriteMovies(currentUserId, 0, 10);  // Adjust limit and offset as needed

            // Clear the existing controls and display the updated favorite movies.
            DisplayFavoriteMovies(favoriteMovies, favoriteMovie_flp);

        }

        private async void DisplayFavoriteMovies(List<movie> favoriteMovies, FlowLayoutPanel targetPanel)
        {
            targetPanel.Controls.Clear();  // Clear the FlowLayoutPanel before adding new movie items.

            foreach (var movie in favoriteMovies)
            {
                await DisplaySingleMovie(movie, targetPanel);  // Display each movie asynchronously
            }
        }

        private async Task DisplaySingleMovie(movie movie, FlowLayoutPanel targetPanel)
        {
            Panel moviePanel = new Panel
            {
                Size = new Size(140, 180),
                Margin = new Padding(5),
                BackColor = Color.Gray,
                Cursor = Cursors.Hand,
                Tag = movie.Id // Set movie ID as Tag to detect duplicates
            };

            PictureBox poster = new PictureBox
            {
                Size = new Size(140, 180),
                Location = new Point(5, 0),
                BackColor = Color.Black,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Load cached image URLs
            var cachedImages = StayLoggedIn.GetCachedImageUrls();

            // Check if the image URL is cached
            if (!string.IsNullOrEmpty(movie.ImageUrl) && cachedImages.Contains(movie.ImageUrl))
            {
                // Load the image from the cache if it is already cached
                var image = await Task.Run(() => LoadImageFromCache(movie.ImageUrl));
                poster.Image = image ?? Properties.Resources.fallback;
            }
            else if (!string.IsNullOrEmpty(movie.ImageUrl))
            {
                // Download and cache the image if not in cache
                var image = await Task.Run(() => DownloadImageAndCache(movie.ImageUrl));
                poster.Image = image ?? Properties.Resources.fallback;

                // Add to the cached images
                var currentCachedImages = cachedImages.ToList();
                currentCachedImages.Add(movie.ImageUrl);
                StayLoggedIn.SaveCachedImages(currentCachedImages.ToArray()); // Save updated cache
            }
            else
            {
                // Use fallback image if no URL is available
                poster.Image = Properties.Resources.fallback;
            }

            // Add poster to the movie panel
            moviePanel.Controls.Add(poster);

            // Attach click to both panel and poster (for better UX)
            moviePanel.Click += (s, e) => ShowMovieDetails(movie);
            poster.Click += (s, e) => ShowMovieDetails(movie);

            targetPanel.Controls.Add(moviePanel);
        }

        public void ShowMovieDetails(movie movie)
        {
            try
            {
                var movieDetailsForm = new movie_details_form(movie, StayLoggedIn.GetCurrentUserId().Value);
                movieDetailsForm.StartPosition = FormStartPosition.CenterParent;
                movieDetailsForm.ShowDialog();
                FavoriteControl favoriteControl = new FavoriteControl(userType, currentUserId);
                favoriteControl.Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing movie details: {ex.Message}");
            }
        }

        private List<movie> GetFavoriteMovies(int userId, int offset, int limit)
        {
            List<movie> movies = new List<movie>();

            // Initialize the connection here, if it's not done already.
            if (connection == null)
            {
                connection = new MySqlConnection(connectionString); // Initialize the connection object
            }

            // SQL query to get movie ids from the Favorites table based on user_id, with pagination
            string query = @"
        SELECT f.movie_id 
        FROM Favorites f
        WHERE f.user_id = @userId
        ORDER BY f.added_at DESC
        LIMIT @limit OFFSET @offset";

            try
            {
                // Ensure the connection is open before executing commands
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                List<int> favoriteMovieIds = new List<int>();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@limit", limit);
                    cmd.Parameters.AddWithValue("@offset", offset);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            favoriteMovieIds.Add(reader.GetInt32("movie_id"));
                        }
                    }
                }

                if (favoriteMovieIds.Count > 0)
                {
                    // Query to get the movie details using the movie_ids
                    string movieDetailsQuery = @"
                SELECT m.movie_id, m.title, m.description, m.genre, m.release_year, m.rating, m.image_url
                FROM Movies m
                WHERE m.movie_id IN (" + string.Join(",", favoriteMovieIds) + ")";

                    using (MySqlCommand cmd = new MySqlCommand(movieDetailsQuery, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                movies.Add(new movie
                                {
                                    Id = reader.GetInt32("movie_id"),
                                    Title = reader.GetString("title"),
                                    Description = reader.IsDBNull(reader.GetOrdinal("description")) ? "" : reader.GetString("description"),
                                    Genre = reader.IsDBNull(reader.GetOrdinal("genre")) ? "" : reader.GetString("genre"),
                                    ReleaseYear = reader.GetInt32("release_year"),
                                    Rating = reader.IsDBNull(reader.GetOrdinal("rating")) ? 0 : reader.GetDecimal("rating"),
                                    ImageUrl = reader.IsDBNull(reader.GetOrdinal("image_url")) ? "" : reader.GetString("image_url")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching favorite movies: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return movies;
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


        private Image LoadImageFromCache(string imageUrl)
        {
            try
            {
                string cacheFolder = Path.Combine(Application.StartupPath, "ImageCache");
                string imageFileName = Path.GetFileName(imageUrl);
                string cachePath = Path.Combine(cacheFolder, imageFileName);

                // Ensure the cache folder exists
                if (File.Exists(cachePath))
                {
                    return Image.FromFile(cachePath);
                }
            }
            catch
            {
                // If there's an error, fallback to default image
                return Properties.Resources.fallback;
            }

            return null; // Return null if not cached
        }

        private async Task<Image> DownloadImageAndCache(string imageUrl)
        {
            string cacheFolder = Path.Combine(Application.StartupPath, "ImageCache");
            string imageFileName = Path.GetFileName(imageUrl);
            string cachePath = Path.Combine(cacheFolder, imageFileName);

            // Ensure the cache folder exists
            Directory.CreateDirectory(cacheFolder);

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Download the image as bytes
                    var imageBytes = await client.GetByteArrayAsync(imageUrl);

                    // Save the image to the cache
                    File.WriteAllBytes(cachePath, imageBytes);

                    // Load and return the image from the cache
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        return Image.FromStream(ms);
                    }
                }
            }
            catch
            {
                // Fallback to default image in case of error
                return Properties.Resources.fallback;
            }
        }


        // Async method to load the image and set it to the PictureBox
        private async Task LoadImageAsync(string imageUrl, PictureBox pictureBox)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var imageBytes = await client.GetByteArrayAsync(imageUrl);
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
            }
            catch
            {
                // Fallback to default image in case of any error
                pictureBox.Image = Properties.Resources.fallback;
            }
        }
    }
}
