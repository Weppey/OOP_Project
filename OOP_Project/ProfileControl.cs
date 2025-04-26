using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Drawing.Printing;
using System.Web.UI.HtmlControls;

namespace OOP_Project
{
    public partial class ProfileControl : UserControl
    {

        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
        string userType;
        int currentUserId;
        int userId;

        bool isLoading = false;
        int currentPage = 0;
        int pageSize = 20;


        public ProfileControl(string userTypeFromLogin, int userIdFromLogin)
        {
            InitializeComponent();
            userType = userTypeFromLogin; // Store the user's type (admin or regular)
            currentUserId = userIdFromLogin; // Store the current user's ID

            string[] preferences = { "Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Documentary", "Drama", "Family", "Fantasy", "History", "Horror", "Musical", "Mystery", "Romance", "Sci-Fi", "Sport", "Thriller", "War", "Western" };
            // Populate the CheckedListBox with movie genres
            foreach (var genre in preferences)
            {
                preferences_clb.Items.Add(genre);
            }
        }


        private void userProfile_cs_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            DisplayRecentlyViewedMovies();
            Reload();

            CurvePanel(profileDetails_panel, 30);
            profileDetails_panel.Resize += (s, args) => CurvePanel(profileDetails_panel, 20);

            RoundPictureBox(avatar_pb);

        }

        public void Reload()
        {
            connection = new MySqlConnection(connectionString);
            DisplayRecentlyViewedMovies();
            LoadProfileData();

            string[] preferences = { "Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Documentary", "Drama", "Family", "Fantasy", "History", "Horror", "Musical", "Mystery", "Romance", "Sci-Fi", "Sport", "Thriller", "War", "Western" };
            // Populate the CheckedListBox with movie genres
            foreach (var genre in preferences)
            {
                preferences_clb.Items.Add(genre);
            }

        }

        private void CurvePanel(System.Windows.Forms.Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            // Add arcs to the path to define the four rounded corners
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Top-left corner
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90); // Top-right corner
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90); // Bottom-right corner
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90); // Bottom-left corner
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void RoundPictureBox(PictureBox pb)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pb.Width, pb.Height); // Make it a circle
            pb.Region = new Region(path);
        }

        public void LoadProfileData()
        {
            string userId = currentUserId.ToString(); // Get the logged-in user's ID

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT username, email, preferences, gender, age, avatar 
                             FROM Users 
                             WHERE user_id = @userId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate basic user details
                            username_tb.Text = reader["username"].ToString();
                            email_tb.Text = reader["email"].ToString();
                            gender_tb.Text = reader["gender"].ToString();
                            age_tb.Text = reader["age"].ToString();

                            // Retrieve and split preferences into an array (handle null/empty values)
                            string preferences = reader["preferences"].ToString();
                            if (!string.IsNullOrEmpty(preferences))
                            {
                                // Split the preferences (assuming they're stored as a comma-separated string)
                                string[] userPreferences = preferences.Split(',');

                                // Loop through the user's preferences and check the corresponding items
                                foreach (string preference in userPreferences)
                                {
                                    string trimmedPreference = preference.Trim();
                                    int index = preferences_clb.Items.IndexOf(trimmedPreference);
                                    if (index >= 0)
                                    {
                                        preferences_clb.SetItemChecked(index, true); // Check the item if it's found
                                    }
                                }
                            }

                            // Load avatar (if exists)
                            if (reader["avatar"] != DBNull.Value)
                            {
                                byte[] avatarData = (byte[])reader["avatar"];
                                using (MemoryStream ms = new MemoryStream(avatarData))
                                {
                                    avatar_pb.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                avatar_pb.Image = Properties.Resources.avatar_default; // No avatar
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data found for the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading profile: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public string GetLoggedInUserId()
        {
            // Implement logic to fetch the actual logged-in user's ID from session, cookie, or context
            return currentUserId.ToString();  // Or use actual user session management
        }


        // Make onClicked a class-level variable
        private int onClicked = 0;

        private void editProfile_btn_Click(object sender, EventArgs e)
        {
            if (onClicked == 0)
            {
                // Enable editing
                changeAvatar_btn.Visible = true;
                username_tb.ReadOnly = false;
                email_tb.ReadOnly = false;
                preferences_clb.Enabled = true;
                age_tb.ReadOnly = false;
                gender_tb.ReadOnly = false;
                birthdate_dtp.Enabled = true; 
                cancel_btn.Visible = true;
                save_btn.Visible = true;

                // Set onClicked to 1 when editing is enabled
                onClicked = 1;
                editProfile_btn.Values.Image = Properties.Resources.icons8_close_24; ; // Switch to edit icon
            }
            else
            {
                // Disable editing
                changeAvatar_btn.Visible = false;
                username_tb.ReadOnly = true;
                email_tb.ReadOnly = true;
                preferences_clb.Enabled = false;
                age_tb.ReadOnly = true;
                gender_tb.ReadOnly = true;
                birthdate_dtp.Enabled = false;
                cancel_btn.Visible = false;
                save_btn.Visible = false;

                // Reset onClicked back to 0
                onClicked = 0;
                editProfile_btn.Values.Image = Properties.Resources.icons8_edit_user_28; // Switch back to close icon
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            LoadProfileData(); // Reload profile data to discard unsaved changes
            MessageBox.Show("Changes discarded.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Disable editing state
            username_tb.ReadOnly = true;
            email_tb.ReadOnly = true;
            preferences_clb.Enabled = false;
            age_tb.ReadOnly = true;
            gender_tb.ReadOnly = true;
            birthdate_dtp.Enabled = true;
            cancel_btn.Enabled = false;
            save_btn.Enabled = false;
            onClicked = 0;

            // Restore edit button image
            editProfile_btn.Values.Image = Properties.Resources.icons8_close_24;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string userId = GetLoggedInUserId(); // Get logged-in user's ID
            string updatedUsername = username_tb.Text;
            string updatedEmail = email_tb.Text;
            string updatedPreferences = string.Join(",", preferences_clb.CheckedItems.Cast<string>());
            string updatedGender = gender_tb.Text;
            int updatedAge = int.TryParse(age_tb.Text, out int ageResult) ? ageResult : 0;
            byte[] avatarData = ImageToByteArray(avatar_pb.Image);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Users 
                            SET username = @username, 
                                email = @email, 
                                preferences = @preferences, 
                                gender = @gender, 
                                age = @age, 
                                avatar = @avatar 
                            WHERE user_id = @userId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", updatedUsername);
                    cmd.Parameters.AddWithValue("@email", updatedEmail);
                    cmd.Parameters.AddWithValue("@preferences", updatedPreferences);
                    cmd.Parameters.AddWithValue("@gender", updatedGender);
                    cmd.Parameters.AddWithValue("@age", updatedAge);
                    cmd.Parameters.AddWithValue("@avatar", avatarData);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Disable edit mode
                DisableEditMode();

                // Reload profile data
                LoadProfileData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to disable edit mode
        private void DisableEditMode()
        {
            changeAvatar_btn.Visible = false;
            username_tb.ReadOnly = true;
            email_tb.ReadOnly = true;
            preferences_clb.Enabled = false;
            age_tb.ReadOnly = true;
            gender_tb.ReadOnly = true;
            birthdate_dtp.Enabled = false;
            cancel_btn.Visible = false;
            save_btn.Visible = false;

            // Reset onClicked back to 0
            onClicked = 0;
            editProfile_btn.Values.Image = Properties.Resources.icons8_close_24; // Switch back to close icon
        }


        private byte[] ImageToByteArray(Image image)
        {
            if (image == null)
            {
                MessageBox.Show("No image to convert!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;  // Or you can return an empty byte array if needed
            }

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);  // Save the image into the MemoryStream in its raw format
                return ms.ToArray();  // Return the byte array of the image
            }
        }


  
        public void DisplayRecentlyViewedMovies()
        {
            home_form homeForm = new home_form(userType, userId);
            if (homeForm == null)
            {
                homeForm = new home_form(userType, userId);
            }

            List<movie> recentMovies = GetRecentlyViewedMovies(currentUserId);

            if (recentMovies == null || recentMovies.Count == 0)
            {
                if (recentlyViewMovie_flp.Controls.Count == 0)
                {
                    Label noRecentLabel = new Label
                    {
                        Text = "No recently viewed movies.",
                        AutoSize = true,
                        ForeColor = Color.Gray,
                        Font = new Font("Arial", 10, FontStyle.Italic)
                    };
                    recentlyViewMovie_flp.Controls.Add(noRecentLabel);
                }
                return;
            }

            foreach (var movie in recentMovies)
            {
                // Check if movie already exists
                Control existingPanel = null;
                foreach (Control ctrl in recentlyViewMovie_flp.Controls)
                {
                    if (ctrl.Tag is int id && id == movie.Id)
                    {
                        existingPanel = ctrl;
                        break;
                    }
                }

                if (existingPanel != null)
                {
                    recentlyViewMovie_flp.Controls.Remove(existingPanel);
                    existingPanel.Dispose(); // Optional: release resources if needed
                }

                // Create new movie panel
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

                moviePanel.Controls.Add(poster);

                moviePanel.Click += (s, e) =>
                {
                    homeForm.LogMovieView(currentUserId, movie.Id);
                    homeForm.LogMovieInteraction(currentUserId, movie.Id);
                    homeForm.ShowMovieDetails(movie);
                };

                foreach (Control ctrl in moviePanel.Controls)
                {
                    ctrl.Click += (s, e) =>
                    {
                        homeForm.LogMovieView(currentUserId, movie.Id);
                        homeForm.LogMovieInteraction(currentUserId, movie.Id);
                        homeForm.ShowMovieDetails(movie);
                    };
                }

                // Add to the very beginning
                recentlyViewMovie_flp.Controls.Add(moviePanel);
                recentlyViewMovie_flp.Controls.SetChildIndex(moviePanel, 0);
            }
        }


        public List<movie> GetRecentlyViewedMovies(int userId)
        {
            List<movie> movies = new List<movie>();

            string query = @"
        SELECT m.movie_id, m.title, m.description, m.genre, m.release_year, m.rating, m.image_url
        FROM Movies m
        INNER JOIN movie_interaction mi ON m.movie_id = mi.movie_id
        WHERE mi.user_id = @userId
        ORDER BY mi.created_at DESC
        LIMIT 10";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

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
                MessageBox.Show($"Error retrieving recently viewed movies: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return movies;
        }

        private void changeAvatar_btn_Click(object sender, EventArgs e)
        {
            // Create a dialog for avatar selection
            using (Form avatarSelectionForm = new Form())
            {
                avatarSelectionForm.Text = "Choose Avatar";
                avatarSelectionForm.Size = new Size(300, 200);

                // Define the avatars
                List<Image> avatarOptions = new List<Image>
        {
            Properties.Resources.avatar_default, // Replace with actual images or paths
            Properties.Resources.avatar_male,
            Properties.Resources.avatar_women,
            Properties.Resources.avatar_women2
        };

                // Create buttons for each avatar option
                int x = 20; // Initial X position for avatars
                foreach (var avatar in avatarOptions)
                {
                    Button avatarButton = new Button
                    {
                        Size = new Size(60, 60),
                        Location = new Point(x, 20),
                        BackgroundImage = avatar,
                        BackgroundImageLayout = ImageLayout.Stretch
                    };

                    avatarButton.Click += (s, args) =>
                    {
                        // Set the selected avatar as the profile picture
                        avatar_pb.Image = avatar;

                        // Close the avatar selection form
                        avatarSelectionForm.Close();
                    };
                    avatarSelectionForm.AutoSize = true;
                    avatarSelectionForm.StartPosition = FormStartPosition.CenterParent;
                    avatarSelectionForm.Controls.Add(avatarButton);
                    x += 80; // Add some space between avatar buttons
                }

                avatarSelectionForm.ShowDialog();
            }
        }

    }
}
