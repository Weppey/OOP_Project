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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.resend_llbl = new System.Windows.Forms.LinkLabel();
            this.recoveryC_tb = new System.Windows.Forms.TextBox();
            this.recovery_lbl = new System.Windows.Forms.Label();
            this.confirmpassword_tb = new System.Windows.Forms.TextBox();
            this.newpassword_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newpassword_lbl = new System.Windows.Forms.Label();
            this.confirmNP_lbl = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.password_chkb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimize_pb
            // 
            this.minimize_pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.minimize_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimize_pb.Image = global::OOP_Project.Properties.Resources.icons8_minimize_48;
            this.minimize_pb.Location = new System.Drawing.Point(370, 7);
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
            this.close_pb.Location = new System.Drawing.Point(399, 7);
            this.close_pb.Name = "close_pb";
            this.close_pb.Size = new System.Drawing.Size(25, 23);
            this.close_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_pb.TabIndex = 4;
            this.close_pb.TabStop = false;
            this.close_pb.Click += new System.EventHandler(this.close_pb_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.minimize_pb);
            this.panel1.Controls.Add(this.close_pb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 38);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(165, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.email_tb);
            this.panel2.Controls.Add(this.email_lbl);
            this.panel2.Controls.Add(this.resend_llbl);
            this.panel2.Controls.Add(this.recoveryC_tb);
            this.panel2.Controls.Add(this.recovery_lbl);
            this.panel2.Controls.Add(this.confirmpassword_tb);
            this.panel2.Controls.Add(this.newpassword_tb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.newpassword_lbl);
            this.panel2.Controls.Add(this.confirmNP_lbl);
            this.panel2.Controls.Add(this.confirm_btn);
            this.panel2.Controls.Add(this.password_chkb);
            this.panel2.Location = new System.Drawing.Point(37, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 362);
            this.panel2.TabIndex = 22;
            // 
            // email_tb
            // 
            this.email_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.email_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_tb.Font = new System.Drawing.Font("Arial", 10F);
            this.email_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.email_tb.Location = new System.Drawing.Point(136, 110);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(151, 23);
            this.email_tb.TabIndex = 48;
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Bebas Neue", 10F);
            this.email_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.email_lbl.Location = new System.Drawing.Point(92, 113);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(38, 17);
            this.email_lbl.TabIndex = 49;
            this.email_lbl.Text = "Email:";
            // 
            // resend_llbl
            // 
            this.resend_llbl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.resend_llbl.AutoSize = true;
            this.resend_llbl.DisabledLinkColor = System.Drawing.Color.White;
            this.resend_llbl.Font = new System.Drawing.Font("Bebas Neue", 8F);
            this.resend_llbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.resend_llbl.Location = new System.Drawing.Point(125, 284);
            this.resend_llbl.Name = "resend_llbl";
            this.resend_llbl.Size = new System.Drawing.Size(132, 13);
            this.resend_llbl.TabIndex = 47;
            this.resend_llbl.TabStop = true;
            this.resend_llbl.Text = "Click here to send a recovery code";
            this.resend_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resend_llbl_LinkClicked);
            // 
            // recoveryC_tb
            // 
            this.recoveryC_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.recoveryC_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recoveryC_tb.Font = new System.Drawing.Font("Arial", 10F);
            this.recoveryC_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.recoveryC_tb.Location = new System.Drawing.Point(174, 241);
            this.recoveryC_tb.Name = "recoveryC_tb";
            this.recoveryC_tb.PasswordChar = '*';
            this.recoveryC_tb.Size = new System.Drawing.Size(113, 23);
            this.recoveryC_tb.TabIndex = 20;
            // 
            // recovery_lbl
            // 
            this.recovery_lbl.AutoSize = true;
            this.recovery_lbl.Font = new System.Drawing.Font("Bebas Neue", 10F);
            this.recovery_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.recovery_lbl.Location = new System.Drawing.Point(93, 247);
            this.recovery_lbl.Name = "recovery_lbl";
            this.recovery_lbl.Size = new System.Drawing.Size(80, 17);
            this.recovery_lbl.TabIndex = 21;
            this.recovery_lbl.Text = "Recovery code:";
            // 
            // confirmpassword_tb
            // 
            this.confirmpassword_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.confirmpassword_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmpassword_tb.Font = new System.Drawing.Font("Arial", 10F);
            this.confirmpassword_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.confirmpassword_tb.Location = new System.Drawing.Point(136, 167);
            this.confirmpassword_tb.Name = "confirmpassword_tb";
            this.confirmpassword_tb.PasswordChar = '*';
            this.confirmpassword_tb.Size = new System.Drawing.Size(151, 23);
            this.confirmpassword_tb.TabIndex = 14;
            // 
            // newpassword_tb
            // 
            this.newpassword_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.newpassword_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newpassword_tb.Font = new System.Drawing.Font("Arial", 10F);
            this.newpassword_tb.ForeColor = System.Drawing.SystemColors.Info;
            this.newpassword_tb.Location = new System.Drawing.Point(136, 138);
            this.newpassword_tb.Name = "newpassword_tb";
            this.newpassword_tb.PasswordChar = '*';
            this.newpassword_tb.Size = new System.Drawing.Size(151, 23);
            this.newpassword_tb.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(91, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 57);
            this.label1.TabIndex = 19;
            this.label1.Text = "Forgotten password? no worries\r\nWe will sent a recovery code to\r\nyour email accou" +
    "nt!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newpassword_lbl
            // 
            this.newpassword_lbl.AutoSize = true;
            this.newpassword_lbl.Font = new System.Drawing.Font("Bebas Neue", 10F);
            this.newpassword_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.newpassword_lbl.Location = new System.Drawing.Point(51, 141);
            this.newpassword_lbl.Name = "newpassword_lbl";
            this.newpassword_lbl.Size = new System.Drawing.Size(79, 17);
            this.newpassword_lbl.TabIndex = 13;
            this.newpassword_lbl.Text = "New password:";
            // 
            // confirmNP_lbl
            // 
            this.confirmNP_lbl.AutoSize = true;
            this.confirmNP_lbl.Font = new System.Drawing.Font("Bebas Neue", 10F);
            this.confirmNP_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.confirmNP_lbl.Location = new System.Drawing.Point(55, 173);
            this.confirmNP_lbl.Name = "confirmNP_lbl";
            this.confirmNP_lbl.Size = new System.Drawing.Size(75, 17);
            this.confirmNP_lbl.TabIndex = 15;
            this.confirmNP_lbl.Text = "Confirmation:";
            // 
            // confirm_btn
            // 
            this.confirm_btn.Font = new System.Drawing.Font("Bebas Neue", 10F);
            this.confirm_btn.Location = new System.Drawing.Point(154, 312);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(75, 23);
            this.confirm_btn.TabIndex = 17;
            this.confirm_btn.Text = "CONFIRM";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // password_chkb
            // 
            this.password_chkb.AutoSize = true;
            this.password_chkb.Font = new System.Drawing.Font("Bebas Neue", 10F);
            this.password_chkb.ForeColor = System.Drawing.SystemColors.Control;
            this.password_chkb.Location = new System.Drawing.Point(186, 196);
            this.password_chkb.Name = "password_chkb";
            this.password_chkb.Size = new System.Drawing.Size(101, 21);
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
            this.ClientSize = new System.Drawing.Size(433, 495);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "account_recovery_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "account_recovery_form";
            this.Load += new System.EventHandler(this.account_recovery_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox minimize_pb;
        private System.Windows.Forms.PictureBox close_pb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox recoveryC_tb;
        private System.Windows.Forms.Label recovery_lbl;
        private System.Windows.Forms.TextBox confirmpassword_tb;
        private System.Windows.Forms.TextBox newpassword_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newpassword_lbl;
        private System.Windows.Forms.Label confirmNP_lbl;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.CheckBox password_chkb;
        private System.Windows.Forms.LinkLabel resend_llbl;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label email_lbl;
    }
}