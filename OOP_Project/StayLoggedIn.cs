using System.IO;
using System.Windows.Forms;

namespace OOP_Project
{
    public static class StayLoggedIn
    {
        private static readonly string sessionFilePath = Path.Combine(Application.StartupPath, "session.txt");

        public static void SaveUserSession(string userType)
        {
            File.WriteAllText(sessionFilePath, userType);
        }

        public static string LoadUserSession()
        {
            if (File.Exists(sessionFilePath))
                return File.ReadAllText(sessionFilePath);
            return null;
        }

        public static void ClearSession()
        {
            if (File.Exists(sessionFilePath))
                File.Delete(sessionFilePath);
        }
    }
}
