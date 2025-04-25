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
        using MySqlX.XDevAPI;





    namespace OOP_Project
    {
        public partial class home_form : KryptonForm
        {
            // Declare a private field named 'connection' of type 'MySqlConnection'.
            // This object will be used to manage the connection to the MySQL database,
            // allowing the application to open a connection, run commands, and interact with the database.
            private MySqlConnection connection;

            private ToolTip tooltip = new ToolTip();
        // Connection string to connect to the database, specifying the server, database, and login credentials.
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";

            // User-related variables
            private string userType; // Variable to store the type of user (admin or regular)
            private int currentUserId; // Variable to store the current user's ID
            private int userId; // Variable to store a user's ID, potentially for a selected user


            // Pagination-related variables
            int currentPage = 0; // Tracks the current page number for pagination
            int pageSize = 20; // Defines how many items to display per page
            bool isLoading = false; // Flag to indicate whether data is currently loading

            public home_form(string userTypeFromLogin, int userIdFromLogin) // Constructor for the home_form class, which initializes the form and handles user session.
            {
                InitializeComponent(); // Initializes the form components (UI elements)

                if (userIdFromLogin <= 0)  // Check if the user session is valid
                {
                    MessageBox.Show("Invalid user session. Please log in again.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // If user ID is invalid, show an error message and prompt for login again
                    login_form login = new login_form(); // Create a new login form instance
                    login.Show(); // Show the login form
                    this.Close(); // Close the current form (home_form)
                    return; // Exit the constructor to prevent further execution
                }

                // Assign user details from the login
                userType = userTypeFromLogin; // Store the user's type (admin or regular)
                currentUserId = userIdFromLogin; // Store the current user's ID

                HandleAccess(); // Handle access based on the user's type (admin or regular user)

            //Tooltip messages
            tooltip.IsBalloon = false;                        // Makes it balloon-shaped
            tooltip.BackColor = Color.LightYellow;           // Tooltip background color (only works in custom-drawn tips)
            tooltip.ForeColor = Color.Black;                 // Text color
            tooltip.UseFading = true;                        // Smooth fade-in/out
            tooltip.UseAnimation = true;                     // Animate appearance

            tooltip.AutoPopDelay = 5000;
                tooltip.InitialDelay = 100;
                tooltip.ReshowDelay = 100;
                tooltip.ShowAlways = true;
                
                tooltip.SetToolTip(home_btn, "Home");
                tooltip.SetToolTip(favorite_btn, "Favorite");
                tooltip.SetToolTip(popular_btn, "Popular");
                tooltip.SetToolTip(signOut_btn, "Sign Out");
                tooltip.SetToolTip(settings_btn, "Settings");
                tooltip.SetToolTip(adminsettings_btn, "Admin");
                tooltip.SetToolTip(search_tb, "Search your movie");
                tooltip.SetToolTip(profile_btn, "Profile");
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

        private void HandleAccess() // Method to handle access control for different user types (admin or regular)
        {
            if (userType.ToLower() == "admin")  // Check if the user type is "admin"
            {
                adminsettings_btn.Visible = true; // If the user is an admin, show the admin button
            }
            else
            {
                adminsettings_btn.Visible = false; // If the user is not an admin, hide the admin button
            }
        }

        private async void home_form_Load(object sender, EventArgs e)
        {

            // Get the userId from the session
            int? userId = StayLoggedIn.GetCurrentUserId();
            if (userId.HasValue)
            {
                LoadRecentSearches(userId.Value);  // Pass userId to load recent searches
            }
            else
            {
                MessageBox.Show("Please log in first.");
            }

            recommendedMovie_flp.FlowDirection = FlowDirection.LeftToRight;
            recommendedMovie_flp.WrapContents = true;
            recommendedMovie_flp.AutoScroll = true;

            allMovie_flp.FlowDirection = FlowDirection.LeftToRight;
            allMovie_flp.WrapContents = true;
            allMovie_flp.AutoScroll = true;

            connection = new MySqlConnection("Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;");

            try
            {
                connection.Open(); // ✅ Must open it before any SQL
                DisplayAllMovies();
                LoadMoreMovies();
                List<string> genres = GetUserGenres(currentUserId);
                if (genres != null && genres.Count > 0)
                {
                    DisplayMoviesByGenre(genres); // Display movies based on multiple genres
                }
                else
                {
                    MessageBox.Show("No genre preferences found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening connection: " + ex.Message);
            }

            StayLoggedIn.LoadUserSession();
            CurvePanel(movie_panel, 30);
            movie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

            CurvePanel(viewport_panel, 30);
            viewport_panel.Resize += (s, args) => CurvePanel(viewport_panel, 20);

            CurvePanel(recommendedMovie_flp, 30);
            recommendedMovie_flp.Resize += (s, args) => CurvePanel(movie_panel, 20);

            CurvePanel(popularmovie_pnl, 30);
            movie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

            CurvePanel(recentlysearch_flp, 30);
            recentlysearch_flp.Resize += (s, args) => CurvePanel(recentlysearch_flp, 20);

            CurvePanel(allMovie_panel, 30);
            allMovie_panel.Resize += (s, aargs) => CurvePanel(allMovie_panel, 20);

            CurvePanel(allMovie_flp, 30);
            allMovie_panel.Resize += (s, aargs) => CurvePanel(allMovie_panel, 20);
            

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
                    // Split genres by commas and trim spaces
                    genres = result.Split(',')
                                   .Select(g => g.Trim())
                                   .Where(g => !string.IsNullOrEmpty(g)) // Ensure no empty genres are included
                                   .ToList();
                }
            }

            return genres;
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
                var movies = GetMoviesByGenre(genre);
                Console.WriteLine($"Found {movies?.Count ?? 0} movies for genre: {genre}");

                if (movies == null || movies.Count == 0)
                {
                    MessageBox.Show($"No movies found for genre: {genre}");
                    continue;
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
                        Size = new Size(159, 189),
                        Location = new Point(5, 0),
                        BackColor = Color.Black,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    try
                    {
                        if (!string.IsNullOrEmpty(movie.ImageUrl))
                        {
                            poster.Load(movie.ImageUrl);
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
                    moviePanel.Click += (s, e) =>
                    {
                        LogMovieView(currentUserId, movie.Id);
                        ShowMovieDetails(movie);
                    };

                    foreach (Control ctrl in moviePanel.Controls)
                    {
                        ctrl.Click += (s, e) =>
                        {
                            LogMovieView(currentUserId, movie.Id);
                            ShowMovieDetails(movie);
                        };
                    }


                    recommendedMovie_flp.Controls.Add(moviePanel);
                }
            }
        }
        private void LoadMoreMovies()
        {
            if (isLoading) return;
            isLoading = true;

            List<Movie> movies = GetMovies(currentPage * pageSize, pageSize);

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
                    Size = new Size(159, 189),
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

                moviePanel.Click += (s, e) =>
                {
                    LogMovieView(currentUserId, movie.Id);
                    ShowMovieDetails(movie);
                };

                foreach (Control ctrl in moviePanel.Controls)
                {
                    ctrl.Click += (s, e) =>
                    {
                        LogMovieView(currentUserId, movie.Id);
                        ShowMovieDetails(movie);
                    };
                }

                allMovie_flp.Controls.Add(moviePanel);
            }

            currentPage++;
            isLoading = false;
        }
        private void DisplayAllMovies()
        {
            allMovie_flp.Controls.Clear(); // Clear the previous movies

            // Get all movies
            List<Movie> allMovies = GetAllMovies();

            if (allMovies == null || allMovies.Count == 0)
            {
                MessageBox.Show("No movies to display.");
                return;
            }

            foreach (var movie in allMovies)
            {
                // Create a panel to hold the movie poster
                Panel moviePanel = new Panel
                {
                    Size = new Size(160, 200),
                    Margin = new Padding(5),
                    BackColor = Color.Gray,
                    Cursor = Cursors.Hand
                };

                // Create a PictureBox for the movie poster
                PictureBox poster = new PictureBox
                {
                    Size = new Size(159, 189),
                    Location = new Point(5, 0),
                    BackColor = Color.Black,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Try to load the movie poster image
                try
                {
                    if (!string.IsNullOrEmpty(movie.ImageUrl))
                    {
                        poster.Load(movie.ImageUrl);
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

                // Movie panel click event to show movie details
                moviePanel.Click += (s, e) =>
                {
                    LogMovieView(currentUserId, movie.Id);
                    ShowMovieDetails(movie);
                };

                foreach (Control ctrl in moviePanel.Controls)
                {
                    ctrl.Click += (s, e) =>
                    {
                        LogMovieView(currentUserId, movie.Id);
                        ShowMovieDetails(movie);
                    };
                }
                // Add the movie panel to the flow layout panel
                allMovie_flp.Controls.Add(moviePanel);
            }
        }
        private List<Movie> GetMovies(int offset, int limit)
        {
            List<Movie> movies = new List<Movie>();
            string query = "SELECT * FROM Movies LIMIT @limit OFFSET @offset";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
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
        private List<Movie> GetMoviesByGenre(string genre)
        {
            List<Movie> movies = new List<Movie>();
            string query = "SELECT * FROM Movies WHERE LOWER(genre) LIKE CONCAT('%', LOWER(@genre), '%')";

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
        private List<Movie> GetAllMovies()
        {
            List<Movie> movies = new List<Movie>();
            string query = "SELECT * FROM Movies"; // No genre filter

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
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
        private void ShowMovieDetails(Movie movie)
        {
            try
            {
                var movieDetailsForm = new movie_details_form(movie, StayLoggedIn.GetCurrentUserId().Value);
                movieDetailsForm.StartPosition = FormStartPosition.CenterScreen;
                movieDetailsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing movie details: {ex.Message}");
            }
        }
        private void close_pb_Click(object sender, EventArgs e)
        {
            string msg = "Do you want to leave this page?";
            string title = "Confirm Naviagtion";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(msg, title, btn, icon);
            if (result == DialogResult.Yes)
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
            favorite_form favoriteForm = new favorite_form(currentUserId, userType);
            favoriteForm.StartPosition = FormStartPosition.CenterParent;
            favoriteForm.Location = new Point(200, 50);
            favoriteForm.ShowDialog();
        }

        private void popular_btn_Click(object sender, EventArgs e)
        {
            form_lbl.Text = "POPULAR";
        }
        private void settings_btn_Click(object sender, EventArgs e)
        {
            form_lbl.Text = "SETTINGS";
        }
        private bool IsValidUrl(string url)
        {
            return Uri.IsWellFormedUriString(url, UriKind.Absolute) && (url.StartsWith("http://") || url.StartsWith("https://"));
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
        private void search_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seacrch
            // Clear the search_txt TextBox
            search_tb.Clear();
            search_txt_Leave(sender, e);

            if (search_list.SelectedItem is Movie selectedMovie)
            {
                // Avoid adding the same movie twice
                if (!IsMovieAlreadyInPanel(selectedMovie, recentlysearch_flp))
                {
                    DisplaySingleMovie(selectedMovie, recentlysearch_flp);
                }
            }
            this.ActiveControl = null; // Remove focus from search_txt, so the cursor disappears
        }
        //search
        private void DisplaySingleMovie(Movie movie, FlowLayoutPanel targetPanel)
        {
            Panel moviePanel = new Panel
            {
                Size = new Size(160, 200),
                Margin = new Padding(5),
                BackColor = Color.Gray,
                Cursor = Cursors.Hand,
                Tag = movie.Id // Set movie ID as Tag to detect duplicates
            };

            PictureBox poster = new PictureBox
            {
                Size = new Size(                                                                                            ),
                Location = new Point(5, 0),
                BackColor = Color.Black,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle
            };

            try
            {
                // Load the movie poster image if URL is provided
                if (!string.IsNullOrEmpty(movie.ImageUrl))
                {
                    poster.Load(movie.ImageUrl);
                }
                else
                {
                    // Use fallback image if no URL is available
                    poster.Image = Properties.Resources.fallback;
                }
            }
            catch
            {
                // Use fallback image in case of an error loading the image
                poster.Image = Properties.Resources.fallback;
            }
            // Add poster to the movie panel
            moviePanel.Controls.Add(poster);

            // Attach click to both panel and poster (for better UX)
            moviePanel.Click += (s, e) => ShowMovieDetails(movie);
            poster.Click += (s, e) => ShowMovieDetails(movie);

            moviePanel.Controls.Add(poster);
            targetPanel.Controls.Add(moviePanel);
        }

        private bool IsMovieAlreadyInPanel(Movie movie, FlowLayoutPanel panel)
        {
            // Iterate through all panels in the FlowLayoutPanel
            foreach (Control control in panel.Controls)
            {
                if (control is Panel moviePanel && moviePanel.Tag is int movieId && movieId == movie.Id)
                {
                    return true; // Movie already exists in the panel
                }
            }
            return false; // Movie does not exist
        }
        private void search_list_Click(object sender, EventArgs e)
        {
            if (search_list.SelectedItem is Movie selectedMovie)
            {
                // Try to get the full movie from the database by title
                var fullMovie = GetFullMovieByTitle(selectedMovie.Title);

                if (fullMovie != null)
                {
                    int? userId = StayLoggedIn.GetCurrentUserId();
                    if (userId.HasValue)
                    {
                        // Ensure the movie exists in the 'movies' table
                        EnsureMovieExistsInMoviesTable(fullMovie);

                        // Save movie to the recent_searches table
                        SaveRecentSearch(userId.Value, fullMovie);

                        // Show movie details form
                        var movieDetailsForm = new movie_details_form(fullMovie, userId.Value);
                        movieDetailsForm.StartPosition = FormStartPosition.CenterScreen;
                        movieDetailsForm.ShowDialog();

                        // Check if the movie is already in the recently searched list
                        if (IsMovieAlreadyInPanel(fullMovie, recentlysearch_flp))
                        {
                           //
                        }
                        else
                        {
                            // Display movie in the recently searched flow panel
                            DisplaySingleMovie(fullMovie, recentlysearch_flp);
                        }
                    }
                    else
                    {
                        MessageBox.Show("User session is not found. Please log in.");
                    }
                }
                else
                {
                    // Show message if movie is not found in the database
                    MessageBox.Show("Movie not found in the database.");
                }

                search_list.ClearSelected();
                search_list.Visible = false;
            }
        }    

        private void ShowMovieDetailsForm(Movie movie)
        {
            movie_details_form detailsForm = new movie_details_form(movie, userId);
            detailsForm.ShowDialog();
        }
        private Movie GetFullMovieByTitle(string title)
        {
            string connStr = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
            string query = "SELECT * FROM movies WHERE title = @title LIMIT 1";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", title);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Movie
                            {
                                Title = reader.GetString("title"),
                                Description = reader.GetString("description"),
                                Genre = reader.GetString("genre"),
                                ReleaseYear = reader.GetInt32("release_year"),
                                ImageUrl = reader.IsDBNull(reader.GetOrdinal("image_url")) ? null : reader.GetString("image_url")
                            };
                        }
                    }
                }
            }
            return null; // Return null if no movie found
        }
        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            string keyword = search_tb.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                search_list.Visible = false;
                search_list.Items.Clear();
                return;
            }
            string connStr = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
            string query = "SELECT title, image_url FROM movies WHERE title LIKE @keyword LIMIT 10";
            search_list.Items.Clear();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var movie = new Movie
                                {
                                    Title = reader.GetString("title"),
                                    ImageUrl = reader.IsDBNull(reader.GetOrdinal("image_url")) ? null : reader.GetString("image_url")
                                };

                                search_list.Items.Add(movie); // Will display movie.Title due to ToString override
                            }
                        }
                    }
                }
                search_list.Visible = search_list.Items.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void search_txt_Enter(object sender, EventArgs e)
        {
            if (search_tb.Text == "Search...")
            {
                search_tb.Text = "";
                search_tb.ForeColor = Color.Black;
            }
        }
        private void search_txt_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(search_tb.Text))
            {
                search_tb.Text = "Search..."; // Set the placeholder text
                search_tb.ForeColor = Color.Gray; // Change the text color to gray for placeholder
            }
        }
        private void LoadRecentSearches(int currentUserId)
        {
            string connStr = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
            string query = "SELECT movie_id, movie_title, movie_description, movie_genre, release_year, image_url " +
                           "FROM recent_searches WHERE user_id = @userId ORDER BY id DESC LIMIT 20";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", currentUserId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            recentlysearch_flp.Controls.Clear();

                            while (reader.Read())
                            {
                                int movieId = reader.GetInt32("movie_id");
                                string title = reader.GetString("movie_title");
                                string description = reader.GetString("movie_description");
                                string genre = reader.GetString("movie_genre");
                                int releaseYear = reader.GetInt32("release_year");
                                string imageUrl = reader.IsDBNull(reader.GetOrdinal("image_url")) ? null : reader.GetString("image_url");

                                Movie movie = new Movie
                                {
                                    Id = movieId, // 🆕 Assign movie_id here
                                    Title = title,
                                    Description = description,
                                    Genre = genre,
                                    ReleaseYear = releaseYear,
                                    ImageUrl = imageUrl
                                };

                                DisplayMovieInRecentlySearch(movie);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void DisplayMovieInRecentlySearch(Movie movie)
        {
            // Check for existing panel by movie ID
            foreach (Control control in recentlysearch_flp.Controls)
            {
                if (control is Panel panel && panel.Tag != null && panel.Tag.ToString() == movie.Id.ToString())
                {
                    // 🛑 Duplication detected — show an error message
                    MessageBox.Show($"Duplicate movie detected: {movie.Title} (ID: {movie.Id})", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Create panel for movie
            Panel moviePanel = new Panel
            {
                Size = new Size(160, 200),
                Margin = new Padding(5),
                BackColor = Color.Gray,
                Cursor = Cursors.Hand,
                Tag = movie.Id
            };

            PictureBox poster = new PictureBox
            {
                Size = new Size(159, 189),
                Location = new Point(5, 0),
                BackColor = Color.Black,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle
            };

            try
            {
                if (!string.IsNullOrEmpty(movie.ImageUrl))
                {
                    poster.Load(movie.ImageUrl);
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

            moviePanel.Controls.Add(poster);

            // Add click event to show details of the movie
            moviePanel.Click += (s, e) => ShowMovieDetails(movie);
            poster.Click += (s, e) => ShowMovieDetails(movie);

            recentlysearch_flp.Controls.Add(moviePanel);

        }
        private void SaveRecentSearch(int userId, Movie movie)
        {
            string connStr = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
            string query = "INSERT IGNORE INTO recent_searches (user_id, movie_id, movie_title, movie_description, movie_genre, release_year, image_url) " +
                           "VALUES (@userId, @movieId, @movieTitle, @movieDescription, @movieGenre, @releaseYear, @imageUrl)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@movieId", movie.Id);
                        cmd.Parameters.AddWithValue("@movieTitle", movie.Title);
                        cmd.Parameters.AddWithValue("@movieDescription", movie.Description);
                        cmd.Parameters.AddWithValue("@movieGenre", movie.Genre);
                        cmd.Parameters.AddWithValue("@releaseYear", movie.ReleaseYear);
                        cmd.Parameters.AddWithValue("@imageUrl", movie.ImageUrl ?? (object)DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void admin_button_Click(object sender, EventArgs e)
        {
            admin_form admin_Form = new admin_form(userType, currentUserId);
            admin_Form.ShowDialog();
        }
        private void allMovie_flp_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.EndScroll &&
             allMovie_flp.VerticalScroll.Value + allMovie_flp.ClientSize.Height >= allMovie_flp.VerticalScroll.Maximum)
            {
                LoadMoreMovies();
            }
        }
        private void EnsureMovieExistsInMoviesTable(Movie movie)
        {
            string connStr = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
            string checkQuery = "SELECT movie_id FROM movies WHERE title = @title";
            string insertQuery = "INSERT INTO movies (title, description, genre, release_year, image_url) " +
                                 "VALUES (@title, @description, @genre, @releaseYear, @imageUrl); SELECT LAST_INSERT_ID();";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@title", movie.Title);
                    object result = checkCmd.ExecuteScalar();

                    if (result != null)
                    {
                        // 🎯 If movie exists, assign its ID to the object
                        movie.Id = Convert.ToInt32(result);
                    }
                    else
                    {
                        // 🆕 Insert and retrieve the new ID
                        using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@title", movie.Title);
                            insertCmd.Parameters.AddWithValue("@description", movie.Description);
                            insertCmd.Parameters.AddWithValue("@genre", movie.Genre);
                            insertCmd.Parameters.AddWithValue("@releaseYear", movie.ReleaseYear);
                            insertCmd.Parameters.AddWithValue("@imageUrl", string.IsNullOrEmpty(movie.ImageUrl) ? DBNull.Value : (object)movie.ImageUrl);

                            object insertedId = insertCmd.ExecuteScalar();
                            movie.Id = Convert.ToInt32(insertedId);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}


