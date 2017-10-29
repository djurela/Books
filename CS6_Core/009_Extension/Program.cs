using System;
using static System.Console;
using Pact.CS6;

namespace _009_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing extension methods");
            string email1 = "pamela@test.com";
            string email2 = "ian&@test.com";

            // WriteLine($"{email1} is valid email address: {MyExtensions.IsValidEmail(email1)}.");
            // WriteLine($"{email2} is valid email address: {MyExtensions.IsValidEmail(email2)}.");
            WriteLine($"{email1} is valid email address: {email1.IsValidEmail()}.");
            WriteLine($"{email2} is valid email address: {email2.IsValidEmail()}.");
        }
    }
}
