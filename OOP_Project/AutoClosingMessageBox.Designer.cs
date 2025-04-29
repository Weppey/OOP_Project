using System;
using System.Windows.Forms;

namespace OOP_Project // Ensure the correct namespace
{
    public partial class AutoClosingMessageBox : Form
    {
        private Timer closeTimer;
        private int timeoutMilliseconds;
        private int remainingTime;
        public DialogResult UserResponse { get; private set; } = DialogResult.None;

        public AutoClosingMessageBox(string message, string title, int timeoutMs = 10000)
        {
            InitializeComponent();
            this.Text = title;  // Set form title
            this.labelMessage.Text = message;  // Set label message text
            this.remainingTime = timeoutMs / 1000;  // Convert to seconds
            this.timeoutMilliseconds = timeoutMs;

            closeTimer = new Timer();
            closeTimer.Interval = 1000;  // 1 second tick interval
            closeTimer.Tick += CloseTimer_Tick;
            closeTimer.Start();
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--; // Decrease remaining time by 1

            // Set the text directly to show the remaining time
            labelMessage.Text = $"Are You Still There: {remainingTime}s remaining"; // Overwrite the text

            // If remaining time is 0 or below, auto-click "Yes" and close the box
            if (remainingTime <= 0)
            {
                closeTimer.Stop(); // Stop the timer
                this.DialogResult = DialogResult.Yes;  // Simulate the "Yes" answer after timeout
                this.Close(); // Close the dialog
            }
        }


        private void buttonNo_Click(object sender, EventArgs e)
        {
            UserResponse = DialogResult.Yes;
            closeTimer.Stop();
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            UserResponse = DialogResult.No;
            closeTimer.Stop();
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
