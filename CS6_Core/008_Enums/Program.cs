using System;
using static System.Console;

namespace _008_Enums
{
    #region Enums
    [System.Flags]
    public enum WondersEnum: byte
    {
        None = 0,
        GreatPyramid = 1,
        HangingGardens = 1 << 1,
        StatueOfZeus = 1 << 2,
        TempleOfArtemis = 1 << 3,
        Mausoleum = 1 << 4,
        Colossus = 1 << 5,
        Lighthouse = 1 << 6
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tester tester = new Tester();
                tester.TestPerson();
                //tester.TestOperator();
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
