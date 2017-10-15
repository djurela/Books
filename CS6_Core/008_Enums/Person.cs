using System;
using System.Collections.Generic;

namespace _008_Enums
{
    public partial class Person
    {
        public string Name;
        public DateTime DateOfBirth;
        public WondersEnum BucketList;
        public List<Person> Children;

        public Person()
        {
            Children = new List<Person>();
            mCountry = "Croatia";
        }

        public Person(string name)
        {
            Name = name;
            Children = new List<Person>();
        }
        public Person(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Children = new List<Person>();
        }
    }
}
