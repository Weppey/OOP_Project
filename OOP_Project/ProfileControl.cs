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
using System.Net.Http;
using System.Threading.Tasks;
using static OOP_Project.StayLoggedIn;
using ComponentFactory.Krypton.Toolkit;


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
                ApplyTheme();
        }

        public void ApplyTheme()
        {
            bool isDark = ThemeManager.IsDarkMode;

            // Background colors
            this.BackColor = isDark ? Color.FromArgb(26, 26, 26) : Color.White;
            recentlyViewMovie_panel.BackColor = isDark ? Color.Gray : Color.LightGray;
            profileDetails_panel.BackColor = isDark ? Color.FromArgb(30, 30, 30) : Color.Gray;
            recentlyViewMovie_flp.BackColor = Color.White; // consistent in both themes

            Color foreColor = isDark ? Color.White : Color.Black;

            // Regular labels
            username_lbl.ForeColor = foreColor;
            email_lbl.ForeColor = foreColor;
            birthdate_lbl.ForeColor = foreColor;
            age_lbl.ForeColor = foreColor;
            gender_lbl.ForeColor = foreColor;
            preferences_lbl.ForeColor = foreColor;

            KryptonButton[] buttons = new KryptonButton[]
            {
            editProfile_btn,
            changeAvatar_btn,
            cancel_btn,
            save_btn
            };

            Color textColor = isDark ? Color.White : Color.Black;
            Color lightBackColor = Color.Gainsboro;
       
        }



        private void userProfile_cs_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);

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
                    string query = @"SELECT username, email, preferences, gender, age, birthdate, avatar 
                             FROM Users 
                             WHERE user_id = @userId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Basic info
                            username_tb.Text = reader["username"].ToString();
                            email_tb.Text = reader["email"].ToString();
                            gender_tb.Text = reader["gender"].ToString();
                            age_tb.Text = reader["age"].ToString();

                            // Birthdate (check for null)
                            if (reader["birthdate"] != DBNull.Value)
                            {
                                DateTime birthdate = Convert.ToDateTime(reader["birthdate"]);
                                birthdate_dtp.Value = birthdate; // Assuming you're using a DateTimePicker named birthdate_dtp
                            }
                            else
                            {
                                birthdate_dtp.Value = DateTime.Today; // Default to today if missing
                            }

                            // Preferences
                            string preferences = reader["preferences"].ToString();
                            if (!string.IsNullOrEmpty(preferences))
                            {
                                string[] userPreferences = preferences.Split(',');

                                foreach (string preference in userPreferences)
                                {
                                    string trimmedPreference = preference.Trim();
                                    int index = preferences_clb.Items.IndexOf(trimmedPreference);
                                    if (index >= 0)
                                    {
                                        preferences_clb.SetItemChecked(index, true);
                                    }
                                }
                            }

                            // Avatar
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
                                avatar_pb.Image = Properties.Resources.avatar_default;
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
                email_tb.ReadOnly = true;
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
            birthdate_dtp.Visible = true;
            cancel_btn.Visible = false;
            save_btn.Visible = false;
            editProfile_btn.Visible = false;
            onClicked = 0;

            // Restore edit button image
            editProfile_btn.Values.Image = Properties.Resources.icons8_edit_user_28; // Switch back to close icon
            LoadProfileData();

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string userId = GetLoggedInUserId(); // Get logged-in user's ID
            string updatedUsername = username_tb.Text.Trim();
            string updatedEmail = email_tb.Text.Trim();
            string updatedPreferences = string.Join(",", preferences_clb.CheckedItems.Cast<string>());
            string updatedGender = gender_tb.Text;
            int updatedAge = int.TryParse(age_tb.Text, out int ageResult) ? ageResult : 0;
            byte[] avatarData = ImageToByteArray(avatar_pb.Image);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if username already exists and belongs to a different user
                    string checkUsernameQuery = "SELECT COUNT(*) FROM Users WHERE username = @username AND user_id != @userId";
                    MySqlCommand checkCmd = new MySqlCommand(checkUsernameQuery, conn);
                    checkCmd.Parameters.AddWithValue("@username", updatedUsername);
                    checkCmd.Parameters.AddWithValue("@userId", userId);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("The username is already taken. Please choose a different one.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadProfileData();
                        return;
                    }

                    // Proceed with update
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

                DisableEditMode();
                LoadProfileData();
                editProfile_btn.Values.Image = Properties.Resources.icons8_edit_user_28;
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

        public async void DisplayRecentlyViewedMovies()
        {
            home_form homeForm = this.FindForm() as home_form;

            if (homeForm == null)
            {
                // Optional: Handle error or fallback
                MessageBox.Show("Home form not found.");
                return;
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

                    if (recentlyViewMovie_flp.IsHandleCreated)
                    {
                        recentlyViewMovie_flp.Invoke((MethodInvoker)(() =>
                        {
                            recentlyViewMovie_flp.Controls.Add(noRecentLabel);
                        }));
                    }
                }
                return;
            }

            foreach (var movie in recentMovies)
            {
                // Remove duplicates
                Control existingPanel = recentlyViewMovie_flp.Controls
                    .Cast<Control>()
                    .FirstOrDefault(ctrl => ctrl.Tag is int id && id == movie.Id);

                if (existingPanel != null)
                {
                    if (recentlyViewMovie_flp.IsHandleCreated)
                    {
                        recentlyViewMovie_flp.Invoke((MethodInvoker)(() =>
                        {
                            recentlyViewMovie_flp.Controls.Remove(existingPanel);
                            existingPanel.Dispose();
                        }));
                    }
                }

                // Create panel and placeholder
                Panel moviePanel = new Panel
                {
                    Size = new Size(120, 160),
                    Margin = new Padding(5),
                    BackColor = Color.Gray,
                    Cursor = Cursors.Hand,
                    Tag = movie.Id
                };

                PictureBox poster = new PictureBox
                {
                    Size = new Size(120, 160),
                    Location = new Point(0, 0),
                    BackColor = Color.Black,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle,
                    Image = Properties.Resources.icons8_loading_50
                };

                moviePanel.Controls.Add(poster);

                EventHandler clickHandler = (s, e) =>
                {
                    homeForm.LogMovieInteraction(currentUserId, movie.Id);
                    homeForm.ShowMovieDetails(movie);
                };

                moviePanel.Click += clickHandler;
                foreach (Control ctrl in moviePanel.Controls)
                    ctrl.Click += clickHandler;

                if (recentlyViewMovie_flp.IsHandleCreated)
                {
                    recentlyViewMovie_flp.Invoke((MethodInvoker)(() =>
                    {
                        recentlyViewMovie_flp.Controls.Add(moviePanel);

                        // Keep max 20
                        if (recentlyViewMovie_flp.Controls.Count > 20)
                        {
                            Control first = recentlyViewMovie_flp.Controls[0];
                            recentlyViewMovie_flp.Controls.Remove(first);
                            first.Dispose();
                        }
                    }));
                }

                // Load poster asynchronously
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



        public List<movie> GetRecentlyViewedMovies(int userId)
        {
            List<movie> movies = new List<movie>();

            string query = @"
        SELECT m.movie_id, m.title, m.description, m.genre, m.release_year, m.rating, m.image_url
        FROM Movies m
        INNER JOIN movie_interaction mi ON m.movie_id = mi.movie_id
        WHERE mi.user_id = @userId
        ORDER BY mi.created_at DESC
        LIMIT 20";

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

        private bool isAvatarButtonToggled = false;
        private void changeAvatar_btn_Click(object sender, EventArgs e)
        {
            if (!isAvatarButtonToggled)
            {
                // Toggle ON - Dark background
                changeAvatar_btn.StateCommon.Back.Color1 = Color.FromArgb(30, 30, 30);
                changeAvatar_btn.StateCommon.Back.Color2 = Color.FromArgb(30, 30, 30);
                changeAvatar_btn.StateNormal.Back.Color1 = Color.FromArgb(30, 30, 30);
                changeAvatar_btn.StateNormal.Back.Color2 = Color.FromArgb(30, 30, 30);
                changeAvatar_btn.StateTracking.Back.Color1 = Color.FromArgb(30, 30, 30);
                changeAvatar_btn.StateTracking.Back.Color2 = Color.FromArgb(30, 30, 30);

                isAvatarButtonToggled = true;

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
                        avatarSelectionForm.ShowIcon = false;
                        avatarSelectionForm.ShowInTaskbar = false;
                        x += 80; // Add some space between avatar buttons
                    }

                    avatarSelectionForm.ShowDialog();
                }
            }
            else
            {
                // Toggle OFF - Transparent background
                Color transparent = Color.FromArgb(0, 0, 0, 0);

                changeAvatar_btn.StateCommon.Back.Color1 = transparent;
                changeAvatar_btn.StateCommon.Back.Color2 = transparent;
                changeAvatar_btn.StateNormal.Back.Color1 = transparent;
                changeAvatar_btn.StateNormal.Back.Color2 = transparent;
                changeAvatar_btn.StateTracking.Back.Color1 = transparent;
                changeAvatar_btn.StateTracking.Back.Color2 = transparent;

                isAvatarButtonToggled = false;
            }
        }

    }
}
