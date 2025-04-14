using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using System.Web.SessionState;

namespace OOP_Project
{
    public partial class login_form : Form
    {
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";

        public login_form()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_tb.Text;
            string password = password_tb.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve hashed password and user type from the database
                    string query = "SELECT password, user_type FROM users WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHashedPassword = reader["password"].ToString();
                            string userType = reader["user_type"].ToString();

                            // Verify password using BCrypt
                            if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword))
                            {
                                MessageBox.Show($"Login successful! Welcome {userType}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                try
                                {

                                    this.Hide();
                                    home_form home_form = new home_form(userType);
                                    home_form.ShowDialog();
                                    this.Close();

                                    StayLoggedIn.SaveUserSession(userType);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error loading home form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Show(); // Show login form again if something fails
                                }

                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signup_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void password_chkb_CheckedChanged(object sender, EventArgs e)
        {
            password_tb.PasswordChar = password_chkb.Checked ? '\0' : '*';
        }

        private void forgotP_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            account_recovery_form recoveryForm = new account_recovery_form();
            recoveryForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Logo click handler (optional)
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
