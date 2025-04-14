using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Org.BouncyCastle.Asn1.Crmf;
using RestSharp;
using RestSharp.Authenticators;
using System.Net.Mail;


namespace OOP_Project
{
    public partial class signup_form : Form
    {
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";

        public signup_form()
        {
            InitializeComponent();
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPassword(string password)
        {
            // Password should contain at least one uppercase letter and one special character
            string pattern = @"^(?=.*[A-Z])(?=.*[\W_]).+$";
            return Regex.IsMatch(password, pattern);
        }

        private void SendConfirmationEmail(string email, string confirmationCode)
        {
            try
            {
                // Define the SMTP client
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new System.Net.NetworkCredential("remmm.help@gmail.com", "nwvo tqpy onmt aohm"),
                    EnableSsl = true,
                };

                // Create the email message
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("remmm.help@gmail.com"),
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
                    <p style='font-size: 12px; color: #888888;'>Best regards, <br> Remmm Support Team</p>
                    <footer style='margin-top: 30px; text-align: center; font-size: 12px; color: #888888;'>
                        <p>For any issues, contact us at <a href='mailto:support@yourdomain.com'>remmm.help@gmail.com</a></p>
                    </footer>
                </div>
            </body>
        </html>"
                };


                mailMessage.To.Add(email);
                //gumana kaya// 

                // Send the email
                smtpClient.Send(mailMessage);

                MessageBox.Show("Confirmation code sent to your email!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //test


        private string GenerateConfirmationCode()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Range(0, 6).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }

        private void signup_form_Load(object sender, EventArgs e)
        {
            string[] securityQuestions = { "What is your mother's maiden name?", "What was your first pet's name?", "What was your first car?", "What elementary school did you attend?", "What is your favorite food?" };
            securityQ_cb.Items.AddRange(securityQuestions);

            // Add movie genres to CheckedListBox (preferences)
            string[] movieGenres = { "Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Documentary", "Drama", "Family", "Fantasy", "History", "Horror", "Musical", "Mystery", "Romance", "Sci-Fi", "Sport", "Thriller", "War", "Western" };
            preferences_clb.Items.AddRange(movieGenres);
        }


        private async void signup_btn_Click(object sender, EventArgs e)
        {
            string username = username_tb.Text;
            string email = email_tb.Text;
            string password = password_tb.Text;
            string gender = gender_cb.SelectedItem?.ToString();
            string birthdate = birthdate_picker.Value.ToString("yyyy-MM-dd");
            string securityQuestion = securityQ_cb.SelectedItem?.ToString();
            string securityAnswer = answer_tb.Text;

            // Validate input fields
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(securityQuestion) || string.IsNullOrWhiteSpace(securityAnswer))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit early, no data will reach the database
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit early, no data will reach the database
            }

            // Validate password strength
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password must contain at least one uppercase letter and one special character!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit early, no data will reach the database
            }

            // Validate age
            int age = DateTime.Now.Year - birthdate_picker.Value.Year;
            if (DateTime.Now.Month < birthdate_picker.Value.Month ||
                (DateTime.Now.Month == birthdate_picker.Value.Month && DateTime.Now.Day < birthdate_picker.Value.Day))
            {
                age--;
            }

            if (age < 8)
            {
                MessageBox.Show("You must be at least 8 years old to sign up!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit early, no data will reach the database
            }

            // Hash password and security answer
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            string hashedAnswer = BCrypt.Net.BCrypt.HashPassword(securityAnswer);
            string verificationCode = GenerateConfirmationCode();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // Check if the username already exists
                    string checkUsernameQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                    MySqlCommand checkUsernameCmd = new MySqlCommand(checkUsernameQuery, connection);
                    checkUsernameCmd.Parameters.AddWithValue("@username", username);

                    int usernameCount = Convert.ToInt32(checkUsernameCmd.ExecuteScalar());
                    if (usernameCount > 0)
                    {
                        MessageBox.Show("Username is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit early, no data will reach the database
                    }

                    // Insert the user into the database if all validations pass
                    string query = "INSERT INTO users (username, email, password, gender, birthdate, age, preferences, user_type, security_question, security_answer, verification_code) " +
                                   "VALUES (@username, @email, @password, @gender, @birthdate, @age, @preferences, 'member', @security_question, @security_answer, @verification_code)";

                    string preferences = string.Join(", ", preferences_clb.CheckedItems.Cast<string>());

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@birthdate", birthdate);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@preferences", preferences);
                        cmd.Parameters.AddWithValue("@security_question", securityQuestion);
                        cmd.Parameters.AddWithValue("@security_answer", hashedAnswer);
                        cmd.Parameters.AddWithValue("@verification_code", verificationCode);

                        cmd.ExecuteNonQuery();
                    }

                    // Send the confirmation email
                    SendConfirmationEmail(email, verificationCode);

                    MessageBox.Show("Sign-up successful! Please check your email for a confirmation code.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the verification form
                    this.Hide();
                    verification_form verifyForm = new verification_form(email);
                    verifyForm.ShowDialog();
                    this.Close();

                   
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void login_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   
            this.Hide();
            login_form Login_Form = new login_form();
            Login_Form.ShowDialog();
            this.Hide();
            
        }

        private void password_chkb_CheckedChanged(object sender, EventArgs e)
        {
            if (password_chkb.Checked)
            {
                password_tb.PasswordChar = '\0';
            }
            else
            {
                password_tb.PasswordChar = '*';
            }
        }

        private void minimize_pb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_pb_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form LoginForm = new login_form();
            LoginForm.Show();
            this.Close();

          
        }
    }
}
