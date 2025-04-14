using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;
using ComponentFactory.Krypton.Toolkit;
using System.Web.UI.WebControls;


namespace OOP_Project
{
    public partial class home_form : KryptonForm
    {
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
        private string userType;
        public home_form(string userTypeFromLogin)
        {
            InitializeComponent();
            userType = userTypeFromLogin;
            HandleAccess();
          //  Panel_edit.Visible = false;

        }

        // This will round the corners of the form
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



        private void HandleAccess()
        {
            if (userType.ToLower() == "member")
            {
                //edit_panel.Visible = false; // Hide button edit
            }
            else
            {
                //edit_panel.Visible = true;  // show edit button
            }
        }


        private async void home_form_Load(object sender, EventArgs e)
        {
            CurvePanel(movie_panel, 30);
            movie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

            CurvePanel(recommendedMovie_panel, 30);
            recommendedMovie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

            CurvePanel(recommendedMovie_flp, 30);
            recommendedMovie_flp.Resize += (s, args) => CurvePanel(movie_panel, 20);

            CurvePanel(popularMovie_panel, 30);
            movie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

            CurvePanel(popularMovie_flp, 30);
            recommendedMovie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

            CurvePanel(topRatedMovie_panel, 30);
            movie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

            CurvePanel(topRatedMovie_flp, 30);
            recommendedMovie_panel.Resize += (s, args) => CurvePanel(movie_panel, 20);

        }

        private void close_pb_Click(object sender, EventArgs e)
        {
            string msg = "Do you want to leave this page?";
            string title = "Confirm Naviagtion";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(msg, title, btn, icon);
            if(result == DialogResult.Yes) 
            {
                Application.Exit();
            }
            else
            {
                return;
            }
            
        }

        private void close_pb_MouseEnter(object sender, EventArgs e)
        {
            close_pb.BackColor = Color.FromArgb(226, 0, 39);
        }

        private void close_pb_MouseLeave(object sender, EventArgs e)
        {
            close_pb.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void minimize_pb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimize_pb_MouseEnter(object sender, EventArgs e)
        {
            minimize_pb.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void minimize_pb_MouseLeave(object sender, EventArgs e)
        {
            minimize_pb.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            form_lbl.Text = "HOME";
        }

        private void favorite_btn_Click(object sender, EventArgs e)
        {
            form_lbl.Text = "FAVORITE";
        }

        private void popular_btn_Click(object sender, EventArgs e)
        {
            form_lbl.Text = "POPULAR";
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            form_lbl.Text = "SETTINGS";
        }

        private void signOut_btn_Click_1(object sender, EventArgs e)
        {
            StayLoggedIn.ClearSession();
            this.Hide();
            login_form loginForm = new login_form();
            loginForm.ShowDialog();
            this.Close();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recommendedMovieLeft_btn_MouseClick(object sender, MouseEventArgs e)
        {
            recommendedMovieLeft_btn.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void recommendedMovieLeft_btn_MouseLeave(object sender, EventArgs e)
        {
            recommendedMovieLeft_btn.BackColor = Color.FromArgb(128, 128, 128);
        }

        private void recommendedMovieLeft_btn_MouseEnter(object sender, EventArgs e)
        {
            recommendedMovieLeft_btn.BackColor = Color.FromArgb(140, 140, 140);
        }

        private void recommendedMovieRight_btn_MouseEnter(object sender, EventArgs e)
        {
            recommendedMovieRight_btn.BackColor = Color.FromArgb(140, 140, 140);
        }

        private void recommendedMovieRight_btn_MouseLeave(object sender, EventArgs e)
        {
            recommendedMovieRight_btn.BackColor = Color.FromArgb(128, 128, 128);
        }

        private void recommendedMovieRight_btn_MouseClick(object sender, MouseEventArgs e)
        {
            recommendedMovieRight_btn.BackColor = Color.FromArgb(100, 100, 100);
        }
    }
}
