using MySql.Data.MySqlClient;
using System;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Net;

namespace OOP_Project
{
    public partial class account_recovery_form : KryptonForm
    {
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
        private string recoveryCode;
        private int cooldownTime = 300; // 5 minutes cooldown in seconds

        private int attemptCount = 0;
        private DateTime? lockoutUntil = null;

        private int userId;
        private string userType;


        public account_recovery_form()
        {
            InitializeComponent();
        }

        private void account_recovery_form_Load(object sender, EventArgs e)
        {

            string[] securityQuestions = { "What is your mother's maiden name?", "What was your first pet's name?", "What was your first car?", "What elementary school did you attend?", "What is your favorite food?" };
            securityq_cmb.Items.AddRange(securityQuestions);

            string[] securityEmailQuestions = { "What is your mother's maiden name?", "What was your first pet's name?", "What was your first car?", "What elementary school did you attend?", "What is your favorite food?" };
            sqEmailChange_cmb.Items.AddRange(securityEmailQuestions);

            CurvePanel(background_panel, 30);
            background_panel.Resize += (s, args) => CurvePanel(background_panel, 20);
            CurvePanel(securityQuestion_panel, 30);
            securityQuestion_panel.Resize += (s, args) => CurvePanel(securityQuestion_panel, 20);
            CurvePanel(changeEmail_panel, 30);
            changeEmail_panel.Resize += (s, args) => CurvePanel(changeEmail_panel, 20);
        }

        private bool IsValidPassword(string password)
        {
            // Password should contain at least one uppercase letter and one special character
            string pattern = @"^(?=.*[A-Z])(?=.*[\W_]).+$";
            return Regex.IsMatch(password, pattern);
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



        private async void StartCooldown()
        {
            // Disable the resend link label and start the countdown
            while (cooldownTime > 0)
            {
                send_llbl.Text = $"Resend Code ({cooldownTime}s)";
                await Task.Delay(1000); // Wait 1 second (non-blocking)
                cooldownTime--;
            }

            // Reset the LinkLabel text and re-enable it after cooldown
            send_llbl.Text = "Resend Recovery Code";
            send_llbl.Enabled = true;
            cooldownTime = 300; // Reset cooldown time to 5 minutes
        }



        private string GenerateRecoveryCode()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Range(0, 6).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }

        private void SendRecoveryEmail(string email, string recoveryCode)
        {
            try
            {
                var smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new System.Net.NetworkCredential("remmm.help@gmail.com", "nwvo tqpy onmt aohm"),
                    EnableSsl = true,
                };

                var mailMessage = new System.Net.Mail.MailMessage
                {
                    From = new System.Net.Mail.MailAddress("remmm.help@gmail.com"),
                    Subject = "🔐 Remmm Password Recovery Code",
                    IsBodyHtml = true,
                    BodyEncoding = Encoding.UTF8,
                    Body = $@"
<html>
    <body style='background-color: #141414; font-family: Helvetica, Arial, sans-serif; color: #ffffff; padding: 20px;'>
        <div style='max-width: 600px; margin: auto; background-color: #1c1c1c; padding: 30px; border-radius: 8px; box-shadow: 0 0 10px rgba(0,0,0,0.5);'>
            <h1 style='color: #e50914; text-align: center;'>Remmm</h1>
            <h2 style='color: #ffffff; text-align: center;'>Password Recovery</h2>
            <p style='color: #ffffff;text-align: center;'>We've received a request to reset your password. Use the code below to continue:</p>
            <div style='margin: 30px auto; width: fit-content; padding: 15px 30px; background-color: #e50914; color: #ffffff; font-size: 28px; font-weight: bold; border-radius: 6px; text-align: center;'>
                {recoveryCode}
            </div>
            <p style='color: #ffffff;text-align: center;'>Didn't request this? Just ignore this message.</p>
            <hr style='border-color: #333333; margin: 30px 0;'>
            <p style='font-size: 12px; text-align: center; color: #aaaaaa;'>
                Need help? Contact us at 
                <a href='mailto:remmm.help@gmail.com' style='color: #e50914; text-decoration: none;'>remmm.help@gmail.com</a>
            </p>
            <p style='text-align: center; font-size: 12px; color: #555;'>© 2025 Remmm. All rights reserved.</p>
        </div>
    </body>
</html>"
                };

                mailMessage.To.Add(email);
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send recovery email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void close_pb_Click(object sender, EventArgs e)
        {
            login_form LoginForm = new login_form();
            LoginForm.Show();
            this.Close();
        }

        private void minimize_pb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void recoveryC_tb_TextChanged(object sender, EventArgs e)
        {
            if (recoveryC_tb.Text.Length == recoveryC_tb.MaxLength)
            {
                MessageBox.Show("You've reached the maximum code length.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ChangePassword()
        {
            Panel_Recovery.Visible = true;
            securityQuestion_panel.Visible = false;
            changeEmail_panel.Visible = false;

            background_panel.BackgroundImage = Properties.Resources._31;
        }

        public void ChangeEmail()
        {
            changeEmail_panel.Visible = true;
            securityQuestion_panel.Visible = false;
            Panel_Recovery.Visible = false;

            background_panel.BackgroundImage = Properties.Resources.a_minecraft_movie_3840x2160_21613;
        }
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            string enteredCode = recoveryC_tb.Text;
            string newPassword = newpassword_tb.Text;
            string confirmPassword = confirmpassword_tb.Text;
            string Email = email_tb.Text;


            if (string.IsNullOrWhiteSpace(enteredCode) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please complete all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidPassword(newPassword))
            {
                MessageBox.Show("Password must contain at least one uppercase letter and one special character!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit early, no data will reach the database
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter them.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (enteredCode == recoveryCode)
            {
                // Update password in the database
                try
                {
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string updateQuery = "UPDATE users SET password = @Password WHERE email = @Email";
                        MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@Email", email_tb.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Password has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (Application.OpenForms["home_form"] != null)
                        {
                            this.Close();
                            StayLoggedIn.ClearSession();
                            Application.Restart();
                            SendSuccessfulRecoveryEmail(Email);
                        }
                        else
                        {
                            this.Close();
                            login_form loginForm = new login_form();
                            loginForm.ShowDialog();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid recovery code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void min_pb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cls_pb_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["home_form"] != null)
            {
                this.Close();
            }
            else
            {
                this.Close();
                login_form LoginForm = new login_form();
                LoginForm.Show();
            }
        }

        private void send_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = email_tb.Text;


            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Optional: Check if email format is valid (basic check)
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT username FROM users WHERE email = @Email";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", email);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Generate and send the recovery code
                        recoveryCode = GenerateRecoveryCode();
                        SendRecoveryEmail(email, recoveryCode);
                        MessageBox.Show("A recovery code has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Start cooldown
                        send_llbl.Enabled = false; // Disable the LinkLabel
                        StartCooldown();
                    }
                    else
                    {
                        MessageBox.Show("Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tryAnotherWay_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (securityQuestion_panel.Visible == false)
            {
                securityQuestion_panel.Visible = true;
            }
            else
            {
                securityQuestion_panel.Visible = false;
            }
        }
        private void sqConfirm_btn_Click(object sender, EventArgs e)
        {

            string email = sqEmail_tb.Text.Trim();
            string selectedQuestion = securityq_cmb.Text;
            string answer = securityQuestionAnswer_tb.Text.Trim();
            string newPassword = sqNewPassword_tb.Text;
            string confirmPassword = sqConfirmPassword_tb.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(selectedQuestion) ||
                string.IsNullOrWhiteSpace(answer) || string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please complete all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IsStrongPassword(newPassword);

            if (!IsValidPassword(newPassword))
            {
                MessageBox.Show("Password must contain at least one uppercase letter and one special character!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter them.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT security_answer FROM users WHERE email = @Email AND security_question = @Question";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Question", selectedQuestion);

                    object result = cmd.ExecuteScalar();

                    if (lockoutUntil != null && DateTime.Now < lockoutUntil)
                    {
                        MessageBox.Show($"Too many failed attempts. Try again at {lockoutUntil.Value}.", "Locked Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tooManyatemp_lbl.Visible = true;
                        return;
                    }
                    else
                    {
                        tooManyatemp_lbl.Visible = false;
                    }

                    if (result != null)
                    {
                        string storedHashedAnswer = result.ToString();

                        if (BCrypt.Net.BCrypt.Verify(answer, storedHashedAnswer))
                        {
                            // Reset attempt counter
                            attemptCount = 0;

                            // Update password
                            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
                            string updateQuery = "UPDATE users SET password = @Password WHERE email = @Email";
                            MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                            updateCmd.Parameters.AddWithValue("@Password", hashedPassword);
                            updateCmd.Parameters.AddWithValue("@Email", email);
                            updateCmd.ExecuteNonQuery();

                            MessageBox.Show("Password has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (Application.OpenForms["home_form"] != null)
                            {
                                this.Close();
                                StayLoggedIn.ClearSession();
                                Application.Restart();
                                SendSuccessfulRecoveryEmail(email);
                            }
                            else
                            {
                                this.Close();
                                login_form loginForm = new login_form();
                                loginForm.ShowDialog();
                            }
                        }
                        else
                        {
                            attemptCount++;
                            if (attemptCount >= 5)
                            {
                                lockoutUntil = DateTime.Now.AddHours(1);
                                SendSuspiciousActivityEmail(email);
                                MessageBox.Show("Too many failed attempts. You are locked out for 1 hour.", "Locked Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Incorrect security answer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        attemptCount++;
                        if (attemptCount >= 5)
                        {
                            lockoutUntil = DateTime.Now.AddMinutes(15); // lock for 15 minutes
                            MessageBox.Show("Too many failed attempts. You are locked out for 15 minutes.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            int remainingAttempts = 5 - attemptCount;
                            MessageBox.Show($"Incorrect answer. You have {remainingAttempts} attempt(s) remaining.", "Incorrect Answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SendSuspiciousActivityEmail(string email)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("remmm.help@gmail.com", "nwvo tqpy onmt aohm"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("remmm.help@gmail.com"),
                Subject = "⚠️ Remmm Password Recovery Attempt",
                IsBodyHtml = true,
                BodyEncoding = Encoding.UTF8,
                Body = $@"
<html>
    <body style='background-color: #141414; font-family: Helvetica, Arial, sans-serif; color: #ffffff; padding: 20px;'>
        <div style='max-width: 600px; margin: auto; background-color: #1c1c1c; padding: 30px; border-radius: 8px; box-shadow: 0 0 10px rgba(0,0,0,0.5);'>
            <h1 style='color: #e50914; text-align: center;'>Remmm</h1>
            <h2 style='color: #ffcc00; text-align: center;'>Suspicious Activity Alert</h2>
            <p style='color: #ffffff; text-align: center;'>Someone tried to recover your account using the security question method.</p>
            <p style='color: #ffffff; text-align: center;'>If this wasn't you, please secure your account immediately.</p>
            <hr style='border-color: #333333; margin: 30px 0;'>
            <p style='font-size: 12px; text-align: center; color: #aaaaaa;'>
                Need help? Contact us at 
                <a href='mailto:remmm.help@gmail.com' style='color: #e50914; text-decoration: none;'>remmm.help@gmail.com</a>
            </p>
            <p style='text-align: center; font-size: 12px; color: #555;'>© 2025 Remmm. All rights reserved.</p>
        </div>
    </body>
</html>"
            };

            mailMessage.To.Add(email);
            smtpClient.Send(mailMessage);
        }

        private bool IsStrongPassword(string password)
        {
            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSymbol = password.Any(ch => !char.IsLetterOrDigit(ch));
            return password.Length >= 8 && hasUpper && hasLower && hasDigit && hasSymbol;
        }

        private void SendSuccessfulRecoveryEmail(string Email)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("remmm.help@gmail.com", "nwvo tqpy onmt aohm"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("remmm.help@gmail.com"),
                Subject = "✅ Remmm Password Successfully Reset",
                IsBodyHtml = true,
                BodyEncoding = Encoding.UTF8,
                Body = @"
<html>
    <body style='background-color: #141414; font-family: Helvetica, Arial, sans-serif; color: #ffffff; padding: 20px;'>
        <div style='max-width: 600px; margin: auto; background-color: #1c1c1c; padding: 30px; border-radius: 8px; box-shadow: 0 0 10px rgba(0,0,0,0.5);'>
            <h1 style='color: #e50914; text-align: center;'>Remmm</h1>
            <h2 style='color: #00cc66; text-align: center;'>Password Reset Successful</h2>
            <p style='color: #ffffff; text-align: center;'>Your password has been successfully updated through the security question recovery method.</p>
            <p style='color: #ffffff; text-align: center;'>If this was not you, please change your password immediately and contact our support team.</p>
            <hr style='border-color: #333333; margin: 30px 0;'>
            <p style='font-size: 12px; text-align: center; color: #aaaaaa;'>
                Need help? Contact us at 
                <a href='mailto:remmm.help@gmail.com' style='color: #e50914; text-decoration: none;'>remmm.help@gmail.com</a>
            </p>
            <p style='text-align: center; font-size: 12px; color: #555;'>© 2025 Remmm. All rights reserved.</p>
        </div>
    </body>
</html>"
            };

            mailMessage.To.Add(Email);
            smtpClient.Send(mailMessage);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (securityQuestion_panel.Visible == false)
            {
                securityQuestion_panel.Visible = false;
            }
            else
            {
                securityQuestion_panel.Visible = false;
            }
        }

        private void sqShowpassword_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (sqShowpassword_chk.Checked)
            {
                sqConfirmPassword_tb.PasswordChar = ('\0');
                sqNewPassword_tb.PasswordChar = ('\0');
            }
            else
            {
                sqConfirmPassword_tb.PasswordChar = ('\0');
                sqNewPassword_tb.PasswordChar = ('\0');
                sqConfirmPassword_tb.PasswordChar = ('*');
                sqNewPassword_tb.PasswordChar = ('*');
            }
        }


        private void password_chkb_CheckedChanged(object sender, EventArgs e)
        {
            if (password_chkb.Checked)
            {
                newpassword_tb.PasswordChar = '\0';
                confirmpassword_tb.PasswordChar = '\0';
            }
            else
            {
                newpassword_tb.PasswordChar = '*';
                confirmpassword_tb.PasswordChar = '*';
            }
        }

        private void emailChange_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (emailChange_cb.Checked)
            {
                emailPassword_tb.PasswordChar = ('\0');
            }
            else
            {
                emailPassword_tb.PasswordChar = ('*');
            }
        }
            private void sqEmailChange_btn_Click(object sender, EventArgs e)
            {
                string email = oldEmail_tb.Text.Trim();
                string selectedQuestion = sqEmailChange_cmb.Text;
                string answer = sqAnswerEmail_tb.Text.Trim();
                string newEmail = newEmail_tb.Text.Trim();
                string emailPassword = emailPassword_tb.Text.Trim();

                // Check if any required field is empty
                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(selectedQuestion) ||
                    string.IsNullOrWhiteSpace(answer) || string.IsNullOrWhiteSpace(newEmail) || string.IsNullOrWhiteSpace(emailPassword))
                {
                    MessageBox.Show("Please complete all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Clear the textboxes with invalid input
                    if (string.IsNullOrWhiteSpace(email)) oldEmail_tb.Clear();
                    if (string.IsNullOrWhiteSpace(selectedQuestion)) sqEmailChange_cmb.SelectedIndex = -1;
                    if (string.IsNullOrWhiteSpace(answer)) sqAnswerEmail_tb.Clear();
                    if (string.IsNullOrWhiteSpace(newEmail)) newEmail_tb.Clear();
                    if (string.IsNullOrWhiteSpace(emailPassword)) emailPassword_tb.Clear();

                    return;
                }

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Check if the new email already exists
                        string checkEmailQuery = "SELECT COUNT(*) FROM users WHERE email = @NewEmail";
                        MySqlCommand checkEmailCmd = new MySqlCommand(checkEmailQuery, connection);
                        checkEmailCmd.Parameters.AddWithValue("@NewEmail", newEmail);
                        int emailCount = Convert.ToInt32(checkEmailCmd.ExecuteScalar());

                        if (emailCount > 0)
                        {
                            MessageBox.Show("The new email address is already registered. Please choose a different email.", "Email Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Clear the new email textbox if there's an error
                            newEmail_tb.Clear();
                            return;
                        }

                        // Proceed with the rest of the process if email is not taken
                        string query = "SELECT password, security_answer FROM users WHERE email = @Email AND security_question = @Question";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Question", selectedQuestion);

                        // Execute the query and process the result in one step
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Check if data is returned
                            {
                                string storedHashedPassword = reader.GetString("password");
                                string storedHashedAnswer = reader.GetString("security_answer");

                                // Verify password
                                if (BCrypt.Net.BCrypt.Verify(emailPassword, storedHashedPassword))
                                {
                                    // Verify security answer
                                    if (BCrypt.Net.BCrypt.Verify(answer, storedHashedAnswer))
                                    {
                                        // Close the reader before executing another command
                                        reader.Close();

                                        // Update email
                                        string updateQuery = "UPDATE users SET email = @NewEmail WHERE email = @Email";
                                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                                        updateCmd.Parameters.AddWithValue("@NewEmail", newEmail);
                                        updateCmd.Parameters.AddWithValue("@Email", email);
                                        updateCmd.ExecuteNonQuery();

                                        MessageBox.Show("Email has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        if (Application.OpenForms["home_form"] != null)
                                        {
                                            this.Close();
                                            StayLoggedIn.ClearSession();
                                            Application.Restart();
                                            // SendSuccessfulEmailChangeNotification(newEmail);
                                        }
                                        else
                                        {
                                            this.Close();
                                            login_form loginForm = new login_form();
                                            loginForm.ShowDialog();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect security answer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                        // Clear the answer textbox if there's an error
                                        sqAnswerEmail_tb.Clear();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    // Clear the password textbox if there's an error
                                    emailPassword_tb.Clear();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No matching user found for the provided information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                // Clear the email textbox if no match found
                                oldEmail_tb.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void cls_pb_MouseEnter(object sender, EventArgs e)
        {
            cls_pb.BackColor = Color.FromArgb(226, 0, 39);
        }

        private void cls_pb_MouseLeave(object sender, EventArgs e)
        {
            cls_pb.BackColor = Color.FromArgb(0, 0, 0);
        }

    }
    }
