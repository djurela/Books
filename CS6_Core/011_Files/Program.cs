using System;
using static System.Console;

namespace _011_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tester tester = new Tester();
                tester.TestFile("/home/davor/Temp");
            }
            catch(Exception excp)
            {
                Console.WriteLine($"ERROR - {excp.Message}.");
            }
            finally
            {
                WriteLine("Done.");
            }
        }
    }
}
