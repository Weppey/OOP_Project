﻿using System;
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
        public MovieCard()
        {
            InitializeComponent();
        }

        public Image Poster
        {
            get { return poster_pb.Image; }
            set { poster_pb.Image = value; }
        }
    }
}
