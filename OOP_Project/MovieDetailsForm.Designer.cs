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
            this.min_pb = new System.Windows.Forms.PictureBox();
            this.cls_pb = new System.Windows.Forms.PictureBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.genre_lbl = new System.Windows.Forms.Label();
            this.releaseDate_lbl = new System.Windows.Forms.Label();
            this.decrition_txt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.min_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // min_pb
            // 
            this.min_pb.BackColor = System.Drawing.Color.Transparent;
            this.min_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.min_pb.Image = global::OOP_Project.Properties.Resources.icons8_minimize_24;
            this.min_pb.Location = new System.Drawing.Point(671, 12);
            this.min_pb.Name = "min_pb";
            this.min_pb.Size = new System.Drawing.Size(25, 23);
            this.min_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.min_pb.TabIndex = 13;
            this.min_pb.TabStop = false;
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
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.ForeColor = System.Drawing.Color.White;
            this.title_lbl.Location = new System.Drawing.Point(160, 87);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(54, 13);
            this.title_lbl.TabIndex = 15;
            this.title_lbl.Text = "movie.title";
            // 
            // genre_lbl
            // 
            this.genre_lbl.AutoSize = true;
            this.genre_lbl.ForeColor = System.Drawing.Color.White;
            this.genre_lbl.Location = new System.Drawing.Point(160, 142);
            this.genre_lbl.Name = "genre_lbl";
            this.genre_lbl.Size = new System.Drawing.Size(65, 13);
            this.genre_lbl.TabIndex = 16;
            this.genre_lbl.Text = "movie.genre";
            // 
            // releaseDate_lbl
            // 
            this.releaseDate_lbl.AutoSize = true;
            this.releaseDate_lbl.ForeColor = System.Drawing.Color.White;
            this.releaseDate_lbl.Location = new System.Drawing.Point(160, 204);
            this.releaseDate_lbl.Name = "releaseDate_lbl";
            this.releaseDate_lbl.Size = new System.Drawing.Size(129, 13);
            this.releaseDate_lbl.TabIndex = 19;
            this.releaseDate_lbl.Text = "movie.releaseyear.string();";
            // 
            // decrition_txt
            // 
            this.decrition_txt.Location = new System.Drawing.Point(434, 84);
            this.decrition_txt.Name = "decrition_txt";
            this.decrition_txt.Size = new System.Drawing.Size(180, 142);
            this.decrition_txt.TabIndex = 20;
            this.decrition_txt.Text = "movie.description";
            // 
            // MovieDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(737, 358);
            this.Controls.Add(this.decrition_txt);
            this.Controls.Add(this.releaseDate_lbl);
            this.Controls.Add(this.genre_lbl);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.min_pb);
            this.Controls.Add(this.cls_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieDetailsForm";
            this.Text = "MovieDetailsForm";
            this.Load += new System.EventHandler(this.MovieDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.min_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox min_pb;
        private System.Windows.Forms.PictureBox cls_pb;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label genre_lbl;
        private System.Windows.Forms.Label releaseDate_lbl;
        private System.Windows.Forms.RichTextBox decrition_txt;
    }
}