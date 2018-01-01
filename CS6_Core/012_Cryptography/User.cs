using System;

namespace _012_Cryptography
{
    public class User
    {
        public string Name { get; set; }
        public string Salt { get; set; }
        public string SaltedHashPassword { get; set; }
    }
}