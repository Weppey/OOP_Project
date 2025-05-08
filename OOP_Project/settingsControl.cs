using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WinFormsToolTip = System.Windows.Forms.ToolTip;

namespace OOP_Project
{
    public partial class settingsControl : UserControl
    {
        WinFormsToolTip tooltip = new WinFormsToolTip();
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=remmmdb;Uid=root;Pwd=;";
        private bool _originalThemePreference;
        // Fields at the top of your settingsControl class:
        private bool _themeSaved = false;
    

        // In your constructor, after userId is set:

        private int userId;
        private string userType;

        public settingsControl(string userType, int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.userType = userType;

            connection = new MySqlConnection(connectionString);

            tooltip.IsBalloon = false;
            tooltip.BackColor = Color.LightYellow;
            tooltip.ForeColor = Color.Black;
            tooltip.UseFading = true;
            tooltip.UseAnimation = true;
            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 100;
            tooltip.ReshowDelay = 100;
            tooltip.ShowAlways = true;

            _originalThemePreference = UserThemeSettings.LoadTheme(userId) ?? false;
            _themeSaved = false;

            if (_originalThemePreference)
                ThemeManager.ApplyDarkMode();
            else
                ThemeManager.ApplyLightMode();

            ApplyTheme();
            ApplyThemeToOpenForms();

            this.VisibleChanged += settingsControl_VisibleChanged; 

            // Curve panels...
        CurvePanel(appinfo_panel, 30);
            appinfo_panel.Resize += (s, aargs) => CurvePanel(appinfo_panel, 20);
            CurvePanel(privacy_panel, 30);
            privacy_panel.Resize += (s, aargs) => CurvePanel(privacy_panel, 20);
            CurvePanel(security_panel, 30);
            security_panel.Resize += (s, aargs) => CurvePanel(security_panel, 20);
            CurvePanel(theme_panel, 30);
            theme_panel.Resize += (s, aargs) => CurvePanel(theme_panel, 20);

        }

        public void ApplyTheme()
        {
            Color labelForeColor = ThemeManager.IsDarkMode ? Color.White : Color.Black;

            theme_lbl.ForeColor = labelForeColor;
            securtySettings_lbl.ForeColor = labelForeColor;
            privacy_lbl.ForeColor = labelForeColor;

            theme_lbl.BackColor = Color.Transparent;
            securtySettings_lbl.BackColor = Color.Transparent;
            privacy_lbl.BackColor = Color.Transparent;
            settings_panel.BackColor = ThemeManager.IsDarkMode ? Color.Transparent : Color.Gainsboro;
        }

        private void ApplyThemeToOpenForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is home_form homeForm)
                {
                    homeForm.ApplyTheme();
                }
                ApplyThemeToSettingsControlRecursive(form.Controls);
            }
        }

        private void ApplyThemeToSettingsControlRecursive(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is settingsControl settingsControl && control != this)
                {
                    settingsControl.ApplyTheme();
                }
                else if (control is AdminControl adminCtrl)
                {
                    adminCtrl.ApplyTheme();
                }

                if (control.HasChildren)
                {
                    ApplyThemeToSettingsControlRecursive(control.Controls);
                }
            }
        }

        private void CurvePanel(Panel panel, int radius)
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
            DialogResult result = MessageBox.Show("Are you sure you want to clear your recently viewed movies?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM movie_interaction WHERE user_id = @userId";
                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", userId);
                            int rows = cmd.ExecuteNonQuery();
                            MessageBox.Show(rows > 0
                                ? "Recently viewed movies cleared."
                                : "No recently viewed movies to clear.",
                                "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
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
            DialogResult result = MessageBox.Show("Are you sure you want to clear your recently search movies?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM recent_searches WHERE user_id = @userId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
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
            DialogResult result = MessageBox.Show(
                "This action will permanently delete your account and cannot be undone.\n\nAre you sure you want to continue?",
                "Confirm Account Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM users WHERE user_id = @userId";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", userId);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Your account has been successfully deleted.", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                StayLoggedIn.ClearSession();
                                this.Hide();
                                login_form login = new login_form();
                                login.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("User not found. The account may have already been deleted.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred while deleting the account:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Your account was not deleted.", "Operation Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void darkmode_btn_Click(object sender, EventArgs e)
        {
            ThemeManager.ApplyDarkMode();  // Preview only
            ApplyTheme();
            ApplyThemeToOpenForms();
        }

        private void lightmode_btn_Click(object sender, EventArgs e)
        {
            ThemeManager.ApplyLightMode();  // Preview only
            ApplyTheme();
            ApplyThemeToOpenForms();
        }




private void apply_btn_Click(object sender, EventArgs e)
        {
            int? userId = StayLoggedIn.GetCurrentUserId();
            if (userId == null) return;

            UserThemeSettings.SaveTheme(userId.Value, ThemeManager.IsDarkMode);
            _themeSaved = true;

            MessageBox.Show("Theme preference saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // RevertTheme method
        private void RevertTheme()
        {
            if (_originalThemePreference)
                ThemeManager.ApplyDarkMode();
            else
                ThemeManager.ApplyLightMode();

            ApplyTheme();              // Re-apply this control's theme
            ApplyThemeToOpenForms();   // Re-apply across the app
        }

        // Detect when user navigates away from settingsControl
        private void settingsControl_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible && !_themeSaved)
            {
                RevertTheme();
            }
        }

    }
}
