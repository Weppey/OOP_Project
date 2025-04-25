using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Linq;
using System.Collections.Generic;


namespace OOP_Project
{
    public partial class ProfileControl : UserControl
    {
        private string connectionString = "server=localhost;user=root;password=your_password;database=your_database;";
        private string originalUsername;
        private string originalEmail;
        private DateTime originalBirthdate;
        private int originalAge;
        private string originalGender;
        private List<string> originalPreferences = new List<string>();

        public ProfileControl()
        {
            InitializeComponent();


        }

        private void userProfile_cs_Load(object sender, EventArgs e)
        {
            CurvePanel(profileDetails_panel, 30);
            profileDetails_panel.Resize += (s, args) => CurvePanel(profileDetails_panel, 20);

            RoundPictureBox(avatar_pb);


            string[] preferences = { "Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Documentary", "Drama", "Family", "Fantasy", "History", "Horror", "Musical", "Mystery", "Romance", "Sci-Fi", "Sport", "Thriller", "War", "Western" };
            // Populate the CheckedListBox with movie genres
            foreach (var genre in preferences)
            {
                preferences_clb.Items.Add(genre);
            }

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

        private void RoundPictureBox(PictureBox pb)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pb.Width, pb.Height); // Make it a circle
            pb.Region = new Region(path);
        }


        private void editProfile_btn_Click(object sender, EventArgs e)
        {
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
        }
    }
}
