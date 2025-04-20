using System.IO;
using System.Windows.Forms;

namespace OOP_Project
{
    public static class StayLoggedIn
    {
        private static readonly string sessionFilePath = Path.Combine(Application.StartupPath, "session.txt");

        public static void SaveUserSession(string userType, int userId)
        {
            File.WriteAllText(sessionFilePath, $"{userType}|{userId}");
        }

        public static (string userType, int userId)? LoadUserSession()
        {
            if (File.Exists(sessionFilePath))
            {
                string[] data = File.ReadAllText(sessionFilePath).Split('|');
                if (data.Length == 2 && int.TryParse(data[1], out int userId))
                {
                    return (data[0], userId);
                }
            }
            return null;
        }

        public static void ClearSession()
        {
            if (File.Exists(sessionFilePath))
                File.Delete(sessionFilePath);
        }
        // Retrieve the current userId from the session file, if available
        public static int? GetCurrentUserId()
        {
            var session = LoadUserSession();
            return session?.userId;
        }
    }
}
