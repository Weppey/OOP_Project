using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;

namespace OOP_Project
{

    public partial class favorite_form : KryptonForm
    {

        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";

        private string userType;
        private int currentUserId;
        private int userId;

        int currentPage = 0;
        int pageSize = 20;
        bool isLoading = false;

        public favorite_form()
        {
            InitializeComponent();
        }
        private void favorite_form_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                LoadMoreMovies();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message);
            }
        }
        private List<Movie> GetFavoriteMovies(int userId, int offset, int limit)
        {
            List<Movie> movies = new List<Movie>();
            string query = @"
              SELECT m.* FROM Movies m
                 INNER JOIN Favorites f ON m.movie_id = f.movie_id
                 WHERE f.user_id = @userId
                    LIMIT @limit OFFSET @offset";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@limit", limit);
                cmd.Parameters.AddWithValue("@offset", offset);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        movies.Add(new Movie
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

            return movies;
        }


        private void LoadMoreMovies()
        {
            if (isLoading) return;
            isLoading = true;

            List<Movie> movies = GetFavoriteMovies(currentUserId, currentPage * pageSize, pageSize);

            if (movies == null || movies.Count == 0)
            {
                isLoading = false;
                return;
            }

            foreach (var movie in movies)
            {
                Panel moviePanel = new Panel
                {
                    Size = new Size(160, 200),
                    Margin = new Padding(5),
                    BackColor = Color.Gray,
                    Cursor = Cursors.Hand
                };

                PictureBox poster = new PictureBox
                {
                    Size = new Size(150, 200),
                    Location = new Point(5, 0),
                    BackColor = Color.Black,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle
                };

                try
                {
                    if (!string.IsNullOrEmpty(movie.ImageUrl))
                        poster.Load(movie.ImageUrl);
                    else
                        poster.Image = Properties.Resources.fallback;
                }
                catch
                {
                    poster.Image = Properties.Resources.fallback;
                }

                moviePanel.Controls.Add(poster);

                moviePanel.Click += (s, e) => {
                    LogMovieView(currentUserId, movie.Id);
                    ShowMovieDetails(movie);
                };

                foreach (Control ctrl in moviePanel.Controls)
                {
                    ctrl.Click += (s, e) => {
                        LogMovieView(currentUserId, movie.Id);
                        ShowMovieDetails(movie);
                    };
                }

                favoriteMovie_flp.Controls.Add(moviePanel);
            }

            currentPage++;
            isLoading = false;
        }

        private void ShowMovieDetails(Movie movie)
        {
            try
            {
                MovieDetailsForm details = new MovieDetailsForm(movie, currentUserId);
                details.StartPosition = FormStartPosition.CenterScreen;
                details.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing movie details: {ex.Message}");
            }
        }

        private void LogMovieView(int userId, int movieId)
        {
            string insertQuery = "INSERT INTO movie_views (user_id, movie_id, viewed_at) VALUES (@userId, @movieId, @viewedAt)";

            using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@movieId", movieId);
                cmd.Parameters.AddWithValue("@viewedAt", DateTime.Now);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to log movie view: " + ex.Message);
                }
            }
        }

        private void close_pb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_pb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
