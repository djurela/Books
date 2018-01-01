using System;
using static System.Console;

namespace _012_Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunCryptography();
            RunHashing();
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
    }
}
