using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class MovieCard : UserControl
    {
        private int currentUserId;
        private int movieID;

        public MovieCard()
        {
            InitializeComponent();

            // Initialize the PictureBox for the poster
            poster_pb = new PictureBox
            {
                Dock = DockStyle.Fill,  // Fill the UserControl with the image
                SizeMode = PictureBoxSizeMode.StretchImage // Adjust image size
            };

            this.Controls.Add(poster_pb);

            // Listen to click events on the poster
            poster_pb.Click += (s, e) => OnMovieClicked();
            this.Click += (s, e) => OnMovieClicked(); // Optional: allow clicking anywhere on the card


        }



        // Property to store the movie ID
        public int MovieID { get; set; }

        // Property to set the image of the movie poster
        public Image Poster
        {
            get { return poster_pb.Image; }
            set { poster_pb.Image = value; }
        }

        // Event to notify when the movie is clicked
        public event EventHandler MovieClicked;

        // Method to invoke the MovieClicked event
        protected virtual void OnMovieClicked()
        {
            MovieClicked?.Invoke(this, EventArgs.Empty);
        }

        private void poster_pb_Click(object sender, EventArgs e)
        {
            // Assuming currentUserId is accessible in this context (if it's a global variable or passed)
            movie_details_form movieDetails = new movie_details_form(MovieID, currentUserId);
            movieDetails.Show();
        }


    }
}
