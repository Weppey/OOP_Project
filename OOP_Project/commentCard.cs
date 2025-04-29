using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class commentCard : UserControl
    {
        private string connectionString; // Now it will be passed externally
        private movie_details_form parentForm; // The parent form reference

        public int InteractionId { get; private set; }
        public int CommentUserId { get; private set; }

        private int userId;

        public commentCard()
        {
            InitializeComponent();
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

        }


        private void deleteComment_btn_Click(object sender, EventArgs e)
        {
            if (parentForm == null) return; // Safety check

            DialogResult result = MessageBox.Show("Are you sure you want to delete this comment?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM movie_interaction WHERE interaction_id = @interactionId";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@interactionId", InteractionId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Comment deleted.");
                    parentForm.LoadComments(); // ✅ Use the given parent form
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting comment: " + ex.Message);
                }
            }
        }
    }
}
