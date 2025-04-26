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
    public partial class commentCard : UserControl
    {
        public commentCard()
        {
            InitializeComponent();
        }

        public void SetComment(string username, string comment, DateTime createdAt)
        {
            // Set username with bold and highlighted color
            username_lbl.Text = username + ":";

            // Set comment date in the desired format (e.g., "4/27/2025 1:00 PM")
            dateLabel.Text = createdAt.ToString("g");

            // Set comment text and ensure it includes the ">" symbol
            comment_lbl.Text = "" + comment;
        }
    }
}
