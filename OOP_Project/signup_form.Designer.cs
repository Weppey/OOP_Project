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
            this.minimize_pb = new System.Windows.Forms.PictureBox();
            this.close_pb = new System.Windows.Forms.PictureBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.Lbl_Signup = new System.Windows.Forms.Label();
            this.signup_panel = new System.Windows.Forms.Panel();
            this.login_llbl = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.acc_lbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pref_lbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.preferences_clb = new ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox();
            this.securityq_cmb = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.answer_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.birthday_dtp = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.gender_cmb = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.email_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.sign_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.showPass_chkb = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.pass_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.user_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.bg2_panel = new System.Windows.Forms.Panel();
            this.question_lbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.birthdate_lbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gender_lbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.process1 = new System.Diagnostics.Process();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).BeginInit();
            this.signup_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.securityq_cmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gender_cmb)).BeginInit();
            this.SuspendLayout();
            // 
            // minimize_pb
            // 
            this.minimize_pb.BackColor = System.Drawing.Color.Transparent;
            this.minimize_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimize_pb.Image = global::OOP_Project.Properties.Resources.icons8_minimize_24;
            this.minimize_pb.Location = new System.Drawing.Point(986, 12);
            this.minimize_pb.Name = "minimize_pb";
            this.minimize_pb.Size = new System.Drawing.Size(25, 23);
            this.minimize_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_pb.TabIndex = 9;
            this.minimize_pb.TabStop = false;
            this.minimize_pb.Click += new System.EventHandler(this.minimize_pb_Click);
            // 
            // close_pb
            // 
            this.close_pb.BackColor = System.Drawing.Color.Transparent;
            this.close_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.close_pb.Image = global::OOP_Project.Properties.Resources.icons8_close_24;
            this.close_pb.Location = new System.Drawing.Point(1015, 12);
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
            // Lbl_Signup
            // 
            this.Lbl_Signup.AutoSize = true;
            this.Lbl_Signup.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.Lbl_Signup.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Signup.Location = new System.Drawing.Point(397, 29);
            this.Lbl_Signup.Name = "Lbl_Signup";
            this.Lbl_Signup.Size = new System.Drawing.Size(91, 26);
            this.Lbl_Signup.TabIndex = 43;
            this.Lbl_Signup.Text = "Sign-up";
            this.Lbl_Signup.Click += new System.EventHandler(this.Lbl_Signup_Click);
            // 
            // signup_panel
            // 
            this.signup_panel.BackColor = System.Drawing.Color.White;
            this.signup_panel.Controls.Add(this.login_llbl);
            this.signup_panel.Controls.Add(this.acc_lbl);
            this.signup_panel.Controls.Add(this.pref_lbl);
            this.signup_panel.Controls.Add(this.preferences_clb);
            this.signup_panel.Controls.Add(this.securityq_cmb);
            this.signup_panel.Controls.Add(this.answer_tb);
            this.signup_panel.Controls.Add(this.birthday_dtp);
            this.signup_panel.Controls.Add(this.gender_cmb);
            this.signup_panel.Controls.Add(this.email_tb);
            this.signup_panel.Controls.Add(this.sign_btn);
            this.signup_panel.Controls.Add(this.showPass_chkb);
            this.signup_panel.Controls.Add(this.pass_tb);
            this.signup_panel.Controls.Add(this.user_tb);
            this.signup_panel.Controls.Add(this.bg2_panel);
            this.signup_panel.Controls.Add(this.Lbl_Signup);
            this.signup_panel.Controls.Add(this.question_lbl);
            this.signup_panel.Controls.Add(this.birthdate_lbl);
            this.signup_panel.Controls.Add(this.gender_lbl);
            this.signup_panel.Location = new System.Drawing.Point(105, 99);
            this.signup_panel.Name = "signup_panel";
            this.signup_panel.Size = new System.Drawing.Size(844, 451);
            this.signup_panel.TabIndex = 3;
            this.signup_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.signup_panel_Paint);
            // 
            // login_llbl
            // 
            this.login_llbl.Location = new System.Drawing.Point(656, 417);
            this.login_llbl.Name = "login_llbl";
            this.login_llbl.Size = new System.Drawing.Size(44, 20);
            this.login_llbl.TabIndex = 69;
            this.login_llbl.Values.Text = "Login!";
            this.login_llbl.LinkClicked += new System.EventHandler(this.login_llbl_LinkClicked);
            // 
            // acc_lbl
            // 
            this.acc_lbl.Location = new System.Drawing.Point(509, 417);
            this.acc_lbl.Name = "acc_lbl";
            this.acc_lbl.Size = new System.Drawing.Size(150, 20);
            this.acc_lbl.TabIndex = 68;
            this.acc_lbl.Values.Text = "Already have an account?";
            // 
            // pref_lbl
            // 
            this.pref_lbl.Location = new System.Drawing.Point(601, 101);
            this.pref_lbl.Name = "pref_lbl";
            this.pref_lbl.Size = new System.Drawing.Size(113, 20);
            this.pref_lbl.TabIndex = 67;
            this.pref_lbl.Values.Text = "Movie Preferences:";
            // 
            // preferences_clb
            // 
            this.preferences_clb.Location = new System.Drawing.Point(601, 127);
            this.preferences_clb.Name = "preferences_clb";
            this.preferences_clb.Size = new System.Drawing.Size(220, 221);
            this.preferences_clb.TabIndex = 66;
            // 
            // securityq_cmb
            // 
            this.securityq_cmb.DropDownWidth = 183;
            this.securityq_cmb.Location = new System.Drawing.Point(402, 328);
            this.securityq_cmb.Name = "securityq_cmb";
            this.securityq_cmb.Size = new System.Drawing.Size(186, 20);
            this.securityq_cmb.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.securityq_cmb.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityq_cmb.TabIndex = 62;
            this.securityq_cmb.Text = "N/A";
            this.securityq_cmb.SelectedIndexChanged += new System.EventHandler(this.securityq_cmb_SelectedIndexChanged);
            this.securityq_cmb.Enter += new System.EventHandler(this.securityq_cmb_Enter);
            this.securityq_cmb.Leave += new System.EventHandler(this.securityq_cmb_Leave);
            // 
            // answer_tb
            // 
            this.answer_tb.Location = new System.Drawing.Point(402, 355);
            this.answer_tb.Name = "answer_tb";
            this.answer_tb.Size = new System.Drawing.Size(186, 26);
            this.answer_tb.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.answer_tb.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.answer_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.answer_tb.TabIndex = 61;
            this.answer_tb.Text = "Answer";
            this.answer_tb.TextChanged += new System.EventHandler(this.answer_tb_TextChanged_1);
            this.answer_tb.Enter += new System.EventHandler(this.answer_tb_Enter);
            this.answer_tb.Leave += new System.EventHandler(this.answer_tb_Leave);
            // 
            // birthday_dtp
            // 
            this.birthday_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthday_dtp.Location = new System.Drawing.Point(402, 269);
            this.birthday_dtp.Name = "birthday_dtp";
            this.birthday_dtp.Size = new System.Drawing.Size(183, 20);
            this.birthday_dtp.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.birthday_dtp.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday_dtp.TabIndex = 60;
            this.birthday_dtp.ValueChanged += new System.EventHandler(this.birthday_dtp_ValueChanged);
            this.birthday_dtp.CloseUp += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerCloseArgs>(this.birthday_dtp_CloseUp);
            // 
            // gender_cmb
            // 
            this.gender_cmb.DropDownWidth = 183;
            this.gender_cmb.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Prefer not to say"});
            this.gender_cmb.Location = new System.Drawing.Point(402, 219);
            this.gender_cmb.Name = "gender_cmb";
            this.gender_cmb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gender_cmb.Size = new System.Drawing.Size(183, 20);
            this.gender_cmb.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.gender_cmb.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_cmb.TabIndex = 59;
            this.gender_cmb.Text = "N/A";
            this.gender_cmb.SelectedIndexChanged += new System.EventHandler(this.kryptonComboBox1_SelectedIndexChanged);
            this.gender_cmb.Enter += new System.EventHandler(this.gender_cmb_Enter);
            this.gender_cmb.Leave += new System.EventHandler(this.gender_cmb_Leave);
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(399, 168);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(186, 26);
            this.email_tb.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.email_tb.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.email_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.email_tb.TabIndex = 58;
            this.email_tb.Text = "Email";
            this.email_tb.TextChanged += new System.EventHandler(this.email_tb_TextChanged);
            this.email_tb.Enter += new System.EventHandler(this.email_tb_Enter);
            this.email_tb.Leave += new System.EventHandler(this.email_tb_Leave);
            // 
            // sign_btn
            // 
            this.sign_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.sign_btn.Location = new System.Drawing.Point(724, 371);
            this.sign_btn.Name = "sign_btn";
            this.sign_btn.Size = new System.Drawing.Size(97, 30);
            this.sign_btn.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.sign_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.sign_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sign_btn.StateCommon.Border.Rounding = 5;
            this.sign_btn.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Disabled;
            this.sign_btn.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.sign_btn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, -1, 5, -1);
            this.sign_btn.TabIndex = 57;
            this.sign_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_right_162;
            this.sign_btn.Values.Text = "Sign-up";
            this.sign_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // showPass_chkb
            // 
            this.showPass_chkb.Location = new System.Drawing.Point(477, 142);
            this.showPass_chkb.Name = "showPass_chkb";
            this.showPass_chkb.Size = new System.Drawing.Size(108, 20);
            this.showPass_chkb.TabIndex = 56;
            this.showPass_chkb.Values.Text = "Show password";
            this.showPass_chkb.CheckedChanged += new System.EventHandler(this.showPass_chkb_CheckedChanged);
            // 
            // pass_tb
            // 
            this.pass_tb.Location = new System.Drawing.Point(399, 110);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(186, 26);
            this.pass_tb.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.pass_tb.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.pass_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.pass_tb.TabIndex = 55;
            this.pass_tb.Text = "Password";
            this.pass_tb.TextChanged += new System.EventHandler(this.pass_tb_TextChanged);
            this.pass_tb.Enter += new System.EventHandler(this.pass_tb_Enter);
            this.pass_tb.Leave += new System.EventHandler(this.pass_tb_Leave);
            // 
            // user_tb
            // 
            this.user_tb.Location = new System.Drawing.Point(399, 78);
            this.user_tb.Name = "user_tb";
            this.user_tb.Size = new System.Drawing.Size(186, 26);
            this.user_tb.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.user_tb.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.user_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.user_tb.TabIndex = 10;
            this.user_tb.Text = "Username";
            this.user_tb.TextChanged += new System.EventHandler(this.user_tb_TextChanged);
            this.user_tb.Enter += new System.EventHandler(this.user_tb_Enter);
            this.user_tb.Leave += new System.EventHandler(this.user_tb_Leave);
            this.user_tb.MouseEnter += new System.EventHandler(this.user_tb_MouseEnter);
            // 
            // bg2_panel
            // 
            this.bg2_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bg2_panel.BackgroundImage = global::OOP_Project.Properties.Resources._1_4;
            this.bg2_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bg2_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bg2_panel.Location = new System.Drawing.Point(0, 0);
            this.bg2_panel.Name = "bg2_panel";
            this.bg2_panel.Size = new System.Drawing.Size(385, 451);
            this.bg2_panel.TabIndex = 54;
            this.bg2_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.bg2_panel_Paint);
            // 
            // question_lbl
            // 
            this.question_lbl.Location = new System.Drawing.Point(399, 309);
            this.question_lbl.Name = "question_lbl";
            this.question_lbl.Size = new System.Drawing.Size(109, 20);
            this.question_lbl.TabIndex = 63;
            this.question_lbl.Values.Text = "Security Question:";
            this.question_lbl.Paint += new System.Windows.Forms.PaintEventHandler(this.question_lbl_Paint);
            // 
            // birthdate_lbl
            // 
            this.birthdate_lbl.Location = new System.Drawing.Point(399, 254);
            this.birthdate_lbl.Name = "birthdate_lbl";
            this.birthdate_lbl.Size = new System.Drawing.Size(63, 20);
            this.birthdate_lbl.TabIndex = 64;
            this.birthdate_lbl.Values.Text = "Birthdate:";
            this.birthdate_lbl.Paint += new System.Windows.Forms.PaintEventHandler(this.birthdate_lbl_Paint);
            // 
            // gender_lbl
            // 
            this.gender_lbl.Location = new System.Drawing.Point(399, 204);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(53, 20);
            this.gender_lbl.TabIndex = 65;
            this.gender_lbl.Values.Text = "Gender:";
            this.gender_lbl.Paint += new System.Windows.Forms.PaintEventHandler(this.gender_lbl_Paint);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // signup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImage = global::OOP_Project.Properties.Resources._112;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 650);
            this.Controls.Add(this.minimize_pb);
            this.Controls.Add(this.signup_panel);
            this.Controls.Add(this.close_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "signup_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signup_form";
            this.Load += new System.EventHandler(this.signup_form_Load);
            this.Shown += new System.EventHandler(this.signup_form_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).EndInit();
            this.signup_panel.ResumeLayout(false);
            this.signup_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.securityq_cmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gender_cmb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label Lbl_Signup;
        private System.Windows.Forms.Panel signup_panel;
        private System.Windows.Forms.PictureBox minimize_pb;
        private System.Windows.Forms.PictureBox close_pb;
        private System.Windows.Forms.Panel bg2_panel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox user_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox showPass_chkb;
        private ComponentFactory.Krypton.Toolkit.KryptonButton sign_btn;
        private System.Diagnostics.Process process1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox gender_cmb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox email_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker birthday_dtp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox answer_tb;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox securityq_cmb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel question_lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel birthdate_lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel gender_lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox preferences_clb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel pref_lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel login_llbl;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel acc_lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox pass_tb;
    }
}