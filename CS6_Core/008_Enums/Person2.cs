using System;

namespace _008_Enums
{
    public partial class Person
    {
        #region Members
        public string Address;
        public string Province { get; set; } = "Zagrebačka županija"; 
        public int AngerLevel;
        private string mCountry;
        #endregion

        #region Events
        public event EventHandler Shout;
        #endregion

        #region Properties
        public string Greeting => $"{Name} says 'Hello'!"; 

        public string Country
        {
            get => mCountry;
            set => mCountry = value;
        }
        #endregion

        #region Indexers
        public Person this[int index] 
        {
            get => Children[index]; 
            set => Children[index] = value;
        }
        #endregion

        #region Methods
        public Person Procreate(Person partner)
        {
            var baby = new Person("Baby", DateTime.Today);
            Children.Add(baby);
            partner.Children.Add(baby);
            return baby;
        }

        public void Poke()
        {
            AngerLevel++;
            if(AngerLevel >= 3 && Shout != null) Shout(this, EventArgs.Empty);
        }
        #endregion

        #region Operators
        public static Person operator *(Person p1, Person p2)
        {
            return p1.Procreate(p2);
        }
        #endregion
    }
}