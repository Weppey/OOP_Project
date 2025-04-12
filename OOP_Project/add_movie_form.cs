using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class add_movie_form : Form
    {
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";

        public add_movie_form()
        {
            InitializeComponent();
        }

        private void LoadImageFromUrl(string imageUrl)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(imageUrl))
                {
                    var request = WebRequest.Create(imageUrl);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        poster_pb.Image = Image.FromStream(stream);
                    }
                }
            }
            catch
            {
                poster_pb.Image = Properties.Resources.Logonetflix; // Use a default image if the URL is invalid
            }
        }

        private void insert_btn_Click_1(object sender, EventArgs e)
        {
            string title = title_tb.Text;
            string description = desc_tb.Text;
            string genre = genre_clb.Text; // Assuming you use ComboBox for genres
            string releaseYear = releaseY_tb.Text;
            string imageUrl = url_tb.Text;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(genre) || string.IsNullOrWhiteSpace(releaseYear))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Movies (title, description, release_year, genre, image_url, views, created_at) VALUES (@Title, @Description, @ReleaseYear, @Genre, @ImageUrl, @Views, NOW())";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@ReleaseYear", releaseYear);
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    cmd.Parameters.AddWithValue("@ImageUrl", imageUrl);
                    cmd.Parameters.AddWithValue("@Views", 0); // Initially set views to 0

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Movie has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add movie: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_movie_form_Load_1(object sender, EventArgs e)
        {
            poster_pb.Image = Properties.Resources.Logonetflix;
            // Populate the CheckedListBox with predefined genres
            genre_clb.Items.AddRange(new string[]
            {
                "Action", "Adventure", "Comedy", "Drama", "Fantasy",
                "Horror", "Mystery", "Romance", "Sci-Fi", "Thriller"
            });
        }

        private void url_tb_TextChanged_1(object sender, EventArgs e)
        {
            LoadImageFromUrl(url_tb.Text);
        }

        private void Pb_logo_Click(object sender, EventArgs e)
        {

        }

        private void poster_pb_Click(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {

        }

        private void minimize_pb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
