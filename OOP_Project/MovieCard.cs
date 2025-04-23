using ComponentFactory.Krypton.Docking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class MovieCard : UserControl
    {
        private PictureBox poster_pb;
        private int currentUserId;
        private Movie _moovie;
        private ToolTip tooltip = new ToolTip();

        public MovieCard(Movie moovie)
        {
            InitializeComponent();
            _moovie = moovie;
            this.Size = new Size(150, 225); // Ensure size is set


            PosterImage_pb = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom,
                Cursor = Cursors.Hand

            };

            this.Controls.Add(PosterImage_pb);

            // Handle click
            PosterImage_pb.Click += Poster_pb_Click;
        }

        public int MovieID { get; set; }

        public Image PosterImage
        {
            get { return PosterImage_pb.Image; }
            set { PosterImage_pb.Image = value; }
        }

        private void Poster_pb_Click(object sender, EventArgs e)
        {
            movie_details_form movieDetails = new movie_details_form(_moovie, currentUserId);


            movieDetails.Show();
        }

        private void MovieCard_Load(object sender, EventArgs e)
        {
            tooltip.IsBalloon = true;                        // Makes it balloon-shaped
            tooltip.BackColor = Color.LightYellow;           // Tooltip background color (only works in custom-drawn tips)
            tooltip.ForeColor = Color.Black;                 // Text color
            tooltip.UseFading = true;                        // Smooth fade-in/out
            tooltip.UseAnimation = true;                     // Animate appearance

            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 100;
            tooltip.ReshowDelay = 100;
            tooltip.ShowAlways = true;

            tooltip.SetToolTip(poster_pb, "Click to view");
        }
    }

}