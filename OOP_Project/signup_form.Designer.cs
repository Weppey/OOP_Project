namespace OOP_Project
{
    partial class signup_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup_form));
            this.top_dock = new System.Windows.Forms.Panel();
            this.minimize_pb = new System.Windows.Forms.PictureBox();
            this.close_pb = new System.Windows.Forms.PictureBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.birthdate_lbl = new System.Windows.Forms.Label();
            this.account_lbl = new System.Windows.Forms.Label();
            this.birthdate_picker = new System.Windows.Forms.DateTimePicker();
            this.login_llbl = new System.Windows.Forms.LinkLabel();
            this.Lbl_Signup = new System.Windows.Forms.Label();
            this.gender_cb = new System.Windows.Forms.ComboBox();
            this.preferences_lbl = new System.Windows.Forms.Label();
            this.preferences_clb = new System.Windows.Forms.CheckedListBox();
            this.securityQ_lbl = new System.Windows.Forms.Label();
            this.securityQ_cb = new System.Windows.Forms.ComboBox();
            this.answer_tb = new System.Windows.Forms.TextBox();
            this.answer_lbl = new System.Windows.Forms.Label();
            this.signup_btn = new System.Windows.Forms.Button();
            this.signup_panel = new System.Windows.Forms.Panel();
            this.password_chkb = new System.Windows.Forms.CheckBox();
            this.Pb_logo = new System.Windows.Forms.PictureBox();
            this.top_dock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).BeginInit();
            this.signup_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // top_dock
            // 
            this.top_dock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.top_dock.Controls.Add(this.minimize_pb);
            this.top_dock.Controls.Add(this.close_pb);
            this.top_dock.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_dock.Location = new System.Drawing.Point(0, 0);
            this.top_dock.Name = "top_dock";
            this.top_dock.Size = new System.Drawing.Size(870, 38);
            this.top_dock.TabIndex = 2;
            // 
            // minimize_pb
            // 
            this.minimize_pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.minimize_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimize_pb.Image = global::OOP_Project.Properties.Resources.icons8_minimize_48;
            this.minimize_pb.Location = new System.Drawing.Point(810, 9);
            this.minimize_pb.Name = "minimize_pb";
            this.minimize_pb.Size = new System.Drawing.Size(25, 23);
            this.minimize_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_pb.TabIndex = 9;
            this.minimize_pb.TabStop = false;
            this.minimize_pb.Click += new System.EventHandler(this.minimize_pb_Click);
            // 
            // close_pb
            // 
            this.close_pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.close_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.close_pb.Image = global::OOP_Project.Properties.Resources.icons8_close_48;
            this.close_pb.Location = new System.Drawing.Point(839, 9);
            this.close_pb.Name = "close_pb";
            this.close_pb.Size = new System.Drawing.Size(25, 23);
            this.close_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_pb.TabIndex = 8;
            this.close_pb.TabStop = false;
            this.close_pb.Click += new System.EventHandler(this.close_pb_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // username_tb
            // 
            this.username_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.username_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_tb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.username_tb.Location = new System.Drawing.Point(200, 153);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(165, 25);
            this.username_tb.TabIndex = 29;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.username_lbl.Location = new System.Drawing.Point(51, 155);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(73, 17);
            this.username_lbl.TabIndex = 30;
            this.username_lbl.Text = "Username:";
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.password_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_tb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.password_tb.Location = new System.Drawing.Point(200, 182);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(165, 25);
            this.password_tb.TabIndex = 31;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.password_lbl.Location = new System.Drawing.Point(51, 185);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(69, 17);
            this.password_lbl.TabIndex = 32;
            this.password_lbl.Text = "Password:";
            // 
            // email_tb
            // 
            this.email_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.email_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_tb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.email_tb.Location = new System.Drawing.Point(200, 237);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(165, 25);
            this.email_tb.TabIndex = 34;
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.email_lbl.Location = new System.Drawing.Point(51, 243);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(45, 17);
            this.email_lbl.TabIndex = 35;
            this.email_lbl.Text = "Email:";
            // 
            // gender_lbl
            // 
            this.gender_lbl.AutoSize = true;
            this.gender_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.gender_lbl.Location = new System.Drawing.Point(51, 278);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(55, 17);
            this.gender_lbl.TabIndex = 38;
            this.gender_lbl.Text = "Gender:";
            // 
            // birthdate_lbl
            // 
            this.birthdate_lbl.AutoSize = true;
            this.birthdate_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdate_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.birthdate_lbl.Location = new System.Drawing.Point(51, 307);
            this.birthdate_lbl.Name = "birthdate_lbl";
            this.birthdate_lbl.Size = new System.Drawing.Size(68, 17);
            this.birthdate_lbl.TabIndex = 41;
            this.birthdate_lbl.Text = "Birthdate:";
            // 
            // account_lbl
            // 
            this.account_lbl.AutoSize = true;
            this.account_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.account_lbl.Location = new System.Drawing.Point(470, 408);
            this.account_lbl.Name = "account_lbl";
            this.account_lbl.Size = new System.Drawing.Size(168, 17);
            this.account_lbl.TabIndex = 36;
            this.account_lbl.Text = "Already have an account?";
            // 
            // birthdate_picker
            // 
            this.birthdate_picker.CalendarFont = new System.Drawing.Font("Arial", 10F);
            this.birthdate_picker.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdate_picker.Location = new System.Drawing.Point(200, 301);
            this.birthdate_picker.Name = "birthdate_picker";
            this.birthdate_picker.Size = new System.Drawing.Size(124, 25);
            this.birthdate_picker.TabIndex = 42;
            // 
            // login_llbl
            // 
            this.login_llbl.ActiveLinkColor = System.Drawing.Color.White;
            this.login_llbl.AutoSize = true;
            this.login_llbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_llbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.login_llbl.Location = new System.Drawing.Point(649, 408);
            this.login_llbl.Name = "login_llbl";
            this.login_llbl.Size = new System.Drawing.Size(47, 17);
            this.login_llbl.TabIndex = 37;
            this.login_llbl.TabStop = true;
            this.login_llbl.Text = "Login!";
            this.login_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_llbl_LinkClicked);
            // 
            // Lbl_Signup
            // 
            this.Lbl_Signup.AutoSize = true;
            this.Lbl_Signup.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Signup.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_Signup.Location = new System.Drawing.Point(368, 103);
            this.Lbl_Signup.Name = "Lbl_Signup";
            this.Lbl_Signup.Size = new System.Drawing.Size(101, 30);
            this.Lbl_Signup.TabIndex = 43;
            this.Lbl_Signup.Text = "SIGN-UP";
            this.Lbl_Signup.Click += new System.EventHandler(this.label3_Click);
            // 
            // gender_cb
            // 
            this.gender_cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.gender_cb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_cb.ForeColor = System.Drawing.SystemColors.Window;
            this.gender_cb.FormattingEnabled = true;
            this.gender_cb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.gender_cb.Location = new System.Drawing.Point(200, 271);
            this.gender_cb.Name = "gender_cb";
            this.gender_cb.Size = new System.Drawing.Size(85, 25);
            this.gender_cb.TabIndex = 44;
            this.gender_cb.Text = "N/A";
            // 
            // preferences_lbl
            // 
            this.preferences_lbl.AutoSize = true;
            this.preferences_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferences_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.preferences_lbl.Location = new System.Drawing.Point(454, 151);
            this.preferences_lbl.Name = "preferences_lbl";
            this.preferences_lbl.Size = new System.Drawing.Size(126, 17);
            this.preferences_lbl.TabIndex = 45;
            this.preferences_lbl.Text = "Movie preferences:";
            // 
            // preferences_clb
            // 
            this.preferences_clb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.preferences_clb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferences_clb.ForeColor = System.Drawing.SystemColors.Info;
            this.preferences_clb.FormattingEnabled = true;
            this.preferences_clb.Location = new System.Drawing.Point(458, 173);
            this.preferences_clb.MultiColumn = true;
            this.preferences_clb.Name = "preferences_clb";
            this.preferences_clb.Size = new System.Drawing.Size(273, 228);
            this.preferences_clb.TabIndex = 46;
            // 
            // securityQ_lbl
            // 
            this.securityQ_lbl.AutoSize = true;
            this.securityQ_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityQ_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.securityQ_lbl.Location = new System.Drawing.Point(51, 340);
            this.securityQ_lbl.Name = "securityQ_lbl";
            this.securityQ_lbl.Size = new System.Drawing.Size(121, 17);
            this.securityQ_lbl.TabIndex = 47;
            this.securityQ_lbl.Text = "Security Question:";
            // 
            // securityQ_cb
            // 
            this.securityQ_cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.securityQ_cb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityQ_cb.ForeColor = System.Drawing.SystemColors.Window;
            this.securityQ_cb.FormattingEnabled = true;
            this.securityQ_cb.Location = new System.Drawing.Point(200, 333);
            this.securityQ_cb.Name = "securityQ_cb";
            this.securityQ_cb.Size = new System.Drawing.Size(124, 25);
            this.securityQ_cb.TabIndex = 48;
            this.securityQ_cb.Text = "N/A";
            // 
            // answer_tb
            // 
            this.answer_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.answer_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answer_tb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.answer_tb.Location = new System.Drawing.Point(200, 363);
            this.answer_tb.Name = "answer_tb";
            this.answer_tb.Size = new System.Drawing.Size(165, 25);
            this.answer_tb.TabIndex = 49;
            // 
            // answer_lbl
            // 
            this.answer_lbl.AutoSize = true;
            this.answer_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.answer_lbl.Location = new System.Drawing.Point(51, 369);
            this.answer_lbl.Name = "answer_lbl";
            this.answer_lbl.Size = new System.Drawing.Size(56, 17);
            this.answer_lbl.TabIndex = 50;
            this.answer_lbl.Text = "Answer:";
            // 
            // signup_btn
            // 
            this.signup_btn.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.Location = new System.Drawing.Point(290, 400);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(75, 31);
            this.signup_btn.TabIndex = 52;
            this.signup_btn.Text = "Sign up";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // signup_panel
            // 
            this.signup_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.signup_panel.Controls.Add(this.password_chkb);
            this.signup_panel.Controls.Add(this.signup_btn);
            this.signup_panel.Controls.Add(this.answer_lbl);
            this.signup_panel.Controls.Add(this.answer_tb);
            this.signup_panel.Controls.Add(this.securityQ_cb);
            this.signup_panel.Controls.Add(this.securityQ_lbl);
            this.signup_panel.Controls.Add(this.preferences_clb);
            this.signup_panel.Controls.Add(this.preferences_lbl);
            this.signup_panel.Controls.Add(this.gender_cb);
            this.signup_panel.Controls.Add(this.Lbl_Signup);
            this.signup_panel.Controls.Add(this.login_llbl);
            this.signup_panel.Controls.Add(this.birthdate_picker);
            this.signup_panel.Controls.Add(this.account_lbl);
            this.signup_panel.Controls.Add(this.birthdate_lbl);
            this.signup_panel.Controls.Add(this.gender_lbl);
            this.signup_panel.Controls.Add(this.Pb_logo);
            this.signup_panel.Controls.Add(this.email_lbl);
            this.signup_panel.Controls.Add(this.email_tb);
            this.signup_panel.Controls.Add(this.password_lbl);
            this.signup_panel.Controls.Add(this.password_tb);
            this.signup_panel.Controls.Add(this.username_lbl);
            this.signup_panel.Controls.Add(this.username_tb);
            this.signup_panel.Location = new System.Drawing.Point(12, 44);
            this.signup_panel.Name = "signup_panel";
            this.signup_panel.Size = new System.Drawing.Size(846, 454);
            this.signup_panel.TabIndex = 3;
            this.signup_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.signup_panel_Paint);
            // 
            // password_chkb
            // 
            this.password_chkb.AutoSize = true;
            this.password_chkb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_chkb.ForeColor = System.Drawing.SystemColors.Control;
            this.password_chkb.Location = new System.Drawing.Point(200, 211);
            this.password_chkb.Name = "password_chkb";
            this.password_chkb.Size = new System.Drawing.Size(123, 21);
            this.password_chkb.TabIndex = 53;
            this.password_chkb.Text = "Show password";
            this.password_chkb.UseVisualStyleBackColor = true;
            this.password_chkb.CheckedChanged += new System.EventHandler(this.password_chkb_CheckedChanged);
            // 
            // Pb_logo
            // 
            this.Pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pb_logo.Image")));
            this.Pb_logo.Location = new System.Drawing.Point(369, 50);
            this.Pb_logo.Name = "Pb_logo";
            this.Pb_logo.Size = new System.Drawing.Size(100, 50);
            this.Pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_logo.TabIndex = 39;
            this.Pb_logo.TabStop = false;
            this.Pb_logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // signup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(870, 510);
            this.Controls.Add(this.signup_panel);
            this.Controls.Add(this.top_dock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "signup_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signup_form";
            this.Load += new System.EventHandler(this.signup_form_Load);
            this.top_dock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).EndInit();
            this.signup_panel.ResumeLayout(false);
            this.signup_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel top_dock;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.PictureBox Pb_logo;
        private System.Windows.Forms.Label gender_lbl;
        private System.Windows.Forms.Label birthdate_lbl;
        private System.Windows.Forms.Label account_lbl;
        private System.Windows.Forms.DateTimePicker birthdate_picker;
        private System.Windows.Forms.LinkLabel login_llbl;
        private System.Windows.Forms.Label Lbl_Signup;
        private System.Windows.Forms.ComboBox gender_cb;
        private System.Windows.Forms.Label preferences_lbl;
        private System.Windows.Forms.CheckedListBox preferences_clb;
        private System.Windows.Forms.Label securityQ_lbl;
        private System.Windows.Forms.ComboBox securityQ_cb;
        private System.Windows.Forms.TextBox answer_tb;
        private System.Windows.Forms.Label answer_lbl;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Panel signup_panel;
        private System.Windows.Forms.PictureBox minimize_pb;
        private System.Windows.Forms.PictureBox close_pb;
        private System.Windows.Forms.CheckBox password_chkb;
    }
}