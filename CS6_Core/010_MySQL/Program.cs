using System;
using static System.Console;

namespace _010_MySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Database db = new Database();
                db.SelectPerson();
            }
            catch(Exception excp)
            {
                WriteLine($"ERROR - {excp.Message}.");
            }
            finally
            {
                WriteLine("Done.");
            }
        }
    }
}
