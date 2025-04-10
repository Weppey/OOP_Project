namespace OOP_Project
{
    partial class account_recovery_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(account_recovery_form));
            this.minimize_pb = new System.Windows.Forms.PictureBox();
            this.close_pb = new System.Windows.Forms.PictureBox();
            this.Panel_Tab = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Panel_Recovery = new System.Windows.Forms.Panel();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.resend_llbl = new System.Windows.Forms.LinkLabel();
            this.recoveryC_tb = new System.Windows.Forms.TextBox();
            this.recovery_lbl = new System.Windows.Forms.Label();
            this.confirmpassword_tb = new System.Windows.Forms.TextBox();
            this.newpassword_tb = new System.Windows.Forms.TextBox();
            this.Lbl_message = new System.Windows.Forms.Label();
            this.newpassword_lbl = new System.Windows.Forms.Label();
            this.confirmNP_lbl = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.password_chkb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).BeginInit();
            this.Panel_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Panel_Recovery.SuspendLayout();
            this.SuspendLayout();
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
            // Panel_Tab
            // 
            this.Panel_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Panel_Tab.Controls.Add(this.minimize_pb);
            this.Panel_Tab.Controls.Add(this.close_pb);
            this.Panel_Tab.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Tab.Location = new System.Drawing.Point(0, 0);
            this.Panel_Tab.Name = "Panel_Tab";
            this.Panel_Tab.Size = new System.Drawing.Size(870, 38);
            this.Panel_Tab.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(125, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Panel_Recovery
            // 
            this.Panel_Recovery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Panel_Recovery.Controls.Add(this.email_tb);
            this.Panel_Recovery.Controls.Add(this.pictureBox3);
            this.Panel_Recovery.Controls.Add(this.email_lbl);
            this.Panel_Recovery.Controls.Add(this.resend_llbl);
            this.Panel_Recovery.Controls.Add(this.recoveryC_tb);
            this.Panel_Recovery.Controls.Add(this.recovery_lbl);
            this.Panel_Recovery.Controls.Add(this.confirmpassword_tb);
            this.Panel_Recovery.Controls.Add(this.newpassword_tb);
            this.Panel_Recovery.Controls.Add(this.Lbl_message);
            this.Panel_Recovery.Controls.Add(this.newpassword_lbl);
            this.Panel_Recovery.Controls.Add(this.confirmNP_lbl);
            this.Panel_Recovery.Controls.Add(this.confirm_btn);
            this.Panel_Recovery.Controls.Add(this.password_chkb);
            this.Panel_Recovery.Location = new System.Drawing.Point(243, 74);
            this.Panel_Recovery.Name = "Panel_Recovery";
            this.Panel_Recovery.Size = new System.Drawing.Size(332, 408);
            this.Panel_Recovery.TabIndex = 22;
            this.Panel_Recovery.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // email_tb
            // 
            this.email_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.email_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_tb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.email_tb.Location = new System.Drawing.Point(139, 180);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(151, 25);
            this.email_tb.TabIndex = 48;
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.email_lbl.Location = new System.Drawing.Point(21, 189);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(45, 17);
            this.email_lbl.TabIndex = 49;
            this.email_lbl.Text = "Email:";
            this.email_lbl.Click += new System.EventHandler(this.email_lbl_Click);
            // 
            // resend_llbl
            // 
            this.resend_llbl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.resend_llbl.AutoSize = true;
            this.resend_llbl.DisabledLinkColor = System.Drawing.Color.White;
            this.resend_llbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resend_llbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.resend_llbl.Location = new System.Drawing.Point(61, 344);
            this.resend_llbl.Name = "resend_llbl";
            this.resend_llbl.Size = new System.Drawing.Size(224, 17);
            this.resend_llbl.TabIndex = 47;
            this.resend_llbl.TabStop = true;
            this.resend_llbl.Text = "Click here to send a recovery code";
            this.resend_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resend_llbl_LinkClicked);
            // 
            // recoveryC_tb
            // 
            this.recoveryC_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.recoveryC_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recoveryC_tb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryC_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.recoveryC_tb.Location = new System.Drawing.Point(139, 305);
            this.recoveryC_tb.Name = "recoveryC_tb";
            this.recoveryC_tb.PasswordChar = '*';
            this.recoveryC_tb.Size = new System.Drawing.Size(146, 25);
            this.recoveryC_tb.TabIndex = 20;
            // 
            // recovery_lbl
            // 
            this.recovery_lbl.AutoSize = true;
            this.recovery_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recovery_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.recovery_lbl.Location = new System.Drawing.Point(21, 313);
            this.recovery_lbl.Name = "recovery_lbl";
            this.recovery_lbl.Size = new System.Drawing.Size(100, 17);
            this.recovery_lbl.TabIndex = 21;
            this.recovery_lbl.Text = "Recovery code:";
            // 
            // confirmpassword_tb
            // 
            this.confirmpassword_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.confirmpassword_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmpassword_tb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpassword_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.confirmpassword_tb.Location = new System.Drawing.Point(139, 238);
            this.confirmpassword_tb.Name = "confirmpassword_tb";
            this.confirmpassword_tb.PasswordChar = '*';
            this.confirmpassword_tb.Size = new System.Drawing.Size(151, 25);
            this.confirmpassword_tb.TabIndex = 14;
            // 
            // newpassword_tb
            // 
            this.newpassword_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.newpassword_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newpassword_tb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassword_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.newpassword_tb.Location = new System.Drawing.Point(139, 209);
            this.newpassword_tb.Name = "newpassword_tb";
            this.newpassword_tb.PasswordChar = '*';
            this.newpassword_tb.Size = new System.Drawing.Size(151, 25);
            this.newpassword_tb.TabIndex = 12;
            // 
            // Lbl_message
            // 
            this.Lbl_message.AutoSize = true;
            this.Lbl_message.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_message.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_message.Location = new System.Drawing.Point(70, 114);
            this.Lbl_message.Name = "Lbl_message";
            this.Lbl_message.Size = new System.Drawing.Size(215, 51);
            this.Lbl_message.TabIndex = 19;
            this.Lbl_message.Text = "Recover Your Password.\r\nStrong password includes letters,\r\nnumbers, and symbols.";
            this.Lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_message.Click += new System.EventHandler(this.label1_Click);
            // 
            // newpassword_lbl
            // 
            this.newpassword_lbl.AutoSize = true;
            this.newpassword_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassword_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.newpassword_lbl.Location = new System.Drawing.Point(21, 218);
            this.newpassword_lbl.Name = "newpassword_lbl";
            this.newpassword_lbl.Size = new System.Drawing.Size(101, 17);
            this.newpassword_lbl.TabIndex = 13;
            this.newpassword_lbl.Text = "New password:";
            // 
            // confirmNP_lbl
            // 
            this.confirmNP_lbl.AutoSize = true;
            this.confirmNP_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmNP_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.confirmNP_lbl.Location = new System.Drawing.Point(21, 244);
            this.confirmNP_lbl.Name = "confirmNP_lbl";
            this.confirmNP_lbl.Size = new System.Drawing.Size(93, 17);
            this.confirmNP_lbl.TabIndex = 15;
            this.confirmNP_lbl.Text = "Confirmation:";
            // 
            // confirm_btn
            // 
            this.confirm_btn.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.Location = new System.Drawing.Point(125, 374);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(78, 31);
            this.confirm_btn.TabIndex = 17;
            this.confirm_btn.Text = "CONFIRM";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // password_chkb
            // 
            this.password_chkb.AutoSize = true;
            this.password_chkb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_chkb.ForeColor = System.Drawing.SystemColors.Control;
            this.password_chkb.Location = new System.Drawing.Point(139, 267);
            this.password_chkb.Name = "password_chkb";
            this.password_chkb.Size = new System.Drawing.Size(123, 21);
            this.password_chkb.TabIndex = 16;
            this.password_chkb.Text = "Show password";
            this.password_chkb.UseVisualStyleBackColor = true;
            this.password_chkb.CheckedChanged += new System.EventHandler(this.password_chkb_CheckedChanged);
            // 
            // account_recovery_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(870, 510);
            this.Controls.Add(this.Panel_Recovery);
            this.Controls.Add(this.Panel_Tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "account_recovery_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "account_recovery_form";
            this.Load += new System.EventHandler(this.account_recovery_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).EndInit();
            this.Panel_Tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Panel_Recovery.ResumeLayout(false);
            this.Panel_Recovery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox minimize_pb;
        private System.Windows.Forms.PictureBox close_pb;
        private System.Windows.Forms.Panel Panel_Tab;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel Panel_Recovery;
        private System.Windows.Forms.TextBox recoveryC_tb;
        private System.Windows.Forms.Label recovery_lbl;
        private System.Windows.Forms.TextBox confirmpassword_tb;
        private System.Windows.Forms.TextBox newpassword_tb;
        private System.Windows.Forms.Label Lbl_message;
        private System.Windows.Forms.Label newpassword_lbl;
        private System.Windows.Forms.Label confirmNP_lbl;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.CheckBox password_chkb;
        private System.Windows.Forms.LinkLabel resend_llbl;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label email_lbl;
    }
}