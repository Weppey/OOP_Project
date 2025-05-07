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
            this.movie_panel = new System.Windows.Forms.Panel();
            this.comment_lbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.commentBorder_panel = new System.Windows.Forms.Panel();
            this.comments_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.comment_tb = new System.Windows.Forms.TextBox();
            this.submit_comment_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ratings_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ratings_panel = new System.Windows.Forms.Panel();
            this.ratingStar5_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ratingStar4_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ratingStar3_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ratingStar2_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ratingStar1_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.title_lbl = new System.Windows.Forms.Label();
            this.comment_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.favorite_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.movieDetails_panel = new System.Windows.Forms.Panel();
            this.description_lbl = new System.Windows.Forms.Label();
            this.genre_lbl = new System.Windows.Forms.Label();
            this.dateRelease_lbl = new System.Windows.Forms.Label();
            this.navigationDock_panel = new System.Windows.Forms.Panel();
            this.watch_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.close_pb = new System.Windows.Forms.PictureBox();
            this.poster_pb = new System.Windows.Forms.PictureBox();
            this.movie_panel.SuspendLayout();
            this.commentBorder_panel.SuspendLayout();
            this.ratings_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.movieDetails_panel.SuspendLayout();
            this.navigationDock_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poster_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // movie_panel
            // 
            this.movie_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.movie_panel.Controls.Add(this.watch_btn);
            this.movie_panel.Controls.Add(this.comment_lbl);
            this.movie_panel.Controls.Add(this.commentBorder_panel);
            this.movie_panel.Controls.Add(this.ratings_btn);
            this.movie_panel.Controls.Add(this.ratings_panel);
            this.movie_panel.Controls.Add(this.webView21);
            this.movie_panel.Controls.Add(this.title_lbl);
            this.movie_panel.Controls.Add(this.comment_btn);
            this.movie_panel.Controls.Add(this.favorite_btn);
            this.movie_panel.Controls.Add(this.movieDetails_panel);
            this.movie_panel.Location = new System.Drawing.Point(39, 65);
            this.movie_panel.Name = "movie_panel";
            this.movie_panel.Size = new System.Drawing.Size(979, 573);
            this.movie_panel.TabIndex = 66;
            // 
            // comment_lbl
            // 
            this.comment_lbl.Location = new System.Drawing.Point(18, 572);
            this.comment_lbl.Name = "comment_lbl";
            this.comment_lbl.Size = new System.Drawing.Size(120, 28);
            this.comment_lbl.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.comment_lbl.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.comment_lbl.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comment_lbl.TabIndex = 83;
            this.comment_lbl.Values.Text = "Comments:";
            // 
            // commentBorder_panel
            // 
            this.commentBorder_panel.AutoSize = true;
            this.commentBorder_panel.BackColor = System.Drawing.Color.White;
            this.commentBorder_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentBorder_panel.Controls.Add(this.comments_panel);
            this.commentBorder_panel.Controls.Add(this.comment_tb);
            this.commentBorder_panel.Controls.Add(this.submit_comment_btn);
            this.commentBorder_panel.Location = new System.Drawing.Point(18, 606);
            this.commentBorder_panel.Name = "commentBorder_panel";
            this.commentBorder_panel.Size = new System.Drawing.Size(932, 191);
            this.commentBorder_panel.TabIndex = 82;
            // 
            // comments_panel
            // 
            this.comments_panel.AutoSize = true;
            this.comments_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.comments_panel.Location = new System.Drawing.Point(26, 87);
            this.comments_panel.Name = "comments_panel";
            this.comments_panel.Size = new System.Drawing.Size(891, 99);
            this.comments_panel.TabIndex = 81;
            // 
            // comment_tb
            // 
            this.comment_tb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comment_tb.ForeColor = System.Drawing.Color.Gray;
            this.comment_tb.Location = new System.Drawing.Point(26, 18);
            this.comment_tb.Multiline = true;
            this.comment_tb.Name = "comment_tb";
            this.comment_tb.Size = new System.Drawing.Size(736, 53);
            this.comment_tb.TabIndex = 80;
            this.comment_tb.Text = "Enter comments...";
            this.comment_tb.Visible = false;
            this.comment_tb.Enter += new System.EventHandler(this.comment_tb_Enter);
            this.comment_tb.Leave += new System.EventHandler(this.comment_tb_Leave);
            // 
            // submit_comment_btn
            // 
            this.submit_comment_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.submit_comment_btn.Location = new System.Drawing.Point(772, 15);
            this.submit_comment_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.submit_comment_btn.Name = "submit_comment_btn";
            this.submit_comment_btn.Size = new System.Drawing.Size(145, 56);
            this.submit_comment_btn.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.submit_comment_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.submit_comment_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.submit_comment_btn.StateCommon.Border.Rounding = 20;
            this.submit_comment_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.submit_comment_btn.StateDisabled.Back.Color1 = System.Drawing.Color.Cyan;
            this.submit_comment_btn.StateDisabled.Back.Color2 = System.Drawing.Color.Blue;
            this.submit_comment_btn.StateNormal.Back.Color1 = System.Drawing.Color.Cyan;
            this.submit_comment_btn.StateNormal.Back.Color2 = System.Drawing.Color.Blue;
            this.submit_comment_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.submit_comment_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.submit_comment_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.submit_comment_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.submit_comment_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.submit_comment_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.submit_comment_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.submit_comment_btn.TabIndex = 79;
            this.submit_comment_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_insert_column_right_28;
            this.submit_comment_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.submit_comment_btn.Values.Text = "Submit";
            this.submit_comment_btn.Visible = false;
            this.submit_comment_btn.Click += new System.EventHandler(this.submit_comment_btn_Click);
            // 
            // ratings_btn
            // 
            this.ratings_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.ratings_btn.Location = new System.Drawing.Point(288, 492);
            this.ratings_btn.Name = "ratings_btn";
            this.ratings_btn.Size = new System.Drawing.Size(45, 45);
            this.ratings_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.ratings_btn.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.ratings_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ratings_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ratings_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ratings_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ratings_btn.TabIndex = 77;
            this.ratings_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_rating_28__1_;
            this.ratings_btn.Values.Text = "";
            this.ratings_btn.Click += new System.EventHandler(this.ratings_btn_Click);
            // 
            // ratings_panel
            // 
            this.ratings_panel.BackColor = System.Drawing.Color.Gray;
            this.ratings_panel.Controls.Add(this.ratingStar5_btn);
            this.ratings_panel.Controls.Add(this.ratingStar4_btn);
            this.ratings_panel.Controls.Add(this.ratingStar3_btn);
            this.ratings_panel.Controls.Add(this.ratingStar2_btn);
            this.ratings_panel.Controls.Add(this.ratingStar1_btn);
            this.ratings_panel.Location = new System.Drawing.Point(334, 492);
            this.ratings_panel.Margin = new System.Windows.Forms.Padding(10);
            this.ratings_panel.Name = "ratings_panel";
            this.ratings_panel.Padding = new System.Windows.Forms.Padding(3);
            this.ratings_panel.Size = new System.Drawing.Size(195, 45);
            this.ratings_panel.TabIndex = 76;
            this.ratings_panel.Visible = false;
            // 
            // ratingStar5_btn
            // 
            this.ratingStar5_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.ratingStar5_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ratingStar5_btn.Location = new System.Drawing.Point(151, 3);
            this.ratingStar5_btn.Name = "ratingStar5_btn";
            this.ratingStar5_btn.Size = new System.Drawing.Size(37, 39);
            this.ratingStar5_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.ratingStar5_btn.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.ratingStar5_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ratingStar5_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ratingStar5_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ratingStar5_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ratingStar5_btn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.ratingStar5_btn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.ratingStar5_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ratingStar5_btn.TabIndex = 74;
            this.ratingStar5_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_star_white;
            this.ratingStar5_btn.Values.Text = "";
            // 
            // ratingStar4_btn
            // 
            this.ratingStar4_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.ratingStar4_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ratingStar4_btn.Location = new System.Drawing.Point(114, 3);
            this.ratingStar4_btn.Name = "ratingStar4_btn";
            this.ratingStar4_btn.Size = new System.Drawing.Size(37, 39);
            this.ratingStar4_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.ratingStar4_btn.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.ratingStar4_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ratingStar4_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ratingStar4_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ratingStar4_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ratingStar4_btn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.ratingStar4_btn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.ratingStar4_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ratingStar4_btn.TabIndex = 75;
            this.ratingStar4_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_star_white;
            this.ratingStar4_btn.Values.Text = "";
            // 
            // ratingStar3_btn
            // 
            this.ratingStar3_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.ratingStar3_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ratingStar3_btn.Location = new System.Drawing.Point(77, 3);
            this.ratingStar3_btn.Name = "ratingStar3_btn";
            this.ratingStar3_btn.Size = new System.Drawing.Size(37, 39);
            this.ratingStar3_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.ratingStar3_btn.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.ratingStar3_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ratingStar3_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ratingStar3_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ratingStar3_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ratingStar3_btn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.ratingStar3_btn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.ratingStar3_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ratingStar3_btn.TabIndex = 71;
            this.ratingStar3_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_star_white;
            this.ratingStar3_btn.Values.Text = "";
            // 
            // ratingStar2_btn
            // 
            this.ratingStar2_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.ratingStar2_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ratingStar2_btn.Location = new System.Drawing.Point(40, 3);
            this.ratingStar2_btn.Name = "ratingStar2_btn";
            this.ratingStar2_btn.Size = new System.Drawing.Size(37, 39);
            this.ratingStar2_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.ratingStar2_btn.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.ratingStar2_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ratingStar2_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ratingStar2_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ratingStar2_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ratingStar2_btn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.ratingStar2_btn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.ratingStar2_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ratingStar2_btn.TabIndex = 72;
            this.ratingStar2_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_star_white;
            this.ratingStar2_btn.Values.Text = "";
            // 
            // ratingStar1_btn
            // 
            this.ratingStar1_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.ratingStar1_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ratingStar1_btn.Location = new System.Drawing.Point(3, 3);
            this.ratingStar1_btn.Name = "ratingStar1_btn";
            this.ratingStar1_btn.Size = new System.Drawing.Size(37, 39);
            this.ratingStar1_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.ratingStar1_btn.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.ratingStar1_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ratingStar1_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ratingStar1_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ratingStar1_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ratingStar1_btn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.ratingStar1_btn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.ratingStar1_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ratingStar1_btn.TabIndex = 73;
            this.ratingStar1_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_star_white;
            this.ratingStar1_btn.Values.Text = "";
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(292, 82);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(644, 393);
            this.webView21.TabIndex = 70;
            this.webView21.ZoomFactor = 1D;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.BackColor = System.Drawing.Color.Transparent;
            this.title_lbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title_lbl.Location = new System.Drawing.Point(39, 19);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Padding = new System.Windows.Forms.Padding(12);
            this.title_lbl.Size = new System.Drawing.Size(98, 60);
            this.title_lbl.TabIndex = 65;
            this.title_lbl.Text = "Title";
            // 
            // comment_btn
            // 
            this.comment_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.comment_btn.Location = new System.Drawing.Point(649, 492);
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
            this.comment_btn.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.comment_btn.StateNormal.Back.Color2 = System.Drawing.Color.Gainsboro;
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
            this.comment_btn.Click += new System.EventHandler(this.comment_btn_Click_1);
            // 
            // favorite_btn
            // 
            this.favorite_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.favorite_btn.Location = new System.Drawing.Point(804, 492);
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
            this.favorite_btn.Click += new System.EventHandler(this.favorite_btn_Click);
            // 
            // movieDetails_panel
            // 
            this.movieDetails_panel.AutoSize = true;
            this.movieDetails_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.movieDetails_panel.Controls.Add(this.description_lbl);
            this.movieDetails_panel.Controls.Add(this.genre_lbl);
            this.movieDetails_panel.Controls.Add(this.poster_pb);
            this.movieDetails_panel.Controls.Add(this.dateRelease_lbl);
            this.movieDetails_panel.Location = new System.Drawing.Point(45, 82);
            this.movieDetails_panel.Margin = new System.Windows.Forms.Padding(10);
            this.movieDetails_panel.Name = "movieDetails_panel";
            this.movieDetails_panel.Size = new System.Drawing.Size(210, 454);
            this.movieDetails_panel.TabIndex = 67;
            // 
            // description_lbl
            // 
            this.description_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.description_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.description_lbl.Location = new System.Drawing.Point(-3, 329);
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Padding = new System.Windows.Forms.Padding(20);
            this.description_lbl.Size = new System.Drawing.Size(210, 125);
            this.description_lbl.TabIndex = 31;
            this.description_lbl.Text = "Description";
            this.description_lbl.Click += new System.EventHandler(this.description_lbl_Click);
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
            // navigationDock_panel
            // 
            this.navigationDock_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.navigationDock_panel.Controls.Add(this.close_pb);
            this.navigationDock_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationDock_panel.Location = new System.Drawing.Point(0, 0);
            this.navigationDock_panel.Name = "navigationDock_panel";
            this.navigationDock_panel.Size = new System.Drawing.Size(1053, 32);
            this.navigationDock_panel.TabIndex = 67;
            // 
            // watch_btn
            // 
            this.watch_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.watch_btn.Location = new System.Drawing.Point(804, 34);
            this.watch_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.watch_btn.Name = "watch_btn";
            this.watch_btn.Size = new System.Drawing.Size(132, 45);
            this.watch_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.watch_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.watch_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.watch_btn.StateCommon.Border.Rounding = 20;
            this.watch_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.watch_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.watch_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.watch_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.watch_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.watch_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.watch_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.watch_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.watch_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.watch_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.watch_btn.TabIndex = 84;
            this.watch_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_play_20;
            this.watch_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.watch_btn.Values.Text = "Watch";
            this.watch_btn.Click += new System.EventHandler(this.watch_btn_Click);
            // 
            // close_pb
            // 
            this.close_pb.BackColor = System.Drawing.Color.Transparent;
            this.close_pb.Image = global::OOP_Project.Properties.Resources.icons8_close_24;
            this.close_pb.Location = new System.Drawing.Point(1018, 6);
            this.close_pb.Name = "close_pb";
            this.close_pb.Size = new System.Drawing.Size(25, 23);
            this.close_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_pb.TabIndex = 18;
            this.close_pb.TabStop = false;
            this.close_pb.Click += new System.EventHandler(this.close_pb_Click);
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
            // movie_details_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 669);
            this.Controls.Add(this.navigationDock_panel);
            this.Controls.Add(this.movie_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "movie_details_form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 15;
            this.Text = "MovieDetailsForm";
            this.Load += new System.EventHandler(this.MovieDetailsForm_Load);
            this.movie_panel.ResumeLayout(false);
            this.movie_panel.PerformLayout();
            this.commentBorder_panel.ResumeLayout(false);
            this.commentBorder_panel.PerformLayout();
            this.ratings_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.movieDetails_panel.ResumeLayout(false);
            this.movieDetails_panel.PerformLayout();
            this.navigationDock_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poster_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox close_pb;
        private System.Windows.Forms.Panel movie_panel;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel movieDetails_panel;
        private System.Windows.Forms.Label genre_lbl;
        private System.Windows.Forms.PictureBox poster_pb;
        private System.Windows.Forms.Label dateRelease_lbl;
        private System.Windows.Forms.Label description_lbl;
        private System.Windows.Forms.Panel navigationDock_panel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton comment_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton favorite_btn;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ratingStar3_btn;
        private System.Windows.Forms.Panel ratings_panel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ratingStar5_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ratingStar4_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ratingStar2_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ratingStar1_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ratings_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton submit_comment_btn;
        private System.Windows.Forms.TextBox comment_tb;
        private System.Windows.Forms.FlowLayoutPanel comments_panel;
        private System.Windows.Forms.Panel commentBorder_panel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel comment_lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonButton watch_btn;
    }
}