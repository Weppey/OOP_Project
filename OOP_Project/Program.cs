using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_Project.StayLoggedIn;

namespace OOP_Project
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Load the theme preference before starting the form
            ThemeManager.LoadSavedThemePreference();

            var userSession = StayLoggedIn.LoadUserSession();
            if (userSession.HasValue)
            {
                string sessionUserType = userSession.Value.userType;
                int sessionUserId = userSession.Value.userId;

                // Start the application with the user's details
                Application.Run(new home_form(sessionUserType, sessionUserId));
            }
            else
            {
                // No session found, show login form
                Application.Run(new login_form());
            }
        }


    }
}
    