using System;
using System.Data;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OOP_Project
{
    public partial class home_form : Form
    {
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
        private string userType;
        public home_form(string userTypeFromLogin)
        {
            InitializeComponent();
            userType = userTypeFromLogin;
            HandleAccess();

        }
        private void HandleAccess()
        {
            if (userType.ToLower() == "member")
            {
                Panel_edit.Visible = false; // Hide admin panel
            }
            else
            {
                Panel_edit.Visible = true;  // Show admin panel
            }
        }

        private async void home_form_Load(object sender, EventArgs e)
        {

        }

        private async void removeMovie_btn_Click(object sender, EventArgs e)
        {
            if (movie_panel.Controls.Count > 0 && movie_panel.Controls[0] is movieitem_form selectedMovie)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this movie?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        await connection.OpenAsync();
                        string query = "DELETE FROM Movies WHERE title = @Title";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@Title", selectedMovie.MovieTitle);
                        await cmd.ExecuteNonQueryAsync();
                    }
               //     await LoadMoviesAsync();
                }
            }
        }

        private void minimize_pb_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_pb_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void search_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private async void clear_pb_Click(object sender, EventArgs e)
        {
            search_tb.Text = "";
        }

        private async void category_pb_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox categoryPictureBox && categoryPictureBox.Tag != null)
            {
                string selectedCategory = categoryPictureBox.Tag.ToString();
            }
        }

        private async void clear_category_pb_Click(object sender, EventArgs e)
        {

        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
            StayLoggedIn.ClearSession();
            this.Hide();
            login_form loginForm = new login_form();
            loginForm.ShowDialog();
            this.Close();
        }

        private void admin_insert_btn_Click(object sender, EventArgs e)
        {
            add_movie_form addMovieForm = new add_movie_form();
            addMovieForm.ShowDialog();
        }

       
    }
}
