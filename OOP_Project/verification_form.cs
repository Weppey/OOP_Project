using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class verification_form : Form
    {
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
        private string userEmail;

        private int cooldownTime = 300; // 5 minutes in seconds

        public verification_form(string email)
        {
            InitializeComponent();
            userEmail = email;
            resend_llbl.Enabled = false;
            StartCooldown();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            string enteredCode = code_tb.Text;

            if (string.IsNullOrWhiteSpace(enteredCode))
            {
                MessageBox.Show("Please enter the verification code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT verification_code FROM users WHERE email = @Email";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", userEmail);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result.ToString() == enteredCode)
                    {
                        // Mark the user as verified
                        string updateQuery = "UPDATE users SET verification_code = NULL WHERE email = @Email";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                        updateCmd.Parameters.AddWithValue("@Email", userEmail);
                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Verification successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                        login_form loginForm = new login_form();
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid verification code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void resend_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            resend_llbl.Enabled = false;
            await ResendVerificationCode();
            StartCooldown();
        }

        private async Task ResendVerificationCode()
        {
            string newCode = GenerateNewVerificationCode();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE users SET verification_code = @NewCode WHERE email = @Email";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                    cmd.Parameters.AddWithValue("@NewCode", newCode);
                    cmd.Parameters.AddWithValue("@Email", userEmail);
                    cmd.ExecuteNonQuery();
                }

                await SendVerificationEmail(userEmail, newCode);

                MessageBox.Show("A new verification code has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to resend verification code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SendVerificationEmail(string email, string confirmationCode)
        {
            try
            {
                // Set up SMTP client
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("cunanjrrafael.pdm@gmail.com", "spbj xwji uzcs fbuf"),
                    EnableSsl = true
                };

                // Create the email message
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("cunanjrrafael.pdm@gmail.com"),
                    Subject = "New Verification Code",
                    IsBodyHtml = true, // Set this to true to allow HTML content
                    Body = $@"
        <html>
            <body style='font-family: Arial, sans-serif; color: #333333;'>
                <div style='background-color: #f9f9f9; padding: 20px; border-radius: 10px;'>
                    <h2 style='color: #007bff;'>Verification Code</h2>
                    <p>Hi there,</p>
                    <p>We received a request to verify your email address. Please use the following code to complete the process:</p>
                    <div style='font-size: 24px; font-weight: bold; text-align: center; background-color: #d1ecf1; padding: 15px; border-radius: 5px; color: #0056b3;'>
                        {confirmationCode}
                    </div>
                    <p style='margin-top: 20px;'>If you did not request this verification, please ignore this email.</p>
                    <p style='font-size: 12px; color: #888888;'>Best regards, <br> Reppey Support Team</p>
                    <footer style='margin-top: 30px; text-align: center; font-size: 12px; color: #888888;'>
                        <p>For any issues, contact us at <a href='mailto:support@yourdomain.com'>cunanjrrafael.pdm@gmail.com</a></p>
                    </footer>
                </div>
            </body>
        </html>"
                };


                mailMessage.To.Add(email);

                // Send the email
                await Task.Run(() => smtpClient.Send(mailMessage));

                MessageBox.Show("A new verification code has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateNewVerificationCode()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Range(0, 6).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }

        private async void StartCooldown()
        {
            while (cooldownTime > 0)
            {
                resend_llbl.Text = $"Resend Code ({cooldownTime}s)";
                await Task.Delay(1000);
                cooldownTime--;
            }

            resend_llbl.Text = "Resend Code";
            resend_llbl.Enabled = true;
        }

        private void close_pb_Click(object sender, EventArgs e)
        {
            this.Close();
            login_form LoginForm = new login_form();
            LoginForm.Show();
        }

        private void minimize_pb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void verification_form_Load(object sender, EventArgs e)
        {

        }

        private void code_lbl_Click(object sender, EventArgs e)
        {

        }

        private void status_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
