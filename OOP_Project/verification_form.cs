using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace OOP_Project
{
    public partial class verification_form : KryptonForm
    {
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
        private string userEmail;
        private string userName;
        private string userId;

        private int cooldownTime = 300; // 5 minutes in seconds

        public verification_form(string email)
        {
            InitializeComponent();
            userEmail = email;
            resend_llbl.Enabled = false;
            StartCooldown();

            CurvePanel(Panel_verify, 30);
            Panel_verify.Resize += (s, args) => CurvePanel(Panel_verify, 20);
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
                        string updateQuery = "UPDATE users SET email_verified = 1 WHERE email = @Email";
                        //old string updateQuery
                        //string updateQuery = "UPDATE users SET verification_code = NULL, email_verified = 1 WHERE email = @Email";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                        updateCmd.Parameters.AddWithValue("@Email", userEmail);
                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Verification successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SendAccountVerifiedEmail(userEmail);
                        this.Hide();
                        login_form loginForm = new login_form();
                        loginForm.ShowDialog();
                        this.Close();
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
        private async Task SendAccountVerifiedEmail(string email)
        {
            try
            {
                // Set up SMTP client
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("remmm.help@gmail.com", "nwvo tqpy onmt aohm"),  // Updated email credentials
                    EnableSsl = true
                };

                // Create the email message
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("remmm.help@gmail.com"),
                    Subject = "Account Verified Successfully",
                    IsBodyHtml = true, // Set this to true to allow HTML content
                    Body = $@"
        <html>
            <body style='font-family: Arial, sans-serif; color: #333333; background-color: #141414; padding: 20px;'>
                <div style='background-color: #1c1c1c; padding: 20px; border-radius: 10px;'>
                    <h2 style='color: #28a745; font-size: 24px;'>Account Verified Successfully</h2>
                    <p style='color: #ffffff;'>Hi there,</p>
                    <p style='color: #ffffff;'>We're happy to inform you that your account has been successfully verified. You can now fully access all the features of your account.</p>
                    <p style='color: #ffffff; margin-top: 20px;'>Thank you for completing the verification process.</p>
                    <p style='color: #888888; font-size: 12px;'>Best regards, <br> Remmm Support Team</p>
                    <footer style='margin-top: 30px; text-align: center; font-size: 12px; color: #888888;'>
                        <p style='color: #888888;'>For any issues, contact us at <a href='mailto:remmm.help@gmail.com' style='color: #28a745;'>remmm.help@gmail.com</a></p>
                    </footer>
                </div>
            </body>
        </html>"
                };

                mailMessage.To.Add(email);

                // Send the email
                await Task.Run(() => smtpClient.Send(mailMessage));

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Credentials = new NetworkCredential("remmm.help@gmail.com", "nwvo tqpy onmt aohm"),  // Updated email credentials
                    EnableSsl = true
                };

                // Create the email message
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("remmm.help@gmail.com"),
                    Subject = "New Verification Code",
                    IsBodyHtml = true, // Set this to true to allow HTML content
                    Body = $@"
            <html>
                <body style='font-family: Arial, sans-serif; color: #333333; background-color: #141414; padding: 20px;'>
                    <div style='background-color: #1c1c1c; padding: 20px; border-radius: 10px;'>
                        <h2 style='color: #e50914; font-size: 24px;'>Verification Code</h2>
                        <p style='color: #ffffff;'>Hi there,</p>
                        <p style='color: #ffffff;'>We received a request to verify your email address. Please use the following code to complete the process:</p>
                        <div style='font-size: 24px; font-weight: bold; text-align: center; background-color: #333333; padding: 15px; border-radius: 5px; color: #e50914;'>
                            {confirmationCode}
                        </div>
                        <p style='color: #ffffff; margin-top: 20px;'>If you did not request this verification, please ignore this email.</p>
                        <p style='color: #888888; font-size: 12px;'>Best regards, <br> Remmm Support Team</p>
                        <footer style='margin-top: 30px; text-align: center; font-size: 12px; color: #888888;'>
                            <p style='color: #888888;'>For any issues, contact us at <a href='mailto:remmm.help@gmail.com' style='color: #e50914;'>remmm.help@gmail.com</a></p>
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


        private void min_pb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cls_pb_Click(object sender, EventArgs e)
        {
            this.Close();
            login_form LoginForm = new login_form();
            LoginForm.Show();
        }



        private void code_tb_Enter(object sender, EventArgs e)
        {
            if (code_tb.Text == "Code")
            {
                code_tb.Text = "";
                code_tb.ForeColor = Color.Black;
            }
        }

        private void code_tb_Leave(object sender, EventArgs e)
        {
            if(code_tb.Text == "")
            {
                code_tb.Text = "Code";
                code_tb.ForeColor = Color.Gray;
            }
        }

    }
}
