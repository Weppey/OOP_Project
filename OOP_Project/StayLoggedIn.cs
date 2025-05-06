using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public static class StayLoggedIn
    {
        // Use AppData for session and cache files to avoid issues with restricted permissions
        private static readonly string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "OOP_Project");
        private static readonly string sessionFilePath = Path.Combine(appDataFolder, "session.txt");

        static StayLoggedIn()
        {
            // Ensure the directory exists for storing session and image cache files
            try
            {
                Directory.CreateDirectory(appDataFolder);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Save the user session (userType and userId)


        public static void SaveUserSession(string userType, int userId)
        {
            try
            {
                File.WriteAllText(sessionFilePath, $"{userType}|{userId}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user session: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load the user session from the file
        public static (string userType, int userId)? LoadUserSession()
        {
            try
            {
                if (File.Exists(sessionFilePath))
                {
                    string[] data = File.ReadAllText(sessionFilePath).Split('|');
                    if (data.Length == 2 && int.TryParse(data[1], out int userId))
                    {
                        return (data[0], userId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user session: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null; // Return null if no session exists
        }

        // Clear the user session file
        public static void ClearSession()
        {
            try
            {
                if (File.Exists(sessionFilePath))
                    File.Delete(sessionFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing user session: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   

        // Retrieve the current userId from the session file, if available
        public static int? GetCurrentUserId()
        {
            var session = LoadUserSession();
            return session?.userId;
        }

        // Optionally, you can create a method to check if the user is logged in
        public static bool IsLoggedIn()
        {
            return LoadUserSession() != null;
        }

        public static class ImageCacheHelper
        {
            private static readonly string cacheFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "OOP_Project", "ImageCache");

            static ImageCacheHelper()
            {
                try
                {
                    Directory.CreateDirectory(cacheFolder);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating image cache directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public static string GetCachedImagePath(string imageUrl)
            {
                // Generate a unique filename based on the image URL (hash it to avoid illegal characters)
                string fileName = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(imageUrl)).Replace("/", "_") + ".jpg";
                return Path.Combine(cacheFolder, fileName);
            }

            public static async Task<string> DownloadImageIfNotCachedAsync(string imageUrl)
            {
                string cachedPath = GetCachedImagePath(imageUrl);

                if (!File.Exists(cachedPath))
                {
                    try
                    {
                        using (var client = new HttpClient())
                        {
                            var imageBytes = await client.GetByteArrayAsync(imageUrl);

                            // If you're using .NET Framework, use WriteAllBytes instead of WriteAllBytesAsync
                            File.WriteAllBytes(cachedPath, imageBytes);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to download image: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }
                }

                return cachedPath;
            }

        }
        }
    public static class UserThemeSettings
    {
        private static readonly string themeFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "OOP_Project", "theme_settings.json");

        public class ThemePreference
        {
            public int UserId { get; set; }
            public bool IsDarkMode { get; set; }
        }

        public static void SaveTheme(int userId, bool isDarkMode)
        {
            Dictionary<int, bool> settings;

            if (File.Exists(themeFilePath))
            {
                var json = File.ReadAllText(themeFilePath);
                settings = JsonConvert.DeserializeObject<Dictionary<int, bool>>(json)
                           ?? new Dictionary<int, bool>();
            }
            else
            {
                settings = new Dictionary<int, bool>();
            }

            settings[userId] = isDarkMode;
            File.WriteAllText(themeFilePath, JsonConvert.SerializeObject(settings));
        }

        public static bool? LoadTheme(int userId)
        {
            if (!File.Exists(themeFilePath))
                return null;

            var json = File.ReadAllText(themeFilePath);
            var settings = JsonConvert.DeserializeObject<Dictionary<int, bool>>(json);

            if (settings != null && settings.TryGetValue(userId, out bool isDarkMode))
                return isDarkMode;

            return null;
        }
    }
}