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
using static OOP_Project.StayLoggedIn;

namespace OOP_Project
{
    public partial class PopularControl : UserControl
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=remmmdb;Uid=root;Pwd=;";
        string userType;
        int currentUserId;
        int userId;

        bool isLoading = false;
        int currentPage = 0;
        int pageSize = 20;

        private void PopularControl_Load(object sender, EventArgs e)
        {
            List<movie> popularMovies = GetPopularMovies(0, 10);
            DisplayFavoriteMovies(popularMovies, popularMovie_flp);

            // Other UI adjustments
            CurvePanel(popularMovie_flp, 30);
            popularMovie_flp.Resize += (s, args) => CurvePanel(popularMovie_flp, 20);

            CurvePanel(popularMovie_panel, 30);
            popularMovie_panel.Resize += (s, args) => CurvePanel(popularMovie_panel, 20);

            CurvePanel(popularPanel_panel, 30);
            popularPanel_panel.Resize += (s, args) => CurvePanel(popularPanel_panel, 20); 

        }

        public PopularControl(string userTypeFromLogin, int userIdFromLogin)
        {
            InitializeComponent();
            userType = userTypeFromLogin; // Store the user's type (admin or regular)
            currentUserId = userIdFromLogin; // Store the current user's ID
            ApplyTheme();
        }

        public void ApplyTheme()
        {
            Color labelForeColor = ThemeManager.IsDarkMode ? Color.White : Color.Black;
            Color basePanelColor = ThemeManager.IsDarkMode ? Color.FromArgb(26, 26, 26) : Color.White;
            Color moviePanelColor = ThemeManager.IsDarkMode ? Color.Gray : Color.LightGray;
            Color flowPanelColor = Color.White; // Always white

            // Main background
            this.BackColor = basePanelColor;
            popularPanel_panel.BackColor = basePanelColor;

            // Movie area
            popularMovie_panel.BackColor = moviePanelColor;
            popularMovie_flp.BackColor = flowPanelColor;
            popularMovie_flp.ForeColor = labelForeColor;

            // Label
            popular_lbl.ForeColor = labelForeColor;
            popular_lbl.BackColor = Color.Transparent;
        }

        public void Reload()
        {
            // Clear the existing favorite movie controls
            popularMovie_flp.Controls.Clear();
            popularMovie_flp.Controls.Clear(); // Clear existing movies

            List<movie> popularMovies = GetPopularMovies(0, 10);

            // Display the refreshed favorite movies
            List<movie> updatedPopularMovies = GetPopularMovies(0, 10);
            DisplayFavoriteMovies(updatedPopularMovies, popularMovie_flp);


            // Optionally re-curve the panel if resizing messed it up
            CurvePanel(popularMovie_flp, 30);
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

            // Try to load the movie poster image
            try
            {
                if (!string.IsNullOrEmpty(movie.ImageUrl))
                {
                    string cachedImagePath = await ImageCacheHelper.DownloadImageIfNotCachedAsync(movie.ImageUrl);
                    if (cachedImagePath != null)
                    {
                        poster.Image = Image.FromFile(cachedImagePath);
                    }
                    else
                    {
                        poster.Image = Properties.Resources.fallback;
                    }
                }
                else
                {
                    poster.Image = Properties.Resources.fallback;
                }
            }
            catch
            {
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

        private List<movie> GetPopularMovies(int offset, int limit)
        {
            List<movie> movies = new List<movie>();

            if (connection == null)
                connection = new MySqlConnection(connectionString);

            string query = @"
        SELECT movie_id, title, description, genre, release_year, rating, image_url, views
        FROM Movies
        ORDER BY views DESC
        LIMIT @limit OFFSET @offset";

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@limit", limit);
                    cmd.Parameters.AddWithValue("@offset", offset);

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
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching popular movies: " + ex.Message);
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

    }
}
