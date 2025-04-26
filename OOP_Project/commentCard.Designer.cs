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
            this.commentBackColor = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.comment_lbl = new System.Windows.Forms.Label();
            this.separatorPanel = new System.Windows.Forms.Panel();
            this.commentBG_panel.SuspendLayout();
            this.commentBackColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.username_lbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.username_lbl.Location = new System.Drawing.Point(13, 1);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(91, 21);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "Username:";
            // 
            // commentBG_panel
            // 
            this.commentBG_panel.AutoSize = true;
            this.commentBG_panel.BackColor = System.Drawing.Color.White;
            this.commentBG_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentBG_panel.Controls.Add(this.dateLabel);
            this.commentBG_panel.Controls.Add(this.commentBackColor);
            this.commentBG_panel.Controls.Add(this.username_lbl);
            this.commentBG_panel.Controls.Add(this.separatorPanel);
            this.commentBG_panel.Location = new System.Drawing.Point(3, 7);
            this.commentBG_panel.Name = "commentBG_panel";
            this.commentBG_panel.Size = new System.Drawing.Size(848, 78);
            this.commentBG_panel.TabIndex = 1;
            // 
            // commentBackColor
            // 
            this.commentBackColor.AutoSize = true;
            this.commentBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.commentBackColor.Controls.Add(this.comment_lbl);
            this.commentBackColor.Location = new System.Drawing.Point(9, 32);
            this.commentBackColor.Name = "commentBackColor";
            this.commentBackColor.Size = new System.Drawing.Size(821, 33);
            this.commentBackColor.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.dateLabel.Location = new System.Drawing.Point(689, 7);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateLabel.Size = new System.Drawing.Size(33, 15);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Date";
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
            this.separatorPanel.Location = new System.Drawing.Point(9, 25);
            this.separatorPanel.Name = "separatorPanel";
            this.separatorPanel.Size = new System.Drawing.Size(821, 1);
            this.separatorPanel.TabIndex = 3;
            // 
            // commentCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.commentBG_panel);
            this.Name = "commentCard";
            this.Size = new System.Drawing.Size(854, 88);
            this.commentBG_panel.ResumeLayout(false);
            this.commentBG_panel.PerformLayout();
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
    }
}
