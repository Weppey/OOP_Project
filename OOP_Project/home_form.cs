using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OOP_Project
{
    public partial class home_form : Form
    {
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";

        public home_form()
        {
            InitializeComponent();
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
            this.Close();
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
            this.Close();
            login_form loginForm = new login_form();
            loginForm.Show();
        }

        private void admin_insert_btn_Click(object sender, EventArgs e)
        {
            add_movie_form addMovieForm = new add_movie_form();
            addMovieForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void code_lbl_Click(object sender, EventArgs e)
        {

        }

        private void menu_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_btn_Click(object sender, EventArgs e)
        {

        }

        private void popular_btn_Click(object sender, EventArgs e)
        {

        }

        private void favorite_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
