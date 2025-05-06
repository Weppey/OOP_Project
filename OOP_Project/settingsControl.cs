using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Security.Policy;
using System.Threading.Tasks;
using WinFormsToolTip = System.Windows.Forms.ToolTip;
using Microsoft.VisualBasic.ApplicationServices;

namespace OOP_Project
{

    public partial class settingsControl : UserControl
    {

        WinFormsToolTip tooltip = new WinFormsToolTip();
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";

        private int userId;
        private string userType;
        public settingsControl(string userType, int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.userType = userType;

            connection = new MySqlConnection(connectionString);

            tooltip.IsBalloon = false;                        // Makes it balloon-shaped
            tooltip.BackColor = Color.LightYellow;           // Tooltip background color (only works in custom-drawn tips)
            tooltip.ForeColor = Color.Black;                 // Text color
            tooltip.UseFading = true;                        // Smooth fade-in/out
            tooltip.UseAnimation = true;                     // Animate appearance

            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 100;
            tooltip.ReshowDelay = 100;
            tooltip.ShowAlways = true;
            ApplyTheme();


        }
        public void ApplyTheme()
        {
            // Get the correct color for text depending on the theme
            Color labelForeColor = ThemeManager.IsDarkMode ? Color.White : Color.Black;

            // Update the label colors (foreground/text color)
            theme_lbl.ForeColor = labelForeColor;
            securtySettings_lbl.ForeColor = labelForeColor;
            privacy_lbl.ForeColor = labelForeColor;
            system_lbl.ForeColor = labelForeColor;

            // Ensure labels have transparent background
            theme_lbl.BackColor = Color.Transparent;
            securtySettings_lbl.BackColor = Color.Transparent;
            privacy_lbl.BackColor = Color.Transparent;
            system_lbl.BackColor = Color.Transparent;
            settings_panel.BackColor = ThemeManager.IsDarkMode ? Color.Transparent : Color.LightGray;
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

        private void language_cmb_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gender_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void changePassword_btn_Click(object sender, EventArgs e)
        {
            account_recovery_form recovery = new account_recovery_form();
            recovery.ChangePassword();
            recovery.ShowDialog();

        }

        private void changeEmail_btn_Click(object sender, EventArgs e)
        {
            account_recovery_form recovery = new account_recovery_form();
            recovery.ChangeEmail();
            recovery.ShowDialog();
        }

        private void clearHistory_btn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to clear your recently viewed movies?",
    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;"))
                    {
                        conn.Open();

                        string deleteQuery = "DELETE FROM movie_interaction WHERE user_id = @userId";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", userId); // Make sure this is passed to settingsControl

                            int rows = cmd.ExecuteNonQuery();

                            MessageBox.Show(rows > 0
                                ? "Recently viewed movies cleared."
                                : "No recently viewed movies to clear.",
                                "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    // Optional: refresh UI if neede
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to clear recently viewed movies.\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void clearRecentSearch_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear your recently search movies?",
            "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Define the SQL command to delete recent searches for the logged-in user
                    string query = "DELETE FROM recent_searches WHERE user_id = @userId";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId); // Or use currentUserId if applicable

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Search history cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            home_form home = new home_form(userType, userId);
                            home.Reload();
                        }
                        else
                        {
                            MessageBox.Show("No search history found to clear.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private void deleteAccount_btn_Click(object sender, EventArgs e)
        {
            int currentUserId = userId; // Make sure this is assigned correctly from your session or logged-in user

            DialogResult result = MessageBox.Show(
                "This action will permanently delete your account and cannot be undone.\n\nAre you sure you want to continue?",
                "Confirm Account Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM users WHERE user_id = @userId";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", currentUserId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show(
                                    "Your account has been successfully deleted.",
                                    "Account Deleted",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                StayLoggedIn.ClearSession();
                                login_form login = new login_form();
                                login.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "User not found. The account may have already been deleted.",
                                    "Deletion Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "An unexpected error occurred while deleting the account:\n\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Your account was not deleted.",
                    "Operation Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void lightmode_btn_Click(object sender, EventArgs e)
        {
            ThemeManager.ApplyLightMode();
            ApplyTheme();
        }

        private void darkmode_btn_Click(object sender, EventArgs e)
        {
            ThemeManager.ApplyDarkMode();
            ApplyTheme();
        }

private void apply_btn_Click(object sender, EventArgs e)
{
    int? userId = StayLoggedIn.GetCurrentUserId();
    if (userId == null) return;

    UserThemeSettings.SaveTheme(userId.Value, ThemeManager.IsDarkMode);
    MessageBox.Show("Theme preference saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
}

    }
}
