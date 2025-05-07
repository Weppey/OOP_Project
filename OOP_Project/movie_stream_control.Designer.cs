namespace OOP_Project
{
    partial class movie_stream_control
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
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.background_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.max_pb = new System.Windows.Forms.PictureBox();
            this.website_logo = new System.Windows.Forms.PictureBox();
            this.close_pb = new System.Windows.Forms.PictureBox();
            this.disclaimer_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.background_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.website_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(22, 20);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1298, 693);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // background_panel
            // 
            this.background_panel.BackColor = System.Drawing.Color.White;
            this.background_panel.Controls.Add(this.pictureBox1);
            this.background_panel.Controls.Add(this.webView21);
            this.background_panel.Location = new System.Drawing.Point(24, 24);
            this.background_panel.Name = "background_panel";
            this.background_panel.Size = new System.Drawing.Size(1341, 733);
            this.background_panel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OOP_Project.Properties.Resources._1_4;
            this.pictureBox1.Location = new System.Drawing.Point(1209, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.max_pb);
            this.panel1.Controls.Add(this.website_logo);
            this.panel1.Controls.Add(this.close_pb);
            this.panel1.Location = new System.Drawing.Point(-182, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1592, 114);
            this.panel1.TabIndex = 2;
            // 
            // max_pb
            // 
            this.max_pb.BackColor = System.Drawing.Color.Transparent;
            this.max_pb.Image = global::OOP_Project.Properties.Resources.icons8_maximize_20;
            this.max_pb.Location = new System.Drawing.Point(1507, 3);
            this.max_pb.Name = "max_pb";
            this.max_pb.Size = new System.Drawing.Size(25, 23);
            this.max_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.max_pb.TabIndex = 21;
            this.max_pb.TabStop = false;
            this.max_pb.Click += new System.EventHandler(this.max_pb_Click);
            // 
            // website_logo
            // 
            this.website_logo.Image = global::OOP_Project.Properties.Resources.onionplay_logo;
            this.website_logo.Location = new System.Drawing.Point(206, 12);
            this.website_logo.Name = "website_logo";
            this.website_logo.Size = new System.Drawing.Size(345, 99);
            this.website_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.website_logo.TabIndex = 20;
            this.website_logo.TabStop = false;
            // 
            // close_pb
            // 
            this.close_pb.BackColor = System.Drawing.Color.Transparent;
            this.close_pb.Image = global::OOP_Project.Properties.Resources.icons8_close_24;
            this.close_pb.Location = new System.Drawing.Point(1533, 3);
            this.close_pb.Name = "close_pb";
            this.close_pb.Size = new System.Drawing.Size(25, 23);
            this.close_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_pb.TabIndex = 19;
            this.close_pb.TabStop = false;
            this.close_pb.Click += new System.EventHandler(this.close_pb_Click);
            // 
            // disclaimer_lbl
            // 
            this.disclaimer_lbl.AutoSize = true;
            this.disclaimer_lbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disclaimer_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.disclaimer_lbl.Location = new System.Drawing.Point(96, 769);
            this.disclaimer_lbl.Name = "disclaimer_lbl";
            this.disclaimer_lbl.Size = new System.Drawing.Size(1176, 17);
            this.disclaimer_lbl.TabIndex = 3;
            this.disclaimer_lbl.Text = "This app does not host or stream any content. All movies are streamed from third-" +
    "party websites OnionPlay. We do not promote piracy and are not affiliated with t" +
    "hese websites. Use at your own risk.";
            // 
            // movie_stream_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1388, 795);
            this.Controls.Add(this.disclaimer_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.background_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "movie_stream_control";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 15;
            this.Text = "movie_stream_control";
            this.Load += new System.EventHandler(this.movie_stream_control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.background_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.max_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.website_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Panel background_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close_pb;
        private System.Windows.Forms.PictureBox website_logo;
        private System.Windows.Forms.Label disclaimer_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox max_pb;
    }
}