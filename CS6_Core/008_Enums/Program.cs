using System;
using System.Linq;
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
                // Add person and its data
                Person person = new Person{Name = "Miš Miško", DateOfBirth = new DateTime(2003, 09, 19)};
                person.BucketList = WondersEnum.HangingGardens | WondersEnum.Mausoleum;
                WriteLine($"Osoba {person.Name} je rođena {person.DateOfBirth:d MMM yyyy}.");
                WriteLine($"Želi posjetiti: {person.BucketList}");
                // Add children
                person.Children.Add(new Person("Mišuljak", new DateTime(2015, 12, 24)));
                person.Children.Add(new Person(dateOfBirth : new DateTime(2016, 11, 21), name : "Mišulja"));
                person.Address = "Stenjevečka 38, Zagreb";
                var childs = person.Children.OrderByDescending(d => d.DateOfBirth).Select(x => x.Name).ToArray();
                //var childs = (from child in person.Children
                //        orderby child.DateOfBirth descending
                //        select child.Name).ToArray();
                string message =$"Osoba ima {person.Children.Count} djece,";
                if(person.Children.Count > 0) message += $" koja se zovu: {String.Join(", ", childs)}";
                WriteLine(message);
                if(!String.IsNullOrEmpty(person.Address)) WriteLine($"Adresa: {person.Address}");
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
