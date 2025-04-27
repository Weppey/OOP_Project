using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace OOP_Project
{
    public static class StayLoggedIn
    {
        // Use AppData for session and cache files to avoid issues with restricted permissions
        private static readonly string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "OOP_Project");
        private static readonly string sessionFilePath = Path.Combine(appDataFolder, "session.txt");
        private static readonly string imageCacheFilePath = Path.Combine(appDataFolder, "imageCache.txt");

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

        // Save the cached image URLs to a file
        public static void SaveCachedImages(string[] cachedImages)
        {
            try
            {
                File.WriteAllLines(imageCacheFilePath, cachedImages);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving cached images: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load cached image URLs from the file
        public static string[] GetCachedImageUrls()
        {
            try
            {
                if (File.Exists(imageCacheFilePath))
                {
                    return File.ReadAllLines(imageCacheFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cached images: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new string[0]; // Return an empty array if no cached images
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
    }
}
