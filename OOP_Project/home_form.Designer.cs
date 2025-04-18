namespace OOP_Project
{
    partial class home_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu2_panel = new System.Windows.Forms.Panel();
            this.menu_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.home_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.favorite_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.popular_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.settings_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.admin_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.signOut_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.logo_pb = new System.Windows.Forms.PictureBox();
            this.form_lbl = new System.Windows.Forms.Label();
            this.movie_panel = new System.Windows.Forms.Panel();
            this.insertMovie_panel = new System.Windows.Forms.Panel();
            this.releaseYear_tb = new System.Windows.Forms.TextBox();
            this.release_year = new System.Windows.Forms.Label();
            this.insertInsert_btn = new System.Windows.Forms.Button();
            this.genre_lbl = new System.Windows.Forms.Label();
            this.decription_lbl = new System.Windows.Forms.Label();
            this.decription_tb = new System.Windows.Forms.TextBox();
            this.url_lbl = new System.Windows.Forms.Label();
            this.url_tb = new System.Windows.Forms.TextBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.genre_cmb = new System.Windows.Forms.ComboBox();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.topRatedMovie_panel = new System.Windows.Forms.Panel();
            this.topRatedMovieRight_btn = new System.Windows.Forms.PictureBox();
            this.topRatedMovieLeft_btn = new System.Windows.Forms.PictureBox();
            this.topRatedMovie_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.popularmovie_pnl = new System.Windows.Forms.Panel();
            this.popularMovieRight_btn = new System.Windows.Forms.PictureBox();
            this.popularMovieLeft_btn = new System.Windows.Forms.PictureBox();
            this.popularMovie_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.viewportPanel = new System.Windows.Forms.Panel();
            this.recommendedMovieRight_btn = new System.Windows.Forms.PictureBox();
            this.recommendedMovieLeft_btn = new System.Windows.Forms.PictureBox();
            this.recommendedMovie_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.search_list = new System.Windows.Forms.ListBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.insert_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.close_pb = new System.Windows.Forms.PictureBox();
            this.minimize_pb = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menu2_panel.SuspendLayout();
            this.menu_panel.SuspendLayout();
            this.logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            this.movie_panel.SuspendLayout();
            this.insertMovie_panel.SuspendLayout();
            this.topRatedMovie_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topRatedMovieRight_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRatedMovieLeft_btn)).BeginInit();
            this.popularmovie_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popularMovieRight_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popularMovieLeft_btn)).BeginInit();
            this.viewportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recommendedMovieRight_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recommendedMovieLeft_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menu2_panel);
            this.panel1.Controls.Add(this.logo_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 857);
            this.panel1.TabIndex = 58;
            // 
            // menu2_panel
            // 
            this.menu2_panel.Controls.Add(this.menu_panel);
            this.menu2_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_panel.Location = new System.Drawing.Point(0, 100);
            this.menu2_panel.Name = "menu2_panel";
            this.menu2_panel.Size = new System.Drawing.Size(109, 757);
            this.menu2_panel.TabIndex = 1;
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.menu_panel.Controls.Add(this.home_btn);
            this.menu_panel.Controls.Add(this.favorite_btn);
            this.menu_panel.Controls.Add(this.popular_btn);
            this.menu_panel.Controls.Add(this.settings_btn);
            this.menu_panel.Controls.Add(this.admin_button);
            this.menu_panel.Controls.Add(this.signOut_btn);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(109, 757);
            this.menu_panel.TabIndex = 0;
            this.menu_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.menu_panel_Paint);
            // 
            // home_btn
            // 
            this.home_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.home_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.home_btn.Location = new System.Drawing.Point(20, 100);
            this.home_btn.Margin = new System.Windows.Forms.Padding(20, 100, 3, 3);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(70, 70);
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
            // favorite_btn
            // 
            this.favorite_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.favorite_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.favorite_btn.Location = new System.Drawing.Point(20, 178);
            this.favorite_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.favorite_btn.Name = "favorite_btn";
            this.favorite_btn.Size = new System.Drawing.Size(70, 70);
            this.favorite_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.favorite_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.favorite_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.favorite_btn.StateCommon.Border.Rounding = 20;
            this.favorite_btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.favorite_btn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.favorite_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.favorite_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.favorite_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.favorite_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.favorite_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.favorite_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.favorite_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.favorite_btn.TabIndex = 61;
            this.favorite_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_favorite_folder_28;
            this.favorite_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.favorite_btn.Values.Text = "";
            this.favorite_btn.Click += new System.EventHandler(this.favorite_btn_Click);
            // 
            // popular_btn
            // 
            this.popular_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.popular_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.popular_btn.Location = new System.Drawing.Point(20, 256);
            this.popular_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.popular_btn.Name = "popular_btn";
            this.popular_btn.Size = new System.Drawing.Size(70, 70);
            this.popular_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.popular_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.popular_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.popular_btn.StateCommon.Border.Rounding = 20;
            this.popular_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.popular_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.popular_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.popular_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.popular_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.popular_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.popular_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.popular_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.popular_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.popular_btn.TabIndex = 62;
            this.popular_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_fire_28;
            this.popular_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.popular_btn.Values.Text = "";
            this.popular_btn.Click += new System.EventHandler(this.popular_btn_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.settings_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings_btn.Location = new System.Drawing.Point(20, 334);
            this.settings_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(70, 70);
            this.settings_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.settings_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.settings_btn.StateCommon.Border.Rounding = 20;
            this.settings_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.settings_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.settings_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.settings_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.settings_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settings_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settings_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settings_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settings_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.settings_btn.TabIndex = 63;
            this.settings_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_settings_28__1_;
            this.settings_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.settings_btn.Values.Text = "";
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // admin_button
            // 
            this.admin_button.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.admin_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.admin_button.Location = new System.Drawing.Point(20, 412);
            this.admin_button.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(70, 70);
            this.admin_button.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.admin_button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.admin_button.StateCommon.Border.Rounding = 20;
            this.admin_button.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.admin_button.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.admin_button.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.admin_button.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.admin_button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.admin_button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.admin_button.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.admin_button.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.admin_button.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.admin_button.TabIndex = 65;
            this.admin_button.Values.Image = global::OOP_Project.Properties.Resources.icons8_admin_settings_female_282;
            this.admin_button.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.admin_button.Values.Text = "";
            // 
            // signOut_btn
            // 
            this.signOut_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.signOut_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.signOut_btn.Location = new System.Drawing.Point(20, 635);
            this.signOut_btn.Margin = new System.Windows.Forms.Padding(20, 150, 3, 3);
            this.signOut_btn.Name = "signOut_btn";
            this.signOut_btn.Size = new System.Drawing.Size(70, 70);
            this.signOut_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.signOut_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signOut_btn.StateCommon.Border.Rounding = 20;
            this.signOut_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.signOut_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.signOut_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.signOut_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.signOut_btn.StateTracking.Back.Color1 = System.Drawing.Color.Gray;
            this.signOut_btn.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.signOut_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signOut_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signOut_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signOut_btn.TabIndex = 66;
            this.signOut_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_left_28;
            this.signOut_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.signOut_btn.Values.Text = "";
            this.signOut_btn.Click += new System.EventHandler(this.signOut_btn_Click);
            // 
            // logo_panel
            // 
            this.logo_panel.BackColor = System.Drawing.Color.White;
            this.logo_panel.Controls.Add(this.logo_pb);
            this.logo_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_panel.Location = new System.Drawing.Point(0, 0);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(109, 100);
            this.logo_panel.TabIndex = 0;
            // 
            // logo_pb
            // 
            this.logo_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo_pb.Image = global::OOP_Project.Properties.Resources._1_2;
            this.logo_pb.Location = new System.Drawing.Point(0, 0);
            this.logo_pb.Name = "logo_pb";
            this.logo_pb.Size = new System.Drawing.Size(109, 100);
            this.logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_pb.TabIndex = 0;
            this.logo_pb.TabStop = false;
            this.logo_pb.Click += new System.EventHandler(this.logo_pb_Click);
            // 
            // form_lbl
            // 
            this.form_lbl.AutoSize = true;
            this.form_lbl.Font = new System.Drawing.Font("Impact", 20F);
            this.form_lbl.ForeColor = System.Drawing.Color.White;
            this.form_lbl.Location = new System.Drawing.Point(173, 38);
            this.form_lbl.Name = "form_lbl";
            this.form_lbl.Size = new System.Drawing.Size(75, 34);
            this.form_lbl.TabIndex = 60;
            this.form_lbl.Text = "HOME";
            // 
            // movie_panel
            // 
            this.movie_panel.AutoScroll = true;
            this.movie_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.movie_panel.Controls.Add(this.search_list);
            this.movie_panel.Controls.Add(this.insertMovie_panel);
            this.movie_panel.Controls.Add(this.search_txt);
            this.movie_panel.Controls.Add(this.topRatedMovie_panel);
            this.movie_panel.Controls.Add(this.popularmovie_pnl);
            this.movie_panel.Controls.Add(this.viewportPanel);
            this.movie_panel.Location = new System.Drawing.Point(143, 113);
            this.movie_panel.Name = "movie_panel";
            this.movie_panel.Size = new System.Drawing.Size(1382, 718);
            this.movie_panel.TabIndex = 61;
            this.movie_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.movie_panel_Paint);
            // 
            // insertMovie_panel
            // 
            this.insertMovie_panel.Controls.Add(this.releaseYear_tb);
            this.insertMovie_panel.Controls.Add(this.release_year);
            this.insertMovie_panel.Controls.Add(this.insertInsert_btn);
            this.insertMovie_panel.Controls.Add(this.genre_lbl);
            this.insertMovie_panel.Controls.Add(this.decription_lbl);
            this.insertMovie_panel.Controls.Add(this.decription_tb);
            this.insertMovie_panel.Controls.Add(this.url_lbl);
            this.insertMovie_panel.Controls.Add(this.url_tb);
            this.insertMovie_panel.Controls.Add(this.title_lbl);
            this.insertMovie_panel.Controls.Add(this.genre_cmb);
            this.insertMovie_panel.Controls.Add(this.title_tb);
            this.insertMovie_panel.Location = new System.Drawing.Point(255, 87);
            this.insertMovie_panel.Name = "insertMovie_panel";
            this.insertMovie_panel.Size = new System.Drawing.Size(565, 288);
            this.insertMovie_panel.TabIndex = 65;
            this.insertMovie_panel.Visible = false;
            this.insertMovie_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.insertMovie_panel_Paint);
            // 
            // releaseYear_tb
            // 
            this.releaseYear_tb.Location = new System.Drawing.Point(96, 165);
            this.releaseYear_tb.Name = "releaseYear_tb";
            this.releaseYear_tb.Size = new System.Drawing.Size(191, 20);
            this.releaseYear_tb.TabIndex = 73;
            // 
            // release_year
            // 
            this.release_year.AutoSize = true;
            this.release_year.Font = new System.Drawing.Font("Impact", 10F);
            this.release_year.ForeColor = System.Drawing.SystemColors.Control;
            this.release_year.Location = new System.Drawing.Point(36, 154);
            this.release_year.Name = "release_year";
            this.release_year.Size = new System.Drawing.Size(33, 18);
            this.release_year.TabIndex = 72;
            this.release_year.Text = "year";
            // 
            // insertInsert_btn
            // 
            this.insertInsert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertInsert_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.insertInsert_btn.Location = new System.Drawing.Point(456, 212);
            this.insertInsert_btn.Name = "insertInsert_btn";
            this.insertInsert_btn.Size = new System.Drawing.Size(75, 23);
            this.insertInsert_btn.TabIndex = 65;
            this.insertInsert_btn.Text = "insert";
            this.insertInsert_btn.UseVisualStyleBackColor = true;
            this.insertInsert_btn.Click += new System.EventHandler(this.insertInsert_btn_Click);
            // 
            // genre_lbl
            // 
            this.genre_lbl.AutoSize = true;
            this.genre_lbl.Font = new System.Drawing.Font("Impact", 10F);
            this.genre_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.genre_lbl.Location = new System.Drawing.Point(34, 127);
            this.genre_lbl.Name = "genre_lbl";
            this.genre_lbl.Size = new System.Drawing.Size(41, 18);
            this.genre_lbl.TabIndex = 70;
            this.genre_lbl.Text = "genre";
            // 
            // decription_lbl
            // 
            this.decription_lbl.AutoSize = true;
            this.decription_lbl.Font = new System.Drawing.Font("Impact", 15F);
            this.decription_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.decription_lbl.Location = new System.Drawing.Point(34, 189);
            this.decription_lbl.Name = "decription_lbl";
            this.decription_lbl.Size = new System.Drawing.Size(104, 25);
            this.decription_lbl.TabIndex = 69;
            this.decription_lbl.Text = "description";
            // 
            // decription_tb
            // 
            this.decription_tb.Location = new System.Drawing.Point(144, 194);
            this.decription_tb.Multiline = true;
            this.decription_tb.Name = "decription_tb";
            this.decription_tb.Size = new System.Drawing.Size(191, 66);
            this.decription_tb.TabIndex = 68;
            // 
            // url_lbl
            // 
            this.url_lbl.AutoSize = true;
            this.url_lbl.Font = new System.Drawing.Font("Impact", 15F);
            this.url_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.url_lbl.Location = new System.Drawing.Point(34, 83);
            this.url_lbl.Name = "url_lbl";
            this.url_lbl.Size = new System.Drawing.Size(42, 25);
            this.url_lbl.TabIndex = 67;
            this.url_lbl.Text = "URL";
            // 
            // url_tb
            // 
            this.url_tb.Location = new System.Drawing.Point(96, 88);
            this.url_tb.Name = "url_tb";
            this.url_tb.Size = new System.Drawing.Size(191, 20);
            this.url_tb.TabIndex = 66;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Impact", 15F);
            this.title_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.title_lbl.Location = new System.Drawing.Point(34, 44);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(47, 25);
            this.title_lbl.TabIndex = 65;
            this.title_lbl.Text = "Title";
            // 
            // genre_cmb
            // 
            this.genre_cmb.FormattingEnabled = true;
            this.genre_cmb.Location = new System.Drawing.Point(96, 127);
            this.genre_cmb.Name = "genre_cmb";
            this.genre_cmb.Size = new System.Drawing.Size(191, 21);
            this.genre_cmb.TabIndex = 2;
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(96, 49);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(191, 20);
            this.title_tb.TabIndex = 0;
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.ForeColor = System.Drawing.Color.Gray;
            this.search_txt.Location = new System.Drawing.Point(988, 25);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(337, 26);
            this.search_txt.TabIndex = 66;
            this.search_txt.Text = "Search...";
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            this.search_txt.Enter += new System.EventHandler(this.search_txt_Enter);
            this.search_txt.Leave += new System.EventHandler(this.search_txt_Leave);
            // 
            // topRatedMovie_panel
            // 
            this.topRatedMovie_panel.BackColor = System.Drawing.Color.Gray;
            this.topRatedMovie_panel.Controls.Add(this.topRatedMovieRight_btn);
            this.topRatedMovie_panel.Controls.Add(this.topRatedMovieLeft_btn);
            this.topRatedMovie_panel.Controls.Add(this.topRatedMovie_flp);
            this.topRatedMovie_panel.Location = new System.Drawing.Point(49, 705);
            this.topRatedMovie_panel.Name = "topRatedMovie_panel";
            this.topRatedMovie_panel.Size = new System.Drawing.Size(1279, 255);
            this.topRatedMovie_panel.TabIndex = 64;
            // 
            // topRatedMovieRight_btn
            // 
            this.topRatedMovieRight_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.topRatedMovieRight_btn.Image = global::OOP_Project.Properties.Resources.icons8_right_28;
            this.topRatedMovieRight_btn.Location = new System.Drawing.Point(1252, 13);
            this.topRatedMovieRight_btn.Name = "topRatedMovieRight_btn";
            this.topRatedMovieRight_btn.Size = new System.Drawing.Size(24, 229);
            this.topRatedMovieRight_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.topRatedMovieRight_btn.TabIndex = 62;
            this.topRatedMovieRight_btn.TabStop = false;
            // 
            // topRatedMovieLeft_btn
            // 
            this.topRatedMovieLeft_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.topRatedMovieLeft_btn.Image = global::OOP_Project.Properties.Resources.icons8_left_28__1_1;
            this.topRatedMovieLeft_btn.Location = new System.Drawing.Point(3, 13);
            this.topRatedMovieLeft_btn.Name = "topRatedMovieLeft_btn";
            this.topRatedMovieLeft_btn.Size = new System.Drawing.Size(24, 229);
            this.topRatedMovieLeft_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.topRatedMovieLeft_btn.TabIndex = 61;
            this.topRatedMovieLeft_btn.TabStop = false;
            // 
            // topRatedMovie_flp
            // 
            this.topRatedMovie_flp.BackColor = System.Drawing.Color.White;
            this.topRatedMovie_flp.Location = new System.Drawing.Point(30, 13);
            this.topRatedMovie_flp.Name = "topRatedMovie_flp";
            this.topRatedMovie_flp.Size = new System.Drawing.Size(1219, 229);
            this.topRatedMovie_flp.TabIndex = 0;
            // 
            // popularmovie_pnl
            // 
            this.popularmovie_pnl.BackColor = System.Drawing.Color.Gray;
            this.popularmovie_pnl.Controls.Add(this.popularMovieRight_btn);
            this.popularmovie_pnl.Controls.Add(this.popularMovieLeft_btn);
            this.popularmovie_pnl.Controls.Add(this.popularMovie_flp);
            this.popularmovie_pnl.Location = new System.Drawing.Point(49, 397);
            this.popularmovie_pnl.Name = "popularmovie_pnl";
            this.popularmovie_pnl.Size = new System.Drawing.Size(1279, 255);
            this.popularmovie_pnl.TabIndex = 63;
            // 
            // popularMovieRight_btn
            // 
            this.popularMovieRight_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.popularMovieRight_btn.Image = global::OOP_Project.Properties.Resources.icons8_right_28;
            this.popularMovieRight_btn.Location = new System.Drawing.Point(1252, 13);
            this.popularMovieRight_btn.Name = "popularMovieRight_btn";
            this.popularMovieRight_btn.Size = new System.Drawing.Size(24, 229);
            this.popularMovieRight_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.popularMovieRight_btn.TabIndex = 62;
            this.popularMovieRight_btn.TabStop = false;
            // 
            // popularMovieLeft_btn
            // 
            this.popularMovieLeft_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.popularMovieLeft_btn.Image = global::OOP_Project.Properties.Resources.icons8_left_28__1_1;
            this.popularMovieLeft_btn.Location = new System.Drawing.Point(3, 13);
            this.popularMovieLeft_btn.Name = "popularMovieLeft_btn";
            this.popularMovieLeft_btn.Size = new System.Drawing.Size(24, 229);
            this.popularMovieLeft_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.popularMovieLeft_btn.TabIndex = 61;
            this.popularMovieLeft_btn.TabStop = false;
            // 
            // popularMovie_flp
            // 
            this.popularMovie_flp.BackColor = System.Drawing.Color.White;
            this.popularMovie_flp.Location = new System.Drawing.Point(30, 13);
            this.popularMovie_flp.Name = "popularMovie_flp";
            this.popularMovie_flp.Size = new System.Drawing.Size(1219, 229);
            this.popularMovie_flp.TabIndex = 0;
            // 
            // viewportPanel
            // 
            this.viewportPanel.BackColor = System.Drawing.Color.Gray;
            this.viewportPanel.Controls.Add(this.recommendedMovieRight_btn);
            this.viewportPanel.Controls.Add(this.recommendedMovieLeft_btn);
            this.viewportPanel.Controls.Add(this.recommendedMovie_flp);
            this.viewportPanel.Location = new System.Drawing.Point(49, 87);
            this.viewportPanel.Name = "viewportPanel";
            this.viewportPanel.Size = new System.Drawing.Size(1279, 255);
            this.viewportPanel.TabIndex = 60;
            // 
            // recommendedMovieRight_btn
            // 
            this.recommendedMovieRight_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.recommendedMovieRight_btn.Image = global::OOP_Project.Properties.Resources.icons8_right_28;
            this.recommendedMovieRight_btn.Location = new System.Drawing.Point(1252, 13);
            this.recommendedMovieRight_btn.Name = "recommendedMovieRight_btn";
            this.recommendedMovieRight_btn.Size = new System.Drawing.Size(24, 229);
            this.recommendedMovieRight_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recommendedMovieRight_btn.TabIndex = 62;
            this.recommendedMovieRight_btn.TabStop = false;
            this.recommendedMovieRight_btn.Click += new System.EventHandler(this.recommendedMovieRight_btn_Click);
            this.recommendedMovieRight_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.recommendedMovieRight_btn_MouseClick);
            this.recommendedMovieRight_btn.MouseEnter += new System.EventHandler(this.recommendedMovieRight_btn_MouseEnter);
            this.recommendedMovieRight_btn.MouseLeave += new System.EventHandler(this.recommendedMovieRight_btn_MouseLeave);
            // 
            // recommendedMovieLeft_btn
            // 
            this.recommendedMovieLeft_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.recommendedMovieLeft_btn.Image = global::OOP_Project.Properties.Resources.icons8_left_28__1_1;
            this.recommendedMovieLeft_btn.Location = new System.Drawing.Point(3, 13);
            this.recommendedMovieLeft_btn.Name = "recommendedMovieLeft_btn";
            this.recommendedMovieLeft_btn.Size = new System.Drawing.Size(24, 229);
            this.recommendedMovieLeft_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recommendedMovieLeft_btn.TabIndex = 61;
            this.recommendedMovieLeft_btn.TabStop = false;
            this.recommendedMovieLeft_btn.Click += new System.EventHandler(this.recommendedMovieLeft_btn_Click);
            this.recommendedMovieLeft_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.recommendedMovieLeft_btn_MouseClick);
            this.recommendedMovieLeft_btn.MouseEnter += new System.EventHandler(this.recommendedMovieLeft_btn_MouseEnter);
            this.recommendedMovieLeft_btn.MouseLeave += new System.EventHandler(this.recommendedMovieLeft_btn_MouseLeave);
            // 
            // recommendedMovie_flp
            // 
            this.recommendedMovie_flp.AutoScroll = true;
            this.recommendedMovie_flp.BackColor = System.Drawing.Color.White;
            this.recommendedMovie_flp.Location = new System.Drawing.Point(30, 13);
            this.recommendedMovie_flp.Name = "recommendedMovie_flp";
            this.recommendedMovie_flp.Size = new System.Drawing.Size(1219, 229);
            this.recommendedMovie_flp.TabIndex = 0;
            this.recommendedMovie_flp.WrapContents = false;
            this.recommendedMovie_flp.Paint += new System.Windows.Forms.PaintEventHandler(this.recommendedMovie_flp_Paint);
            // 
            // search_list
            // 
            this.search_list.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_list.FormattingEnabled = true;
            this.search_list.ItemHeight = 19;
            this.search_list.Location = new System.Drawing.Point(988, 48);
            this.search_list.Name = "search_list";
            this.search_list.Size = new System.Drawing.Size(337, 80);
            this.search_list.TabIndex = 67;
            this.search_list.Visible = false;
            this.search_list.Click += new System.EventHandler(this.search_list_Click);
            this.search_list.SelectedIndexChanged += new System.EventHandler(this.search_list_SelectedIndexChanged);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ButtonSpec;
            this.kryptonButton1.Location = new System.Drawing.Point(1485, 51);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(40, 40);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.StateCommon.Border.Width = -5;
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.DimGray;
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateNormal.Border.Rounding = 20;
            this.kryptonButton1.StateNormal.Border.Width = -5;
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 20;
            this.kryptonButton1.StatePressed.Border.Width = -5;
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.Rounding = 20;
            this.kryptonButton1.StateTracking.Border.Width = -5;
            this.kryptonButton1.TabIndex = 62;
            this.kryptonButton1.Values.Image = global::OOP_Project.Properties.Resources.icons8_user_28__1_;
            this.kryptonButton1.Values.Text = "";
            // 
            // insert_btn
            // 
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.insert_btn.Location = new System.Drawing.Point(549, 51);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_btn.TabIndex = 63;
            this.insert_btn.Text = "insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.remove_btn.Location = new System.Drawing.Point(651, 51);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(75, 23);
            this.remove_btn.TabIndex = 64;
            this.remove_btn.Text = "remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            // 
            // close_pb
            // 
            this.close_pb.BackColor = System.Drawing.Color.Transparent;
            this.close_pb.Image = global::OOP_Project.Properties.Resources.icons8_close_24;
            this.close_pb.Location = new System.Drawing.Point(1515, 12);
            this.close_pb.Name = "close_pb";
            this.close_pb.Size = new System.Drawing.Size(25, 23);
            this.close_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_pb.TabIndex = 16;
            this.close_pb.TabStop = false;
            this.close_pb.Click += new System.EventHandler(this.close_pb_Click);
            this.close_pb.MouseEnter += new System.EventHandler(this.close_pb_MouseEnter);
            this.close_pb.MouseLeave += new System.EventHandler(this.close_pb_MouseLeave);
            // 
            // minimize_pb
            // 
            this.minimize_pb.BackColor = System.Drawing.Color.Transparent;
            this.minimize_pb.Image = global::OOP_Project.Properties.Resources.icons8_minimize_24;
            this.minimize_pb.Location = new System.Drawing.Point(1486, 12);
            this.minimize_pb.Name = "minimize_pb";
            this.minimize_pb.Size = new System.Drawing.Size(25, 23);
            this.minimize_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_pb.TabIndex = 17;
            this.minimize_pb.TabStop = false;
            this.minimize_pb.Click += new System.EventHandler(this.minimize_pb_Click);
            this.minimize_pb.MouseEnter += new System.EventHandler(this.minimize_pb_MouseEnter);
            this.minimize_pb.MouseLeave += new System.EventHandler(this.minimize_pb_MouseLeave);
            // 
            // home_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1552, 857);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.movie_panel);
            this.Controls.Add(this.form_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close_pb);
            this.Controls.Add(this.minimize_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1552, 857);
            this.MinimumSize = new System.Drawing.Size(1400, 500);
            this.Name = "home_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 15;
            this.StateCommon.Border.Width = 1;
            this.StateCommon.Header.ButtonEdgeInset = -10;
            this.Text = "home_form";
            this.Load += new System.EventHandler(this.home_form_Load);
            this.panel1.ResumeLayout(false);
            this.menu2_panel.ResumeLayout(false);
            this.menu_panel.ResumeLayout(false);
            this.logo_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            this.movie_panel.ResumeLayout(false);
            this.movie_panel.PerformLayout();
            this.insertMovie_panel.ResumeLayout(false);
            this.insertMovie_panel.PerformLayout();
            this.topRatedMovie_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topRatedMovieRight_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRatedMovieLeft_btn)).EndInit();
            this.popularmovie_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popularMovieRight_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popularMovieLeft_btn)).EndInit();
            this.viewportPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recommendedMovieRight_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recommendedMovieLeft_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.PictureBox minimize_pb;
        private System.Windows.Forms.PictureBox close_pb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menu2_panel;
        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.PictureBox logo_pb;
        private System.Windows.Forms.FlowLayoutPanel menu_panel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton home_btn;
        private System.Windows.Forms.Label form_lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonButton favorite_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton popular_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton settings_btn;
        private System.Windows.Forms.Panel movie_panel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.PictureBox recommendedMovieLeft_btn;
        private System.Windows.Forms.Panel viewportPanel;
        private System.Windows.Forms.FlowLayoutPanel recommendedMovie_flp;
        private System.Windows.Forms.PictureBox recommendedMovieRight_btn;
        private System.Windows.Forms.Panel topRatedMovie_panel;
        private System.Windows.Forms.PictureBox topRatedMovieRight_btn;
        private System.Windows.Forms.PictureBox topRatedMovieLeft_btn;
        private System.Windows.Forms.FlowLayoutPanel topRatedMovie_flp;
        private System.Windows.Forms.Panel popularmovie_pnl;
        private System.Windows.Forms.PictureBox popularMovieRight_btn;
        private System.Windows.Forms.PictureBox popularMovieLeft_btn;
        private System.Windows.Forms.FlowLayoutPanel popularMovie_flp;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Panel insertMovie_panel;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.ComboBox genre_cmb;
        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.Label genre_lbl;
        private System.Windows.Forms.Label decription_lbl;
        private System.Windows.Forms.TextBox decription_tb;
        private System.Windows.Forms.Label url_lbl;
        private System.Windows.Forms.TextBox url_tb;
        private System.Windows.Forms.Button insertInsert_btn;
        private System.Windows.Forms.TextBox releaseYear_tb;
        private System.Windows.Forms.Label release_year;
        private ComponentFactory.Krypton.Toolkit.KryptonButton admin_button;
        private ComponentFactory.Krypton.Toolkit.KryptonButton signOut_btn;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.ListBox search_list;
    }
}