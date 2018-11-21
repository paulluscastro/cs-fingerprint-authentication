using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace FingerprintAuthentication.Commons.Utils
{
    public static class Crypto
    {
        private static StringBuilder sb = new StringBuilder(32);
        public static string HashMD5(string text)
        {
            using (MD5 hash = MD5.Create())
            {
                byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(text));
                sb.Clear();
                foreach (var b in data)
                    sb.Append(b.ToString("X2"));
            }
            return sb.ToString().ToUpper();
        }
        public static string HashMD5(string text, string salt) => HashMD5(text + salt);
    }
}
