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
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class AdminControl : UserControl
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";

        private DataTable movieTable = new DataTable();
        private BindingSource movieBindingSource = new BindingSource();

        private DataTable usersTable = new DataTable();
        private BindingSource usersBindingSource = new BindingSource();

        private BindingSource userBindingSource = new BindingSource();
        private bool isInsertingNewUser = true;
        public AdminControl()
        {
            InitializeComponent();
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

        private void AdminMovieControl_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                LoadMovies();
                SetupSearchPlaceholder();
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

            SetupSearchPlaceholder();
            CurvePanel(Admin_panel, 30);
            Admin_panel.Resize += (s, aargs) => CurvePanel(Admin_panel, 20);
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

        private void SetupSearchPlaceholder()
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

        private void insert_btn_Click(object sender, EventArgs e)
        {
            insert_btn.Visible = true;
            title_tb.Text = "";
            posterUrl_tb.Text = "";
            poster_pb.Image = null;
            description_tb.Text = ""; // Clear the description textbox as well
            MovieClearCheckedItems();
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
            int movieId = Convert.ToInt32(movies_dgv.CurrentRow.Cells["movie_id"].Value);

            // Get the selected genres as a comma-separated string
            string selectedGenres = GetSelectedGenres();

            // Prepare the query to update the movie
            string query = "UPDATE movies SET title=@title, genre=@genre, release_year=@release, image_url=@url, description=@description WHERE movie_id=@id";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@title", title_tb.Text);
            cmd.Parameters.AddWithValue("@genre", selectedGenres); // Using the comma-separated genres
            cmd.Parameters.AddWithValue("@release", releaseYear_dtp.Value.Year); // Only the year
            cmd.Parameters.AddWithValue("@url", posterUrl_tb.Text);
            cmd.Parameters.AddWithValue("@description", description_tb.Text); // Add description
            cmd.Parameters.AddWithValue("@id", movieId);

            // Execute the update query
            cmd.ExecuteNonQuery();
            MovieClearCheckedItems();
            LoadMovies(); // Refresh the movie list
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

        private void submit_btn_Click(object sender, EventArgs e)
        {
            string selectedGenres = GetSelectedGenres();

            // Extract just the year from the release year DateTimePicker
            int releaseYear = releaseYear_dtp.Value.Year;

            // Insert query with description
            string query = "INSERT INTO movies (title, genre, release_year, image_url, description) VALUES (@title, @genre, @release, @url, @description)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@title", title_tb.Text);
            cmd.Parameters.AddWithValue("@genre", selectedGenres); // Save genres as a comma-separated string
            cmd.Parameters.AddWithValue("@release", releaseYear); // Pass the release year (as integer)
            cmd.Parameters.AddWithValue("@url", posterUrl_tb.Text);
            cmd.Parameters.AddWithValue("@description", description_tb.Text); // Save the description
            cmd.ExecuteNonQuery();
            MovieClearCheckedItems();
            LoadMovies(); // Refresh the movie list
        }

        private void editMovie_btn_Click(object sender, EventArgs e)
        {
            if (movieEditor_panel.Visible == false)
            {
                movieEditor_panel.Visible = true;
                userEditor_panel.Visible = false;
                LoadMovies();
            }
            else
            {
                movieEditor_panel.Visible = false;
            }
        }

        //user editor 

        private void LoadUsers()
        {
            string query = "SELECT * FROM users";
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

                // ✅ Load user_type
                if (usertype_cmb.Items.Contains(reader["user_type"].ToString()))
                {
                    usertype_cmb.SelectedItem = reader["user_type"].ToString();
                }
                else
                {
                    usertype_cmb.SelectedIndex = -1; // fallback if value is unknown
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

        private void verify_btn_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(userID_tb.Text);
            string query = "UPDATE users SET email_verified=@emailVerified WHERE user_id=@userId";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@emailVerified", emailVerified_cb.Checked);
            cmd.Parameters.AddWithValue("@userId", userId);

            cmd.ExecuteNonQuery();
            MessageBox.Show("User email verify update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteUser_btn_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(userID_tb.Text);
            string query = "DELETE FROM users WHERE user_id=@userId";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@userId", userId);

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
                int userId = Convert.ToInt32(row.Cells["user_id"].Value); // Assuming "user_id" is a column in your DataGridView
                userID_tb.Text = userId.ToString(); // Set userId in the hidden TextBox

                // Load user details into the user editor panel
                LoadUserDetails(userId);

                // Set flag to false since we are editing an existing user
                isInsertingNewUser = false;
                insertUser_btn.Text = "Save Changes"; // Change button text to "Save Changes"
            }
        }


        private void editUser_btn_Click(object sender, EventArgs e)
        {
            if (userEditor_panel.Visible == false)
            {
                userEditor_panel.Visible = true;
                movieEditor_panel.Visible = false;
                LoadUsers();
            }
            else
            {
                userEditor_panel.Visible = false;
            }
        }



        private void userSearchBox_tb_Click(object sender, EventArgs e)
        {
            userBindingSource.Clear(); // Clears the data source
            users_dgv.Refresh(); // Refresh the DataGridView to update the UI
            string searchQuery = userSearchBox_tb.Text.ToLower(); // Get the search text

            string query = "SELECT * FROM users WHERE username LIKE @searchQuery OR email LIKE @searchQuery";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");

            MySqlDataReader reader = cmd.ExecuteReader();

            // Clear the DataGridView rows before adding new data
            if (users_dgv.Rows.Count > 0)
            {
                users_dgv.Rows.Clear(); // Clear the existing rows in DataGridView
            }

            // Load new data into the DataGridView
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

            // Optionally, you can assign the data source to the BindingSource
            userBindingSource.DataSource = users_dgv;
        }


        private void userSearchBox_tb_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = userSearchBox_tb.Text.ToLower(); // Get the search text

            string query = "SELECT * FROM users WHERE username LIKE @searchQuery OR email LIKE @searchQuery";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");

            MySqlDataReader reader = cmd.ExecuteReader();

            // Clear the BindingSource (if used) or DataGridView rows
            userBindingSource.Clear(); // Clear BindingSource if you're using it

            while (reader.Read())
            {
                int userId = Convert.ToInt32(reader["user_id"]);
                string username = reader["username"].ToString();
                string email = reader["email"].ToString();
                string gender = reader["gender"].ToString();

                // Add the user data to the DataTable
                users_dgv.Rows.Add(userId, username, email, gender);
            }

            // Close the reader and bind the DataTable to the BindingSource
            reader.Close();
            userBindingSource.DataSource = users_dgv; // Bind the DataTable to BindingSource
        }

        private void insertUser_btn_Click(object sender, EventArgs e)
        {
            // Check if any required fields are null or empty
            if (string.IsNullOrWhiteSpace(username_tb.Text) || string.IsNullOrWhiteSpace(email_tb.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd.Parameters.AddWithValue("@userType", usertype_cmb.SelectedItem?.ToString() ?? "user"); // Default to "user" if not selected

                cmd.ExecuteNonQuery();
                MessageBox.Show("New user added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetUserForm();
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add user.\n\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UserClearCheckedItems()
        {
            for (int i = 0; i < genre_clb.Items.Count; i++)
            {
                userGenre_clb.SetItemChecked(i, false);
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
                MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadUsers();
                ResetUserForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update user.\n\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
