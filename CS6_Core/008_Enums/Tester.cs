using System;
using System.Linq;
using static System.Console;

namespace _008_Enums
{
    public class Tester
    {
        public void TestPerson()
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
            person.Country = "Hrvatska";
            person.Province = "Grad Zagreb";
            var childs = person.Children.OrderByDescending(d => d.DateOfBirth).Select(x => x.Name).ToArray();
            //var childs = (from child in person.Children
            //        orderby child.DateOfBirth descending
            //        select child.Name).ToArray();
            string message =$"Osoba ima {person.Children.Count} djece,";
            if(person.Children.Count > 0) message += $" koja se zovu: {String.Join(", ", childs)}";
            WriteLine(message);
            if(person.Children.Count > 0)
            {
                WriteLine("Ponovo djeca:");
                for(int i = 0; i < person.Children.Count; i++)
                    WriteLine($"\t{person.Children[i].Name}, rođen(a) {person.Children[i].DateOfBirth:d MMM yyyy}.");
            }       
            if(!String.IsNullOrEmpty(person.Address)) WriteLine($"Adresa: {person.Address}");
            if(!String.IsNullOrEmpty(person.Country)) WriteLine($"Zemlja: {person.Country}");
            if(!String.IsNullOrEmpty(person.Province)) WriteLine($"Province: {person.Province}");
            WriteLine($"Pozdrav: {person.Greeting}");
        }

        public void TestOperator()
        {
            Person harry = new Person("Harry");
            Person mary = new Person("Mary");
            Person baby1 = harry.Procreate(mary);
            Person baby2 = harry * mary;

            WriteNumberOfChildren(harry);
            WriteNumberOfChildren(mary);
        }

        private void WriteNumberOfChildren(Person person)
        {
            WriteLine($"{person.Name} has {person.Children.Count} children.");
        }
    }
}