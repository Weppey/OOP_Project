using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class admin_form : Form
    {

        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
        private string userType;
        private int currentUserId;
        public admin_form(string userType, int currentUserId)
        {
            InitializeComponent();

         //   home_form homeForm = new home_form(userType, currentUserId);
         //may problema pa sa load dahil sa images
         //   homeForm.LoadMovies();

            movieListAdmin_panel.FlowDirection = FlowDirection.LeftToRight;
            movieListAdmin_panel.WrapContents = true;
            movieListAdmin_panel.AutoScroll = true;

            for (int i = 0; i < 10; i++)
            {
                Panel p = new Panel();
                p.Width = 200;
                p.Height = 300;
                p.BackColor = Color.AliceBlue;
                movieListAdmin_panel.Controls.Add(p);
            }

            genre_clb.Items.AddRange(new string[]
             {
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Sci-Fi",
            "Romance",
            "Thriller",
            "Documentary",
            "Adventure",
            "Animation",
            "Fantasy"
             });

            genre_clb.SelectedIndex = 0; // Optional: select first item by default

            CurvePanel(insertMovie_panel, 30);
            insertMovie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

        }

        private void CurvePanel(System.Windows.Forms.Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }
        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            insertMovie_panel.Visible = true;

        }

        private void insertClose_btn_Click(object sender, EventArgs e)
        {
            insertMovie_panel.Visible=false;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(title_tb.Text) ||
                string.IsNullOrWhiteSpace(posterUrl_lbl.Text) ||
                string.IsNullOrWhiteSpace(decription_lbl.Text) ||
                genre_clb.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill out all fields before inserting the movie.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get release year from DateTimePicker
            int year = releaseDate_dtp.Value.Year;

            // Optional: Check if the year is not in the future
            if (year > DateTime.Now.Year)
            {
                MessageBox.Show("Release year cannot be in the future.", "Invalid Year", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string imageUrl = url_tb.Text.Trim();

            // All good, insert the movie
            InsertMovie(title_tb.Text, imageUrl, genre_clb.SelectedItem.ToString(), decription_lbl.Text, year);
            insertMovie_panel.Visible = false;
        }


        private void InsertMovie(string title, string imageUrl, string genre, string description, int year)
        {
            string query = "INSERT INTO Movies (title, image_url, genre, description, release_year, created_at) " +
                           "VALUES (@title, @image_url, @genre, @description, @year, NOW())";

            //  if (!IsValidUrl(imageUrl))
            // {
            //      MessageBox.Show("Invalid Image URL. Please enter a valid URL starting with http:// or https://", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //       return;
            // }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@image_url", imageUrl);
                    cmd.Parameters.AddWithValue("@genre", genre);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@year", year);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Movie inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No rows were inserted. Please check your input.", "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting movie:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertMovie_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
