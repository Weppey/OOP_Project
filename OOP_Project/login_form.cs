using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using System.Web.SessionState;
using System.Drawing.Drawing2D;
using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using Microsoft.Web.WebView2.Core;
using CaptchaGen;
using System.Linq;
using System.IO;
using System.Threading.Tasks;


namespace OOP_Project
{
    public partial class login_form : KryptonForm
    {
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
        string currentCaptchaCode;
        public login_form()
        {
            InitializeComponent();
        }
        private int failedAttempts = 0; // To track failed attempts
        private int cooldownTime = 30;  // Cooldown time in seconds
        private async void login_btn_Click(object sender, EventArgs e)
        {
            // Check if the entered CAPTCHA matches the generated one
            if (captcha_tb.Text.Trim().ToUpper() != currentCaptchaCode.ToUpper())
            {
                // Increment failed attempts
                failedAttempts++;

                // Provide visual feedback by changing the border color to red
                captcha_tb.BackColor = Color.Pink;
                captcha_tb.Focus(); // Focus back on the CAPTCHA textbox for quicker retry

                // Show MessageBox with a custom message
                MessageBox.Show("CAPTCHA is incorrect. Please try again.", "CAPTCHA Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Clear the CAPTCHA textbox and regenerate a new CAPTCHA
                captcha_tb.Clear();
                GenerateCaptcha();

                // Disable the login button if there are more than 3 failed attempts
                if (failedAttempts >= 3)
                {
                    login_btn.Enabled = false;

                    // Show cooldown label
                    attempt_lbl.Visible = true;
                    attempt_lbl.Text = $"Please wait for {cooldownTime} seconds.";

                    // Start cooldown timer
                    for (int i = cooldownTime; i > 0; i--)
                    {
                        attempt_lbl.Text = $"Please wait for {i} seconds.";
                        await Task.Delay(1000); // Wait for 1 second
                    }

                    // Re-enable the login button and hide the cooldown label
                    login_btn.Enabled = true;
                    attempt_lbl.Visible = false;

                    // Show MessageBox for cooldown completion
                    MessageBox.Show("You can now try logging in again.", "Cooldown Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return;
            }

            // Reset failed attempts counter after successful CAPTCHA entry
            failedAttempts = 0;

            // Continue with login logic (username/password check, etc.)
            MessageBox.Show("CAPTCHA verified!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Trim any unnecessary whitespace from the input fields
            string username = userName_tb.Text.Trim();
            string password = password_tb.Text.Trim();

            // Check if both username and password are provided
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();  // Open the connection to the database

                    // SQL query to fetch user details
                    string query = "SELECT user_id, password, user_type FROM users WHERE username = @username LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@username", username);

                        // Execute the query and read the result
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())  // If a matching record is found
                            {
                                string storedHash = reader["password"].ToString(); // Get stored password hash
                                string userType = reader["user_type"].ToString();  // Get the user type (admin, regular, etc.)
                                int userId = Convert.ToInt32(reader["user_id"]);  // Get the user ID

                                // Verify the password using BCrypt
                                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                                {
                                    // Save the session information, such as user type and ID
                                    StayLoggedIn.SaveUserSession(userType, userId);

                                    // Provide feedback to the user
                                    MessageBox.Show($"Welcome back, {username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Hide the login form and show the home form
                                    this.Hide();
                                    home_form homeForm = new home_form(userType, userId);
                                    homeForm.ShowDialog(); // Display the home form modally
                                    this.Close();  // Close the login form after successful login
                                }
                                else
                                {
                                    // Handle incorrect password
                                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                // Handle case where no user is found with the entered username
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Catch and display any errors that occur during the login process
                MessageBox.Show("An error occurred while attempting to log in:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void captcha_tb_Enter(object sender, EventArgs e)
        {
            if (captcha_tb.Text == "Enter code...")
            {
                captcha_tb.Text = "";
                captcha_tb.ForeColor = Color.Black;
            }

        }

        private void captcha_tb_Leave(object sender, EventArgs e)
        {
            if (captcha_tb.Text == "")
            {
                captcha_tb.Text = "Enter code...";
                captcha_tb.ForeColor = Color.Gray;
            }
        }

        private void refreshCaptcha_btn_Click(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }
        private void GenerateCaptcha()
        {
            currentCaptchaCode = GenerateRandomCode(5); // e.g., 5-character CAPTCHA

            // Improved image dimensions and font settings
            var captchaImageStream = ImageFactory.GenerateImage(currentCaptchaCode, 100, 250, 50);

            // Convert MemoryStream to Image
            using (var memoryStream = new MemoryStream())
            {
                captchaImageStream.CopyTo(memoryStream);
                var captchaImage = Image.FromStream(memoryStream);
                captcha_pb.Image = captchaImage;
            }
        }
        private string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789"; // exclude similar-looking characters
            Random rand = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[rand.Next(s.Length)]).ToArray());
        }


        private async void login_form_Load(object sender, EventArgs e)
        {
            GenerateCaptcha();
            this.AcceptButton = login_btn;

            // Check if session exists
            var userSession = StayLoggedIn.LoadUserSession();
            if (userSession != null)
            {
                // The session already exists, proceed directly to home_form
                this.Hide();

                // Destructure the session tuple into userType and userId
                var (userType, userId) = userSession.Value;

                home_form homeForm = new home_form(userType, userId);
                homeForm.ShowDialog();
                this.Close();
            }
        }
        private void WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            string message = e.TryGetWebMessageAsString();

           if (message == "captcha_success")
            {
                MessageBox.Show("CAPTCHA passed!");
                // Proceed to the next logic like enabling login or user action
            }
        }

        private void signUp_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup_form SignUp_Form = new signup_form();
            SignUp_Form.ShowDialog();
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

        private void minimize_pb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void showPass_chkb_CheckedChanged(object sender, EventArgs e)
        {
            password_tb.PasswordChar = showPass_chkb.Checked ? '\0' : '*';
        }

        private void minimize_pb_MouseEnter(object sender, EventArgs e)
        {
            minimize_pb.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void minimize_pb_MouseLeave(object sender, EventArgs e)
        {
            minimize_pb.BackColor = Color.Transparent;
        }

        private void close_pb_MouseEnter(object sender, EventArgs e)
        {
            close_pb.BackColor = Color.FromArgb(226, 0, 39);
        }

        private void close_pb_MouseLeave(object sender, EventArgs e)
        {
            close_pb.BackColor = Color.Transparent;
        }

        private void forgotPassword_llbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            account_recovery_form recoveryForm = new account_recovery_form();
            recoveryForm.ShowDialog();

        }

        private void userName_tb_Enter(object sender, EventArgs e)
        {
            if (userName_tb.Text == "Username")
            {
                userName_tb.Text = "";
                userName_tb.ForeColor = Color.Black;
            }
        }

        private void userName_tb_Leave(object sender, EventArgs e)
        {
            if (userName_tb.Text == "")
            {
                userName_tb.Text = "Username";
                userName_tb.ForeColor = Color.Gray;
            }
        }

        private void password_tb_Leave(object sender, EventArgs e)
        {
            if (password_tb.Text == "")
            {
                password_tb.PasswordChar = '\0';
                password_tb.Text = "Password";
                password_tb.ForeColor = Color.Gray;
            }
        }

        private void password_tb_Enter(object sender, EventArgs e)
        {
            if (password_tb.Text == "Password")
            {
                password_tb.PasswordChar = '*';
                password_tb.Text = "";
                password_tb.ForeColor = Color.Black;
            }
        }


    }
}
