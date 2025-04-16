namespace OOP_Project
{
    partial class MovieCard
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
            this.poster_pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.poster_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // poster_pb
            // 
            this.poster_pb.Location = new System.Drawing.Point(0, 0);
            this.poster_pb.Margin = new System.Windows.Forms.Padding(10);
            this.poster_pb.Name = "poster_pb";
            this.poster_pb.Size = new System.Drawing.Size(180, 217);
            this.poster_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.poster_pb.TabIndex = 0;
            this.poster_pb.TabStop = false;
            this.poster_pb.Click += new System.EventHandler(this.poster_pb_Click);
            // 
            // MovieCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.poster_pb);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "MovieCard";
            this.Size = new System.Drawing.Size(180, 217);
            ((System.ComponentModel.ISupportInitialize)(this.poster_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox poster_pb;
    }
}
