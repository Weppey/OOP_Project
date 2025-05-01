using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Project
{
    partial class commentCard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.username_lbl = new System.Windows.Forms.Label();
            this.commentBG_panel = new System.Windows.Forms.Panel();
            this.deleteComment_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.editComment_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileBack_panel = new System.Windows.Forms.Panel();
            this.userAvatar = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.commentBackColor = new System.Windows.Forms.Panel();
            this.comment_lbl = new System.Windows.Forms.Label();
            this.separatorPanel = new System.Windows.Forms.Panel();
            this.commentBG_panel.SuspendLayout();
            this.profileBack_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).BeginInit();
            this.commentBackColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.username_lbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.username_lbl.Location = new System.Drawing.Point(73, 1);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(91, 21);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "Username:";
            // 
            // commentBG_panel
            // 
            this.commentBG_panel.AutoSize = true;
            this.commentBG_panel.BackColor = System.Drawing.Color.White;
            this.commentBG_panel.Controls.Add(this.deleteComment_btn);
            this.commentBG_panel.Controls.Add(this.editComment_btn);
            this.commentBG_panel.Controls.Add(this.panel1);
            this.commentBG_panel.Controls.Add(this.profileBack_panel);
            this.commentBG_panel.Controls.Add(this.dateLabel);
            this.commentBG_panel.Controls.Add(this.commentBackColor);
            this.commentBG_panel.Controls.Add(this.username_lbl);
            this.commentBG_panel.Controls.Add(this.separatorPanel);
            this.commentBG_panel.Location = new System.Drawing.Point(3, 3);
            this.commentBG_panel.Name = "commentBG_panel";
            this.commentBG_panel.Size = new System.Drawing.Size(848, 84);
            this.commentBG_panel.TabIndex = 1;
            // 
            // deleteComment_btn
            // 
            this.deleteComment_btn.Location = new System.Drawing.Point(799, 25);
            this.deleteComment_btn.Name = "deleteComment_btn";
            this.deleteComment_btn.Size = new System.Drawing.Size(28, 28);
            this.deleteComment_btn.TabIndex = 8;
            this.deleteComment_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_trash_20;
            this.deleteComment_btn.Values.Text = "";
            this.deleteComment_btn.Click += new System.EventHandler(this.deleteComment_btn_Click);
            // 
            // editComment_btn
            // 
            this.editComment_btn.Location = new System.Drawing.Point(765, 25);
            this.editComment_btn.Name = "editComment_btn";
            this.editComment_btn.Size = new System.Drawing.Size(28, 28);
            this.editComment_btn.TabIndex = 7;
            this.editComment_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_edit_20__1_;
            this.editComment_btn.Values.Text = "";
            this.editComment_btn.Click += new System.EventHandler(this.editComment_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 2);
            this.panel1.TabIndex = 4;
            // 
            // profileBack_panel
            // 
            this.profileBack_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.profileBack_panel.Controls.Add(this.userAvatar);
            this.profileBack_panel.Location = new System.Drawing.Point(11, 15);
            this.profileBack_panel.Name = "profileBack_panel";
            this.profileBack_panel.Size = new System.Drawing.Size(55, 55);
            this.profileBack_panel.TabIndex = 6;
            // 
            // userAvatar
            // 
            this.userAvatar.BackColor = System.Drawing.Color.Transparent;
            this.userAvatar.Location = new System.Drawing.Point(5, 11);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Size = new System.Drawing.Size(45, 45);
            this.userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAvatar.TabIndex = 5;
            this.userAvatar.TabStop = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.dateLabel.Location = new System.Drawing.Point(645, 65);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateLabel.Size = new System.Drawing.Size(33, 15);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Date";
            // 
            // commentBackColor
            // 
            this.commentBackColor.AutoSize = true;
            this.commentBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.commentBackColor.Controls.Add(this.comment_lbl);
            this.commentBackColor.Location = new System.Drawing.Point(75, 25);
            this.commentBackColor.Name = "commentBackColor";
            this.commentBackColor.Size = new System.Drawing.Size(684, 40);
            this.commentBackColor.TabIndex = 1;
            // 
            // comment_lbl
            // 
            this.comment_lbl.AutoSize = true;
            this.comment_lbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comment_lbl.ForeColor = System.Drawing.Color.White;
            this.comment_lbl.Location = new System.Drawing.Point(8, 9);
            this.comment_lbl.Name = "comment_lbl";
            this.comment_lbl.Size = new System.Drawing.Size(87, 19);
            this.comment_lbl.TabIndex = 2;
            this.comment_lbl.Text = "> Comment:";
            // 
            // separatorPanel
            // 
            this.separatorPanel.BackColor = System.Drawing.Color.Gray;
            this.separatorPanel.Location = new System.Drawing.Point(74, 21);
            this.separatorPanel.Name = "separatorPanel";
            this.separatorPanel.Size = new System.Drawing.Size(756, 1);
            this.separatorPanel.TabIndex = 3;
            // 
            // commentCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.commentBG_panel);
            this.Name = "commentCard";
            this.Size = new System.Drawing.Size(854, 91);
            this.Load += new System.EventHandler(this.commentCard_Load);
            this.commentBG_panel.ResumeLayout(false);
            this.commentBG_panel.PerformLayout();
            this.profileBack_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).EndInit();
            this.commentBackColor.ResumeLayout(false);
            this.commentBackColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label username_lbl;
        private Panel commentBG_panel;
        private Panel commentBackColor;
        private Label comment_lbl;
        private Panel separatorPanel; // Added separator panel for the border between username and comment
        private Label dateLabel;
        private PictureBox userAvatar;
        private Panel profileBack_panel;
        private Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteComment_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton editComment_btn;
    }
}
