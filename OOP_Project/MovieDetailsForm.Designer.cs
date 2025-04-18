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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.posterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls_pb)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Black;
            this.title_lbl.Location = new System.Drawing.Point(3, 18);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(143, 32);
            this.title_lbl.TabIndex = 15;
            this.title_lbl.Text = "movie.title";
            // 
            // genre_lbl
            // 
            this.genre_lbl.AutoSize = true;
            this.genre_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_lbl.ForeColor = System.Drawing.Color.Black;
            this.genre_lbl.Location = new System.Drawing.Point(3, 60);
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
            this.releaseDate_lbl.ForeColor = System.Drawing.Color.Black;
            this.releaseDate_lbl.Location = new System.Drawing.Point(3, 75);
            this.releaseDate_lbl.Name = "releaseDate_lbl";
            this.releaseDate_lbl.Size = new System.Drawing.Size(147, 15);
            this.releaseDate_lbl.TabIndex = 19;
            this.releaseDate_lbl.Text = "movie.releaseyear.string();";
            // 
            // description_txt
            // 
            this.description_txt.BackColor = System.Drawing.Color.DarkGray;
            this.description_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description_txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_txt.ForeColor = System.Drawing.Color.White;
            this.description_txt.Location = new System.Drawing.Point(6, 104);
            this.description_txt.Name = "description_txt";
            this.description_txt.ReadOnly = true;
            this.description_txt.Size = new System.Drawing.Size(275, 193);
            this.description_txt.TabIndex = 20;
            this.description_txt.Text = "movie.description";
            // 
            // posterBox
            // 
            this.posterBox.BackColor = System.Drawing.Color.Black;
            this.posterBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.posterBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.posterBox.Location = new System.Drawing.Point(445, 42);
            this.posterBox.Name = "posterBox";
            this.posterBox.Size = new System.Drawing.Size(227, 304);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 358);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImage = global::OOP_Project.Properties.Resources._1_2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.releaseDate_lbl);
            this.panel3.Controls.Add(this.title_lbl);
            this.panel3.Controls.Add(this.genre_lbl);
            this.panel3.Controls.Add(this.description_txt);
            this.panel3.Location = new System.Drawing.Point(156, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 304);
            this.panel3.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play Trailer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Feedback";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // MovieDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::OOP_Project.Properties.Resources._112;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 358);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.posterBox);
            this.Controls.Add(this.cls_pb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieDetailsForm";
            this.Text = "MovieDetailsForm";
            this.Load += new System.EventHandler(this.MovieDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls_pb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox cls_pb;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label genre_lbl;
        private System.Windows.Forms.Label releaseDate_lbl;
        private System.Windows.Forms.RichTextBox description_txt;
        private System.Windows.Forms.PictureBox posterBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}