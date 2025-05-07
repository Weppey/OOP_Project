using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WinFormsToolTip = System.Windows.Forms.ToolTip;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace OOP_Project
{
    public partial class AdminControl : UserControl
    {
        
            WinFormsToolTip tooltip = new WinFormsToolTip();
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";

        private DataTable movieTable = new DataTable();
        private BindingSource movieBindingSource = new BindingSource();

        private DataTable usersTable = new DataTable();
        private BindingSource usersBindingSource = new BindingSource();

        private BindingSource userBindingSource = new BindingSource();
        private bool isInsertingNewUser = true;

        private string userType;
        private int userId;

        public AdminControl(string userTypeFromLogin, int userIdFromLogin)
        {
            InitializeComponent();

            userType = userTypeFromLogin;
            userId = userIdFromLogin;
            tooltip.IsBalloon = false;                        // Makes it balloon-shaped
            tooltip.BackColor = Color.LightYellow;           // Tooltip background color (only works in custom-drawn tips)
            tooltip.ForeColor = Color.Black;                 // Text color
            tooltip.UseFading = true;                        // Smooth fade-in/out
            tooltip.UseAnimation = true;                     // Animate appearance

            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 100;
            tooltip.ReshowDelay = 100;
            tooltip.ShowAlways = true;

            tooltip.SetToolTip(insert_btn, "Insert");
            //tooltip.SetToolTip(submit_btn, "Submit"); nakacomment muna, nawawala yung button ehh
            //tooltip.SetToolTip(saveUser_btn, "Save User");
            tooltip.SetToolTip(Clear_btn, "Clear");
            tooltip.SetToolTip(remove_btn, "Remove");
            tooltip.SetToolTip(update_btn, "Update");
            tooltip.SetToolTip(editUser_btn, "Edit User");
            tooltip.SetToolTip(editMovie_btn, "Edit Movie");
            tooltip.SetToolTip(insertUser_btn, "Insert User");
            tooltip.SetToolTip(deleteUser_btn, "Delete User");
            ApplyTheme();

        }
        public void ApplyTheme()
        {
            Color labelForeColor = ThemeManager.IsDarkMode ? Color.White : Color.Black;
            Color buttonPanelColor = ThemeManager.IsDarkMode ? Color.FromArgb(26, 26, 26) : Color.Gray;
            Color controlPanelColor = ThemeManager.IsDarkMode ? Color.FromArgb(35, 35, 35) : Color.LightGray;
            Color anotherColor = ThemeManager.IsDarkMode ? Color.DarkGray : Color.Gainsboro;
            this.BackColor = buttonPanelColor;

            buttonDock_panel.BackColor = buttonPanelColor;
            movieEditor_panel.BackColor = buttonPanelColor;
            userEditor_panel.BackColor = buttonPanelColor;
            Admin_panel.BackColor = anotherColor;

            movieControlBtn_panel.BackColor = controlPanelColor;
            movieFillUp_panel.BackColor = controlPanelColor;
            fillup_panel.BackColor = controlPanelColor;
            controlBtn_panel.BackColor = controlPanelColor;

            // Labels
            profile_lbl.ForeColor = labelForeColor;
            profile_lbl.BackColor = Color.Transparent;

            Genre_lbl.ForeColor = labelForeColor;
            Genre_lbl.BackColor = Color.Transparent;

            movieEditor_lbl.ForeColor = labelForeColor;
            movieEditor_lbl.BackColor = Color.Transparent;

            // Controls
            emailVerified_cb.ForeColor = labelForeColor;
            emailVerified_cb.BackColor = controlPanelColor;
        }

        private void LoadMovies()
        {
            string query = "SELECT * FROM movies";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            movieTable.Clear();
            adapter.Fill(movieTable);
            movieBindingSource.DataSource = movieTable;
            movies_dgv.DataSource = movieBindingSource;
        }

        public void HandleMasterAccess()
        {
                usertype_cmb.Visible = true;
       
        }

        private void AdminMovieControl_Load(object sender, EventArgs e)
        {
            HandleMasterAccess();
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                LoadMovies();
                SetupSearchMoviesPlaceholder();
                SetupSearchUsersPlaceholder();
                LoadUsers();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message);
            }
            string[] movieGenres = { "Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Documentary", "Drama", "Family", "Fantasy", "History", "Horror", "Musical", "Mystery", "Romance", "Sci-Fi", "Sport", "Thriller", "War", "Western" };
            // Populate the CheckedListBox with movie genres

            string[] securityQuestions = { "What is your mother's maiden name?", "What was your first pet's name?", "What was your first car?", "What elementary school did you attend?", "What is your favorite food?" };
            securityQuestion_cmb.Items.AddRange(securityQuestions);

            foreach (var genre in movieGenres)
            {
                genre_clb.Items.Add(genre);
            }

            foreach (var genre in movieGenres)
            {
                userGenre_clb.Items.Add(genre);
            }

            CurvePanel(Admin_panel, 30);
            Admin_panel.Resize += (s, aargs) => CurvePanel(Admin_panel, 20);

            CurvePanel(avatar_pb, 30);
            avatar_pb.Resize += (s, aargs) => CurvePanel(avatar_pb, 20);

            //USERS

            CurvePanel(controlBtn_panel, 30);
            controlBtn_panel.Resize += (s, aargs) => CurvePanel(controlBtn_panel, 20);

            CurvePanel(fillup_panel, 30);
            fillup_panel.Resize += (s, aargs) => CurvePanel(fillup_panel, 20);

            CurvePanel(dataGrid_panel, 30);
            dataGrid_panel.Resize += (s, aargs) => CurvePanel(dataGrid_panel, 20);

            //MOVIES

            CurvePanel(movieFillUp_panel, 30);
            movieFillUp_panel.Resize += (s, aargs) => CurvePanel(movieFillUp_panel, 20);


            CurvePanel(movieControlBtn_panel, 30);
            movieControlBtn_panel.Resize += (s, aargs) => CurvePanel(movieControlBtn_panel, 20);
        }

        private void CurvePanel(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Top-left
            path.AddArc(new Rectangle(control.Width - radius, 0, radius, radius), 270, 90); // Top-right
            path.AddArc(new Rectangle(control.Width - radius, control.Height - radius, radius, radius), 0, 90); // Bottom-right
            path.AddArc(new Rectangle(0, control.Height - radius, radius, radius), 90, 90); // Bottom-left

            path.CloseFigure();
            control.Region = new Region(path);
        }

        private string GetSelectedGenres()
        {
            List<string> selectedGenres = new List<string>();

            // Loop through the CheckedItems in the CheckedListBox and collect the selected genres
            foreach (var item in genre_clb.CheckedItems)
            {
                selectedGenres.Add(item.ToString());
            }

            // Return the selected genres as a comma-separated string
            return string.Join(",", selectedGenres);
        }

        private void SetupSearchMoviesPlaceholder()
        {
            searchBox_tb.Text = "Search movies...";
            searchBox_tb.ForeColor = Color.Gray;

            searchBox_tb.GotFocus += (s, e) =>
            {
                if (searchBox_tb.Text == "Search movies...")
                {
                    searchBox_tb.Text = "";
                    searchBox_tb.ForeColor = Color.Black;
                }
            };

            searchBox_tb.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(searchBox_tb.Text))
                {
                    searchBox_tb.Text = "Search movies...";
                    searchBox_tb.ForeColor = Color.Gray;
                }
            };
        }

        private void SetupSearchUsersPlaceholder()
        {
            userSearchBox_tb.Text = "Search users...";
            userSearchBox_tb.ForeColor = Color.Gray;

            userSearchBox_tb.GotFocus += (s, e) =>
            {
                if (userSearchBox_tb.Text == "Search users...")
                {
                    userSearchBox_tb.Text = "";
                    userSearchBox_tb.ForeColor = Color.Black;
                }
            };

            userSearchBox_tb.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(userSearchBox_tb.Text))
                {
                    userSearchBox_tb.Text = "Search users...";
                    userSearchBox_tb.ForeColor = Color.Gray;
                }
            };
        }



        private void MovieClearCheckedItems()
        {
            for (int i = 0; i < genre_clb.Items.Count; i++)
            {
                genre_clb.SetItemChecked(i, false);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (movies_dgv.CurrentRow == null)
            {
                MessageBox.Show("Please select a movie to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int movieId = Convert.ToInt32(movies_dgv.CurrentRow.Cells["movie_id"].Value);

            // Get the selected genres as a comma-separated string
            string selectedGenres = GetSelectedGenres();

            // Validate the URLs
            if (!IsValidUrl(posterUrl_tb.Text) || !IsValidImagePoster(posterUrl_tb.Text) || !IsValidMovieUrl(movieUrl_tb.Text) || !IsValidUrl(trailerUrl_tb.Text))
            {
                MessageBox.Show("Please enter valid URLs for the poster, movie, and trailer. Ensure the poster URL ends with .jpg and the movie URL comes from onionplay.ch.", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearMovieInput();
                return;
            }

            // Prepare the query to update the movie
            string query = "UPDATE movies SET title=@title, genre=@genre, release_year=@release, image_url=@imageurl, movie_url=@movieurl, trailer_link=@trailerlink, description=@description WHERE movie_id=@id";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@title", title_tb.Text);
            cmd.Parameters.AddWithValue("@genre", selectedGenres); // Using the comma-separated genres
            cmd.Parameters.AddWithValue("@release", releaseYear_dtp.Value.Year); // Only the year
            cmd.Parameters.AddWithValue("@imageurl", posterUrl_tb.Text);
            cmd.Parameters.AddWithValue("@trailerlink", trailerUrl_tb.Text);
            cmd.Parameters.AddWithValue("@description", description_tb.Text); // Add description
            cmd.Parameters.AddWithValue("@id", movieId);
            cmd.Parameters.AddWithValue("@movieurl", movieUrl_tb.Text);

            // Execute the update query
            cmd.ExecuteNonQuery();
            MovieClearCheckedItems();
            LoadMovies(); // Refresh the movie list
        }

        private bool IsValidUrl(string url)
        {
            // Simple regex to validate URL (you can adjust the pattern if needed)
            string pattern = @"^(http|https)://([a-z0-9-]+\.)+[a-z]{2,3}(/.*)?$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(url);
        }

        private bool IsValidImagePoster(string url)
        {
            // Check if the URL ends with ".jpg"
            return url.ToLower().EndsWith(".jpg");
        }

        private bool IsValidMovieUrl(string url)
        {
            // Check if the URL starts with "https://onionplay.ch"
            return url.ToLower().StartsWith("https://onionplay.ch");
        }


        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this movie?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                insert_btn.Enabled = false;
                int movieId = Convert.ToInt32(movies_dgv.CurrentRow.Cells["movie_id"].Value);
                string query = "DELETE FROM movies WHERE movie_id=@id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", movieId);
                cmd.ExecuteNonQuery();

                title_tb.Text = "";
                posterUrl_tb.Text = "";
                releaseYear_dtp.Value = DateTime.Now;  // Set to a default value
                description_tb.Text = "";

                poster_pb.Image = null;


                MovieClearCheckedItems();
                LoadMovies();
            }
        }

        private void searchBox_tb_TextChanged(object sender, EventArgs e)
        {
            string filter = searchBox_tb.Text.Replace("'", "''");
            if (!string.IsNullOrWhiteSpace(filter) && filter != "Search movies...")
                movieBindingSource.Filter = $"title LIKE '%{filter}%' OR genre LIKE '%{filter}%'";
            else
                movieBindingSource.RemoveFilter();
        }

        private void movies_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = movies_dgv.Rows[e.RowIndex];
                title_tb.Text = row.Cells["title"].Value.ToString();

                // Convert release year (int) to DateTime (set to January 1st of that year)
                int releaseYear = Convert.ToInt32(row.Cells["release_year"].Value);
                releaseYear_dtp.Value = new DateTime(releaseYear, 1, 1); // Set to Jan 1st of the release year

                posterUrl_tb.Text = row.Cells["image_url"].Value.ToString();
                poster_pb.ImageLocation = row.Cells["image_url"].Value.ToString(); // Optional

                trailerUrl_tb.Text = row.Cells["trailer_link"].Value.ToString();

                movieUrl_tb.Text = row.Cells["movie_url"].Value.ToString() ;

                // Set description
                description_tb.Text = row.Cells["description"].Value.ToString();

                // Get genres from DB (assuming it's a comma-separated list)
                string genres = row.Cells["genre"].Value.ToString();
                string[] selectedGenres = genres.Split(',');

                // Deselect all genres
                for (int i = 0; i < genre_clb.Items.Count; i++)
                    genre_clb.SetItemChecked(i, false);

                // Select the genres that match the ones in the database
                foreach (var genre in selectedGenres)
                {
                    for (int i = 0; i < genre_clb.Items.Count; i++)
                    {
                        if (genre_clb.Items[i].ToString().Equals(genre.Trim(), StringComparison.OrdinalIgnoreCase))
                        {
                            genre_clb.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            ClearMovieInput();
    
        }
        public void ClearMovieInput()
        {
            insert_btn.Visible = true;
            title_tb.Text = "Enter title...";
            posterUrl_tb.Text = "Enter poster URL...";
            poster_pb.Image = Properties.Resources._11;
            description_tb.Text = "Enter description..."; // Clear the description textbox as well
            trailerUrl_tb.Text = "Enter trailer URL...";
            releaseYear_dtp.Value = DateTime.Now;
            MovieClearCheckedItems();
            movieUrl_tb.Text = "Enter movie URL...";

            // Clear the selection in the DataGridView
            if (movies_dgv.SelectedRows.Count > 0)
            {
                movies_dgv.ClearSelection(); // Deselect the selected row
            }
        }
        private void submit_btn_Click(object sender, EventArgs e)
        {
            // 1. Check if any of the fields contain the default placeholder text
            if (title_tb.Text == "Enter title..." ||
                posterUrl_tb.Text == "Enter poster URL..." ||
                description_tb.Text == "Enter description..." ||
                trailerUrl_tb.Text == "Enter trailer URL..." ||
                movieUrl_tb.Text == "Enter movie URL..." ||
                releaseYear_dtp.Value == DateTime.Now)
            {
                MessageBox.Show("Please fill out all fields before inserting a movie.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validate the email format
            if (!IsValidEmail(email_tb.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Check if the username already exists
            if (IsUsernameTaken(username_tb.Text))
            {
                MessageBox.Show("This username is already taken. Please choose a different one.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Check if a security question is selected
            if (securityQuestion_cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a security question.", "Security Question", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Check if gender is selected
            if (string.IsNullOrWhiteSpace(gender_cmb.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please select a gender.", "Gender Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If all checks pass, proceed with inserting the movie
            string selectedGenres = GetSelectedGenres();

            // Extract just the year from the release year DateTimePicker
            int releaseYear = releaseYear_dtp.Value.Year;

            // Insert query with description
            string query = "INSERT INTO movies (title, genre, release_year, image_url, trailer_link, movie_url, description) VALUES (@title, @genre, @release, @imageurl, @trailer_link, @movie_url, @description)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@title", title_tb.Text);
            cmd.Parameters.AddWithValue("@genre", selectedGenres); // Save genres as a comma-separated string
            cmd.Parameters.AddWithValue("@release", releaseYear); // Pass the release year (as integer)
            cmd.Parameters.AddWithValue("@imageurl", posterUrl_tb.Text);
            cmd.Parameters.AddWithValue("@trailerlink", trailerUrl_tb.Text);
            cmd.Parameters.AddWithValue("@description", description_tb.Text); // Save the description
            cmd.ExecuteNonQuery();
            MovieClearCheckedItems();
            LoadMovies(); // Refresh the movie list
        }

        // Method to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Method to check if the username already exists in the database
        private bool IsUsernameTaken(string username)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @username";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }


        private void editMovie_btn_Click(object sender, EventArgs e)
        {
            if (movieEditor_panel.Visible == false)
            {
                movieEditor_panel.Visible = true;
                userEditor_panel.Visible = false;
                LoadMovies();
                ClearMovieInput();
            }
            
            else
            {
                movieEditor_panel.Visible = false;
            }
        }

        //user editor 

        private void LoadUsers()
        {
            string query = "SELECT user_id, username, email, age, gender, birthdate, preferences, email_verified, user_type, signup_date, security_question, security_answer, avatar FROM users";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            usersTable.Clear();
            adapter.Fill(usersTable);
            usersBindingSource.DataSource = usersTable;
            users_dgv.DataSource = usersBindingSource;
        }


        private void LoadUserDetails(int userId)
        {
            string query = "SELECT * FROM users WHERE user_id=@userId";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@userId", userId);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                username_tb.Text = reader["username"].ToString();
                email_tb.Text = reader["email"].ToString();
                age_tb.Text = reader["age"].ToString();
                gender_cmb.SelectedItem = reader["gender"].ToString();

                // Load genre preferences
                string preferences = reader["preferences"].ToString();
                string[] selectedGenres = preferences.Split(',');
                for (int i = 0; i < userGenre_clb.Items.Count; i++)
                {
                    userGenre_clb.SetItemChecked(i, selectedGenres.Contains(userGenre_clb.Items[i].ToString()));
                }

                securityQuestion_cmb.Text = reader["security_question"].ToString();
                securityAnswer_tb.Text = reader["security_answer"].ToString();

                Birthdate_dtp.Value = Convert.ToDateTime(reader["birthdate"]);
                emailVerified_cb.Checked = Convert.ToBoolean(reader["email_verified"]);


                //Load user avatar
                if (!reader.IsDBNull(reader.GetOrdinal("avatar")))
                {
                    byte[] avatarData = (byte[])reader["avatar"];
                    using (MemoryStream ms = new MemoryStream(avatarData))
                    {
                        avatar_pb.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    avatar_pb.Image = Properties.Resources.avatar_default; // use a default image if no avatar is set
                }


                // ✅ Load user_type
                if (usertype_cmb.Items.Contains(reader["user_type"].ToString()))
                {
                    usertype_cmb.SelectedItem = reader["user_type"].ToString();
                }
                else
                {
                    usertype_cmb.SelectedIndex = -1; // fallback
                }
            }

            reader.Close();
        }



        // Function to save the changes made to a user's details
        private void SaveUserDetails(int userId)
        {
            string query = "UPDATE users SET username=@username, email=@email, age=@age, gender=@gender, " +
                           "preferences=@preferences, security_question=@securityQuestion, security_answer=@securityAnswer, " +
                           "birthdate=@birthdate, email_verified=@emailVerified, user_type=@userType WHERE user_id=@userId";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username_tb.Text);
            cmd.Parameters.AddWithValue("@email", email_tb.Text);
            cmd.Parameters.AddWithValue("@age", age_tb.Text);
            cmd.Parameters.AddWithValue("@gender", gender_cmb.SelectedItem?.ToString() ?? "");

            // Properly extract the preferences from the CheckedListBox
            cmd.Parameters.AddWithValue("@preferences", string.Join(",", genre_clb.CheckedItems.Cast<string>()));

            cmd.Parameters.AddWithValue("@securityQuestion", securityQuestion_cmb.SelectedItem?.ToString() ?? "");
            cmd.Parameters.AddWithValue("@securityAnswer", securityAnswer_tb.Text);
            cmd.Parameters.AddWithValue("@birthdate", Birthdate_dtp.Value.Date);
            cmd.Parameters.AddWithValue("@emailVerified", emailVerified_cb.Checked);

            // Add the new user_type parameter
            cmd.Parameters.AddWithValue("@userType", usertype_cmb.SelectedItem?.ToString() ?? "user");

            cmd.Parameters.AddWithValue("@userId", userId);

            cmd.ExecuteNonQuery();
            MessageBox.Show("✅ User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadUsers(); // Refresh the DataGridView if you want updated info reflected immediately
        }

        private void saveUser_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userID_tb.Text))
            {
                MessageBox.Show("User ID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(userID_tb.Text, out int userId))
            {
                MessageBox.Show("User ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveUserDetails(userId);
            LoadUsers();
            avatar_pb.Image = Properties.Resources._11;
        }

        // Button to update the security question
        private void updateSecurityQuestion_btn_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(userID_tb.Text);
            string query = "UPDATE users SET security_question=@securityQuestion, security_answer=@securityAnswer WHERE user_id=@userId";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@securityQuestion", securityQuestion_cmb.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@securityAnswer", securityAnswer_tb.Text);
            cmd.Parameters.AddWithValue("@userId", userId);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Security question updated successfully!");
        }

        private void deleteUser_btn_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(userID_tb.Text);
            string query = "DELETE FROM users WHERE user_id=@userId";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@userId", userId);
            avatar_pb.Image = Properties.Resources._11;

            cmd.ExecuteNonQuery();
            LoadUsers(); // Refresh the user list
            ResetUserForm();
            MessageBox.Show("User removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Function to handle user selection in the DataGridView for editing
        private void users_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = users_dgv.Rows[e.RowIndex];

                username_tb.StateCommon.Content.Color1 = Color.Black;
                userID_tb.StateCommon.Content.Color1 = Color.Black;
                email_tb.StateCommon.Content.Color1 = Color.Black;
                age_tb.StateCommon.Content.Color1 = Color.Black;
                securityAnswer_tb.StateCommon.Content.Color1 = Color.Black;
                usertype_cmb.StateCommon.ComboBox.Content.Color1 = Color.Black;
                securityQuestion_cmb.StateCommon.ComboBox.Content.Color1 = Color.Black;
                gender_cmb.StateCommon.ComboBox.Content.Color1 = Color.Black;

                userID_tb.Text = row.Cells["user_id"].Value.ToString();
                username_tb.Text = row.Cells["username"].Value.ToString();
                email_tb.Text = row.Cells["email"].Value.ToString();
                age_tb.Text = row.Cells["age"].Value.ToString();
                gender_cmb.SelectedItem = row.Cells["gender"].Value.ToString();
                securityQuestion_cmb.SelectedItem = row.Cells["security_question"].Value.ToString();
                securityAnswer_tb.Text = row.Cells["security_answer"].Value.ToString();

                // Load genre preferences (comma separated)
                string preferences = row.Cells["preferences"].Value.ToString();
                string[] selectedGenres = preferences.Split(',');

                // Deselect all first
                for (int i = 0; i < userGenre_clb.Items.Count; i++)
                    userGenre_clb.SetItemChecked(i, false);

                // Select matching genres
                foreach (var genre in selectedGenres)
                {
                    for (int i = 0; i < userGenre_clb.Items.Count; i++)
                    {
                        if (userGenre_clb.Items[i].ToString().Equals(genre.Trim(), StringComparison.OrdinalIgnoreCase))
                        {
                            userGenre_clb.SetItemChecked(i, true);
                        }
                    }
                }

                // Set birthdate
                if (DateTime.TryParse(row.Cells["birthdate"].Value?.ToString(), out DateTime birthdate))
                {
                    Birthdate_dtp.Value = birthdate;
                }

                // Email verified
                if (row.Cells["email_verified"].Value != null)
                {
                    bool isEmailVerified = Convert.ToBoolean(row.Cells["email_verified"].Value);
                    emailVerified_cb.Checked = isEmailVerified;
                }

                // User type
                string userType = row.Cells["user_type"].Value.ToString();
                if (usertype_cmb.Items.Contains(userType))
                {
                    usertype_cmb.SelectedItem = userType;
                }
                else
                {
                    usertype_cmb.SelectedIndex = -1;
                }

                // ✅ Load avatar BLOB from DataGridView cell
                if (row.Cells["avatar"].Value != DBNull.Value)
                {
                    byte[] avatarBytes = (byte[])row.Cells["avatar"].Value;
                    if (avatarBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(avatarBytes))
                        {
                            avatar_pb.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        if (gender_cmb.Text == "Male")
                        {
                            avatar_pb.Image = Properties.Resources.avatar_default;
                        }
                        else
                        {
                            avatar_pb.Image = Properties.Resources.avatar_women;
                        }
                    }
                }
                else
                {
                    if (gender_cmb.Text == "Male")
                    {
                        avatar_pb.Image = Properties.Resources.avatar_default;
                    }
                    else
                    {
                        avatar_pb.Image = Properties.Resources.avatar_women;
                    }
                }

                // Editing existing user
                isInsertingNewUser = false;
                insertUser_btn.Text = "Save Changes";
            }
        }

        private void editUser_btn_Click(object sender, EventArgs e)
        {
            if (userEditor_panel.Visible == false)
            {
                userEditor_panel.Visible = true;
                movieEditor_panel.Visible = false;
                LoadUsers();
                ClearInput();
            }
            else
            {
                userEditor_panel.Visible = false;
            }
        }

        private void userSearchBox_tb_Click(object sender, EventArgs e)
        {
            string searchQuery = userSearchBox_tb.Text.ToLower(); // Get the search text

            string query = "SELECT * FROM users WHERE username LIKE @searchQuery OR email LIKE @searchQuery";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");

            MySqlDataReader reader = cmd.ExecuteReader();

            // Remove the binding from the DataGridView before clearing
            users_dgv.DataSource = null;

            // Clear the existing rows
            users_dgv.Rows.Clear();

            // Manually define columns if they don't exist
            if (users_dgv.Columns.Count == 0)
            {
                users_dgv.Columns.Add("user_id", "User ID");
                users_dgv.Columns.Add("username", "Username");
                users_dgv.Columns.Add("email", "Email");
                users_dgv.Columns.Add("gender", "Gender");
            }

            // Add data rows
            while (reader.Read())
            {
                int userId = Convert.ToInt32(reader["user_id"]);
                string username = reader["username"].ToString();
                string email = reader["email"].ToString();
                string gender = reader["gender"].ToString();

                // Add the user data as a row in the DataGridView
                users_dgv.Rows.Add(userId, username, email, gender);
            }

            reader.Close();
        }

        private void userSearchBox_tb_Enter(object sender, EventArgs e)
        {
            // If the TextBox is currently showing the placeholder text, clear it when it gains focus
            if (userSearchBox_tb.Text == "Search...")
            {
                userSearchBox_tb.Text = "";
                userSearchBox_tb.ForeColor = System.Drawing.Color.Black; // Set text color to black
            }

        }

        private void userSearchBox_tb_Leave(object sender, EventArgs e)
        {
            // If the TextBox is empty when it loses focus, display the placeholder text
            if (string.IsNullOrWhiteSpace(userSearchBox_tb.Text))
            {
                userSearchBox_tb.Text = "Search..."; // Set placeholder text
                userSearchBox_tb.ForeColor = System.Drawing.Color.Gray; // Set color for placeholder text
            }
        }




        private void userSearchBox_tb_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = userSearchBox_tb.Text.ToLower(); // Get the search text

            string query = "SELECT * FROM users WHERE username LIKE @searchQuery OR email LIKE @searchQuery";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");

            MySqlDataReader reader = cmd.ExecuteReader();

            users_dgv.Rows.Clear(); // Important: Clear before adding new rows

            while (reader.Read())
            {
                int userId = Convert.ToInt32(reader["user_id"]);
                string username = reader["username"].ToString();
                string email = reader["email"].ToString();
                string gender = reader["gender"].ToString();

                users_dgv.Rows.Add(userId, username, email, gender);
            }

            reader.Close();
        }


        private void insertUser_btn_Click(object sender, EventArgs e)
        {
            // Check if any required fields are null or empty
            if (string.IsNullOrWhiteSpace(username_tb.Text) || string.IsNullOrWhiteSpace(email_tb.Text))
            {
                MessageBox.Show("Please ensure that the 'Username' and 'Email' fields are filled out before proceeding.",
                                "Missing Required Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Stop further execution if validation fails
            }

            if (isInsertingNewUser)
            {
                // Insert new user logic
                InsertNewUser();
            }
            else
            {
                // Update existing user logic
                UpdateUserDetails();
            }
        }

        private void InsertNewUser()
        {
            try
            {
                string query = "INSERT INTO users (username, email, age, gender, preferences, security_question, security_answer, birthdate, email_verified, user_type) " +
                               "VALUES (@username, @email, @age, @gender, @preferences, @securityQuestion, @securityAnswer, @birthdate, @emailVerified, @userType)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username_tb.Text);
                cmd.Parameters.AddWithValue("@email", email_tb.Text);
                cmd.Parameters.AddWithValue("@age", age_tb.Text);
                cmd.Parameters.AddWithValue("@gender", gender_cmb.SelectedItem?.ToString() ?? "");
                cmd.Parameters.AddWithValue("@preferences", string.Join(",", genre_clb.CheckedItems.Cast<string>()));
                cmd.Parameters.AddWithValue("@securityQuestion", securityQuestion_cmb.SelectedItem?.ToString() ?? "");
                cmd.Parameters.AddWithValue("@securityAnswer", securityAnswer_tb.Text);
                cmd.Parameters.AddWithValue("@birthdate", Birthdate_dtp.Value.Date);
                cmd.Parameters.AddWithValue("@emailVerified", emailVerified_cb.Checked);
                cmd.Parameters.AddWithValue("@userType", usertype_cmb.SelectedItem?.ToString() ?? "user");

                cmd.ExecuteNonQuery();
                MessageBox.Show("New user has been successfully added to the system. You can now view their details.",
                                "User Added Successfully",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                ResetUserForm();
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the user. Please try again.\n\nError: {ex.Message}",
                                "Error Adding User",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void UpdateUserDetails()
        {
            try
            {
                string query = "UPDATE users SET username=@username, email=@email, age=@age, gender=@gender, " +
                               "preferences=@preferences, security_question=@securityQuestion, security_answer=@securityAnswer, " +
                               "birthdate=@birthdate, email_verified=@emailVerified, user_type=@userType WHERE user_id=@userId";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username_tb.Text);
                cmd.Parameters.AddWithValue("@email", email_tb.Text);
                cmd.Parameters.AddWithValue("@age", age_tb.Text);
                cmd.Parameters.AddWithValue("@gender", gender_cmb.SelectedItem?.ToString() ?? "");
                cmd.Parameters.AddWithValue("@preferences", string.Join(",", userGenre_clb.CheckedItems.Cast<string>()));
                cmd.Parameters.AddWithValue("@securityQuestion", securityQuestion_cmb.SelectedItem?.ToString() ?? "");
                cmd.Parameters.AddWithValue("@securityAnswer", securityAnswer_tb.Text);
                cmd.Parameters.AddWithValue("@birthdate", Birthdate_dtp.Value.Date);
                cmd.Parameters.AddWithValue("@emailVerified", emailVerified_cb.Checked);
                cmd.Parameters.AddWithValue("@userType", usertype_cmb.SelectedItem?.ToString() ?? "user");
                cmd.Parameters.AddWithValue("@userId", Convert.ToInt32(userID_tb.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("User details updated successfully! All changes have been saved.",
                                "User Updated",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LoadUsers();
                ResetUserForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update user details.\n\nError: {ex.Message}\nPlease try again.",
                                "Error Updating User",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void ResetUserForm()
        {
            // Reset the form for a new user insertion
            username_tb.Clear();
            email_tb.Clear();
            userID_tb.Clear();
            age_tb.Clear();
            gender_cmb.SelectedIndex = -1;
            securityQuestion_cmb.SelectedIndex = -1;
            securityAnswer_tb.Clear();
            Birthdate_dtp.Value = DateTime.Now;
            emailVerified_cb.Checked = false;
            usertype_cmb.SelectedIndex = -1; // Reset user type
            UserClearCheckedItems();
            isInsertingNewUser = true;
            insertUser_btn.Text = "Add User";
        }


        private void UserClearCheckedItems()
        {
            for (int i = 0; i < genre_clb.Items.Count; i++)
            {
                userGenre_clb.SetItemChecked(i, false);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        public void ClearInput()
        {
            // Reset the textboxes to their placeholder text or default values and set the text color to gray
            username_tb.StateCommon.Content.Color1 = Color.Gray;
            username_tb.Text = "Enter username...";

            email_tb.StateCommon.Content.Color1 = Color.Gray;
            email_tb.Text = "Enter email...";

            age_tb.StateCommon.Content.Color1 = Color.Gray;
            age_tb.Text = "Enter age...";

            userID_tb.StateCommon.Content.Color1 = Color.Gray;
            userID_tb.Text = "Enter user ID...";

            securityAnswer_tb.StateCommon.Content.Color1 = Color.Gray;
            securityAnswer_tb.Text = "Security Answer";

            // Reset combo boxes to their default state (no selection)
            gender_cmb.SelectedIndex = -1;
            gender_cmb.Text = "Select gender...";
            gender_cmb.StateCommon.ComboBox.Content.Color1 = Color.Gray;

            securityQuestion_cmb.SelectedIndex = -1;
            usertype_cmb.SelectedIndex = -1;
            usertype_cmb.Text = "Select user type";

            avatar_pb.Image = Properties.Resources._11;

            // Reset the checked list box to default (no checked items)
            genre_clb.ClearSelected();
            userGenre_clb.ClearSelected();

            // Reset the DateTimePicker to the current date
            Birthdate_dtp.Value = DateTime.Now;

            // Reset the email verification checkbox and set its color
            emailVerified_cb.Checked = false;

            // Set button text back to "Add User" for new user creation
            insertUser_btn.Text = "Add User";

            // Reset the DataGridView selection if it's being used for user selection
            if (movies_dgv.SelectedRows.Count > 0)
            {
                movies_dgv.ClearSelection();
            }

            // Optionally reset the form or perform any additional cleanup
            isInsertingNewUser = true; // Assuming you want to reset to insert mode for a new user

            if (users_dgv.SelectedRows.Count > 0)
            {
                users_dgv.ClearSelection(); // Deselect the selected row
            }
        }


        // Username textbox enter and leave events
        private void username_tb_Enter(object sender, EventArgs e)
        {
            if (username_tb.Text == "Enter username...")
            {
                username_tb.StateCommon.Content.Color1 = Color.Black;
                username_tb.Text = "";
            }
        }

        private void username_tb_Leave(object sender, EventArgs e)
        {
            if (username_tb.Text == "")
            {
                username_tb.StateCommon.Content.Color1 = Color.Gray;
                username_tb.Text = "Enter username...";
            }
        }

        // UserID textbox enter and leave events
        private void userID_tb_Enter(object sender, EventArgs e)
        {
            if (userID_tb.Text == "Enter user ID...")
            {
                userID_tb.StateCommon.Content.Color1 = Color.Black;
                userID_tb.Text = "";
            }
        }

        private void userID_tb_Leave(object sender, EventArgs e)
        {
            if (userID_tb.Text == "")
            {
                userID_tb.StateCommon.Content.Color1 = Color.Gray;
                userID_tb.Text = "Enter user ID...";
            }
        }

        // Email textbox enter and leave events
        private void email_tb_Enter(object sender, EventArgs e)
        {
            if (email_tb.Text == "Enter email...")
            {
                email_tb.StateCommon.Content.Color1 = Color.Black;
                email_tb.Text = "";
            }
        }

        private void email_tb_Leave(object sender, EventArgs e)
        {
            if (email_tb.Text == "")
            {
                email_tb.StateCommon.Content.Color1 = Color.Gray;
                email_tb.Text = "Enter email...";
            }
        }

        // Age textbox enter and leave events
        private void age_tb_Enter(object sender, EventArgs e)
        {
            if (age_tb.Text == "Enter age...")
            {
                age_tb.StateCommon.Content.Color1 = Color.Black;
                age_tb.Text = "";
            }
        }

        private void age_tb_Leave(object sender, EventArgs e)
        {
            if (age_tb.Text == "")
            {
                age_tb.StateCommon.Content.Color1 = Color.Gray;
                age_tb.Text = "Enter age...";
            }
        }

        private void title_tb_Leave(object sender, EventArgs e)
        {
            if (title_tb.Text == "")
            {
                title_tb.StateCommon.Content.Color1 = Color.Gray;
                title_tb.Text = "Enter title...";
            }
        }

        private void title_tb_Enter(object sender, EventArgs e)
        {
            if (title_tb.Text == "Enter title...")
            {
                title_tb.StateCommon.Content.Color1 = Color.Black;
                title_tb.Text = "";
            }
        }

        private void posterUrl_tb_Leave(object sender, EventArgs e)
        {
            if (posterUrl_tb.Text == "")
            {
                posterUrl_tb.StateCommon.Content.Color1 = Color.Gray;
                posterUrl_tb.Text = "Enter poster URL...";
            }
        }

        private void posterUrl_tb_Enter(object sender, EventArgs e)
        {
            if (posterUrl_tb.Text == "Enter poster URL...")
            {
                posterUrl_tb.StateCommon.Content.Color1 = Color.Black;
                posterUrl_tb.Text = "";
            }
        }

        private void trailerUrl_tb_Leave(object sender, EventArgs e)
        {
            if (trailerUrl_tb.Text == "")
            {
                trailerUrl_tb.StateCommon.Content.Color1 = Color.Gray;
                trailerUrl_tb.Text = "Enter trailer URL...";
            }
        }

        private void trailerUrl_tb_Enter(object sender, EventArgs e)
        {
            if (trailerUrl_tb.Text == "Enter trailer URL...")
            {
                trailerUrl_tb.StateCommon.Content.Color1 = Color.Black;
                trailerUrl_tb.Text = "";
            }
        }

        private void description_tb_Leave(object sender, EventArgs e)
        {
            if (description_tb.Text == "")
            {
                description_tb.StateCommon.Content.Color1 = Color.Gray;
                description_tb.Text = "Enter description...";
            }
        }

        private void description_tb_Enter(object sender, EventArgs e)
        {
            if (description_tb.Text == "Enter description...")
            {
                description_tb.StateCommon.Content.Color1 = Color.Black;
                description_tb.Text = "";
            }
        }

        private void securityAnswer_tb_Leave(object sender, EventArgs e)
        {
            if (securityAnswer_tb.Text == "")
            {
                securityAnswer_tb.StateCommon.Content.Color1 = Color.Gray;
                securityAnswer_tb.Text = "Enter security answer...";
            }
        }

        private void securityAnswer_tb_Enter(object sender, EventArgs e)
        {
            if (securityAnswer_tb.Text == "Enter security answer...")
            {
                securityAnswer_tb.StateCommon.Content.Color1 = Color.Black;
                securityAnswer_tb.Text = "";
            }
        }

        private void movie_url_Enter(object sender, EventArgs e)
        {
            if (movieUrl_tb.Text == "Enter movie URL...")
            {
                movieUrl_tb.StateCommon.Content.Color1 = Color.Black;
                movieUrl_tb.Text = "";
            }
        }

        private void movie_url_Leave(object sender, EventArgs e)
        {
            if (movieUrl_tb.Text == "")
            {
                movieUrl_tb.StateCommon.Content.Color1 = Color.Gray;
                movieUrl_tb.Text = "Enter movie URL...";
            }
        }
    }
}
