using System;
using System.Collections.Generic;

namespace _008_Enums
{
    public class Person
    {
        public string Name;
        public DateTime DateOfBirth;

        public WondersEnum BucketList;
        public List<Person> Children;

        public Person()
        {
            Children = new List<Person>();
        }
    }
}
