    using System;
    using System.Data;
    using System.Drawing;
    using System.Threading.Tasks;
    using System.Web.SessionState;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;
    using System.Drawing.Drawing2D;
    using ComponentFactory.Krypton.Toolkit;
    using System.Drawing.Imaging;
    using System.IO;
using System.Collections.Generic;
using System.Linq;



namespace OOP_Project
    {
        public partial class home_form : KryptonForm
        {
        private MySqlConnection connection;

        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
        private string userType;
        private int currentUserId;
        int currentUserId2 = 40;

        public int CurrentUserId => currentUserId; // 🔸 public getter if needed externally
        public string UserType => userType;

        public home_form(string userTypeFromLogin, int userIdFromLogin)
        {
            InitializeComponent();

            if (userIdFromLogin <= 0)
            {
                MessageBox.Show("Invalid user session. Please log in again.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                login_form login = new login_form();
                login.Show();
                this.Close();
                return;
            }

            userType = userTypeFromLogin;
            currentUserId = userIdFromLogin;

            HandleAccess();
        }

        // This will round the corners of the form
        private void CurvePanel(System.Windows.Forms.Panel panel, int radius)
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



        private void HandleAccess()
        {
            if (userType.ToLower() == "admin")
            {
                insert_btn.Visible = true; // 🔸 allow movie insert
                admin_button.Visible = true;
            }
            else
            {
                insert_btn.Visible = false;
                admin_button.Visible = false;
            }
        }

        



        private async void home_form_Load(object sender, EventArgs e)
        {


            connection = new MySqlConnection("Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;");
                try
                {
                    connection.Open(); // ✅ Must open it before any SQL
                    List<string> genres = GetUserGenres(currentUserId);
                    DisplayMoviesByGenre(genres);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening connection: " + ex.Message);
                }




            StayLoggedIn.LoadUserSession();
                CurvePanel(movie_panel, 30);
                movie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

                CurvePanel(recommendedMovie_panel, 30);
                recommendedMovie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

                CurvePanel(recommendedMovie_flp, 30);
                recommendedMovie_flp.Resize += (s, args) => CurvePanel(movie_panel, 20);

                CurvePanel(popularMovie_panel, 30);
                movie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

                CurvePanel(popularMovie_flp, 30);
                recommendedMovie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

                CurvePanel(topRatedMovie_panel, 30);
                movie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

                CurvePanel(topRatedMovie_flp, 30);
                recommendedMovie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

                LoadMovies();


                genre_cmb.Items.AddRange(new string[]
                 {
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Sci-Fi",
            "Romance",
            "Thriller",
            "Documentary",
            "Adventure",
            "Animation",
            "Fantasy"
                 });

                genre_cmb.SelectedIndex = 0; // Optional: select first item by default




        }

        private List<string> GetUserGenres(int userId)
        {
            List<string> genres = new List<string>();
            string query = "SELECT preferences FROM users WHERE user_id = @userId";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                var result = cmd.ExecuteScalar()?.ToString();

                if (!string.IsNullOrEmpty(result))
                {
                    genres = result.Split(',').Select(g => g.Trim()).ToList();
                }
            }

            return genres;
        }
        private Color GetGenreColor(string genre)
        {
            switch (genre.ToLower())
            {
                case "action":
                    return Color.LightCoral;
                case "comedy":
                    return Color.LightYellow;
                case "drama":
                    return Color.LightSteelBlue;
                case "horror":
                    return Color.MistyRose;
                case "sci-fi":
                    return Color.LightGreen;
                case "romance":
                    return Color.LightPink;
                default:
                    return Color.LightGray;
            }
        }
        private void DisplayMoviesByGenre(List<string> genres)
        {
           
            if (genres == null || genres.Count == 0)
            {
                MessageBox.Show("No genres to display.");
                return;
            }
           
            recommendedMovie_flp.Controls.Clear();

            foreach (string genre in genres)
            {
                // Genre panel (with a distinct color)
                Panel genrePanel = new Panel
                {
                    Width = recommendedMovie_flp.Width - 25, // account for scrollbar
                    AutoSize = true,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    BackColor = GetGenreColor("comedy"),// <-- Genre panel background
                    BackgroundImage = Properties.Resources._11
                };

                Label genreLabel = new Label
                {
                    Text = genre,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true,
                    ForeColor = Color.DarkBlue
                };
                genrePanel.Controls.Add(genreLabel);

                int movieYOffset = genreLabel.Bottom + 10;

                var movies = GetMoviesByGenre(genre);
                Console.WriteLine($"Found {movies.Count} movies for genre: {genre}");

                if (movies == null || movies.Count == 0)
                {
                    MessageBox.Show($"No movies found for genre: {genre}");
                    continue; // Skip to next genre
                }

                foreach (var movie in movies)
                {
                    Panel moviePanel = new Panel
                    {
                        Location = new Point(10, movieYOffset),
                        Size = new Size(genrePanel.Width - 20, 30),
                        BackColor = Color.LightCoral, // <-- Movie panel background
                        Cursor = Cursors.Hand
                    };

                    Label movieTitle = new Label
                    {
                        Text = movie.Title,
                        Location = new Point(5, 5),
                        AutoSize = true,
                        ForeColor = Color.White
                    };

                    moviePanel.Controls.Add(movieTitle);
                    genrePanel.Controls.Add(moviePanel);

                    // Click to show movie details
                    moviePanel.Click += (s, e) => ShowMovieDetails(movie);
                    foreach (Control ctrl in moviePanel.Controls)
                        ctrl.Click += (s, e) => ShowMovieDetails(movie);

                    movieYOffset += 40;
                }

                genrePanel.Height = movieYOffset + 10;

                // Add genre panel to flow layout
                recommendedMovie_flp.Controls.Add(genrePanel);
            }
        }

        private List<Movie> GetMoviesByGenre(string genre)
        {


            List<Movie> movies = new List<Movie>();
            string query = "SELECT * FROM Movies WHERE LOWER(Genre) = LOWER('comedy')";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@genre", genre);
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
        private void ShowMovieDetails(Movie moovie)
        {
            MovieDetailsForm details = new MovieDetailsForm(moovie);
            details.ShowDialog();
        }




        public void LoadMovies()
        {
            recommendedMovie_flp.Controls.Clear();

            string query = "SELECT movie_id, image_url FROM Movies ORDER BY created_at DESC";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        MovieCard card = new MovieCard();
                        int movieID = reader.GetInt32("movie_id");


                        string imageUrl = reader["image_url"]?.ToString();
                        if (!string.IsNullOrWhiteSpace(imageUrl))
                        {
                            // Check if the URL doesn't have an extension, then append .jpg or .png
                            if (!imageUrl.EndsWith(".jpg") && !imageUrl.EndsWith(".png"))
                            {
                                imageUrl += ".jpg"; // Or use .png if you prefer
                            }

                            try
                            {
                                if (Uri.IsWellFormedUriString(imageUrl, UriKind.Absolute))
                                {
                                    using (var webClient = new System.Net.WebClient())
                                    {
                                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                                        using (var stream = new System.IO.MemoryStream(imageBytes))
                                        {
                                            card.Poster = Image.FromStream(stream);
                                        }
                                    }
                                }
                                else
                                {
                                    // Handle the case where the image URL is invalid
                                    card.Poster = Properties.Resources.Netflix_N_Symbol_logo;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Failed to load image for movie ID {movieID}.\n\n{ex.Message}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                card.Poster = Properties.Resources.Netflix_N_Symbol_logo;
                            }
                        }
                        else
                        {
                            card.Poster = Properties.Resources.Netflix_N_Symbol_logo;
                        }

                        try
                        {
                            if (!string.IsNullOrWhiteSpace(imageUrl))
                            {
                                // If the URL is well-formed, attempt to load the image from the web
                                if (Uri.IsWellFormedUriString(imageUrl, UriKind.Absolute))
                                {
                                    using (var webClient = new System.Net.WebClient())
                                    {
                                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                                        using (var stream = new System.IO.MemoryStream(imageBytes))
                                        {
                                            card.Poster = Image.FromStream(stream);
                                        }
                                    }
                                }
                                // If it's a local file path, try loading the image from the file system
                                else if (File.Exists(imageUrl))
                                {
                                    card.Poster = Image.FromFile(imageUrl);
                                }
                                else
                                {
                                    // If URL is invalid, set a default image
                                    card.Poster = Properties.Resources.Netflix_N_Symbol_logo;
                                }
                            }
                            else
                            {
                                // If the image URL is empty or null, set a default image
                                card.Poster = Properties.Resources.Netflix_N_Symbol_logo;
                            }
                        }
                        catch (Exception ex)
                        {
                            // Show a message box with the error details
                            MessageBox.Show($"Failed to load image for movie ID {movieID}.\n\n{ex.Message}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            card.Poster = Properties.Resources.Netflix_N_Symbol_logo; // Fallback image
                        }

                        // Add the movie card to the flow panel
                        recommendedMovie_flp.Controls.Add(card);
                    }
                }
            }
        }

        private void close_pb_Click(object sender, EventArgs e)
            {
                string msg = "Do you want to leave this page?";
                string title = "Confirm Naviagtion";
                MessageBoxButtons btn = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                DialogResult result = MessageBox.Show(msg, title, btn, icon);
                if(result == DialogResult.Yes) 
                {
                    Application.Exit();
                }
                else
                {
                    return;
                }
            
            }

            private void close_pb_MouseEnter(object sender, EventArgs e)
            {
                close_pb.BackColor = Color.FromArgb(226, 0, 39);
            }

            private void close_pb_MouseLeave(object sender, EventArgs e)
            {
                close_pb.BackColor = Color.FromArgb(0, 0, 0);
            }

            private void minimize_pb_Click(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;
            }

            private void minimize_pb_MouseEnter(object sender, EventArgs e)
            {
                minimize_pb.BackColor = Color.FromArgb(50, 50, 50);
            }

            private void minimize_pb_MouseLeave(object sender, EventArgs e)
            {
                minimize_pb.BackColor = Color.FromArgb(0, 0, 0);
            }

            private void home_btn_Click(object sender, EventArgs e)
            {
                form_lbl.Text = "HOME";
            }

            private void favorite_btn_Click(object sender, EventArgs e)
            {
                form_lbl.Text = "FAVORITE";
            }

            private void popular_btn_Click(object sender, EventArgs e)
            {
                form_lbl.Text = "POPULAR";
            }

            private void settings_btn_Click(object sender, EventArgs e)
            {
                form_lbl.Text = "SETTINGS";
            }

            private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void menu_panel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void recommendedMovieLeft_btn_MouseClick(object sender, MouseEventArgs e)
            {
                recommendedMovieLeft_btn.BackColor = Color.FromArgb(80, 80, 80);
            }

            private void recommendedMovieLeft_btn_MouseLeave(object sender, EventArgs e)
            {
                recommendedMovieLeft_btn.BackColor = Color.FromArgb(128, 128, 128);
            }
            private void recommendedMovieLeft_btn_MouseEnter(object sender, EventArgs e)
            {
                recommendedMovieLeft_btn.BackColor = Color.FromArgb(100, 100, 100);
            }

            private void recommendedMovieRight_btn_MouseEnter(object sender, EventArgs e)
            {
                recommendedMovieRight_btn.BackColor = Color.FromArgb(100, 100, 100);
            }

            private void recommendedMovieRight_btn_MouseLeave(object sender, EventArgs e)
            {
                recommendedMovieRight_btn.BackColor = Color.FromArgb(128, 128, 128);
            }

            private void recommendedMovieRight_btn_MouseClick(object sender, MouseEventArgs e)
            {
                recommendedMovieRight_btn.BackColor = Color.FromArgb(80, 80, 80);
            }

            private bool IsValidUrl(string url)
            {
                return Uri.IsWellFormedUriString(url, UriKind.Absolute) && (url.StartsWith("http://") || url.StartsWith("https://"));
            }


            private void InsertMovie(string title, string imageUrl, string genre, string description, int year)
            {
                string query = "INSERT INTO Movies (title, image_url, genre, description, release_year, created_at) " +
                               "VALUES (@title, @image_url, @genre, @description, @year, NOW())";

              //  if (!IsValidUrl(imageUrl))
               // {
              //      MessageBox.Show("Invalid Image URL. Please enter a valid URL starting with http:// or https://", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             //       return;
               // }

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@image_url", imageUrl);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@year", year);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Movie inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows were inserted. Please check your input.", "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting movie:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            private void insert_btn_Click(object sender, EventArgs e)
            {
               // admin_form adminForm = new admin_form();
               // adminForm.Show();
                insertMovie_panel.Visible = true;
            }

        private void insertInsert_btn_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(title_tb.Text) ||
                string.IsNullOrWhiteSpace(url_lbl.Text) ||
                string.IsNullOrWhiteSpace(decription_lbl.Text) ||
                string.IsNullOrWhiteSpace(releaseYear_tb.Text) ||
                genre_cmb.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill out all fields before inserting the movie.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate year
            if (!int.TryParse(releaseYear_tb.Text, out int year))
            {
                MessageBox.Show("Please enter a valid number for release year.", "Invalid Year", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
    
            string imageUrl = url_tb.Text.Trim();


            // All good, insert the movie
            InsertMovie(title_tb.Text, imageUrl, genre_cmb.SelectedItem.ToString(), decription_lbl.Text, year);
            insertMovie_panel.Visible = false;
            LoadMovies();
        }

        private void signOut_btn_Click(object sender, EventArgs e)
        {
                string msg = "Do you really want to sign out?";
                string title = "Confirm Navigation";
                MessageBoxButtons btn = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                DialogResult result = MessageBox.Show(msg, title, btn, icon);

            if (result == DialogResult.Yes)
            {

                StayLoggedIn.ClearSession();

                // Use a new process to restart the app
                System.Diagnostics.Process.Start(Application.ExecutablePath);

                // Then close the current app entirely
                Application.Exit();


                login_form loginForm = new login_form();
                loginForm.Show();
            }

            else
            {
                return;
            }
            }

        private void insertMovie_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
