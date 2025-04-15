namespace OOP_Project
{
    partial class movie_details_form
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
            this.poster_pb = new System.Windows.Forms.PictureBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.genre_chklb = new System.Windows.Forms.CheckedListBox();
            this.releaseDate_lbl = new System.Windows.Forms.Label();
            this.description_lbl = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.comment_tb = new System.Windows.Forms.TextBox();
            this.comment_lbl = new System.Windows.Forms.Label();
            this.rating_cmb = new System.Windows.Forms.ComboBox();
            this.rating_lbl = new System.Windows.Forms.Label();
            this.remove_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.poster_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // poster_pb
            // 
            this.poster_pb.Location = new System.Drawing.Point(30, 30);
            this.poster_pb.Name = "poster_pb";
            this.poster_pb.Size = new System.Drawing.Size(180, 217);
            this.poster_pb.TabIndex = 0;
            this.poster_pb.TabStop = false;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(25, 259);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(55, 26);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "Title";
            // 
            // genre_chklb
            // 
            this.genre_chklb.FormattingEnabled = true;
            this.genre_chklb.Location = new System.Drawing.Point(30, 288);
            this.genre_chklb.Name = "genre_chklb";
            this.genre_chklb.Size = new System.Drawing.Size(180, 49);
            this.genre_chklb.TabIndex = 3;
            // 
            // releaseDate_lbl
            // 
            this.releaseDate_lbl.AutoSize = true;
            this.releaseDate_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.releaseDate_lbl.Location = new System.Drawing.Point(25, 340);
            this.releaseDate_lbl.Name = "releaseDate_lbl";
            this.releaseDate_lbl.Size = new System.Drawing.Size(113, 22);
            this.releaseDate_lbl.TabIndex = 4;
            this.releaseDate_lbl.Text = "Release Date";
            // 
            // description_lbl
            // 
            this.description_lbl.AutoSize = true;
            this.description_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.description_lbl.Location = new System.Drawing.Point(26, 362);
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Size = new System.Drawing.Size(102, 22);
            this.description_lbl.TabIndex = 5;
            this.description_lbl.Text = "description";
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(685, 428);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(75, 36);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // comment_tb
            // 
            this.comment_tb.Location = new System.Drawing.Point(462, 288);
            this.comment_tb.Name = "comment_tb";
            this.comment_tb.Size = new System.Drawing.Size(100, 20);
            this.comment_tb.TabIndex = 7;
            // 
            // comment_lbl
            // 
            this.comment_lbl.AutoSize = true;
            this.comment_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.comment_lbl.Location = new System.Drawing.Point(369, 285);
            this.comment_lbl.Name = "comment_lbl";
            this.comment_lbl.Size = new System.Drawing.Size(87, 22);
            this.comment_lbl.TabIndex = 8;
            this.comment_lbl.Text = "comment";
            // 
            // rating_cmb
            // 
            this.rating_cmb.FormattingEnabled = true;
            this.rating_cmb.Location = new System.Drawing.Point(387, 144);
            this.rating_cmb.Name = "rating_cmb";
            this.rating_cmb.Size = new System.Drawing.Size(121, 21);
            this.rating_cmb.TabIndex = 9;
            // 
            // rating_lbl
            // 
            this.rating_lbl.AutoSize = true;
            this.rating_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.rating_lbl.Location = new System.Drawing.Point(335, 143);
            this.rating_lbl.Name = "rating_lbl";
            this.rating_lbl.Size = new System.Drawing.Size(46, 22);
            this.rating_lbl.TabIndex = 10;
            this.rating_lbl.Text = "Rate";
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(604, 428);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(75, 36);
            this.remove_btn.TabIndex = 11;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // movie_details_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 539);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.rating_lbl);
            this.Controls.Add(this.rating_cmb);
            this.Controls.Add(this.comment_lbl);
            this.Controls.Add(this.comment_tb);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.description_lbl);
            this.Controls.Add(this.releaseDate_lbl);
            this.Controls.Add(this.genre_chklb);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.poster_pb);
            this.Name = "movie_details_form";
            this.Text = "movie_details_form";
            ((System.ComponentModel.ISupportInitialize)(this.poster_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox poster_pb;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.CheckedListBox genre_chklb;
        private System.Windows.Forms.Label releaseDate_lbl;
        private System.Windows.Forms.Label description_lbl;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.TextBox comment_tb;
        private System.Windows.Forms.Label comment_lbl;
        private System.Windows.Forms.ComboBox rating_cmb;
        private System.Windows.Forms.Label rating_lbl;
        private System.Windows.Forms.Button remove_btn;
    }
}