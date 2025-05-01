namespace OOP_Project
{
    partial class PopularControl
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
            this.popularPanel_panel = new System.Windows.Forms.Panel();
            this.popular_lbl = new System.Windows.Forms.Label();
            this.popularMovie_panel = new System.Windows.Forms.Panel();
            this.popularMovie_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.popularPanel_panel.SuspendLayout();
            this.popularMovie_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // popularPanel_panel
            // 
            this.popularPanel_panel.AutoScroll = true;
            this.popularPanel_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.popularPanel_panel.Controls.Add(this.popular_lbl);
            this.popularPanel_panel.Controls.Add(this.popularMovie_panel);
            this.popularPanel_panel.Location = new System.Drawing.Point(33, 30);
            this.popularPanel_panel.Name = "popularPanel_panel";
            this.popularPanel_panel.Size = new System.Drawing.Size(1148, 554);
            this.popularPanel_panel.TabIndex = 71;
            // 
            // popular_lbl
            // 
            this.popular_lbl.AutoSize = true;
            this.popular_lbl.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.popular_lbl.ForeColor = System.Drawing.Color.White;
            this.popular_lbl.Location = new System.Drawing.Point(54, 18);
            this.popular_lbl.Name = "popular_lbl";
            this.popular_lbl.Size = new System.Drawing.Size(187, 31);
            this.popular_lbl.TabIndex = 67;
            this.popular_lbl.Text = "Popular today...";
            // 
            // popularMovie_panel
            // 
            this.popularMovie_panel.BackColor = System.Drawing.Color.Gray;
            this.popularMovie_panel.Controls.Add(this.popularMovie_flp);
            this.popularMovie_panel.Location = new System.Drawing.Point(60, 62);
            this.popularMovie_panel.Name = "popularMovie_panel";
            this.popularMovie_panel.Size = new System.Drawing.Size(1040, 468);
            this.popularMovie_panel.TabIndex = 66;
            // 
            // popularMovie_flp
            // 
            this.popularMovie_flp.AutoScroll = true;
            this.popularMovie_flp.BackColor = System.Drawing.Color.White;
            this.popularMovie_flp.Location = new System.Drawing.Point(20, 20);
            this.popularMovie_flp.Name = "popularMovie_flp";
            this.popularMovie_flp.Padding = new System.Windows.Forms.Padding(5);
            this.popularMovie_flp.Size = new System.Drawing.Size(1002, 425);
            this.popularMovie_flp.TabIndex = 0;
            // 
            // PopularControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.popularPanel_panel);
            this.Name = "PopularControl";
            this.Size = new System.Drawing.Size(1214, 614);
            this.Load += new System.EventHandler(this.PopularControl_Load);
            this.popularPanel_panel.ResumeLayout(false);
            this.popularPanel_panel.PerformLayout();
            this.popularMovie_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel popularPanel_panel;
        private System.Windows.Forms.Label popular_lbl;
        private System.Windows.Forms.Panel popularMovie_panel;
        private System.Windows.Forms.FlowLayoutPanel popularMovie_flp;
    }
}
