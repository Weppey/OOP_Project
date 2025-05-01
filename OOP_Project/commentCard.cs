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

        private int interactionId;
        private int commentUserId;
        private int currentUserId;
        private int parentMovieId;

        private string userType;


        public commentCard()
        {
            InitializeComponent();
        }

        public void InitializeCommentCard(int interactionId, int commentUserId, int currentUserId, int movieId)
        {
            this.interactionId = interactionId;
            this.commentUserId = commentUserId;
            this.currentUserId = currentUserId;
            this.parentMovieId = movieId;

            // Show buttons only if current user is the comment author
            if (commentUserId == currentUserId)
            {
                editComment_btn.Visible = true;
                deleteComment_btn.Visible = true;
            }
            else
            {
                editComment_btn.Visible = false;
                deleteComment_btn.Visible = false;
            }
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
            if (MessageBox.Show("Are you sure you want to delete this comment?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM movie_interaction WHERE interaction_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", interactionId);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Optionally notify parent form to reload comments
                MessageBox.Show("Comment deleted.");
                this.Parent.Controls.Remove(this); // Remove card from panel
            }
        }
        int isClicked = 0;
        private void editComment_btn_Click(object sender, EventArgs e)
        {
            if (isClicked == 0)
            {
                editComment_btn.Values.Image = Properties.Resources.icons8_save_20;
                comment_tb.Text = comment_lbl.Text.TrimStart(':', ' ').Trim();
                comment_lbl.Visible = false;
                comment_tb.Visible = true;
                comment_tb.Focus();
                comment_tb.SelectAll();
                isClicked = 1;
            }
            else if(isClicked == 1)
            {
                SaveEditedComment();
                editComment_btn.Values.Image = Properties.Resources.icons8_edit_20__1_;
                comment_tb.Text = comment_lbl.Text.TrimStart(':', ' ').Trim();
                comment_lbl.Visible = true;
                comment_tb.Visible = false;
                comment_tb.Focus();
                comment_tb.SelectAll();
                isClicked = 0;
            }
            
        }

        private void comment_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveEditedComment();
                editComment_btn.Values.Image = Properties.Resources.icons8_edit_20__1_;
                isClicked = 0;
                e.SuppressKeyPress = true; // Prevent ding sound
            }
        }

        private void SaveEditedComment()
        {
            string newText = comment_tb.Text.Trim();

            if (!string.IsNullOrWhiteSpace(newText))
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE movie_interaction SET comment = @comment WHERE interaction_id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@comment", newText);
                            cmd.Parameters.AddWithValue("@id", interactionId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Update UI
                    comment_lbl.Text = ": " + newText;
                    comment_lbl.Visible = true;
                    comment_tb.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update comment: " + ex.Message);
                }
            }
        }

    }
}
