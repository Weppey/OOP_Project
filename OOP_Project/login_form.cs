﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net; // Import bcrypt library

namespace OOP_Project
{
    public partial class login_form : Form
    {
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";

        public login_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

                    // Retrieve hashed password from database
                    string query = "SELECT password, user_type FROM users WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHashedPassword = reader["password"].ToString();
                            string userType = reader["user_type"].ToString();

                            // Verify bcrypt password
                            if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword))
                            {
                                MessageBox.Show($"Login successful! Welcome {userType}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Example: Redirect to main dashboard (replace with actual navigation logic)
                                this.Hide(); // Hide the login form
                                home_form MainForm = new home_form(); // Assuming you have a MainForm
                                MainForm.Show();
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
            signup_form SignUp_Form = new signup_form();
            SignUp_Form.Show();
            this.Hide();
        }

        private void close_pb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_pb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void forgotP_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the Account Recovery Form
            account_recovery_form recoveryForm = new account_recovery_form();
            recoveryForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //logo to
        }

        private void username_lbl_Click(object sender, EventArgs e)
        {

        }

        private void password_lbl_Click(object sender, EventArgs e)
        {

        }

        private void username_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void account_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
