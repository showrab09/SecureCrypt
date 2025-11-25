using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureCrypt
{
    public static class PasswordHelper
    {
        // Hash password with SHA256 
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
