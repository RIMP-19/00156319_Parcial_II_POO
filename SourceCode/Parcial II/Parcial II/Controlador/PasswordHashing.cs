using System;
using System.Text;
using System.Security.Cryptography;

namespace Parcial_II.Controlador
{
    public static class PasswordHashing
    {
        public static string CreateHash(string unHashed)
        {
            using (var md5 = MD5.Create())
            {
                var inputBytes = Encoding.ASCII.GetBytes(unHashed);
                var hashBytes = md5.ComputeHash(inputBytes);
                
                var sb = new StringBuilder();
                foreach (var t in hashBytes)
                {
                    sb.Append(t.ToString("x2"));
                }
                return sb.ToString();
            }            
        }

        public static bool CheckPassword(string unHashed, string dbHash)
        {
            var hashedInput = CreateHash(unHashed);
            
            var comparer = StringComparer.OrdinalIgnoreCase;
            
            return(0 == comparer.Compare(hashedInput,dbHash));
        }
    }
}