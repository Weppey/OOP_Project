using ComponentFactory.Krypton.Docking;
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
    public partial class MovieCard : UserControl
    {
        private PictureBox poster_pb;
        private int currentUserId;

        public MovieCard()
        {
            InitializeComponent();

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
            movie_details_form movieDetails = new movie_details_form(MovieID, currentUserId);
            movieDetails.Show();
        }
    }

}