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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_form));
            this.leftdock_pnl = new System.Windows.Forms.Panel();
            this.menu2_panel = new System.Windows.Forms.Panel();
            this.menu_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.home_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.popular_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.settings_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.adminsettings_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.signOut_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.form_lbl = new System.Windows.Forms.Label();
            this.movie_panel = new System.Windows.Forms.Panel();
            this.allMovie_lbl = new System.Windows.Forms.Label();
            this.allMovie_panel = new System.Windows.Forms.Panel();
            this.allMovie_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.recent_lbl = new System.Windows.Forms.Label();
            this.suggest_lbl = new System.Windows.Forms.Label();
            this.search_list = new System.Windows.Forms.ListBox();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.recentlyMovie_panel = new System.Windows.Forms.Panel();
            this.recentlysearch_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.viewport_panel = new System.Windows.Forms.Panel();
            this.recommendedMovie_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.profile_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.AdminControl_panel = new System.Windows.Forms.Panel();
            this.userProfile_panel = new System.Windows.Forms.Panel();
            this.Favorite_panel = new System.Windows.Forms.Panel();
            this.popular_panel = new System.Windows.Forms.Panel();
            this.settings_panel = new System.Windows.Forms.Panel();
            this.favorite_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.logo_pb = new System.Windows.Forms.PictureBox();
            this.close_pb = new System.Windows.Forms.PictureBox();
            this.minimize_pb = new System.Windows.Forms.PictureBox();
            this.leftdock_pnl.SuspendLayout();
            this.menu2_panel.SuspendLayout();
            this.menu_panel.SuspendLayout();
            this.logo_panel.SuspendLayout();
            this.movie_panel.SuspendLayout();
            this.allMovie_panel.SuspendLayout();
            this.recentlyMovie_panel.SuspendLayout();
            this.viewport_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // leftdock_pnl
            // 
            this.leftdock_pnl.Controls.Add(this.menu2_panel);
            this.leftdock_pnl.Controls.Add(this.logo_panel);
            this.leftdock_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftdock_pnl.Location = new System.Drawing.Point(0, 0);
            this.leftdock_pnl.Name = "leftdock_pnl";
            this.leftdock_pnl.Size = new System.Drawing.Size(109, 791);
            this.leftdock_pnl.TabIndex = 58;
            // 
            // menu2_panel
            // 
            this.menu2_panel.Controls.Add(this.menu_panel);
            this.menu2_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_panel.Location = new System.Drawing.Point(0, 100);
            this.menu2_panel.Name = "menu2_panel";
            this.menu2_panel.Size = new System.Drawing.Size(109, 691);
            this.menu2_panel.TabIndex = 1;
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.menu_panel.Controls.Add(this.home_btn);
            this.menu_panel.Controls.Add(this.favorite_btn);
            this.menu_panel.Controls.Add(this.popular_btn);
            this.menu_panel.Controls.Add(this.settings_btn);
            this.menu_panel.Controls.Add(this.adminsettings_btn);
            this.menu_panel.Controls.Add(this.signOut_btn);
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(109, 692);
            this.menu_panel.TabIndex = 0;
            // 
            // home_btn
            // 
            this.home_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.home_btn.Location = new System.Drawing.Point(20, 100);
            this.home_btn.Margin = new System.Windows.Forms.Padding(20, 100, 3, 3);
            this.home_btn.Name = "home_btn";
            this.home_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.home_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.home_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.home_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.home_btn.OverrideDefault.Border.Width = 1;
            this.home_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.Transparent;
            this.home_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.Transparent;
            this.home_btn.Size = new System.Drawing.Size(70, 70);
            this.home_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.home_btn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.home_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.home_btn.StateCommon.Border.Rounding = 20;
            this.home_btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home_btn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.home_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.home_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.home_btn.TabIndex = 1;
            this.home_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_home_28;
            this.home_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.home_btn.Values.Text = "";
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // popular_btn
            // 
            this.popular_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.popular_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.popular_btn.Location = new System.Drawing.Point(20, 256);
            this.popular_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.popular_btn.Name = "popular_btn";
            this.popular_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.popular_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.popular_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.popular_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.popular_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.popular_btn.OverrideDefault.Border.Width = 1;
            this.popular_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.Transparent;
            this.popular_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.Transparent;
            this.popular_btn.Size = new System.Drawing.Size(70, 70);
            this.popular_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.popular_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.popular_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.popular_btn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
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
            this.popular_btn.TabIndex = 3;
            this.popular_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_fire_28;
            this.popular_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.popular_btn.Values.Text = "";
            this.popular_btn.Click += new System.EventHandler(this.popular_btn_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.settings_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings_btn.Location = new System.Drawing.Point(20, 334);
            this.settings_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.settings_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.settings_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.settings_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settings_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.settings_btn.OverrideDefault.Border.Width = 1;
            this.settings_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.Transparent;
            this.settings_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.Transparent;
            this.settings_btn.Size = new System.Drawing.Size(70, 70);
            this.settings_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.settings_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.settings_btn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
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
            this.settings_btn.TabIndex = 4;
            this.settings_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_settings_28__1_;
            this.settings_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.settings_btn.Values.Text = "";
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // adminsettings_btn
            // 
            this.adminsettings_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.adminsettings_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminsettings_btn.Location = new System.Drawing.Point(20, 412);
            this.adminsettings_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.adminsettings_btn.Name = "adminsettings_btn";
            this.adminsettings_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.adminsettings_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.adminsettings_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.adminsettings_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminsettings_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.adminsettings_btn.OverrideDefault.Border.Width = 1;
            this.adminsettings_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.Transparent;
            this.adminsettings_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.Transparent;
            this.adminsettings_btn.Size = new System.Drawing.Size(70, 70);
            this.adminsettings_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.adminsettings_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.adminsettings_btn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.adminsettings_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.adminsettings_btn.StateCommon.Border.Rounding = 20;
            this.adminsettings_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.adminsettings_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.adminsettings_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.adminsettings_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.adminsettings_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminsettings_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminsettings_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminsettings_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminsettings_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.adminsettings_btn.TabIndex = 5;
            this.adminsettings_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_admin_settings_female_282;
            this.adminsettings_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adminsettings_btn.Values.Text = "";
            this.adminsettings_btn.Click += new System.EventHandler(this.admin_button_Click);
            // 
            // signOut_btn
            // 
            this.signOut_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.signOut_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.signOut_btn.Location = new System.Drawing.Point(20, 565);
            this.signOut_btn.Margin = new System.Windows.Forms.Padding(20, 80, 3, 3);
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
            this.signOut_btn.TabIndex = 6;
            this.signOut_btn.UseMnemonic = false;
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
            // form_lbl
            // 
            this.form_lbl.AutoSize = true;
            this.form_lbl.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.form_lbl.ForeColor = System.Drawing.Color.White;
            this.form_lbl.Location = new System.Drawing.Point(173, 38);
            this.form_lbl.Name = "form_lbl";
            this.form_lbl.Size = new System.Drawing.Size(93, 31);
            this.form_lbl.TabIndex = 60;
            this.form_lbl.Text = "HOME";
            // 
            // movie_panel
            // 
            this.movie_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movie_panel.AutoScroll = true;
            this.movie_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.movie_panel.Controls.Add(this.allMovie_lbl);
            this.movie_panel.Controls.Add(this.allMovie_panel);
            this.movie_panel.Controls.Add(this.recent_lbl);
            this.movie_panel.Controls.Add(this.suggest_lbl);
            this.movie_panel.Controls.Add(this.search_list);
            this.movie_panel.Controls.Add(this.search_tb);
            this.movie_panel.Controls.Add(this.recentlyMovie_panel);
            this.movie_panel.Controls.Add(this.viewport_panel);
            this.movie_panel.Location = new System.Drawing.Point(146, 126);
            this.movie_panel.Name = "movie_panel";
            this.movie_panel.Size = new System.Drawing.Size(1214, 614);
            this.movie_panel.TabIndex = 61;
            // 
            // allMovie_lbl
            // 
            this.allMovie_lbl.AutoSize = true;
            this.allMovie_lbl.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.allMovie_lbl.ForeColor = System.Drawing.Color.White;
            this.allMovie_lbl.Location = new System.Drawing.Point(34, 321);
            this.allMovie_lbl.Name = "allMovie_lbl";
            this.allMovie_lbl.Size = new System.Drawing.Size(152, 31);
            this.allMovie_lbl.TabIndex = 69;
            this.allMovie_lbl.Text = "All movies...";
            // 
            // allMovie_panel
            // 
            this.allMovie_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allMovie_panel.BackColor = System.Drawing.Color.Gray;
            this.allMovie_panel.Controls.Add(this.allMovie_flp);
            this.allMovie_panel.Location = new System.Drawing.Point(25, 355);
            this.allMovie_panel.Name = "allMovie_panel";
            this.allMovie_panel.Size = new System.Drawing.Size(1156, 315);
            this.allMovie_panel.TabIndex = 61;
            // 
            // allMovie_flp
            // 
            this.allMovie_flp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allMovie_flp.AutoScroll = true;
            this.allMovie_flp.BackColor = System.Drawing.Color.White;
            this.allMovie_flp.Location = new System.Drawing.Point(18, 16);
            this.allMovie_flp.Name = "allMovie_flp";
            this.allMovie_flp.Padding = new System.Windows.Forms.Padding(5);
            this.allMovie_flp.Size = new System.Drawing.Size(1117, 279);
            this.allMovie_flp.TabIndex = 0;
            this.allMovie_flp.WrapContents = false;
            this.allMovie_flp.Scroll += new System.Windows.Forms.ScrollEventHandler(this.allMovie_flp_Scroll);
            // 
            // recent_lbl
            // 
            this.recent_lbl.AutoSize = true;
            this.recent_lbl.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.recent_lbl.ForeColor = System.Drawing.Color.White;
            this.recent_lbl.Location = new System.Drawing.Point(37, 689);
            this.recent_lbl.Name = "recent_lbl";
            this.recent_lbl.Size = new System.Drawing.Size(234, 31);
            this.recent_lbl.TabIndex = 68;
            this.recent_lbl.Text = "Recently searched...";
            // 
            // suggest_lbl
            // 
            this.suggest_lbl.AutoSize = true;
            this.suggest_lbl.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.suggest_lbl.ForeColor = System.Drawing.Color.White;
            this.suggest_lbl.Location = new System.Drawing.Point(34, 26);
            this.suggest_lbl.Name = "suggest_lbl";
            this.suggest_lbl.Size = new System.Drawing.Size(230, 31);
            this.suggest_lbl.TabIndex = 65;
            this.suggest_lbl.Text = "Suggested for you...";
            // 
            // search_list
            // 
            this.search_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_list.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_list.FormattingEnabled = true;
            this.search_list.ItemHeight = 19;
            this.search_list.Location = new System.Drawing.Point(827, 49);
            this.search_list.Name = "search_list";
            this.search_list.Size = new System.Drawing.Size(337, 80);
            this.search_list.TabIndex = 67;
            this.search_list.Visible = false;
            this.search_list.Click += new System.EventHandler(this.search_list_Click);
            this.search_list.SelectedIndexChanged += new System.EventHandler(this.search_list_SelectedIndexChanged);
            this.search_list.TabIndexChanged += new System.EventHandler(this.search_list_TabIndexChanged);
            // 
            // search_tb
            // 
            this.search_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_tb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tb.ForeColor = System.Drawing.Color.Gray;
            this.search_tb.Location = new System.Drawing.Point(827, 26);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(337, 26);
            this.search_tb.TabIndex = 66;
            this.search_tb.Text = "Search...";
            this.search_tb.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            this.search_tb.Enter += new System.EventHandler(this.search_txt_Enter);
            this.search_tb.Leave += new System.EventHandler(this.search_txt_Leave);
            // 
            // recentlyMovie_panel
            // 
            this.recentlyMovie_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recentlyMovie_panel.BackColor = System.Drawing.Color.Gray;
            this.recentlyMovie_panel.Controls.Add(this.recentlysearch_flp);
            this.recentlyMovie_panel.Location = new System.Drawing.Point(25, 723);
            this.recentlyMovie_panel.Name = "recentlyMovie_panel";
            this.recentlyMovie_panel.Size = new System.Drawing.Size(1156, 255);
            this.recentlyMovie_panel.TabIndex = 63;
            // 
            // recentlysearch_flp
            // 
            this.recentlysearch_flp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recentlysearch_flp.AutoScroll = true;
            this.recentlysearch_flp.BackColor = System.Drawing.Color.White;
            this.recentlysearch_flp.Location = new System.Drawing.Point(18, 13);
            this.recentlysearch_flp.Name = "recentlysearch_flp";
            this.recentlysearch_flp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.recentlysearch_flp.Size = new System.Drawing.Size(1117, 229);
            this.recentlysearch_flp.TabIndex = 0;
            // 
            // viewport_panel
            // 
            this.viewport_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewport_panel.BackColor = System.Drawing.Color.Gray;
            this.viewport_panel.Controls.Add(this.recommendedMovie_flp);
            this.viewport_panel.Location = new System.Drawing.Point(25, 63);
            this.viewport_panel.Name = "viewport_panel";
            this.viewport_panel.Size = new System.Drawing.Size(1156, 242);
            this.viewport_panel.TabIndex = 60;
            // 
            // recommendedMovie_flp
            // 
            this.recommendedMovie_flp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recommendedMovie_flp.AutoScroll = true;
            this.recommendedMovie_flp.BackColor = System.Drawing.Color.White;
            this.recommendedMovie_flp.Location = new System.Drawing.Point(18, 13);
            this.recommendedMovie_flp.Name = "recommendedMovie_flp";
            this.recommendedMovie_flp.Padding = new System.Windows.Forms.Padding(5);
            this.recommendedMovie_flp.Size = new System.Drawing.Size(1121, 209);
            this.recommendedMovie_flp.TabIndex = 0;
            this.recommendedMovie_flp.WrapContents = false;
            // 
            // profile_btn
            // 
            this.profile_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profile_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ButtonSpec;
            this.profile_btn.Location = new System.Drawing.Point(1320, 60);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(43, 40);
            this.profile_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.profile_btn.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.profile_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.profile_btn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.profile_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.profile_btn.StateCommon.Border.Rounding = 20;
            this.profile_btn.StateCommon.Border.Width = -5;
            this.profile_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.profile_btn.StateNormal.Back.Color2 = System.Drawing.Color.DimGray;
            this.profile_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.profile_btn.StateNormal.Border.Rounding = 20;
            this.profile_btn.StateNormal.Border.Width = -5;
            this.profile_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.profile_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.profile_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.profile_btn.StatePressed.Border.Rounding = 20;
            this.profile_btn.StatePressed.Border.Width = -5;
            this.profile_btn.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.profile_btn.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.profile_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.profile_btn.StateTracking.Border.Rounding = 20;
            this.profile_btn.StateTracking.Border.Width = -5;
            this.profile_btn.TabIndex = 64;
            this.profile_btn.Values.Image = ((System.Drawing.Image)(resources.GetObject("profile_btn.Values.Image")));
            this.profile_btn.Values.Text = "";
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // AdminControl_panel
            // 
            this.AdminControl_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminControl_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.AdminControl_panel.Location = new System.Drawing.Point(148, 123);
            this.AdminControl_panel.Name = "AdminControl_panel";
            this.AdminControl_panel.Size = new System.Drawing.Size(1214, 614);
            this.AdminControl_panel.TabIndex = 65;
            this.AdminControl_panel.Visible = false;
            // 
            // userProfile_panel
            // 
            this.userProfile_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.userProfile_panel.Location = new System.Drawing.Point(145, 122);
            this.userProfile_panel.Name = "userProfile_panel";
            this.userProfile_panel.Size = new System.Drawing.Size(1214, 614);
            this.userProfile_panel.TabIndex = 66;
            this.userProfile_panel.Visible = false;
            // 
            // Favorite_panel
            // 
            this.Favorite_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Favorite_panel.Location = new System.Drawing.Point(148, 124);
            this.Favorite_panel.Name = "Favorite_panel";
            this.Favorite_panel.Size = new System.Drawing.Size(1214, 614);
            this.Favorite_panel.TabIndex = 66;
            this.Favorite_panel.Visible = false;
            // 
            // popular_panel
            // 
            this.popular_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.popular_panel.Location = new System.Drawing.Point(147, 120);
            this.popular_panel.Name = "popular_panel";
            this.popular_panel.Size = new System.Drawing.Size(1214, 614);
            this.popular_panel.TabIndex = 67;
            this.popular_panel.Visible = false;
            // 
            // settings_panel
            // 
            this.settings_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.settings_panel.Location = new System.Drawing.Point(147, 120);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(1214, 614);
            this.settings_panel.TabIndex = 68;
            this.settings_panel.Visible = false;
            // 
            // favorite_btn
            // 
            this.favorite_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.favorite_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.favorite_btn.Location = new System.Drawing.Point(20, 178);
            this.favorite_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.favorite_btn.Name = "favorite_btn";
            this.favorite_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.favorite_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.favorite_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.favorite_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.favorite_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.favorite_btn.OverrideDefault.Border.Width = 1;
            this.favorite_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.Transparent;
            this.favorite_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.Transparent;
            this.favorite_btn.Size = new System.Drawing.Size(70, 70);
            this.favorite_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.favorite_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.favorite_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.favorite_btn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.favorite_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.favorite_btn.StateCommon.Border.Rounding = 20;
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
            this.favorite_btn.TabIndex = 2;
            this.favorite_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_favorite_folder_28;
            this.favorite_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.favorite_btn.Values.Text = "";
            this.favorite_btn.Click += new System.EventHandler(this.favorite_btn_Click);
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
            // 
            // close_pb
            // 
            this.close_pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_pb.BackColor = System.Drawing.Color.Transparent;
            this.close_pb.Image = global::OOP_Project.Properties.Resources.icons8_close_24;
            this.close_pb.Location = new System.Drawing.Point(1349, 12);
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
            this.minimize_pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_pb.BackColor = System.Drawing.Color.Transparent;
            this.minimize_pb.Image = global::OOP_Project.Properties.Resources.icons8_minimize_24;
            this.minimize_pb.Location = new System.Drawing.Point(1320, 12);
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
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1388, 791);
            this.Controls.Add(this.settings_panel);
            this.Controls.Add(this.profile_btn);
            this.Controls.Add(this.form_lbl);
            this.Controls.Add(this.leftdock_pnl);
            this.Controls.Add(this.close_pb);
            this.Controls.Add(this.minimize_pb);
            this.Controls.Add(this.popular_panel);
            this.Controls.Add(this.userProfile_panel);
            this.Controls.Add(this.Favorite_panel);
            this.Controls.Add(this.AdminControl_panel);
            this.Controls.Add(this.movie_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 15;
            this.StateCommon.Border.Width = 1;
            this.StateCommon.Header.ButtonEdgeInset = -10;
            this.Text = "home_form";
            this.Load += new System.EventHandler(this.home_form_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.home_form_MouseMove);
            this.leftdock_pnl.ResumeLayout(false);
            this.menu2_panel.ResumeLayout(false);
            this.menu_panel.ResumeLayout(false);
            this.logo_panel.ResumeLayout(false);
            this.movie_panel.ResumeLayout(false);
            this.movie_panel.PerformLayout();
            this.allMovie_panel.ResumeLayout(false);
            this.recentlyMovie_panel.ResumeLayout(false);
            this.viewport_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.PictureBox minimize_pb;
        private System.Windows.Forms.PictureBox close_pb;
        private System.Windows.Forms.Panel leftdock_pnl;
        private System.Windows.Forms.Panel menu2_panel;
        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.PictureBox logo_pb;
        private System.Windows.Forms.FlowLayoutPanel menu_panel;
        private System.Windows.Forms.Label form_lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonButton popular_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton settings_btn;
        private System.Windows.Forms.Panel movie_panel;
        private System.Windows.Forms.Panel viewport_panel;
        private System.Windows.Forms.FlowLayoutPanel recommendedMovie_flp;
        private System.Windows.Forms.Panel recentlyMovie_panel;
        private System.Windows.Forms.FlowLayoutPanel recentlysearch_flp;
        private ComponentFactory.Krypton.Toolkit.KryptonButton adminsettings_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton signOut_btn;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.ListBox search_list;
        private System.Windows.Forms.Label recent_lbl;
        private System.Windows.Forms.Label suggest_lbl;
        private System.Windows.Forms.Label allMovie_lbl;
        private System.Windows.Forms.Panel allMovie_panel;
        private System.Windows.Forms.FlowLayoutPanel allMovie_flp;
        private ComponentFactory.Krypton.Toolkit.KryptonButton profile_btn;
        private System.Windows.Forms.Panel AdminControl_panel;
        private System.Windows.Forms.Panel userProfile_panel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton home_btn;
        private System.Windows.Forms.Panel Favorite_panel;
        private System.Windows.Forms.Panel popular_panel;
        private System.Windows.Forms.Panel settings_panel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton favorite_btn;
    }
}