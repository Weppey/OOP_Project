namespace OOP_Project
{
    partial class FavoriteControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.favorite_lbl = new System.Windows.Forms.Label();
            this.favoriteMovie_panel = new System.Windows.Forms.Panel();
            this.favoriteMovie_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.favoriteMovie_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // favorite_lbl
            // 
            this.favorite_lbl.AutoSize = true;
            this.favorite_lbl.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.favorite_lbl.ForeColor = System.Drawing.Color.White;
            this.favorite_lbl.Location = new System.Drawing.Point(54, 18);
            this.favorite_lbl.Name = "favorite_lbl";
            this.favorite_lbl.Size = new System.Drawing.Size(177, 31);
            this.favorite_lbl.TabIndex = 67;
            this.favorite_lbl.Text = "Your favorite...";
            // 
            // favoriteMovie_panel
            // 
            this.favoriteMovie_panel.BackColor = System.Drawing.Color.Gray;
            this.favoriteMovie_panel.Controls.Add(this.favoriteMovie_flp);
            this.favoriteMovie_panel.Location = new System.Drawing.Point(60, 62);
            this.favoriteMovie_panel.Name = "favoriteMovie_panel";
            this.favoriteMovie_panel.Size = new System.Drawing.Size(1040, 468);
            this.favoriteMovie_panel.TabIndex = 66;
            // 
            // favoriteMovie_flp
            // 
            this.favoriteMovie_flp.AutoScroll = true;
            this.favoriteMovie_flp.BackColor = System.Drawing.Color.White;
            this.favoriteMovie_flp.Location = new System.Drawing.Point(20, 20);
            this.favoriteMovie_flp.Name = "favoriteMovie_flp";
            this.favoriteMovie_flp.Padding = new System.Windows.Forms.Padding(5);
            this.favoriteMovie_flp.Size = new System.Drawing.Size(1002, 425);
            this.favoriteMovie_flp.TabIndex = 0;
            this.favoriteMovie_flp.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.favorite_lbl);
            this.panel1.Controls.Add(this.favoriteMovie_panel);
            this.panel1.Location = new System.Drawing.Point(31, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 554);
            this.panel1.TabIndex = 70;
            // 
            // FavoriteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel1);
            this.Name = "FavoriteControl";
            this.Size = new System.Drawing.Size(1214, 614);
            this.Load += new System.EventHandler(this.FavoriteControl_Load);
            this.favoriteMovie_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label favorite_lbl;
        private System.Windows.Forms.Panel favoriteMovie_panel;
        private System.Windows.Forms.FlowLayoutPanel favoriteMovie_flp;
        private System.Windows.Forms.Panel panel1;
    }
}
