namespace OOP_Project
{
    partial class favorite_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.movie_panel = new System.Windows.Forms.Panel();
            this.recentlyAdded_panel = new System.Windows.Forms.Panel();
            this.recentlyAdded_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.recentlyAdded_lbl = new System.Windows.Forms.Label();
            this.favorite_lbl = new System.Windows.Forms.Label();
            this.popularmovie_pnl = new System.Windows.Forms.Panel();
            this.recentlysearch_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.favoriteMovie_panel = new System.Windows.Forms.Panel();
            this.favoriteMovie_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.close_pb = new System.Windows.Forms.PictureBox();
            this.minimize_pb = new System.Windows.Forms.PictureBox();
            this.movie_panel.SuspendLayout();
            this.recentlyAdded_panel.SuspendLayout();
            this.popularmovie_pnl.SuspendLayout();
            this.favoriteMovie_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // movie_panel
            // 
            this.movie_panel.AutoScroll = true;
            this.movie_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.movie_panel.Controls.Add(this.recentlyAdded_panel);
            this.movie_panel.Controls.Add(this.recentlyAdded_lbl);
            this.movie_panel.Controls.Add(this.favorite_lbl);
            this.movie_panel.Controls.Add(this.popularmovie_pnl);
            this.movie_panel.Controls.Add(this.favoriteMovie_panel);
            this.movie_panel.Location = new System.Drawing.Point(25, 47);
            this.movie_panel.Name = "movie_panel";
            this.movie_panel.Size = new System.Drawing.Size(1382, 695);
            this.movie_panel.TabIndex = 62;
            // 
            // recentlyAdded_panel
            // 
            this.recentlyAdded_panel.BackColor = System.Drawing.Color.Gray;
            this.recentlyAdded_panel.Controls.Add(this.recentlyAdded_flp);
            this.recentlyAdded_panel.Location = new System.Drawing.Point(52, 526);
            this.recentlyAdded_panel.Name = "recentlyAdded_panel";
            this.recentlyAdded_panel.Size = new System.Drawing.Size(1279, 269);
            this.recentlyAdded_panel.TabIndex = 61;
            // 
            // recentlyAdded_flp
            // 
            this.recentlyAdded_flp.AutoScroll = true;
            this.recentlyAdded_flp.BackColor = System.Drawing.Color.White;
            this.recentlyAdded_flp.Location = new System.Drawing.Point(30, 13);
            this.recentlyAdded_flp.Name = "recentlyAdded_flp";
            this.recentlyAdded_flp.Padding = new System.Windows.Forms.Padding(5);
            this.recentlyAdded_flp.Size = new System.Drawing.Size(1219, 236);
            this.recentlyAdded_flp.TabIndex = 0;
            this.recentlyAdded_flp.WrapContents = false;
            // 
            // recentlyAdded_lbl
            // 
            this.recentlyAdded_lbl.AutoSize = true;
            this.recentlyAdded_lbl.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.recentlyAdded_lbl.ForeColor = System.Drawing.Color.White;
            this.recentlyAdded_lbl.Location = new System.Drawing.Point(49, 489);
            this.recentlyAdded_lbl.Name = "recentlyAdded_lbl";
            this.recentlyAdded_lbl.Size = new System.Drawing.Size(234, 31);
            this.recentlyAdded_lbl.TabIndex = 68;
            this.recentlyAdded_lbl.Text = "Recently searched...";
            // 
            // favorite_lbl
            // 
            this.favorite_lbl.AutoSize = true;
            this.favorite_lbl.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.favorite_lbl.ForeColor = System.Drawing.Color.White;
            this.favorite_lbl.Location = new System.Drawing.Point(46, 50);
            this.favorite_lbl.Name = "favorite_lbl";
            this.favorite_lbl.Size = new System.Drawing.Size(177, 31);
            this.favorite_lbl.TabIndex = 65;
            this.favorite_lbl.Text = "Your favorite...";
            // 
            // popularmovie_pnl
            // 
            this.popularmovie_pnl.BackColor = System.Drawing.Color.Gray;
            this.popularmovie_pnl.Controls.Add(this.recentlysearch_flp);
            this.popularmovie_pnl.Location = new System.Drawing.Point(49, 721);
            this.popularmovie_pnl.Name = "popularmovie_pnl";
            this.popularmovie_pnl.Size = new System.Drawing.Size(1279, 255);
            this.popularmovie_pnl.TabIndex = 63;
            // 
            // recentlysearch_flp
            // 
            this.recentlysearch_flp.BackColor = System.Drawing.Color.White;
            this.recentlysearch_flp.Location = new System.Drawing.Point(30, 13);
            this.recentlysearch_flp.Name = "recentlysearch_flp";
            this.recentlysearch_flp.Size = new System.Drawing.Size(1219, 229);
            this.recentlysearch_flp.TabIndex = 0;
            // 
            // favoriteMovie_panel
            // 
            this.favoriteMovie_panel.BackColor = System.Drawing.Color.Gray;
            this.favoriteMovie_panel.Controls.Add(this.favoriteMovie_flp);
            this.favoriteMovie_panel.Location = new System.Drawing.Point(49, 87);
            this.favoriteMovie_panel.Name = "favoriteMovie_panel";
            this.favoriteMovie_panel.Size = new System.Drawing.Size(1279, 381);
            this.favoriteMovie_panel.TabIndex = 60;
            // 
            // favoriteMovie_flp
            // 
            this.favoriteMovie_flp.AutoScroll = true;
            this.favoriteMovie_flp.BackColor = System.Drawing.Color.White;
            this.favoriteMovie_flp.Location = new System.Drawing.Point(30, 13);
            this.favoriteMovie_flp.Name = "favoriteMovie_flp";
            this.favoriteMovie_flp.Padding = new System.Windows.Forms.Padding(5);
            this.favoriteMovie_flp.Size = new System.Drawing.Size(1219, 348);
            this.favoriteMovie_flp.TabIndex = 0;
            this.favoriteMovie_flp.WrapContents = false;
            // 
            // close_pb
            // 
            this.close_pb.BackColor = System.Drawing.Color.Transparent;
            this.close_pb.Image = global::OOP_Project.Properties.Resources.icons8_close_24;
            this.close_pb.Location = new System.Drawing.Point(1386, 12);
            this.close_pb.Name = "close_pb";
            this.close_pb.Size = new System.Drawing.Size(25, 23);
            this.close_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_pb.TabIndex = 63;
            this.close_pb.TabStop = false;
            this.close_pb.Click += new System.EventHandler(this.close_pb_Click);
            // 
            // minimize_pb
            // 
            this.minimize_pb.BackColor = System.Drawing.Color.Transparent;
            this.minimize_pb.Image = global::OOP_Project.Properties.Resources.icons8_minimize_24;
            this.minimize_pb.Location = new System.Drawing.Point(1357, 12);
            this.minimize_pb.Name = "minimize_pb";
            this.minimize_pb.Size = new System.Drawing.Size(25, 23);
            this.minimize_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_pb.TabIndex = 64;
            this.minimize_pb.TabStop = false;
            this.minimize_pb.Click += new System.EventHandler(this.minimize_pb_Click);
            // 
            // favorite_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1423, 754);
            this.Controls.Add(this.close_pb);
            this.Controls.Add(this.minimize_pb);
            this.Controls.Add(this.movie_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "favorite_form";
            this.Text = "c";
            this.Load += new System.EventHandler(this.favorite_form_Load);
            this.movie_panel.ResumeLayout(false);
            this.movie_panel.PerformLayout();
            this.recentlyAdded_panel.ResumeLayout(false);
            this.popularmovie_pnl.ResumeLayout(false);
            this.favoriteMovie_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel movie_panel;
        private System.Windows.Forms.Label favorite_lbl;
        private System.Windows.Forms.Panel popularmovie_pnl;
        private System.Windows.Forms.FlowLayoutPanel recentlysearch_flp;
        private System.Windows.Forms.Panel favoriteMovie_panel;
        private System.Windows.Forms.FlowLayoutPanel favoriteMovie_flp;
        private System.Windows.Forms.Panel recentlyAdded_panel;
        private System.Windows.Forms.FlowLayoutPanel recentlyAdded_flp;
        private System.Windows.Forms.Label recentlyAdded_lbl;
        private System.Windows.Forms.PictureBox close_pb;
        private System.Windows.Forms.PictureBox minimize_pb;
    }
}