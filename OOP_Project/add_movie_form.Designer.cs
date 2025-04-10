namespace OOP_Project
{
    partial class add_movie_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_movie_form));
            this.topdock_panel = new System.Windows.Forms.Panel();
            this.minimize_pb = new System.Windows.Forms.PictureBox();
            this.close_pb = new System.Windows.Forms.PictureBox();
            this.insert_panel = new System.Windows.Forms.Panel();
            this.Pb_logo = new System.Windows.Forms.PictureBox();
            this.releaseyear_lbl = new System.Windows.Forms.Label();
            this.releaseY_tb = new System.Windows.Forms.TextBox();
            this.poster_pb = new System.Windows.Forms.PictureBox();
            this.genre_clb = new System.Windows.Forms.CheckedListBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.url_lbl = new System.Windows.Forms.Label();
            this.url_tb = new System.Windows.Forms.TextBox();
            this.desc_lbl = new System.Windows.Forms.Label();
            this.desc_tb = new System.Windows.Forms.TextBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.topdock_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).BeginInit();
            this.insert_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poster_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // topdock_panel
            // 
            this.topdock_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.topdock_panel.Controls.Add(this.minimize_pb);
            this.topdock_panel.Controls.Add(this.close_pb);
            this.topdock_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topdock_panel.Location = new System.Drawing.Point(0, 0);
            this.topdock_panel.Name = "topdock_panel";
            this.topdock_panel.Size = new System.Drawing.Size(870, 38);
            this.topdock_panel.TabIndex = 0;
            // 
            // minimize_pb
            // 
            this.minimize_pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(11)))), ((int)(((byte)(15)))));
            this.minimize_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimize_pb.Image = global::OOP_Project.Properties.Resources.icons8_minimize_48;
            this.minimize_pb.Location = new System.Drawing.Point(808, 7);
            this.minimize_pb.Name = "minimize_pb";
            this.minimize_pb.Size = new System.Drawing.Size(25, 23);
            this.minimize_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_pb.TabIndex = 15;
            this.minimize_pb.TabStop = false;
            // 
            // close_pb
            // 
            this.close_pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(11)))), ((int)(((byte)(15)))));
            this.close_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.close_pb.Image = global::OOP_Project.Properties.Resources.icons8_close_48;
            this.close_pb.Location = new System.Drawing.Point(837, 7);
            this.close_pb.Name = "close_pb";
            this.close_pb.Size = new System.Drawing.Size(25, 23);
            this.close_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_pb.TabIndex = 14;
            this.close_pb.TabStop = false;
            // 
            // insert_panel
            // 
            this.insert_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.insert_panel.Controls.Add(this.Pb_logo);
            this.insert_panel.Controls.Add(this.releaseyear_lbl);
            this.insert_panel.Controls.Add(this.releaseY_tb);
            this.insert_panel.Controls.Add(this.poster_pb);
            this.insert_panel.Controls.Add(this.genre_clb);
            this.insert_panel.Controls.Add(this.clear_btn);
            this.insert_panel.Controls.Add(this.insert_btn);
            this.insert_panel.Controls.Add(this.url_lbl);
            this.insert_panel.Controls.Add(this.url_tb);
            this.insert_panel.Controls.Add(this.desc_lbl);
            this.insert_panel.Controls.Add(this.desc_tb);
            this.insert_panel.Controls.Add(this.title_lbl);
            this.insert_panel.Controls.Add(this.title_tb);
            this.insert_panel.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_panel.Location = new System.Drawing.Point(12, 44);
            this.insert_panel.Name = "insert_panel";
            this.insert_panel.Size = new System.Drawing.Size(846, 454);
            this.insert_panel.TabIndex = 1;
            // 
            // Pb_logo
            // 
            this.Pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pb_logo.Image")));
            this.Pb_logo.Location = new System.Drawing.Point(369, 50);
            this.Pb_logo.Name = "Pb_logo";
            this.Pb_logo.Size = new System.Drawing.Size(100, 50);
            this.Pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_logo.TabIndex = 40;
            this.Pb_logo.TabStop = false;
            this.Pb_logo.Click += new System.EventHandler(this.Pb_logo_Click);
            // 
            // releaseyear_lbl
            // 
            this.releaseyear_lbl.AutoSize = true;
            this.releaseyear_lbl.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseyear_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.releaseyear_lbl.Location = new System.Drawing.Point(101, 310);
            this.releaseyear_lbl.Name = "releaseyear_lbl";
            this.releaseyear_lbl.Size = new System.Drawing.Size(83, 17);
            this.releaseyear_lbl.TabIndex = 53;
            this.releaseyear_lbl.Text = "Release Date:";
            // 
            // releaseY_tb
            // 
            this.releaseY_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.releaseY_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.releaseY_tb.Font = new System.Drawing.Font("Arial", 10F);
            this.releaseY_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.releaseY_tb.Location = new System.Drawing.Point(190, 304);
            this.releaseY_tb.Name = "releaseY_tb";
            this.releaseY_tb.Size = new System.Drawing.Size(202, 23);
            this.releaseY_tb.TabIndex = 52;
            // 
            // poster_pb
            // 
            this.poster_pb.Location = new System.Drawing.Point(525, 180);
            this.poster_pb.Name = "poster_pb";
            this.poster_pb.Size = new System.Drawing.Size(158, 172);
            this.poster_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poster_pb.TabIndex = 51;
            this.poster_pb.TabStop = false;
            this.poster_pb.Click += new System.EventHandler(this.poster_pb_Click);
            // 
            // genre_clb
            // 
            this.genre_clb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.genre_clb.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_clb.ForeColor = System.Drawing.SystemColors.Info;
            this.genre_clb.FormattingEnabled = true;
            this.genre_clb.Location = new System.Drawing.Point(190, 333);
            this.genre_clb.MultiColumn = true;
            this.genre_clb.Name = "genre_clb";
            this.genre_clb.Size = new System.Drawing.Size(202, 84);
            this.genre_clb.TabIndex = 50;
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(525, 377);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 27);
            this.clear_btn.TabIndex = 11;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(608, 377);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 27);
            this.insert_btn.TabIndex = 10;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click_1);
            // 
            // url_lbl
            // 
            this.url_lbl.AutoSize = true;
            this.url_lbl.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.url_lbl.Location = new System.Drawing.Point(455, 147);
            this.url_lbl.Name = "url_lbl";
            this.url_lbl.Size = new System.Drawing.Size(64, 17);
            this.url_lbl.TabIndex = 7;
            this.url_lbl.Text = "Movie URL:";
            // 
            // url_tb
            // 
            this.url_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.url_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.url_tb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.url_tb.Location = new System.Drawing.Point(525, 139);
            this.url_tb.Name = "url_tb";
            this.url_tb.Size = new System.Drawing.Size(158, 25);
            this.url_tb.TabIndex = 6;
            this.url_tb.TextChanged += new System.EventHandler(this.url_tb_TextChanged_1);
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.desc_lbl.Location = new System.Drawing.Point(101, 182);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(75, 17);
            this.desc_lbl.TabIndex = 5;
            this.desc_lbl.Text = "Description:";
            // 
            // desc_tb
            // 
            this.desc_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.desc_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desc_tb.Font = new System.Drawing.Font("Arial", 10F);
            this.desc_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.desc_tb.Location = new System.Drawing.Point(190, 180);
            this.desc_tb.Multiline = true;
            this.desc_tb.Name = "desc_tb";
            this.desc_tb.Size = new System.Drawing.Size(202, 118);
            this.desc_tb.TabIndex = 4;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.title_lbl.Location = new System.Drawing.Point(101, 145);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(70, 17);
            this.title_lbl.TabIndex = 3;
            this.title_lbl.Text = "Movie Title:";
            // 
            // title_tb
            // 
            this.title_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.title_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title_tb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.title_tb.Location = new System.Drawing.Point(190, 139);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(202, 25);
            this.title_tb.TabIndex = 2;
            // 
            // add_movie_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(870, 510);
            this.Controls.Add(this.insert_panel);
            this.Controls.Add(this.topdock_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_movie_form";
            this.Text = "add_movie_form";
            this.Load += new System.EventHandler(this.add_movie_form_Load_1);
            this.topdock_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).EndInit();
            this.insert_panel.ResumeLayout(false);
            this.insert_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poster_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topdock_panel;
        private System.Windows.Forms.Panel insert_panel;
        private System.Windows.Forms.PictureBox minimize_pb;
        private System.Windows.Forms.PictureBox close_pb;
        private System.Windows.Forms.Label url_lbl;
        private System.Windows.Forms.TextBox url_tb;
        private System.Windows.Forms.Label desc_lbl;
        private System.Windows.Forms.TextBox desc_tb;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.CheckedListBox genre_clb;
        private System.Windows.Forms.PictureBox poster_pb;
        private System.Windows.Forms.Label releaseyear_lbl;
        private System.Windows.Forms.TextBox releaseY_tb;
        private System.Windows.Forms.PictureBox Pb_logo;
    }
}