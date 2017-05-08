using System;
using static System.Console;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Tester tester = new Tester();
                tester.Test01();
            }
            catch(Exception excp)
            {
                WriteLine($"ERROR - {excp.Message}.");
            }
            finally
            {
                Write("Press any key to continue ...");
                ReadKey();
            }
        }
    }
}
