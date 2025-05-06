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
using System.Net.Http;

using MySqlX.XDevAPI;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;
using Mysqlx.Crud;
using static OOP_Project.StayLoggedIn;

namespace OOP_Project
{
    public partial class home_form : KryptonForm
    {
        // Declare a private field named 'connection' of type 'MySqlConnection'.
        // This object will be used to manage the connection to the MySQL database,
        // allowing the application to open a connection, run commands, and interact with the database.
        private MySqlConnection connection;
        private static bool isProfilePanelActive = false;

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

        private Timer inactivityTimer;
        private DateTime lastActivityTime;
        private int inactivityLimitSeconds = 300;

        private int userIdFromLogin;

        public home_form(string userTypeFromLogin, int userIdFromLogin) // Constructor for the home_form class, which initializes the form and handles user session.
        {
            InitializeComponent(); // Initializes the form components (UI elements)
            connection = new MySqlConnection(connectionString);

            // Assign user details from the login
            userType = userTypeFromLogin; // Store the user's type (admin or regular)
            currentUserId = userIdFromLogin; // Store the current user's ID

            HandleAccess(); // Handle access based on the user's type (admin or regular user)

            //Tooltip messages
            tooltip.IsBalloon = false; // Makes it balloon-shaped
            tooltip.BackColor = Color.LightYellow; // Tooltip background color (only works in custom-drawn tips)
            tooltip.ForeColor = Color.Black; // Text color
            tooltip.UseFading = true; // Smooth fade-in/out
            tooltip.UseAnimation = true; // Animate appearance

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
            this.Name = "home_form"; // Ensure this is set so ThemeManager recognizes it
            ApplyTheme();
        }

        public void ApplyTheme()
        {
            bool isDark = ThemeManager.IsDarkMode;

            this.BackColor = isDark ? Color.FromArgb(30, 30, 30) : Color.LightGray;
            menu_panel.BackColor = isDark ? Color.FromArgb(26, 26, 26) : Color.DarkGray;
            viewport_panel.BackColor = isDark ? Color.Gray : Color.LightGray;
            movie_panel.BackColor = isDark ? Color.FromArgb(26, 26, 26) : Color.White;
            recommendedMovie_flp.BackColor = isDark ? Color.White : Color.White;
            allMovie_flp.BackColor = isDark ? Color.White : Color.White;
            recentlysearch_flp.BackColor = isDark ? Color.White : Color.White;
            allMovie_panel.BackColor = isDark ? Color.Gray : Color.LightGray;
            recentlyMovie_panel.BackColor = isDark ? Color.Gray : Color.LightGray;

            // Label foreground colors
            Color labelForeColor = isDark ? Color.White : Color.Black;

            form_lbl.ForeColor = labelForeColor;
            suggest_lbl.ForeColor = labelForeColor;
            allMovie_lbl.ForeColor = labelForeColor;
            recent_lbl.ForeColor = labelForeColor;

            // Optional: transparent backgrounds for labels
            form_lbl.BackColor = Color.Transparent;
            suggest_lbl.BackColor = Color.Transparent;
            allMovie_lbl.BackColor = Color.Transparent;
            recent_lbl.BackColor = Color.Transparent;
        }


        private void CurvePanel(System.Windows.Forms.Panel panel, int radius) // Method to apply curved corners to a panel
        {
            GraphicsPath path = new GraphicsPath(); // Method to apply curved corners to a panel
            path.StartFigure(); // Start the shape definition

            // Add arcs to the path to define the four rounded corners
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Top-left corner
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90); // Top-left corner
            path.AddArc(
                new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius),
                0,
                90
            ); // Bottom-right corner
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90); // Bottom-left corner
            path.CloseFigure(); // Close the shape definition
            panel.Region = new Region(path); // Apply the custom shape to the panel by setting its Region property
        }

        private void HandleAccess() // Method to handle access control for different user types (admin or regular)
        {
            if (userType.ToLower() == "admin") // Check if the user type is "admin"
            {
                adminsettings_btn.Visible = true; // If the user is an admin, show the admin button
            }
            else if (userType.ToLower() == "master")
            {
                AdminControl admin = new AdminControl(userType, currentUserId);
                admin.HandleMasterAccess();
            }
            else
            {
                adminsettings_btn.Visible = false; // If the user is not an admin, hide the admin button
            }
        }

        public void FavoriteButtonClick()
        {
            // Manually call the favorite_btn_Click event handler
            favorite_btn_Click(favorite_btn, EventArgs.Empty); // Simulate the click event
        }

        private void InactivityTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan inactivity = DateTime.Now - lastActivityTime;
            if (inactivity.TotalSeconds >= inactivityLimitSeconds)
            {
                inactivityTimer.Stop();
                MessageBox.Show("You've been inactive for 5 minutes. Logging out...");

                // Clear the session
                StayLoggedIn.ClearSession();

                // Hide the current home form and show the login form
                this.Hide();
                login_form loginForm = new login_form();
                loginForm.ShowDialog(); // Show the login form modally

                // After the login form is closed, close the current app (home form)
                this.Close();
            }
        }

        public void Reload()
        {

            int? userId = StayLoggedIn.GetCurrentUserId();
            if (userId.HasValue)
            {
                LoadRecentSearches(userId.Value); // Pass userId to load recent searches
            }
            else
            {
                MessageBox.Show("Please log in first.");
            }
            List<string> genres = GetUserGenres(currentUserId);
            if (genres != null && genres.Count > 0)
            {
                DisplayMoviesByGenre(genres); // Display movies based on multiple genres
            }
            else
            {
                MessageBox.Show(
                    "No genre preferences found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public async void home_form_Load(object sender, EventArgs e)
        {
            if (userType == "admin")
            {
                lastActivityTime = DateTime.Now;

                inactivityTimer = new Timer();
                inactivityTimer.Interval = 1000;
                inactivityTimer.Tick += InactivityTimer_Tick;
                inactivityTimer.Start();
            }

            // Attach MouseMove to all controls
            this.MouseMove += AllControls_MouseMove;

            AttachMouseMoveToAllControls(this);

            // Hook global mouse move event
            this.MouseMove += home_form_MouseMove;
            // Get the userId from the session
            int? userId = StayLoggedIn.GetCurrentUserId();
            if (userId.HasValue)
            {
                LoadRecentSearches(userId.Value); // Pass userId to load recent searches
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

            connection = new MySqlConnection(
                "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;"
            );

            try
            {
                connection.Open(); // ✅ Must open it before any SQL
                DisplayAllMovies();

                List<string> genres = GetUserGenres(currentUserId);
                if (genres != null && genres.Count > 0)
                {
                    DisplayMoviesByGenre(genres); // Display movies based on multiple genres
                }
                else
                {
                    MessageBox.Show(
                        "No genre preferences found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
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

            CurvePanel(recentlyMovie_panel, 30);
            movie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

            CurvePanel(recentlysearch_flp, 30);
            recentlysearch_flp.Resize += (s, args) => CurvePanel(recentlysearch_flp, 20);

            CurvePanel(allMovie_panel, 30);
            allMovie_panel.Resize += (s, aargs) => CurvePanel(allMovie_panel, 20);

            CurvePanel(allMovie_flp, 30);
            allMovie_panel.Resize += (s, aargs) => CurvePanel(allMovie_panel, 20);

            CurvePanel(AdminControl_panel, 30);
            allMovie_panel.Resize += (s, aargs) => CurvePanel(allMovie_panel, 20);
        }

        private void home_form_MouseMove(object sender, MouseEventArgs e)
        {
            lastActivityTime = DateTime.Now;
        }
        private List<string> GetUserGenres(int userId)
        {
            List<string> genres = new List<string>();
            string query = "SELECT preferences FROM users WHERE user_id = @userId";

            try
            {
                // Check if the connection is open, and if not, open it.
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    // Execute the query and get the result
                    var result = cmd.ExecuteScalar();

                    // Check if result is DBNull or null
                    if (result != DBNull.Value && result != null)
                    {
                        string preferences = result.ToString();

                        if (!string.IsNullOrEmpty(preferences))
                        {
                            // Split genres by commas and trim spaces
                            genres = preferences
                                .Split(',')
                                .Select(g => g.Trim())
                                .Where(g => !string.IsNullOrEmpty(g)) // Ensure no empty genres are included
                                .ToList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving user genres: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed after the operation.
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return genres;
        }


        private HashSet<int> displayedMovies = new HashSet<int>(); // Track displayed movie IDs

        private async void DisplayMoviesByGenre(List<string> genres)
        {
            if (genres == null || genres.Count == 0)
            {
                MessageBox.Show("No genres to display.");
                return;
            }

            recommendedMovie_flp.Controls.Clear(); // Clear existing movies
            displayedMovies.Clear(); // Reset the displayed movie IDs

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
                    if (displayedMovies.Contains(movie.Id)) continue;

                    // Create a panel to hold the movie poster
                    Panel moviePanel = new Panel
                    {
                        Size = new Size(140, 180),
                        Margin = new Padding(5),
                        BackColor = Color.Gray,
                        Cursor = Cursors.Hand
                    };

                    // Create a PictureBox for the movie poster
                    PictureBox poster = new PictureBox
                    {
                        Size = new Size(140, 180),
                        Location = new Point(5, 0),
                        BackColor = Color.Black,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        BorderStyle = BorderStyle.FixedSingle,
                        Image = Properties.Resources.icons8_loading_50 // Show loading first
                    };

                    // Add poster first to panel, and panel to UI
                    moviePanel.Controls.Add(poster);
                    recommendedMovie_flp.Controls.Add(moviePanel);
                    displayedMovies.Add(movie.Id);

                    // Shared click behavior
                    EventHandler clickHandler = (s, e) =>
                    {
                        LogMovieInteraction(currentUserId, movie.Id);
                        ShowMovieDetails(movie);
                    };

                    moviePanel.Click += clickHandler;
                    foreach (Control ctrl in moviePanel.Controls)
                        ctrl.Click += clickHandler;

                    // Load image in background
                    _ = Task.Run(async () =>
                    {
                        try
                        {
                            string cachedImagePath = null;
                            if (!string.IsNullOrEmpty(movie.ImageUrl))
                            {
                                cachedImagePath = await ImageCacheHelper.DownloadImageIfNotCachedAsync(movie.ImageUrl);
                            }

                            Image imageToShow = File.Exists(cachedImagePath)
                                ? Image.FromFile(cachedImagePath)
                                : Properties.Resources.fallback;

                            // Safe UI update
                            if (poster.IsHandleCreated)
                            {
                                poster.Invoke((MethodInvoker)(() =>
                                {
                                    poster.Image = imageToShow;
                                }));
                            }
                        }
                        catch
                        {
                            if (poster.IsHandleCreated)
                            {
                                poster.Invoke((MethodInvoker)(() =>
                                {
                                    poster.Image = Properties.Resources.fallback;
                                }));
                            }
                        }
                    });
                }
            }
        }


        private async void DisplayAllMovies()
        {
            if (!this.IsHandleCreated)
            {
                await Task.Delay(100); // Ensure handle is created
                if (!this.IsHandleCreated) return;
            }

            this.Invoke((MethodInvoker)(() => allMovie_flp.Controls.Clear())); // Clear the previous movies

            // Get all movies
            List<movie> allMovies = GetAllMovies();

            if (allMovies == null || allMovies.Count == 0)
            {
                this.Invoke((MethodInvoker)(() => MessageBox.Show("No movies to display.")));
                return;
            }

            foreach (var movie in allMovies)
            {
                // Create a panel to hold the movie poster
                Panel moviePanel = new Panel
                {
                    Size = new Size(140, 180),
                    Margin = new Padding(5),
                    BackColor = Color.Gray,
                    Cursor = Cursors.Hand
                };

                // Create a PictureBox for the movie poster
                PictureBox poster = new PictureBox
                {
                    Size = new Size(140, 180),
                    Location = new Point(5, 0),
                    BackColor = Color.Black,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle,
                    Image = Properties.Resources.icons8_loading_50 // use a loading image
                };

                // Try to load the movie poster image
                try
                {
                    if (!string.IsNullOrEmpty(movie.ImageUrl))
                    {
                        string cachedImagePath = await ImageCacheHelper.DownloadImageIfNotCachedAsync(movie.ImageUrl);
                        if (cachedImagePath != null)
                        {
                            this.Invoke((MethodInvoker)(() =>
                            {
                                poster.Image = Image.FromFile(cachedImagePath);
                            }));
                        }
                        else
                        {
                            this.Invoke((MethodInvoker)(() =>
                            {
                                poster.Image = Properties.Resources.fallback;
                            }));
                        }
                    }
                    else
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            poster.Image = Properties.Resources.fallback;
                        }));
                    }
                }
                catch
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        poster.Image = Properties.Resources.fallback;
                    }));
                }

                moviePanel.Controls.Add(poster);

                // Movie panel click event to show movie details
                EventHandler clickHandler = (s, e) =>
                {
                    LogMovieInteraction(currentUserId, movie.Id);
                    ShowMovieDetails(movie);
                };

                moviePanel.Click += clickHandler;
                foreach (Control ctrl in moviePanel.Controls)
                {
                    ctrl.Click += clickHandler;
                }

                this.Invoke((MethodInvoker)(() =>
                {
                    allMovie_flp.Controls.Add(moviePanel);
                }));
            }
        }


        private List<movie> GetMovies(int offset, int limit)
        {
            List<movie> movies = new List<movie>();
            string query = "SELECT * FROM Movies LIMIT @limit OFFSET @offset";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@limit", limit);
                cmd.Parameters.AddWithValue("@offset", offset);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        movies.Add(
                            new movie
                            {
                                Id = reader.GetInt32("movie_id"),
                                Title = reader.GetString("title"),
                                Description = reader.IsDBNull(reader.GetOrdinal("description"))
                                    ? ""
                                    : reader.GetString("description"),
                                Genre = reader.IsDBNull(reader.GetOrdinal("genre"))
                                    ? ""
                                    : reader.GetString("genre"),
                                ReleaseYear = reader.GetInt32("release_year"),
                                Rating = reader.IsDBNull(reader.GetOrdinal("rating"))
                                    ? 0
                                    : reader.GetDecimal("rating"),
                                ImageUrl = reader.IsDBNull(reader.GetOrdinal("image_url"))
                                    ? ""
                                    : reader.GetString("image_url")
                            }
                        );
                    }
                }
            }

            return movies;
        }
  
        public void LogMovieInteraction(int userId, int movieId)
        {
            string checkUserQuery = "SELECT COUNT(*) FROM users WHERE user_id = @userId";
            string checkMovieQuery = "SELECT COUNT(*) FROM movies WHERE movie_id = @movieId";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open(); // Open the connection to the database

                    // Check if user exists
                    using (MySqlCommand checkUserCmd = new MySqlCommand(checkUserQuery, conn))
                    {
                        checkUserCmd.Parameters.AddWithValue("@userId", userId);
                        int userExists = Convert.ToInt32(checkUserCmd.ExecuteScalar()); // <-- You forgot this line!

                        if (userExists == 0)
                        {
                            MessageBox.Show(
                                "The user does not exist. Please check the user ID.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            return;
                        }
                    }

                    // Check if movie exists
                    using (MySqlCommand checkMovieCmd = new MySqlCommand(checkMovieQuery, conn))
                    {
                        checkMovieCmd.Parameters.AddWithValue("@movieId", movieId);
                        int movieExists = Convert.ToInt32(checkMovieCmd.ExecuteScalar());

                        if (movieExists == 0)
                        {
                            MessageBox.Show(
                                "The movie does not exist. Please check the movie ID.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            return;
                        }
                    }

                    // If both user and movie exist, insert into movie_interaction
                    string insertQuery =
                        "INSERT INTO movie_interaction (user_id, movie_id, created_at) VALUES (@userId, @movieId, @createdAt)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@movieId", movieId);
                        cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }

                    // Log movie view
                    string logViewQuery =
                        "INSERT INTO movie_views (user_id, movie_id, viewed_at) VALUES (@userId, @movieId, @viewedAt)";
                    using (MySqlCommand cmdView = new MySqlCommand(logViewQuery, conn))
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
                MessageBox.Show(
                    "Failed to log movie interaction: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private List<movie> GetMoviesByGenre(string genre)
        {
            List<movie> movies = new List<movie>();

            // Ensure the connection is open
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();  // Open the connection if it's not already open
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while opening the connection: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return movies; // Return empty list on failure to open connection
                }
            }

            string query = "SELECT * FROM Movies WHERE LOWER(genre) LIKE CONCAT('%', LOWER(@genre), '%')";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@genre", genre);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movies.Add(
                                new movie
                                {
                                    Id = reader.GetInt32("movie_id"),
                                    Title = reader.GetString("title"),
                                    Description = reader.IsDBNull(reader.GetOrdinal("description")) ? "" : reader.GetString("description"),
                                    Genre = reader.IsDBNull(reader.GetOrdinal("genre")) ? "" : reader.GetString("genre"),
                                    ReleaseYear = reader.GetInt32("release_year"),
                                    Rating = reader.IsDBNull(reader.GetOrdinal("rating")) ? 0 : reader.GetDecimal("rating"),
                                    ImageUrl = reader.IsDBNull(reader.GetOrdinal("image_url")) ? "" : reader.GetString("image_url")
                                }
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching movies: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed after the operation
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return movies;
        }

        private List<movie> GetAllMovies()
        {
            List<movie> movies = new List<movie>();
            string query = "SELECT * FROM Movies"; // No genre filter

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        movies.Add(
                            new movie
                            {
                                Id = reader.GetInt32("movie_id"),
                                Title = reader.GetString("title"),
                                Description = reader.IsDBNull(reader.GetOrdinal("description"))
                                    ? ""
                                    : reader.GetString("description"),
                                Genre = reader.IsDBNull(reader.GetOrdinal("genre"))
                                    ? ""
                                    : reader.GetString("genre"),
                                ReleaseYear = reader.GetInt32("release_year"),
                                Rating = reader.IsDBNull(reader.GetOrdinal("rating"))
                                    ? 0
                                    : reader.GetDecimal("rating"),
                                ImageUrl = reader.IsDBNull(reader.GetOrdinal("image_url"))
                                    ? ""
                                    : reader.GetString("image_url")
                            }
                        );
                    }
                }
            }

            return movies;
        }
        public void ShowMovieDetails(movie movie)
        {
            try
            {
                var movieDetailsForm = new movie_details_form(
                    movie,
                    StayLoggedIn.GetCurrentUserId().Value
                );
                movieDetailsForm.StartPosition = FormStartPosition.CenterParent;
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
            string title = "Confirm Navigation";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(msg, title, btn, icon);

            if (result == DialogResult.Yes)
            {
                // Ensure the session is saved before exiting
                var currentSession = StayLoggedIn.LoadUserSession();
                if (currentSession.HasValue)
                {
                    StayLoggedIn.SaveUserSession(
                        currentSession.Value.userType,
                        currentSession.Value.userId
                    );
                }

                // Close the application
                Application.Exit();
            }
            else
            {
                return; // Do nothing if user cancels the close
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
        public void favorite_btn_Click(object sender, EventArgs e)
        {
            if (Favorite_panel.Visible == false)
            {
           
                form_lbl.Text = "FAVORITE";
                Favorite_panel.Visible = true;
                userProfile_panel.Visible = false;
                AdminControl_panel.Visible = false;
                movie_panel.Visible = false;
                popular_panel.Visible = false;
                settings_panel.Visible = false;
                // Create an instance of FavoriteControl
                FavoriteControl favoriteControl = new FavoriteControl(userType, currentUserId);
                // Clear any existing controls from Favorite_panel if necessary
                Favorite_panel.Controls.Clear();
                // Add the FavoriteControl to the Favorite_panel
                Favorite_panel.Controls.Add(favoriteControl);

                // Optionally set FavoriteControl's dock property to fill the parent panel
                favoriteControl.Dock = DockStyle.Fill; // Fills the parent panel (Favorite_panel)
            }
            else
            {
                Reload();
                Favorite_panel.Visible = false;
                userProfile_panel.Visible = false;
                AdminControl_panel.Visible = false;
                movie_panel.Visible = true;
                popular_panel.Visible = false;
                settings_panel.Visible = false;

                List<string> genres = GetUserGenres(currentUserId);
                if (genres != null && genres.Count > 0)
                {
                    DisplayMoviesByGenre(genres); // Display movies based on multiple genres
                }
                else
                {
                    MessageBox.Show(
                        "No genre preferences found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        private void popular_btn_Click(object sender, EventArgs e)
        {
            if (popular_panel.Visible == false)
            {
             
                form_lbl.Text = "POPULAR";
                // Create an instance of FavoriteControl
                PopularControl popularControl = new PopularControl(userType, currentUserId);
                // Clear any existing controls from Favorite_panel if necessary
                popular_panel.Controls.Clear();
                // Add the FavoriteControl to the Favorite_panel
                popular_panel.Controls.Add(popularControl);

                // Optionally set FavoriteControl's dock property to fill the parent panel
                popularControl.Dock = DockStyle.Fill; // Fills the parent panel (Favorite_panel)

                popular_panel.Visible = true;
                Favorite_panel.Visible = false;
                userProfile_panel.Visible = false;
                AdminControl_panel.Visible = false;
                movie_panel.Visible = false;
                settings_panel.Visible = false;
            }
            else
            {
                Reload();
                form_lbl.Text = "HOME";

                popular_panel.Visible = false;
                Favorite_panel.Visible = false;
                userProfile_panel.Visible = false;
                AdminControl_panel.Visible = false;
                movie_panel.Visible = true;
                settings_panel.Visible = false;

                List<string> genres = GetUserGenres(currentUserId);
                if (genres != null && genres.Count > 0)
                {
                    DisplayMoviesByGenre(genres); // Display movies based on multiple genres
                }
                else
                {
                    MessageBox.Show(
                        "No genre preferences found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }
        private void settings_btn_Click(object sender, EventArgs e)
        {
            if (settings_panel.Visible == false)
            {

                form_lbl.Text = "SETTINGS";
                Favorite_panel.Visible = false;
                userProfile_panel.Visible = false;
                AdminControl_panel.Visible = false;
                movie_panel.Visible = false;
                popular_panel.Visible = false;
                settings_panel.Visible = true;

                // Create an instance of FavoriteControl
                settingsControl settings = new settingsControl(userType, currentUserId);

                // Clear any existing controls from Favorite_panel if necessary
                settings_panel.Controls.Clear();
                // Add the FavoriteControl to the Favorite_panel
                settings_panel.Controls.Add(settings);

                // Optionally set FavoriteControl's dock property to fill the parent panel
                settings.Dock = DockStyle.Fill; // Fills the parent panel (Favorite_panel)
            }
            else
            {
                Reload();
                Favorite_panel.Visible = false;
                userProfile_panel.Visible = false;
                AdminControl_panel.Visible = false;
                movie_panel.Visible = true;
                popular_panel.Visible = false;
                settings_panel.Visible = false;

                List<string> genres = GetUserGenres(currentUserId);
                if (genres != null && genres.Count > 0)
                {
                    DisplayMoviesByGenre(genres); // Display movies based on multiple genres
                }
                else
                {
                    MessageBox.Show(
                        "No genre preferences found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }
        private bool IsValidUrl(string url)
        {
            return Uri.IsWellFormedUriString(url, UriKind.Absolute)
                && (url.StartsWith("http://") || url.StartsWith("https://"));
        }
        private void signOut_btn_Click(object sender, EventArgs e)
        {
            logOut();
        }

        public void logOut()
        {
            string msg = "Do you really want to sign out?";
            string title = "Confirm Navigation";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(msg, title, btn, icon);

            if (result == DialogResult.Yes)
            {
                // Save the session if needed
                var currentSession = StayLoggedIn.LoadUserSession();
                if (currentSession.HasValue)
                {
                    StayLoggedIn.SaveUserSession(
                        currentSession.Value.userType,
                        currentSession.Value.userId
                    );
                }

                // Clear the session
                StayLoggedIn.ClearSession();

                // Hide the current home form and show the login form
                this.Hide();
                login_form loginForm = new login_form();
                loginForm.ShowDialog(); // Show the login form modally

                // After the login form is closed, close the current app (home form)
                this.Close();
            }
            else
            {
                return; // Do nothing if user cancels
            }
        }

        private void search_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (search_list.SelectedItem is movie selectedMovie)
            {
                movie fullMovie = GetFullMovieByTitle(selectedMovie.Title);
                if (fullMovie != null)
                {
                    int? userId = StayLoggedIn.GetCurrentUserId();
                    if (userId.HasValue)
                    {
                        EnsureMovieExistsInMoviesTable(fullMovie);
                        SaveRecentSearch(userId.Value, fullMovie);
                        LoadRecentSearches(userId.Value);

                        var detailsForm = new movie_details_form(fullMovie, userId.Value);
                        detailsForm.StartPosition = FormStartPosition.CenterParent;
                        detailsForm.ShowDialog();
                    }
                }

                // Clear selection and UI cleanup
                search_tb.Clear();
                search_txt_Leave(sender, e);
                search_list.ClearSelected();
                search_list.Visible = false;
                this.ActiveControl = null;
            }
        }

        //search
        private async void DisplaySingleMovie(movie movie, FlowLayoutPanel targetPanel)
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
                Location = new Point(0, 0),
                BackColor = Color.Black,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle,
                Image = Properties.Resources.icons8_loading_50 // Optional loading placeholder
            };

            moviePanel.Controls.Add(poster);

            // Attach only one safe click handler to avoid double openings
            EventHandler openDetailsHandler = (s, e) => ShowMovieDetails(movie);
            moviePanel.Click += openDetailsHandler;
            poster.Click += openDetailsHandler;

            // Add to target panel
            targetPanel.Controls.Add(moviePanel);

            // Load poster asynchronously
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


        private bool IsMovieAlreadyInPanel(movie movie, FlowLayoutPanel panel)
        {
            // Iterate through all panels in the FlowLayoutPanel
            foreach (Control control in panel.Controls)
            {
                if (    
                    control is Panel moviePanel
                    && moviePanel.Tag is int movieId
                    && movieId == movie.Id
                )
                {
                    return true; // Movie already exists in the panel
                }
            }
            return false; // Movie does not exist
        }
        private void search_list_Click(object sender, EventArgs e)
        {
            if (search_list.SelectedItem is movie selectedMovie)
            {
                var fullMovie = GetFullMovieByTitle(selectedMovie.Title);

                if (fullMovie != null)
                {
                    int? userId = StayLoggedIn.GetCurrentUserId();
                    if (userId.HasValue)
                    {
                        EnsureMovieExistsInMoviesTable(fullMovie);
                        SaveRecentSearch(userId.Value, fullMovie);
                        LoadRecentSearches(userId.Value);

                        var movieDetailsForm = new movie_details_form(fullMovie, userId.Value);
                        movieDetailsForm.StartPosition = FormStartPosition.CenterParent;
                        movieDetailsForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("User session is not found. Please log in.");
                    }
                }
                else
                {
                    MessageBox.Show("Movie not found in the database.");
                }

                // Reset UI
                search_list.ClearSelected();
                search_list.Visible = false;
                search_tb.Clear();
                search_txt_Leave(sender, e);
                this.ActiveControl = null;
            }
        }

        private void LoadRecentSearchSuggestions()
        {
            string connStr = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
            string query =
                "SELECT movie_title FROM recent_searches WHERE user_id = @userId ORDER BY search_date DESC LIMIT 3";

            try
            {
                search_list.Items.Clear(); // Clear previous search results

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", currentUserId); // Make sure currentUserId is set

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var movie = new movie
                                {
                                    Title = reader.GetString("movie_title") // Should match the SELECT
                                };

                                search_list.Items.Add(movie);
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

        private void SaveRecentSearch(int userId, movie movie)
        {
            string connStr = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
            string checkQuery =
                "SELECT COUNT(*) FROM recent_searches WHERE user_id = @userId AND movie_id = @movieId";
            string insertQuery =
                "INSERT INTO recent_searches (user_id, movie_id, movie_title, movie_description, movie_genre, release_year, image_url, search_date) "
                + "VALUES (@userId, @movieId, @movieTitle, @movieDescription, @movieGenre, @releaseYear, @imageUrl, NOW())";
            string updateQuery =
                "UPDATE recent_searches SET search_date = NOW() WHERE user_id = @userId AND movie_id = @movieId";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(checkQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@movieId", movie.Id);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@userId", userId);
                                updateCmd.Parameters.AddWithValue("@movieId", movie.Id);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@userId", userId);
                                insertCmd.Parameters.AddWithValue("@movieId", movie.Id);
                                insertCmd.Parameters.AddWithValue("@movieTitle", movie.Title);
                                insertCmd.Parameters.AddWithValue(
                                    "@movieDescription",
                                    movie.Description
                                );
                                insertCmd.Parameters.AddWithValue("@movieGenre", movie.Genre);
                                insertCmd.Parameters.AddWithValue(
                                    "@releaseYear",
                                    movie.ReleaseYear
                                );
                                insertCmd.Parameters.AddWithValue(
                                    "@imageUrl",
                                    movie.ImageUrl ?? (object)DBNull.Value
                                );

                                insertCmd.ExecuteNonQuery();
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

        private void ShowMovieDetailsForm(movie movie)
        {
            movie_details_form detailsForm = new movie_details_form(movie, userId);
            detailsForm.ShowDialog();
        }
        private movie GetFullMovieByTitle(string title)
        {
            string connStr = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
            string query = "SELECT * FROM movies WHERE title = @title LIMIT 1";
            search_list.Items.Clear();

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
                            return new movie
                            {
                                Title = reader.GetString("title"),
                                Description = reader.GetString("description"),
                                Genre = reader.GetString("genre"),
                                ReleaseYear = reader.GetInt32("release_year"),
                                ImageUrl = reader.IsDBNull(reader.GetOrdinal("image_url"))
                                    ? null
                                    : reader.GetString("image_url")
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
                LoadRecentSearchSuggestions(); // ✅ pass userId
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
                                var movie = new movie
                                {
                                    Title = reader.GetString("title"),
                                    ImageUrl = reader.IsDBNull(reader.GetOrdinal("image_url"))
                                        ? null
                                        : reader.GetString("image_url")
                                };
                                search_list.Items.Add(movie);
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
            if (search_tb.ForeColor == Color.Gray)
            {
                search_tb.Text = "";
                search_tb.ForeColor = Color.Black;
            }
        }

        private string GetRecentSearchTitles(int userId)
        {
            List<string> recentTitles = new List<string>();
            string connStr = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
            string query =
                "SELECT movie_title FROM recent_searches WHERE user_id = @userId ORDER BY search_date DESC LIMIT 3";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string title = reader.GetString("movie_title");
                                recentTitles.Add(title);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // Join the titles into a single string (separated by commas)
            return string.Join(", ", recentTitles);
        }

        private void search_txt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(search_tb.Text))
            {
                search_tb.Text = "Search..."; // Set the placeholder text
                search_tb.ForeColor = Color.Gray; // Change the text color to gray for placeholder
            }
        }
        public async Task LoadRecentSearches(int currentUserId)
        {
            string connStr = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
            string query =
                @"
            SELECT movie_id, movie_title, movie_description, movie_genre, release_year, image_url 
            FROM ( 
                SELECT * FROM recent_searches 
                WHERE user_id = @userId 
                ORDER BY search_date DESC
            ) AS ordered
            GROUP BY movie_id
            ORDER BY search_date DESC
            LIMIT 7;
        ";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    await conn.OpenAsync();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", currentUserId);
                        using (var reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            recentlysearch_flp.FlowDirection = FlowDirection.LeftToRight;
                            recentlysearch_flp.WrapContents = false;
                            recentlysearch_flp.Controls.Clear();

                            HashSet<int> addedMovieIds = new HashSet<int>();

                            while (await reader.ReadAsync())
                            {
                                int movieId = reader.GetInt32("movie_id");

                                // Skip duplicates early
                                if (addedMovieIds.Contains(movieId))
                                    continue;

                                addedMovieIds.Add(movieId);

                                string title = reader.GetString("movie_title");
                                string description = reader.GetString("movie_description");
                                string genre = reader.GetString("movie_genre");
                                int releaseYear = reader.GetInt32("release_year");
                                string imageUrl = reader.IsDBNull(reader.GetOrdinal("image_url"))
                                    ? null
                                    : reader.GetString("image_url");

                                movie movie = new movie
                                {
                                    Id = movieId,
                                    Title = title,
                                    Description = description,
                                    Genre = genre,
                                    ReleaseYear = releaseYear,
                                    ImageUrl = imageUrl
                                };

                                await DisplayMovieInRecentlySearchAsync(movie);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recent searches: " + ex.Message);    
            }
        }

        private void search_list_TabIndexChanged(object sender, EventArgs e)
        {
            search_txt_Leave(sender, e); // still useful to keep placeholder logic

            if (search_list.SelectedItem is movie selectedMovie)
            {
                // Avoid adding the same movie twice
                if (!IsMovieAlreadyInPanel(selectedMovie, recentlysearch_flp))
                {
                    DisplaySingleMovie(selectedMovie, recentlysearch_flp);
                }

                // Clear the TextBox and remove focus
                search_tb.Clear();
                this.ActiveControl = null;
            }
            else if (string.IsNullOrWhiteSpace(search_tb.Text) || search_tb.Text == "Search...")
            {
                // Display 3 most recent searched titles
                string placeholder = GetRecentSearchTitles(currentUserId); // Make sure currentUserId is available
                search_tb.Text = placeholder;
                search_tb.ForeColor = Color.Gray;
            }
        }

        private async Task DisplayMovieInRecentlySearchAsync(movie movie)
        {
            // Same content as before...
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
                Image = Properties.Resources.icons8_loading_50 // use a loading image
            };


            moviePanel.Controls.Add(poster);
            recentlysearch_flp.Controls.Add(moviePanel);

            // Load image in background
            await Task.Run(async () =>
            {
                try
                {
                    if (!string.IsNullOrEmpty(movie.ImageUrl))
                    {
                        string cachedPath = await ImageCacheHelper.DownloadImageIfNotCachedAsync(movie.ImageUrl);
                        if (cachedPath != null && File.Exists(cachedPath))
                        {
                            Image loadedImage = Image.FromFile(cachedPath);

                            // Safe UI update
                            poster.Invoke((MethodInvoker)(() =>
                            {
                                poster.Image = loadedImage;
                            }));
                        }
                        else
                        {
                            poster.Invoke((MethodInvoker)(() =>
                            {
                                poster.Image = Properties.Resources.fallback;
                            }));
                        }
                    }
                    else
                    {
                        poster.Invoke((MethodInvoker)(() =>
                        {
                            poster.Image = Properties.Resources.fallback;
                        }));
                    }
                }
                catch
                {
                    if (poster.IsHandleCreated)
                    {
                        poster.Invoke((MethodInvoker)(() =>
                        {
                            poster.Image = Properties.Resources.fallback;
                        }));
                    }

                }
            });

            moviePanel.Click += (s, e) => ShowMovieDetails(movie);
            poster.Click += (s, e) => ShowMovieDetails(movie);

            moviePanel.Controls.Add(poster);

            recentlysearch_flp.Controls.Add(moviePanel);
        }


        private void home_btn_Click(object sender, EventArgs e)
        {
            movie_panel.Visible = true;

            form_lbl.Text = "HOME";
            AdminControl_panel.Visible = false;
            userProfile_panel.Visible = false;
            popular_panel.Visible = false;
            Favorite_panel.Visible = false;
            settings_panel.Visible = false;
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            if (AdminControl_panel.Visible == false)
            {
              
                form_lbl.Text = "ADMIN";
                AdminControl_panel.Visible = true;
                userProfile_panel.Visible = false;
                movie_panel.Visible = false;
                Favorite_panel.Visible = false;
                settings_panel.Visible = false;

                isProfilePanelActive = false; // If Admin panel is shown, the profile is inactive

                AdminControl adminPanel = new AdminControl(userType, userId);
                AdminControl_panel.Controls.Add(adminPanel);
            }
            else
            {
                Reload();
                AdminControl_panel.Visible = false;
                userProfile_panel.Visible = false;
                AdminControl_panel.Visible = false;
                movie_panel.Visible = true;
                popular_panel.Visible = false;
                settings_panel.Visible = false;

                List<string> genres = GetUserGenres(currentUserId);
                if (genres != null && genres.Count > 0)
                {
                    DisplayMoviesByGenre(genres);
                }
                else
                {
                    MessageBox.Show(
                        "No genre preferences found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            ProfileControl userProfilePanel = new ProfileControl(userType, currentUserId);

            if (!userProfile_panel.Visible)
            {
                form_lbl.Text = "PROFILE";

                // Show profile, hide other panels
                userProfile_panel.Visible = true;
                AdminControl_panel.Visible = false;
                Favorite_panel.Visible = false;
                popular_panel.Visible = false;
                movie_panel.Visible = false;
                settings_panel.Visible = false;

                // Pause the inactivity timer when the profile is shown
                Console.WriteLine("Pausing inactivity timer...");
                Console.WriteLine("Inactivity timer paused.");

                userProfile_panel.Controls.Clear();
                userProfilePanel.LoadProfileData();
                userProfile_panel.Controls.Add(userProfilePanel);
            }
            else
            {
                userProfile_panel.Visible = false;
                AdminControl_panel.Visible = false;
                popular_panel.Visible = false;
                Favorite_panel.Visible = false;
                movie_panel.Visible = true;
                settings_panel.Visible = false;

                List<string> genres = GetUserGenres(currentUserId);
                if (genres != null && genres.Count > 0)
                {
                    DisplayMoviesByGenre(genres); // Display movies based on multiple genres
                }
                else
                {
                    MessageBox.Show(
                        "No genre preferences found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        private void allMovie_flp_Scroll(object sender, ScrollEventArgs e)
        {
            if (
                e.Type == ScrollEventType.EndScroll
                && allMovie_flp.VerticalScroll.Value + allMovie_flp.ClientSize.Height
                    >= allMovie_flp.VerticalScroll.Maximum
            )
            {
                DisplayAllMovies();
            }
        }
        private void EnsureMovieExistsInMoviesTable(movie movie)
        {
            string connStr = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
            string checkQuery = "SELECT movie_id FROM movies WHERE title = @title";
            string insertQuery =
                "INSERT INTO movies (title, description, genre, release_year, image_url) "
                + "VALUES (@title, @description, @genre, @releaseYear, @imageUrl); SELECT LAST_INSERT_ID();";

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
                            insertCmd.Parameters.AddWithValue(
                                "@imageUrl",
                                string.IsNullOrEmpty(movie.ImageUrl)
                                  ? DBNull.Value
                                  : (object)movie.ImageUrl
                            );

                            object insertedId = insertCmd.ExecuteScalar();
                            movie.Id = Convert.ToInt32(insertedId);
                        }
                    }
                }
            }
        }

        private void AllControls_MouseMove(object sender, MouseEventArgs e)
        {
            lastActivityTime = DateTime.Now;
        }

        private void AttachMouseMoveToAllControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                ctrl.MouseMove += AllControls_MouseMove;

                // If the control contains more controls (e.g., a panel), recurse
                if (ctrl.HasChildren)
                {
                    AttachMouseMoveToAllControls(ctrl);
                }
            }
        }

 
    }
}




