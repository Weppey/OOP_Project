using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime SignupDate { get; set; }
        public string Preferences { get; set; }  // Could be comma-separated genres, or converted to a List<string> later
        public string UserType { get; set; }     // e.g., "admin" or "user"
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public DateTime Birthdate { get; set; }
        public bool EmailVerified { get; set; }
        public string VerificationCode { get; set; }
        public DateTime CodeGeneratedAt { get; set; }
        public DateTime VerificationCodeSentAt { get; set; }
    }
}
