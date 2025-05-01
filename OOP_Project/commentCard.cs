using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OOP_Project
{
    public partial class commentCard : UserControl
    {
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
        private int movieId;
        private int userId;
        private int interactionId;
        private bool isOwner;


        public commentCard()
        {
            InitializeComponent();
        }


        public void SetCommentInfo(int interactionId, int movieId, int userId, bool isOwner)
        {
            this.interactionId = interactionId;
            this.movieId = movieId;
            this.userId = userId;
            this.isOwner = isOwner;

            editComment_btn.Visible = isOwner;
            deleteComment_btn.Visible = isOwner;
        }

        private void CurvePanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        public void SetComment(string username, string comment, DateTime createdAt)
        {
            username_lbl.Text = "@" + username;
            dateLabel.Text = createdAt.ToString("g");
            comment_lbl.Text = ": " + comment;
        }

        public void SetAvatar(Image avatarImage)
        {
            if (avatarImage != null)
            {
                userAvatar.Image = avatarImage;
                userAvatar.Visible = true;
            }
            else
            {
                userAvatar.Image = Properties.Resources.avatar_default;
                userAvatar.Visible = true;
            }
        }

        private void commentCard_Load(object sender, EventArgs e)
        {
            CurvePanel(profileBack_panel, 60);
            profileBack_panel.Resize += (s, args) => CurvePanel(profileBack_panel, 20);

            CurvePanel(commentBackColor, 30);
            commentBackColor.Resize += (s, args) => CurvePanel(commentBackColor, 20);

            movie_details_form parentForm = this.FindForm() as movie_details_form;

        }


        private void deleteComment_btn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this comment?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM movie_interaction WHERE interaction_id = @interactionId AND user_id = @userId";
                    MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@interactionId", interactionId);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        this.Parent.Controls.Remove(this);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete comment.");
                    }
                }
            }
        }


        private void editComment_btn_Click(object sender, EventArgs e)
        {
            string currentComment = comment_lbl.Text.Substring(2); // remove ": "
            string newComment = Microsoft.VisualBasic.Interaction.InputBox("Edit your comment:", "Edit Comment", currentComment);

            if (!string.IsNullOrWhiteSpace(newComment) && newComment != currentComment)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = "UPDATE movie_interaction SET comment = @comment WHERE interaction_id = @interactionId AND user_id = @userId";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@comment", newComment);
                    cmd.Parameters.AddWithValue("@interactionId", interactionId);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        comment_lbl.Text = ": " + newComment;
                    }
                    else
                    {
                        MessageBox.Show("Failed to update comment.");
                    }
                }
            }
        }

    }
}
