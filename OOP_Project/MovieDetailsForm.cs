using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using ComponentFactory.Krypton.Toolkit;

namespace OOP_Project
{
    public partial class MovieDetailsForm : KryptonForm
    {
        private Movie _moovie;
        public int MovieID { get; set; }
        public int CurrentUserId { get; set; }
        public MovieDetailsForm(Movie moovie)

        {                     
            InitializeComponent();
            _moovie = moovie;
            poster_pb.SizeMode = PictureBoxSizeMode.Zoom;
        }
        
        private void MovieDetailsForm_Load(object sender, EventArgs e)
        {
            // Set movie title and description to the LABELS
            title_lbl.Text = _moovie.Title;
            description_lbl.Text = _moovie.Description;
            genre_lbl.Text = _moovie.Genre;
            dateRelease_lbl.Text = "Year released: " + _moovie.ReleaseYear;

            // Set poster image to the PICTURE BOX
            try
            {
                if (!string.IsNullOrEmpty(_moovie.ImageUrl))
                {
                    poster_pb.Load(_moovie.ImageUrl);
                    panelTest.BackgroundImage = poster_pb.Image;
                    panelTest.BackgroundImageLayout = ImageLayout.Stretch;


                }
                else
                {
                    poster_pb.Image = Properties.Resources.fallback;
                }
            }
            catch
            {
                poster_pb.Image = Properties.Resources.fallback;
            }

        }

        private void genre_lbl_Click(object sender, EventArgs e)
        {

        }    

        private void cls_pb_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void title_lbl_Click(object sender, EventArgs e)
        {

        }

        private void close_pb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comment_btn_Click(object sender, EventArgs e)
        {
            //di pa nagana
            if (this.Size.Height == 620)
            {
                this.Size = new Size(1050, 700);
            }
            else
            {
                this.Size = new Size(1050, 620);
            }
        }
    }

    
}
