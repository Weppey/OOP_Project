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
    public partial class MovieDetailsForm : Form
    {
        private Movie _moovie;
        public MovieDetailsForm(Movie moovie)
        {
            InitializeComponent();
            _moovie = moovie;
            posterBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void MovieDetailsForm_Load(object sender, EventArgs e)
        {
            // Set movie title and description to the LABELS
            title_lbl.Text = _moovie.Title;
            description_txt.Text = _moovie.Description;
            genre_lbl.Text = _moovie.Genre;
            releaseDate_lbl.Text = "Year released: " + _moovie.ReleaseYear;

            // Set poster image to the PICTURE BOX
            try
            {
                if (!string.IsNullOrEmpty(_moovie.ImageUrl))
                {
                    posterBox.Load(_moovie.ImageUrl);
                }
                else
                {
                    posterBox.Image = Properties.Resources.fallback;
                }
            }
            catch
            {
                posterBox.Image = Properties.Resources.fallback;
            }

        }

        private void genre_lbl_Click(object sender, EventArgs e)
        {

        }    

        private void cls_pb_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }

    
}
