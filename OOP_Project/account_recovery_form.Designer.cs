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
            this.min_pb = new System.Windows.Forms.PictureBox();
            this.cls_pb = new System.Windows.Forms.PictureBox();
            this.background_panel = new System.Windows.Forms.Panel();
            this.Panel_Recovery = new System.Windows.Forms.Panel();
            this.confirm_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.send_llbl = new System.Windows.Forms.LinkLabel();
            this.recoveryC_tb = new System.Windows.Forms.TextBox();
            this.recovery_lbl = new System.Windows.Forms.Label();
            this.confirmpassword_tb = new System.Windows.Forms.TextBox();
            this.newpassword_tb = new System.Windows.Forms.TextBox();
            this.Lbl_message = new System.Windows.Forms.Label();
            this.newpassword_lbl = new System.Windows.Forms.Label();
            this.confirmNP_lbl = new System.Windows.Forms.Label();
            this.password_chkb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.min_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls_pb)).BeginInit();
            this.background_panel.SuspendLayout();
            this.Panel_Recovery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // min_pb
            // 
            this.min_pb.BackColor = System.Drawing.Color.Transparent;
            this.min_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.min_pb.Image = global::OOP_Project.Properties.Resources.icons8_minimize_24;
            this.min_pb.Location = new System.Drawing.Point(933, 12);
            this.min_pb.Name = "min_pb";
            this.min_pb.Size = new System.Drawing.Size(25, 23);
            this.min_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.min_pb.TabIndex = 51;
            this.min_pb.TabStop = false;
            this.min_pb.Click += new System.EventHandler(this.min_pb_Click);
            // 
            // cls_pb
            // 
            this.cls_pb.BackColor = System.Drawing.Color.Transparent;
            this.cls_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cls_pb.Image = global::OOP_Project.Properties.Resources.icons8_close_24;
            this.cls_pb.Location = new System.Drawing.Point(962, 12);
            this.cls_pb.Name = "cls_pb";
            this.cls_pb.Size = new System.Drawing.Size(25, 23);
            this.cls_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cls_pb.TabIndex = 50;
            this.cls_pb.TabStop = false;
            this.cls_pb.Click += new System.EventHandler(this.cls_pb_Click);
            // 
            // background_panel
            // 
            this.background_panel.BackgroundImage = global::OOP_Project.Properties.Resources._3;
            this.background_panel.Controls.Add(this.Panel_Recovery);
            this.background_panel.Location = new System.Drawing.Point(35, 50);
            this.background_panel.Name = "background_panel";
            this.background_panel.Size = new System.Drawing.Size(936, 518);
            this.background_panel.TabIndex = 52;
            // 
            // Panel_Recovery
            // 
            this.Panel_Recovery.BackColor = System.Drawing.Color.White;
            this.Panel_Recovery.Controls.Add(this.confirm_btn);
            this.Panel_Recovery.Controls.Add(this.email_tb);
            this.Panel_Recovery.Controls.Add(this.pictureBox3);
            this.Panel_Recovery.Controls.Add(this.email_lbl);
            this.Panel_Recovery.Controls.Add(this.send_llbl);
            this.Panel_Recovery.Controls.Add(this.recoveryC_tb);
            this.Panel_Recovery.Controls.Add(this.recovery_lbl);
            this.Panel_Recovery.Controls.Add(this.confirmpassword_tb);
            this.Panel_Recovery.Controls.Add(this.newpassword_tb);
            this.Panel_Recovery.Controls.Add(this.Lbl_message);
            this.Panel_Recovery.Controls.Add(this.newpassword_lbl);
            this.Panel_Recovery.Controls.Add(this.confirmNP_lbl);
            this.Panel_Recovery.Controls.Add(this.password_chkb);
            this.Panel_Recovery.Location = new System.Drawing.Point(44, 17);
            this.Panel_Recovery.Name = "Panel_Recovery";
            this.Panel_Recovery.Size = new System.Drawing.Size(321, 466);
            this.Panel_Recovery.TabIndex = 23;
            // 
            // confirm_btn
            // 
            this.confirm_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.confirm_btn.Location = new System.Drawing.Point(114, 402);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(106, 30);
            this.confirm_btn.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.confirm_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.confirm_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.confirm_btn.StateCommon.Border.Rounding = 5;
            this.confirm_btn.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Disabled;
            this.confirm_btn.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.confirm_btn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, -1, 5, -1);
            this.confirm_btn.TabIndex = 59;
            this.confirm_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_right_162;
            this.confirm_btn.Values.Text = "Confirm";
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // email_tb
            // 
            this.email_tb.BackColor = System.Drawing.Color.White;
            this.email_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.email_tb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.email_tb.Location = new System.Drawing.Point(114, 205);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(151, 22);
            this.email_tb.TabIndex = 48;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OOP_Project.Properties.Resources._1_4;
            this.pictureBox3.Location = new System.Drawing.Point(101, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.email_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.email_lbl.Location = new System.Drawing.Point(56, 207);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(42, 15);
            this.email_lbl.TabIndex = 49;
            this.email_lbl.Text = "Email:";
            // 
            // send_llbl
            // 
            this.send_llbl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.send_llbl.AutoSize = true;
            this.send_llbl.DisabledLinkColor = System.Drawing.Color.White;
            this.send_llbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.send_llbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.send_llbl.Location = new System.Drawing.Point(66, 361);
            this.send_llbl.Name = "send_llbl";
            this.send_llbl.Size = new System.Drawing.Size(193, 15);
            this.send_llbl.TabIndex = 47;
            this.send_llbl.TabStop = true;
            this.send_llbl.Text = "Click here to send a recovery code";
            // 
            // recoveryC_tb
            // 
            this.recoveryC_tb.BackColor = System.Drawing.Color.White;
            this.recoveryC_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recoveryC_tb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryC_tb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.recoveryC_tb.Location = new System.Drawing.Point(119, 313);
            this.recoveryC_tb.MaxLength = 6;
            this.recoveryC_tb.Name = "recoveryC_tb";
            this.recoveryC_tb.PasswordChar = '*';
            this.recoveryC_tb.Size = new System.Drawing.Size(146, 25);
            this.recoveryC_tb.TabIndex = 20;
            // 
            // recovery_lbl
            // 
            this.recovery_lbl.AutoSize = true;
            this.recovery_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.recovery_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.recovery_lbl.Location = new System.Drawing.Point(25, 316);
            this.recovery_lbl.Name = "recovery_lbl";
            this.recovery_lbl.Size = new System.Drawing.Size(88, 15);
            this.recovery_lbl.TabIndex = 21;
            this.recovery_lbl.Text = "Recovery code:";
            // 
            // confirmpassword_tb
            // 
            this.confirmpassword_tb.BackColor = System.Drawing.Color.White;
            this.confirmpassword_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmpassword_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.confirmpassword_tb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.confirmpassword_tb.Location = new System.Drawing.Point(114, 260);
            this.confirmpassword_tb.Name = "confirmpassword_tb";
            this.confirmpassword_tb.PasswordChar = '*';
            this.confirmpassword_tb.Size = new System.Drawing.Size(151, 22);
            this.confirmpassword_tb.TabIndex = 14;
            // 
            // newpassword_tb
            // 
            this.newpassword_tb.BackColor = System.Drawing.Color.White;
            this.newpassword_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newpassword_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.newpassword_tb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.newpassword_tb.Location = new System.Drawing.Point(113, 233);
            this.newpassword_tb.Name = "newpassword_tb";
            this.newpassword_tb.PasswordChar = '*';
            this.newpassword_tb.Size = new System.Drawing.Size(151, 22);
            this.newpassword_tb.TabIndex = 12;
            // 
            // Lbl_message
            // 
            this.Lbl_message.AutoSize = true;
            this.Lbl_message.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_message.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_message.Location = new System.Drawing.Point(70, 147);
            this.Lbl_message.Name = "Lbl_message";
            this.Lbl_message.Size = new System.Drawing.Size(189, 45);
            this.Lbl_message.TabIndex = 19;
            this.Lbl_message.Text = "Recover Your Password.\r\nStrong password includes letters,\r\nnumbers, and symbols.";
            this.Lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newpassword_lbl
            // 
            this.newpassword_lbl.AutoSize = true;
            this.newpassword_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.newpassword_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newpassword_lbl.Location = new System.Drawing.Point(20, 235);
            this.newpassword_lbl.Name = "newpassword_lbl";
            this.newpassword_lbl.Size = new System.Drawing.Size(87, 15);
            this.newpassword_lbl.TabIndex = 13;
            this.newpassword_lbl.Text = "New password:";
            // 
            // confirmNP_lbl
            // 
            this.confirmNP_lbl.AutoSize = true;
            this.confirmNP_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.confirmNP_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.confirmNP_lbl.Location = new System.Drawing.Point(24, 262);
            this.confirmNP_lbl.Name = "confirmNP_lbl";
            this.confirmNP_lbl.Size = new System.Drawing.Size(84, 15);
            this.confirmNP_lbl.TabIndex = 15;
            this.confirmNP_lbl.Text = "Confirmation:";
            // 
            // password_chkb
            // 
            this.password_chkb.AutoSize = true;
            this.password_chkb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.password_chkb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password_chkb.Location = new System.Drawing.Point(157, 288);
            this.password_chkb.Name = "password_chkb";
            this.password_chkb.Size = new System.Drawing.Size(108, 19);
            this.password_chkb.TabIndex = 16;
            this.password_chkb.Text = "Show password";
            this.password_chkb.UseVisualStyleBackColor = true;
            // 
            // account_recovery_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(999, 580);
            this.Controls.Add(this.background_panel);
            this.Controls.Add(this.min_pb);
            this.Controls.Add(this.cls_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "account_recovery_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "account_recovery_form";
            this.Load += new System.EventHandler(this.account_recovery_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.min_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls_pb)).EndInit();
            this.background_panel.ResumeLayout(false);
            this.Panel_Recovery.ResumeLayout(false);
            this.Panel_Recovery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox min_pb;
        private System.Windows.Forms.PictureBox cls_pb;
        private System.Windows.Forms.Panel background_panel;
        private System.Windows.Forms.Panel Panel_Recovery;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.LinkLabel send_llbl;
        private System.Windows.Forms.TextBox recoveryC_tb;
        private System.Windows.Forms.Label recovery_lbl;
        private System.Windows.Forms.TextBox confirmpassword_tb;
        private System.Windows.Forms.TextBox newpassword_tb;
        private System.Windows.Forms.Label Lbl_message;
        private System.Windows.Forms.Label newpassword_lbl;
        private System.Windows.Forms.Label confirmNP_lbl;
        private System.Windows.Forms.CheckBox password_chkb;
        private ComponentFactory.Krypton.Toolkit.KryptonButton confirm_btn;
    }
}