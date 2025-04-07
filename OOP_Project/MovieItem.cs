using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Project
{
    public class MovieItem : UserControl
    {
        private Label titleLabel;
        private Label descriptionLabel;
        private PictureBox moviePictureBox;

        public string MovieTitle
        {
            get => titleLabel.Text;
            set => titleLabel.Text = value;
        }

        public string MovieDescription
        {
            get => descriptionLabel.Text;
            set => descriptionLabel.Text = value;
        }

        public string MovieImage
        {
            get => moviePictureBox.ImageLocation;
            set => moviePictureBox.Load(value);
        }

        public MovieItem()
        {
            this.Width = 300;
            this.Height = 100;
            this.BackColor = Color.LightGray;

            moviePictureBox = new PictureBox
            {
                Size = new Size(80, 80),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            titleLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(100, 10)
            };

            descriptionLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Arial", 9),
                Location = new Point(100, 40),
                MaximumSize = new Size(200, 40)
            };

            this.Controls.Add(moviePictureBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(descriptionLabel);
        }
    }
}
