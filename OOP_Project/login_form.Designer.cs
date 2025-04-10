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
            this.login_panel = new System.Windows.Forms.Panel();
            this.account_lbl = new System.Windows.Forms.Label();
            this.forgotP_llbl = new System.Windows.Forms.LinkLabel();
            this.login_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signup_llbl = new System.Windows.Forms.LinkLabel();
            this.password_chkb = new System.Windows.Forms.CheckBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.Panel_tab = new System.Windows.Forms.Panel();
            this.minimize_pb = new System.Windows.Forms.PictureBox();
            this.close_pb = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // login_panel
            // 
            this.login_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.login_panel.Controls.Add(this.account_lbl);
            this.login_panel.Controls.Add(this.forgotP_llbl);
            this.login_panel.Controls.Add(this.login_btn);
            this.login_panel.Controls.Add(this.pictureBox1);
            this.login_panel.Controls.Add(this.signup_llbl);
            this.login_panel.Controls.Add(this.password_chkb);
            this.login_panel.Controls.Add(this.password_lbl);
            this.login_panel.Controls.Add(this.password_tb);
            this.login_panel.Controls.Add(this.username_lbl);
            this.login_panel.Controls.Add(this.username_tb);
            this.login_panel.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_panel.Location = new System.Drawing.Point(243, 74);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(332, 408);
            this.login_panel.TabIndex = 0;
            this.login_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.login_panel_Paint);
            // 
            // account_lbl
            // 
            this.account_lbl.AutoSize = true;
            this.account_lbl.BackColor = System.Drawing.Color.Transparent;
            this.account_lbl.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.account_lbl.Location = new System.Drawing.Point(57, 361);
            this.account_lbl.Name = "account_lbl";
            this.account_lbl.Size = new System.Drawing.Size(151, 17);
            this.account_lbl.TabIndex = 12;
            this.account_lbl.Text = "Don\'t have an account yet?";
            this.account_lbl.Click += new System.EventHandler(this.account_lbl_Click);
            // 
            // forgotP_llbl
            // 
            this.forgotP_llbl.ActiveLinkColor = System.Drawing.Color.White;
            this.forgotP_llbl.AutoSize = true;
            this.forgotP_llbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotP_llbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.forgotP_llbl.Location = new System.Drawing.Point(89, 283);
            this.forgotP_llbl.Name = "forgotP_llbl";
            this.forgotP_llbl.Size = new System.Drawing.Size(151, 17);
            this.forgotP_llbl.TabIndex = 11;
            this.forgotP_llbl.TabStop = true;
            this.forgotP_llbl.Text = "Forgot your password?";
            this.forgotP_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotP_llbl_LinkClicked);
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(125, 250);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 30);
            this.login_btn.TabIndex = 9;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // signup_llbl
            // 
            this.signup_llbl.ActiveLinkColor = System.Drawing.Color.White;
            this.signup_llbl.AutoSize = true;
            this.signup_llbl.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_llbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.signup_llbl.Location = new System.Drawing.Point(214, 361);
            this.signup_llbl.Name = "signup_llbl";
            this.signup_llbl.Size = new System.Drawing.Size(53, 17);
            this.signup_llbl.TabIndex = 7;
            this.signup_llbl.TabStop = true;
            this.signup_llbl.Text = "Sign up!";
            this.signup_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_llbl_LinkClicked);
            // 
            // password_chkb
            // 
            this.password_chkb.AutoSize = true;
            this.password_chkb.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_chkb.ForeColor = System.Drawing.SystemColors.Control;
            this.password_chkb.Location = new System.Drawing.Point(111, 196);
            this.password_chkb.Name = "password_chkb";
            this.password_chkb.Size = new System.Drawing.Size(113, 21);
            this.password_chkb.TabIndex = 4;
            this.password_chkb.Text = "Show password";
            this.password_chkb.UseVisualStyleBackColor = true;
            this.password_chkb.CheckedChanged += new System.EventHandler(this.password_chkb_CheckedChanged);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.password_lbl.Location = new System.Drawing.Point(30, 173);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(65, 17);
            this.password_lbl.TabIndex = 3;
            this.password_lbl.Text = "Password:";
            this.password_lbl.Click += new System.EventHandler(this.password_lbl_Click);
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.password_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_tb.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.password_tb.Location = new System.Drawing.Point(111, 167);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(163, 23);
            this.password_tb.TabIndex = 2;
            this.password_tb.TextChanged += new System.EventHandler(this.password_tb_TextChanged);
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.username_lbl.Location = new System.Drawing.Point(30, 144);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(67, 17);
            this.username_lbl.TabIndex = 1;
            this.username_lbl.Text = "Username:";
            this.username_lbl.Click += new System.EventHandler(this.username_lbl_Click);
            // 
            // username_tb
            // 
            this.username_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.username_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_tb.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.username_tb.Location = new System.Drawing.Point(111, 138);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(163, 23);
            this.username_tb.TabIndex = 0;
            this.username_tb.TextChanged += new System.EventHandler(this.username_tb_TextChanged);
            // 
            // Panel_tab
            // 
            this.Panel_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Panel_tab.Controls.Add(this.minimize_pb);
            this.Panel_tab.Controls.Add(this.close_pb);
            this.Panel_tab.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_tab.Location = new System.Drawing.Point(0, 0);
            this.Panel_tab.Name = "Panel_tab";
            this.Panel_tab.Size = new System.Drawing.Size(870, 38);
            this.Panel_tab.TabIndex = 1;
            // 
            // minimize_pb
            // 
            this.minimize_pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.minimize_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimize_pb.Image = global::OOP_Project.Properties.Resources.icons8_minimize_48;
            this.minimize_pb.Location = new System.Drawing.Point(808, 7);
            this.minimize_pb.Name = "minimize_pb";
            this.minimize_pb.Size = new System.Drawing.Size(25, 23);
            this.minimize_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_pb.TabIndex = 5;
            this.minimize_pb.TabStop = false;
            this.minimize_pb.Click += new System.EventHandler(this.minimize_pb_Click);
            // 
            // close_pb
            // 
            this.close_pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.close_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.close_pb.Image = global::OOP_Project.Properties.Resources.icons8_close_48;
            this.close_pb.Location = new System.Drawing.Point(837, 7);
            this.close_pb.Name = "close_pb";
            this.close_pb.Size = new System.Drawing.Size(25, 23);
            this.close_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_pb.TabIndex = 4;
            this.close_pb.TabStop = false;
            this.close_pb.Click += new System.EventHandler(this.close_pb_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(870, 510);
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.Panel_tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.LinkLabel signup_llbl;
        private System.Windows.Forms.CheckBox password_chkb;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Panel Panel_tab;
        private System.Windows.Forms.PictureBox minimize_pb;
        private System.Windows.Forms.PictureBox close_pb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel forgotP_llbl;
        private System.Windows.Forms.Label account_lbl;
    }
}

