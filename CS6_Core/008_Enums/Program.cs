using System;
using static System.Console;

namespace _008_Enums
{
    [System.Flags]
    public enum WondersEnum
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

    class Program
    {
        #region Main
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person{Name = "Miš Miško", DateOfBirth = new DateTime(2003, 09, 19)};
                person.BucketList = WondersEnum.HangingGardens | WondersEnum.Mausoleum;
                WriteLine($"Osoba {person.Name} je rođena {person.DateOfBirth:d MMM yyyy}.");
                WriteLine($"Želi posjetiti: {person.BucketList}");
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
        #endregion
    }
}
