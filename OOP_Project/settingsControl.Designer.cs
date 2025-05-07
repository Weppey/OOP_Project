namespace OOP_Project
{
    partial class settingsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsControl));
            this.settings_panel = new System.Windows.Forms.Panel();
            this.privacy_lbl = new System.Windows.Forms.Label();
            this.theme_lbl = new System.Windows.Forms.Label();
            this.securtySettings_lbl = new System.Windows.Forms.Label();
            this.appinfo_panel = new System.Windows.Forms.Panel();
            this.version_lbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.deleteAccount_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.appinfo_lbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.security_panel = new System.Windows.Forms.Panel();
            this.changeEmail_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.changePassword_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.privacy_panel = new System.Windows.Forms.Panel();
            this.clearRecentSearch_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.clearHistory_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.theme_panel = new System.Windows.Forms.Panel();
            this.darkmode_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lightmode_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.apply_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.appinfo = new System.Windows.Forms.Label();
            this.appinfo2 = new System.Windows.Forms.Label();
            this.logo_pbp = new System.Windows.Forms.PictureBox();
            this.settings_panel.SuspendLayout();
            this.appinfo_panel.SuspendLayout();
            this.security_panel.SuspendLayout();
            this.privacy_panel.SuspendLayout();
            this.theme_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pbp)).BeginInit();
            this.SuspendLayout();
            // 
            // settings_panel
            // 
            this.settings_panel.Controls.Add(this.logo_pbp);
            this.settings_panel.Controls.Add(this.privacy_lbl);
            this.settings_panel.Controls.Add(this.theme_lbl);
            this.settings_panel.Controls.Add(this.securtySettings_lbl);
            this.settings_panel.Controls.Add(this.appinfo_panel);
            this.settings_panel.Controls.Add(this.security_panel);
            this.settings_panel.Controls.Add(this.privacy_panel);
            this.settings_panel.Controls.Add(this.theme_panel);
            this.settings_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_panel.Location = new System.Drawing.Point(0, 0);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(1214, 614);
            this.settings_panel.TabIndex = 0;
            // 
            // privacy_lbl
            // 
            this.privacy_lbl.AutoSize = true;
            this.privacy_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privacy_lbl.ForeColor = System.Drawing.Color.White;
            this.privacy_lbl.Location = new System.Drawing.Point(38, 325);
            this.privacy_lbl.Name = "privacy_lbl";
            this.privacy_lbl.Size = new System.Drawing.Size(164, 27);
            this.privacy_lbl.TabIndex = 11;
            this.privacy_lbl.Text = "Privacy settings";
            // 
            // theme_lbl
            // 
            this.theme_lbl.AutoSize = true;
            this.theme_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theme_lbl.ForeColor = System.Drawing.Color.White;
            this.theme_lbl.Location = new System.Drawing.Point(38, 40);
            this.theme_lbl.Name = "theme_lbl";
            this.theme_lbl.Size = new System.Drawing.Size(78, 27);
            this.theme_lbl.TabIndex = 10;
            this.theme_lbl.Text = "Theme";
            // 
            // securtySettings_lbl
            // 
            this.securtySettings_lbl.AutoSize = true;
            this.securtySettings_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securtySettings_lbl.ForeColor = System.Drawing.Color.White;
            this.securtySettings_lbl.Location = new System.Drawing.Point(419, 40);
            this.securtySettings_lbl.Name = "securtySettings_lbl";
            this.securtySettings_lbl.Size = new System.Drawing.Size(172, 27);
            this.securtySettings_lbl.TabIndex = 9;
            this.securtySettings_lbl.Text = "Security Settings";
            // 
            // appinfo_panel
            // 
            this.appinfo_panel.BackColor = System.Drawing.Color.White;
            this.appinfo_panel.Controls.Add(this.appinfo2);
            this.appinfo_panel.Controls.Add(this.appinfo);
            this.appinfo_panel.Controls.Add(this.version_lbl);
            this.appinfo_panel.Controls.Add(this.deleteAccount_btn);
            this.appinfo_panel.Controls.Add(this.appinfo_lbl);
            this.appinfo_panel.Location = new System.Drawing.Point(831, 34);
            this.appinfo_panel.Name = "appinfo_panel";
            this.appinfo_panel.Size = new System.Drawing.Size(319, 542);
            this.appinfo_panel.TabIndex = 4;
            // 
            // version_lbl
            // 
            this.version_lbl.Location = new System.Drawing.Point(90, 72);
            this.version_lbl.Name = "version_lbl";
            this.version_lbl.Size = new System.Drawing.Size(138, 22);
            this.version_lbl.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.version_lbl.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version_lbl.TabIndex = 107;
            this.version_lbl.Values.Text = "App Version: 1.0.0";
            // 
            // deleteAccount_btn
            // 
            this.deleteAccount_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.deleteAccount_btn.Location = new System.Drawing.Point(73, 474);
            this.deleteAccount_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.deleteAccount_btn.Name = "deleteAccount_btn";
            this.deleteAccount_btn.Size = new System.Drawing.Size(183, 45);
            this.deleteAccount_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.deleteAccount_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.deleteAccount_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteAccount_btn.StateCommon.Border.Rounding = 20;
            this.deleteAccount_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.deleteAccount_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.deleteAccount_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.deleteAccount_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.deleteAccount_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.deleteAccount_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteAccount_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteAccount_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteAccount_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteAccount_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteAccount_btn.TabIndex = 106;
            this.deleteAccount_btn.Values.Image = ((System.Drawing.Image)(resources.GetObject("deleteAccount_btn.Values.Image")));
            this.deleteAccount_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.deleteAccount_btn.Values.Text = "Delete my account";
            this.deleteAccount_btn.Click += new System.EventHandler(this.deleteAccount_btn_Click);
            // 
            // appinfo_lbl
            // 
            this.appinfo_lbl.Location = new System.Drawing.Point(119, 22);
            this.appinfo_lbl.Name = "appinfo_lbl";
            this.appinfo_lbl.Size = new System.Drawing.Size(91, 28);
            this.appinfo_lbl.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.appinfo_lbl.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appinfo_lbl.TabIndex = 8;
            this.appinfo_lbl.Values.Text = "App info";
            // 
            // security_panel
            // 
            this.security_panel.BackColor = System.Drawing.Color.Maroon;
            this.security_panel.Controls.Add(this.changeEmail_btn);
            this.security_panel.Controls.Add(this.changePassword_btn);
            this.security_panel.Location = new System.Drawing.Point(424, 73);
            this.security_panel.Name = "security_panel";
            this.security_panel.Size = new System.Drawing.Size(349, 215);
            this.security_panel.TabIndex = 2;
            // 
            // changeEmail_btn
            // 
            this.changeEmail_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.changeEmail_btn.Location = new System.Drawing.Point(43, 123);
            this.changeEmail_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.changeEmail_btn.Name = "changeEmail_btn";
            this.changeEmail_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.changeEmail_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.changeEmail_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.changeEmail_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changeEmail_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changeEmail_btn.OverrideDefault.Border.Width = 1;
            this.changeEmail_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.Transparent;
            this.changeEmail_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.Transparent;
            this.changeEmail_btn.OverrideFocus.Border.Color1 = System.Drawing.Color.Red;
            this.changeEmail_btn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changeEmail_btn.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changeEmail_btn.OverrideFocus.Border.Width = 1;
            this.changeEmail_btn.Size = new System.Drawing.Size(263, 48);
            this.changeEmail_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.changeEmail_btn.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.changeEmail_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.changeEmail_btn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.changeEmail_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changeEmail_btn.StateCommon.Border.Rounding = 20;
            this.changeEmail_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.changeEmail_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.changeEmail_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.changeEmail_btn.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.changeEmail_btn.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.changeEmail_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changeEmail_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.changeEmail_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.changeEmail_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changeEmail_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changeEmail_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changeEmail_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changeEmail_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changeEmail_btn.TabIndex = 108;
            this.changeEmail_btn.Values.Image = ((System.Drawing.Image)(resources.GetObject("changeEmail_btn.Values.Image")));
            this.changeEmail_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.changeEmail_btn.Values.Text = "Change email";
            this.changeEmail_btn.Click += new System.EventHandler(this.changeEmail_btn_Click);
            // 
            // changePassword_btn
            // 
            this.changePassword_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.changePassword_btn.Location = new System.Drawing.Point(43, 38);
            this.changePassword_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.changePassword_btn.Name = "changePassword_btn";
            this.changePassword_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.changePassword_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.changePassword_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.changePassword_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changePassword_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changePassword_btn.OverrideDefault.Border.Width = 1;
            this.changePassword_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.Transparent;
            this.changePassword_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.Transparent;
            this.changePassword_btn.OverrideFocus.Border.Color1 = System.Drawing.Color.Red;
            this.changePassword_btn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changePassword_btn.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changePassword_btn.OverrideFocus.Border.Width = 1;
            this.changePassword_btn.Size = new System.Drawing.Size(263, 48);
            this.changePassword_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.changePassword_btn.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.changePassword_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.changePassword_btn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.changePassword_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changePassword_btn.StateCommon.Border.Rounding = 20;
            this.changePassword_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.changePassword_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.changePassword_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.changePassword_btn.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.changePassword_btn.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.changePassword_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changePassword_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.changePassword_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.changePassword_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changePassword_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changePassword_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changePassword_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changePassword_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changePassword_btn.TabIndex = 107;
            this.changePassword_btn.Values.Image = ((System.Drawing.Image)(resources.GetObject("changePassword_btn.Values.Image")));
            this.changePassword_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.changePassword_btn.Values.Text = "Change password";
            this.changePassword_btn.Click += new System.EventHandler(this.changePassword_btn_Click);
            // 
            // privacy_panel
            // 
            this.privacy_panel.BackColor = System.Drawing.Color.Maroon;
            this.privacy_panel.Controls.Add(this.clearRecentSearch_btn);
            this.privacy_panel.Controls.Add(this.clearHistory_btn);
            this.privacy_panel.Location = new System.Drawing.Point(43, 359);
            this.privacy_panel.Name = "privacy_panel";
            this.privacy_panel.Size = new System.Drawing.Size(349, 217);
            this.privacy_panel.TabIndex = 1;
            // 
            // clearRecentSearch_btn
            // 
            this.clearRecentSearch_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.clearRecentSearch_btn.Location = new System.Drawing.Point(31, 124);
            this.clearRecentSearch_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.clearRecentSearch_btn.Name = "clearRecentSearch_btn";
            this.clearRecentSearch_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.clearRecentSearch_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.clearRecentSearch_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.clearRecentSearch_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearRecentSearch_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clearRecentSearch_btn.OverrideDefault.Border.Width = 1;
            this.clearRecentSearch_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.Transparent;
            this.clearRecentSearch_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.Transparent;
            this.clearRecentSearch_btn.OverrideFocus.Border.Color1 = System.Drawing.Color.Red;
            this.clearRecentSearch_btn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearRecentSearch_btn.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clearRecentSearch_btn.OverrideFocus.Border.Width = 1;
            this.clearRecentSearch_btn.Size = new System.Drawing.Size(275, 45);
            this.clearRecentSearch_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.clearRecentSearch_btn.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.clearRecentSearch_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.clearRecentSearch_btn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.clearRecentSearch_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clearRecentSearch_btn.StateCommon.Border.Rounding = 20;
            this.clearRecentSearch_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.clearRecentSearch_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.clearRecentSearch_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.clearRecentSearch_btn.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.clearRecentSearch_btn.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.clearRecentSearch_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clearRecentSearch_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.clearRecentSearch_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.clearRecentSearch_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearRecentSearch_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearRecentSearch_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearRecentSearch_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearRecentSearch_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clearRecentSearch_btn.TabIndex = 106;
            this.clearRecentSearch_btn.Values.Image = ((System.Drawing.Image)(resources.GetObject("clearRecentSearch_btn.Values.Image")));
            this.clearRecentSearch_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.clearRecentSearch_btn.Values.Text = "Clear recently search";
            this.clearRecentSearch_btn.Click += new System.EventHandler(this.clearRecentSearch_btn_Click);
            // 
            // clearHistory_btn
            // 
            this.clearHistory_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.clearHistory_btn.Location = new System.Drawing.Point(31, 48);
            this.clearHistory_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.clearHistory_btn.Name = "clearHistory_btn";
            this.clearHistory_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.clearHistory_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.clearHistory_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.clearHistory_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearHistory_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clearHistory_btn.OverrideDefault.Border.Width = 1;
            this.clearHistory_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.Transparent;
            this.clearHistory_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.Transparent;
            this.clearHistory_btn.OverrideFocus.Border.Color1 = System.Drawing.Color.Red;
            this.clearHistory_btn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearHistory_btn.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clearHistory_btn.OverrideFocus.Border.Width = 1;
            this.clearHistory_btn.Size = new System.Drawing.Size(275, 45);
            this.clearHistory_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.clearHistory_btn.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.clearHistory_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.clearHistory_btn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.clearHistory_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clearHistory_btn.StateCommon.Border.Rounding = 20;
            this.clearHistory_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.clearHistory_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.clearHistory_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.clearHistory_btn.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.clearHistory_btn.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.clearHistory_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clearHistory_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.clearHistory_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.clearHistory_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearHistory_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearHistory_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearHistory_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearHistory_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clearHistory_btn.TabIndex = 105;
            this.clearHistory_btn.Values.Image = ((System.Drawing.Image)(resources.GetObject("clearHistory_btn.Values.Image")));
            this.clearHistory_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.clearHistory_btn.Values.Text = "Clear view history";
            this.clearHistory_btn.Click += new System.EventHandler(this.clearHistory_btn_Click);
            // 
            // theme_panel
            // 
            this.theme_panel.BackColor = System.Drawing.Color.Firebrick;
            this.theme_panel.Controls.Add(this.darkmode_btn);
            this.theme_panel.Controls.Add(this.lightmode_btn);
            this.theme_panel.Controls.Add(this.apply_btn);
            this.theme_panel.Location = new System.Drawing.Point(43, 73);
            this.theme_panel.Name = "theme_panel";
            this.theme_panel.Size = new System.Drawing.Size(349, 215);
            this.theme_panel.TabIndex = 0;
            // 
            // darkmode_btn
            // 
            this.darkmode_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.darkmode_btn.Location = new System.Drawing.Point(31, 107);
            this.darkmode_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.darkmode_btn.Name = "darkmode_btn";
            this.darkmode_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.darkmode_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.darkmode_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.darkmode_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.darkmode_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.darkmode_btn.OverrideDefault.Border.Width = 1;
            this.darkmode_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.Transparent;
            this.darkmode_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.Transparent;
            this.darkmode_btn.OverrideFocus.Border.Color1 = System.Drawing.Color.Red;
            this.darkmode_btn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.darkmode_btn.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.darkmode_btn.OverrideFocus.Border.Width = 1;
            this.darkmode_btn.Size = new System.Drawing.Size(275, 45);
            this.darkmode_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.darkmode_btn.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.darkmode_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.darkmode_btn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.darkmode_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.darkmode_btn.StateCommon.Border.Rounding = 20;
            this.darkmode_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.darkmode_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.darkmode_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.darkmode_btn.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.darkmode_btn.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.darkmode_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.darkmode_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.darkmode_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.darkmode_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.darkmode_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.darkmode_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.darkmode_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.darkmode_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.darkmode_btn.TabIndex = 104;
            this.darkmode_btn.Values.Image = ((System.Drawing.Image)(resources.GetObject("darkmode_btn.Values.Image")));
            this.darkmode_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.darkmode_btn.Values.Text = "Dark mode";
            this.darkmode_btn.Click += new System.EventHandler(this.darkmode_btn_Click);
            // 
            // lightmode_btn
            // 
            this.lightmode_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.lightmode_btn.Location = new System.Drawing.Point(31, 33);
            this.lightmode_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.lightmode_btn.Name = "lightmode_btn";
            this.lightmode_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.lightmode_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.lightmode_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.lightmode_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightmode_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lightmode_btn.OverrideDefault.Border.Width = 1;
            this.lightmode_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.Transparent;
            this.lightmode_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.Transparent;
            this.lightmode_btn.OverrideFocus.Border.Color1 = System.Drawing.Color.Red;
            this.lightmode_btn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightmode_btn.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lightmode_btn.OverrideFocus.Border.Width = 1;
            this.lightmode_btn.Size = new System.Drawing.Size(275, 45);
            this.lightmode_btn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.lightmode_btn.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.lightmode_btn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.lightmode_btn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.lightmode_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lightmode_btn.StateCommon.Border.Rounding = 20;
            this.lightmode_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.lightmode_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.lightmode_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.lightmode_btn.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.lightmode_btn.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.lightmode_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lightmode_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lightmode_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lightmode_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightmode_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightmode_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightmode_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightmode_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lightmode_btn.TabIndex = 103;
            this.lightmode_btn.Values.Image = ((System.Drawing.Image)(resources.GetObject("lightmode_btn.Values.Image")));
            this.lightmode_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.lightmode_btn.Values.Text = "Light mode";
            this.lightmode_btn.Click += new System.EventHandler(this.lightmode_btn_Click);
            // 
            // apply_btn
            // 
            this.apply_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.apply_btn.Location = new System.Drawing.Point(214, 167);
            this.apply_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(132, 45);
            this.apply_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.apply_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.apply_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.apply_btn.StateCommon.Border.Rounding = 20;
            this.apply_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.apply_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.apply_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.apply_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.apply_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.apply_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apply_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apply_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apply_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apply_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.apply_btn.TabIndex = 102;
            this.apply_btn.Values.Image = ((System.Drawing.Image)(resources.GetObject("apply_btn.Values.Image")));
            this.apply_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.apply_btn.Values.Text = "Apply";
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // appinfo
            // 
            this.appinfo.AutoSize = true;
            this.appinfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appinfo.ForeColor = System.Drawing.Color.IndianRed;
            this.appinfo.Location = new System.Drawing.Point(30, 143);
            this.appinfo.Name = "appinfo";
            this.appinfo.Size = new System.Drawing.Size(263, 150);
            this.appinfo.TabIndex = 108;
            this.appinfo.Text = resources.GetString("appinfo.Text");
            this.appinfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // appinfo2
            // 
            this.appinfo2.AutoSize = true;
            this.appinfo2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appinfo2.ForeColor = System.Drawing.Color.IndianRed;
            this.appinfo2.Location = new System.Drawing.Point(61, 343);
            this.appinfo2.Name = "appinfo2";
            this.appinfo2.Size = new System.Drawing.Size(195, 75);
            this.appinfo2.TabIndex = 109;
            this.appinfo2.Text = "The name \"Remmm\" is an acronym \r\nderived from the first names of \r\nthe applicatio" +
    "n\'s developers:\r\nRafael, Ericka, Michael, Marry,\r\n and Mharcky.";
            this.appinfo2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logo_pbp
            // 
            this.logo_pbp.BackColor = System.Drawing.Color.White;
            this.logo_pbp.Image = global::OOP_Project.Properties.Resources._1_3;
            this.logo_pbp.Location = new System.Drawing.Point(424, 359);
            this.logo_pbp.Name = "logo_pbp";
            this.logo_pbp.Size = new System.Drawing.Size(349, 217);
            this.logo_pbp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_pbp.TabIndex = 12;
            this.logo_pbp.TabStop = false;
            // 
            // settingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.settings_panel);
            this.Name = "settingsControl";
            this.Size = new System.Drawing.Size(1214, 614);
            this.settings_panel.ResumeLayout(false);
            this.settings_panel.PerformLayout();
            this.appinfo_panel.ResumeLayout(false);
            this.appinfo_panel.PerformLayout();
            this.security_panel.ResumeLayout(false);
            this.privacy_panel.ResumeLayout(false);
            this.theme_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_pbp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.Panel appinfo_panel;
        private System.Windows.Forms.Panel security_panel;
        private System.Windows.Forms.Panel privacy_panel;
        private System.Windows.Forms.Panel theme_panel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton apply_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton darkmode_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton lightmode_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton clearRecentSearch_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton clearHistory_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel version_lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteAccount_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel appinfo_lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonButton changePassword_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton changeEmail_btn;
        private System.Windows.Forms.Label theme_lbl;
        private System.Windows.Forms.Label securtySettings_lbl;
        private System.Windows.Forms.Label privacy_lbl;
        private System.Windows.Forms.Label appinfo2;
        private System.Windows.Forms.Label appinfo;
        private System.Windows.Forms.PictureBox logo_pbp;
    }
}
