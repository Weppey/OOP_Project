namespace OOP_Project
{
    partial class AutoClosingMessageBox
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;

        // Form override to clean up resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Required method for Designer support
        private void InitializeComponent()
        {
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelMessage
            this.labelMessage.Location = new System.Drawing.Point(12, 9);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(360, 60);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "Message goes here.";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // buttonYes
            this.buttonYes.Location = new System.Drawing.Point(70, 80);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(100, 35);
            this.buttonYes.TabIndex = 1;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);

            // buttonNo
            this.buttonNo.Location = new System.Drawing.Point(220, 80);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(100, 35);
            this.buttonNo.TabIndex = 2;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);

            // AutoClosingMessageBox
            this.AcceptButton = this.buttonYes;
            this.CancelButton = this.buttonNo;
            this.ClientSize = new System.Drawing.Size(384, 130);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.labelMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutoClosingMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Closing MessageBox";
            this.ResumeLayout(false);
        }
    }
}