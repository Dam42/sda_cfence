using System;

namespace sda_cfence
{
    internal class Guest
    {
        private int PROPER_AGE = 18;

        //fields
        private string _firstName;

        //properties
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName { get; set; }

        public int YearOfBirth { get; set; }

        public void DumpInfo()
        {
            System.Console.WriteLine($"{this.FirstName} {this.LastName} is {2022 - this.YearOfBirth} years old");
        }

        public bool IsAdult => (DateTime.Now.Year) - YearOfBirth >= PROPER_AGE;

        public Guest(string FirstN = "", string LN = "", int age = 0)
        {
            this.FirstName = FirstN;
            this.LastName = LN;
            this.YearOfBirth = age;
        }
    }
}