using System;
using System.Windows.Forms;
using OOP_Project;

public static class InactivityManager
{
    private static Timer inactivityTimer;
    private static int inactivityInterval = 5000; // 10 seconds for testing (adjust as needed)
    private static bool isPaused = false;
    private static Form ownerForm; // Form that owns the session

    public static void Initialize(Form owner)
    {
        ownerForm = owner;

        inactivityTimer = new Timer();
        inactivityTimer.Interval = inactivityInterval;
        inactivityTimer.Tick += InactivityTimer_Tick;
        inactivityTimer.Start();
    }

    public static void ResetTimer()
    {
        if (!isPaused && inactivityTimer != null)
        {
            inactivityTimer.Stop();
            inactivityTimer.Start(); // Restart the timer
        }
    }

    public static void Pause()
    {
        if (inactivityTimer != null)
        {
            inactivityTimer.Stop(); // Stop the timer
            isPaused = true;
            Console.WriteLine("Inactivity timer paused.");
        }
    }

    public static void Resume()
    {
        if (inactivityTimer != null)
        {
            inactivityTimer.Start(); // Start the timer
            isPaused = false;
            Console.WriteLine("Inactivity timer resumed.");
        }
    }

    private static async void InactivityTimer_Tick(object sender, EventArgs e)
    {
        Console.WriteLine("Inactivity timer tick triggered.");
        inactivityTimer.Stop();  // Stop the timer

        // If the timer is paused, don't continue
        if (isPaused)
        {
            Console.WriteLine("Timer is paused. Skipping inactivity action.");
            return;
        }

        // Show the logout message box after the inactivity timeout
        AutoClosingMessageBox logoutBox = new AutoClosingMessageBox("Do you really want to sign out?", "Confirm Logout", 10000); // 10 sec timeout
        var result = logoutBox.ShowDialog();

        if (result == DialogResult.Yes)
        {
            Logout();
        }
        else
        {
            inactivityTimer.Start(); // Continue session if the user says No or the box auto-closes
        }
    }

    private static void Logout()
    {
        if (ownerForm != null)
        {
            if (ownerForm is home_form home)
            {
                StayLoggedIn.ClearSession(); // Clear the session before logging out
                home.Hide();

                login_form loginForm = new login_form();
                loginForm.ShowDialog();
                home.Close();
            }
            else
            {
                ownerForm.Invoke(new Action(() =>
                {
                    ownerForm.Close();
                }));
            }
        }
    }
}

