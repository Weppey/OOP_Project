using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.releaseYear_dtp = new System.Windows.Forms.DateTimePicker();
            this.title_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.movies_dgv = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.posterUrl_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.remove_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.update_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Clear_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchBox_tb = new System.Windows.Forms.TextBox();
            this.genre_clb = new System.Windows.Forms.CheckedListBox();
            this.description_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.insert_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Admin_panel = new System.Windows.Forms.Panel();
            this.buttonDock_panel = new System.Windows.Forms.Panel();
            this.logo_pb = new System.Windows.Forms.PictureBox();
            this.editUser_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.editMovie_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.userEditor_panel = new System.Windows.Forms.Panel();
            this.dataGrid_panel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.users_dgv = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.fillup_panel = new System.Windows.Forms.Panel();
            this.avatar_pb = new System.Windows.Forms.PictureBox();
            this.email_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.username_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.usertype_cmb = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.age_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.userGenre_clb = new System.Windows.Forms.CheckedListBox();
            this.securityQuestion_cmb = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.userID_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.securityAnswer_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.emailVerified_cb = new System.Windows.Forms.CheckBox();
            this.Birthdate_dtp = new System.Windows.Forms.DateTimePicker();
            this.gender_cmb = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Genre_lbl = new System.Windows.Forms.Label();
            this.controlBtn_panel = new System.Windows.Forms.Panel();
            this.insertUser_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cancel_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.deleteUser_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.usersEditor_lbl = new System.Windows.Forms.Label();
            this.userSearchBox_tb = new System.Windows.Forms.TextBox();
            this.movieEditor_panel = new System.Windows.Forms.Panel();
            this.movieFillUp_panel = new System.Windows.Forms.Panel();
            this.trailerUrl_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.poster_pb = new System.Windows.Forms.PictureBox();
            this.movieControlBtn_panel = new System.Windows.Forms.Panel();
            this.movieEditor_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profile_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movies_dgv)).BeginInit();
            this.Admin_panel.SuspendLayout();
            this.buttonDock_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            this.userEditor_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_panel)).BeginInit();
            this.dataGrid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_dgv)).BeginInit();
            this.fillup_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertype_cmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityQuestion_cmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gender_cmb)).BeginInit();
            this.controlBtn_panel.SuspendLayout();
            this.movieEditor_panel.SuspendLayout();
            this.movieFillUp_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster_pb)).BeginInit();
            this.movieControlBtn_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // releaseYear_dtp
            // 
            this.releaseYear_dtp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseYear_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.releaseYear_dtp.Location = new System.Drawing.Point(213, 165);
            this.releaseYear_dtp.Name = "releaseYear_dtp";
            this.releaseYear_dtp.Size = new System.Drawing.Size(189, 26);
            this.releaseYear_dtp.TabIndex = 79;
            this.releaseYear_dtp.Value = new System.DateTime(2025, 4, 27, 0, 0, 0, 0);
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(213, 20);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(290, 26);
            this.title_tb.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.title_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_tb.TabIndex = 77;
            this.title_tb.Text = "Enter title...";
            this.title_tb.Enter += new System.EventHandler(this.title_tb_Enter);
            this.title_tb.Leave += new System.EventHandler(this.title_tb_Leave);
            // 
            // movies_dgv
            // 
            this.movies_dgv.AllowUserToAddRows = false;
            this.movies_dgv.AllowUserToDeleteRows = false;
            this.movies_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.movies_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.movies_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.movies_dgv.ColumnHeadersHeight = 40;
            this.movies_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.movies_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movies_dgv.Location = new System.Drawing.Point(0, 0);
            this.movies_dgv.MultiSelect = false;
            this.movies_dgv.Name = "movies_dgv";
            this.movies_dgv.ReadOnly = true;
            this.movies_dgv.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.movies_dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.movies_dgv.RowTemplate.Height = 35;
            this.movies_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movies_dgv.Size = new System.Drawing.Size(977, 275);
            this.movies_dgv.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.movies_dgv.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.movies_dgv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.movies_dgv.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.movies_dgv.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.movies_dgv.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.movies_dgv.StateCommon.DataCell.Border.Rounding = 0;
            this.movies_dgv.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.movies_dgv.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.movies_dgv.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.movies_dgv.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.movies_dgv.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.movies_dgv.StateCommon.HeaderColumn.Border.Rounding = 0;
            this.movies_dgv.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.movies_dgv.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.movies_dgv.TabIndex = 75;
            this.movies_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movies_dgv_CellClick);
            // 
            // posterUrl_tb
            // 
            this.posterUrl_tb.Location = new System.Drawing.Point(213, 57);
            this.posterUrl_tb.Multiline = true;
            this.posterUrl_tb.Name = "posterUrl_tb";
            this.posterUrl_tb.Size = new System.Drawing.Size(290, 42);
            this.posterUrl_tb.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.posterUrl_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posterUrl_tb.TabIndex = 81;
            this.posterUrl_tb.Text = "Enter poster URL...";
            this.posterUrl_tb.Enter += new System.EventHandler(this.posterUrl_tb_Enter);
            this.posterUrl_tb.Leave += new System.EventHandler(this.posterUrl_tb_Leave);
            // 
            // remove_btn
            // 
            this.remove_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.remove_btn.Location = new System.Drawing.Point(22, 131);
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
            this.update_btn.Location = new System.Drawing.Point(22, 184);
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
            // Clear_btn
            // 
            this.Clear_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.Clear_btn.Location = new System.Drawing.Point(22, 230);
            this.Clear_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(132, 45);
            this.Clear_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.Clear_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.Clear_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Clear_btn.StateCommon.Border.Rounding = 20;
            this.Clear_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Clear_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.Clear_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.Clear_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Clear_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Clear_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Clear_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Clear_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Clear_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Clear_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Clear_btn.TabIndex = 66;
            this.Clear_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_insert_column_right_28;
            this.Clear_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Clear_btn.Values.Text = "Clear";
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // searchBox_tb
            // 
            this.searchBox_tb.Location = new System.Drawing.Point(733, 348);
            this.searchBox_tb.Name = "searchBox_tb";
            this.searchBox_tb.Size = new System.Drawing.Size(266, 20);
            this.searchBox_tb.TabIndex = 84;
            this.searchBox_tb.TextChanged += new System.EventHandler(this.searchBox_tb_TextChanged);
            // 
            // genre_clb
            // 
            this.genre_clb.FormattingEnabled = true;
            this.genre_clb.Location = new System.Drawing.Point(512, 18);
            this.genre_clb.MultiColumn = true;
            this.genre_clb.Name = "genre_clb";
            this.genre_clb.Size = new System.Drawing.Size(242, 199);
            this.genre_clb.TabIndex = 86;
            // 
            // description_tb
            // 
            this.description_tb.Location = new System.Drawing.Point(213, 203);
            this.description_tb.Multiline = true;
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(250, 77);
            this.description_tb.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.description_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_tb.TabIndex = 87;
            this.description_tb.Text = "Enter description...";
            this.description_tb.Enter += new System.EventHandler(this.description_tb_Enter);
            this.description_tb.Leave += new System.EventHandler(this.description_tb_Leave);
            // 
            // insert_btn
            // 
            this.insert_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.insert_btn.Location = new System.Drawing.Point(22, 76);
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
            this.insert_btn.TabIndex = 85;
            this.insert_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_submit_282;
            this.insert_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.insert_btn.Values.Text = "Insert";
            this.insert_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // Admin_panel
            // 
            this.Admin_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Admin_panel.Controls.Add(this.buttonDock_panel);
            this.Admin_panel.Controls.Add(this.userEditor_panel);
            this.Admin_panel.Controls.Add(this.movieEditor_panel);
            this.Admin_panel.Location = new System.Drawing.Point(3, 3);
            this.Admin_panel.Name = "Admin_panel";
            this.Admin_panel.Size = new System.Drawing.Size(1214, 696);
            this.Admin_panel.TabIndex = 87;
            // 
            // buttonDock_panel
            // 
            this.buttonDock_panel.Controls.Add(this.logo_pb);
            this.buttonDock_panel.Controls.Add(this.editUser_btn);
            this.buttonDock_panel.Controls.Add(this.editMovie_btn);
            this.buttonDock_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDock_panel.Location = new System.Drawing.Point(0, 0);
            this.buttonDock_panel.Name = "buttonDock_panel";
            this.buttonDock_panel.Size = new System.Drawing.Size(172, 696);
            this.buttonDock_panel.TabIndex = 89;
            // 
            // logo_pb
            // 
            this.logo_pb.BackColor = System.Drawing.Color.White;
            this.logo_pb.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_pb.Image = global::OOP_Project.Properties.Resources._1_3;
            this.logo_pb.Location = new System.Drawing.Point(0, 0);
            this.logo_pb.Name = "logo_pb";
            this.logo_pb.Size = new System.Drawing.Size(172, 164);
            this.logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_pb.TabIndex = 91;
            this.logo_pb.TabStop = false;
            // 
            // editUser_btn
            // 
            this.editUser_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.editUser_btn.Location = new System.Drawing.Point(6, 263);
            this.editUser_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.editUser_btn.Name = "editUser_btn";
            this.editUser_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.editUser_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.editUser_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.editUser_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editUser_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editUser_btn.OverrideDefault.Border.Width = 1;
            this.editUser_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.Transparent;
            this.editUser_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.Transparent;
            this.editUser_btn.OverrideFocus.Border.Color1 = System.Drawing.Color.Red;
            this.editUser_btn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editUser_btn.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editUser_btn.OverrideFocus.Border.Width = 1;
            this.editUser_btn.Size = new System.Drawing.Size(163, 45);
            this.editUser_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.editUser_btn.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.editUser_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.editUser_btn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.editUser_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editUser_btn.StateCommon.Border.Rounding = 20;
            this.editUser_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.editUser_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.editUser_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.editUser_btn.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.editUser_btn.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.editUser_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
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
            this.editUser_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_edit_user_28;
            this.editUser_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.editUser_btn.Values.Text = "Edit User";
            this.editUser_btn.Click += new System.EventHandler(this.editUser_btn_Click);
            // 
            // editMovie_btn
            // 
            this.editMovie_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.editMovie_btn.Location = new System.Drawing.Point(6, 191);
            this.editMovie_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.editMovie_btn.Name = "editMovie_btn";
            this.editMovie_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.editMovie_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.editMovie_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.editMovie_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editMovie_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editMovie_btn.OverrideDefault.Border.Width = 1;
            this.editMovie_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.Transparent;
            this.editMovie_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.Transparent;
            this.editMovie_btn.OverrideFocus.Border.Color1 = System.Drawing.Color.Red;
            this.editMovie_btn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editMovie_btn.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editMovie_btn.OverrideFocus.Border.Width = 1;
            this.editMovie_btn.Size = new System.Drawing.Size(163, 45);
            this.editMovie_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.editMovie_btn.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.editMovie_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.editMovie_btn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.editMovie_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editMovie_btn.StateCommon.Border.Rounding = 20;
            this.editMovie_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.editMovie_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.editMovie_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.editMovie_btn.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.editMovie_btn.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.editMovie_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
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
            this.editMovie_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_edit_delivery_terms_28;
            this.editMovie_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.editMovie_btn.Values.Text = "Edit Movie";
            this.editMovie_btn.Click += new System.EventHandler(this.editMovie_btn_Click);
            // 
            // userEditor_panel
            // 
            this.userEditor_panel.AutoScroll = true;
            this.userEditor_panel.Controls.Add(this.dataGrid_panel);
            this.userEditor_panel.Controls.Add(this.fillup_panel);
            this.userEditor_panel.Controls.Add(this.controlBtn_panel);
            this.userEditor_panel.Controls.Add(this.userSearchBox_tb);
            this.userEditor_panel.Location = new System.Drawing.Point(189, 2);
            this.userEditor_panel.Name = "userEditor_panel";
            this.userEditor_panel.Size = new System.Drawing.Size(1024, 666);
            this.userEditor_panel.TabIndex = 89;
            this.userEditor_panel.Visible = false;
            // 
            // dataGrid_panel
            // 
            this.dataGrid_panel.Controls.Add(this.users_dgv);
            this.dataGrid_panel.Location = new System.Drawing.Point(20, 375);
            this.dataGrid_panel.Name = "dataGrid_panel";
            this.dataGrid_panel.Size = new System.Drawing.Size(980, 291);
            this.dataGrid_panel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGrid_panel.TabIndex = 106;
            // 
            // users_dgv
            // 
            this.users_dgv.AllowUserToAddRows = false;
            this.users_dgv.AllowUserToDeleteRows = false;
            this.users_dgv.AllowUserToResizeRows = false;
            this.users_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.users_dgv.ColumnHeadersHeight = 40;
            this.users_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.users_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.users_dgv.Location = new System.Drawing.Point(0, 0);
            this.users_dgv.MultiSelect = false;
            this.users_dgv.Name = "users_dgv";
            this.users_dgv.ReadOnly = true;
            this.users_dgv.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.users_dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.users_dgv.RowTemplate.Height = 35;
            this.users_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.users_dgv.Size = new System.Drawing.Size(980, 291);
            this.users_dgv.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.users_dgv.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.users_dgv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.users_dgv.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.users_dgv.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.users_dgv.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.users_dgv.StateCommon.DataCell.Border.Rounding = 0;
            this.users_dgv.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.users_dgv.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.users_dgv.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.users_dgv.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.users_dgv.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.users_dgv.StateCommon.HeaderColumn.Border.Rounding = 0;
            this.users_dgv.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.users_dgv.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.users_dgv.TabIndex = 81;
            this.users_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_dgv_CellClick);
            // 
            // fillup_panel
            // 
            this.fillup_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.fillup_panel.Controls.Add(this.profile_lbl);
            this.fillup_panel.Controls.Add(this.avatar_pb);
            this.fillup_panel.Controls.Add(this.email_tb);
            this.fillup_panel.Controls.Add(this.username_tb);
            this.fillup_panel.Controls.Add(this.usertype_cmb);
            this.fillup_panel.Controls.Add(this.age_tb);
            this.fillup_panel.Controls.Add(this.userGenre_clb);
            this.fillup_panel.Controls.Add(this.securityQuestion_cmb);
            this.fillup_panel.Controls.Add(this.userID_tb);
            this.fillup_panel.Controls.Add(this.securityAnswer_tb);
            this.fillup_panel.Controls.Add(this.emailVerified_cb);
            this.fillup_panel.Controls.Add(this.Birthdate_dtp);
            this.fillup_panel.Controls.Add(this.gender_cmb);
            this.fillup_panel.Controls.Add(this.Genre_lbl);
            this.fillup_panel.Location = new System.Drawing.Point(235, 36);
            this.fillup_panel.Name = "fillup_panel";
            this.fillup_panel.Size = new System.Drawing.Size(765, 293);
            this.fillup_panel.TabIndex = 105;
            // 
            // avatar_pb
            // 
            this.avatar_pb.BackColor = System.Drawing.Color.White;
            this.avatar_pb.Location = new System.Drawing.Point(32, 48);
            this.avatar_pb.Name = "avatar_pb";
            this.avatar_pb.Size = new System.Drawing.Size(200, 200);
            this.avatar_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar_pb.TabIndex = 103;
            this.avatar_pb.TabStop = false;
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(260, 92);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(213, 26);
            this.email_tb.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.email_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_tb.TabIndex = 83;
            this.email_tb.Text = "Enter email...";
            this.email_tb.Enter += new System.EventHandler(this.email_tb_Enter);
            this.email_tb.Leave += new System.EventHandler(this.email_tb_Leave);
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(260, 24);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(213, 26);
            this.username_tb.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.username_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.TabIndex = 82;
            this.username_tb.Text = "Enter username...";
            this.username_tb.Enter += new System.EventHandler(this.username_tb_Enter);
            this.username_tb.Leave += new System.EventHandler(this.username_tb_Leave);
            // 
            // usertype_cmb
            // 
            this.usertype_cmb.DropDownWidth = 183;
            this.usertype_cmb.Items.AddRange(new object[] {
            "member",
            "admin"});
            this.usertype_cmb.Location = new System.Drawing.Point(506, 63);
            this.usertype_cmb.Name = "usertype_cmb";
            this.usertype_cmb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usertype_cmb.Size = new System.Drawing.Size(160, 20);
            this.usertype_cmb.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.usertype_cmb.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertype_cmb.TabIndex = 102;
            this.usertype_cmb.Text = "Select user type...";
            this.usertype_cmb.Visible = false;
            // 
            // age_tb
            // 
            this.age_tb.Location = new System.Drawing.Point(260, 133);
            this.age_tb.Name = "age_tb";
            this.age_tb.Size = new System.Drawing.Size(93, 26);
            this.age_tb.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.age_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_tb.TabIndex = 84;
            this.age_tb.Text = "Enter age...";
            this.age_tb.Enter += new System.EventHandler(this.age_tb_Enter);
            this.age_tb.Leave += new System.EventHandler(this.age_tb_Leave);
            // 
            // userGenre_clb
            // 
            this.userGenre_clb.FormattingEnabled = true;
            this.userGenre_clb.Location = new System.Drawing.Point(511, 122);
            this.userGenre_clb.MultiColumn = true;
            this.userGenre_clb.Name = "userGenre_clb";
            this.userGenre_clb.Size = new System.Drawing.Size(230, 124);
            this.userGenre_clb.TabIndex = 86;
            // 
            // securityQuestion_cmb
            // 
            this.securityQuestion_cmb.DropDownWidth = 183;
            this.securityQuestion_cmb.Location = new System.Drawing.Point(260, 211);
            this.securityQuestion_cmb.Name = "securityQuestion_cmb";
            this.securityQuestion_cmb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.securityQuestion_cmb.Size = new System.Drawing.Size(213, 20);
            this.securityQuestion_cmb.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Silver;
            this.securityQuestion_cmb.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityQuestion_cmb.TabIndex = 88;
            this.securityQuestion_cmb.Text = "Security Question";
            // 
            // userID_tb
            // 
            this.userID_tb.Location = new System.Drawing.Point(260, 57);
            this.userID_tb.Name = "userID_tb";
            this.userID_tb.Size = new System.Drawing.Size(93, 26);
            this.userID_tb.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.userID_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID_tb.TabIndex = 98;
            this.userID_tb.Text = "Enter user ID...";
            this.userID_tb.Enter += new System.EventHandler(this.userID_tb_Enter);
            this.userID_tb.Leave += new System.EventHandler(this.userID_tb_Leave);
            // 
            // securityAnswer_tb
            // 
            this.securityAnswer_tb.Location = new System.Drawing.Point(260, 245);
            this.securityAnswer_tb.Name = "securityAnswer_tb";
            this.securityAnswer_tb.Size = new System.Drawing.Size(213, 26);
            this.securityAnswer_tb.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.securityAnswer_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityAnswer_tb.TabIndex = 90;
            this.securityAnswer_tb.Text = "Enter security answer...";
            this.securityAnswer_tb.Enter += new System.EventHandler(this.securityAnswer_tb_Enter);
            this.securityAnswer_tb.Leave += new System.EventHandler(this.securityAnswer_tb_Leave);
            // 
            // emailVerified_cb
            // 
            this.emailVerified_cb.AutoSize = true;
            this.emailVerified_cb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailVerified_cb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailVerified_cb.Location = new System.Drawing.Point(506, 252);
            this.emailVerified_cb.Name = "emailVerified_cb";
            this.emailVerified_cb.Size = new System.Drawing.Size(122, 23);
            this.emailVerified_cb.TabIndex = 97;
            this.emailVerified_cb.Text = "Is email verified";
            this.emailVerified_cb.UseVisualStyleBackColor = true;
            // 
            // Birthdate_dtp
            // 
            this.Birthdate_dtp.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Birthdate_dtp.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.Birthdate_dtp.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Birthdate_dtp.Checked = false;
            this.Birthdate_dtp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthdate_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthdate_dtp.Location = new System.Drawing.Point(506, 24);
            this.Birthdate_dtp.Name = "Birthdate_dtp";
            this.Birthdate_dtp.Size = new System.Drawing.Size(200, 26);
            this.Birthdate_dtp.TabIndex = 91;
            // 
            // gender_cmb
            // 
            this.gender_cmb.DropDownWidth = 183;
            this.gender_cmb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
            this.gender_cmb.Location = new System.Drawing.Point(260, 176);
            this.gender_cmb.Name = "gender_cmb";
            this.gender_cmb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gender_cmb.Size = new System.Drawing.Size(93, 20);
            this.gender_cmb.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Silver;
            this.gender_cmb.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_cmb.TabIndex = 96;
            this.gender_cmb.Text = "Select gender...";
            // 
            // Genre_lbl
            // 
            this.Genre_lbl.AutoSize = true;
            this.Genre_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Genre_lbl.Location = new System.Drawing.Point(507, 92);
            this.Genre_lbl.Name = "Genre_lbl";
            this.Genre_lbl.Size = new System.Drawing.Size(124, 19);
            this.Genre_lbl.TabIndex = 93;
            this.Genre_lbl.Text = "Genre Preferences:";
            // 
            // controlBtn_panel
            // 
            this.controlBtn_panel.AutoSize = true;
            this.controlBtn_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.controlBtn_panel.Controls.Add(this.insertUser_btn);
            this.controlBtn_panel.Controls.Add(this.cancel_btn);
            this.controlBtn_panel.Controls.Add(this.deleteUser_btn);
            this.controlBtn_panel.Controls.Add(this.usersEditor_lbl);
            this.controlBtn_panel.Location = new System.Drawing.Point(20, 36);
            this.controlBtn_panel.Name = "controlBtn_panel";
            this.controlBtn_panel.Size = new System.Drawing.Size(186, 293);
            this.controlBtn_panel.TabIndex = 104;
            // 
            // insertUser_btn
            // 
            this.insertUser_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.insertUser_btn.Location = new System.Drawing.Point(22, 68);
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
            // cancel_btn
            // 
            this.cancel_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.cancel_btn.Location = new System.Drawing.Point(22, 171);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(132, 45);
            this.cancel_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.cancel_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.cancel_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cancel_btn.StateCommon.Border.Rounding = 20;
            this.cancel_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.cancel_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.cancel_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.cancel_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cancel_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cancel_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cancel_btn.TabIndex = 103;
            this.cancel_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_close_24;
            this.cancel_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.cancel_btn.Values.Text = "Cancel";
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // deleteUser_btn
            // 
            this.deleteUser_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.deleteUser_btn.Location = new System.Drawing.Point(22, 121);
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
            this.deleteUser_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_delete_document_28;
            this.deleteUser_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.deleteUser_btn.Values.Text = "Delete";
            this.deleteUser_btn.Click += new System.EventHandler(this.deleteUser_btn_Click);
            // 
            // usersEditor_lbl
            // 
            this.usersEditor_lbl.AutoSize = true;
            this.usersEditor_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersEditor_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usersEditor_lbl.Location = new System.Drawing.Point(17, 19);
            this.usersEditor_lbl.Name = "usersEditor_lbl";
            this.usersEditor_lbl.Size = new System.Drawing.Size(142, 26);
            this.usersEditor_lbl.TabIndex = 99;
            this.usersEditor_lbl.Text = "Users Editor";
            // 
            // userSearchBox_tb
            // 
            this.userSearchBox_tb.Location = new System.Drawing.Point(666, 349);
            this.userSearchBox_tb.Name = "userSearchBox_tb";
            this.userSearchBox_tb.Size = new System.Drawing.Size(334, 20);
            this.userSearchBox_tb.TabIndex = 100;
            this.userSearchBox_tb.Click += new System.EventHandler(this.userSearchBox_tb_Click);
            this.userSearchBox_tb.TextChanged += new System.EventHandler(this.userSearchBox_tb_TextChanged);
            this.userSearchBox_tb.Enter += new System.EventHandler(this.userSearchBox_tb_Enter);
            this.userSearchBox_tb.Leave += new System.EventHandler(this.userSearchBox_tb_Leave);
            // 
            // movieEditor_panel
            // 
            this.movieEditor_panel.AutoScroll = true;
            this.movieEditor_panel.Controls.Add(this.movieFillUp_panel);
            this.movieEditor_panel.Controls.Add(this.movieControlBtn_panel);
            this.movieEditor_panel.Controls.Add(this.panel1);
            this.movieEditor_panel.Controls.Add(this.searchBox_tb);
            this.movieEditor_panel.Location = new System.Drawing.Point(187, 3);
            this.movieEditor_panel.Name = "movieEditor_panel";
            this.movieEditor_panel.Size = new System.Drawing.Size(1024, 665);
            this.movieEditor_panel.TabIndex = 88;
            this.movieEditor_panel.Visible = false;
            // 
            // movieFillUp_panel
            // 
            this.movieFillUp_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.movieFillUp_panel.Controls.Add(this.title_tb);
            this.movieFillUp_panel.Controls.Add(this.posterUrl_tb);
            this.movieFillUp_panel.Controls.Add(this.trailerUrl_tb);
            this.movieFillUp_panel.Controls.Add(this.genre_clb);
            this.movieFillUp_panel.Controls.Add(this.releaseYear_dtp);
            this.movieFillUp_panel.Controls.Add(this.poster_pb);
            this.movieFillUp_panel.Controls.Add(this.description_tb);
            this.movieFillUp_panel.Location = new System.Drawing.Point(224, 26);
            this.movieFillUp_panel.Name = "movieFillUp_panel";
            this.movieFillUp_panel.Size = new System.Drawing.Size(775, 302);
            this.movieFillUp_panel.TabIndex = 92;
            // 
            // trailerUrl_tb
            // 
            this.trailerUrl_tb.Location = new System.Drawing.Point(213, 111);
            this.trailerUrl_tb.Multiline = true;
            this.trailerUrl_tb.Name = "trailerUrl_tb";
            this.trailerUrl_tb.Size = new System.Drawing.Size(290, 44);
            this.trailerUrl_tb.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.trailerUrl_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trailerUrl_tb.TabIndex = 90;
            this.trailerUrl_tb.Text = "Enter trailer URL...";
            this.trailerUrl_tb.Enter += new System.EventHandler(this.trailerUrl_tb_Enter);
            this.trailerUrl_tb.Leave += new System.EventHandler(this.trailerUrl_tb_Leave);
            // 
            // poster_pb
            // 
            this.poster_pb.BackColor = System.Drawing.Color.White;
            this.poster_pb.Image = global::OOP_Project.Properties.Resources._1_2;
            this.poster_pb.Location = new System.Drawing.Point(21, 20);
            this.poster_pb.Name = "poster_pb";
            this.poster_pb.Size = new System.Drawing.Size(180, 255);
            this.poster_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.poster_pb.TabIndex = 83;
            this.poster_pb.TabStop = false;
            // 
            // movieControlBtn_panel
            // 
            this.movieControlBtn_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.movieControlBtn_panel.Controls.Add(this.remove_btn);
            this.movieControlBtn_panel.Controls.Add(this.Clear_btn);
            this.movieControlBtn_panel.Controls.Add(this.update_btn);
            this.movieControlBtn_panel.Controls.Add(this.movieEditor_lbl);
            this.movieControlBtn_panel.Controls.Add(this.insert_btn);
            this.movieControlBtn_panel.Location = new System.Drawing.Point(22, 26);
            this.movieControlBtn_panel.Name = "movieControlBtn_panel";
            this.movieControlBtn_panel.Size = new System.Drawing.Size(180, 302);
            this.movieControlBtn_panel.TabIndex = 91;
            // 
            // movieEditor_lbl
            // 
            this.movieEditor_lbl.AutoSize = true;
            this.movieEditor_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.movieEditor_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.movieEditor_lbl.Location = new System.Drawing.Point(17, 24);
            this.movieEditor_lbl.Name = "movieEditor_lbl";
            this.movieEditor_lbl.Size = new System.Drawing.Size(149, 26);
            this.movieEditor_lbl.TabIndex = 88;
            this.movieEditor_lbl.Text = "Movie Editor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.movies_dgv);
            this.panel1.Location = new System.Drawing.Point(22, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 275);
            this.panel1.TabIndex = 89;
            // 
            // profile_lbl
            // 
            this.profile_lbl.AutoSize = true;
            this.profile_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profile_lbl.Location = new System.Drawing.Point(27, 15);
            this.profile_lbl.Name = "profile_lbl";
            this.profile_lbl.Size = new System.Drawing.Size(89, 26);
            this.profile_lbl.TabIndex = 104;
            this.profile_lbl.Text = "Avatar:";
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Admin_panel);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(1214, 701);
            this.Load += new System.EventHandler(this.AdminMovieControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movies_dgv)).EndInit();
            this.Admin_panel.ResumeLayout(false);
            this.buttonDock_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            this.userEditor_panel.ResumeLayout(false);
            this.userEditor_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_panel)).EndInit();
            this.dataGrid_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.users_dgv)).EndInit();
            this.fillup_panel.ResumeLayout(false);
            this.fillup_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertype_cmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityQuestion_cmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gender_cmb)).EndInit();
            this.controlBtn_panel.ResumeLayout(false);
            this.controlBtn_panel.PerformLayout();
            this.movieEditor_panel.ResumeLayout(false);
            this.movieEditor_panel.PerformLayout();
            this.movieFillUp_panel.ResumeLayout(false);
            this.movieFillUp_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster_pb)).EndInit();
            this.movieControlBtn_panel.ResumeLayout(false);
            this.movieControlBtn_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker releaseYear_dtp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox title_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView movies_dgv;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox posterUrl_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonButton remove_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton update_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Clear_btn;
        private System.Windows.Forms.TextBox searchBox_tb;
        private System.Windows.Forms.PictureBox poster_pb;
        private System.Windows.Forms.CheckedListBox genre_clb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox description_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonButton insert_btn;
        private System.Windows.Forms.Panel Admin_panel;
        private System.Windows.Forms.Panel movieEditor_panel;
        private System.Windows.Forms.Panel buttonDock_panel;
        private System.Windows.Forms.PictureBox logo_pb;
        private ComponentFactory.Krypton.Toolkit.KryptonButton editUser_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton editMovie_btn;
        private System.Windows.Forms.Label movieEditor_lbl;
        private System.Windows.Forms.Panel userEditor_panel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox username_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView users_dgv;
        private System.Windows.Forms.CheckedListBox userGenre_clb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox age_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox email_tb;
        private System.Windows.Forms.Label Genre_lbl;
        private System.Windows.Forms.DateTimePicker Birthdate_dtp;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteUser_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox gender_cmb;
        private System.Windows.Forms.CheckBox emailVerified_cb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox userID_tb;
        private System.Windows.Forms.Label usersEditor_lbl;
        private System.Windows.Forms.TextBox userSearchBox_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonButton insertUser_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox usertype_cmb;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancel_btn;
        private System.Windows.Forms.Panel controlBtn_panel;
        private System.Windows.Forms.Panel fillup_panel;
        private KryptonPanel dataGrid_panel;
        private Panel panel1;
        private KryptonTextBox trailerUrl_tb;
        private Panel movieControlBtn_panel;
        private Panel movieFillUp_panel;
        private KryptonComboBox securityQuestion_cmb;
        private KryptonTextBox securityAnswer_tb;
        private PictureBox avatar_pb;
        private Label profile_lbl;
    }
}
