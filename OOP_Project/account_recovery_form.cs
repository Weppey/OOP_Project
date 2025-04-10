using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class account_recovery_form : Form
    {
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
        private string recoveryCode;
        private int cooldownTime = 300; // 5 minutes cooldown in seconds

        public account_recovery_form()
        {
            InitializeComponent();
        }

        private void account_recovery_form_Load(object sender, EventArgs e)
        {
            // Form load logic (if any)
        }

        private bool IsValidPassword(string password)
        {
            // Password should contain at least one uppercase letter and one special character
            string pattern = @"^(?=.*[A-Z])(?=.*[\W_]).+$";
            return Regex.IsMatch(password, pattern);
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            string enteredCode = recoveryC_tb.Text;
            string newPassword = newpassword_tb.Text;
            string confirmPassword = confirmpassword_tb.Text;


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
                        this.Close();
                        login_form loginForm = new login_form();
                        loginForm.Show();
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
                // Setup and send the recovery code via email
                var smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new System.Net.NetworkCredential("cunanjrrafael.pdm@gmail.com", "spbj xwji uzcs fbuf"),
                    EnableSsl = true,
                };

                var mailMessage = new System.Net.Mail.MailMessage
                {
                    From = new System.Net.Mail.MailAddress("cunanjrrafael.pdm@gmail.com"),
                    Subject = "Password Recovery Code",
                    IsBodyHtml = true, // Set this to true to allow HTML content
                    Body = $@"
        <html>
            <body style='font-family: Arial, sans-serif; color: #333333;'>
                <div style='background-color: #f4f4f4; padding: 20px; border-radius: 10px;'>
                    <h2 style='color: #0056b3;'>Password Recovery Request</h2>
                    <p>Hi there,</p>
                    <p>We received a request to reset your password. Please use the following code to recover your account:</p>
                    <div style='font-size: 24px; font-weight: bold; text-align: center; background-color: #e6f7ff; padding: 10px; border-radius: 5px; color: #0056b3;'>
                        {recoveryCode}
                    </div>
                    <p style='margin-top: 20px;'>If you did not request a password reset, please ignore this email.</p>
                    <p style='font-size: 12px; color: #888888;'>Best regards, <br> Reppey Support Team</p>
                    <footer style='margin-top: 30px; text-align: center; font-size: 12px; color: #888888;'>
                        <p>For any issues, contact us at <a href='mailto:support@yourdomain.com'>cunanjrrafael.pdm@gmail.com</a></p>
                    </footer>
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

        private void password_chkb_CheckedChanged(object sender, EventArgs e)
        {
            if(password_chkb.Checked)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void email_lbl_Click(object sender, EventArgs e)
        {

        }

        private void recoveryC_tb_TextChanged(object sender, EventArgs e)
        {
            if (recoveryC_tb.Text.Length == recoveryC_tb.MaxLength)
            {
                MessageBox.Show("You've reached the maximum code length.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
