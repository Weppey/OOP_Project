using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;

namespace OOP_Project
{
    internal static class Program
    {
        //goods na
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string sessionUserType = StayLoggedIn.LoadUserSession();

            if (!string.IsNullOrEmpty(sessionUserType))
            {
                Application.Run(new home_form(sessionUserType));
            }
            else
            {
                Application.Run(new login_form());
            }

        }
    }
}
