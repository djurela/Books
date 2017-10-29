using System;
using System.Text.RegularExpressions;

namespace Pact.CS6
{
    /*
    public class MyExtensions
    {
        public static bool IsValidEmail(string input)
        {
            return Regex.IsMatch(input, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
        }
    }
    */
    public static class MyExtensions
    {
        public static bool IsValidEmail(this string input)
        {
            return Regex.IsMatch(input, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
        }
    }
}