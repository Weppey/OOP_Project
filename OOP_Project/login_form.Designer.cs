namespace OOP_Project
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.loginDock_panel = new System.Windows.Forms.Panel();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.userName_tb = new System.Windows.Forms.TextBox();
            this.forgotPassword_llbl = new System.Windows.Forms.Label();
            this.protection_lbl = new System.Windows.Forms.Label();
            this.signUp_lbl = new System.Windows.Forms.Label();
            this.signIn_lbl = new System.Windows.Forms.Label();
            this.login_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.showPass_chkb = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.logo_pb = new System.Windows.Forms.PictureBox();
            this.close_pb = new System.Windows.Forms.PictureBox();
            this.minimize_pb = new System.Windows.Forms.PictureBox();
            this.loginDock_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // loginDock_panel
            // 
            this.loginDock_panel.BackColor = System.Drawing.Color.White;
            this.loginDock_panel.Controls.Add(this.password_tb);
            this.loginDock_panel.Controls.Add(this.userName_tb);
            this.loginDock_panel.Controls.Add(this.forgotPassword_llbl);
            this.loginDock_panel.Controls.Add(this.protection_lbl);
            this.loginDock_panel.Controls.Add(this.signUp_lbl);
            this.loginDock_panel.Controls.Add(this.signIn_lbl);
            this.loginDock_panel.Controls.Add(this.login_btn);
            this.loginDock_panel.Controls.Add(this.showPass_chkb);
            this.loginDock_panel.Controls.Add(this.logo_pb);
            this.loginDock_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginDock_panel.Location = new System.Drawing.Point(0, 0);
            this.loginDock_panel.Name = "loginDock_panel";
            this.loginDock_panel.Size = new System.Drawing.Size(254, 650);
            this.loginDock_panel.TabIndex = 20;
            // 
            // password_tb
            // 
            this.password_tb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.ForeColor = System.Drawing.Color.DarkGray;
            this.password_tb.Location = new System.Drawing.Point(52, 297);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(153, 26);
            this.password_tb.TabIndex = 12;
            this.password_tb.Text = "Password";
            this.password_tb.Enter += new System.EventHandler(this.password_tb_Enter);
            this.password_tb.Leave += new System.EventHandler(this.password_tb_Leave);
            // 
            // userName_tb
            // 
            this.userName_tb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_tb.ForeColor = System.Drawing.Color.DarkGray;
            this.userName_tb.Location = new System.Drawing.Point(52, 257);
            this.userName_tb.Name = "userName_tb";
            this.userName_tb.Size = new System.Drawing.Size(153, 26);
            this.userName_tb.TabIndex = 11;
            this.userName_tb.Text = "Username";
            this.userName_tb.Enter += new System.EventHandler(this.userName_tb_Enter);
            this.userName_tb.Leave += new System.EventHandler(this.userName_tb_Leave);
            // 
            // forgotPassword_llbl
            // 
            this.forgotPassword_llbl.AutoSize = true;
            this.forgotPassword_llbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPassword_llbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassword_llbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.forgotPassword_llbl.Location = new System.Drawing.Point(50, 428);
            this.forgotPassword_llbl.Name = "forgotPassword_llbl";
            this.forgotPassword_llbl.Size = new System.Drawing.Size(155, 12);
            this.forgotPassword_llbl.TabIndex = 10;
            this.forgotPassword_llbl.Text = "FORGOT YOUR PASSWORD?";
            this.forgotPassword_llbl.Click += new System.EventHandler(this.forgotPassword_llbl_Click);
            // 
            // protection_lbl
            // 
            this.protection_lbl.AutoSize = true;
            this.protection_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.protection_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.protection_lbl.Location = new System.Drawing.Point(17, 584);
            this.protection_lbl.Name = "protection_lbl";
            this.protection_lbl.Size = new System.Drawing.Size(225, 45);
            this.protection_lbl.TabIndex = 7;
            this.protection_lbl.Text = resources.GetString("protection_lbl.Text");
            this.protection_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signUp_lbl
            // 
            this.signUp_lbl.AutoSize = true;
            this.signUp_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUp_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signUp_lbl.Location = new System.Drawing.Point(31, 555);
            this.signUp_lbl.Name = "signUp_lbl";
            this.signUp_lbl.Size = new System.Drawing.Size(182, 12);
            this.signUp_lbl.TabIndex = 6;
            this.signUp_lbl.Text = "HAVEN\'T GOT AN ACCOUNT YET?";
            this.signUp_lbl.Click += new System.EventHandler(this.signUp_lbl_Click);
            // 
            // signIn_lbl
            // 
            this.signIn_lbl.AutoSize = true;
            this.signIn_lbl.Font = new System.Drawing.Font("Impact", 14F);
            this.signIn_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signIn_lbl.Location = new System.Drawing.Point(92, 219);
            this.signIn_lbl.Name = "signIn_lbl";
            this.signIn_lbl.Size = new System.Drawing.Size(63, 23);
            this.signIn_lbl.TabIndex = 5;
            this.signIn_lbl.Text = "Sign in";
            // 
            // login_btn
            // 
            this.login_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.login_btn.Location = new System.Drawing.Point(122, 355);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(97, 30);
            this.login_btn.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.login_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.login_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.login_btn.StateCommon.Border.Rounding = 5;
            this.login_btn.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Disabled;
            this.login_btn.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.login_btn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, -1, 5, -1);
            this.login_btn.TabIndex = 4;
            this.login_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_right_162;
            this.login_btn.Values.Text = "Login";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // showPass_chkb
            // 
            this.showPass_chkb.Location = new System.Drawing.Point(111, 329);
            this.showPass_chkb.Name = "showPass_chkb";
            this.showPass_chkb.Size = new System.Drawing.Size(108, 20);
            this.showPass_chkb.TabIndex = 3;
            this.showPass_chkb.Values.Text = "Show password";
            this.showPass_chkb.CheckedChanged += new System.EventHandler(this.showPass_chkb_CheckedChanged);
            // 
            // logo_pb
            // 
            this.logo_pb.Image = global::OOP_Project.Properties.Resources._11;
            this.logo_pb.Location = new System.Drawing.Point(52, 45);
            this.logo_pb.Name = "logo_pb";
            this.logo_pb.Size = new System.Drawing.Size(150, 150);
            this.logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_pb.TabIndex = 0;
            this.logo_pb.TabStop = false;
            // 
            // close_pb
            // 
            this.close_pb.BackColor = System.Drawing.Color.Transparent;
            this.close_pb.Image = global::OOP_Project.Properties.Resources.icons8_close_24;
            this.close_pb.Location = new System.Drawing.Point(1015, 12);
            this.close_pb.Name = "close_pb";
            this.close_pb.Size = new System.Drawing.Size(25, 23);
            this.close_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_pb.TabIndex = 18;
            this.close_pb.TabStop = false;
            this.close_pb.Click += new System.EventHandler(this.close_pb_Click);
            this.close_pb.MouseEnter += new System.EventHandler(this.close_pb_MouseEnter);
            this.close_pb.MouseLeave += new System.EventHandler(this.close_pb_MouseLeave);
            // 
            // minimize_pb
            // 
            this.minimize_pb.BackColor = System.Drawing.Color.Transparent;
            this.minimize_pb.Image = global::OOP_Project.Properties.Resources.icons8_minimize_24;
            this.minimize_pb.Location = new System.Drawing.Point(986, 12);
            this.minimize_pb.Name = "minimize_pb";
            this.minimize_pb.Size = new System.Drawing.Size(25, 23);
            this.minimize_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_pb.TabIndex = 19;
            this.minimize_pb.TabStop = false;
            this.minimize_pb.Click += new System.EventHandler(this.minimize_pb_Click);
            this.minimize_pb.MouseEnter += new System.EventHandler(this.minimize_pb_MouseEnter);
            this.minimize_pb.MouseLeave += new System.EventHandler(this.minimize_pb_MouseLeave);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImage = global::OOP_Project.Properties.Resources.login_wall2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 650);
            this.Controls.Add(this.loginDock_panel);
            this.Controls.Add(this.close_pb);
            this.Controls.Add(this.minimize_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StateCommon.Back.Image = global::OOP_Project.Properties.Resources.login_wall;
            this.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 15;
            this.StateCommon.Border.Width = 1;
            this.Text = "REMMM";
            this.Load += new System.EventHandler(this.login_form_Load);
            this.loginDock_panel.ResumeLayout(false);
            this.loginDock_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox close_pb;
        private System.Windows.Forms.PictureBox minimize_pb;
        private System.Windows.Forms.Panel loginDock_panel;
        private System.Windows.Forms.PictureBox logo_pb;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox showPass_chkb;
        private ComponentFactory.Krypton.Toolkit.KryptonButton login_btn;
        private System.Windows.Forms.Label signIn_lbl;
        private System.Windows.Forms.Label signUp_lbl;
        private System.Windows.Forms.Label protection_lbl;
        private System.Windows.Forms.Label forgotPassword_llbl;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox userName_tb;
    }
}

