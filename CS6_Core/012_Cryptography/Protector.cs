using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace _012_Cryptography
{
    public static class Protector
    {
        private static readonly byte[] salt = Encoding.Unicode.GetBytes("7BANANAS");
        private static readonly int iterations = 2000;

        public static string Encrypt(string plainText, string password)
        {
            byte[] plainBytes = Encoding.Unicode.GetBytes(plainText);
            var aes = Aes.Create();
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            aes.Key = pbkdf2.GetBytes(32);  // set 256-bit key
            aes.IV = pbkdf2.GetBytes(16);   // set 128-bit key
            var ms = new MemoryStream();
            using(var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
            {
                cs.Write(plainBytes, 0, plainBytes.Length);
            }
            return Convert.ToBase64String(ms.ToArray());
        }

        public static string Decrypt(string cryptoText, string password)
        {
            byte[] cryptoBytes = Convert.FromBase64String(cryptoText);
            var aes = Aes.Create();
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            aes.Key = pbkdf2.GetBytes(32);  // set 256-bit key
            aes.IV = pbkdf2.GetBytes(16);   // set 128-bit key
            var ms = new MemoryStream();
            using(var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
            {
                cs.Write(cryptoBytes, 0, cryptoBytes.Length);
            }
            return Encoding.Unicode.GetString(ms.ToArray());
        }
    }
}