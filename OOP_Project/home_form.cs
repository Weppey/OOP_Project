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

        private const int ScrollAmount = 200;
        private int currentOffsetX = 0;
        private const int ScrollStep = 200;

        // memo


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
                admin_button.Visible = true;
            }
            else
            {
                admin_button.Visible = false;
            }
        }

        private async void home_form_Load(object sender, EventArgs e)
        {
            LoadRecentSearches();

            recommendedMovie_flp.FlowDirection = FlowDirection.LeftToRight;
            recommendedMovie_flp.WrapContents = true;
            recommendedMovie_flp.AutoScroll = true;

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

                CurvePanel(viewportPanel, 30);
                viewportPanel.Resize += (s, args) => CurvePanel(movie_panel, 20);

                CurvePanel(recommendedMovie_flp, 30);
                recommendedMovie_flp.Resize += (s, args) => CurvePanel(movie_panel, 20);

                CurvePanel(popularmovie_pnl, 30);
                movie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

                CurvePanel(recentlysearch_flp, 30);
                viewportPanel.Resize += (s, args) => CurvePanel(movie_panel, 20);

                //LoadMovies();

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

                    //Label movieTitle = new Label
                   // {
                  //      Text = movie.Title,
                 //       Location = new Point(5, 5),
                 //       AutoSize = false,
                 //       Size = new Size(150, 35),
                //        Font = new Font("Times New Roman", 9, FontStyle.Bold),
                //        ForeColor = Color.White,
                //        TextAlign = ContentAlignment.MiddleCenter
                //    };

                    PictureBox poster = new PictureBox
                    {
                        Size = new Size(150, 200),
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

                   // moviePanel.Controls.Add(movieTitle);
                    moviePanel.Controls.Add(poster);

                    moviePanel.Click += (s, e) => ShowMovieDetails(movie);
                    foreach (Control ctrl in moviePanel.Controls)
                        ctrl.Click += (s, e) => ShowMovieDetails(movie);

                    recommendedMovie_flp.Controls.Add(moviePanel);
                }
            }
        }
      

        private List<Movie> GetMoviesByGenre(string genre)
        {


            List<Movie> movies = new List<Movie>();
            string query = "SELECT * FROM Movies WHERE LOWER(genre) = LOWER(@genre)";

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
            try
            {
                MovieDetailsForm details = new MovieDetailsForm(moovie);
                details.StartPosition = FormStartPosition.CenterScreen;
                details.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing movie details: {ex.Message}");
            }
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
                            // Append .jpg if no valid extension
                            if (!imageUrl.EndsWith(".jpg") && !imageUrl.EndsWith(".png"))
                            {
                                imageUrl += ".jpg";
                            }

                            try
                            {
                                if (Uri.IsWellFormedUriString(imageUrl, UriKind.Absolute))
                                {
                                    using (var webClient = new System.Net.WebClient())
                                    {
                                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                                        using (var stream = new MemoryStream(imageBytes))
                                        {
                                            card.PosterImage = Image.FromStream(stream);
                                        }
                                    }
                                }
                                else if (File.Exists(imageUrl)) // Local file path
                                {
                                    card.PosterImage = Image.FromFile(imageUrl);
                                }
                                else
                                {
                                    card.PosterImage = Properties.Resources.Netflix_N_Symbol_logo;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Failed to load image for movie ID {movieID}.\n\n{ex.Message}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                card.PosterImage = Properties.Resources.Netflix_N_Symbol_logo;
                            }
                        }
                        else
                        {
                            card.PosterImage = Properties.Resources.Netflix_N_Symbol_logo;
                        }

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
            search_txt.Clear();
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
        private void DisplaySingleMovie(Movie movie, FlowLayoutPanel panel)
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
            moviePanel.Click += (s, e) => ShowMovieDetailsForm(movie);
            foreach (Control ctrl in moviePanel.Controls)
                ctrl.Click += (s, e) => ShowMovieDetailsForm(movie);

            panel.Controls.Add(moviePanel);
        }

        private bool IsMovieAlreadyInPanel(Movie movie, FlowLayoutPanel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Panel panelControl)
                {
                    foreach (Control inner in panelControl.Controls)
                    {
                        if (inner is PictureBox poster && poster.Tag is Movie existingMovie)
                        {
                            if (existingMovie.Title == movie.Title)
                                return true;
                        }
                    }
                }
            }
            return false;
        }
        private void search_list_Click(object sender, EventArgs e)
        {
            if (search_list.SelectedItem is Movie selectedMovie)
            {
                // If you already have full data, no need to refetch
                var fullMovie = GetFullMovieByTitle(selectedMovie.Title);

                if (fullMovie != null)
                {
                    var movieDetailsForm = new MovieDetailsForm(fullMovie);
                    movieDetailsForm.StartPosition = FormStartPosition.CenterParent;
                    movieDetailsForm.ShowDialog();

                    if (!IsMovieAlreadyInPanel(fullMovie, recentlysearch_flp))
                    {
                        DisplaySingleMovie(fullMovie, recentlysearch_flp);
                    }
                }

                search_list.ClearSelected();
                search_list.Visible = false;
            }
        }
        //search
        private void ShowMovieDetailsForm(Movie movie)
        {
            MovieDetailsForm detailsForm = new MovieDetailsForm(movie);
            detailsForm.ShowDialog();
        }
        //search
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
            return null;
        }
        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            string keyword = search_txt.Text.Trim();

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
                if (search_txt.Text == "Search...")
                {
                    search_txt.Text = "";
                    search_txt.ForeColor = Color.Black;
                }           
        }

        private void search_txt_Leave(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(search_txt.Text))
            {
                search_txt.Text = "Search..."; // Set the placeholder text
                search_txt.ForeColor = Color.Gray; // Change the text color to gray for placeholder
            }
        }

        private void recommendedMovieLeft_btn_Click(object sender, EventArgs e)
        {
            // Define the scroll amount (how much to move each time the button is clicked)
            int scrollAmount = 200;

            // Calculate the new horizontal scroll position
            int newX = recommendedMovie_flp.HorizontalScroll.Value - scrollAmount;

            // Ensure that the new position is not less than 0 (no negative scroll)
            if (newX < 0)
                newX = 0;

            // Set the new horizontal scroll position
            recommendedMovie_flp.HorizontalScroll.Value = newX;
        }

        private void recommendedMovieRight_btn_Click(object sender, EventArgs e)
        {
            // Define the scroll amount
            int scrollAmount = 200;

            // Calculate the new horizontal scroll position
            int newX = recommendedMovie_flp.HorizontalScroll.Value + scrollAmount;

            // Ensure that the new position is not greater than the maximum scroll value
            if (newX > recommendedMovie_flp.HorizontalScroll.Maximum)
                newX = recommendedMovie_flp.HorizontalScroll.Maximum;

            // Set the new horizontal scroll position
            recommendedMovie_flp.HorizontalScroll.Value = newX;
        }
        //recent search    
        private void LoadRecentSearches()
        {
            string connStr = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
            string query = "SELECT movie_title, movie_description, movie_genre, release_year, image_url FROM recent_searches ORDER BY id DESC LIMIT 20"; // You can limit the number to 10

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string title = reader.GetString("movie_title");
                                string description = reader.GetString("movie_description");
                                string genre = reader.GetString("movie_genre");
                                int releaseYear = reader.GetInt32("release_year");
                                string imageUrl = reader.IsDBNull(reader.GetOrdinal("image_url")) ? null : reader.GetString("image_url");

                                // Create a Movie object from the data
                                Movie movie = new Movie
                                {
                                    Title = title,
                                    Description = description,
                                    Genre = genre,
                                    ReleaseYear = releaseYear,
                                    ImageUrl = imageUrl
                                };

                                // Display the movie in the recentlysearch_flp flow layout
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

            recentlysearch_flp.Controls.Add(moviePanel);
        }


        private List<Movie> GetRecentSearches()
        {
            List<Movie> recentMovies = new List<Movie>();

            string connStr = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
            string query = "SELECT movie_title, movie_description, movie_genre, release_year, image_url " +
                           "FROM recent_searches ORDER BY search_date DESC LIMIT 10"; // Limiting to 10 recent searches

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            recentMovies.Add(new Movie
                            {
                                Title = reader.GetString("movie_title"),
                                Description = reader.GetString("movie_description"),
                                Genre = reader.GetString("movie_genre"),
                                ReleaseYear = reader.GetInt32("release_year"),
                                ImageUrl = reader.IsDBNull(reader.GetOrdinal("image_url")) ? null : reader.GetString("image_url")
                            });
                        }
                    }
                }
            }

            return recentMovies;
        }
        private void DisplayRecentSearches()
        {
            var recentMovies = GetRecentSearches();

            foreach (var movie in recentMovies)
            {
                DisplaySingleMovie(movie, recentlysearch_flp);
            }
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            admin_form admin_Form = new admin_form(userType, currentUserId);
            admin_Form.ShowDialog();
        }

        private void insertInsert_btn_Click(object sender, EventArgs e)
        {

        }
    }


}


