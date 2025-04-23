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
using ComponentFactory.Krypton.Toolkit;
using System.Drawing.Drawing2D;


namespace OOP_Project
{
    public partial class signup_form : KryptonForm
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
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new System.Net.NetworkCredential("remmm.help@gmail.com", "nwvo tqpy onmt aohm"),
                    EnableSsl = true,
                };

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("remmm.help@gmail.com"),
                    Subject = "🎬 Remmm Email Verification",
                    IsBodyHtml = true,
                    BodyEncoding = Encoding.UTF8,
                    Body = $@"
<html>
    <body style='background-color: #141414; font-family: Helvetica, Arial, sans-serif; color: #ffffff; padding: 20px;'>
        <div style='max-width: 600px; margin: auto; background-color: #000000; padding: 30px; border-radius: 8px; box-shadow: 0 0 10px rgba(0,0,0,0.5);'>
            <h1 style='color: #e50914; text-align: center; font-size: 36px;'>Remmm</h1>
            <h2 style='color: #ffffff; text-align: center;'>Verify Your Email</h2>
            <p style='text-align: center; font-size: 16px;'>To continue using Remmm, please verify your email by entering the code below:</p>
            <div style='margin: 30px auto; width: fit-content; padding: 15px 30px; background-color: #e50914; color: #ffffff; font-size: 28px; font-weight: bold; border-radius: 6px; text-align: center;'>
                {confirmationCode}
            </div>
            <p style='text-align: center; font-size: 16px;'>If you did not request this verification, feel free to ignore this email.</p>
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

                MessageBox.Show("Confirmation code sent to your email!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string GenerateConfirmationCode()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Range(0, 6).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }

        private void signup_form_Load(object sender, EventArgs e)
        {
            Lbl_Signup.Focus();
            birthday_dtp.Text = "mm/dd/yyyy";

            string[] securityQuestions = { "What is your mother's maiden name?", "What was your first pet's name?", "What was your first car?", "What elementary school did you attend?", "What is your favorite food?" };
            securityq_cmb.Items.AddRange(securityQuestions);

            // Add movie genres to CheckedListBox (preferences)
            string[] movieGenres = { "Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Documentary", "Drama", "Family", "Fantasy", "History", "Horror", "Musical", "Mystery", "Romance", "Sci-Fi", "Sport", "Thriller", "War", "Western" };
            preferences_clb.Items.AddRange(movieGenres);

            CurvePanel(signup_panel, 30);
            signup_panel.Resize += (s, args) => CurvePanel(signup_panel, 20);
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

        private void Lbl_Signup_Click(object sender, EventArgs e)
        {

        }

        private void signup_panel_Paint(object sender, PaintEventArgs e)
        {
           //
        }

        private void user_tb_TextChanged(object sender, EventArgs e)
        {

        }      

        private void showPass_chkb_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass_chkb.Checked)
            {
                pass_tb.PasswordChar = '\0';
            }
            else
            {
                pass_tb.PasswordChar = '*';
            }
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void answer_tb_TextChanged_1(object sender, EventArgs e)
        {

        }




        private void birthday_dtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void securityq_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void question_lbl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void birthdate_lbl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gender_lbl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bg2_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_llbl_LinkClicked(object sender, EventArgs e)
        {
          //  this.Hide();
            login_form Login_Form = new login_form();
            Login_Form.ShowDialog();
            this.Hide();
        }

       

        private void user_tb_Enter(object sender, EventArgs e)
        {
            if(user_tb.Text == "Username")
            {
                user_tb.Text = "";
                user_tb.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void user_tb_Leave(object sender, EventArgs e)
        {
            if(user_tb.Text == "")
            {
                user_tb.Text = "Username";
                user_tb.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void user_tb_MouseEnter(object sender, EventArgs e)
        {
  
        }

        private void signup_form_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }


        private void pass_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_tb_Enter(object sender, EventArgs e)
        {
            if (pass_tb.Text == "Password")
            {
                pass_tb.PasswordChar = '*';
                pass_tb.Text = "";
                pass_tb.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void pass_tb_Leave(object sender, EventArgs e)
        {
            if (pass_tb.Text == "")
            {
                pass_tb.PasswordChar = '\0';
                pass_tb.Text = "Password";
                pass_tb.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void email_tb_Enter(object sender, EventArgs e)
        {
            if(email_tb.Text == "Email")
            {
                email_tb.Text = "";
                email_tb.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void email_tb_Leave(object sender, EventArgs e)
        {
            if (email_tb.Text == "")
            {
                email_tb.Text = "Email";
                email_tb.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void gender_cmb_Enter(object sender, EventArgs e)
        {
            if(gender_cmb.Text == "N/A")
            {
                gender_cmb.Text = "";
                gender_cmb.StateCommon.ComboBox.Content.Color1 = Color.Black;
            }
        }

        private void gender_cmb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(gender_cmb.Text))
            {
                gender_cmb.Text = "N/A";
                gender_cmb.StateCommon.ComboBox.Content.Color1 = Color.Gray;
            }
            else
            {
                gender_cmb.StateCommon.ComboBox.Content.Color1 = Color.Black;
            }
        }

        private void birthday_dtp_CloseUp(object sender, DateTimePickerCloseArgs e)
        {
          
        }

        private void securityq_cmb_Enter(object sender, EventArgs e)
        {
            if (securityq_cmb.Text == "N/A")
            {
                securityq_cmb.Text = "";
                securityq_cmb.StateCommon.ComboBox.Content.Color1 = Color.Black;
            }
        }

        private void securityq_cmb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(securityq_cmb.Text))
            {
                securityq_cmb.Text = "N/A";
                securityq_cmb.StateCommon.ComboBox.Content.Color1 = Color.Gray;
            }
            else
            {
                securityq_cmb.StateCommon.ComboBox.Content.Color1 = Color.Black;
            }
        }

        private void answer_tb_Enter(object sender, EventArgs e)
        {
            if (answer_tb.Text == "Answer")
            {
                answer_tb.Text = "";
                answer_tb.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void answer_tb_Leave(object sender, EventArgs e)
        {
            if (answer_tb.Text == "")
            {
                answer_tb.Text = "Answer";
                answer_tb.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void email_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void sign_btn_Click(object sender, EventArgs e)
        {
            string username = user_tb.Text;
            string email = email_tb.Text;
            string password = pass_tb.Text;
            string gender = gender_cmb.SelectedItem?.ToString();
            string birthdate = birthday_dtp.Value.ToString("yyyy-MM-dd");
            string securityQuestion = securityq_cmb.SelectedItem?.ToString();
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
                email = email.Trim();
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
            int age = DateTime.Now.Year - birthday_dtp.Value.Year;
            if (DateTime.Now.Month < birthday_dtp.Value.Month ||
                (DateTime.Now.Month == birthday_dtp.Value.Month && DateTime.Now.Day < birthday_dtp.Value.Day))
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
    }
}
