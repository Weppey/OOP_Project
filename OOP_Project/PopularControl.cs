using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
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
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
        string userType;
        int currentUserId;

        public PopularControl(string userTypeFromLogin, int userIdFromLogin)
        {
            InitializeComponent();
            userType = userTypeFromLogin;
            currentUserId = userIdFromLogin;
        }

        private void PopularControl_Load(object sender, EventArgs e)
        {
            List<movie> popularMovies = GetPopularMovies(0, 10);
            DisplayFavoriteMovies(popularMovies, popularMovie_flp);

            CurvePanel(popularMovie_flp, 30);
            popularMovie_flp.Resize += (s, args) => CurvePanel(popularMovie_flp, 20);
            CurvePanel(popularMovie_panel, 30);
            popularMovie_panel.Resize += (s, args) => CurvePanel(popularMovie_panel, 20);
            CurvePanel(popularPanel_panel, 30);
            popularPanel_panel.Resize += (s, args) => CurvePanel(popularPanel_panel, 20);
        }

        public void Reload()
        {
            popularMovie_flp.Controls.Clear();
            List<movie> updatedPopularMovies = GetPopularMovies(0, 10);
            DisplayFavoriteMovies(updatedPopularMovies, popularMovie_flp);
            CurvePanel(popularMovie_flp, 30);
        }

        private async void DisplayFavoriteMovies(List<movie> favoriteMovies, FlowLayoutPanel targetPanel)
        {
            targetPanel.Controls.Clear();

            foreach (var movie in favoriteMovies)
            {
                await DisplaySingleMovie(movie, targetPanel);
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
                Tag = movie.Id
            };

            PictureBox poster = new PictureBox
            {
                Size = new Size(140, 180),
                Location = new Point(0, 0),
                BackColor = Color.Black,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle,
                Image = Properties.Resources.icons8_loading_50 // optional placeholder
            };

            moviePanel.Controls.Add(poster);

            // Shared click handler
            EventHandler clickHandler = (s, e) =>
            {
                ShowMovieDetails(movie);
                LogMovieInteraction(currentUserId, movie.Id);
            };

            moviePanel.Click += clickHandler;
            poster.Click += clickHandler;

            targetPanel.Controls.Add(moviePanel);

            try
            {
                if (!string.IsNullOrEmpty(movie.ImageUrl))
                {
                    string cachedImagePath = await ImageCacheHelper.DownloadImageIfNotCachedAsync(movie.ImageUrl);
                    if (!string.IsNullOrEmpty(cachedImagePath) && File.Exists(cachedImagePath))
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
        }

        public void LogMovieInteraction(int userId, int movieId)
        {
            string checkUserQuery = "SELECT COUNT(*) FROM users WHERE user_id = @userId";
            string checkMovieQuery = "SELECT COUNT(*) FROM movies WHERE movie_id = @movieId";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand checkUserCmd = new MySqlCommand(checkUserQuery, conn))
                    {
                        checkUserCmd.Parameters.AddWithValue("@userId", userId);
                        if (Convert.ToInt32(checkUserCmd.ExecuteScalar()) == 0)
                        {
                            MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    using (MySqlCommand checkMovieCmd = new MySqlCommand(checkMovieQuery, conn))
                    {
                        checkMovieCmd.Parameters.AddWithValue("@movieId", movieId);
                        if (Convert.ToInt32(checkMovieCmd.ExecuteScalar()) == 0)
                        {
                            MessageBox.Show("Movie not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string insertInteraction =
                        "INSERT INTO movie_interaction (user_id, movie_id, created_at) VALUES (@userId, @movieId, @createdAt)";
                    using (MySqlCommand cmd = new MySqlCommand(insertInteraction, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@movieId", movieId);
                        cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }

                    string insertView =
                        "INSERT INTO movie_views (user_id, movie_id, viewed_at) VALUES (@userId, @movieId, @viewedAt)";
                    using (MySqlCommand cmdView = new MySqlCommand(insertView, conn))
                    {
                        cmdView.Parameters.AddWithValue("@userId", userId);
                        cmdView.Parameters.AddWithValue("@movieId", movieId);
                        cmdView.Parameters.AddWithValue("@viewedAt", DateTime.Now);
                        cmdView.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Log error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowMovieDetails(movie movie)
        {
            try
            {
                var movieDetailsForm = new movie_details_form(movie, StayLoggedIn.GetCurrentUserId().Value)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                movieDetailsForm.ShowDialog();
                FavoriteControl favoriteControl = new FavoriteControl(userType, currentUserId);
                favoriteControl.Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading movie details: " + ex.Message);
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

        private void CurvePanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }
    }
}
