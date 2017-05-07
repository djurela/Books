using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace ConsoleApplication
{
    public class Tester
    {
        private class Person
        {
            public string Name;
            public int Age;
            public bool IsMale;

            public Person(string name, int age, bool isMale)
            {
                Name = name;
                Age = age;
                IsMale = isMale;
            }
        }
        public void TestDictonary()
        {
            WriteLine("Testing dictionary");
            Dictionary<int, Person> persons = MakePersons();
            
            //var query = persons.Where(person => person.Value.Age > 20 && person.Value.IsMale).OrderBy(person => person.Value.Age).ThenBy(person => person.Value.Name);
            var query = from person in persons
                        where person.Value.Age > 20 && person.Value.IsMale
                        orderby person.Value.Age, person.Value.Name
                        select person;
                        
            foreach(KeyValuePair<int, Person> person in query)
                WriteLine($"    {person.Key}: {person.Value.Name} ({person.Value.Age})");
        }
        private Dictionary<int, Person> MakePersons()
        {
            Dictionary<int, Person> persons = new Dictionary<int, Person>();
            persons.Add(1, new Person("Janko", 16, true));
            persons.Add(2, new Person("Matko", 87, true));
            persons.Add(3, new Person("Jana", 24, false));
            persons.Add(4, new Person("Mara", 50, false));
            persons.Add(5, new Person("Buba", 2, false));
            persons.Add(6, new Person("Zlatko", 36, true));
            
            return persons;
        }
    }
}