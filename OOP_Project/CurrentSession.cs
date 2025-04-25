using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OOP_Project
{
    public static class CurrentSession
    {
        public static User CurrentUser { get; set; }

        private static string connectionString = "server=localhost;user=root;password=your_password;database=your_database;";

        public static bool Initialize()
        {
            int? userId = StayLoggedIn.GetCurrentUserId();
            if (userId == null) return false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE user_id = @userId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId.Value);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CurrentUser = new User
                        {
                            UserId = reader.GetInt32("user_id"),
                            Username = reader.GetString("username"),
                            Email = reader.GetString("email"),
                            Password = reader.GetString("password"),
                            Age = reader.GetInt32("age"),
                            Gender = reader.GetString("gender"),
                            SignupDate = reader.GetDateTime("signup_date"),
                            Preferences = reader.GetString("preferences"),
                            UserType = reader.GetString("user_type"),
                            SecurityQuestion = reader.GetString("security_question"),
                            SecurityAnswer = reader.GetString("security_answer"),
                            Birthdate = reader.GetDateTime("birthdate"),
                            EmailVerified = reader.GetBoolean("email_verified"),
                            VerificationCode = reader.GetString("verification_code"),
                            CodeGeneratedAt = reader.GetDateTime("code_generated_at"),
                            VerificationCodeSentAt = reader.GetDateTime("verification_code_sent_at")
                        };
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
