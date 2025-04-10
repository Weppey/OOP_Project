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
            this.Panel_verify = new System.Windows.Forms.Panel();
            this.resend_llbl = new System.Windows.Forms.LinkLabel();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.emailverify_lbl = new System.Windows.Forms.Label();
            this.code_tb = new System.Windows.Forms.TextBox();
            this.status_lbl = new System.Windows.Forms.Label();
            this.code_lbl = new System.Windows.Forms.Label();
            this.logo_pb = new System.Windows.Forms.PictureBox();
            this.minimize_pb = new System.Windows.Forms.PictureBox();
            this.close_pb = new System.Windows.Forms.PictureBox();
            this.Panel_tab = new System.Windows.Forms.Panel();
            this.Panel_verify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).BeginInit();
            this.Panel_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_verify
            // 
            this.Panel_verify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Panel_verify.Controls.Add(this.resend_llbl);
            this.Panel_verify.Controls.Add(this.confirm_btn);
            this.Panel_verify.Controls.Add(this.logo_pb);
            this.Panel_verify.Controls.Add(this.emailverify_lbl);
            this.Panel_verify.Controls.Add(this.code_tb);
            this.Panel_verify.Controls.Add(this.status_lbl);
            this.Panel_verify.Controls.Add(this.code_lbl);
            this.Panel_verify.Location = new System.Drawing.Point(243, 74);
            this.Panel_verify.Name = "Panel_verify";
            this.Panel_verify.Size = new System.Drawing.Size(332, 408);
            this.Panel_verify.TabIndex = 1;
      
            // 
            // resend_llbl
            // 
            this.resend_llbl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.resend_llbl.AutoSize = true;
            this.resend_llbl.DisabledLinkColor = System.Drawing.Color.White;
            this.resend_llbl.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resend_llbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.resend_llbl.Location = new System.Drawing.Point(107, 308);
            this.resend_llbl.Name = "resend_llbl";
            this.resend_llbl.Size = new System.Drawing.Size(132, 25);
            this.resend_llbl.TabIndex = 46;
            this.resend_llbl.TabStop = true;
            this.resend_llbl.Text = "Resend code:";
            this.resend_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resend_llbl_LinkClicked);
            // 
            // confirm_btn
            // 
            this.confirm_btn.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.Location = new System.Drawing.Point(125, 347);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(93, 29);
            this.confirm_btn.TabIndex = 44;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // emailverify_lbl
            // 
            this.emailverify_lbl.AutoSize = true;
            this.emailverify_lbl.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailverify_lbl.ForeColor = System.Drawing.Color.White;
            this.emailverify_lbl.Location = new System.Drawing.Point(65, 103);
            this.emailverify_lbl.Name = "emailverify_lbl";
            this.emailverify_lbl.Size = new System.Drawing.Size(237, 37);
            this.emailverify_lbl.TabIndex = 42;
            this.emailverify_lbl.Text = "Email verification";
            // 
            // code_tb
            // 
            this.code_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.code_tb.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_tb.ForeColor = System.Drawing.SystemColors.Window;
            this.code_tb.Location = new System.Drawing.Point(139, 201);
            this.code_tb.Name = "code_tb";
            this.code_tb.Size = new System.Drawing.Size(135, 25);
            this.code_tb.TabIndex = 41;
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_lbl.ForeColor = System.Drawing.Color.White;
            this.status_lbl.Location = new System.Drawing.Point(68, 238);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(215, 21);
            this.status_lbl.TabIndex = 40;
            this.status_lbl.Text = "Please verify your account\r\n";
            this.status_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // code_lbl
            // 
            this.code_lbl.AutoSize = true;
            this.code_lbl.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_lbl.ForeColor = System.Drawing.Color.White;
            this.code_lbl.Location = new System.Drawing.Point(69, 205);
            this.code_lbl.Name = "code_lbl";
            this.code_lbl.Size = new System.Drawing.Size(53, 21);
            this.code_lbl.TabIndex = 39;
            this.code_lbl.Text = "Code:";
           
            // 
            // logo_pb
            // 
            this.logo_pb.Image = global::OOP_Project.Properties.Resources.Logonetflix;
            this.logo_pb.Location = new System.Drawing.Point(125, 50);
            this.logo_pb.Name = "logo_pb";
            this.logo_pb.Size = new System.Drawing.Size(100, 50);
            this.logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_pb.TabIndex = 0;
            this.logo_pb.TabStop = false;
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
            this.minimize_pb.TabIndex = 11;
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
            this.close_pb.TabIndex = 10;
            this.close_pb.TabStop = false;
            this.close_pb.Click += new System.EventHandler(this.close_pb_Click);
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
            this.Panel_tab.TabIndex = 3;
            // 
            // verification_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(870, 510);
            this.Controls.Add(this.Panel_tab);
            this.Controls.Add(this.Panel_verify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "verification_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "verification_form";
         
            this.Panel_verify.ResumeLayout(false);
            this.Panel_verify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).EndInit();
            this.Panel_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_verify;
        private System.Windows.Forms.PictureBox logo_pb;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Label emailverify_lbl;
        private System.Windows.Forms.TextBox code_tb;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.Label code_lbl;
        private System.Windows.Forms.LinkLabel resend_llbl;
        private System.Windows.Forms.PictureBox minimize_pb;
        private System.Windows.Forms.PictureBox close_pb;
        private System.Windows.Forms.Panel Panel_tab;
    }
}