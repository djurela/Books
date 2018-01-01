using System;
using static System.Console;

namespace _012_Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunCryptography();
            //RunHashing();
            RunSigning();
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

        #region Hashing
        private static void RunHashing()
        {
            Write("Enter user name: ");
            string userName = ReadLine();
            Write("Enter password: ");
            string password = ReadLine();
            var user = Protector.Register(userName, password);
            WriteLine($"User name: {user.Name}");
            WriteLine($"Salt: {user.Salt}");
            WriteLine($"SaltedHashPassword : {user.SaltedHashPassword}");

            bool isCorrect = false;
            while(!isCorrect)
            {
                Write("Enter user name: ");
                string loginUserName = ReadLine();
                Write("Enter password: ");
                string loginPassword = ReadLine();
                if(Protector.CheckPassword(loginUserName, loginPassword))
                {
                    WriteLine("User name / password is valid");
                    isCorrect = true;
                }
                else
                    WriteLine("Invalid user name / password");
            }
        }
        #endregion

        #region Signing
        private static void RunSigning()
        {
            Write("Write some text to sign: ");
            string data = ReadLine();
            var signature = Protector.GenerateSignature(data);
            WriteLine($"Signature: {signature}");
            WriteLine("Public key used to check signature: ");
            WriteLine(Protector.PublicKey);

            if(Protector.ValidateSignature(data, signature))
                WriteLine("Signature is correct.");
            else
                WriteLine("Signature is invalid.");
        }
        #endregion
    }
}
