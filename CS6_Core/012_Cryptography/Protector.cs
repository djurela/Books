using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;

namespace _012_Cryptography
{
    public static class Protector
    {
        public static Dictionary<string, User> Users = new Dictionary<string, User>();
        public static string PublicKey;
        private static readonly byte[] salt = Encoding.Unicode.GetBytes("7BANANAS");
        private static readonly int iterations = 2000;

        #region Encription & decription
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
        #endregion

        #region User handling
        public static User Register(string userName, string password)
        {
            // generate random salt
            var rng = RandomNumberGenerator.Create();
            var saltBytes = new byte[16];
            rng.GetBytes(saltBytes);
            var saltText = Convert.ToBase64String(saltBytes);

            // generate the salted and hashed password
            var sha = SHA256.Create();
            var saltedPassword = password + saltText;
            var saltedhashedPassword = Convert.ToBase64String(sha.ComputeHash(Encoding.Unicode.GetBytes(saltedPassword)));

            var user = new User{Name = userName, Salt = saltText, SaltedHashPassword = saltedhashedPassword};
            Users.Add(user.Name, user);
            
            return user;
        }

        public static bool CheckPassword(string userName, string password)
        {
            if(!Users.TryGetValue(userName, out User user)) return false;

            // regenerate the salted and hashed password
            var sha = SHA256.Create();
            var saltedPassword = password + user.Salt;
            var saltedhashedPassword = Convert.ToBase64String(sha.ComputeHash(Encoding.Unicode.GetBytes(saltedPassword)));

            return saltedhashedPassword == user.SaltedHashPassword;
        }
        #endregion

        #region Signing data
        public static string GenerateSignature(string data)
        {
            byte[] dataBytes = Encoding.Unicode.GetBytes(data);
            var sha = SHA256.Create();
            var hashedData = sha.ComputeHash(dataBytes);

            var rsa = RSA.Create();
            PublicKey = rsa.ToXmlString(false); // exclude private key

            var signer = new RSAPKCS1SignatureFormatter(rsa);
            signer.SetHashAlgorithm("SHA256");

            return Convert.ToBase64String(signer.CreateSignature(hashedData));
        }

        public static bool ValidateSignature(string data, string signature)
        {
            byte[] dataBytes = Encoding.Unicode.GetBytes(data);
            var sha = SHA256.Create();
            var hashedData = sha.ComputeHash(dataBytes);

            byte[] signatureBytes = Convert.FromBase64String(signature);
            var rsa = RSA.Create();
            rsa.FromXmlString(PublicKey);

            var checker = new RSAPKCS1SignatureDeformatter(rsa);
            checker.SetHashAlgorithm("SHA256");

            return checker.VerifySignature(hashedData, signatureBytes);
        }
        #endregion
    }
}