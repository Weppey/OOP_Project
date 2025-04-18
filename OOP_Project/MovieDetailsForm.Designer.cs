namespace OOP_Project
{
    partial class MovieDetailsForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comment_lbl = new System.Windows.Forms.Label();
            this.user_lbl = new System.Windows.Forms.Label();
            this.close_pb = new System.Windows.Forms.PictureBox();
            this.panelTest = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.comment_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.favorite_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.genre_lbl = new System.Windows.Forms.Label();
            this.description_lbl = new System.Windows.Forms.Label();
            this.poster_pb = new System.Windows.Forms.PictureBox();
            this.dateRelease_lbl = new System.Windows.Forms.Label();
            this.movieTrailer_panel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).BeginInit();
            this.panelTest.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(77, 648);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(909, 106);
            this.flowLayoutPanel1.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comment_lbl);
            this.panel1.Controls.Add(this.user_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 61);
            this.panel1.TabIndex = 0;
            // 
            // comment_lbl
            // 
            this.comment_lbl.AutoSize = true;
            this.comment_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comment_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comment_lbl.Location = new System.Drawing.Point(72, 13);
            this.comment_lbl.Name = "comment_lbl";
            this.comment_lbl.Size = new System.Drawing.Size(57, 15);
            this.comment_lbl.TabIndex = 31;
            this.comment_lbl.Text = "Comment";
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.user_lbl.Location = new System.Drawing.Point(9, 9);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(57, 19);
            this.user_lbl.TabIndex = 30;
            this.user_lbl.Text = "UserID:";
            // 
            // close_pb
            // 
            this.close_pb.BackColor = System.Drawing.Color.Transparent;
            this.close_pb.Image = global::OOP_Project.Properties.Resources.icons8_close_24;
            this.close_pb.Location = new System.Drawing.Point(1006, 14);
            this.close_pb.Name = "close_pb";
            this.close_pb.Size = new System.Drawing.Size(25, 23);
            this.close_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_pb.TabIndex = 18;
            this.close_pb.TabStop = false;
            this.close_pb.Click += new System.EventHandler(this.close_pb_Click);
            // 
            // panelTest
            // 
            this.panelTest.Controls.Add(this.title_lbl);
            this.panelTest.Controls.Add(this.comment_btn);
            this.panelTest.Controls.Add(this.favorite_btn);
            this.panelTest.Controls.Add(this.panel2);
            this.panelTest.Controls.Add(this.movieTrailer_panel);
            this.panelTest.Location = new System.Drawing.Point(40, 40);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(980, 558);
            this.panelTest.TabIndex = 66;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.title_lbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title_lbl.Location = new System.Drawing.Point(61, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Padding = new System.Windows.Forms.Padding(12);
            this.title_lbl.Size = new System.Drawing.Size(98, 60);
            this.title_lbl.TabIndex = 65;
            this.title_lbl.Text = "Title";
            // 
            // comment_btn
            // 
            this.comment_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.comment_btn.Location = new System.Drawing.Point(649, 491);
            this.comment_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.comment_btn.Name = "comment_btn";
            this.comment_btn.Size = new System.Drawing.Size(132, 45);
            this.comment_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.comment_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.comment_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comment_btn.StateCommon.Border.Rounding = 20;
            this.comment_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.comment_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.comment_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.comment_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comment_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comment_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comment_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comment_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comment_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comment_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comment_btn.TabIndex = 69;
            this.comment_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_comments_28;
            this.comment_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.comment_btn.Values.Text = "Comments";
            // 
            // favorite_btn
            // 
            this.favorite_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.favorite_btn.Location = new System.Drawing.Point(804, 491);
            this.favorite_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.favorite_btn.Name = "favorite_btn";
            this.favorite_btn.Size = new System.Drawing.Size(132, 45);
            this.favorite_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.favorite_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.favorite_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.favorite_btn.StateCommon.Border.Rounding = 20;
            this.favorite_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.favorite_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.favorite_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.favorite_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.favorite_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.favorite_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.favorite_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.favorite_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.favorite_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.favorite_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.favorite_btn.TabIndex = 68;
            this.favorite_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_favorite_folder_28;
            this.favorite_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.favorite_btn.Values.Text = "Add to favorite";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel2.Controls.Add(this.genre_lbl);
            this.panel2.Controls.Add(this.description_lbl);
            this.panel2.Controls.Add(this.poster_pb);
            this.panel2.Controls.Add(this.dateRelease_lbl);
            this.panel2.Location = new System.Drawing.Point(45, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 467);
            this.panel2.TabIndex = 67;
            // 
            // genre_lbl
            // 
            this.genre_lbl.AutoSize = true;
            this.genre_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.genre_lbl.Location = new System.Drawing.Point(17, 274);
            this.genre_lbl.Name = "genre_lbl";
            this.genre_lbl.Size = new System.Drawing.Size(46, 19);
            this.genre_lbl.TabIndex = 29;
            this.genre_lbl.Text = "Genre";
            // 
            // description_lbl
            // 
            this.description_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.description_lbl.Location = new System.Drawing.Point(17, 329);
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Size = new System.Drawing.Size(171, 125);
            this.description_lbl.TabIndex = 27;
            this.description_lbl.Text = "Description";
            // 
            // poster_pb
            // 
            this.poster_pb.BackColor = System.Drawing.Color.White;
            this.poster_pb.Location = new System.Drawing.Point(22, 19);
            this.poster_pb.Name = "poster_pb";
            this.poster_pb.Size = new System.Drawing.Size(166, 221);
            this.poster_pb.TabIndex = 25;
            this.poster_pb.TabStop = false;
            // 
            // dateRelease_lbl
            // 
            this.dateRelease_lbl.AutoSize = true;
            this.dateRelease_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRelease_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateRelease_lbl.Location = new System.Drawing.Point(17, 255);
            this.dateRelease_lbl.Name = "dateRelease_lbl";
            this.dateRelease_lbl.Size = new System.Drawing.Size(89, 19);
            this.dateRelease_lbl.TabIndex = 28;
            this.dateRelease_lbl.Text = "Date Release";
            // 
            // movieTrailer_panel
            // 
            this.movieTrailer_panel.BackColor = System.Drawing.Color.White;
            this.movieTrailer_panel.Location = new System.Drawing.Point(293, 82);
            this.movieTrailer_panel.Name = "movieTrailer_panel";
            this.movieTrailer_panel.Size = new System.Drawing.Size(643, 386);
            this.movieTrailer_panel.TabIndex = 66;
            // 
            // MovieDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 620);
            this.Controls.Add(this.panelTest);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.close_pb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieDetailsForm";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 15;
            this.Text = "MovieDetailsForm";
            this.Load += new System.EventHandler(this.MovieDetailsForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).EndInit();
            this.panelTest.ResumeLayout(false);
            this.panelTest.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox close_pb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label comment_lbl;
        private System.Windows.Forms.Label user_lbl;
        private System.Windows.Forms.Panel panelTest;
        private System.Windows.Forms.Label title_lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonButton comment_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton favorite_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label genre_lbl;
        private System.Windows.Forms.Label description_lbl;
        private System.Windows.Forms.PictureBox poster_pb;
        private System.Windows.Forms.Label dateRelease_lbl;
        private System.Windows.Forms.Panel movieTrailer_panel;
    }
}