namespace OOP_Project
{
    partial class AdminControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.releaseYear_dtp = new System.Windows.Forms.DateTimePicker();
            this.title_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.movies_dgv = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.posterUrl_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.remove_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.update_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.insert_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchBox_tb = new System.Windows.Forms.TextBox();
            this.genre_clb = new System.Windows.Forms.CheckedListBox();
            this.description_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.submit_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Admin_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo_pb = new System.Windows.Forms.PictureBox();
            this.editUser_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.editMovie_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.userEditor_panel = new System.Windows.Forms.Panel();
            this.userSearchBox_tb = new System.Windows.Forms.TextBox();
            this.usersEditor_lbl = new System.Windows.Forms.Label();
            this.userID_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.emailVerified_cb = new System.Windows.Forms.CheckBox();
            this.gender_cmb = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.deleteUser_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.verify_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Genre_lbl = new System.Windows.Forms.Label();
            this.Birthdate_dtp = new System.Windows.Forms.DateTimePicker();
            this.securityAnswer_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.securityQuestion_cmb = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.userGenre_clb = new System.Windows.Forms.CheckedListBox();
            this.age_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.email_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.username_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.users_dgv = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.saveUser_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.movieEditor_panel = new System.Windows.Forms.Panel();
            this.movieEditor_lbl = new System.Windows.Forms.Label();
            this.poster_pb = new System.Windows.Forms.PictureBox();
            this.insertUser_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.movies_dgv)).BeginInit();
            this.Admin_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            this.userEditor_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gender_cmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityQuestion_cmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_dgv)).BeginInit();
            this.movieEditor_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // releaseYear_dtp
            // 
            this.releaseYear_dtp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseYear_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.releaseYear_dtp.Location = new System.Drawing.Point(361, 188);
            this.releaseYear_dtp.Name = "releaseYear_dtp";
            this.releaseYear_dtp.Size = new System.Drawing.Size(189, 26);
            this.releaseYear_dtp.TabIndex = 79;
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(361, 82);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(250, 26);
            this.title_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_tb.TabIndex = 77;
            this.title_tb.Text = "Title";
            // 
            // movies_dgv
            // 
            this.movies_dgv.AllowUserToAddRows = false;
            this.movies_dgv.AllowUserToDeleteRows = false;
            this.movies_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.movies_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.movies_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movies_dgv.Location = new System.Drawing.Point(22, 334);
            this.movies_dgv.Name = "movies_dgv";
            this.movies_dgv.ReadOnly = true;
            this.movies_dgv.Size = new System.Drawing.Size(912, 214);
            this.movies_dgv.StateCommon.Background.Color1 = System.Drawing.Color.Red;
            this.movies_dgv.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.movies_dgv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.movies_dgv.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.movies_dgv.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.movies_dgv.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.movies_dgv.StateCommon.DataCell.Border.Rounding = 5;
            this.movies_dgv.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.movies_dgv.StateCommon.HeaderColumn.Border.Rounding = 5;
            this.movies_dgv.TabIndex = 75;
            this.movies_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movies_dgv_CellClick);
            // 
            // posterUrl_tb
            // 
            this.posterUrl_tb.Location = new System.Drawing.Point(361, 135);
            this.posterUrl_tb.Name = "posterUrl_tb";
            this.posterUrl_tb.Size = new System.Drawing.Size(189, 26);
            this.posterUrl_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posterUrl_tb.TabIndex = 81;
            this.posterUrl_tb.Text = "Poster URL";
            // 
            // remove_btn
            // 
            this.remove_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.remove_btn.Location = new System.Drawing.Point(8, 125);
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
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.update_btn.Location = new System.Drawing.Point(8, 178);
            this.update_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(132, 45);
            this.update_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.update_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.update_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.update_btn.StateCommon.Border.Rounding = 20;
            this.update_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.update_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.update_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.update_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.update_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.update_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.update_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.update_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.update_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.update_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.update_btn.TabIndex = 82;
            this.update_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_submit_281;
            this.update_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.update_btn.Values.Text = "Update";
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.insert_btn.Location = new System.Drawing.Point(8, 72);
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
            // searchBox_tb
            // 
            this.searchBox_tb.Location = new System.Drawing.Point(668, 294);
            this.searchBox_tb.Name = "searchBox_tb";
            this.searchBox_tb.Size = new System.Drawing.Size(266, 20);
            this.searchBox_tb.TabIndex = 84;
            this.searchBox_tb.TextChanged += new System.EventHandler(this.searchBox_tb_TextChanged);
            // 
            // genre_clb
            // 
            this.genre_clb.FormattingEnabled = true;
            this.genre_clb.Location = new System.Drawing.Point(643, 81);
            this.genre_clb.MultiColumn = true;
            this.genre_clb.Name = "genre_clb";
            this.genre_clb.Size = new System.Drawing.Size(291, 139);
            this.genre_clb.TabIndex = 86;
            // 
            // description_tb
            // 
            this.description_tb.Location = new System.Drawing.Point(361, 228);
            this.description_tb.Multiline = true;
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(250, 77);
            this.description_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_tb.TabIndex = 87;
            this.description_tb.Text = "Description";
            // 
            // submit_btn
            // 
            this.submit_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.submit_btn.Location = new System.Drawing.Point(802, 228);
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
            this.submit_btn.TabIndex = 85;
            this.submit_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_submit_282;
            this.submit_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.submit_btn.Values.Text = "Submit";
            this.submit_btn.Visible = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // Admin_panel
            // 
            this.Admin_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Admin_panel.Controls.Add(this.panel1);
            this.Admin_panel.Controls.Add(this.movieEditor_panel);
            this.Admin_panel.Controls.Add(this.userEditor_panel);
            this.Admin_panel.Location = new System.Drawing.Point(3, 3);
            this.Admin_panel.Name = "Admin_panel";
            this.Admin_panel.Size = new System.Drawing.Size(1214, 614);
            this.Admin_panel.TabIndex = 87;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logo_pb);
            this.panel1.Controls.Add(this.editUser_btn);
            this.panel1.Controls.Add(this.editMovie_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 614);
            this.panel1.TabIndex = 89;
            // 
            // logo_pb
            // 
            this.logo_pb.BackColor = System.Drawing.Color.White;
            this.logo_pb.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_pb.Image = global::OOP_Project.Properties.Resources._1_2;
            this.logo_pb.Location = new System.Drawing.Point(0, 0);
            this.logo_pb.Name = "logo_pb";
            this.logo_pb.Size = new System.Drawing.Size(181, 164);
            this.logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_pb.TabIndex = 91;
            this.logo_pb.TabStop = false;
            // 
            // editUser_btn
            // 
            this.editUser_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.editUser_btn.Location = new System.Drawing.Point(6, 263);
            this.editUser_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.editUser_btn.Name = "editUser_btn";
            this.editUser_btn.Size = new System.Drawing.Size(172, 45);
            this.editUser_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.editUser_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.editUser_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editUser_btn.StateCommon.Border.Rounding = 20;
            this.editUser_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.editUser_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.editUser_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.editUser_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.editUser_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.editUser_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editUser_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editUser_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editUser_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editUser_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editUser_btn.TabIndex = 90;
            this.editUser_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_user_28;
            this.editUser_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.editUser_btn.Values.Text = "Edit User";
            this.editUser_btn.Click += new System.EventHandler(this.editUser_btn_Click);
            // 
            // editMovie_btn
            // 
            this.editMovie_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.editMovie_btn.Location = new System.Drawing.Point(6, 191);
            this.editMovie_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.editMovie_btn.Name = "editMovie_btn";
            this.editMovie_btn.Size = new System.Drawing.Size(172, 45);
            this.editMovie_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.editMovie_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.editMovie_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editMovie_btn.StateCommon.Border.Rounding = 20;
            this.editMovie_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.editMovie_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.editMovie_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.editMovie_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.editMovie_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.editMovie_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editMovie_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editMovie_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editMovie_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editMovie_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editMovie_btn.TabIndex = 89;
            this.editMovie_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_insert_column_right_28;
            this.editMovie_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.editMovie_btn.Values.Text = "Edit Movie";
            this.editMovie_btn.Click += new System.EventHandler(this.editMovie_btn_Click);
            // 
            // userEditor_panel
            // 
            this.userEditor_panel.Controls.Add(this.insertUser_btn);
            this.userEditor_panel.Controls.Add(this.userSearchBox_tb);
            this.userEditor_panel.Controls.Add(this.usersEditor_lbl);
            this.userEditor_panel.Controls.Add(this.userID_tb);
            this.userEditor_panel.Controls.Add(this.emailVerified_cb);
            this.userEditor_panel.Controls.Add(this.gender_cmb);
            this.userEditor_panel.Controls.Add(this.deleteUser_btn);
            this.userEditor_panel.Controls.Add(this.verify_btn);
            this.userEditor_panel.Controls.Add(this.Genre_lbl);
            this.userEditor_panel.Controls.Add(this.Birthdate_dtp);
            this.userEditor_panel.Controls.Add(this.securityAnswer_tb);
            this.userEditor_panel.Controls.Add(this.securityQuestion_cmb);
            this.userEditor_panel.Controls.Add(this.userGenre_clb);
            this.userEditor_panel.Controls.Add(this.age_tb);
            this.userEditor_panel.Controls.Add(this.email_tb);
            this.userEditor_panel.Controls.Add(this.username_tb);
            this.userEditor_panel.Controls.Add(this.users_dgv);
            this.userEditor_panel.Controls.Add(this.saveUser_btn);
            this.userEditor_panel.Location = new System.Drawing.Point(189, 2);
            this.userEditor_panel.Name = "userEditor_panel";
            this.userEditor_panel.Size = new System.Drawing.Size(1024, 632);
            this.userEditor_panel.TabIndex = 89;
            this.userEditor_panel.Visible = false;
            // 
            // userSearchBox_tb
            // 
            this.userSearchBox_tb.Location = new System.Drawing.Point(686, 291);
            this.userSearchBox_tb.Name = "userSearchBox_tb";
            this.userSearchBox_tb.Size = new System.Drawing.Size(266, 20);
            this.userSearchBox_tb.TabIndex = 100;
            this.userSearchBox_tb.Click += new System.EventHandler(this.userSearchBox_tb_Click);
            this.userSearchBox_tb.TextChanged += new System.EventHandler(this.userSearchBox_tb_TextChanged);
            // 
            // usersEditor_lbl
            // 
            this.usersEditor_lbl.AutoSize = true;
            this.usersEditor_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersEditor_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usersEditor_lbl.Location = new System.Drawing.Point(24, 20);
            this.usersEditor_lbl.Name = "usersEditor_lbl";
            this.usersEditor_lbl.Size = new System.Drawing.Size(142, 26);
            this.usersEditor_lbl.TabIndex = 99;
            this.usersEditor_lbl.Text = "Users Editor";
            // 
            // userID_tb
            // 
            this.userID_tb.Location = new System.Drawing.Point(229, 81);
            this.userID_tb.Name = "userID_tb";
            this.userID_tb.Size = new System.Drawing.Size(93, 26);
            this.userID_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID_tb.TabIndex = 98;
            this.userID_tb.Text = "User ID";
            // 
            // emailVerified_cb
            // 
            this.emailVerified_cb.AutoSize = true;
            this.emailVerified_cb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailVerified_cb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailVerified_cb.Location = new System.Drawing.Point(702, 49);
            this.emailVerified_cb.Name = "emailVerified_cb";
            this.emailVerified_cb.Size = new System.Drawing.Size(122, 23);
            this.emailVerified_cb.TabIndex = 97;
            this.emailVerified_cb.Text = "Is email verified";
            this.emailVerified_cb.UseVisualStyleBackColor = true;
            // 
            // gender_cmb
            // 
            this.gender_cmb.DropDownWidth = 183;
            this.gender_cmb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
            this.gender_cmb.Location = new System.Drawing.Point(229, 200);
            this.gender_cmb.Name = "gender_cmb";
            this.gender_cmb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gender_cmb.Size = new System.Drawing.Size(93, 20);
            this.gender_cmb.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.gender_cmb.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_cmb.TabIndex = 96;
            this.gender_cmb.Text = "N/A";
            // 
            // deleteUser_btn
            // 
            this.deleteUser_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.deleteUser_btn.Location = new System.Drawing.Point(20, 189);
            this.deleteUser_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.deleteUser_btn.Name = "deleteUser_btn";
            this.deleteUser_btn.Size = new System.Drawing.Size(132, 45);
            this.deleteUser_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.deleteUser_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.deleteUser_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteUser_btn.StateCommon.Border.Rounding = 20;
            this.deleteUser_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.deleteUser_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.deleteUser_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.deleteUser_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.deleteUser_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.deleteUser_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteUser_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteUser_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteUser_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteUser_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteUser_btn.TabIndex = 95;
            this.deleteUser_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_insert_column_right_28;
            this.deleteUser_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.deleteUser_btn.Values.Text = "Delete";
            this.deleteUser_btn.Click += new System.EventHandler(this.deleteUser_btn_Click);
            // 
            // verify_btn
            // 
            this.verify_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.verify_btn.Location = new System.Drawing.Point(829, 40);
            this.verify_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.verify_btn.Name = "verify_btn";
            this.verify_btn.Size = new System.Drawing.Size(105, 49);
            this.verify_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.verify_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.verify_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.verify_btn.StateCommon.Border.Rounding = 20;
            this.verify_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.verify_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.verify_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.verify_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.verify_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.verify_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.verify_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.verify_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.verify_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.verify_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.verify_btn.TabIndex = 94;
            this.verify_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_insert_column_right_28;
            this.verify_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.verify_btn.Values.Text = "Verify";
            this.verify_btn.Click += new System.EventHandler(this.verify_btn_Click);
            // 
            // Genre_lbl
            // 
            this.Genre_lbl.AutoSize = true;
            this.Genre_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Genre_lbl.Location = new System.Drawing.Point(476, 116);
            this.Genre_lbl.Name = "Genre_lbl";
            this.Genre_lbl.Size = new System.Drawing.Size(124, 19);
            this.Genre_lbl.TabIndex = 93;
            this.Genre_lbl.Text = "Genre Preferences:";
            // 
            // Birthdate_dtp
            // 
            this.Birthdate_dtp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthdate_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthdate_dtp.Location = new System.Drawing.Point(475, 48);
            this.Birthdate_dtp.Name = "Birthdate_dtp";
            this.Birthdate_dtp.Size = new System.Drawing.Size(200, 26);
            this.Birthdate_dtp.TabIndex = 91;
            // 
            // securityAnswer_tb
            // 
            this.securityAnswer_tb.Location = new System.Drawing.Point(229, 269);
            this.securityAnswer_tb.Name = "securityAnswer_tb";
            this.securityAnswer_tb.Size = new System.Drawing.Size(213, 26);
            this.securityAnswer_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityAnswer_tb.TabIndex = 90;
            this.securityAnswer_tb.Text = "Title";
            // 
            // securityQuestion_cmb
            // 
            this.securityQuestion_cmb.DropDownWidth = 183;
            this.securityQuestion_cmb.Location = new System.Drawing.Point(229, 235);
            this.securityQuestion_cmb.Name = "securityQuestion_cmb";
            this.securityQuestion_cmb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.securityQuestion_cmb.Size = new System.Drawing.Size(213, 20);
            this.securityQuestion_cmb.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.securityQuestion_cmb.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityQuestion_cmb.TabIndex = 88;
            this.securityQuestion_cmb.Text = "N/A";
            // 
            // userGenre_clb
            // 
            this.userGenre_clb.FormattingEnabled = true;
            this.userGenre_clb.Location = new System.Drawing.Point(480, 146);
            this.userGenre_clb.MultiColumn = true;
            this.userGenre_clb.Name = "userGenre_clb";
            this.userGenre_clb.Size = new System.Drawing.Size(454, 124);
            this.userGenre_clb.TabIndex = 86;
            // 
            // age_tb
            // 
            this.age_tb.Location = new System.Drawing.Point(229, 157);
            this.age_tb.Name = "age_tb";
            this.age_tb.Size = new System.Drawing.Size(93, 26);
            this.age_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_tb.TabIndex = 84;
            this.age_tb.Text = "Age";
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(229, 113);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(213, 26);
            this.email_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_tb.TabIndex = 83;
            this.email_tb.Text = "Email";
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(229, 48);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(213, 26);
            this.username_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.TabIndex = 82;
            this.username_tb.Text = "Username";
            // 
            // users_dgv
            // 
            this.users_dgv.AllowUserToAddRows = false;
            this.users_dgv.AllowUserToDeleteRows = false;
            this.users_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.users_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.users_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_dgv.Location = new System.Drawing.Point(40, 329);
            this.users_dgv.Name = "users_dgv";
            this.users_dgv.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.users_dgv.Size = new System.Drawing.Size(912, 260);
            this.users_dgv.StateCommon.Background.Color1 = System.Drawing.Color.Red;
            this.users_dgv.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.users_dgv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.users_dgv.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.users_dgv.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.users_dgv.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.users_dgv.StateCommon.DataCell.Border.Rounding = 5;
            this.users_dgv.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.users_dgv.StateCommon.HeaderColumn.Border.Rounding = 5;
            this.users_dgv.TabIndex = 81;
            this.users_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_dgv_CellClick);
            // 
            // saveUser_btn
            // 
            this.saveUser_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.saveUser_btn.Location = new System.Drawing.Point(20, 126);
            this.saveUser_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.saveUser_btn.Name = "saveUser_btn";
            this.saveUser_btn.Size = new System.Drawing.Size(132, 45);
            this.saveUser_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.saveUser_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.saveUser_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.saveUser_btn.StateCommon.Border.Rounding = 20;
            this.saveUser_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.saveUser_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.saveUser_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.saveUser_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.saveUser_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.saveUser_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveUser_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveUser_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveUser_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveUser_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.saveUser_btn.TabIndex = 80;
            this.saveUser_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_insert_column_right_28;
            this.saveUser_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.saveUser_btn.Values.Text = "Save";
            this.saveUser_btn.Click += new System.EventHandler(this.saveUser_btn_Click);
            // 
            // movieEditor_panel
            // 
            this.movieEditor_panel.Controls.Add(this.movieEditor_lbl);
            this.movieEditor_panel.Controls.Add(this.poster_pb);
            this.movieEditor_panel.Controls.Add(this.submit_btn);
            this.movieEditor_panel.Controls.Add(this.description_tb);
            this.movieEditor_panel.Controls.Add(this.releaseYear_dtp);
            this.movieEditor_panel.Controls.Add(this.genre_clb);
            this.movieEditor_panel.Controls.Add(this.title_tb);
            this.movieEditor_panel.Controls.Add(this.movies_dgv);
            this.movieEditor_panel.Controls.Add(this.posterUrl_tb);
            this.movieEditor_panel.Controls.Add(this.searchBox_tb);
            this.movieEditor_panel.Controls.Add(this.remove_btn);
            this.movieEditor_panel.Controls.Add(this.update_btn);
            this.movieEditor_panel.Controls.Add(this.insert_btn);
            this.movieEditor_panel.Location = new System.Drawing.Point(187, 3);
            this.movieEditor_panel.Name = "movieEditor_panel";
            this.movieEditor_panel.Size = new System.Drawing.Size(1024, 632);
            this.movieEditor_panel.TabIndex = 88;
            this.movieEditor_panel.Visible = false;
            // 
            // movieEditor_lbl
            // 
            this.movieEditor_lbl.AutoSize = true;
            this.movieEditor_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.movieEditor_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.movieEditor_lbl.Location = new System.Drawing.Point(27, 19);
            this.movieEditor_lbl.Name = "movieEditor_lbl";
            this.movieEditor_lbl.Size = new System.Drawing.Size(149, 26);
            this.movieEditor_lbl.TabIndex = 88;
            this.movieEditor_lbl.Text = "Movie Editor";
            // 
            // poster_pb
            // 
            this.poster_pb.BackColor = System.Drawing.Color.White;
            this.poster_pb.Image = global::OOP_Project.Properties.Resources._1_2;
            this.poster_pb.Location = new System.Drawing.Point(146, 70);
            this.poster_pb.Name = "poster_pb";
            this.poster_pb.Size = new System.Drawing.Size(183, 235);
            this.poster_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.poster_pb.TabIndex = 83;
            this.poster_pb.TabStop = false;
            // 
            // insertUser_btn
            // 
            this.insertUser_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.insertUser_btn.Location = new System.Drawing.Point(20, 73);
            this.insertUser_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.insertUser_btn.Name = "insertUser_btn";
            this.insertUser_btn.Size = new System.Drawing.Size(132, 45);
            this.insertUser_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.insertUser_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.insertUser_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.insertUser_btn.StateCommon.Border.Rounding = 20;
            this.insertUser_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.insertUser_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.insertUser_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.insertUser_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.insertUser_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.insertUser_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insertUser_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insertUser_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insertUser_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insertUser_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.insertUser_btn.TabIndex = 101;
            this.insertUser_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_submit_281;
            this.insertUser_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.insertUser_btn.Values.Text = "Insert";
            this.insertUser_btn.Click += new System.EventHandler(this.insertUser_btn_Click);
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Admin_panel);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(1214, 614);
            this.Load += new System.EventHandler(this.AdminMovieControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movies_dgv)).EndInit();
            this.Admin_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            this.userEditor_panel.ResumeLayout(false);
            this.userEditor_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gender_cmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityQuestion_cmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_dgv)).EndInit();
            this.movieEditor_panel.ResumeLayout(false);
            this.movieEditor_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker releaseYear_dtp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox title_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView movies_dgv;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox posterUrl_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonButton remove_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton update_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton insert_btn;
        private System.Windows.Forms.TextBox searchBox_tb;
        private System.Windows.Forms.PictureBox poster_pb;
        private System.Windows.Forms.CheckedListBox genre_clb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox description_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonButton submit_btn;
        private System.Windows.Forms.Panel Admin_panel;
        private System.Windows.Forms.Panel movieEditor_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo_pb;
        private ComponentFactory.Krypton.Toolkit.KryptonButton editUser_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton editMovie_btn;
        private System.Windows.Forms.Label movieEditor_lbl;
        private System.Windows.Forms.Panel userEditor_panel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox username_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView users_dgv;
        private ComponentFactory.Krypton.Toolkit.KryptonButton saveUser_btn;
        private System.Windows.Forms.CheckedListBox userGenre_clb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox age_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox email_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox securityAnswer_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox securityQuestion_cmb;
        private System.Windows.Forms.Label Genre_lbl;
        private System.Windows.Forms.DateTimePicker Birthdate_dtp;
        private ComponentFactory.Krypton.Toolkit.KryptonButton verify_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteUser_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox gender_cmb;
        private System.Windows.Forms.CheckBox emailVerified_cb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox userID_tb;
        private System.Windows.Forms.Label usersEditor_lbl;
        private System.Windows.Forms.TextBox userSearchBox_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonButton insertUser_btn;
    }
}
