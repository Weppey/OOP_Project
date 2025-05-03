namespace OOP_Project
{
    partial class verification_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verification_form));
            this.Panel_verify = new System.Windows.Forms.Panel();
            this.note_lbl = new System.Windows.Forms.Label();
            this.logo_pb = new System.Windows.Forms.PictureBox();
            this.confirm_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bg2_panel = new System.Windows.Forms.Panel();
            this.resend_llbl = new System.Windows.Forms.LinkLabel();
            this.emailverify_lbl = new System.Windows.Forms.Label();
            this.code_tb = new System.Windows.Forms.TextBox();
            this.status_lbl = new System.Windows.Forms.Label();
            this.code_lbl = new System.Windows.Forms.Label();
            this.min_pb = new System.Windows.Forms.PictureBox();
            this.cls_pb = new System.Windows.Forms.PictureBox();
            this.Panel_verify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_verify
            // 
            this.Panel_verify.BackColor = System.Drawing.Color.White;
            this.Panel_verify.Controls.Add(this.note_lbl);
            this.Panel_verify.Controls.Add(this.logo_pb);
            this.Panel_verify.Controls.Add(this.confirm_btn);
            this.Panel_verify.Controls.Add(this.bg2_panel);
            this.Panel_verify.Controls.Add(this.resend_llbl);
            this.Panel_verify.Controls.Add(this.emailverify_lbl);
            this.Panel_verify.Controls.Add(this.code_tb);
            this.Panel_verify.Controls.Add(this.status_lbl);
            this.Panel_verify.Controls.Add(this.code_lbl);
            this.Panel_verify.Location = new System.Drawing.Point(105, 99);
            this.Panel_verify.Name = "Panel_verify";
            this.Panel_verify.Size = new System.Drawing.Size(844, 451);
            this.Panel_verify.TabIndex = 1;
            // 
            // note_lbl
            // 
            this.note_lbl.AutoSize = true;
            this.note_lbl.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_lbl.ForeColor = System.Drawing.Color.Gray;
            this.note_lbl.Location = new System.Drawing.Point(612, 270);
            this.note_lbl.Name = "note_lbl";
            this.note_lbl.Size = new System.Drawing.Size(182, 28);
            this.note_lbl.TabIndex = 60;
            this.note_lbl.Text = "Please kindly check your spam folder \r\nif you didn’t receive the code.";
            this.note_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo_pb
            // 
            this.logo_pb.Image = global::OOP_Project.Properties.Resources._11;
            this.logo_pb.Location = new System.Drawing.Point(635, 18);
            this.logo_pb.Name = "logo_pb";
            this.logo_pb.Size = new System.Drawing.Size(133, 122);
            this.logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_pb.TabIndex = 12;
            this.logo_pb.TabStop = false;
            // 
            // confirm_btn
            // 
            this.confirm_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.confirm_btn.Location = new System.Drawing.Point(652, 368);
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
            this.confirm_btn.TabIndex = 58;
            this.confirm_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_right_162;
            this.confirm_btn.Values.Text = "Confirm";
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // bg2_panel
            // 
            this.bg2_panel.BackColor = System.Drawing.Color.White;
            this.bg2_panel.BackgroundImage = global::OOP_Project.Properties.Resources._41;
            this.bg2_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bg2_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bg2_panel.Location = new System.Drawing.Point(0, 0);
            this.bg2_panel.Name = "bg2_panel";
            this.bg2_panel.Size = new System.Drawing.Size(540, 451);
            this.bg2_panel.TabIndex = 55;
            // 
            // resend_llbl
            // 
            this.resend_llbl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.resend_llbl.AutoSize = true;
            this.resend_llbl.DisabledLinkColor = System.Drawing.Color.White;
            this.resend_llbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resend_llbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.resend_llbl.Location = new System.Drawing.Point(662, 331);
            this.resend_llbl.Name = "resend_llbl";
            this.resend_llbl.Size = new System.Drawing.Size(79, 15);
            this.resend_llbl.TabIndex = 46;
            this.resend_llbl.TabStop = true;
            this.resend_llbl.Text = "Resend code:";
            this.resend_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resend_llbl_LinkClicked);
            // 
            // emailverify_lbl
            // 
            this.emailverify_lbl.AutoSize = true;
            this.emailverify_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailverify_lbl.ForeColor = System.Drawing.Color.Black;
            this.emailverify_lbl.Location = new System.Drawing.Point(607, 154);
            this.emailverify_lbl.Name = "emailverify_lbl";
            this.emailverify_lbl.Size = new System.Drawing.Size(196, 26);
            this.emailverify_lbl.TabIndex = 42;
            this.emailverify_lbl.Text = "Email verification";
            // 
            // code_tb
            // 
            this.code_tb.BackColor = System.Drawing.Color.White;
            this.code_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.code_tb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_tb.ForeColor = System.Drawing.Color.Black;
            this.code_tb.Location = new System.Drawing.Point(635, 197);
            this.code_tb.Name = "code_tb";
            this.code_tb.Size = new System.Drawing.Size(157, 25);
            this.code_tb.TabIndex = 41;
            this.code_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.code_tb.Enter += new System.EventHandler(this.code_tb_Enter);
            this.code_tb.Leave += new System.EventHandler(this.code_tb_Leave);
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_lbl.ForeColor = System.Drawing.Color.Black;
            this.status_lbl.Location = new System.Drawing.Point(623, 246);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(149, 30);
            this.status_lbl.TabIndex = 40;
            this.status_lbl.Text = "Please verify your account\r\n.";
            this.status_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // code_lbl
            // 
            this.code_lbl.AutoSize = true;
            this.code_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_lbl.ForeColor = System.Drawing.Color.Black;
            this.code_lbl.Location = new System.Drawing.Point(583, 200);
            this.code_lbl.Name = "code_lbl";
            this.code_lbl.Size = new System.Drawing.Size(46, 19);
            this.code_lbl.TabIndex = 39;
            this.code_lbl.Text = "Code:";
            // 
            // min_pb
            // 
            this.min_pb.BackColor = System.Drawing.Color.Transparent;
            this.min_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.min_pb.Image = global::OOP_Project.Properties.Resources.icons8_minimize_24;
            this.min_pb.Location = new System.Drawing.Point(986, 12);
            this.min_pb.Name = "min_pb";
            this.min_pb.Size = new System.Drawing.Size(25, 23);
            this.min_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.min_pb.TabIndex = 11;
            this.min_pb.TabStop = false;
            this.min_pb.Click += new System.EventHandler(this.min_pb_Click);
            // 
            // cls_pb
            // 
            this.cls_pb.BackColor = System.Drawing.Color.Transparent;
            this.cls_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cls_pb.Image = global::OOP_Project.Properties.Resources.icons8_close_24;
            this.cls_pb.Location = new System.Drawing.Point(1015, 12);
            this.cls_pb.Name = "cls_pb";
            this.cls_pb.Size = new System.Drawing.Size(25, 23);
            this.cls_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cls_pb.TabIndex = 10;
            this.cls_pb.TabStop = false;
            this.cls_pb.Click += new System.EventHandler(this.cls_pb_Click);
            // 
            // verification_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 650);
            this.Controls.Add(this.min_pb);
            this.Controls.Add(this.cls_pb);
            this.Controls.Add(this.Panel_verify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "verification_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verification - Remmm";
            this.Panel_verify.ResumeLayout(false);
            this.Panel_verify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_verify;
        private System.Windows.Forms.Label emailverify_lbl;
        private System.Windows.Forms.TextBox code_tb;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.Label code_lbl;
        private System.Windows.Forms.LinkLabel resend_llbl;
        private System.Windows.Forms.PictureBox min_pb;
        private System.Windows.Forms.PictureBox cls_pb;
        private System.Windows.Forms.Panel bg2_panel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton confirm_btn;
        private System.Windows.Forms.PictureBox logo_pb;
        private System.Windows.Forms.Label note_lbl;
    }
}