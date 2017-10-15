using System;

namespace _008_Enums
{
    public partial class Person
    {
        #region Members
        public string Address;
        public string Province { get; set; } = "Zagrebačka županija"; 
        private string mCountry;
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
    }
}