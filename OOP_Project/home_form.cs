using System;
using System.Data;
using System.Drawing;
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
            popularMovie_flp.VerticalScroll.Visible = false;
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

        private void close_pb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_pb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private const int scrollAmount = 500; // how much to scroll on each click

        private void popularRight_btn_Click(object sender, EventArgs e)
        {
            int currentX = popularMovie_flp.HorizontalScroll.Value;
            popularMovie_flp.AutoScrollPosition = new Point(currentX + scrollAmount, 0);
        }

        private void popularLeft_btn_Click(object sender, EventArgs e)
        {
            int currentX = popularMovie_flp.HorizontalScroll.Value;
            popularMovie_flp.AutoScrollPosition = new Point(currentX - scrollAmount, 0);
        }
    }
}
