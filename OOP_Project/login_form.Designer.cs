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
            this.forgotP_llbl = new System.Windows.Forms.LinkLabel();
            this.login_btn = new System.Windows.Forms.Button();
            this.signup_llbl = new System.Windows.Forms.LinkLabel();
            this.password_chkb = new System.Windows.Forms.CheckBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.account_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimize_pb = new System.Windows.Forms.PictureBox();
            this.close_pb = new System.Windows.Forms.PictureBox();
            this.login_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.login_panel.Location = new System.Drawing.Point(243, 74);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(332, 408);
            this.login_panel.TabIndex = 0;
            // 
            // forgotP_llbl
            // 
            this.forgotP_llbl.ActiveLinkColor = System.Drawing.Color.White;
            this.forgotP_llbl.AutoSize = true;
            this.forgotP_llbl.Font = new System.Drawing.Font("Bebas Neue", 10F);
            this.forgotP_llbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.forgotP_llbl.Location = new System.Drawing.Point(122, 283);
            this.forgotP_llbl.Name = "forgotP_llbl";
            this.forgotP_llbl.Size = new System.Drawing.Size(121, 17);
            this.forgotP_llbl.TabIndex = 11;
            this.forgotP_llbl.TabStop = true;
            this.forgotP_llbl.Text = "Forgot your password?";
            this.forgotP_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotP_llbl_LinkClicked);
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Bebas Neue", 10F);
            this.login_btn.Location = new System.Drawing.Point(175, 230);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 9;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // signup_llbl
            // 
            this.signup_llbl.ActiveLinkColor = System.Drawing.Color.White;
            this.signup_llbl.AutoSize = true;
            this.signup_llbl.Font = new System.Drawing.Font("Bebas Neue", 10F);
            this.signup_llbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.signup_llbl.Location = new System.Drawing.Point(221, 361);
            this.signup_llbl.Name = "signup_llbl";
            this.signup_llbl.Size = new System.Drawing.Size(43, 17);
            this.signup_llbl.TabIndex = 7;
            this.signup_llbl.TabStop = true;
            this.signup_llbl.Text = "sign up!";
            this.signup_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_llbl_LinkClicked);
            // 
            // password_chkb
            // 
            this.password_chkb.AutoSize = true;
            this.password_chkb.Font = new System.Drawing.Font("Bebas Neue", 10F);
            this.password_chkb.ForeColor = System.Drawing.SystemColors.Control;
            this.password_chkb.Location = new System.Drawing.Point(149, 203);
            this.password_chkb.Name = "password_chkb";
            this.password_chkb.Size = new System.Drawing.Size(101, 21);
            this.password_chkb.TabIndex = 4;
            this.password_chkb.Text = "Show password";
            this.password_chkb.UseVisualStyleBackColor = true;
            this.password_chkb.CheckedChanged += new System.EventHandler(this.password_chkb_CheckedChanged);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Bebas Neue", 10F);
            this.password_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.password_lbl.Location = new System.Drawing.Point(79, 170);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(58, 17);
            this.password_lbl.TabIndex = 3;
            this.password_lbl.Text = "password:";
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.password_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_tb.Font = new System.Drawing.Font("Arial", 10F);
            this.password_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.password_tb.Location = new System.Drawing.Point(137, 167);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(113, 23);
            this.password_tb.TabIndex = 2;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Bebas Neue", 10F);
            this.username_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.username_lbl.Location = new System.Drawing.Point(79, 141);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(58, 17);
            this.username_lbl.TabIndex = 1;
            this.username_lbl.Text = "username:";
            // 
            // username_tb
            // 
            this.username_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.username_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_tb.Font = new System.Drawing.Font("Arial", 10F);
            this.username_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.username_tb.Location = new System.Drawing.Point(137, 138);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(113, 23);
            this.username_tb.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.minimize_pb);
            this.panel1.Controls.Add(this.close_pb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 38);
            this.panel1.TabIndex = 1;
            // 
            // account_lbl
            // 
            this.account_lbl.AutoSize = true;
            this.account_lbl.Font = new System.Drawing.Font("Bebas Neue", 10F);
            this.account_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.account_lbl.Location = new System.Drawing.Point(78, 361);
            this.account_lbl.Name = "account_lbl";
            this.account_lbl.Size = new System.Drawing.Size(137, 17);
            this.account_lbl.TabIndex = 12;
            this.account_lbl.Text = "Don\'t have an account yet?";
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
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimize_pb;
        private System.Windows.Forms.PictureBox close_pb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel forgotP_llbl;
        private System.Windows.Forms.Label account_lbl;
    }
}

