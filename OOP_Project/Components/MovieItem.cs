using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Project.Components
{
    public partial class MovieItem : UserControl
    {
        private string defaultImage = "https://via.placeholder.com/150"; // Default placeholder image

        public MovieItem()
        {
            InitializeComponent();
        }

        public string MovieTitle
        {
            get { return title_lbl.Text; }
            set { title_lbl.Text = value; }
        }

        public string MovieDescription
        {
            get { return description_lbl.Text; }
            set { description_lbl.Text = value; }
        }

        public string MovieImage
        {
            get { return poster_pb.ImageLocation; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    try
                    {
                        poster_pb.LoadAsync(value); // Load image asynchronously
                    }
                    catch
                    {
                        poster_pb.LoadAsync(defaultImage); // Use default if load fails
                    }
                }
                else
                {
                    poster_pb.LoadAsync(defaultImage);
                }
            }
        }
    }
}
