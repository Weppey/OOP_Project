namespace OOP_Project
{
    partial class admin_form
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
            this.home_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.movie_panel = new System.Windows.Forms.Panel();
            this.insertMovie_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.submit_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.insertClose_btn = new System.Windows.Forms.PictureBox();
            this.search_list = new System.Windows.Forms.ListBox();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.viewportPanel = new System.Windows.Forms.Panel();
            this.recommendedMovieRight_btn = new System.Windows.Forms.PictureBox();
            this.movieListAdmin_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.insert_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.remove_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_pb = new System.Windows.Forms.PictureBox();
            this.minimize_pb = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.genre_clb = new System.Windows.Forms.CheckedListBox();
            this.release_year = new System.Windows.Forms.Label();
            this.genre_lbl = new System.Windows.Forms.Label();
            this.decription_lbl = new System.Windows.Forms.Label();
            this.decription_tb = new System.Windows.Forms.TextBox();
            this.posterUrl_lbl = new System.Windows.Forms.Label();
            this.url_tb = new System.Windows.Forms.TextBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.movie_panel.SuspendLayout();
            this.insertMovie_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertClose_btn)).BeginInit();
            this.viewportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recommendedMovieRight_btn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // home_btn
            // 
            this.home_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.home_btn.Location = new System.Drawing.Point(1323, 9);
            this.home_btn.Margin = new System.Windows.Forms.Padding(20, 100, 3, 3);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(47, 48);
            this.home_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.home_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.home_btn.StateCommon.Border.Rounding = 20;
            this.home_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.home_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.home_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.home_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.home_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.home_btn.TabIndex = 60;
            this.home_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_home_281;
            this.home_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.home_btn.Values.Text = "";
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // movie_panel
            // 
            this.movie_panel.AutoScroll = true;
            this.movie_panel.AutoSize = true;
            this.movie_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.movie_panel.Controls.Add(this.insertMovie_panel);
            this.movie_panel.Controls.Add(this.search_list);
            this.movie_panel.Controls.Add(this.search_txt);
            this.movie_panel.Controls.Add(this.viewportPanel);
            this.movie_panel.Controls.Add(this.panel2);
            this.movie_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movie_panel.Location = new System.Drawing.Point(0, 0);
            this.movie_panel.Name = "movie_panel";
            this.movie_panel.Size = new System.Drawing.Size(1382, 718);
            this.movie_panel.TabIndex = 61;
            // 
            // insertMovie_panel
            // 
            this.insertMovie_panel.Controls.Add(this.panel3);
            this.insertMovie_panel.Controls.Add(this.label1);
            this.insertMovie_panel.Controls.Add(this.submit_btn);
            this.insertMovie_panel.Controls.Add(this.insertClose_btn);
            this.insertMovie_panel.Location = new System.Drawing.Point(304, 179);
            this.insertMovie_panel.Name = "insertMovie_panel";
            this.insertMovie_panel.Size = new System.Drawing.Size(742, 411);
            this.insertMovie_panel.TabIndex = 71;
            this.insertMovie_panel.Visible = false;
            this.insertMovie_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.insertMovie_panel_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.genre_clb);
            this.panel3.Controls.Add(this.release_year);
            this.panel3.Controls.Add(this.genre_lbl);
            this.panel3.Controls.Add(this.decription_lbl);
            this.panel3.Controls.Add(this.decription_tb);
            this.panel3.Controls.Add(this.posterUrl_lbl);
            this.panel3.Controls.Add(this.url_tb);
            this.panel3.Controls.Add(this.title_lbl);
            this.panel3.Controls.Add(this.title_tb);
            this.panel3.Location = new System.Drawing.Point(34, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 342);
            this.panel3.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Fill up";
            // 
            // submit_btn
            // 
            this.submit_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.submit_btn.Location = new System.Drawing.Point(572, 335);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(132, 45);
            this.submit_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.submit_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.submit_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.submit_btn.StateCommon.Border.Rounding = 20;
            this.submit_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.submit_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.submit_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.submit_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.submit_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.submit_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.submit_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.submit_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.submit_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.submit_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.submit_btn.TabIndex = 67;
            this.submit_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_insert_column_right_28;
            this.submit_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.submit_btn.Values.Text = "Insert";
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // insertClose_btn
            // 
            this.insertClose_btn.BackColor = System.Drawing.Color.Transparent;
            this.insertClose_btn.Image = global::OOP_Project.Properties.Resources.icons8_close_24;
            this.insertClose_btn.Location = new System.Drawing.Point(714, 3);
            this.insertClose_btn.Name = "insertClose_btn";
            this.insertClose_btn.Size = new System.Drawing.Size(25, 23);
            this.insertClose_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.insertClose_btn.TabIndex = 64;
            this.insertClose_btn.TabStop = false;
            this.insertClose_btn.Click += new System.EventHandler(this.insertClose_btn_Click);
            // 
            // search_list
            // 
            this.search_list.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_list.FormattingEnabled = true;
            this.search_list.ItemHeight = 19;
            this.search_list.Location = new System.Drawing.Point(817, 113);
            this.search_list.Name = "search_list";
            this.search_list.Size = new System.Drawing.Size(337, 80);
            this.search_list.TabIndex = 70;
            this.search_list.Visible = false;
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.ForeColor = System.Drawing.Color.Gray;
            this.search_txt.Location = new System.Drawing.Point(817, 90);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(337, 26);
            this.search_txt.TabIndex = 69;
            this.search_txt.Text = "Search...";
            // 
            // viewportPanel
            // 
            this.viewportPanel.BackColor = System.Drawing.Color.Gray;
            this.viewportPanel.Controls.Add(this.recommendedMovieRight_btn);
            this.viewportPanel.Controls.Add(this.movieListAdmin_panel);
            this.viewportPanel.Location = new System.Drawing.Point(166, 122);
            this.viewportPanel.Name = "viewportPanel";
            this.viewportPanel.Size = new System.Drawing.Size(988, 519);
            this.viewportPanel.TabIndex = 68;
            // 
            // recommendedMovieRight_btn
            // 
            this.recommendedMovieRight_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.recommendedMovieRight_btn.Image = global::OOP_Project.Properties.Resources.icons8_right_28;
            this.recommendedMovieRight_btn.Location = new System.Drawing.Point(1252, 13);
            this.recommendedMovieRight_btn.Name = "recommendedMovieRight_btn";
            this.recommendedMovieRight_btn.Size = new System.Drawing.Size(24, 538);
            this.recommendedMovieRight_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recommendedMovieRight_btn.TabIndex = 62;
            this.recommendedMovieRight_btn.TabStop = false;
            // 
            // movieListAdmin_panel
            // 
            this.movieListAdmin_panel.AutoScroll = true;
            this.movieListAdmin_panel.BackColor = System.Drawing.Color.White;
            this.movieListAdmin_panel.Location = new System.Drawing.Point(16, 13);
            this.movieListAdmin_panel.Name = "movieListAdmin_panel";
            this.movieListAdmin_panel.Size = new System.Drawing.Size(960, 538);
            this.movieListAdmin_panel.TabIndex = 0;
            this.movieListAdmin_panel.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.insert_btn);
            this.panel2.Controls.Add(this.remove_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 718);
            this.panel2.TabIndex = 67;
            // 
            // insert_btn
            // 
            this.insert_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.insert_btn.Location = new System.Drawing.Point(0, 243);
            this.insert_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(132, 45);
            this.insert_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.insert_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.insert_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.insert_btn.StateCommon.Border.Rounding = 20;
            this.insert_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.insert_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.insert_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.insert_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.insert_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.insert_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insert_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insert_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insert_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insert_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.insert_btn.TabIndex = 66;
            this.insert_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_insert_column_right_28;
            this.insert_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.insert_btn.Values.Text = "Insert";
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.remove_btn.Location = new System.Drawing.Point(3, 296);
            this.remove_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(132, 45);
            this.remove_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.remove_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.remove_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.remove_btn.StateCommon.Border.Rounding = 20;
            this.remove_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.remove_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.remove_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.remove_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.remove_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.remove_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.remove_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.remove_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.remove_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.remove_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.remove_btn.TabIndex = 65;
            this.remove_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_remove_28;
            this.remove_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.remove_btn.Values.Text = "Remove";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.home_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 60);
            this.panel1.TabIndex = 63;
            // 
            // close_pb
            // 
            this.close_pb.BackColor = System.Drawing.Color.Transparent;
            this.close_pb.Image = global::OOP_Project.Properties.Resources.icons8_close_24;
            this.close_pb.Location = new System.Drawing.Point(1515, 13);
            this.close_pb.Name = "close_pb";
            this.close_pb.Size = new System.Drawing.Size(25, 23);
            this.close_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_pb.TabIndex = 16;
            this.close_pb.TabStop = false;
            // 
            // minimize_pb
            // 
            this.minimize_pb.BackColor = System.Drawing.Color.Transparent;
            this.minimize_pb.Image = global::OOP_Project.Properties.Resources.icons8_minimize_24;
            this.minimize_pb.Location = new System.Drawing.Point(1486, 13);
            this.minimize_pb.Name = "minimize_pb";
            this.minimize_pb.Size = new System.Drawing.Size(25, 23);
            this.minimize_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_pb.TabIndex = 17;
            this.minimize_pb.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 86;
            // 
            // genre_clb
            // 
            this.genre_clb.FormattingEnabled = true;
            this.genre_clb.Location = new System.Drawing.Point(81, 94);
            this.genre_clb.Name = "genre_clb";
            this.genre_clb.Size = new System.Drawing.Size(191, 49);
            this.genre_clb.TabIndex = 85;
            // 
            // release_year
            // 
            this.release_year.AutoSize = true;
            this.release_year.Font = new System.Drawing.Font("Impact", 10F);
            this.release_year.ForeColor = System.Drawing.SystemColors.Control;
            this.release_year.Location = new System.Drawing.Point(30, 156);
            this.release_year.Name = "release_year";
            this.release_year.Size = new System.Drawing.Size(85, 18);
            this.release_year.TabIndex = 84;
            this.release_year.Text = "Release Year:";
            // 
            // genre_lbl
            // 
            this.genre_lbl.AutoSize = true;
            this.genre_lbl.Font = new System.Drawing.Font("Impact", 10F);
            this.genre_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.genre_lbl.Location = new System.Drawing.Point(30, 94);
            this.genre_lbl.Name = "genre_lbl";
            this.genre_lbl.Size = new System.Drawing.Size(45, 18);
            this.genre_lbl.TabIndex = 83;
            this.genre_lbl.Text = "Genre:";
            // 
            // decription_lbl
            // 
            this.decription_lbl.AutoSize = true;
            this.decription_lbl.Font = new System.Drawing.Font("Impact", 12F);
            this.decription_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.decription_lbl.Location = new System.Drawing.Point(29, 191);
            this.decription_lbl.Name = "decription_lbl";
            this.decription_lbl.Size = new System.Drawing.Size(88, 20);
            this.decription_lbl.TabIndex = 82;
            this.decription_lbl.Text = "Description:";
            // 
            // decription_tb
            // 
            this.decription_tb.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decription_tb.Location = new System.Drawing.Point(119, 194);
            this.decription_tb.Multiline = true;
            this.decription_tb.Name = "decription_tb";
            this.decription_tb.Size = new System.Drawing.Size(191, 118);
            this.decription_tb.TabIndex = 81;
            // 
            // posterUrl_lbl
            // 
            this.posterUrl_lbl.AutoSize = true;
            this.posterUrl_lbl.Font = new System.Drawing.Font("Impact", 12F);
            this.posterUrl_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.posterUrl_lbl.Location = new System.Drawing.Point(29, 53);
            this.posterUrl_lbl.Name = "posterUrl_lbl";
            this.posterUrl_lbl.Size = new System.Drawing.Size(82, 20);
            this.posterUrl_lbl.TabIndex = 80;
            this.posterUrl_lbl.Text = "Poster URL:";
            // 
            // url_tb
            // 
            this.url_tb.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_tb.Location = new System.Drawing.Point(121, 56);
            this.url_tb.Name = "url_tb";
            this.url_tb.Size = new System.Drawing.Size(191, 20);
            this.url_tb.TabIndex = 79;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Impact", 12F);
            this.title_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.title_lbl.Location = new System.Drawing.Point(29, 15);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(40, 20);
            this.title_lbl.TabIndex = 78;
            this.title_lbl.Text = "Title:";
            // 
            // title_tb
            // 
            this.title_tb.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_tb.Location = new System.Drawing.Point(75, 18);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(191, 20);
            this.title_tb.TabIndex = 77;
            // 
            // admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1382, 718);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.movie_panel);
            this.Controls.Add(this.close_pb);
            this.Controls.Add(this.minimize_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(330, 200);
            this.Name = "admin_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.movie_panel.ResumeLayout(false);
            this.movie_panel.PerformLayout();
            this.insertMovie_panel.ResumeLayout(false);
            this.insertMovie_panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertClose_btn)).EndInit();
            this.viewportPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recommendedMovieRight_btn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.PictureBox minimize_pb;
        private System.Windows.Forms.PictureBox close_pb;
        private ComponentFactory.Krypton.Toolkit.KryptonButton home_btn;
        private System.Windows.Forms.Panel movie_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton insert_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton remove_btn;
        private System.Windows.Forms.Panel viewportPanel;
        private System.Windows.Forms.PictureBox recommendedMovieRight_btn;
        private System.Windows.Forms.FlowLayoutPanel movieListAdmin_panel;
        private System.Windows.Forms.ListBox search_list;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Panel insertMovie_panel;
        private System.Windows.Forms.PictureBox insertClose_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton submit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckedListBox genre_clb;
        private System.Windows.Forms.Label release_year;
        private System.Windows.Forms.Label genre_lbl;
        private System.Windows.Forms.Label decription_lbl;
        private System.Windows.Forms.TextBox decription_tb;
        private System.Windows.Forms.Label posterUrl_lbl;
        private System.Windows.Forms.TextBox url_tb;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TextBox title_tb;
    }
}