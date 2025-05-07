using Microsoft.Web.WebView2.Core;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace OOP_Project
{
    public partial class movie_stream_control : KryptonForm
    {
        private string movieUrl;
        private Timer disclaimerTimer;  // Declare the disclaimerTimer

        public movie_stream_control(string url)
        {
            InitializeComponent();
            movieUrl = url;

            // Initialize and start the disclaimer timer
            disclaimerTimer = new Timer();
            disclaimerTimer.Interval = 30; // Adjust for speed of animation
            disclaimerTimer.Tick += disclaimerTimer_Tick; // Attach the event handler
            disclaimerTimer.Start(); // Start the animation loop

            CurvePanel(background_panel, 30);
            background_panel.Resize += (s, args) => CurvePanel(background_panel, 20);
        }

        private async void movie_stream_control_Load(object sender, EventArgs e)
        {
            try
            {
                // Ensure WebView2 is ready
                await webView21.EnsureCoreWebView2Async(null);

                // Prevent new tabs/popups
                webView21.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;

                // Navigate to the movie URL
                webView21.CoreWebView2.Navigate(movieUrl);

                // Optional: Prevent user from scrolling beyond a certain point
                string limitedScrollScript = @"
                    window.addEventListener('scroll', function(e) { 
                        if (window.scrollY > 300) {
                            window.scrollTo(0, 300); // Lock scroll at 300px
                        }
                    });
                ";
                await webView21.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(limitedScrollScript);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load the movie: " + ex.Message);
            }
        }

        private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            string requestedUrl = e.Uri;

            if (requestedUrl == "https://onionplay.ch/donate/")
            {
                // Allow the popup to open inside the same WebView
                webView21.CoreWebView2.Navigate(requestedUrl);

                // Prevent it from opening in a new window
                e.Handled = true;
            }
            else
            {
                // Block all other popups
                e.Handled = true;
            }
        }

        private void CurvePanel(System.Windows.Forms.Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void close_pb_Click(object sender, EventArgs e)
        {
            webView21.Dispose(); // Dispose WebView2 to release resources
            this.Close(); // Close the form
        }

        private void disclaimerTimer_Tick(object sender, EventArgs e)
        {
            disclaimer_lbl.Left -= 2; // Move the label left

            // Reset to right edge when it goes off-screen
            if (disclaimer_lbl.Right < 0)
            {
                disclaimer_lbl.Left = this.Width; // Start from the right edge again
            }
        }
        int isFullScreen = 0;
        private void max_pb_Click(object sender, EventArgs e)
        {
            if (isFullScreen == 0)
            {
                FullScreenForm();
                isFullScreen = 1;
            }
            else
            {
                BackToNormal();
            }
        }

        private void FullScreenForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal; // Reset first in case it's already maximized
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
        }
        private void BackToNormal()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Bounds = Screen.PrimaryScreen.WorkingArea; // Optional: resize to working area
        }

    }
}
