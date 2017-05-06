using System;
using System.Linq;
using static System.Console;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("Linq examles");

            string[] names = new string[]{"Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed"};
            //var query = names.Where(new Func<string, bool>(NameLongerThanFour));
            //var query = names.Where(NameLongerThanFour);
            var query = names.Where(name => name.Length > 4).OrderBy(name => name.Length).ThenBy(name => name);
            foreach(var item in query)
                WriteLine($"  {item}");
        }

        private static bool NameLongerThanFour(string name)
        {
            return name.Length > 4;
        }
    }
}
