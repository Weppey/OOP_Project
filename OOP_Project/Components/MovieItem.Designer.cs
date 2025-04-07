namespace OOP_Project.Components
{
    partial class MovieItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.movie_panel = new System.Windows.Forms.Panel();
            this.description_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.poster_pb = new System.Windows.Forms.PictureBox();
            this.movie_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // movie_panel
            // 
            this.movie_panel.BackColor = System.Drawing.Color.White;
            this.movie_panel.Controls.Add(this.description_lbl);
            this.movie_panel.Controls.Add(this.title_lbl);
            this.movie_panel.Controls.Add(this.poster_pb);
            this.movie_panel.Location = new System.Drawing.Point(16, 30);
            this.movie_panel.Name = "movie_panel";
            this.movie_panel.Size = new System.Drawing.Size(178, 268);
            this.movie_panel.TabIndex = 45;
            // 
            // description_lbl
            // 
            this.description_lbl.AutoSize = true;
            this.description_lbl.BackColor = System.Drawing.Color.Black;
            this.description_lbl.Font = new System.Drawing.Font("Bebas Neue", 12F);
            this.description_lbl.ForeColor = System.Drawing.Color.White;
            this.description_lbl.Location = new System.Drawing.Point(13, 233);
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Size = new System.Drawing.Size(71, 19);
            this.description_lbl.TabIndex = 47;
            this.description_lbl.Text = "description";
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.BackColor = System.Drawing.Color.Black;
            this.title_lbl.Font = new System.Drawing.Font("Bebas Neue", 12F);
            this.title_lbl.ForeColor = System.Drawing.Color.White;
            this.title_lbl.Location = new System.Drawing.Point(13, 203);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(35, 19);
            this.title_lbl.TabIndex = 46;
            this.title_lbl.Text = "Title";
            // 
            // poster_pb
            // 
            this.poster_pb.BackColor = System.Drawing.Color.Black;
            this.poster_pb.Location = new System.Drawing.Point(17, 16);
            this.poster_pb.Name = "poster_pb";
            this.poster_pb.Size = new System.Drawing.Size(149, 172);
            this.poster_pb.TabIndex = 45;
            this.poster_pb.TabStop = false;
            // 
            // MovieItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.movie_panel);
            this.Name = "MovieItem";
            this.Size = new System.Drawing.Size(208, 312);
            this.movie_panel.ResumeLayout(false);
            this.movie_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel movie_panel;
        private System.Windows.Forms.Label description_lbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.PictureBox poster_pb;
    }
}
