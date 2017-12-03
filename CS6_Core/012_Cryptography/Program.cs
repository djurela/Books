using System;
using static System.Console;

namespace _012_Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            RunCryptography();
        }

        #region Cryptography
        private static void RunCryptography()
        {
            Write("Enter message you want to encrypt: ");
            string message = Console.ReadLine();
            Write("Enter password: ");
            string password = ReadLine();
            string cryptoText = Protector.Encrypt(message, password);
            WriteLine($"Encrypeted test: {cryptoText}");
            string clearText = Protector.Decrypt(cryptoText, password);
            WriteLine($"decrypted text: {clearText}");
        }
        #endregion
    }
}
