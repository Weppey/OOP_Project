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
            this.title_lbl = new System.Windows.Forms.Label();
            this.genre_lbl = new System.Windows.Forms.Label();
            this.releaseDate_lbl = new System.Windows.Forms.Label();
            this.description_txt = new System.Windows.Forms.RichTextBox();
            this.posterBox = new System.Windows.Forms.PictureBox();
            this.cls_pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.posterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.White;
            this.title_lbl.Location = new System.Drawing.Point(122, 52);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(143, 32);
            this.title_lbl.TabIndex = 15;
            this.title_lbl.Text = "movie.title";
            // 
            // genre_lbl
            // 
            this.genre_lbl.AutoSize = true;
            this.genre_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_lbl.ForeColor = System.Drawing.Color.White;
            this.genre_lbl.Location = new System.Drawing.Point(122, 94);
            this.genre_lbl.Name = "genre_lbl";
            this.genre_lbl.Size = new System.Drawing.Size(72, 15);
            this.genre_lbl.TabIndex = 16;
            this.genre_lbl.Text = "movie.genre";
            this.genre_lbl.Click += new System.EventHandler(this.genre_lbl_Click);
            // 
            // releaseDate_lbl
            // 
            this.releaseDate_lbl.AutoSize = true;
            this.releaseDate_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDate_lbl.ForeColor = System.Drawing.Color.White;
            this.releaseDate_lbl.Location = new System.Drawing.Point(122, 109);
            this.releaseDate_lbl.Name = "releaseDate_lbl";
            this.releaseDate_lbl.Size = new System.Drawing.Size(147, 15);
            this.releaseDate_lbl.TabIndex = 19;
            this.releaseDate_lbl.Text = "movie.releaseyear.string();";
            // 
            // description_txt
            // 
            this.description_txt.BackColor = System.Drawing.Color.DimGray;
            this.description_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description_txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_txt.ForeColor = System.Drawing.Color.White;
            this.description_txt.Location = new System.Drawing.Point(125, 138);
            this.description_txt.Name = "description_txt";
            this.description_txt.Size = new System.Drawing.Size(215, 198);
            this.description_txt.TabIndex = 20;
            this.description_txt.Text = "movie.description";
            // 
            // posterBox
            // 
            this.posterBox.BackColor = System.Drawing.Color.Transparent;
            this.posterBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.posterBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.posterBox.Location = new System.Drawing.Point(359, 56);
            this.posterBox.Name = "posterBox";
            this.posterBox.Size = new System.Drawing.Size(238, 279);
            this.posterBox.TabIndex = 21;
            this.posterBox.TabStop = false;
            // 
            // cls_pb
            // 
            this.cls_pb.BackColor = System.Drawing.Color.Transparent;
            this.cls_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cls_pb.Image = global::OOP_Project.Properties.Resources.icons8_close_24;
            this.cls_pb.Location = new System.Drawing.Point(700, 12);
            this.cls_pb.Name = "cls_pb";
            this.cls_pb.Size = new System.Drawing.Size(25, 23);
            this.cls_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cls_pb.TabIndex = 12;
            this.cls_pb.TabStop = false;
            this.cls_pb.Click += new System.EventHandler(this.cls_pb_Click);
            // 
            // MovieDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::OOP_Project.Properties.Resources._1_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(737, 358);
            this.Controls.Add(this.posterBox);
            this.Controls.Add(this.description_txt);
            this.Controls.Add(this.releaseDate_lbl);
            this.Controls.Add(this.genre_lbl);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.cls_pb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieDetailsForm";
            this.Text = "MovieDetailsForm";
            this.Load += new System.EventHandler(this.MovieDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox cls_pb;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label genre_lbl;
        private System.Windows.Forms.Label releaseDate_lbl;
        private System.Windows.Forms.RichTextBox description_txt;
        private System.Windows.Forms.PictureBox posterBox;
    }
}